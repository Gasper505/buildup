/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.buildup.services;

import java.sql.Connection;
import java.sql.DriverManager;
import java.util.Date;
import java.util.HashMap;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import net.sf.jasperreports.engine.JasperExportManager;
import net.sf.jasperreports.engine.JasperFillManager;
import net.sf.jasperreports.engine.JasperPrint;
import net.sf.jasperreports.engine.JasperReport;
import net.sf.jasperreports.engine.util.JRLoader;
import pe.edu.pucp.buildup.servlets.ServletIncidencia;
import pe.edu.pucp.ta.config.DBManager;

/**
 *
 * @author Luis Gaspar
 */
@WebService(serviceName = "ReportesIncidencia")
public class ReportesIncidencia {

    @WebMethod(operationName = "generarReporteIncidencia")
    public byte[] generarReporteIncidencia() {
        byte[] arreglo = null;
        try{
            //Referencia al archivo JASPER
            JasperReport reporte = (JasperReport)
                JRLoader.loadObjectFromFile(
            ServletIncidencia.class.getResource("/pe/edu/pucp/buildup/reports/ReporteIncidencia.jasper")
                    .getFile());
 
            //Obtener la ruta del subreporte1
            String rutaSubreporte1 = 
               ServletIncidencia.class.getResource("/pe/edu/pucp/buildup/reports/SubReporte1.jasper")
                    .getPath();
            
            //Obtener la ruta del subreporte2
            String rutaSubreporte2 = 
               ServletIncidencia.class.getResource("/pe/edu/pucp/buildup/reports/SubReporte2.jasper")
                    .getPath();
            
            //Registramos el Driver
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Creamos el objeto Connection
            Connection con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);
            
            //Creamos un HashMap para enviar los parámetros
            HashMap hm = new HashMap();
            hm.put("RUTA_SUBREPORTE1",rutaSubreporte1);
            hm.put("RUTA_SUBREPORTE2",rutaSubreporte2);
            
            //Poblamos el reporte
            JasperPrint jp = JasperFillManager.fillReport
            (reporte, hm, con);
            
            //Cerrar la conexion
            con.close();
            arreglo = JasperExportManager.exportReportToPdf(jp);
    }catch(Exception ex){
            System.out.println(ex.getMessage());
    }
        return arreglo;
    }
        

}
