/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.buildup.servlets;

import java.io.IOException;
import java.io.PrintWriter;
import java.sql.Connection;
import java.sql.DriverManager;
import java.util.HashMap;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import net.sf.jasperreports.engine.JasperExportManager;
import net.sf.jasperreports.engine.JasperFillManager;
import net.sf.jasperreports.engine.JasperPrint;
import net.sf.jasperreports.engine.JasperReport;
import net.sf.jasperreports.engine.util.JRLoader;
import pe.edu.pucp.ta.config.DBManager;

/**
 *
 * @author Giohanny
 */
public class ServletMaquinaria extends HttpServlet {

    protected void processRequest(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        try{
            //Referencia al archivo Jasper
            JasperReport reporteMaq = (JasperReport) JRLoader.loadObjectFromFile(
                    ServletMaquinaria.class.getResource("/pe/edu/pucp/buildup/reports/ReporteMaquinaria.jasper").getFile()); 
            String rutasubrepInci = ServletMaquinaria.class.getResource("/pe/edu/pucp/buildup/reports/IncidenteMaquinaria.jasper").getPath(); 
            String rutasubrepGraf = ServletMaquinaria.class.getResource("/pe/edu/pucp/buildup/reports/GraficoMaquinarias.jasper").getPath(); 
         
            
            HashMap hm = new HashMap();
            hm.put("RUTA_SUBREPORTE",rutasubrepInci);
            hm.put("RUTA_SUBREPGRAF",rutasubrepGraf);
            
        //Registramos el Driver
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Creamos el objeto Connection
            Connection con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);
            //Poblamos el reporte
            JasperPrint jp = JasperFillManager.fillReport
            (reporteMaq, hm, con);
            
            //Cerrar la conexion
            con.close();
            
            //Mostramos el reporte a nivel web
            JasperExportManager.exportReportToPdfStream(jp, response.getOutputStream());
            
        }catch (Exception ex){
            System.out.println(ex.getMessage());
        }
        
            
    }

    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }

    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }

    @Override
    public String getServletInfo() {
        return "Short description";
    }// </editor-fold>

}
