
package pe.edu.pucp.ta.dao;

import pe.edu.pucp.ta.model.Usuario;

public interface UsuarioDAO {
    
    int autenticarUsuario(Usuario usuario);
    Usuario buscarUsuarioPorUsername(String username);
    
    
    
}
