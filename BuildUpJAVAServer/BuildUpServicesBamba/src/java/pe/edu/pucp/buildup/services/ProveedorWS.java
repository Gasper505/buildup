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
import pe.edu.pucp.ta.dao.ProveedorDAO;
import pe.edu.pucp.ta.model.Proveedor;
import pe.edu.pucp.ta.mysql.ProveedorMySQL;

/**
 *
 * @author Giohanny
 */
@WebService(serviceName = "ProveedorWS")
public class ProveedorWS {
    private ProveedorDAO daoProveedor;
    public ProveedorWS(){
        daoProveedor = new ProveedorMySQL();
    }
    @WebMethod(operationName = "listarProveedor")
    public ArrayList<Proveedor> listarProveedor() {
        ArrayList<Proveedor> proveedores = new ArrayList<>();
        try{
            proveedores =daoProveedor.listar();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return proveedores;
    }
    
    @WebMethod(operationName = "insertarProveedor")
    public int insertarProveedor(@WebParam(name="proveedor") Proveedor proveedor) {
        int resultado =0;
        try{
            resultado = daoProveedor.insertar(proveedor);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "actualizarProveedor")
    public int actualizarProveedor(@WebParam(name = "proveedor") Proveedor proveedor) {
        int resultado = 0;
        try{
            resultado = daoProveedor.actualizar(proveedor);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "eliminarProveedor")
    public int eliminarProveedor(@WebParam(name = "idProveedor") int idProveedor) {
        int resultado = 0;
        try{
            resultado = daoProveedor.eliminar(idProveedor);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarProveedorPorRazonSocial")
    public ArrayList<Proveedor> listarProveedorPorRazonSocial(@WebParam(name = "razonSocial") String razonSocial) {
        ArrayList<Proveedor> proveedores = new ArrayList<>();
        try{
            proveedores = daoProveedor.listarProveedorPorRazonSocial(razonSocial);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return proveedores;
    }
}
