
package pe.edu.pucp.ta.model;

import java.util.ArrayList;


public class LineaProduccion {
    
    private int idLineaProduccion;
    private String nombre;
    private TipoLadrillo tipoLadrillo;
    private boolean activo;
    private ArrayList<Operario> operarios;
    private ArrayList<Supervisor> supervisores;
    

    public LineaProduccion(int idLineaProduccion, String nombre, boolean activo) {
        this.idLineaProduccion = idLineaProduccion;
        this.nombre = nombre;
        this.activo = activo;
    }

    public LineaProduccion() {
        tipoLadrillo = new TipoLadrillo();
        operarios = new ArrayList<Operario>();
        supervisores = new ArrayList<Supervisor>();
        
    }

    public int getIdLineaProduccion() {
        return idLineaProduccion;
    }

    public void setIdLineaProduccion(int idLineaProduccion) {
        this.idLineaProduccion = idLineaProduccion;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public boolean isActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }

    public ArrayList<Operario> getOperarios() {
        return operarios;
    }

    public void setOperarios(ArrayList<Operario> operarios) {
        this.operarios = operarios;
    }

    public ArrayList<Supervisor> getSupervisores() {
        return supervisores;
    }

    public void setSupervisores(ArrayList<Supervisor> supervisores) {
        this.supervisores = supervisores;
    }

    public TipoLadrillo getTipoLadrillo() {
        return tipoLadrillo;
    }

    public void setTipoLadrillo(TipoLadrillo tipoLadrillo) {
        this.tipoLadrillo = tipoLadrillo;
    }
    
}
