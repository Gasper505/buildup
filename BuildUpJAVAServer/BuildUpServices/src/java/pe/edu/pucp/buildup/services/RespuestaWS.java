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
import pe.edu.pucp.ta.dao.RespuestaDAO;
import pe.edu.pucp.ta.model.Respuesta;
import pe.edu.pucp.ta.mysql.RespuestaMySQL;

/**
 *
 * @author Giohanny
 */
@WebService(serviceName = "RespuestaWS")
public class RespuestaWS {

    private RespuestaDAO daoRespuesta;
    public RespuestaWS(){
        daoRespuesta = new RespuestaMySQL();
    }
    @WebMethod(operationName = "listarRespuesta")
    public ArrayList<Respuesta> listarRespuesta() {
        ArrayList<Respuesta> respuestas = new ArrayList<>();
        try{
            respuestas =daoRespuesta.listar();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return respuestas;
    }
    
    @WebMethod(operationName = "insertarRespuesta")
    public int insertarRespuesta(@WebParam(name="respuesta") Respuesta respuesta) {
        int resultado =0;
        try{
            resultado = daoRespuesta.insertar(respuesta);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "actualizarRespuesta")
    public int actualizarRespuesta(@WebParam(name = "respuesta") Respuesta respuesta) {
        int resultado = 0;
        try{
            resultado = daoRespuesta.actualizar(respuesta);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "eliminarRespuesta")
    public int eliminarRespuesta(@WebParam(name = "idRespuesta") int idRespuesta) {
        int resultado = 0;
        try{
            resultado = daoRespuesta.eliminar(idRespuesta);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
}
