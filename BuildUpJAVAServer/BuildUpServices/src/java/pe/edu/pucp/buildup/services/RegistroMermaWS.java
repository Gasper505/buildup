/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.buildup.services;

import java.sql.Date;
import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.ta.dao.RegistroMermaDAO;
import pe.edu.pucp.ta.model.RegistroMerma;
import pe.edu.pucp.ta.mysql.RegistroMermaMySQL;

/**
 *
 * @author Giohanny
 */
@WebService(serviceName = "RegistroMermaWS")
public class RegistroMermaWS {

    private RegistroMermaDAO daoRegistroMerma;
    public RegistroMermaWS(){
        daoRegistroMerma = new RegistroMermaMySQL();
    }
    @WebMethod(operationName = "listarRegistroMerma")
    public ArrayList<RegistroMerma> listarRegistroMerma() {
        ArrayList<RegistroMerma> registroMermas = new ArrayList<>();
        try{
            registroMermas =daoRegistroMerma.listar();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return registroMermas;
    }
    
    @WebMethod(operationName = "listarRegistrosMermasPorSupervisorYRangoFechas")
    public ArrayList<RegistroMerma> listarRegistrosMermaPorSupervisorYRangoFechas(@WebParam(name="nombreSup")String nombreSup, 
            @WebParam(name="fechaInicial")Date fechaInicial, @WebParam(name="fechaFin")Date fechaFin) {
        ArrayList<RegistroMerma> registroMermas = new ArrayList<>();
        try{
            registroMermas = daoRegistroMerma.listarRegistrosMermasPorSupervisorYRangoFechas(nombreSup,new java.sql.Date(fechaInicial.getTime()), new java.sql.Date(fechaFin.getTime()));
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return registroMermas;
    }
    
    @WebMethod(operationName = "insertarRegistroMerma")
    public int insertarRegistroMerma(@WebParam(name="registroMerma") RegistroMerma registroMerma) {
        int resultado =0;
        try{
            resultado = daoRegistroMerma.insertar(registroMerma);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "actualizarRegistroMerma")
    public int actualizarRegistroMerma(@WebParam(name = "registroMerma") RegistroMerma registroMerma) {
        int resultado = 0;
        try{
            resultado = daoRegistroMerma.actualizar(registroMerma);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "eliminarRegistroMerma")
    public int eliminarRegistroMerma(@WebParam(name = "idRegistroMerma") int idRegistroMerma) {
        int resultado = 0;
        try{
            resultado = daoRegistroMerma.eliminar(idRegistroMerma);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
}
