
package pe.edu.pucp.ta.model;


public class Insumo {
    
    private int idInsumo;
    private String nombre;
    private String unidadMedida;
    private boolean activo;

    public Insumo(int idInsumo, String nombre, String unidadMedida, boolean activo) {
        this.idInsumo = idInsumo;
        this.nombre = nombre;
        this.unidadMedida = unidadMedida;
        this.activo = activo;
    }

    public Insumo() {}

    public Insumo(String nombre, String unidadMedida, boolean activo) {
        this.nombre = nombre;
        this.unidadMedida = unidadMedida;
        this.activo = activo;
    }

    public int getIdInsumo() {
        return idInsumo;
    }

    public void setIdInsumo(int idInsumo) {
        this.idInsumo = idInsumo;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getUnidadMedida() {
        return unidadMedida;
    }

    public void setUnidadMedida(String unidadMedida) {
        this.unidadMedida = unidadMedida;
    }

    public boolean isActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }
    
}
