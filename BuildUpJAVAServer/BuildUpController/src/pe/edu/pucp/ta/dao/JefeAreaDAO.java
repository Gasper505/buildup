
package pe.edu.pucp.ta.dao;

import java.util.ArrayList;
import pe.edu.pucp.ta.model.JefeArea;


public interface JefeAreaDAO {
    
    int insertar(JefeArea jefeArea);
    int actualizar_estado(int idPersona, boolean activo);
    int modificar(JefeArea jefeArea);
    int eliminar(int idJefe);
    ArrayList<JefeArea> listar();
    byte[] obtener_foto_firma(int idJefeArea);
    
}
