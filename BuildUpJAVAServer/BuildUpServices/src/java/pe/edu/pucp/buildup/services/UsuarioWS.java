
package pe.edu.pucp.buildup.services;

import javax.jws.WebMethod;
import javax.jws.WebParam;
import javax.jws.WebService;
import pe.edu.pucp.ta.dao.UsuarioDAO;
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
    
}
