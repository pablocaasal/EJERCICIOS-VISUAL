package Bucles;
import java.util.*;
//fijarse en el orden, primero el paquete luego los import y luego la clase
public class DoLoopWhile {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		//Do while ,
		
		//solicitar al usuario un numero positivo
		//dependiendo del tipo de datoq que quieres leer cambiar el lector. (para strings es next)
		
		Scanner lector = new Scanner(System.in);
		int numero;

		do {
		System.out.println("Introduce un numero positivo");
	    numero = lector.nextInt();
		System.out.println("Numero introducido " + numero); 
		}
		while (numero<0);
	}

}
