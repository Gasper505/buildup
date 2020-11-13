
package pe.edu.pucp.ta.dao;

import java.util.ArrayList;
import pe.edu.pucp.ta.model.Problema;


public interface ProblemaDAO {
    
    int insertar(Problema tipoIncidente);
    int actualizar(Problema tipoIncidente);
    int eliminar(int idTipoIncidente);
    ArrayList<Problema> listar();
    
}
