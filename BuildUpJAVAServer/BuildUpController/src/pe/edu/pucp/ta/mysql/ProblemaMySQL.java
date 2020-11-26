
package pe.edu.pucp.ta.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import pe.edu.pucp.ta.config.DBManager;
import pe.edu.pucp.ta.dao.ProblemaDAO;
import pe.edu.pucp.ta.model.Problema;


public class ProblemaMySQL implements ProblemaDAO {

    Connection con;
    CallableStatement cs;
    ResultSet rs;
    Statement st;
    @Override
    public int insertar(Problema prob) {
         int resultado=0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con =DriverManager.getConnection(DBManager.urlMySQL, DBManager.user,DBManager.password);
            String sql = "{call INSERTAR_PROBLEMA(?,?,?)}";
            cs = con.prepareCall(sql);
            cs.registerOutParameter("_ID_PROBLEMA", java.sql.Types.INTEGER);
            cs.setString("_TIPO", prob.getTipo());
            cs.setInt("_NIVEL_IMPORTANCIA", prob.getNivelImportancia());
            //cs.setBoolean("_ACTIVO", prob.getActivo());
            cs.executeUpdate();
            prob.setIdProblema(cs.getInt("_ID_PROBLEMA"));
            resultado=1;
        
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
        
    }

    @Override
    public int actualizar(Problema prob) {
        int resultado=0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con =DriverManager.getConnection(DBManager.urlMySQL, DBManager.user,DBManager.password);
            String sql = "{call ACTUALIZAR_PROBLEMA(?,?,?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_PROBLEMA", prob.getIdProblema());
            cs.setString("_TIPO", prob.getTipo());
            cs.setInt("_NIVEL_IMPORTANCIA", prob.getNivelImportancia());
            //cs.setBoolean("_ACTIVO", prob.getActivo());
            cs.executeUpdate();
            //prob.setIdProblema(cs.getInt("_ID_PROBLEMA")); 
       
            resultado=1;
        
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int eliminar(int idProb) {
        int resultado=0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con =DriverManager.getConnection(DBManager.urlMySQL, DBManager.user,DBManager.password);
            String sql = "{call ELIMINAR_PROBLEMA(?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_PROBLEMA", idProb);
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
    public ArrayList<Problema> listar() {
        ArrayList<Problema> problemas=new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);
            cs = con.prepareCall("{call LISTAR_PROBLEMAS()}");
            rs = cs.executeQuery(); 
            while(rs.next()){
                Problema problema = new Problema();
                problema.setIdProblema(rs.getInt("ID_PROBLEMA"));
                problema.setTipo(rs.getString("TIPO"));
                problema.setNivelImportancia(rs.getInt("NIVEL_IMPORTANCIA"));
                problema.setActivo(rs.getBoolean("ACTIVO"));
                problemas.add(problema);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
            
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return problemas;
    }
    
}
