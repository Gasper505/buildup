/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.buildup.services;

import java.sql.Connection;
import java.sql.DriverManager;
import java.util.HashMap;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import net.sf.jasperreports.engine.JasperExportManager;
import net.sf.jasperreports.engine.JasperFillManager;
import net.sf.jasperreports.engine.JasperPrint;
import net.sf.jasperreports.engine.JasperReport;
import net.sf.jasperreports.engine.util.JRLoader;
import pe.edu.pucp.buildup.servlets.ServletOrdenesSalida;
import pe.edu.pucp.ta.config.DBManager;

/**
 *
 * @author jherson
 */
@WebService(serviceName = "ReporteOrdenes")
public class ReporteOrdenes {

    @WebMethod(operationName = "generarReporteOrdenes")
    public byte[] generarReporteOrdenes() {
        byte[] arreglo = null;
        try{
            //Referencia al archivo JASPER
            JasperReport reporte = (JasperReport)
                JRLoader.loadObjectFromFile(
            ServletOrdenesSalida.class.getResource("/pe/edu/pucp/buildup/reports/Ordenes.jasper")
                    .getFile());
 
            //Registramos el Driver
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Creamos el objeto Connection
            Connection con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);
            
            //Creamos un HashMap para enviar los parámetros
            HashMap hm = new HashMap();
            //hm.put("RUTA_SUBREPORTE1",rutaSubreporte1);
            //hm.put("RUTA_SUBREPORTE2",rutaSubreporte2);
            
            //Poblamos el reporte
            JasperPrint jp = JasperFillManager.fillReport
            (reporte, null, con);
            
            //Cerrar la conexion
            con.close();
            arreglo = JasperExportManager.exportReportToPdf(jp);
    }catch(Exception ex){
            System.out.println(ex.getMessage());
    }
        return arreglo;
    }
}
