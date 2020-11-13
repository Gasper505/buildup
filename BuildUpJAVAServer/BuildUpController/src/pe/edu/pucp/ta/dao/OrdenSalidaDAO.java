
package pe.edu.pucp.ta.dao;

import java.sql.Date;
import java.util.ArrayList;
import pe.edu.pucp.ta.model.OrdenSalida;


public interface OrdenSalidaDAO {
    
    int insertar(OrdenSalida ordenSalida);
    int actualizar(OrdenSalida ordenSalida);
    int eliminar(int idOrdenSalida);
    ArrayList<OrdenSalida> listar();
    ArrayList<OrdenSalida> listarOrdenesSalidaConParametros(String nombreOperario, Date fechaRegistro);
    
}
