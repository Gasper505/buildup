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
import pe.edu.pucp.ta.dao.JefeAreaDAO;
import pe.edu.pucp.ta.model.JefeArea;
import pe.edu.pucp.ta.mysql.JefeAreaMySQL;

/**
 *
 * @author Giohanny
 */
@WebService(serviceName = "JefeAreaWS")
public class JefeAreaWS {

    private JefeAreaDAO daoJefeArea;
    public JefeAreaWS(){
        daoJefeArea = new JefeAreaMySQL();
    }
    @WebMethod(operationName = "listarJefeArea")
    public ArrayList<JefeArea> listarJefeArea() {
        ArrayList<JefeArea> jefeAreas = new ArrayList<>();
        try{
            jefeAreas =daoJefeArea.listar();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return jefeAreas;
    }
    
    @WebMethod(operationName = "insertarJefeArea")
    public int insertarJefeArea(@WebParam(name="jefeArea") JefeArea jefeArea, @WebParam(name="username") String username, @WebParam(name="password") String password) {
        int resultado =0;
        try{
            resultado = daoJefeArea.insertar(jefeArea, username, password);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "actualizarEstadoJefeArea")
    public int actualizarEstadoJefeArea(@WebParam(name = "idPersona") int idPersona,@WebParam(name = "activo") boolean activo) {
        int resultado = 0;
        try{
            resultado = daoJefeArea.actualizar_estado(idPersona, activo);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "modificarJefeArea")
    public int modificarJefeArea(@WebParam(name = "jefeArea") JefeArea jefeArea) {
        int resultado = 0;
        try{
            resultado = daoJefeArea.modificar(jefeArea);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "eliminarJefeArea")
    public int eliminarJefeArea(@WebParam(name = "idJefeArea") int idJefeArea) {
        int resultado = 0;
        try{
            resultado = daoJefeArea.eliminar(idJefeArea);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "obtenerFotoFirmaJefeArea")
    public byte[] obtenerFotoFirmaJefeArea(@WebParam(name = "idJefeArea") int idJefeArea ) {
        byte[] foto_firma={};
        try{
            foto_firma = daoJefeArea.obtener_foto_firma(idJefeArea);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return foto_firma;
    }
}
