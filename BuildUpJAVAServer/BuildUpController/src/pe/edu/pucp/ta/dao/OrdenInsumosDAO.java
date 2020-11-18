
package pe.edu.pucp.ta.dao;

import java.util.ArrayList;
import java.util.Date;
import pe.edu.pucp.ta.model.OrdenInsumos;


public interface OrdenInsumosDAO {
    
    int insertar(OrdenInsumos ordenInsumos);
    int modificar(OrdenInsumos ordenInsumos);
    int eliminar(int idOrdenInsumos);
    ArrayList<OrdenInsumos> listar();
    ArrayList<OrdenInsumos> listar_por_fecha(Date fechaIni, Date fechaFin);
    int aceptar(int idOrdenInsumos);
}
