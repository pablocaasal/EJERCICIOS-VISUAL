package Matrices;

public class Matrices1D {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		//Matrices --> Permite guardar n valores de un tipo
		// al declarar el 5 no es la ultima posicion sino la capacidad total, es decir esa matriz tiene 5 posiciones
		
		int []matriz = new int[5];
		
		//accecemos a la diferentes posiciones
		
		matriz[0] = 9;
		matriz[4] = 7;
		
		//saber la capacidad de una matriz
		
		int capacidad = matriz.length;
		
		//visualizar todos los valores del array
		
		for (int i= 0 ; i == matriz.length -1; i+=1 ) {
        System.out.println(matriz[i] + " ");		}
		
		int [] matriz2 = {4,5,7,8,1};
		
		//copiar array
		
		int [] copia = new int [matriz2.length];
		
		for (int o = 0; 0 < matriz2.length ;o+=1) {
        copia [o] = matriz2[o];
        System.out.println(copia);
	}

	}
}
