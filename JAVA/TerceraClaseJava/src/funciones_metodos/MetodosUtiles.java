package funciones_metodos;

public class MetodosUtiles {
	
	//Metodo que diga si un numero es par
	
	public static boolean esPar (int numero) {
		
		if (numero % 2 ==0) {
			return true;
		}
		else {
			
			return false;
		}
	}
	
	//metodo que me dkga si un numero es positivo
	
	public static boolean esPositivo (int numero) {
		if (numero >= 0) {
			return true;
		}
		return false;
	}
	
	//metodo que le suma 10 a una variable int (las variables primitivas se pasan por valor (copia que se almacena en la funcion)
	//las demas por referencia (apuntan a la misma zona de memoria, no copia nada
	
	//public static int sumar10(int n) {
		
		//n +=10;
	//}
}
