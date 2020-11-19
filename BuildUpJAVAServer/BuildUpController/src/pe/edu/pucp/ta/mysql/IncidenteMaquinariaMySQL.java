
package pe.edu.pucp.ta.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import pe.edu.pucp.ta.config.DBManager;
import pe.edu.pucp.ta.dao.IncidenteMaquinariaDAO;
import pe.edu.pucp.ta.model.IncidenteMaquinaria;


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
    public int actualizar(IncidenteMaquinaria incidenteMaquinaria) {
        int resultado=0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);
            String sql = "{call ACTUALIZAR_INCIDENTE_MAQUINARIA(?,?,?,?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_INCIDENTE",incidenteMaquinaria.getIdIncidente());
            cs.setInt("_ID_INGENIERO",incidenteMaquinaria.getIngeniero().getIdPersona());
            cs.setInt("_ID_RESPUESTA",incidenteMaquinaria.getRespuesta().getIdRespuesta());
            cs.setString("_DESCRIPCION_RESPUESTA",incidenteMaquinaria.getDetalle());
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
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
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
//                incidente.getMaquinaria().setIdMaquinaria(rs.getInt("ID_MAQUINARIA"));           //
//                incidente.getSupervisor().setIdPersona(rs.getInt("ID_SUPERVISOR"));           //
//                incidente.getIngeniero().setIdPersona(rs.getInt("ID_INGENIERO"));             //
//                incidente.getProblema().setIdProblema(rs.getInt("ID_PROBLEMA"));               //
//                incidente.getRespuesta().setIdRespuesta(rs.getInt("ID_RESPUESTA"));             //
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
            incidenteMaquinaria.setIdIncidente(cs.getInt("_ID_INCIDENTE"));
            resultado=cs.executeUpdate();
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
}
