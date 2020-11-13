
package pe.edu.pucp.ta.model;

import java.util.Date;


public class Maquinaria {
    
    private int idMaquinaria;
    private String nombre;
    private LineaProduccion lineaProduccion;
    private Proveedor proveedor;
    private Date garantiaFin;
    private boolean activo;
    

    public Maquinaria(int idMaquinaria, String nombre) {
        this.idMaquinaria = idMaquinaria;
        this.nombre = nombre;
    }

    public Maquinaria() {
        lineaProduccion = new LineaProduccion();
        proveedor = new Proveedor();
        
    }

    public int getIdMaquinaria() {
        return idMaquinaria;
    }

    public void setIdMaquinaria(int idMaquinaria) {
        this.idMaquinaria = idMaquinaria;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public LineaProduccion getLineaProduccion() {
        return lineaProduccion;
    }

    public void setLineaProduccion(LineaProduccion lineaProduccion) {
        this.lineaProduccion = lineaProduccion;
    }

    public Proveedor getProveedor() {
        return proveedor;
    }

    public void setProveedor(Proveedor proveedor) {
        this.proveedor = proveedor;
    }

    public boolean isActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }

    public Date getGarantiaFin() {
        return garantiaFin;
    }

    public void setGarantiaFin(Date garantiaFin) {
        this.garantiaFin = garantiaFin;
    }
    
    @Override
    public String toString(){
        return this.nombre;
    }
    
}
