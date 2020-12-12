/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pe.edu.pucp.buildup.services;

import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.ta.dao.PersonaDAO;
import pe.edu.pucp.ta.model.Persona;
import pe.edu.pucp.ta.mysql.PersonaMySQL;

/**
 *
 * @author Giohanny
 */
@WebService(serviceName = "PersonaWS")
public class PersonaWS {

    private PersonaDAO daoPersona;
    public PersonaWS(){
        daoPersona = new PersonaMySQL();
    }
    @WebMethod(operationName = "listarPersona")
    public ArrayList<Persona> listarPersona() {
        ArrayList<Persona> personas = new ArrayList<>();
        try{
            personas =daoPersona.listar();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return personas;
    }
    
    @WebMethod(operationName = "insertarPersona")
    public int insertarPersona(@WebParam(name="persona") Persona persona) {
        int resultado =0;
        try{
            resultado = daoPersona.insertar(persona);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "actualizarPersona")
    public int actualizarPersona(@WebParam(name = "persona") Persona persona) {
        int resultado = 0;
        try{
            resultado = daoPersona.actualizar(persona);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "eliminarPersona")
    public int eliminarPersona(@WebParam(name = "idPersona") int idPersona) {
        int resultado = 0;
        try{
            resultado = daoPersona.eliminar(idPersona);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
}
