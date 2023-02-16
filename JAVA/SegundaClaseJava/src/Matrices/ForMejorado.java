package Matrices;

import java.util.*;

public class ForMejorado {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		//for each
		
		int [] numeros = {9,3,6,7,3};
		int contador = 0;
		
		//contar numero pares
		
		for (int n : numeros) {
			if (n % 2 == 0) {
				contador +=1;
				System.out.println("Hay " + contador + " numeroa pares");
			}
		}
		
		//sumar los numeros del array
		int suma = 0;
		
		for (int n : numeros) {
			suma += n;
			System.out.println("Suma total de los valores array" + suma);
		}
		
		
		//Buscar un valor en un array
		
		boolean condicion = false;
		Scanner lector = new Scanner(System.in);
				
	    System.out.println("Introduce el valor que quieres buscar");
		
		int num = lector.nextInt();
		
		for ( int n : numeros) {
			if (n==num) {
				System.out.println("El numero " + num + " está en la array");
				condicion = true;
				break;
			}
			
		}
		
		if (condicion == false) {
			System.out.println("No se ha encontrado");
		}
	}

}
