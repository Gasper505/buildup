
package pe.edu.pucp.ta.dao;

import java.util.ArrayList;
import pe.edu.pucp.ta.model.Respuesta;


public interface RespuestaDAO {
    int insertar(Respuesta resp);
    int actualizar(Respuesta resp);
    int eliminar(int idResp);
    ArrayList<Respuesta> listar();
}
