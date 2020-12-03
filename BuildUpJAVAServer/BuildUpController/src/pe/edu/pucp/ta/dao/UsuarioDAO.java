
package pe.edu.pucp.ta.dao;

import java.util.ArrayList;
import pe.edu.pucp.ta.model.Usuario;

public interface UsuarioDAO {
    
    int autenticarUsuario(Usuario usuario);
    Usuario buscarUsuarioPorUsername(String username);
    
    ArrayList<Usuario> listarUsuarioPorIDNombreApellidoNombreCargo(int id, String username, String nombres, String apellidos, String cargo);
    
}
