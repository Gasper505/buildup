
package pe.edu.pucp.ta.model;



public class Usuario extends Persona{
    
    private String username; //username
    private String password; //password

    public Usuario(){
    }

    public String getUsername() {
        return username;
    }

    public void setUsername(String username) {
        this.username = username;
    }

    public String getPassword() {
        return password;
    }

    public void setPassword(String password) {
        this.password = password;
    }
    
    
    
}
