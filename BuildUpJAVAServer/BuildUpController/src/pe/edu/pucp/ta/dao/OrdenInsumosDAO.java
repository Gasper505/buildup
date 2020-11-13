
package pe.edu.pucp.ta.dao;

import java.util.ArrayList;
import pe.edu.pucp.ta.model.OrdenInsumos;


public interface OrdenInsumosDAO {
    
    int insertar(OrdenInsumos ordenInsumos);
    int actualizar(OrdenInsumos ordenInsumos);
    int eliminar(int idOrdenInsumos);
    ArrayList<OrdenInsumos> listar();
    
}
