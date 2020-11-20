
package pe.edu.pucp.ta.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.Date;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import pe.edu.pucp.ta.config.DBManager;
import pe.edu.pucp.ta.dao.OrdenSalidaDAO;
import pe.edu.pucp.ta.model.LineaOrdenSalida;
import pe.edu.pucp.ta.model.OrdenSalida;


public class OrdenSalidaMySQL implements OrdenSalidaDAO{
    Connection con;
    CallableStatement cs;
    ResultSet rs;
    Statement st;
    
    @Override
    public int insertar(OrdenSalida ordenSalida) {
        int resultado=0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
            con.setAutoCommit(false);
            String sql = "{call INSERTAR_ORDEN_SALIDA(?,?)}";
            cs = con.prepareCall(sql);
            cs.registerOutParameter("_ID_ORDEN_SALIDA", java.sql.Types.INTEGER);
            cs.setInt("_ID_OPERARIO",ordenSalida.getOperario().getIdPersona());
            cs.executeUpdate();
            ordenSalida.setIdOrdenSalida(cs.getInt("_ID_ORDEN_SALIDA"));
            
            for(LineaOrdenSalida linea : ordenSalida.getLineasOrdenSalida()){
                cs = con.prepareCall("{call INSERTAR_LINEA_ORDEN_SALIDA(?,?,?,?)}");
                cs.setInt("_FID_ORDEN_SALIDA", ordenSalida.getIdOrdenSalida());
                cs.setInt("_FID_TIPO_LADRILLO", linea.getTipoLadrillo().getIdTipoLadrillo());
                cs.setInt("_CANTIDAD",linea.getCantidad());
                cs.registerOutParameter("_ID_LINEA_ORDEN_SALIDA", java.sql.Types.INTEGER);
                cs.executeUpdate();
                
                linea.setIdLineaOrdenSalida(cs.getInt("_ID_LINEA_ORDEN_SALIDA"));
                
            }
            
            con.commit();
            resultado = ordenSalida.getIdOrdenSalida();
            
        }catch(Exception ex){
            try{
                con.rollback();
            }catch(Exception exR){
                System.out.println(exR.getMessage());
            }
            System.out.println(ex.getMessage());
        }finally{
            try{
                con.setAutoCommit(true);
                con.close();
            }catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return resultado;
    }

    @Override
    public int actualizar(OrdenSalida ordenSalida) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            con.setAutoCommit(false);
            String sql = "{call MODIFICAR_ORDEN_SALIDA(?,?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_ORDEN_SALIDA", ordenSalida.getIdOrdenSalida());
            cs.setInt("_ID_OPERARIO", ordenSalida.getOperario().getIdPersona());
            cs.executeUpdate();
            //eliminar lineas anteriores
            sql = "call {ELIMINAR_LINEA_ORDEN_SALIDA(?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_ORDEN_SALIDA", ordenSalida.getIdOrdenSalida());
            cs.executeUpdate();
            //insertar nuevas lineas
            for(LineaOrdenSalida lov : ordenSalida.getLineasOrdenSalida()){
                sql = "{call INSERTAR_LINEA_ORDEN_SALIDA(?,?,?,?)}";
                cs = con.prepareCall(sql);
                cs.setInt("_FID_ORDEN_SALIDA", ordenSalida.getIdOrdenSalida());
                cs.setInt("_FID_TIPO_LADRILLO", lov.getTipoLadrillo().getIdTipoLadrillo());
                cs.setInt("_CANTIDAD",lov.getCantidad());
                cs.registerOutParameter("_ID_LINEA_ORDEN_SALIDA", java.sql.Types.INTEGER);
                cs.executeUpdate();
                lov.setIdLineaOrdenSalida(cs.getInt("_ID_LINEA_ORDEN_SALIDA"));
            }
            con.commit();
            resultado = 1;
        }catch(Exception ex){
            try{
                con.rollback();
            }catch(Exception exR){
                System.out.println(exR.getMessage());
            }
            System.out.println(ex.getMessage());
        }finally{
            try{
                con.setAutoCommit(true);
                con.close();
            }catch(Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return resultado;
    }

    @Override
    public int eliminar(int idOrdenSalida) {
        int resultado=0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            String sql = "{call ELIMINAR_ORDEN_SALIDA(?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_ORDEN_SALIDA",idOrdenSalida);
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
    public ArrayList<OrdenSalida> listar() {
           ArrayList<OrdenSalida> ordenes=new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            st=con.createStatement();
            String sql = "SELECT * FROM ORDEN_SALIDA";
            rs = st.executeQuery(sql);  
            while(rs.next()){
                OrdenSalida orden = new OrdenSalida();
                orden.setIdOrdenSalida(rs.getInt("ID_ORDEN_SALIDA"));
                orden.getOperario().setIdPersona(rs.getInt("ID_OPERARIO"));
                orden.setFecha(rs.getDate("FECHA"));
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
    public ArrayList<OrdenSalida> listarOrdenesSalidaConParametros(String nombreOperario, Date fecha_inf, Date fecha_sup) {
        ArrayList<OrdenSalida> ordenes = new ArrayList<>();
        try{            
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call LISTAR_ORDEN_SALIDA_POR_NOMBRE_OPERARIO_RANGO_FECHAS(?, ?, ?)}");
            cs.setString("_NOMBRE_OPERARIO", nombreOperario);
            cs.setDate("_FECHA_INICIO", fecha_inf);
            cs.setDate("_FECHA_FIN", fecha_sup);
            rs = cs.executeQuery();
            
            while(rs.next()){
                OrdenSalida orden = new OrdenSalida();
                orden.setIdOrdenSalida(rs.getInt("ID_ORDEN_SALIDA"));
                orden.getOperario().setIdPersona(rs.getInt("ID_OPERARIO"));
                orden.setFecha(rs.getDate("FECHA"));
                orden.getOperario().setNombres(rs.getString("NOMBRE_OPERARIO"));
                orden.getOperario().setApellidos(rs.getString("APELLIDO_OPERARIO"));
                orden.getOperario().getLineaProduccion().setNombre(rs.getString("NOMBRE_LINEA_PRODUCCION"));
                ordenes.add(orden);
            }
            rs.close();
            
            for(OrdenSalida orden : ordenes){
                cs = con.prepareCall("{call LISTAR_LINEAS_ORDEN_SALIDA_POR_ID_ORDEN_SALIDA(?)}");
                cs.setInt("_ID_ORDEN_SALIDA", orden.getIdOrdenSalida());
                rs = cs.executeQuery();
                while(rs.next()){
                    LineaOrdenSalida linea = new LineaOrdenSalida();
                    linea.getTipoLadrillo().setNombre(rs.getString("NOMBRE_TIPO_LADRILLO"));
                    linea.setCantidad(rs.getInt("CANTIDAD"));
                    orden.getLineasOrdenSalida().add(linea);
                }
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
            
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return ordenes;
    }
    
    
}
