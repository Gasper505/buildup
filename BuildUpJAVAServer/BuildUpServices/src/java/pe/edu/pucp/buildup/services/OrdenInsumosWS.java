/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.buildup.services;

import java.util.ArrayList;
import java.util.Date;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.ta.dao.OrdenInsumosDAO;
import pe.edu.pucp.ta.model.OrdenInsumos;
import pe.edu.pucp.ta.mysql.OrdenInsumosMySQL;

/**
 *
 * @author Giohanny
 */
@WebService(serviceName = "OrdenInsumosWS")
public class OrdenInsumosWS {

    /**
     * This is a sample web service operation
     */
        private OrdenInsumosDAO daoOrdenInsumos;
    public OrdenInsumosWS(){
        daoOrdenInsumos = new OrdenInsumosMySQL();
    }
    @WebMethod(operationName = "listarOrdenInsumos")
    public ArrayList<OrdenInsumos> listarOrdenInsumos() {
        ArrayList<OrdenInsumos> ordenInsumos = new ArrayList<>();
        try{
            ordenInsumos =daoOrdenInsumos.listar();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return ordenInsumos;
    }
    @WebMethod(operationName = "listarOrdenInsumosPorRangoFecha")
    public ArrayList<OrdenInsumos> listarOrdenInsumosPorRangoFecha(@WebParam(name="fechaInicio") Date fechaInicio,@WebParam(name="fechaFin") Date fechaFin) {
        ArrayList<OrdenInsumos> ordenInsumos = new ArrayList<>();
        try{
            ordenInsumos =daoOrdenInsumos.listar_por_fecha(fechaFin, fechaFin);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return ordenInsumos;
    }
    
    @WebMethod(operationName = "insertarOrdenInsumos")
    public int insertarOrdenInsumos(@WebParam(name="ordenInsumo") OrdenInsumos ordenInsumo) {
        int resultado =0;
        try{
            resultado = daoOrdenInsumos.insertar(ordenInsumo);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "actualizarOrdenInsumos")
    public int actualizarOrdenInsumos(@WebParam(name = "ordenInsumo") OrdenInsumos ordenInsumo) {
        int resultado = 0;
        try{
            resultado = daoOrdenInsumos.actualizar(ordenInsumo);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "eliminarOrdenInsumos")
    public int eliminarOrdenInsumos(@WebParam(name = "idOrdenInsumos") int idOrdenInsumos) {
        int resultado = 0;
        try{
            resultado = daoOrdenInsumos.eliminar(idOrdenInsumos);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
}
