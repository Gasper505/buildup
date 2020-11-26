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
import pe.edu.pucp.ta.dao.PlanProduccionDAO;
import pe.edu.pucp.ta.model.PlanProduccion;
import pe.edu.pucp.ta.mysql.PlanProduccionMySQL;

/**
 *
 * @author Luis Gaspar
 */
@WebService(serviceName = "PlanProduccionWS")
public class PlanProduccionWS {

    private PlanProduccionDAO daoPlan;
    
    public PlanProduccionWS(){
        daoPlan = new PlanProduccionMySQL();
    }
    
     @WebMethod(operationName = "insertarPlanProduccion")
    public int insertarPlanProduccion(@WebParam(name = "planProduccion") PlanProduccion planProduccion) {
        int resultado = 0;
        try{
            resultado = daoPlan.insertar(planProduccion);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "actualizarPlanProduccion")
    public int actualizarPlanProduccion(@WebParam(name = "planProduccion") PlanProduccion planProduccion) {
        int resultado = 0;
        try{
            resultado = daoPlan.actualizar(planProduccion);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarPlanProduccion")
    public int eliminarPlanProduccion(@WebParam(name = "idPlanProduccion") int idPlanProduccion) {
        int resultado = 0;
        try{
            resultado = daoPlan.eliminar(idPlanProduccion);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarPlanesProduccion")
    public ArrayList<PlanProduccion> listarPlanesProduccion() {
        ArrayList<PlanProduccion> planes = new ArrayList<>();
        try{
            planes = daoPlan.listar();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return planes;
    }
}
