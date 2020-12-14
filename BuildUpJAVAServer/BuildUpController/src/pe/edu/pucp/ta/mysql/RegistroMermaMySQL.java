    
package pe.edu.pucp.ta.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.Date;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import pe.edu.pucp.ta.config.DBManager;
import pe.edu.pucp.ta.dao.RegistroMermaDAO;
import pe.edu.pucp.ta.model.RegistroMerma;


public class RegistroMermaMySQL implements RegistroMermaDAO {
    Connection con;
    CallableStatement cs;
    ResultSet rs;
    Statement st;
    @Override
    public int insertar(RegistroMerma regMerma) {
         int resultado=0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            String sql = "{call INSERTAR_REGISTRO_MERMA(?,?,?,?,?)}";
            cs = con.prepareCall(sql);
            
            cs.registerOutParameter("_ID_REGISTRO_MERMA", java.sql.Types.INTEGER);
            cs.setInt("_ID_SUPERVISOR", regMerma.getSupervisor().getIdPersona());
            cs.setInt("_ID_LINEA_PRODUCCION", regMerma.getLineaProduccion().getIdLineaProduccion());
            cs.setInt("_ID_MERMA", regMerma.getMerma().getIdMerma());
            cs.setInt("_CANTIDAD", regMerma.getCantidad());
            //cs.setDate("_FECHA", new java.sql.Date(regMerma.getFecha().getTime()));
            
            cs.executeUpdate();
            regMerma.setIdRegistroMerma(cs.getInt("_ID_REGISTRO_MERMA"));
            
            resultado=1;
        
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int actualizar(RegistroMerma regMerma) {
        int resultado=0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            String sql = "{call ACTUALIZAR_REGISTRO_MERMA(?,?,?,?,?)}";
            cs = con.prepareCall(sql);
            
            cs.setInt("_ID_REGISTRO_MERMA", regMerma.getIdRegistroMerma());
            cs.setInt("_ID_SUPERVISOR", regMerma.getSupervisor().getIdPersona());
            cs.setInt("_ID_LINEA_PRODUCCION", regMerma.getLineaProduccion().getIdLineaProduccion());
            cs.setInt("_ID_MERMA", regMerma.getMerma().getIdMerma());
            cs.setInt("_CANTIDAD", regMerma.getCantidad());
            
            cs.executeUpdate();
            regMerma.setIdRegistroMerma(cs.getInt("_ID_REGISTRO_MERMA"));
            resultado=1;
        
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    
    }

    @Override
    public int eliminar(int idRegistroMerma) {
        int resultado=0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con =DriverManager.getConnection(DBManager.urlMySQL, DBManager.user,DBManager.password);
            String sql = "{call ELIMINAR_REGISTRO_MERMA(?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_REGISTRO_MERMA", idRegistroMerma);
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
    public ArrayList<RegistroMerma> listar() {
        ArrayList<RegistroMerma> registrosMermas=new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);
            st=con.createStatement();
            String sql = "SELECT * FROM REGISTRO_MERMA WHERE ACTIVO=1";
            rs = st.executeQuery(sql);  
            while(rs.next()){
                RegistroMerma regMerma = new RegistroMerma();
                regMerma.setIdRegistroMerma(rs.getInt("ID_REGISTRO_MERMA"));
                regMerma.getLineaProduccion().setIdLineaProduccion(rs.getInt("ID_LINEA_PRODUCCION"));
                regMerma.getMerma().setIdMerma(rs.getInt("ID_MERMA"));                                  
                regMerma.setCantidad(rs.getInt("CANTIDAD"));
                regMerma.setFecha(rs.getDate("FECHA"));
                regMerma.setActivo(rs.getBoolean("ACTIVO"));                
                registrosMermas.add(regMerma);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
            
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return registrosMermas;
    
    }
    @Override
    public ArrayList<RegistroMerma> listarRegistrosMermasPorSupervisorYRangoFechas(String nombreSup, Date fechaInicial, Date fechaFin){
        ArrayList<RegistroMerma> registrosMermas=new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);
            cs = con.prepareCall("{call LISTAR_REGISTROS_MERMAS_POR_NOMBRE_SUPERVISOR_RANGO_FECHAS(?,?,?)}");
            cs.setString("_NOMBRE_SUPERVISOR", nombreSup);
            cs.setDate("_FECHA_INICIO", fechaInicial);
            cs.setDate("_FECHA_FIN", fechaFin);
            rs = cs.executeQuery();  
            while(rs.next()){
                RegistroMerma regMerma = new RegistroMerma();
                regMerma.setIdRegistroMerma(rs.getInt("ID_REGISTRO_MERMA"));
                regMerma.getLineaProduccion().setIdLineaProduccion(rs.getInt("ID_LINEA_PRODUCCION")); 
                regMerma.getLineaProduccion().setNombre(rs.getString("NOMBRE_LINEA_PRODUCCION"));
                regMerma.getSupervisor().setIdPersona(rs.getInt("ID_SUPERVISOR"));
                regMerma.getSupervisor().setNombres(rs.getString("NOMBRE_SUPERVISOR"));
                regMerma.getMerma().setIdMerma(rs.getInt("ID_MERMA"));  
                regMerma.getMerma().setTipo(rs.getString("TIPO_MERMA"));
                regMerma.setCantidad(rs.getInt("CANTIDAD"));
                regMerma.setFecha(rs.getDate("FECHA_REGISTRO"));            
                registrosMermas.add(regMerma);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
            
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        
        return registrosMermas;
    }
       
                                                                                   
    
}
