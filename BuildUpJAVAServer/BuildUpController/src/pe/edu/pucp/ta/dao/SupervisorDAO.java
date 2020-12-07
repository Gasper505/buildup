
package pe.edu.pucp.ta.dao;

import java.util.ArrayList;
import pe.edu.pucp.ta.model.Supervisor;


public interface SupervisorDAO {
    
    int insertar(Supervisor sup, String username, String password);
    int actualizar(Supervisor sup);
    int eliminar(int idSup);
    String obtener_linea_produccion(int idSup);
    ArrayList<Supervisor> listar();
    
}
