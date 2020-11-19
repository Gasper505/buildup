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
import pe.edu.pucp.ta.dao.LineaProduccionDAO;
import pe.edu.pucp.ta.model.LineaProduccion;
import pe.edu.pucp.ta.mysql.LineaProduccionMySQL;

/**
 *
 * @author Giohanny
 */
@WebService(serviceName = "LineaProduccionWS")
public class LineaProduccionWS {

        private LineaProduccionDAO daoLineaProduccion;
    public LineaProduccionWS(){
        daoLineaProduccion = new LineaProduccionMySQL();
    }
    @WebMethod(operationName = "listarPorNombreLineaProduccion")
    public ArrayList<LineaProduccion> listarPorNombreLineaProduccion(@WebParam(name="nombre") String nombre){
        ArrayList<LineaProduccion> lineaProducciones = new ArrayList<>();
        try{
            lineaProducciones =daoLineaProduccion.listarPorNombre(nombre);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return lineaProducciones;
    }
    
    @WebMethod(operationName = "insertarLineaProduccion")
    public int insertarLineaProduccion(@WebParam(name="lineaProduccion") LineaProduccion lineaProduccion) {
        int resultado =0;
        try{
            resultado = daoLineaProduccion.insertar(lineaProduccion);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "actualizarLineaProduccion")
    public int actualizarLineaProduccion(@WebParam(name = "idlineaProduccion") int idlineaProduccion,int idTipoLadrillo) {
        int resultado = 0;
        try{
            resultado = daoLineaProduccion.actualizar(idlineaProduccion,idTipoLadrillo);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "eliminarLineaProduccion")
    public int eliminarLineaProduccion(@WebParam(name = "idLineaProduccion") int idLineaProduccion) {
        int resultado = 0;
        try{
            resultado = daoLineaProduccion.eliminar(idLineaProduccion);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
}
