
package pe.edu.pucp.buildup.services;

import java.util.ArrayList;
import java.util.Date;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.ta.dao.OrdenSalidaDAO;
import pe.edu.pucp.ta.model.OrdenSalida;
import pe.edu.pucp.ta.mysql.OrdenSalidaMySQL;

@WebService(serviceName = "OrdenSalidaWS")
public class OrdenSalidaWS {

    private OrdenSalidaDAO daoOrdenSalida;
    
    public OrdenSalidaWS(){
        daoOrdenSalida = new OrdenSalidaMySQL();
    }
    
    @WebMethod(operationName = "insertarOrdenSalida")
    public int insertarOrdenSalida(@WebParam(name = "ordenSalida") OrdenSalida ordenSalida) {
        int resultado = 0;
        try{
            resultado = daoOrdenSalida.insertar(ordenSalida);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "actualizarOrdenSalida")
    public int actualizarOrdenSalida(@WebParam(name = "ordenSalida") OrdenSalida ordenSalida) {
        int resultado = 0;
        try{
            resultado = daoOrdenSalida.actualizar(ordenSalida);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarOrdenSalida")
    public int eliminarOrdenSalida(@WebParam(name = "idOrdenSalida") int idOrdenSalida) {
        int resultado = 0;
        try{
            resultado = daoOrdenSalida.eliminar(idOrdenSalida);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarOrdenesSalida")
    public ArrayList<OrdenSalida> listarOrdenesSalida() {
        ArrayList<OrdenSalida> ordenes = new ArrayList<>();
        try{
            ordenes = daoOrdenSalida.listar();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return ordenes;
    }
    
    @WebMethod(operationName = "listarOrdenesSalidaConParametros")
    public ArrayList<OrdenSalida> listarOrdenesSalidaConParametros(@WebParam(name = "nombreOperario") String nombreOperario, @WebParam(name = "fechaRegistro") Date fechaRegistro) {
        ArrayList<OrdenSalida> ordenes = new ArrayList<>();
        try{
            ordenes = daoOrdenSalida.listarOrdenesSalidaConParametros(nombreOperario, new java.sql.Date(fechaRegistro.getTime()));
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return ordenes;
    }
    
}
