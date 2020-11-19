
package pe.edu.pucp.ta.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import pe.edu.pucp.ta.config.DBManager;
import pe.edu.pucp.ta.dao.InsumoDAO;
import pe.edu.pucp.ta.model.Insumo;


public class InsumoMySQL implements InsumoDAO{
        Connection con;
        CallableStatement cs;
        ResultSet rs;
        Statement st;
        
    @Override
    public int insertar(Insumo insumo) {
        int resultado=0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            String sql = "{call INSERTAR_INSUMO(?,?,?)}";
            cs = con.prepareCall(sql);
            cs.registerOutParameter("_ID_INSUMO", java.sql.Types.INTEGER);
            cs.setString("_NOMBRE", insumo.getNombre());
            cs.setString("_UNIDAD_MEDIDA", insumo.getUnidadMedida());
            cs.executeUpdate();
            insumo.setIdInsumo(cs.getInt("_ID_INSUMO"));
            resultado=insumo.getIdInsumo();
        
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int actualizar(Insumo insumo) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public int eliminar(int idInsumo) {
        int resultado=0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            
            String sql = "{call ELIMINAR_INSUMO(?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_INSUMO", idInsumo);
            
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
    public ArrayList<Insumo> listar() {
        ArrayList<Insumo> insumos = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            st = con.createStatement();
            String sql = "SELECT * FROM INSUMO WHERE ACTIVO = 1";
            rs = st.executeQuery(sql);
            while(rs.next()){
                Insumo insumo= new Insumo();
                insumo.setIdInsumo(rs.getInt("ID_INSUMO"));
                insumo.setNombre(rs.getString("NOMBRE"));
                insumo.setUnidadMedida(rs.getString("UNIDAD_MEDIDA"));
                insumos.add(insumo);
            }
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{rs.close();con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return insumos;
    }
    
}
