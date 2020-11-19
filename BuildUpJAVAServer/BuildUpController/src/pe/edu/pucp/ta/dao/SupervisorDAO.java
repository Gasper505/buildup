
package pe.edu.pucp.ta.dao;

import java.util.ArrayList;
import pe.edu.pucp.ta.model.Supervisor;


public interface SupervisorDAO {
    
    int insertar(Supervisor sup);
    int actualizar(Supervisor sup);
    int eliminar(int idSup);
    ArrayList<Supervisor> listar();
    
}
