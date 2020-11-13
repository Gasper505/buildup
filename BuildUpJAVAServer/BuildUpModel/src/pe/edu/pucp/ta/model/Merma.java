

package pe.edu.pucp.ta.model;


public class Merma {
    private int idMerma;
    private String tipo;
    private String descripcion;
    private String unidad;
    private boolean activo;

    public Merma() {
    }

    public Merma(int idMerma, String tipo, String descripcion, String unidad, boolean activo) {
        this.idMerma = idMerma;
        this.tipo = tipo;
        this.descripcion = descripcion;
        this.unidad = unidad;
        this.activo = activo;
    }

    public Merma(String tipo, String descripcion, String unidad, boolean activo) {
        this.tipo = tipo;
        this.descripcion = descripcion;
        this.unidad = unidad;
        this.activo = activo;
    }

    public int getIdMerma() {
        return idMerma;
    }

    public void setIdMerma(int idMerma) {
        this.idMerma = idMerma;
    }

    public String getTipo() {
        return tipo;
    }

    public void setTipo(String tipo) {
        this.tipo = tipo;
    }

    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }

    public String getUnidad() {
        return unidad;
    }

    public void setUnidad(String unidad) {
        this.unidad = unidad;
    }

    public boolean getActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }

 
    
    
}
