
package pe.edu.pucp.ta.model;

import java.util.Date;


public class JefeArea extends Persona{
    
    private String archivoFirmaDigital;

    public JefeArea(String nombres, String apellidos, String telefono, String correo, String rol, Date fechaFinContrato, String fotitoJpg, byte[] foto, boolean activo) {
        super(nombres, apellidos, telefono, correo, rol, fechaFinContrato, foto, activo);
        this.archivoFirmaDigital = fotitoJpg;
    }

    public JefeArea() {
    }

    public String getArchivoFirmaDigital() {
        return archivoFirmaDigital;
    }

    public void setArchivoFirmaDigital(String archivoFirmaDigital) {
        this.archivoFirmaDigital = archivoFirmaDigital;
    }
    
}
