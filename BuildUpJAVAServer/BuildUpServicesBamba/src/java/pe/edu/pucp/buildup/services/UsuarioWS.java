
package pe.edu.pucp.buildup.services;

import java.util.ArrayList;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import javax.jws.WebService;
import pe.edu.pucp.ta.dao.UsuarioDAO;
import pe.edu.pucp.ta.model.Persona;
import pe.edu.pucp.ta.model.Usuario;
import pe.edu.pucp.ta.mysql.UsuarioMySQL;

@WebService(serviceName = "UsuarioWS")
public class UsuarioWS {
    
    private UsuarioDAO daoUsuario;
    
    public UsuarioWS(){
        daoUsuario = new UsuarioMySQL();
    }
    
    @WebMethod(operationName = "autenticarUsuario")
    public int autenticarUsuario(@WebParam(name = "usuario") Usuario usuario) {
        int resultado = daoUsuario.autenticarUsuario(usuario);
        return resultado;
    }
    
    @WebMethod(operationName = "buscarUsuarioPorUsername")
    public Usuario buscarUsuarioPorUsername(@WebParam(name = "username") String username) {
        Usuario usuarioLogeado;
        usuarioLogeado = daoUsuario.buscarUsuarioPorUsername(username);
        return usuarioLogeado;
    }
    @WebMethod(operationName = "listarUsuarioPorParametros")
    public ArrayList<Persona> listarUsuarioPorParametros(
                                                         @WebParam(name = "username") String username,@WebParam(name = "nombres") String nombres,
                                                         @WebParam(name = "apellidos") String apellidos,@WebParam(name = "cargo") String cargo){
        ArrayList<Persona> personas = new ArrayList<>();
        try{
            personas = daoUsuario.listarUsuarioPorNombreApellidoNombreCargo(username, nombres, apellidos, cargo);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return personas;
    }
    
}
