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
import pe.edu.pucp.ta.dao.InsumoDAO;
import pe.edu.pucp.ta.model.Insumo;
import pe.edu.pucp.ta.mysql.InsumoMySQL;

/**
 *
 * @author Giohanny
 */
@WebService(serviceName = "InsumoWS")
public class InsumoWS {
private InsumoDAO daoInsumo;
    public InsumoWS(){
        daoInsumo = new InsumoMySQL();
    }
    @WebMethod(operationName = "listarInsumo")
    public ArrayList<Insumo> listarInsumo() {
        ArrayList<Insumo> insumos = new ArrayList<>();
        try{
            insumos =daoInsumo.listar();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return insumos;
    }
    
    @WebMethod(operationName = "insertarInsumo")
    public int insertarInsumo(@WebParam(name="insumo") Insumo insumo) {
        int resultado =0;
        try{
            resultado = daoInsumo.insertar(insumo);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "actualizarInsumo")
    public int actualizarInsumo(@WebParam(name = "insumo") Insumo insumo) {
        int resultado = 0;
        try{
            resultado = daoInsumo.actualizar(insumo);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "eliminarInsumo")
    public int eliminarInsumo(@WebParam(name = "idInsumo") int idInsumo) {
        int resultado = 0;
        try{
            resultado = daoInsumo.eliminar(idInsumo);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
}
