
package pe.edu.pucp.ta.model;

import java.util.Date;


public class RegistroMerma {
    private int idRegistroMerma;
    private Supervisor supervisor;
    private LineaProduccion lineaProduccion;
    private Merma merma;
    private int cantidad;
    private Date fecha;
    private boolean activo;
    

    public RegistroMerma() {
        supervisor = new Supervisor();
        lineaProduccion = new LineaProduccion();
        merma = new Merma();
        
    }

    public RegistroMerma(int idRegistroMerma, Supervisor supervisor, LineaProduccion lineaProduccion, Merma merma, int cantidad, Date fecha, boolean activo) {
        this.idRegistroMerma = idRegistroMerma;
        this.supervisor = supervisor;
        this.lineaProduccion = lineaProduccion;
        this.merma = merma;
        this.cantidad = cantidad;
        this.fecha = fecha;
        this.activo = activo;
    }

    public RegistroMerma(Supervisor supervisor, LineaProduccion lineaProduccion, Merma merma, int cantidad, Date fecha, boolean activo) {
        this.supervisor = supervisor;
        this.lineaProduccion = lineaProduccion;
        this.merma = merma;
        this.cantidad = cantidad;
        this.fecha = fecha;
        this.activo = activo;
    }

    public int getIdRegistroMerma() {
        return idRegistroMerma;
    }

    public void setIdRegistroMerma(int idRegistroMerma) {
        this.idRegistroMerma = idRegistroMerma;
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

    public boolean getActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }

    public Supervisor getSupervisor() {
        return supervisor;
    }

    public void setSupervisor(Supervisor supervisor) {
        this.supervisor = supervisor;
    }

    public LineaProduccion getLineaProduccion() {
        return lineaProduccion;
    }

    public void setLineaProduccion(LineaProduccion lineaProduccion) {
        this.lineaProduccion = lineaProduccion;
    }

    public Merma getMerma() {
        return merma;
    }

    public void setMerma(Merma merma) {
        this.merma = merma;
    }


}
