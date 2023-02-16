package Bucles;

public class For {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		//Bucle For
		
		//Mostrar solo los 5 primeros números por debajo de 1000 multiplos de 3 y 7
		
		int contador = 0;
		
		for (int o =1; o<=1000 && contador<=5 ;o+=1) {
			
			if (o % 3 == 0 && o % 5 == 0) {
				contador+=1;
				System.out.println(o);
				
			}
		}

	}

}
