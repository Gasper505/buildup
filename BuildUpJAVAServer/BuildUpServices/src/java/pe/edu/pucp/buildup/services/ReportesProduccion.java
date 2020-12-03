/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.buildup.services;

import java.awt.Image;
import java.sql.Connection;
import java.sql.DriverManager;
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
import pe.edu.pucp.buildup.servlets.ServletProduccionDiario;
import pe.edu.pucp.buildup.servlets.ServletProduccionMensual;
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
            JasperReport reporte = (JasperReport)JRLoader.loadObjectFromFile(ServletProduccionDiario.class.getResource("/pe/edu/pucp/buildup/reports/ReporteProduccionDiario.jasper").getFile());
            
            
            //Registro del driver
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Creación del objeto Connection
            Connection con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            
            
            //Creamos un HashMap para enviar los parámetros del reporte
            HashMap hm = new HashMap();
            hm.put("fecha", fecha);
            
            
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
    
    @WebMethod(operationName = "generarReporteProduccionMensual")
    public byte[] generarReporteProduccionMensual(@WebParam(name = "mes") int mes) {
        byte[] arreglo = null;
        try{
            //Referencia al archivo Jasper
            JasperReport reporte = (JasperReport)JRLoader.loadObjectFromFile(ServletProduccionMensual.class.getResource("/pe/edu/pucp/buildup/reports/ReporteProduccionMensual.jasper").getFile());
            
            
            //Registro del driver
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Creación del objeto Connection
            Connection con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            
            
            //Creamos un HashMap para enviar los parámetros del reporte
            HashMap hm = new HashMap();
            hm.put("mes", mes);
            
            
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
