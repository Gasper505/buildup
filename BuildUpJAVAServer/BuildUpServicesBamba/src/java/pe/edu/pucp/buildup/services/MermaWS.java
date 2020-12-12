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
import pe.edu.pucp.ta.dao.MermaDAO;
import pe.edu.pucp.ta.model.Merma;
import pe.edu.pucp.ta.mysql.MermaMySQL;

/**
 *
 * @author Giohanny
 */
@WebService(serviceName = "MermaWS")
public class MermaWS {
    private MermaDAO daoMerma;
    public MermaWS(){
        daoMerma = new MermaMySQL();
    }
    @WebMethod(operationName = "listarMerma")
    public ArrayList<Merma> listarMerma() {
        ArrayList<Merma> mermas = new ArrayList<>();
        try{
            mermas =daoMerma.listar();
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return mermas;
    }
    @WebMethod(operationName = "listarPorTipoMerma")
    public ArrayList<Merma> listarPorTipoMerma(@WebParam(name="tipo") String tipo) {
        ArrayList<Merma> mermas = new ArrayList<>();
        try{
            mermas =daoMerma.listarPorTipo(tipo);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return mermas;
    }
    
    @WebMethod(operationName = "insertarMerma")
    public int insertarMerma(@WebParam(name="merma") Merma merma) {
        int resultado =0;
        try{
            resultado = daoMerma.insertar(merma);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "actualizarMerma")
    public int actualizarMerma(@WebParam(name = "merma") Merma merma) {
        int resultado = 0;
        try{
            resultado = daoMerma.actualizar(merma);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    @WebMethod(operationName = "eliminarMerma")
    public int eliminarMerma(@WebParam(name = "idMerma") int idMerma) {
        int resultado = 0;
        try{
            resultado = daoMerma.eliminar(idMerma);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
}
