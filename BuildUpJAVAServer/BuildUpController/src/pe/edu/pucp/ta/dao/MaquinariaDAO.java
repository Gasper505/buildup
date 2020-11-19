
package pe.edu.pucp.ta.dao;

import java.util.ArrayList;
import pe.edu.pucp.ta.model.Maquinaria;


public interface MaquinariaDAO {
    int insertar(Maquinaria maquinaria);
    int actualizar(int idMaquinaria, boolean nuevo);
    int modificar(Maquinaria maquinaria);
    int eliminar(int idMaquinaria);
    ArrayList<Maquinaria> listar();
    ArrayList<Maquinaria> listarMaquinariaPorNombreMaqNombreLinea(String nombreMaq, String nombreLineaProd);
}
