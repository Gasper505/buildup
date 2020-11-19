
package pe.edu.pucp.ta.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import pe.edu.pucp.ta.config.DBManager;
import pe.edu.pucp.ta.dao.MaquinariaDAO;
import pe.edu.pucp.ta.model.LineaProduccion;
import pe.edu.pucp.ta.model.Maquinaria;


public class MaquinariaMySQL implements MaquinariaDAO{
    Connection con;
    CallableStatement cs;
    ResultSet rs;
    Statement st;
    
    @Override
    public int insertar(Maquinaria maquinaria) {
        int resultado=0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            String sql = "{call INSERTAR_MAQUINARIA(?,?,?,?,?)}";
            cs = con.prepareCall(sql);
            
            cs.registerOutParameter("_ID_MAQUINARIA", java.sql.Types.INTEGER);
            cs.setInt("_ID_LINEA_PRODUCCION", maquinaria.getLineaProduccion().getIdLineaProduccion());
            cs.setInt("_ID_PROVEEDOR", maquinaria.getProveedor().getIdProveedor());
            cs.setString("_NOMBRE", maquinaria.getNombre());
            cs.setDate("_GARANTIA_FIN", new java.sql.Date(maquinaria.getGarantiaFin().getTime()));
            
            cs.executeUpdate();
            maquinaria.setIdMaquinaria(cs.getInt("_ID_MAQUINARIA"));
            
            resultado=1;
        
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int actualizar(int idMaquinaria, boolean nuevo) {
        int resultado=0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            String sql = "{call ACTUALIZAR_ESTADO_MAQUINARIA(?,?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_MAQUINARIA", idMaquinaria);
            cs.setBoolean("_ACTIVO", nuevo);
            resultado=cs.executeUpdate();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int eliminar(int idMaquinaria) {
        int resultado=0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            String sql = "{call ELIMINAR_MAQUINARIA(?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_MAQUINARIA", idMaquinaria);
            resultado=cs.executeUpdate();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public ArrayList<Maquinaria> listar() {
        ArrayList<Maquinaria> maquinarias = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            st = con.createStatement();
            String sql = "SELECT * FROM MAQUINARIA WHERE ACTIVO = 1";
            rs = st.executeQuery(sql);
            
            while(rs.next()){
                Maquinaria maquinaria = new Maquinaria();
                
                maquinaria.setIdMaquinaria(rs.getInt("ID_MAQUINARIA"));
//                maquinaria.getLineaProduccion().setIdLineaProduccion(rs.getInt("ID_LINEA_PRODUCCION"));
//                maquinaria.getProveedor().setIdProveedor(rs.getInt("ID_PROVEEDOR"));
                maquinaria.setNombre(rs.getString("NOMBRE"));
                maquinaria.setGarantiaFin(rs.getDate("GARANTIA_FIN"));
                maquinaria.setActivo(rs.getBoolean("ACTIVO"));
            
                maquinarias.add(maquinaria);
            }
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{rs.close();con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return maquinarias;
    }

    @Override
    public ArrayList<Maquinaria> listarMaquinariaPorNombreMaqNombreLinea(String nombreMaq, String nombreLineaProd) {
        ArrayList<Maquinaria> maquinas = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call LISTAR_MAQUINARIA_POR_NOMBREMAQ_NOMBRELINEA(?,?)}");
            cs.setString("_NOMBRE_MAQUINARIA", nombreMaq);
            cs.setString("_NOMBRE_LINEA_PRODUCCION", nombreLineaProd);
            rs = cs.executeQuery();
            while(rs.next()){
                Maquinaria maq = new Maquinaria();
                maq.setIdMaquinaria(rs.getInt("ID_MAQUINARIA")); 
                maq.setNombre(rs.getString("NOMBRE_MAQUINARIA"));
                maq.setGarantiaFin(rs.getDate("FECHA_FIN_GARANTIA"));
                maq.getLineaProduccion().setIdLineaProduccion(rs.getInt("LINEA_PRODUCCION"));
                maq.getLineaProduccion().setNombre(rs.getString("NOMBRE_LINEA_PRODUCCION"));
                maq.getProveedor().setIdProveedor(rs.getInt("ID_PROVEEDOR"));
                maq.getProveedor().setRazonSocial(rs.getString("NOMBRE_PROVEEDOR"));
                maq.getProveedor().setRepresentante(rs.getString("REPRESENTANTE_PROVEEDOR"));
                maq.getProveedor().setCorreo(rs.getString("CORREO_PROVEEDOR"));
                maquinas.add(maq);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
            
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return maquinas;
    }

    @Override
    public int modificar(Maquinaria maquinaria) {
        int resultado=0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            String sql = "{call MODIFICAR_MAQUINARIA(?,?,?,?,?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_MAQUINARIA", maquinaria.getIdMaquinaria());
            cs.setInt("_ID_LINEA_PRODUCCION", maquinaria.getLineaProduccion().getIdLineaProduccion());
            cs.setInt("_ID_PROVEEDOR", maquinaria.getProveedor().getIdProveedor());
            cs.setString("_NOMBRE", maquinaria.getNombre());
            cs.setDate("_GARANTIA_FIN", new java.sql.Date(maquinaria.getGarantiaFin().getTime()));
            resultado=cs.executeUpdate();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }
    
}
