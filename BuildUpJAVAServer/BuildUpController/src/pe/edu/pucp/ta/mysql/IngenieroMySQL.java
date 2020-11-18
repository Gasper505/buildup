
package pe.edu.pucp.ta.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import pe.edu.pucp.ta.config.DBManager;
import pe.edu.pucp.ta.dao.IngenieroDAO;
import pe.edu.pucp.ta.model.Ingeniero;


public class IngenieroMySQL implements IngenieroDAO{
    Connection con;
    CallableStatement cs;
    ResultSet rs;
    Statement st;

    @Override
    public int insertar(Ingeniero ing) {
        int resultado=0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);
            String sql = "{call INSERTAR_INGENIERO(?,?,?,?,?,?,?,?,?,?)}";
            cs = con.prepareCall(sql);
            cs.registerOutParameter("_ID_INGENIERO", java.sql.Types.INTEGER);
            cs.setString("_NOMBRES", ing.getNombres());
            cs.setString("_APELLIDOS", ing.getApellidos());
            cs.setDate("_FECHA_NACIMIENTO",new java.sql.Date(ing.getFechaNacimiento().getTime()));
            cs.setString("_TELEFONO", ing.getTelefono());
            cs.setString("_CORREO",ing.getCorreo());
            cs.setString("_ROL",ing.getRol());
            cs.setDate("_FECHA_FIN_CONTRATO",new java.sql.Date(ing.getFechaFinContrato().getTime()));
            cs.setBytes("_PHOTO", ing.getFoto());
            cs.setString("_ESPECIALIDAD", ing.getEspecialidad());
            cs.executeUpdate();
            ing.setIdPersona(cs.getInt("_ID_INGENIERO"));
            resultado=cs.getInt("_ID_INGENIERO");         
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
       
    }

    @Override
    public int actualizar_estado(int idIng, boolean activo) {
        int resultado=0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);
            String sql = "{call ACTUALIZAR_ESTADO_INGENIERO(?,?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_INGENIERO",idIng);
            cs.setBoolean("_ACTIVO",activo);
            resultado=cs.executeUpdate();;
        
        }catch(Exception ex){
            System.out.println(ex.getMessage());
            
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int modificar(Ingeniero ing) {
        int resultado=0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);
            String sql = "{call MODIFICAR_INGENIERO(?,?,?,?,?,?,?,?,?,?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_PERSONA",ing.getIdPersona());
            cs.setString("_ESPECIALIDAD", ing.getEspecialidad());
            cs.setString("_NOMBRES", ing.getNombres());
            cs.setString("_APELLIDOS", ing.getApellidos());
            cs.setDate("_FECHA_NACIMIENTO",new java.sql.Date(ing.getFechaNacimiento().getTime()));
            cs.setString("_TELEFONO", ing.getTelefono());
            cs.setString("_CORREO",ing.getCorreo());
            cs.setString("_ROL",ing.getRol());
            cs.setDate("_FECHA_FIN_CONTRATO",new java.sql.Date(ing.getFechaFinContrato().getTime()));
            cs.setBytes("_PHOTO", ing.getFoto());
            resultado=cs.executeUpdate();;
        
        }catch(Exception ex){
            System.out.println(ex.getMessage());
            
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }
    @Override
    public int eliminar(int idIng) {
        int resultado=0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);
            String sql = "{call ELIMINAR_INGENIERO(?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_INGENIERO",idIng);
            resultado=cs.executeUpdate();       
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public ArrayList<Ingeniero> listar() {
        ArrayList<Ingeniero> ingenieros=new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);
            st=con.createStatement();
            String sql = "SELECT * FROM PERSONA WHERE ROL='INGENIERO'";
            rs = st.executeQuery(sql);  
            while(rs.next()){
                Ingeniero ingeniero = new Ingeniero();
                ingeniero.setIdPersona(rs.getInt("ID_PERSONA")); 
                ingeniero.setNombres(rs.getString("NOMBRES"));
                ingeniero.setApellidos(rs.getString("APELLIDOS"));
                ingeniero.setTelefono(rs.getString("TELEFONO"));
                ingeniero.setRol(rs.getString("ROL"));
                ingeniero.setFechaFinContrato(rs.getDate("FECHA_FIN_CONTRATO"));
                ingenieros.add(ingeniero);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
            
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return ingenieros;
    }
    
    @Override
    public String obtener_especialidad(int idIng){
        String especialidad = "";
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);
            String sql = "{call OBTENER_INGENIERO_ESPECIALIDAD(?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_PERSONA",idIng);
            rs=cs.executeQuery();     
            while(rs.next()){
                especialidad = rs.getString("ESPECIALIDAD");
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return especialidad;
    }
    
}
