
package pe.edu.pucp.ta.model;


public class Proveedor {
    
    private int idProveedor;
    private String razonSocial;
    private String correo;
    private String representante;
    private boolean activo;
    private String ruc;
    private String direccion;

    public Proveedor() {
    }

    public Proveedor(int idProveedor, String razonSocial, String correo, String representante) {
        this.idProveedor = idProveedor;
        this.razonSocial = razonSocial;
        this.correo = correo;
        this.representante = representante;
    }

    public Proveedor(String razonSocial, String correo, String representante) {
        this.razonSocial = razonSocial;
        this.correo = correo;
        this.representante = representante;
    }

    public String getRuc() {
        return ruc;
    }

    public void setRuc(String ruc) {
        this.ruc = ruc;
    }

    public String getDireccion() {
        return direccion;
    }

    public void setDireccion(String direccion) {
        this.direccion = direccion;
    }

    public int getIdProveedor() {
        return idProveedor;
    }

    public void setIdProveedor(int idProveedor) {
        this.idProveedor = idProveedor;
    }

    public String getRazonSocial() {
        return razonSocial;
    }

    public void setRazonSocial(String razonSocial) {
        this.razonSocial = razonSocial;
    }

    public String getCorreo() {
        return correo;
    }

    public void setCorreo(String correo) {
        this.correo = correo;
    }

    public String getRepresentante() {
        return representante;
    }

    public void setRepresentante(String representante) {
        this.representante = representante;
    }

    public boolean getActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }

    
    
}
