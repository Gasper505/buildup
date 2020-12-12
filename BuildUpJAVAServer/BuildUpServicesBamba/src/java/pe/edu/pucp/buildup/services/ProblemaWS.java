/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.buildup.services;

import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.ta.dao.ProblemaDAO;
import pe.edu.pucp.ta.model.Problema;
import pe.edu.pucp.ta.mysql.ProblemaMySQL;

/**
 *
 * @author Giohanny
 */
@WebService(serviceName = "ProblemaWS")
public class ProblemaWS {

    private ProblemaDAO daoProblema;
    public ProblemaWS(){
        daoProblema = new ProblemaMySQL();
    }
    @WebMethod(operationName = "listarProblema")
    public ArrayList<Problema> listarProblema() {
        ArrayList<Problema> problemas = new ArrayList<>();
        try{
            problemas =daoProblema.listar();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return problemas;
    }
    
    @WebMethod(operationName = "insertarProblema")
    public int insertarProblema(@WebParam(name="problema") Problema problema) {
        int resultado =0;
        try{
            resultado = daoProblema.insertar(problema);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "actualizarProblema")
    public int actualizarProblema(@WebParam(name = "problema") Problema problema) {
        int resultado = 0;
        try{
            resultado = daoProblema.actualizar(problema);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "eliminarProblema")
    public int eliminarProblema(@WebParam(name = "idProblema") int idProblema) {
        int resultado = 0;
        try{
            resultado = daoProblema.eliminar(idProblema);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
}
