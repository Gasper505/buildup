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
 * @author Luis Gaspar
 */
public class ServletIncidencia extends HttpServlet {

    /**
     * Processes requests for both HTTP <code>GET</code> and <code>POST</code>
     * methods.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    protected void processRequest(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
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
            
            //Mostramos el reporte a nivel web
            JasperExportManager.exportReportToPdfStream(jp, response.getOutputStream());
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }

        
        
    }

    // <editor-fold defaultstate="collapsed" desc="HttpServlet methods. Click on the + sign on the left to edit the code.">
    /**
     * Handles the HTTP <code>GET</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }

    /**
     * Handles the HTTP <code>POST</code> method.
     *
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        processRequest(request, response);
    }

    /**
     * Returns a short description of the servlet.
     *
     * @return a String containing servlet description
     */
    @Override
    public String getServletInfo() {
        return "Short description";
    }// </editor-fold>

}
