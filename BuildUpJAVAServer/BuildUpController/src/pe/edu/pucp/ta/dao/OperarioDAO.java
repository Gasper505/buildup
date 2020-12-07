
package pe.edu.pucp.ta.dao;

import java.util.ArrayList;
import pe.edu.pucp.ta.model.Operario;


public interface OperarioDAO {
    
    int insertar(Operario op, String username, String password);
    int actualizar_estado(int idOp,boolean activo);
    int modificar(Operario op);
    int eliminar(int idOp);
    String obtener_linea_produccion(int idOp);
    ArrayList<Operario> listar();
    
}
