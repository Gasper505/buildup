
package pe.edu.pucp.ta.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.util.Date;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import pe.edu.pucp.ta.config.DBManager;
import pe.edu.pucp.ta.dao.OrdenInsumosDAO;
import pe.edu.pucp.ta.model.OrdenInsumos;


public class OrdenInsumosMySQL implements OrdenInsumosDAO{
    Connection con;
    CallableStatement cs;
    ResultSet rs;
    Statement st;

    @Override
    public int insertar(OrdenInsumos ordenInsumos) {
            int resultado=0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            String sql = "{call INSERTAR_ORDEN_INSUMOS(?,?,?,?)}";
            cs = con.prepareCall(sql);
            cs.registerOutParameter("_ID_ORDEN_INSUMOS", java.sql.Types.INTEGER);
            cs.setInt("_ID_INSUMO",ordenInsumos.getInsumo().getIdInsumo());
            cs.setInt("_ID_OPERARIO",ordenInsumos.getOperario().getIdPersona());
            cs.setDouble("_CANTIDAD",ordenInsumos.getCantidad());
            cs.executeUpdate();
            ordenInsumos.setIdOrdenInsumos(cs.getInt("_ID_ORDEN_INSUMOS"));
            resultado=ordenInsumos.getIdOrdenInsumos();       
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int modificar(OrdenInsumos ordenInsumos) {
        int resultado=0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            String sql = "{call MODIFICAR_ORDEN_INSUMOS(?,?,?,?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_ORDEN_INSUMOS",ordenInsumos.getIdOrdenInsumos());
            cs.setInt("_ID_INSUMO",ordenInsumos.getInsumo().getIdInsumo());
            cs.setInt("_ID_OPERARIO",ordenInsumos.getIdOrdenInsumos());
            cs.setInt("_CANTIDAD",ordenInsumos.getCantidad());
            resultado=cs.executeUpdate();       
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;  
    }

    @Override
    public int eliminar(int idOrdenInsumos) {
        int resultado=0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            String sql = "{call ELIMINAR_ORDEN_INSUMOS(?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_ORDEN_INSUMOS",idOrdenInsumos);
            resultado=cs.executeUpdate();       
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public ArrayList<OrdenInsumos> listar() {
        ArrayList<OrdenInsumos> ordenes=new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            cs=con.prepareCall("{call LISTAR_ORDEN_INSUMOS()}");
            rs = cs.executeQuery();
            while(rs.next()){
                OrdenInsumos orden = new OrdenInsumos();
                orden.setIdOrdenInsumos(rs.getInt("ID_ORDEN_INSUMOS")); 
                orden.setFecha(rs.getDate("FECHA_REGISTRO"));
                orden.setIdOperario(rs.getInt("ID_OPERARIO"));    
                orden.getOperario().setNombres(rs.getString("NOMBRE_OPERARIO"));
                orden.setIdInsumo(rs.getInt("ID_INSUMO"));    
                orden.getInsumo().setNombre(rs.getString("NOMBRE_INSUMO"));
                orden.setCantidad(rs.getInt("CANTIDAD"));
                orden.setEstado(rs.getBoolean("ESTADO_ORDEN"));
                ordenes.add(orden);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
            
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return ordenes;
    }

    @Override
    public ArrayList<OrdenInsumos> listar_por_fecha(Date fechaIni, Date fechaFin) {
        ArrayList<OrdenInsumos> ordenes=new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            cs=con.prepareCall("{call LISTAR_ORDEN_INSUMOS_POR_RANGO_FECHAS(?,?)}");
            cs.setDate("_FECHA_INICIO", (java.sql.Date) fechaIni);
            cs.setDate("_FECHA_FIN", (java.sql.Date) fechaFin);
            rs = cs.executeQuery();
            while(rs.next()){
                OrdenInsumos orden = new OrdenInsumos();
                orden.setIdOrdenInsumos(rs.getInt("ID_ORDEN_INSUMOS")); 
                orden.setFecha(rs.getDate("FECHA_REGISTRO"));
                orden.setIdOperario(rs.getInt("ID_OPERARIO"));    
                orden.getOperario().setNombres(rs.getString("NOMBRE_OPERARIO"));
                orden.setIdInsumo(rs.getInt("ID_INSUMO"));    
                orden.getInsumo().setNombre(rs.getString("NOMBRE_INSUMO"));
                orden.setCantidad(rs.getInt("CANTIDAD"));
                orden.setEstado(rs.getBoolean("ESTADO_ORDEN"));
                ordenes.add(orden);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
            
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return ordenes;
    }
    
    
}
