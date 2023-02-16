package funciones_metodos;

public class PruebaMetodosSumaArray {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		//probar Método calcularSumaArray
		
		int matriz[]= {9,5,7,3,7,3};
		
		int suma = MetodosArrays.calcularSumaArray(matriz);
		
		System.out.println("La suma de todos los valores del array es " + suma);
		
        //probar metodo calcular media
		
	   double media = MetodosArrays.calcularMediaArray(matriz);
	   System.out.println("La media es : " + media);
	   
	   //probar metodo random
	   
	   int matrizAleatoria[] = new int[20];
	   
	   MetodosArrays.llenarMatriz(matrizAleatoria);
	   
	   //probar metodo para mostrar array por pantalla
	   
	   System.out.println("Matriz generada aletoriamente : ");
	   MetodosArrays.mostrarArray(matrizAleatoria);
	   
	   //probar metodo sobrecarga array aleatoria
	   
	   MetodosArrays.llenarMatriz(matrizAleatoria, 11);
	   MetodosArrays.mostrarArray(matrizAleatoria);
	   
	   //probar metodo saber si un numero es par
	   
	   int numero = 4;
	   
	   if (MetodosUtiles.esPar(numero)) 
		   System.out.println("El numero " + numero + " es par");
	   else 
		   System.out.println("El numero " + numero + " es par");
	   
	   //probar metodo sumar 10
	   
	  // int numero1 = 40;
	   
	   //n = MetodosUtiles.sumar10(numero1);
	   
	   
	}

}
