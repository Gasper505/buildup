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
            ordenInsumos = daoOrdenInsumos.listar_por_fecha(new java.sql.Date(fechaInicio.getTime()), new java.sql.Date(fechaFin.getTime()));
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
    @WebMethod(operationName = "modificarOrdenInsumos")
    public int modificarOrdenInsumos(@WebParam(name = "ordenInsumo") OrdenInsumos ordenInsumo) {
        int resultado = 0;
        try{
            resultado = daoOrdenInsumos.modificar(ordenInsumo);
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
    @WebMethod(operationName = "aceptarOrdenInsumos")
    public int aceptarOrdenInsumos(@WebParam(name = "idOrdenInsumos") int idOrdenInsumos) {
        int resultado = 0;
        try{
            resultado = daoOrdenInsumos.aceptar(idOrdenInsumos);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "rechazarOrdenInsumos")
    public int rechazarOrdenInsumos(@WebParam(name = "idOrdenInsumos") int idOrdenInsumos) {
        int resultado = 0;
        try{
            resultado = daoOrdenInsumos.rechazar(idOrdenInsumos);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
}
