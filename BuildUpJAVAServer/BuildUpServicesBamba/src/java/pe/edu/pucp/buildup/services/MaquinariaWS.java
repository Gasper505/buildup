
package pe.edu.pucp.buildup.services;

import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.ta.dao.MaquinariaDAO;
import pe.edu.pucp.ta.model.Maquinaria;
import pe.edu.pucp.ta.mysql.MaquinariaMySQL;

@WebService(serviceName = "MaquinariaWS")
public class MaquinariaWS {
    
    private MaquinariaDAO daoMaquinaria;
    
    public MaquinariaWS(){
        daoMaquinaria = new MaquinariaMySQL();
    }

    @WebMethod(operationName = "actualizarMaquinaria")
    public int actualizarMaquinaria(@WebParam(name = "idMaquinaria") int idMaquinaria,@WebParam(name = "nuevo") boolean nuevo ) {
        int result = 0;
        try{
            result = daoMaquinaria.actualizar(idMaquinaria, nuevo);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return result;
    }
    @WebMethod(operationName = "modificarMaquinaria")
    public int modificarMaquinaria(@WebParam(name = "maquinaria") Maquinaria maquinaria) {
        int result = 0;
        try{
            result = daoMaquinaria.modificar(maquinaria);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return result;
    }
    @WebMethod(operationName = "insertarMaquinaria")
    public int insertarMaquinaria(@WebParam(name = "maquinaria") Maquinaria maq) {
        int result = 0;
        try{
            result = daoMaquinaria.insertar(maq);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return result;
    }
    
    @WebMethod(operationName = "eliminarMaquinaria")
    public int eliminarMaquinaria(@WebParam(name = "idMaquinaria") int idMaq) {
        int result = 0;
        try{
            result = daoMaquinaria.eliminar(idMaq);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return result;
    }
    
    @WebMethod(operationName = "listarMaquinariasConParametros")
    public ArrayList<Maquinaria> listarMaquinariaPorNombreMaqNombreLinea(@WebParam(name = "nombreMaquinaria") String nomMaq, @WebParam(name = "nombreLineaProduccion") String nomLineaProd) {
        ArrayList<Maquinaria> maqs = new ArrayList<>();
        try{
            maqs = daoMaquinaria.listarMaquinariaPorNombreMaqNombreLinea(nomMaq, nomLineaProd);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return maqs;
    }
    
}
