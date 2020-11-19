
package pe.edu.pucp.ta.dao;

import java.sql.Date;
import java.util.ArrayList;
import pe.edu.pucp.ta.model.RegistroMerma;


public interface RegistroMermaDAO {
    
    int insertar(RegistroMerma regMerma);
    int actualizar(RegistroMerma regMerma);
    int eliminar(int idRegistroMerma);
    ArrayList<RegistroMerma> listar();
    ArrayList<RegistroMerma> listarRegistrosMermasPorSupervisorYRangoFechas(String nombreSup, Date fechaInicial, Date fechaFin);
    
}
