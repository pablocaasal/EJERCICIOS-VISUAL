package SenteciasControl;

import java.time.*;

public class SentenciaSwitch {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		//Evaluar valores discretos de una variable
		
		char opcion = 'd';
		
		//si opcion = a manda mensaje
		//si opcion = b muestro la fecha actual
		//si opcion = c sumo dos numeros
		
		switch(opcion) {
		
		case 'a' :
			
		System.out.println("Mando un mensaje");
		    break;
		
		case 'b' : 
			
			System.out.println("Hoy es " + LocalDate.now().toString());
			break;
			
		case 'c' :
			
			int x = 4;
			int y = 2;
			int o = x + y;
					
			System.out.println(o);
			break;
			
	    default :
	    	
	    	System.out.println("Error");
	    	break;
		    
	   }
				
		
		}

	}


