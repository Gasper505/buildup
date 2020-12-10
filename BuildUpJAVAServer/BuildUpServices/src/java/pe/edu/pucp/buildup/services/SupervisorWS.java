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
import pe.edu.pucp.ta.dao.SupervisorDAO;
import pe.edu.pucp.ta.model.LineaProduccion;
import pe.edu.pucp.ta.model.Supervisor;
import pe.edu.pucp.ta.mysql.SupervisorMySQL;

/**
 *
 * @author Giohanny
 */
@WebService(serviceName = "SupervisorWS")
public class SupervisorWS {

    private SupervisorDAO daoSupervisor;
    public SupervisorWS(){
        daoSupervisor = new SupervisorMySQL();
    }
    @WebMethod(operationName = "listarSupervisor")
    public ArrayList<Supervisor> listarSupervisor() {
        ArrayList<Supervisor> supervisores = new ArrayList<>();
        try{
            supervisores =daoSupervisor.listar();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return supervisores;
    }
    
    @WebMethod(operationName = "insertarSupervisor")
    public int insertarSupervisor(@WebParam(name="supervisor") Supervisor supervisor, @WebParam(name="username") String username, @WebParam(name="password") String password) {
        int resultado =0;
        try{
            resultado = daoSupervisor.insertar(supervisor,username,password);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "actualizarSupervisor")
    public int actualizarSupervisor(@WebParam(name = "supervisor") Supervisor supervisor) {
        int resultado = 0;
        try{
            resultado = daoSupervisor.actualizar(supervisor);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "eliminarSupervisor")
    public int eliminarSupervisor(@WebParam(name = "idSupervisor") int idSupervisor) {
        int resultado = 0;
        try{
            resultado = daoSupervisor.eliminar(idSupervisor);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
        @WebMethod(operationName = "obtenerLineaProduccionSupervisor")
    public LineaProduccion obtenerLineaProduccionSupervisor(@WebParam(name = "idSupervisor") int idSupervisor ) {
        LineaProduccion lineaProd=new LineaProduccion();
        try{
            lineaProd = daoSupervisor.obtener_linea_produccion(idSupervisor);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return lineaProd;
    }
    
    
}
