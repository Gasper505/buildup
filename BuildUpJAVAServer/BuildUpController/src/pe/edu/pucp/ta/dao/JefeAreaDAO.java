
package pe.edu.pucp.ta.dao;

import java.util.ArrayList;
import pe.edu.pucp.ta.model.JefeArea;


public interface JefeAreaDAO {
    
    int insertar(JefeArea jefe);
    int actualizar(int idPersona, int nuevo);
    int eliminar(int idJefe);
    ArrayList<JefeArea> listar();
    
}
