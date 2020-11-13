
package pe.edu.pucp.ta.dao;

import java.util.ArrayList;
import pe.edu.pucp.ta.model.Operario;


public interface OperarioDAO {
    
    int insertar(Operario op);
    int actualizar(Operario op);
    int eliminar(int idOp);
    ArrayList<Operario> listar();
    
}
