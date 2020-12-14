
package pe.edu.pucp.ta.model;

import java.util.Date;


public class OrdenInsumos {
    private int idOrdenInsumos;
    private Operario operario;
    private Insumo insumo;
    private int cantidad;
    private String unidadMedida;
    private Date fecha;
    private boolean activo;
    private int estado;

    public OrdenInsumos(Operario operario, Insumo insumo, int cantidad, String unidadMedida, Date fecha) {
        this.operario = operario;
        this.insumo = insumo;
        this.cantidad = cantidad;
        this.unidadMedida = unidadMedida;
        this.fecha = fecha;
    }

    public OrdenInsumos() {
        operario = new Operario();
        insumo = new Insumo();
        
        
    }

    public OrdenInsumos(int idOrdenInsumos, int cantidad, Date fecha) {
        this.idOrdenInsumos = idOrdenInsumos;
        this.cantidad = cantidad;
        this.fecha = fecha;
    }

    public int getIdOrdenInsumos() {
        return idOrdenInsumos;
    }

    public void setIdOrdenInsumos(int idOrdenInsumos) {
        this.idOrdenInsumos = idOrdenInsumos;
    }

    public int getCantidad() {
        return cantidad;
    }

    public void setCantidad(int cantidad) {
        this.cantidad = cantidad;
    }

    public Date getFecha() {
        return fecha;
    }

    public void setFecha(Date fecha) {
        this.fecha = fecha;
    }

    public Operario getOperario() {
        return operario;
    }

    public void setOperario(Operario operario) {
        this.operario = operario;
    }

    public Insumo getInsumo() {
        return insumo;
    }

    public void setInsumo(Insumo insumo) {
        this.insumo = insumo;
    }

    public String getUnidadMedida() {
        return unidadMedida;
    }

    public void setUnidadMedida(String unidadMedida) {
        this.unidadMedida = unidadMedida;
    }

    public void setIdOperario(int aInt) {
        this.operario.setIdPersona(aInt);
    }

    public void setIdInsumo(int aInt) {
        this.insumo.setIdInsumo(aInt);
    }
        public boolean isActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }

    public int getEstado() {
        return estado;
    }

    public void setEstado(int estado) {
        this.estado = estado;
    }

    
}
