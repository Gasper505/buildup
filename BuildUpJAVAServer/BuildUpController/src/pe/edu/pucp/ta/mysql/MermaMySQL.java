

package pe.edu.pucp.ta.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import pe.edu.pucp.ta.config.DBManager;
import pe.edu.pucp.ta.dao.MermaDAO;
import pe.edu.pucp.ta.model.Merma;


public class MermaMySQL implements MermaDAO{

     Connection con;
    CallableStatement cs;
    ResultSet rs;
    Statement st;
    @Override
    public int insertar(Merma merma) {
        int resultado=0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con =DriverManager.getConnection(DBManager.urlMySQL, DBManager.user,DBManager.password);
            String sql = "{call INSERTAR_MERMA(?,?,?,?)}";
            cs = con.prepareCall(sql);
            cs.registerOutParameter("_ID_MERMA", java.sql.Types.INTEGER);
            cs.setString("_TIPO", merma.getTipo());
            cs.setString("_DESCRIPCION", merma.getDescripcion());
            cs.setString("_UNIDAD_MEDIDA", merma.getUnidad());
            cs.executeUpdate();
            merma.setIdMerma(cs.getInt("_ID_MERMA"));
            resultado=merma.getIdMerma();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    
    }

    @Override
    public int actualizar(Merma merma) {
        int resultado=0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con =DriverManager.getConnection(DBManager.urlMySQL, DBManager.user,DBManager.password);
            String sql = "{call ACTUALIZAR_MERMA(?,?,?,?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_MERMA", merma.getIdMerma());
            cs.setString("_TIPO", merma.getTipo());
            cs.setString("_DESCRIPCION", merma.getDescripcion());
            cs.setString("_UNIDAD_MEDIDA", merma.getUnidad());
            resultado=cs.executeUpdate();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public int eliminar(int idMerma) {
        int resultado=0;
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con =DriverManager.getConnection(DBManager.urlMySQL, DBManager.user,DBManager.password);
            String sql = "{call ELIMINAR_MERMA(?)}";
            cs = con.prepareCall(sql);
            cs.setInt("_ID_MERMA", idMerma);      
            resultado=cs.executeUpdate(); 
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return resultado;
    }

    @Override
    public ArrayList<Merma> listar() {
         ArrayList<Merma> mermas=new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, 
                    DBManager.user, DBManager.password);
            st=con.createStatement();
            String sql = "SELECT * FROM MERMA WHERE ACTIVO=1";
            rs = st.executeQuery(sql);  
            while(rs.next()){
                Merma merma = new Merma();
                merma.setIdMerma(rs.getInt("ID_MERMA"));
                merma.setTipo(rs.getString("TIPO"));
                merma.setDescripcion(rs.getString("DESCRIPCION"));
                merma.setUnidad(rs.getString("UNIDAD_MEDIDA"));
                merma.setActivo(rs.getBoolean("ACTIVO"));
                
                mermas.add(merma);
                            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
            
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return mermas;
    }

    @Override
    public ArrayList<Merma> listarPorTipo(String tipo) {
        ArrayList<Merma> mermas = new ArrayList<>();
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            con = DriverManager.getConnection(DBManager.urlMySQL, DBManager.user, DBManager.password);
            cs = con.prepareCall("{call LISTAR_MERMAS_POR_TIPO_MERMA(?)}");
            cs.setString("_TIPO_MERMA", tipo);
            rs = cs.executeQuery();
            while(rs.next()){
                Merma mer = new Merma();
                mer.setIdMerma(rs.getInt("ID_MERMA"));
                mer.setTipo(rs.getString("TIPO"));
                mer.setDescripcion(rs.getString("DESCRIPCION"));
                mer.setUnidad(rs.getString("UNIDAD_MEDIDA"));
                mer.setActivo(rs.getBoolean("ACTIVO"));
                mermas.add(mer);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }finally{
            try{con.close();}catch(Exception ex){System.out.println(ex.getMessage());}
        }
        return mermas;
    }
}
