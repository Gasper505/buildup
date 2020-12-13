/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.buildup.services;

import java.awt.Image;
import java.sql.Connection;
import java.sql.DriverManager;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.HashMap;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import javax.swing.ImageIcon;
import net.sf.jasperreports.engine.JasperExportManager;
import net.sf.jasperreports.engine.JasperFillManager;
import net.sf.jasperreports.engine.JasperPrint;
import net.sf.jasperreports.engine.JasperReport;
import net.sf.jasperreports.engine.util.JRLoader;
import pe.edu.pucp.buildup.servlets.ServletProdDiaria;
import pe.edu.pucp.buildup.servlets.ServletProdMes;
import pe.edu.pucp.ta.config.DBManager;

/**
 *
 * @author Diego Alonso
 */
@WebService(serviceName = "ReportesProduccion")
public class ReportesProduccion {

    @WebMethod(operationName = "generarReporteProduccionDiario")
    public byte[] generarReporteProduccionDiario(@WebParam(name = "fecha") Date fecha) {
        byte[] arreglo = null;
        try{
            //Referencia al archivo Jasper
            JasperReport reporteProd = (JasperReport)JRLoader.loadObjectFromFile(
                    ServletProdDiaria.class.getResource("/pe/edu/pucp/buildup/reports/ReporteProduccionDia.jasper").getFile());
            
            
            //Creamos un HashMap para enviar los parámetros del reporte
            HashMap hm = new HashMap();
            hm.put("FECHA", fecha);
            
            
            //Registramos el Driver
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Creamos el objeto Connection
            Connection con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            //Poblamos el reporte
            JasperPrint jp = JasperFillManager.fillReport(reporteProd, null, con);
            
            //Cerrar la conexion
            con.close();
            arreglo = JasperExportManager.exportReportToPdf(jp);
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return arreglo;
    }
    
    @WebMethod(operationName = "generarReporteProduccionMensual")
    public byte[] generarReporteProduccionMensual(@WebParam(name = "mes") int mes, @WebParam(name = "anho") int anho) {
        byte[] arreglo = null;
        try{
            //Referencia al archivo Jasper
                JasperReport reporte = (JasperReport)JRLoader.loadObjectFromFile(ServletProdMes.class.getResource("/pe/edu/pucp/buildup/reports/ReporteProduccionMes.jasper").getFile());
            
            
            //Registro del driver
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Creación del objeto Connection
            Connection con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            
            
            //Creamos un HashMap para enviar los parámetros del reporte
            HashMap hm = new HashMap();
            hm.put("MES_REPORTE", mes);
            hm.put("ANHO_REPORTE", anho);
            
            //Población del reporte
            JasperPrint jp = JasperFillManager.fillReport(reporte, hm, con);
            
            
            //Cierre de conexión
            con.close();
            
            
            //Convertirlo a arreglo bytes
            arreglo = JasperExportManager.exportReportToPdf(jp);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return arreglo;
    }
}
