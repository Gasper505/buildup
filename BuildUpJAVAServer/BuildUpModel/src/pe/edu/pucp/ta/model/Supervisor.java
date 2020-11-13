
package pe.edu.pucp.ta.model;


public class Supervisor extends Persona{
    
    private LineaProduccion lineaProduccion;

    public Supervisor(){
        lineaProduccion = new LineaProduccion();
    }

    public Supervisor(LineaProduccion lineaProduccion, boolean activo) {
        this.lineaProduccion = lineaProduccion;
    }

    public LineaProduccion getLineaProduccion() {
        return lineaProduccion;
    }

    public void setLineaProduccion(LineaProduccion lineaProduccion) {
        this.lineaProduccion = lineaProduccion;
    }

}
