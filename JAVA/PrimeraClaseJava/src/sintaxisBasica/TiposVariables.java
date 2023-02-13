package sintaxisBasica;

public class TiposVariables {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		//comentario de una solo línea
		
		/*comentario
		 * de varias lineas
		 */
		
		//tipos de variables númericas enteras (no decimales)
		//al declarar las variables siempre hay que darle valor para inicializarlas
		
		byte b1= 0; //valores de -128 a 127
		
		short s1; //valores de -32760 a 32760
		
		int i1; //puede almacenar en 4 bytes
		
		long l1; // puede almacenar 8 bytes
		
		//tipos de variables númericas decimales
		
		float f1 = 0.4f; //equivalente a single en vb, poner siempre una f, sino reconoce que es double y da error
				
		double d1 = 0;
		
		//tipo de variables alfanuméricas
		
		char caracter = 'a'; //con comillas simples (donde la interrogación)
		
		String caracteres = "hola buenas"; //con comillas dobles y la primera en mayúscula
		//String es una variable compleja (puede almacenar un valor y permite realizar acciones con funciones) las demas son primitivas
		
		boolean condición = true;
				
		//FIN BLOQUE TIPO DE VARIABLES
		
		//Declaración y inicialización de variables
		
		int numero, numero2, numero3;
		numero = 1;
		numero2 = 2;
		numero3 = 3;
				
		float temp1 = 4.5f, temp2= 4.6f, temp3=4.7f;
		
		//HAY QUE PONER LA L PARA VALORES QUE SUPERAN LA CAPACIDAD DE INT, SE PUEDEN SEPARA LOS MILES CON _
		
		long numeroAlto =10_000_000_000L;
		
		//MODIFICACIÓN DE LOS VALORES DE UNA VARIABLE
		
		int x1 = 100;
		
		x1 = x1 + 1;
		x1 += 1;

		//Mandar mensaje por consola (console writeline)(sysou ctrl y espacio
		
		System.out.println("El valor de x1 es " + x1); //reemplazar & por +
		System.out.println("booenas");
		System.out.println();
		System.out.print("ey"); //como el console.write
		System.out.println();
		
		
	}

}
