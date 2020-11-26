
package pe.edu.pucp.ta.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import pe.edu.pucp.ta.config.DBManager;
import pe.edu.pucp.ta.dao.RespuestaDAO;
import pe.edu.pucp.ta.model.Respuesta;


public class RespuestaMySQL implements RespuestaDAO{

    Connection con;
    CallableStatement cs;
    ResultSet rs;
    Statement st;
     
    @Override
    public int insertar(Respuesta resp) {
        int resultado=0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con =DriverManager.getConnection(DBManager.urlMySQL, DBManager.user,DBManager.password);
            String sql = "{call INSERTAR_RESPUESTA(?,?)}";
            cs = con.prepareCall(sql);
            cs.registerOutParameter("_ID_RESPUESTA", java.sql.Types.INTEGER);
            cs.setString("_TIPO", resp.getTipo());
            //cs.setBoolean("_ACTIVO", resp.getActivo());
            cs.executeUpdate();
            resp.setIdRespuesta(cs.getInt("_ID_RESPUESTA"));
       
            resultado=1;
        
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    
    }

    @Override
    public int actualizar(Respuesta resp) {
        int resultado=0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con =DriverManager.getConnection(DBManager.urlMySQL, DBManager.user,DBManager.password);
            String sql = "{call ACTUALIZAR_RESPUESTA(?,?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_RESPUESTA", resp.getIdRespuesta());
            cs.setString("_TIPO", resp.getTipo());
            //cs.setBoolean("_ACTIVO", resp.getActivo());
            cs.executeUpdate();
            //resp.setIdRespuesta(cs.getInt("_ID_RESPUESTA"));
       
            resultado=1;
        
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    
    }

    @Override
    public int eliminar(int idResp) {
         int resultado=0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con =DriverManager.getConnection(DBManager.urlMySQL, DBManager.user,DBManager.password);
            String sql = "{call ELIMINAR_RESPUESTA(?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_RESPUESTA", idResp);
            cs.executeUpdate();       
            resultado=1;
        
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public ArrayList<Respuesta> listar() {
        ArrayList<Respuesta> respuestas=new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);
            cs = con.prepareCall("{call LISTAR_RESPUESTAS()}");
            rs = cs.executeQuery();
            while(rs.next()){
                Respuesta respuesta = new Respuesta();
                respuesta.setIdRespuesta(rs.getInt("ID_RESPUESTA"));
                respuesta.setTipo(rs.getString("TIPO"));
                respuesta.setActivo(rs.getBoolean("ACTIVO"));
                respuestas.add(respuesta);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
            
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return respuestas;
    }
    
}
