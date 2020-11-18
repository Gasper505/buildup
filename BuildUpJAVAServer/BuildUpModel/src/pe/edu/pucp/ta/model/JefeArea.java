
package pe.edu.pucp.ta.model;

import java.util.Date;


public class JefeArea extends Persona{

    private String archivoFirmaDigital;
    private byte[] foto_firma;

    public JefeArea(String archivoFirmaDigital, byte[] foto_firma, String nombres, String apellidos, Date fechaNacimiento, String telefono, String correo, String rol, Date fechaFinContrato, byte[] foto, boolean activo) {
        super(nombres, apellidos, fechaNacimiento, telefono, correo, rol, fechaFinContrato, foto, activo);
        this.archivoFirmaDigital = archivoFirmaDigital;
        this.foto_firma = foto_firma;
    }
    

    public JefeArea() {
    }

    public String getArchivoFirmaDigital() {
        return archivoFirmaDigital;
    }

    public void setArchivoFirmaDigital(String archivoFirmaDigital) {
        this.archivoFirmaDigital = archivoFirmaDigital;
    }

    public byte[] getFoto_firma() {
        return foto_firma;
    }

    public void setFoto_firma(byte[] foto_firma) {
        this.foto_firma = foto_firma;
    }
}
