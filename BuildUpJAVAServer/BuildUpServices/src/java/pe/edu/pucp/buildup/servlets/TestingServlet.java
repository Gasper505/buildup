/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.buildup.servlets;

import java.awt.Image;
import java.io.IOException;
import java.io.PrintWriter;
import java.sql.Connection;
import java.sql.DriverManager;
import java.util.HashMap;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.swing.ImageIcon;
import net.sf.jasperreports.engine.JasperExportManager;
import net.sf.jasperreports.engine.JasperFillManager;
import net.sf.jasperreports.engine.JasperPrint;
import net.sf.jasperreports.engine.JasperReport;
import net.sf.jasperreports.engine.util.JRLoader;
import pe.edu.pucp.ta.config.DBManager;

/**
 *
 * @author Diego Alonso
 */
public class TestingServlet extends HttpServlet {

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
            //Referencia al archivo Jasper
            JasperReport reporte = (JasperReport)JRLoader.loadObjectFromFile(TestingServlet.class.getResource("/pe/edu/pucp/buildup/reportes/TestingReport.jasper").getFile());
            
            
            //Referencia a la ruta de la imagen
            String rutaLogo = TestingServlet.class.getResource("/pe/edu/pucp/buildup/images/foto.jpg").getPath();
            //Generación del objeto Image
            ImageIcon icono = new ImageIcon(rutaLogo);
            Image imagen = icono.getImage();
            
            
            //Registro del driver
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Creación del objeto Connection
            Connection con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            
            
            //Creamos un HashMap para enviar los parámetros del reporte
            HashMap hm = new HashMap();
            hm.put("AUTOR", "Diego Ramírez");
            hm.put("FOTO_AUTOR", imagen);
            
            
            //Población del reporte
            JasperPrint jp = JasperFillManager.fillReport(reporte, hm, con);
            
            
            //Cierre de conexión
            con.close();
            
            
            //Mostramos el reporte a nivel web
            JasperExportManager.exportReportToPdfStream(jp, response.getOutputStream());
        }
        catch(Exception ex){
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
