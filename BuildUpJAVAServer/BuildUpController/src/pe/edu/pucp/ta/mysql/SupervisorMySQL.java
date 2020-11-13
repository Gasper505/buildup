
package pe.edu.pucp.ta.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import pe.edu.pucp.ta.config.DBManager;
import pe.edu.pucp.ta.dao.SupervisorDAO;
import pe.edu.pucp.ta.model.Supervisor;


public class SupervisorMySQL implements SupervisorDAO{

    Connection con;
    CallableStatement cs;
    ResultSet rs;
    Statement st;
    @Override
    public int insertar(Supervisor sup) {
            int resultado=0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            String sql = "{call INSERTAR_SUPERVISOR(?,?,?,?,?,?,?,?)}";
            cs = con.prepareCall(sql);
            
            cs.registerOutParameter("_ID_SUPERVISOR", java.sql.Types.INTEGER);
            cs.setString("_NOMBRES", sup.getNombres());
            cs.setString("_APELLIDOS", sup.getApellidos());
            cs.setString("_TELEFONO", sup.getTelefono());
            cs.setString("_CORREO", sup.getCorreo());
            cs.setString("_ROL", sup.getRol());
            cs.setDate("_FECHA_FIN_CONTRATO", new java.sql.Date(sup.getFechaFinContrato().getTime()));
            cs.setInt("_ID_LINEA_PRODUCCION", sup.getLineaProduccion().getIdLineaProduccion());
            
            cs.executeUpdate();
            sup.setIdPersona(cs.getInt("_ID_SUPERVISOR"));
            
            resultado=1;
        
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int actualizar(int idPersona, boolean nuevo) {
        int resultado=0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            String sql = "{call ACTUALIZAR_ESTADO_SUPERVISOR(?,?)}";
            cs = con.prepareCall(sql);
            
            cs.setInt("_ID_SUPERVISOR", idPersona);
            cs.setBoolean("_ACTIVO", nuevo);
            
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
    public int eliminar(int idSup) {
    int resultado=0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            String sql = "{call ELIMINAR_SUPERVISOR(?)}";
            cs = con.prepareCall(sql);
            
            cs.setInt("_ID_SUPERVISOR", idSup);
            
            cs.executeUpdate();
            resultado=1;
        
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;    }

    @Override
    public ArrayList<Supervisor> listar() {
        ArrayList<Supervisor> supervisores = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            st = con.createStatement();
            String sql = "SELECT * FROM PERSONA WHERE ACTIVO = 1 AND ROL = 'SUPERVISOR'";
            rs = st.executeQuery(sql);
            
            while(rs.next()){
                Supervisor supervisor = new Supervisor();
                supervisor.setIdPersona(rs.getInt("ID_PERSONA"));
                supervisor.setNombres(rs.getString("NOMBRES"));
                supervisor.setApellidos(rs.getString("APELLIDOS"));
                supervisor.setTelefono(rs.getString("TELEFONO"));
                supervisor.setCorreo(rs.getString("CORREO"));
                supervisor.setRol(rs.getString("ROL"));
                supervisor.setFechaFinContrato(rs.getDate("FECHA_FIN_CONTRATO"));
                supervisores.add(supervisor);
                
            }
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{rs.close();con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return supervisores;
    }
    
}
