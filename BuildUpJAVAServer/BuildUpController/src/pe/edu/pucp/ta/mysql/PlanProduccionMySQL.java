/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.ta.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import pe.edu.pucp.ta.config.DBManager;
import pe.edu.pucp.ta.dao.PlanProduccionDAO;
import pe.edu.pucp.ta.model.LineaOrdenSalida;
import pe.edu.pucp.ta.model.LineaPlanProduccion;
import pe.edu.pucp.ta.model.OrdenSalida;
import pe.edu.pucp.ta.model.PlanProduccion;

/**
 *
 * @author Luis Gaspar
 */
public class PlanProduccionMySQL implements PlanProduccionDAO{

    Connection con;
    CallableStatement cs;
    ResultSet rs;
    Statement st;
    @Override
    public int insertar(PlanProduccion plan) {
        int resultado=0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL,DBManager.user, DBManager.password);
            con.setAutoCommit(false);
            String sql = "{call INSERTAR_PLAN_PRODUCCION(?,?)}";
            cs = con.prepareCall(sql);
            cs.registerOutParameter("_ID_PLAN_PRODUCCION", java.sql.Types.INTEGER);
            cs.setInt("_FECHA_ANHO",plan.getAnhoPlan());
            cs.executeUpdate();
            plan.setIdPlan(cs.getInt("_ID_PLAN_PRODUCCION"));
            
            for(LineaPlanProduccion linea : plan.getLineasPlan()){
                cs = con.prepareCall("{call INSERTAR_LINEA_PLAN_PRODUCCION (?,?,?,?)}");
                cs.setInt("_FID_PLAN_PRODUCCION", plan.getIdPlan());
                cs.setInt("_FID_TIPO_LADRILLO", linea.getTipoLadrillo().getIdTipoLadrillo());
                cs.setInt("_CANTIDAD",linea.getCantidad());
                cs.registerOutParameter("_ID_LINEA_PLAN_PRODUCCION", java.sql.Types.INTEGER);
                cs.executeUpdate();
                
                linea.setIdLineaPlan(cs.getInt("_ID_LINEA_PLAN_PRODUCCION"));
                
            }
            
            con.commit();
            resultado = plan.getIdPlan();
            
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
    public int actualizar(PlanProduccion plan) {
        int resultado = 0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            con.setAutoCommit(false);
            String sql = "{call MODIFICAR_PLAN_PRODUCCION(?,?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_PLAN", plan.getIdPlan());
            cs.setInt("_FECHA_ANHO",plan.getAnhoPlan());
            cs.executeUpdate();
            //eliminar lineas anteriores
            sql = "{call ELIMINAR_LINEA_PLAN_PRODUCCION(?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_PLAN",plan.getIdPlan() );
            cs.executeUpdate();
            //insertar nuevas lineas
            for(LineaPlanProduccion linea : plan.getLineasPlan()){
                cs = con.prepareCall("{call INSERTAR_LINEA_PLAN_PRODUCCION (?,?,?,?)}");
                cs.setInt("_FID_PLAN_PRODUCCION", plan.getIdPlan());
                cs.setInt("_FID_TIPO_LADRILLO", linea.getTipoLadrillo().getIdTipoLadrillo());
                cs.setInt("_CANTIDAD",linea.getCantidad());
                cs.registerOutParameter("_ID_LINEA_PLAN_PRODUCCION", java.sql.Types.INTEGER);
                cs.executeUpdate();
                
                linea.setIdLineaPlan(cs.getInt("_ID_LINEA_PLAN_PRODUCCION"));
                
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
    public int eliminar(int idPlan) {
        int resultado=0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            String sql = "{call ELIMINAR_PLAN_PRODUCCION(?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_PLAN",idPlan);
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
    public ArrayList<PlanProduccion> listar() {
        ArrayList<PlanProduccion> planes=new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            st=con.createStatement();
            String sql = "SELECT * FROM PLAN_PRODUCCION WHERE ACTIVO=1";
            rs = st.executeQuery(sql);  
            while(rs.next()){
                PlanProduccion plan = new PlanProduccion();
                plan.setIdPlan(rs.getInt("ID_PLAN"));
                plan.setAnhoPlan(rs.getInt("FECHA_ANHO"));    
                planes.add(plan);
            }
            rs.close();
            
            for(PlanProduccion plan : planes){
                cs = con.prepareCall("{call LISTAR_LINEAS_PLAN_PRODUCCION_POR_ID_PLAN(?)}");
                cs.setInt("_ID_PLAN_PRODUCCION", plan.getIdPlan());
                rs = cs.executeQuery();
                while(rs.next()){
                    LineaPlanProduccion linea = new LineaPlanProduccion(); 
                    linea.getTipoLadrillo().setIdTipoLadrillo(rs.getInt("ID_TIPO_LADRILLO"));
                    linea.getTipoLadrillo().setNombre(rs.getString("NOMBRE_TIPO_LADRILLO"));
                    linea.setCantidad(rs.getInt("CANTIDAD"));
                    plan.getLineasPlan().add(linea);
                }
            }
            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
            
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return planes;
    }
    
}
