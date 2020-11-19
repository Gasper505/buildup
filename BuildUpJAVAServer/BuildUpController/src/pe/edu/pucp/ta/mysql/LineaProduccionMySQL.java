
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
            resultado=lineaProduccion.getIdLineaProduccion();
        
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
            resultado=cs.executeUpdate();
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
            resultado=cs.executeUpdate();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public ArrayList<LineaProduccion> listarPorNombre(String nombre) {
        ArrayList<LineaProduccion> lineas = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call LISTAR_LINEA_PRODUCCION_POR_NOMBRE(?)}");
            cs.setString("_NOMBRE_LINEA_PRODUCCION", nombre);
            rs = cs.executeQuery();
            while(rs.next()){
                LineaProduccion linProd = new LineaProduccion();
                linProd.setIdLineaProduccion(rs.getInt("ID_LINEA_PRODUCCION"));
                linProd.setNombre(rs.getString("NOMBRE_LINEA_PRODUCCION"));
                linProd.getTipoLadrillo().setNombre(rs.getString("NOMBRE_LADRILLO"));
                lineas.add(linProd);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return lineas;
    }

    @Override
    public int modificar(LineaProduccion lineaProduccion) {
        int resultado=0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            String sql = "{call MODIFICAR_LINEA_PRODUCCION(?,?,?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_LINEA_PRODUCCION", lineaProduccion.getIdLineaProduccion());
            cs.setString("_NOMBRE", lineaProduccion.getNombre());
            cs.setInt("_ID_TIPO_LADRILLO", lineaProduccion.getTipoLadrillo().getIdTipoLadrillo());
            resultado=cs.executeUpdate();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }
}
