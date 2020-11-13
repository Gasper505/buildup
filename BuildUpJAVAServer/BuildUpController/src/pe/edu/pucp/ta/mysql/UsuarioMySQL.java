
package pe.edu.pucp.ta.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import pe.edu.pucp.ta.config.DBManager;
import pe.edu.pucp.ta.dao.UsuarioDAO;
import pe.edu.pucp.ta.model.Persona;
import pe.edu.pucp.ta.model.Usuario;

public class UsuarioMySQL implements UsuarioDAO{
    
    Connection con;
    CallableStatement cs;
    ResultSet rs;
    Statement st;

    @Override
    public int autenticarUsuario(Usuario usuario) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            
            cs = con.prepareCall("{call AUTENTICAR_USUARIO(?,?)}");
            
            cs.setString("_USERNAME", usuario.getUsername());
            cs.setString("_PASSWORD", usuario.getPassword());
            
            rs = cs.executeQuery();
            
            if(rs.next()){
                resultado = 1;
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{rs.close();con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public Usuario buscarUsuarioPorUsername(String username) {
        Usuario usuarioLogeado = new Usuario();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call BUSCAR_USUARIO_POR_USERNAME(?)}");
            cs.setString("_USERNAME", username);
            
            rs = cs.executeQuery();
            
            if(rs.next()){
                usuarioLogeado.setUsername(rs.getString("USERNAME"));
                usuarioLogeado.setIdPersona(rs.getInt("ID_PERSONA")); 
                usuarioLogeado.setNombres(rs.getString("NOMBRES"));
                usuarioLogeado.setApellidos(rs.getString("APELLIDOS"));
                usuarioLogeado.setTelefono(rs.getString("TELEFONO"));
                usuarioLogeado.setCorreo(rs.getString("CORREO"));
                usuarioLogeado.setRol(rs.getString("ROL"));
                usuarioLogeado.setFechaFinContrato(rs.getDate("FECHA_FIN_CONTRATO"));
            }
                
        }catch(Exception ex){
            System.out.println(ex.getMessage());
            
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return usuarioLogeado;

    }
    
}
