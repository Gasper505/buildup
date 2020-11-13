
package pe.edu.pucp.ta.dao;

import java.util.ArrayList;
import pe.edu.pucp.ta.model.RegistroMerma;


public interface RegistroMermaDAO {
    
    int insertar(RegistroMerma regMerma);
    int actualizar(RegistroMerma regMerma);
    int eliminar(int idRegistroMerma);
    ArrayList<RegistroMerma> listar();
    
}
