
package pe.edu.pucp.ta.model;

import java.util.ArrayList;
import java.util.Date;


public class OrdenSalida {
    
    private int idOrdenSalida;
    private Operario operario;
    private Date fecha;
    private ArrayList<LineaOrdenSalida> lineasOrdenSalida;

    public OrdenSalida(Operario operario, Date fecha) {
        this.operario = operario;
        this.fecha = fecha;
    }


    public OrdenSalida(){ 
        operario = new Operario();
        lineasOrdenSalida = new ArrayList<LineaOrdenSalida>();
    }
    
    public int getIdOrdenSalida() {
        return idOrdenSalida;
    }

    public void setIdOrdenSalida(int idOrdenSalida) {
        this.idOrdenSalida = idOrdenSalida;
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

    public ArrayList<LineaOrdenSalida> getLineasOrdenSalida() {
        return lineasOrdenSalida;
    }

    public void setLineasOrdenSalida(ArrayList<LineaOrdenSalida> lineasOrdenSalida) {
        this.lineasOrdenSalida = lineasOrdenSalida;
    }
    
}
