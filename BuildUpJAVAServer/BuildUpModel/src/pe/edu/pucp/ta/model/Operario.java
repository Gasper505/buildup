
package pe.edu.pucp.ta.model;

import java.util.Date;

public class Operario extends Persona{

    
    private LineaProduccion lineaProduccion;

    public Operario(){
        lineaProduccion = new LineaProduccion();
    }

    public LineaProduccion getLineaProduccion() {
        return lineaProduccion;
    }

    public void setLineaProduccion(LineaProduccion lineaProduccion) {
        this.lineaProduccion = lineaProduccion;
    }
    
    @Override
    public String toString(){
        return getNombres() + getApellidos();
    }
    
}
