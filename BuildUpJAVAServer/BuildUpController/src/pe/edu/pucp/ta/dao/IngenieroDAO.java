
package pe.edu.pucp.ta.dao;

import java.util.ArrayList;
import pe.edu.pucp.ta.model.Ingeniero;


public interface IngenieroDAO {
    
    int insertar(Ingeniero ing);
    int actualizar(Ingeniero ing);
    int eliminar(int idIng);
    ArrayList<Ingeniero> listar();
    
}
