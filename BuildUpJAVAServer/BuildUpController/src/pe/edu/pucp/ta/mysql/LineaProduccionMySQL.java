
package pe.edu.pucp.ta.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import pe.edu.pucp.ta.config.DBManager;
import pe.edu.pucp.ta.dao.LineaProduccionDAO;
import pe.edu.pucp.ta.model.LineaProduccion;


public class LineaProduccionMySQL implements LineaProduccionDAO{
    Connection con;
    CallableStatement cs;
    ResultSet rs;
    Statement st;
    
    @Override
    public int insertar(LineaProduccion lineaProduccion) {
        int resultado=0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            String sql = "{call INSERTAR_LINEA_PRODUCCION(?,?,?)}";
            cs = con.prepareCall(sql);
            
            cs.registerOutParameter("_ID_LINEA_PRODUCCION", java.sql.Types.INTEGER);
            cs.setString("_NOMBRE", lineaProduccion.getNombre());
            cs.setInt("_ID_TIPO_LADRILLO", lineaProduccion.getTipoLadrillo().getIdTipoLadrillo());
            
            cs.executeUpdate();
            lineaProduccion.setIdLineaProduccion(cs.getInt("_ID_LINEA_PRODUCCION"));
            
            resultado=1;
        
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int actualizar(int idLineaProduccion, int idTipoLadrillo) {
        int resultado=0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            String sql = "{call ACTUALIZAR_TIPO_LADRILLO_LINEA_PRODUCCION(?,?)}";
            cs = con.prepareCall(sql);
            
            cs.setInt("_ID_LINEA_PRODUCCION", idLineaProduccion);
            cs.setInt("_ID_TIPO_LADRILLO", idTipoLadrillo);
            
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
    public int eliminar(int idLineaProduccion) {
        int resultado=0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            String sql = "{call ELIMINAR_LINEA_PRODUCCION(?)}";
            cs = con.prepareCall(sql);
            
            cs.setInt("_ID_LINEA_PRODUCCION", idLineaProduccion);
            
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
    public ArrayList<LineaProduccion> listar() {
        ArrayList<LineaProduccion> lineas = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            st = con.createStatement();
            String sql = "SELECT * FROM LINEA_PRODUCCION WHERE ACTIVO = 1";
            rs = st.executeQuery(sql);
            
            while(rs.next()){
                LineaProduccion linea = new LineaProduccion();
                linea.setIdLineaProduccion(rs.getInt("ID_LINEA_PRODUCCION"));
                linea.setNombre(rs.getString("NOMBRE"));
                linea.getTipoLadrillo().setIdTipoLadrillo(rs.getInt("ID_TIPO_LADRILLO"));               //
            
                lineas.add(linea);
            }
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{rs.close();con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return lineas;
    }
    
}
