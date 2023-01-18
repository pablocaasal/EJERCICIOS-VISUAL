package SenteciasControl;

public class IfElseIf {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		int numero = 9;
		
		//Quiero saber si es multiplo de 5 o no
		
		if(numero % 5 == 0){
		System.out.println(numero + " es múltiplo de 5");
		}
		else {
	    }
		
		//quiero evaluar si tiene un sobresaliente, notable, aprobado, o suspeso
		
		if(numero < 0 || numero > 10) {
			System.out.println("Error");
		}
		else if (numero < 5) {
			System.out.println("Suspenso");
		}
		else if (numero < 7) {
			System.out.println("Bien");
		}
		else if (numero < 9) {
			System.out.println("Notable");
		}
		else if (numero <= 10) {
			System.out.println("Sobresaliente");
		}
		
	}
}
