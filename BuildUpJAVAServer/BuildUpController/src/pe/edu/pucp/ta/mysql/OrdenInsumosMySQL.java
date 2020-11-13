
package pe.edu.pucp.ta.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
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
            String sql = "{call INSERTAR_ORDEN_INSUMOS(?,?,?,?,?)}";
            cs = con.prepareCall(sql);
            cs.registerOutParameter("_ID_ORDEN_INSUMOS", java.sql.Types.INTEGER);
            cs.setInt("_ID_OPERARIO",ordenInsumos.getOperario().getIdPersona());
            cs.setInt("_ID_INSUMO",ordenInsumos.getInsumo().getIdInsumo());
            cs.setDouble("_CANTIDAD",ordenInsumos.getCantidad());
            cs.setDate("_FECHA",new java.sql.Date(ordenInsumos.getFecha().getTime()));
            cs.executeUpdate();
            ordenInsumos.setIdOrdenInsumos(cs.getInt("_ID_ORDEN_INSUMOS"));
            resultado=1;       
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int actualizar(OrdenInsumos ordenInsumos) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
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
    public ArrayList<OrdenInsumos> listar() {
        ArrayList<OrdenInsumos> ordenes=new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            st=con.createStatement();
            String sql = "SELECT * FROM ORDEN_INSUMOS";
            rs = st.executeQuery(sql);  
            while(rs.next()){
                OrdenInsumos orden = new OrdenInsumos();
                orden.setIdOrdenInsumos(rs.getInt("ID_ORDEN_INSUMOS")); 
//                orden.setIdOperario(rs.getInt("ID_OPERARIO"));                   //
//                orden.setIdInsumo(rs.getInt("ID_INSUMO"));                       //
                orden.setCantidad(rs.getDouble("CANTIDAD"));
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
    
    
}
