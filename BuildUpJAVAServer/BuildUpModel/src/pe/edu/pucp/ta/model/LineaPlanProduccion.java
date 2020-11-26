/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.ta.model;

/**
 *
 * @author Luis Gaspar
 */
public class LineaPlanProduccion {
    private int idLineaPlan;
    private PlanProduccion plan;
    private TipoLadrillo tipoLadrillo;
    private int cantidad;

    public LineaPlanProduccion() {
        plan = new PlanProduccion();
        tipoLadrillo = new TipoLadrillo();
    }

    public int getIdLineaPlan() {
        return idLineaPlan;
    }

    public void setIdLineaPlan(int idLineaPlan) {
        this.idLineaPlan = idLineaPlan;
    }

    public PlanProduccion getPlan() {
        return plan;
    }

    public void setPlan(PlanProduccion plan) {
        this.plan = plan;
    }

    public TipoLadrillo getTipoLadrillo() {
        return tipoLadrillo;
    }

    public void setTipoLadrillo(TipoLadrillo tipoLadrillo) {
        this.tipoLadrillo = tipoLadrillo;
    }

    public int getCantidad() {
        return cantidad;
    }

    public void setCantidad(int cantidad) {
        this.cantidad = cantidad;
    }
    
    
    
    
}
