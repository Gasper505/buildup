
package pe.edu.pucp.ta.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import pe.edu.pucp.ta.config.DBManager;
import pe.edu.pucp.ta.dao.JefeAreaDAO;
import pe.edu.pucp.ta.model.JefeArea;


public class JefeAreaMySQL implements JefeAreaDAO{
    Connection con;
    CallableStatement cs;
    ResultSet rs;
    Statement st;
    
    @Override
    public int insertar(JefeArea jefe) {
        int resultado=0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            String sql = "{call INSERTAR_JEFE_AREA(?,?,?,?,?,?,?,?,?,?)}";
            cs = con.prepareCall(sql);
            cs.registerOutParameter("_ID_JEFE_AREA", java.sql.Types.INTEGER);
            cs.setString("_NOMBRES", jefe.getNombres());
            cs.setString("_APELLIDOS", jefe.getApellidos());
            cs.setDate("_FECHA_NACIMIENTO",new java.sql.Date(jefe.getFechaNacimiento().getTime()));
            cs.setString("_TELEFONO", jefe.getTelefono());
            cs.setString("_CORREO", jefe.getCorreo());
            cs.setString("_ROL", jefe.getRol());
            cs.setDate("_FECHA_FIN_CONTRATO", new java.sql.Date(jefe.getFechaFinContrato().getTime()));
            cs.setBytes("_PHOTO", jefe.getFoto());
            cs.setBytes("_PHOTO_FIRMA", jefe.getFoto_firma());
            cs.executeUpdate();
            jefe.setIdPersona(cs.getInt("_ID_JEFE_AREA"));
            resultado=cs.getInt("_ID_JEFE_AREA");
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int actualizar_estado(int idPersona, boolean activo) {
        int resultado=0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            String sql = "{call ACTUALIZAR_ESTADO_JEFE_AREA(?,?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_JEFE_AREA", idPersona);
            cs.setBoolean("_ACTIVO", activo);
            resultado=cs.executeUpdate();;
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int modificar(JefeArea jefe) {
        int resultado=0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            String sql = "{call MODIFICAR_JEFE_AREA(?,?,?,?,?,?,?,?,?,?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_PERSONA", jefe.getIdPersona());
            cs.setString("_NOMBRES", jefe.getNombres());
            cs.setString("_APELLIDOS", jefe.getApellidos());
            cs.setDate("_FECHA_NACIMIENTO",new java.sql.Date(jefe.getFechaNacimiento().getTime()));
            cs.setString("_TELEFONO", jefe.getTelefono());
            cs.setString("_CORREO", jefe.getCorreo());
            cs.setString("_ROL", jefe.getRol());
            cs.setDate("_FECHA_FIN_CONTRATO", new java.sql.Date(jefe.getFechaFinContrato().getTime()));
            cs.setBytes("_PHOTO", jefe.getFoto());
            cs.setBytes("_PHOTO_FIRMA", jefe.getFoto_firma());
            resultado=cs.executeUpdate();;
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }
    @Override
    public int eliminar(int idJefe) {
        int resultado=0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            String sql = "{call ELIMINAR_JEFE_AREA(?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_JEFE_AREA", idJefe);
            resultado=cs.executeUpdate();
        
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public ArrayList<JefeArea> listar() {
        ArrayList<JefeArea> jefes = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            st = con.createStatement();
            String sql = "SELECT * FROM PERSONA WHERE ACTIVO = 1 AND ROL = 'Jefe de Area'"; //OJO
            rs = st.executeQuery(sql);
            
            while(rs.next()){
                JefeArea jefe = new JefeArea();
                jefe.setIdPersona(rs.getInt("ID_PERSONA"));
                jefe.setNombres(rs.getString("NOMBRES"));
                jefe.setApellidos(rs.getString("APELLIDOS"));
                jefe.setTelefono(rs.getString("TELEFONO"));
                jefe.setCorreo(rs.getString("CORREO"));
                jefe.setRol(rs.getString("ROL"));
                jefe.setFechaFinContrato(rs.getDate("FECHA_FIN_CONTRATO"));
            
                jefes.add(jefe);
            }
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{rs.close();con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return jefes;
    }
    @Override
    public byte[] obtener_foto_firma(int idJefeArea){
        byte[] foto_firma = {};
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);
            String sql = "{call OBTENER_JEFE_AREA_FOTO(?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_PERSONA",idJefeArea);
            rs=cs.executeQuery();     
            while(rs.next()){
                foto_firma = rs.getBytes("PHOTO_FIRMA");
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return foto_firma;
    }
}
