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
import pe.edu.pucp.ta.dao.OperarioDAO;
import pe.edu.pucp.ta.model.Operario;
import pe.edu.pucp.ta.mysql.OperarioMySQL;

/**
 *
 * @author Giohanny
 */
@WebService(serviceName = "OperarioWS")
public class OperarioWS {

    private OperarioDAO daoOperario;
    public OperarioWS(){
        daoOperario = new OperarioMySQL();
    }
    @WebMethod(operationName = "listarOperario")
    public ArrayList<Operario> listarOperario() {
        ArrayList<Operario> operarios = new ArrayList<>();
        try{
            operarios =daoOperario.listar();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return operarios;
    }
    
    @WebMethod(operationName = "insertarOperario")
    public int insertarOperario(@WebParam(name="operario") Operario operario) {
        int resultado =0;
        try{
            resultado = daoOperario.insertar(operario);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "actualizarEstadoOperario")
    public int actualizarEstadoOperario(@WebParam(name = "idOp") int idOp,@WebParam(name = "activo")boolean activo ) {
        int resultado = 0;
        try{
            resultado = daoOperario.actualizar_estado(idOp, activo);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "eliminarOperario")
    public int eliminarOperario(@WebParam(name = "idOperario") int idOperario) {
        int resultado = 0;
        try{
            resultado = daoOperario.eliminar(idOperario);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "modificarOperario")
    public int modificarOperario(@WebParam(name = "operario") Operario op ) {
        int resultado = 0;
        try{
            resultado = daoOperario.modificar(op);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
}
