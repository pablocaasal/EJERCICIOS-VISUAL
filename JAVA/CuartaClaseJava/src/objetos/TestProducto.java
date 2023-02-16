package objetos;
import java.util.*;
public class TestProducto {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		//Crear un Producto
		
		Producto p1 = new Producto();
		System.out.println("Precio de p1 " + p1.getPrecio());
		
		//Modificar valores del objeto p1
		p1.setCode("a4!");
		p1.setMarca("Lenovo");
	    p1.setPrecio(1000);
	    
	    //Matriz Productos
	    
	    Producto pm[]=new Producto[100];
	    ArrayList<Producto> lista = new ArrayList<Producto>(10);
	    
	    //aplicar 50% decuento sobre p1
	    p1.aplicarDescuento(50);
	    System.out.println("Descuento aplicado : " + p1.getPrecio());
	    
	    //hashCode
	    System.out.println(p1.hashCode());
	    
	    //mostrar toda la info de p1
	    System.out.println(p1.toString());
	    
	    //setCod (MODIFICAS EL VALOR DE P1 VERIFICANDO SI TIENE EL FORMATO CORRECTO)
	    p1.setCode("A2");
	    
	    //constructor
	    
	    Producto p3 = new Producto("M3","HP",800);
	    
	}
	
	

}
