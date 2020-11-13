
package pe.edu.pucp.ta.model;

public class LineaOrdenSalida {
    
    private int idLineaOrdenSalida;
    private OrdenSalida ordenSalida;
    private TipoLadrillo tipoLadrillo;
    private int cantidad;
    
    public LineaOrdenSalida(){
        ordenSalida = new OrdenSalida();
        tipoLadrillo = new TipoLadrillo();
    }

    public OrdenSalida getOrdenSalida() {
        return ordenSalida;
    }

    public void setOrdenSalida(OrdenSalida ordenSalida) {
        this.ordenSalida = ordenSalida;
    }

    public TipoLadrillo getTipoLadrillo() {
        return tipoLadrillo;
    }

    public void setTipoLadrillo(TipoLadrillo tipoLadrillo) {
        this.tipoLadrillo = tipoLadrillo;
    }

    public int getCantidad() {
        return cantidad;
    }

    public void setCantidad(int cantidad) {
        this.cantidad = cantidad;
    }

    public int getIdLineaOrdenSalida() {
        return idLineaOrdenSalida;
    }

    public void setIdLineaOrdenSalida(int idLineaOrdenSalida) {
        this.idLineaOrdenSalida = idLineaOrdenSalida;
    }
    
}
