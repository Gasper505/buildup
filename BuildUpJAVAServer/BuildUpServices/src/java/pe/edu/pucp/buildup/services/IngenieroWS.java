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
import pe.edu.pucp.ta.dao.IngenieroDAO;
import pe.edu.pucp.ta.model.Ingeniero;
import pe.edu.pucp.ta.mysql.IngenieroMySQL;

/**
 *
 * @author Giohanny
 */
@WebService(serviceName = "IngenieroWS")
public class IngenieroWS {
private IngenieroDAO daoIngeniero;
    public IngenieroWS(){
        daoIngeniero = new IngenieroMySQL();
    }
    @WebMethod(operationName = "listarIngeniero")
    public ArrayList<Ingeniero> listarIngeniero() {
        ArrayList<Ingeniero> ingenieros = new ArrayList<>();
        try{
            ingenieros =daoIngeniero.listar();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return ingenieros;
    }
    
    @WebMethod(operationName = "insertarIngeniero")
    public int insertarIngeniero(@WebParam(name="ingeniero") Ingeniero ingeniero) {
        int resultado =0;
        try{
            resultado = daoIngeniero.insertar(ingeniero);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "actualizarIngeniero")
    public int actualizarIngeniero(@WebParam(name = "ingeniero") Ingeniero ingeniero) {
        int resultado = 0;
        try{
            resultado = daoIngeniero.actualizar(ingeniero);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "eliminarIngeniero")
    public int eliminarIngeniero(@WebParam(name = "idIngeniero") int idIngeniero) {
        int resultado = 0;
        try{
            resultado = daoIngeniero.eliminar(idIngeniero);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
}
