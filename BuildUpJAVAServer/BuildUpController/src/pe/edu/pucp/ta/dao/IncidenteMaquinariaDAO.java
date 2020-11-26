
package pe.edu.pucp.ta.dao;

import java.util.ArrayList;
import java.sql.Date;
import pe.edu.pucp.ta.model.IncidenteMaquinaria;
import pe.edu.pucp.ta.model.Ingeniero;
import pe.edu.pucp.ta.model.Respuesta;


public interface IncidenteMaquinariaDAO {
    
    int insertar(IncidenteMaquinaria incidenteMaquinaria);
    int modificarPorIngeniero(IncidenteMaquinaria incidenteMaquinaria);
    int modificarPorSupervisor(IncidenteMaquinaria incidenteMaquinaria);
    int eliminar(int idIncidenteMaquinaria);
    ArrayList<IncidenteMaquinaria> listar();
    ArrayList<IncidenteMaquinaria> listarPorRangoFecha(Date fechaIni, Date fechaFin);
    int insertarProblema(IncidenteMaquinaria incidenteMaquinaria);
    int insertarRespuesta(IncidenteMaquinaria incidenteMaquinaria);
    IncidenteMaquinaria obtenerIngeniero(IncidenteMaquinaria incidenteMaquinaria);
    IncidenteMaquinaria obtenerRespuesta(IncidenteMaquinaria incidenteMaquinaria);
    
}
