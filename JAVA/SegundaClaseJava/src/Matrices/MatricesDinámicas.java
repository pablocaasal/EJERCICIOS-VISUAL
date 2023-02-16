package Matrices;
import java.util.*;
public class MatricesDinámicas {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		//arrays que se pueden redimnensarionar o aumentar su capacidad
		
		ArrayList<String> alumnos = new ArrayList<String>();
		
		//añadir elementos a esta lsta
		
		alumnos.add("Matias");
		alumnos.add("PABLO");
		alumnos.add("jUAN");
		
		//saber cuantoa alumnos hay guardados .size()

		int numeroAlumnos = alumnos.size();
		System.out.println(numeroAlumnos);
		
		//mostar la lista
		
		for (String n : alumnos) {
			System.out.println(n);
		}
		
		//eliminar un alumno
		
		alumnos.remove(1);
		
		//mostrar toda la lista
		
		for (String n : alumnos) {
			System.out.println(n);
		}
		
		
	}

}
