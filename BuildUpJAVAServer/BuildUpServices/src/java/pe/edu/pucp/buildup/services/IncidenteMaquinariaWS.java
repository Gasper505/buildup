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
import pe.edu.pucp.ta.dao.IncidenteMaquinariaDAO;
import pe.edu.pucp.ta.model.IncidenteMaquinaria;
import pe.edu.pucp.ta.mysql.IncidenteMaquinariaMySQL;

/**
 *
 * @author Giohanny
 */
@WebService(serviceName = "IncidenteMaquinariaWS")
public class IncidenteMaquinariaWS {

    private IncidenteMaquinariaDAO daoIncidenteMaquinaria;
    public IncidenteMaquinariaWS(){
        daoIncidenteMaquinaria = new IncidenteMaquinariaMySQL();
    }
    @WebMethod(operationName = "listarIncidenteMaquinaria")
    public ArrayList<IncidenteMaquinaria> listarIncidenteMaquinaria() {
        ArrayList<IncidenteMaquinaria> incidenteMaquinarias = new ArrayList<>();
        try{
            incidenteMaquinarias =daoIncidenteMaquinaria.listar();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return incidenteMaquinarias;
    }
    
    @WebMethod(operationName = "insertarIncidenteMaquinaria")
    public int insertarIncidenteMaquinaria(@WebParam(name="incidenteMaquinaria") IncidenteMaquinaria incidenteMaquinaria) {
        int resultado =0;
        try{
            resultado = daoIncidenteMaquinaria.insertar(incidenteMaquinaria);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "insertarProblema")
    public int insertarProblema(@WebParam(name="incidenteMaquinaria") IncidenteMaquinaria incidenteMaquinaria) {
        int resultado =0;
        try{
            resultado = daoIncidenteMaquinaria.insertarProblema(incidenteMaquinaria);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "insertarRespuesta")
    public int insertarRespuesta(@WebParam(name="incidenteMaquinaria") IncidenteMaquinaria incidenteMaquinaria) {
        int resultado =0;
        try{
            resultado = daoIncidenteMaquinaria.insertarRespuesta(incidenteMaquinaria);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "actualizarIncidenteMaquinaria")
    public int actualizarIncidenteMaquinaria(@WebParam(name = "incidenteMaquinaria") IncidenteMaquinaria incidenteMaquinaria) {
        int resultado = 0;
        try{
            resultado = daoIncidenteMaquinaria.actualizar(incidenteMaquinaria);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "eliminarIncidenteMaquinaria")
    public int eliminarIncidenteMaquinaria(@WebParam(name = "idIncidenteMaquinaria") int idIncidenteMaquinaria) {
        int resultado = 0;
        try{
            resultado = daoIncidenteMaquinaria.eliminar(idIncidenteMaquinaria);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
}
