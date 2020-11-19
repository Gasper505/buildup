
package pe.edu.pucp.ta.dao;

import java.util.ArrayList;
import pe.edu.pucp.ta.model.LineaProduccion;


public interface LineaProduccionDAO {
    
    int insertar(LineaProduccion lineaProduccion);
    int actualizar(int idLineaProduccion, int idLadrillo);
    int modificar(LineaProduccion lineaProduccion);
    int eliminar(int idLineaProduccion);
    ArrayList<LineaProduccion> listarPorNombre(String nombre);
    
}
