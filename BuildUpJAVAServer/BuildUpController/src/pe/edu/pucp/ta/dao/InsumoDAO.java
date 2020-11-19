
package pe.edu.pucp.ta.dao;

import java.util.ArrayList;
import pe.edu.pucp.ta.model.Insumo;

public interface InsumoDAO {
    
    int insertar(Insumo insumo);
    int modificar(Insumo insumo);
    int eliminar(int idInsumo);
    ArrayList<Insumo> listar();
    ArrayList<Insumo> listarPorNombre(String nombre);
}
