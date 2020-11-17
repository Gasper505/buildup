
package pe.edu.pucp.ta.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import pe.edu.pucp.ta.config.DBManager;
import pe.edu.pucp.ta.dao.OperarioDAO;
import pe.edu.pucp.ta.model.Operario;


public class OperarioMySQL implements OperarioDAO{
    Connection con;
    CallableStatement cs;
    ResultSet rs;
    Statement st;

    @Override
    public int insertar(Operario op) {
                int resultado=0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);
            String sql = "{call INSERTAR_OPERARIO(?,?,?,?,?,?,?,?,?,?)}";
            cs = con.prepareCall(sql);
            cs.registerOutParameter("_ID_OPERARIO", java.sql.Types.INTEGER);
            cs.setString("_NOMBRES", op.getNombres());
            cs.setString("_APELLIDOS", op.getApellidos());
            cs.setDate("_FECHA_NACIMIENTO",new java.sql.Date(op.getFechaNacimiento().getTime()));
            cs.setString("_TELEFONO",op.getTelefono());
            cs.setString("_CORREO",op.getCorreo());
            cs.setString("_ROL",op.getRol());
            cs.setDate("_FECHA_FIN_CONTRATO",new java.sql.Date(op.getFechaFinContrato().getTime()));
            cs.setInt("_ID_LINEA_PRODUCCION", op.getLineaProduccion().getIdLineaProduccion());
            cs.setBytes("_PHOTO", op.getFoto());
            cs.executeUpdate();
            op.setIdPersona(cs.getInt("_ID_OPERARIO"));
            resultado=cs.getInt("_ID_OPERARIO");       
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    
    
    }

    @Override
    public int actualizar(Operario op) {
   int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user,DBManager.password);
            String sql =  "{call ACTUALIZAR_ESTADO_OPERARIO(?,?}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_OPERARIO", op.getIdPersona());
            cs.setBoolean("_ACTIVO", op.isActivo());
            cs.executeUpdate();
            op.setIdPersona(cs.getInt("_ID_OPERARIO"));
            resultado = 1;
        
        } catch(Exception ex){ 
            System.out.println(ex.getMessage());
        }finally{
            try{
                con.close();
            } catch (Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        return resultado;   
        
    }

    @Override
    public int eliminar(int idOp) {
        int resultado=0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);
            String sql = "{call ELIMINAR_OPERARIO(?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_OPERARIO",idOp);
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
    public ArrayList<Operario> listar() {
              ArrayList<Operario> operarios=new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);
            st=con.createStatement();
            String sql = "SELECT * FROM PERSONA WHERE ROL='OPERARIO'AND ACTIVO=1 ";
            rs = st.executeQuery(sql);  
            while(rs.next()){
                Operario operario = new Operario();
                operario.setIdPersona(rs.getInt("ID_PERSONA")); 
                operario.setNombres(rs.getString("NOMBRES"));
                operario.setApellidos(rs.getString("APELLIDOS"));
                operario.setTelefono(rs.getString("TELEFONO"));
                operario.setRol(rs.getString("ROL"));
                operario.setFechaFinContrato(rs.getDate("FECHA_FIN_CONTRATO"));
                operarios.add(operario);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
            
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return operarios;
    }
    
}
