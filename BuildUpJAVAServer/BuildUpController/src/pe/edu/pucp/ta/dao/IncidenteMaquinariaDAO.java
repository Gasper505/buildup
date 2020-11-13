
package pe.edu.pucp.ta.dao;

import java.util.ArrayList;
import pe.edu.pucp.ta.model.IncidenteMaquinaria;


public interface IncidenteMaquinariaDAO {
    
    int insertar(IncidenteMaquinaria incidenteMaquinaria);
    int actualizar(IncidenteMaquinaria incidenteMaquinaria);
    int eliminar(int idIncidenteMaquinaria);
    ArrayList<IncidenteMaquinaria> listar();
    
}
