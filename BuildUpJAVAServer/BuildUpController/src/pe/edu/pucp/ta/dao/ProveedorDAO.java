
package pe.edu.pucp.ta.dao;

import java.util.ArrayList;
import pe.edu.pucp.ta.model.Proveedor;


public interface ProveedorDAO {
    
    int insertar(Proveedor proveedor);
    int actualizar(Proveedor proveedor);
    int eliminar(int idProveedor);
    ArrayList<Proveedor> listar();
    
}
