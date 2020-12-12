
package pe.edu.pucp.buildup.services;

import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;

@WebService(serviceName = "TestingWS")
public class TestingWS {
    
    @WebMethod(operationName = "greet")
    public String hello(@WebParam(name = "name") String txt) {
        return "Hello " + txt + " !";
    }
    
    @WebMethod(operationName = "multiply")
    public int multiply(@WebParam(name = "number1") int a, @WebParam(name = "number2") int b){
        int result = 0;
        try{
            result = a*b;
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return result;
    }
}
