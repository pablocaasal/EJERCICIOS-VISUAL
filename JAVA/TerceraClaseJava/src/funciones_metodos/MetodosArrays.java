package funciones_metodos;
import java.util.*;
public class MetodosArrays {

	//Declarar metodos(funciones)
	
	//1º- Atributo de acceso :
	//public : Puedo acceder desde cualquier clase
	//private : Solo puedo llamar al metodo dentro de la clase
	//por defecto : Se puede llamar desde cualquier clase del mismo paquete
	//protected : Se puede acceder desde clases hijas
	
	//2º - Metodo es de clase o instancia (class o static)
	
	//3º - Tipo de retorno : Tipo de dato que devuelve
	
	//4º - Nombre del metodo 
	
	//5º - Argumentos de la funcion/metodo (lo que necesita
	
	//Método que calcula la suma de los elementos de un array de enteros
	
	public static int calcularSumaArray(int matriz[]) {
		
		int suma = 0;
		
		for (int numero : matriz) { //(for each)
			suma+=numero;
		}
		
		return suma;
	}

	//metodo que calcula la media de un array de enteros
	
	public static double calcularMediaArray(int matriz[]){
		
		int sumaMedia = calcularSumaArray(matriz);
		
		double media = sumaMedia / matriz.length -1;
		
	    return media;	    

	}
	
    //Sobrecarga método calcularSumaArray 
	//(al llamar a la funcion van a aparecer dos con el mismo nombre pero que devuelven tipos distintos
	
     //public static double calcularMediaArray(double matriz[]){
		
		//int sumaMedia = calcularSumaArray(matriz);
		
		//double media = sumaMedia / matriz.length -1; (descomentar luego)
		
	   // return media;	    
    // }
     
     //metodo que lena una matriz de enteros con numeros aleatorios (void porque no genera valores nuevos)
     
     public static void llenarMatriz(int matriz[]) {
    	 
    	 Random aleatorio = new Random();
    	 
    	 for (int i = 0; i < matriz.length -1; i+=1) {
    		 i = aleatorio.nextInt(5);
    	 }
     }
     
     //metodo para mostrar un array por pantalla
     
     public static void mostrarArray(int matriz[]) {
    	 
    	 for (int numeros : matriz) {
    		 System.out.println(numeros + " ");
    	 }
     }

     //sobrecargar metodo random
     
     public static void llenarMatriz(int matriz[], int max) {
    	 
    	 Random aleatorio = new Random();
    	 
    	 for (int i = 0; i < matriz.length -1; i+=1) {
    		 i = aleatorio.nextInt(5);
    	 }
     }
     
	}
	

