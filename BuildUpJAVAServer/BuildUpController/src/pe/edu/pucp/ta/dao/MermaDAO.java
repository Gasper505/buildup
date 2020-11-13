

package pe.edu.pucp.ta.dao;

import java.util.ArrayList;
import pe.edu.pucp.ta.model.Merma;


public interface MermaDAO {
    int insertar(Merma merma);
    int actualizar(Merma merma);
    int eliminar(int idMerma);
    ArrayList<Merma> listar();
}
