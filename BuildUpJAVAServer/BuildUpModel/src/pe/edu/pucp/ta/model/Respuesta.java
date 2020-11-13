
package pe.edu.pucp.ta.model;


public class Respuesta {
    private int idRespuesta;
    private String tipo;
    private boolean activo;

    public Respuesta() {
    }
    
    public Respuesta(int idRespuesta, String tipo, boolean activo) {
        this.idRespuesta = idRespuesta;
        this.tipo = tipo;
        this.activo = activo;
    }

    public Respuesta(String tipo, boolean activo) {
        this.tipo = tipo;
        this.activo = activo;
    }

    public int getIdRespuesta() {
        return idRespuesta;
    }

    public void setIdRespuesta(int idRespuesta) {
        this.idRespuesta = idRespuesta;
    }

    public String getTipo() {
        return tipo;
    }

    public void setTipo(String tipo) {
        this.tipo = tipo;
    }

    public boolean getActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }
    
    
}
