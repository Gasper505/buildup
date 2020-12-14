
package pe.edu.pucp.ta.model;

import java.util.Date;


public class IncidenteMaquinaria {

    private int idIncidente;
    private Maquinaria maquinaria;
    private Supervisor supervisor;
    private Ingeniero ingeniero;
    private Problema problema;
    private Respuesta respuesta;
    private String detalleProblema;
    private String detalle; //descripcion/detalle de la respuesta al incidente
    private Date fechaIncidente;
    private Date fechaAtencion;
    private boolean estado;
    private boolean activo;
    
    public IncidenteMaquinaria() {
       maquinaria = new Maquinaria();
       supervisor = new Supervisor();
       ingeniero = new Ingeniero();
       problema = new Problema();
       respuesta = new Respuesta();
    }
    
    public IncidenteMaquinaria(int id, Date fechaInc, boolean act) {
        this.idIncidente = id;
        this.fechaIncidente = fechaInc;
        this.activo = act;
    }

    public String getDetalleProblema() {
        return detalleProblema;
    }

    public void setDetalleProblema(String detalleProblema) {
        this.detalleProblema = detalleProblema;
    }
    
    
    
    public IncidenteMaquinaria(int idIncidente, Maquinaria maquinaria, Supervisor supervisor, Ingeniero ingeniero, Problema problema, Respuesta respuesta, String detalle, Date fechaIncidente, Date fechaAtencion) {
        this.idIncidente = idIncidente;
        this.maquinaria = maquinaria;
        this.supervisor = supervisor;
        this.ingeniero = ingeniero;
        this.problema = problema;
        this.respuesta = respuesta;
        this.detalle = detalle;
        this.fechaIncidente = fechaIncidente;
        this.fechaAtencion = fechaAtencion;
    }
    

    public int getIdIncidente() {
        return idIncidente;
    }

    public void setIdIncidente(int idIncidente) {
        this.idIncidente = idIncidente;
    }

    public Maquinaria getMaquinaria() {
        return maquinaria;
    }

    public void setMaquinaria(Maquinaria maquinaria) {
        this.maquinaria = maquinaria;
    }

    public Supervisor getSupervisor() {
        return supervisor;
    }

    public void setSupervisor(Supervisor supervisor) {
        this.supervisor = supervisor;
    }

    public Ingeniero getIngeniero() {
        return ingeniero;
    }

    public void setIngeniero(Ingeniero ingeniero) {
        this.ingeniero = ingeniero;
    }

    public Problema getProblema() {
        return problema;
    }

    public void setProblema(Problema problema) {
        this.problema = problema;
    }

    public Respuesta getRespuesta() {
        return respuesta;
    }

    public void setRespuesta(Respuesta respuesta) {
        this.respuesta = respuesta;
    }

    public String getDetalle() {
        return detalle;
    }

    public void setDetalle(String detalle) {
        this.detalle = detalle;
    }

    public Date getFechaIncidente() {
        return fechaIncidente;
    }

    public void setFechaIncidente(Date fechaIncidente) {
        this.fechaIncidente = fechaIncidente;
    }

    public Date getFechaAtencion() {
        return fechaAtencion;
    }

    public void setFechaAtencion(Date fechaAtencion) {
        this.fechaAtencion = fechaAtencion;
    }

    public boolean isActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }
    public boolean isEstado() {
        return estado;
    }

    public void setEstado(boolean estado) {
        this.estado = estado;
    }
}
