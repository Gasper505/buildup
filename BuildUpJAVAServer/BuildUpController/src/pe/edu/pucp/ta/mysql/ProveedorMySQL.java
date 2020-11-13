
package pe.edu.pucp.ta.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import pe.edu.pucp.ta.config.DBManager;
import pe.edu.pucp.ta.dao.ProveedorDAO;
import pe.edu.pucp.ta.model.Proveedor;


public class ProveedorMySQL implements ProveedorDAO{

    Connection con;
    CallableStatement cs;
    ResultSet rs;
    Statement st;
    @Override
    public int insertar(Proveedor proveedor) {
        int resultado=0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con =DriverManager.getConnection(DBManager.urlMySQL, DBManager.user,DBManager.password);
            String sql = "{call INSERTAR_PROVEEDOR(?,?,?,?)}";
            cs = con.prepareCall(sql);
            cs.registerOutParameter("_ID_PROVEEDOR", java.sql.Types.INTEGER);
            cs.setString("_RAZON_SOCIAL", proveedor.getRazonSocial());
            cs.setString("_CORREO", proveedor.getCorreo());
            cs.setString("_REPRESENTANTE", proveedor.getRepresentante());
            
            cs.executeUpdate();
            proveedor.setIdProveedor(cs.getInt("_ID_PROVEEDOR"));
            
            resultado=1;
        
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    
    }

    @Override
    public int actualizar(Proveedor proveedor) {
        int resultado=0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con =DriverManager.getConnection(DBManager.urlMySQL, DBManager.user,DBManager.password);
            String sql = "{call ACTUALIZAR_PROVEEDOR(?,?,?,?,?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_PROVEEDOR", proveedor.getIdProveedor());
            cs.setString("_RAZON_SOCIAL", proveedor.getRazonSocial());
            cs.setString("_CORREO",proveedor.getCorreo());
            cs.setString("_REPRESENTANTE", proveedor.getRepresentante());
            cs.setBoolean("_ACTIVO", proveedor.getActivo());
           
            cs.executeUpdate();
            proveedor.setIdProveedor(cs.getInt("_ID_PROVEEDOR"));       
            resultado=1;
        
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int eliminar(int idProveedor) {
         int resultado=0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con =DriverManager.getConnection(DBManager.urlMySQL, DBManager.user,DBManager.password);
            String sql = "{call ELIMINAR_PROVEEDOR(?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_PROVEEDOR", idProveedor);
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
    public ArrayList<Proveedor> listar() {
         ArrayList<Proveedor> proveedores=new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);
            st=con.createStatement();
            String sql = "SELECT * FROM PROVEEDOR WHERE ACTIVO=1";
            rs = st.executeQuery(sql);  
            while(rs.next()){
                Proveedor proveedor = new Proveedor();
                proveedor.setIdProveedor(rs.getInt("ID_PROVEEDOR"));
                proveedor.setRazonSocial(rs.getString("RAZON_SOCIAL"));
                proveedor.setCorreo(rs.getString("CORREO"));
                proveedor.setRepresentante(rs.getString("REPRESENTANTE"));
                proveedor.setActivo(rs.getBoolean("ACTIVO"));
                proveedores.add(proveedor);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
            
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return proveedores;
    }
    
}
