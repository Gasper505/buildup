
package pe.edu.pucp.ta.dao;

import java.util.ArrayList;
import pe.edu.pucp.ta.model.Persona;


public interface PersonaDAO {
    
    int insertar(Persona per);
    int actualizar(Persona per);
    int eliminar(int idPer);
    ArrayList<Persona> listar();
    
}
