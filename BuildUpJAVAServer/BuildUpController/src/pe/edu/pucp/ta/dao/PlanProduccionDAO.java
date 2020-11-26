/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.ta.dao;

import java.sql.Date;
import java.util.ArrayList;
import pe.edu.pucp.ta.model.OrdenSalida;
import pe.edu.pucp.ta.model.PlanProduccion;

/**
 *
 * @author Luis Gaspar
 */
public interface PlanProduccionDAO {
    int insertar(PlanProduccion plan);
    int actualizar(PlanProduccion plan);
    int eliminar(int idPlan);
    ArrayList<PlanProduccion> listar();
    
    
    
}
