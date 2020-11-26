/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.ta.model;

import java.util.ArrayList;

/**
 *
 * @author Luis Gaspar
 */
public class PlanProduccion {
    private int idPlan;
    private int anhoPlan;
    private ArrayList<LineaPlanProduccion> lineasPlan;

    public PlanProduccion(int anhoPlan) {
        this.anhoPlan = anhoPlan;
    }
    public PlanProduccion() {
        lineasPlan = new ArrayList<LineaPlanProduccion>(); 
    }

    public int getIdPlan() {
        return idPlan;
    }

    public void setIdPlan(int idPlan) {
        this.idPlan = idPlan;
    }

    public int getAnhoPlan() {
        return anhoPlan;
    }

    public void setAnhoPlan(int anhoPlan) {
        this.anhoPlan = anhoPlan;
    }

    public ArrayList<LineaPlanProduccion> getLineasPlan() {
        return lineasPlan;
    }

    public void setLineasPlan(ArrayList<LineaPlanProduccion> lineasPlan) {
        this.lineasPlan = lineasPlan;
    }
    
    
    
}
