package Matrices;

import java.util.*;

public class Aleatorios {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		//Llenar array de randoms
		int numeros[] = new int[10];
		Random aleatorio = new Random();
		
		for (int i = 0; i < numeros.length; i+=1) {
			numeros[i]= aleatorio.nextInt(5);
		}
		//Si quiero poner limite inferior y superior --> (limite superior - limite inferior) + limite inferior
		
		//La clase(funcion) array contiene metodos utiles para trabajar on matrices
		
		//Mostrar por pantalla toda¡o el array
		
		System.out.println(Arrays.toString(numeros));
		
		//Ordenadar de menor a mayor los elementos del array
		
		Arrays.sort(numeros);
		
	int [] copiaArray =	Arrays.copyOf(numeros, numeros.length);
	
	//Buscar un valor en un array ordenado
	
	int valorBuscado = 4;
	int posicion = Arrays.binarySearch(copiaArray, valorBuscado);
	System.out.println(Arrays.toString(copiaArray));
	System.out.print("El valor está en la posición " + posicion);
	}

}
