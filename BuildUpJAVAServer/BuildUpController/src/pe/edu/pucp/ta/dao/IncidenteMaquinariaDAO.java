
package pe.edu.pucp.ta.dao;

import java.util.ArrayList;
import java.util.Date;
import pe.edu.pucp.ta.model.IncidenteMaquinaria;
import pe.edu.pucp.ta.model.Ingeniero;


public interface IncidenteMaquinariaDAO {
    
    int insertar(IncidenteMaquinaria incidenteMaquinaria);
    int actualizar(IncidenteMaquinaria incidenteMaquinaria);
    int eliminar(int idIncidenteMaquinaria);
    ArrayList<IncidenteMaquinaria> listar();
    ArrayList<IncidenteMaquinaria> listarPorRangoFecha(Date fechaIni, Date fechaFin);
    int insertarProblema(IncidenteMaquinaria incidenteMaquinaria);
    int insertarRespuesta(IncidenteMaquinaria incidenteMaquinaria);
    Ingeniero obtenerIngeniero(int idIncidenteMaquinaria);
    ArrayList<Object> obtenerRespuesta(int idIncidenteMaquinaria);
    
}
