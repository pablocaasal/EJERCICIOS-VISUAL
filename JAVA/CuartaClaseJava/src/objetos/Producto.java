package objetos;

public class Producto {

	//en la clase donde haces los objetos, no debe tener modulo main
	
	private String codigo;
	private String marca;
	private float precio;
	
	
	//Constructores : 
	//Constructor por defcto
	public Producto() {
		precio = 0;
		marca="null";
		codigo="null";
	}
	
	public Producto(String codigo, String marca, float precio) {
		this.codigo=codigo;
		this.marca=marca;
		this.precio=precio;
	}
	
	//--------------------------------------------
	public String getMarca() {
		return marca;
	}
	
	public String setCod() {
		return codigo;
	}

	public void setMarca(String marca) {
		this.marca = marca;
	}

	public float getPrecio() {
		return precio;
	}

	public void setPrecio(float precio) {
		this.precio = precio;
	}

	float precio2;
	
	//Metodos de acceso : set y get (modificar y mostrar)(para generarlos auto : source, generate getter and setter
	
	public void setCode(String cod) {
		//validar el cod -->FORMATO A9
		
		if (cod.length()==2) {
			if (Character.isLetter(cod.charAt(0)) && Character.isDigit(cod.charAt(1))) {
				codigo = cod;
			}
		  }
		}
			
	//------------------------------------
	//Metodos de instancia
	
	//aplicar descuento a un producto
	
	public void aplicarDescuento(int porcentaje) {
		precio = precio - (precio * porcentaje) / 100;		
		}
	
	//mostrar toda la información del producto
	@Override
	
	public String toString() {
		return "Codigo " + codigo + " Marca " + marca + " Precio " + precio; 
	}
	
	//limitar acceso a los datos (ocultación)(poner private las variables)
		
}
