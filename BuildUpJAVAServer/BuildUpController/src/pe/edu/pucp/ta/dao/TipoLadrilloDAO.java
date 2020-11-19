
package pe.edu.pucp.ta.dao;

import java.util.ArrayList;
import pe.edu.pucp.ta.model.TipoLadrillo;

public interface TipoLadrilloDAO {
    
    int insertar(TipoLadrillo tipoLadrillo);
    int actualizar(TipoLadrillo tipoLadrillo);
    int eliminar(int idTipoLadrillo);
    ArrayList<TipoLadrillo> listar();
    ArrayList<TipoLadrillo> listarTipoLadrilloPorNombre(String nombre);
    
}
