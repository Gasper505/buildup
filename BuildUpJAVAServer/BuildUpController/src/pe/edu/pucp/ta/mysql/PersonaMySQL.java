
package pe.edu.pucp.ta.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import pe.edu.pucp.ta.config.DBManager;
import pe.edu.pucp.ta.dao.PersonaDAO;
import pe.edu.pucp.ta.model.Persona;


public class PersonaMySQL implements PersonaDAO {
    
    Connection con;
    CallableStatement cs;
    ResultSet rs;
    Statement st;

    @Override
    public int insertar(Persona per) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public int actualizar(Persona per) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public int eliminar(int idPer) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public ArrayList<Persona> listar() {
        ArrayList<Persona> personas = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call LISTAR_PERSONAS()}");
            rs = cs.executeQuery();
            while(rs.next()){
                Persona persona = new Persona();
                persona.setIdPersona(rs.getInt("ID_PERSONA")); 
                persona.setNombres(rs.getString("NOMBRES"));
                persona.setApellidos(rs.getString("APELLIDOS"));
                persona.setTelefono(rs.getString("TELEFONO"));
                persona.setCorreo(rs.getString("CORREO"));
                persona.setRol(rs.getString("ROL"));
                persona.setFechaFinContrato(rs.getDate("FECHA_FIN_CONTRATO"));
                personas.add(persona);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
            
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return personas;
    }
    
}
