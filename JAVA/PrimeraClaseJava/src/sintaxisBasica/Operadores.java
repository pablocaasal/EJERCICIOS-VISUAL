package sintaxisBasica;

public class Operadores {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		//operadores : Simbolos que realizan alguna funcion
		//Matematicos : +, -, *, /, % (operadores binarios)(% es como el Mod de visual)
		//Asignación : =, +=, -=, *=, /=
		//Operadores ++ y --

		int x =5, y=9;
		
		int resultadoSuma = x + y;
		
		float resultadoDivisión =(float) x / y; //para hacer conversiones poner entre parentesis el tipo de variable
		
		System.out.println("El resultado de la división es " + resultadoDivisión);
		
		byte c1=125, c2=4, resultadoByte;
		
		resultadoByte= (byte)(c1 + c2); 
		
		//cuando hay variables de tipo byte y hay riesgo de desbordamento hay que convertirlos a int o declarla como int
		//pero si sabemos que no se va desbordar se convierte en byte
		
		System.out.println("c1 + c2 =" + resultadoByte);
		
		//operadores += -=
		
		int r =100;
		
		r += 1;
		r = r +1;
		
		//Operadores ++ y --
		
		int o1 = 10;
		int o2 = ++o1 ; //si el ++ esta delante se suma 1 al valor
		
		System.out.println("o2 " + o2);
		
		int i1 = 10;
		int i2 = i1 ++; // si el ++ esta detras se guarda el valor de i1 en i2 y se le suma 1 a i1
		
		System.out.println("i1 " + i1);
		
		//Operadores relaciones < , <=, >, >=, ==, != 
		//el == es el igual que (=) y el != es el diferente (<>) que en vb
		
		boolean condicion = o1>10; //cuando o1 > 10 condicion es true. cuando es menor que es false
		boolean condicion2 = o1!=10; //cuando o1 sea distinto de 10 es true
		
		//Operadores lógicos
		//Y lógico : && --> Devuelve true si las dos condiciones son true (AND)
		
		boolean c3 = o1 >10 && o2 % 2 == 0;
				
		//O lógico : || --> Devuelve true		
		
		boolean c4 = o1 >10 && o2 % 2 == 0; //si una de los dos es cierta devuelve true
		
		//No lógico : ! --> Niega la condición que va despues
		
		boolean c5 = !c4;
	}

}
