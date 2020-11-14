
package pe.edu.pucp.buildup.services;

import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.ta.dao.TipoLadrilloDAO;
import pe.edu.pucp.ta.model.TipoLadrillo;
import pe.edu.pucp.ta.mysql.TipoLadrilloMySQL;

@WebService(serviceName = "TipoLadrilloWS")
public class TipoLadrilloWS {

    private TipoLadrilloDAO daoTipoLadrillo;
    
    public TipoLadrilloWS(){
        daoTipoLadrillo = new TipoLadrilloMySQL();
    }
    
    @WebMethod(operationName = "listarTiposLadrillo")
    public ArrayList<TipoLadrillo> listarTiposLadrillo() {
        ArrayList<TipoLadrillo> ladrillos = new ArrayList<>();
        try{
            ladrillos = daoTipoLadrillo.listar();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return ladrillos;
    }
    
    @WebMethod(operationName = "insertarTipoLadrillo")
    public int insertarTipoLadrillo(@WebParam(name = "tipoLadrillo") TipoLadrillo lad) {
        int resultado = 0;
        try{
            resultado = daoTipoLadrillo.insertar(lad);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarTipoLadrillo")
    public int eliminarTipoLadrillo(@WebParam(name = "idTipoLadrillo") int idTipoLadrillo) {
        int resultado = 0;
        try{
            resultado = daoTipoLadrillo.eliminar(idTipoLadrillo);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
}
