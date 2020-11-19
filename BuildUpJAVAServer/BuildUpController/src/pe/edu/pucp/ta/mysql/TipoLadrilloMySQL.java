
package pe.edu.pucp.ta.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import pe.edu.pucp.ta.config.DBManager;
import pe.edu.pucp.ta.dao.TipoLadrilloDAO;
import pe.edu.pucp.ta.model.TipoLadrillo;


public class TipoLadrilloMySQL implements TipoLadrilloDAO{
    Connection con;
    CallableStatement cs;
    ResultSet rs;
    Statement st;
    
    @Override
    public int insertar(TipoLadrillo tipoLadrillo) {
        int resultado=0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            String sql = "{call INSERTAR_TIPO_LADRILLO(?,?,?,?,?)}";
            cs = con.prepareCall(sql);
            
            cs.registerOutParameter("_ID_TIPO_LADRILLO", java.sql.Types.INTEGER);
            cs.setString("_NOMBRE", tipoLadrillo.getNombre());
            cs.setDouble("_LARGO", tipoLadrillo.getLargo());
            cs.setDouble("_ANCHO", tipoLadrillo.getAncho());
            cs.setDouble("_ALTURA", tipoLadrillo.getAltura());
            
            cs.executeUpdate();
            tipoLadrillo.setIdTipoLadrillo(cs.getInt("_ID_TIPO_LADRILLO"));
            
            resultado=1;
        
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int actualizar(TipoLadrillo tipoLadrillo) {
        int resultado=0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            String sql = "{call MODIFICAR_TIPO_LADRILLO(?,?,?,?,?)}";
            cs = con.prepareCall(sql);
            
            cs.setInt("_ID_TIPO_LADRILLO", tipoLadrillo.getIdTipoLadrillo());
            cs.setString("_NOMBRE", tipoLadrillo.getNombre());
            cs.setDouble("_LARGO", tipoLadrillo.getLargo());
            cs.setDouble("_ANCHO", tipoLadrillo.getAncho());
            cs.setDouble("_ALTURA", tipoLadrillo.getAltura());
            
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
    public int eliminar(int idTipoLadrillo) {
        int resultado=0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            String sql = "{call ELIMINAR_TIPO_LADRILLO(?)}";
            cs = con.prepareCall(sql);
            
            cs.setInt("_ID_TIPO_LADRILLO", idTipoLadrillo);
            
            cs.executeUpdate();
            
            resultado = 1;
        
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public ArrayList<TipoLadrillo> listar() {
        ArrayList<TipoLadrillo> ladrillos = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call LISTAR_TIPOS_LADRILLO()}");
            rs = cs.executeQuery();
            while(rs.next()){
                TipoLadrillo lad = new TipoLadrillo();
                lad.setIdTipoLadrillo(rs.getInt("ID_TIPO_LADRILLO")); 
                lad.setNombre(rs.getString("NOMBRE"));
                lad.setAncho(rs.getDouble("ANCHO"));
                lad.setAltura(rs.getDouble("ALTURA"));
                lad.setLargo(rs.getDouble("LARGO"));
                ladrillos.add(lad);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
            
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return ladrillos;
    }
    
    @Override
    public ArrayList<TipoLadrillo> listarTipoLadrilloPorNombre(String nombre) {
        ArrayList<TipoLadrillo> ladrillos = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call LISTAR_TIPOS_LADRILLO_POR_NOMBRE(?)}");
            cs.setString("_NOMBRE_LADRILLO", nombre);
            rs = cs.executeQuery();
            while(rs.next()){
                TipoLadrillo lad = new TipoLadrillo();
                lad.setIdTipoLadrillo(rs.getInt("ID_TIPO_LADRILLO")); 
                lad.setNombre(rs.getString("NOMBRE"));
                lad.setAncho(rs.getDouble("ANCHO"));
                lad.setAltura(rs.getDouble("ALTURA"));
                lad.setLargo(rs.getDouble("LARGO"));
                ladrillos.add(lad);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
            
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return ladrillos;
    }
    
    
}
