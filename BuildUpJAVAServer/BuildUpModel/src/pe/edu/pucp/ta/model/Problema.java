
package pe.edu.pucp.ta.model;


public class Problema {
    
    private int idProblema;
    private String tipo;
    private int nivelImportancia;
    private boolean activo;

    public Problema() {
    }

    public Problema(String tipo, int nivelImportancia, boolean activo) {
        this.tipo = tipo;
        this.nivelImportancia = nivelImportancia;
        this.activo = activo;
    }
    
    public Problema(int idProblema, String tipo, int nivelImportancia, boolean activo) {
        this.idProblema = idProblema;
        this.tipo = tipo;
        this.nivelImportancia = nivelImportancia;
        this.activo = activo;
    }

    public int getIdProblema() {
        return idProblema;
    }

    public void setIdProblema(int idProblema) {
        this.idProblema = idProblema;
    }

    public String getTipo() {
        return tipo;
    }

    public void setTipo(String tipo) {
        this.tipo = tipo;
    }

    public int getNivelImportancia() {
        return nivelImportancia;
    }

    public void setNivelImportancia(int nivelImportancia) {
        this.nivelImportancia = nivelImportancia;
    }

    public boolean getActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }
    
    

    
}
