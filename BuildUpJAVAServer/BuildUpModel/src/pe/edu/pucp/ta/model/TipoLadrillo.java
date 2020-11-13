
package pe.edu.pucp.ta.model;


public class TipoLadrillo {
    
    private int idTipoLadrillo;
    private String nombre;
    private double largo;
    private double ancho;
    private double altura;

    public TipoLadrillo(int idTipoLadrillo, String nombre, double largo, double ancho, double altura) {
        this.idTipoLadrillo = idTipoLadrillo;
        this.nombre = nombre;
        this.largo = largo;
        this.ancho = ancho;
        this.altura = altura;
    }

    public TipoLadrillo() {
    }

    public int getIdTipoLadrillo() {
        return idTipoLadrillo;
    }

    public void setIdTipoLadrillo(int idTipoLadrillo) {
        this.idTipoLadrillo = idTipoLadrillo;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public double getLargo() {
        return largo;
    }

    public void setLargo(double largo) {
        this.largo = largo;
    }

    public double getAncho() {
        return ancho;
    }

    public void setAncho(double ancho) {
        this.ancho = ancho;
    }

    public double getAltura() {
        return altura;
    }

    public void setAltura(double altura) {
        this.altura = altura;
    }
    
}
