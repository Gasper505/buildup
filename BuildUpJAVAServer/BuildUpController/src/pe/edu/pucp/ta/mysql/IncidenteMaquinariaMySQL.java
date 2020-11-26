
package pe.edu.pucp.ta.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import java.sql.Date;
import pe.edu.pucp.ta.config.DBManager;
import pe.edu.pucp.ta.dao.IncidenteMaquinariaDAO;
import pe.edu.pucp.ta.model.IncidenteMaquinaria;
import pe.edu.pucp.ta.model.Ingeniero;
import pe.edu.pucp.ta.model.Respuesta;

public class IncidenteMaquinariaMySQL implements IncidenteMaquinariaDAO{
    
    Connection con;
    CallableStatement cs;
    ResultSet rs;
    Statement st;

    @Override
    public int insertar(IncidenteMaquinaria incidenteMaquinaria) {
        int resultado=0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);
            String sql = "{call INSERTAR_INCIDENTE_MAQUINARIA(?,?,?,?,?)}";
            cs = con.prepareCall(sql);
            cs.registerOutParameter("_ID_INCIDENTE", java.sql.Types.INTEGER);
            cs.setInt("_ID_MAQUINARIA",incidenteMaquinaria.getMaquinaria().getIdMaquinaria());
            cs.setInt("_ID_SUPERVISOR",incidenteMaquinaria.getSupervisor().getIdPersona());
            cs.setInt("_ID_PROBLEMA",incidenteMaquinaria.getProblema().getIdProblema());
            cs.setDate("_FECHA",new java.sql.Date(incidenteMaquinaria.getFechaIncidente().getTime()));
            cs.executeUpdate();
            incidenteMaquinaria.setIdIncidente(cs.getInt("_ID_INCIDENTE"));
            resultado=1;
        
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
        
    }

    @Override
    public int eliminar(int idIncidenteMaquinaria) {
        int resultado=0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            String sql = "{call ELIMINAR_INCIDENTE(?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_INCIDENTE", idIncidenteMaquinaria);
            resultado=cs.executeUpdate();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public ArrayList<IncidenteMaquinaria> listar() {
        ArrayList<IncidenteMaquinaria> incidentes=new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);
            st=con.createStatement();
            String sql = "SELECT * FROM INCIDENTE_MAQUINARIA";
            rs = st.executeQuery(sql);  
            while(rs.next()){
                IncidenteMaquinaria incidente = new IncidenteMaquinaria();
                incidente.setIdIncidente(rs.getInt("ID_INCIDENTE")); 
                incidente.setDetalle(rs.getString("DESCRIPCION_RESPUESTA"));
                incidente.setFechaIncidente(rs.getDate("FECHA_INCIDENTE"));
                incidente.setFechaAtencion(rs.getDate("FECHA_ATENCION"));
                incidente.setActivo(rs.getBoolean("ACTIVO"));
                incidentes.add(incidente);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
            
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return incidentes;
    }

    @Override
    public int insertarProblema(IncidenteMaquinaria incidenteMaquinaria) {
        int resultado=0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);
            String sql = "{call INSERTAR_INCIDENTE_MAQUINARIA_PROBLEMA(?,?,?,?)}";
            cs = con.prepareCall(sql);
            cs.registerOutParameter("_ID_INCIDENTE", java.sql.Types.INTEGER);
            cs.setInt("_ID_MAQUINARIA",incidenteMaquinaria.getMaquinaria().getIdMaquinaria());
            cs.setInt("_ID_SUPERVISOR",incidenteMaquinaria.getSupervisor().getIdPersona());
            cs.setInt("_ID_PROBLEMA",incidenteMaquinaria.getProblema().getIdProblema());
            resultado=cs.executeUpdate();
            incidenteMaquinaria.setIdIncidente(cs.getInt("_ID_INCIDENTE"));
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }
    @Override
    public int insertarRespuesta(IncidenteMaquinaria incidenteMaquinaria) {
        int resultado=0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);
            String sql = "{call INSERTAR_INCIDENTE_MAQUINARIA_RESPUESTA(?,?,?,?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_INCIDENTE",incidenteMaquinaria.getIdIncidente());
            cs.setInt("_ID_INGENIERO",incidenteMaquinaria.getIngeniero().getIdPersona());
            cs.setInt("_ID_RESPUESTA",incidenteMaquinaria.getRespuesta().getIdRespuesta());
            cs.setString("_DESCRIPCION_RESPUESTA",incidenteMaquinaria.getDetalle());
            resultado=cs.executeUpdate();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public ArrayList<IncidenteMaquinaria> listarPorRangoFecha(Date fechaIni, Date fechaFin) {
         ArrayList<IncidenteMaquinaria> incidentes=new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);
            cs=con.prepareCall("{call LISTAR_INCIDENTE_POR_RANGO_FECHAS(?,?)}");
            cs.setDate("_FECHA_INICIO", fechaIni);
            cs.setDate("_FECHA_FIN", fechaFin);
            rs = cs.executeQuery();  
            while(rs.next()){
                IncidenteMaquinaria incidente = new IncidenteMaquinaria();
                incidente.setIdIncidente(rs.getInt("ID_INCIDENTE"));           
                incidente.getSupervisor().setIdPersona(rs.getInt("ID_SUPERVISOR"));   
                incidente.getSupervisor().setNombres(rs.getString("NOMBRE_SUPERVISOR"));
                incidente.getSupervisor().setApellidos(rs.getString("APELLIDO_SUPERVISOR"));
                incidente.setFechaIncidente(rs.getDate("FECHA_INCIDENTE"));
                incidente.setEstado(rs.getBoolean("ESTADO_INCIDENTE"));
                incidente.getProblema().setIdProblema(rs.getInt("ID_PROBLEMA")); 
                incidente.getProblema().setTipo(rs.getString("NOMBRE_PROBLEMA"));
                incidente.getProblema().setNivelImportancia(rs.getInt("NIVEL_IMPORTANCIA_PROBLEMA"));
                incidente.getMaquinaria().setIdMaquinaria(rs.getInt("ID_MAQUINARIA")); 
                incidente.getMaquinaria().setNombre(rs.getString("NOMBRE_MAQUINARIA"));
                incidente.getMaquinaria().getProveedor().setRazonSocial(rs.getString("NOMBRE_PROVEEDOR"));
                incidentes.add(incidente);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
            
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return incidentes;
    }

    @Override
    public IncidenteMaquinaria obtenerIngeniero(IncidenteMaquinaria incidenteMaquinaria) {
        int resultado=0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            cs=con.prepareCall("{call OBTENER_INGENIERO_POR_ID_INCIDENTE(?)}");
            cs.setInt("_ID_INCIDENTE",incidenteMaquinaria.getIdIncidente());
            rs = cs.executeQuery();  
            while(rs.next()){
                incidenteMaquinaria.getIngeniero().setIdPersona(rs.getInt("ID_INGENIERO"));
                incidenteMaquinaria.getIngeniero().setNombres(rs.getString("NOMBRE_INGENIERO"));
                incidenteMaquinaria.getIngeniero().setApellidos(rs.getString("APELLIDO_INGENIERO"));
            }
            resultado=1;
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return incidenteMaquinaria;
    }

    @Override
    public IncidenteMaquinaria obtenerRespuesta(IncidenteMaquinaria incidenteMaquinaria) {
        int resultado=0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            cs=con.prepareCall("{call OBTENER_RESPUESTA_POR_ID_INCIDENTE(?)}");
            cs.setInt("_ID_INCIDENTE", incidenteMaquinaria.getIdIncidente());
            rs = cs.executeQuery();  
            while(rs.next()){
                incidenteMaquinaria.getRespuesta().setIdRespuesta(rs.getInt("ID_RESPUESTA"));
                incidenteMaquinaria.getRespuesta().setTipo(rs.getString("TIPO_RESPUESTA"));
                incidenteMaquinaria.setDetalle(rs.getString("DESCRIPCION_RESPUESTA"));
                incidenteMaquinaria.setFechaAtencion(rs.getDate("FECHA_RESPUESTA"));
            }
            resultado=1;
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return incidenteMaquinaria;
    }

    @Override
    public int modificarPorIngeniero(IncidenteMaquinaria incidenteMaquinaria) {
        int resultado=0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);
            String sql = "{call MODIFICAR_INCIDENTE_POR_INGENIERO(?,?,?,?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_INCIDENTE",incidenteMaquinaria.getIdIncidente());
            cs.setInt("_ID_INGENIERO",incidenteMaquinaria.getIngeniero().getIdPersona());
            cs.setInt("_ID_RESPUESTA",incidenteMaquinaria.getRespuesta().getIdRespuesta());
            cs.setString("_DESCRIPCION_RESPUESTA",incidenteMaquinaria.getDetalle());
            resultado=cs.executeUpdate();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;  
    }

    @Override
    public int modificarPorSupervisor(IncidenteMaquinaria incidenteMaquinaria) {
        int resultado=0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);
            String sql = "{call MODIFICAR_INCIDENTE_POR_SUPERVISOR(?,?,?,?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_INCIDENTE",incidenteMaquinaria.getIdIncidente());
            cs.setInt("_ID_MAQUINARIA",incidenteMaquinaria.getMaquinaria().getIdMaquinaria());
            cs.setInt("_ID_SUPERVISOR",incidenteMaquinaria.getSupervisor().getIdPersona());
            cs.setInt("_ID_PROBLEMA",incidenteMaquinaria.getProblema().getIdProblema());
            resultado=cs.executeUpdate();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado; 
    }
}
