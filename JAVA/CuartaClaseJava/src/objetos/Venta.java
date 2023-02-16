package objetos;
import java.time.*;
public class Venta {

	private String codigoVenta;
	private String codigoProducto;
	private LocalDate fecha;
	
	public Venta(String codigoVenta, String codigoProducto, LocalDate fecha) {
		super();
		this.codigoVenta = codigoVenta;
		this.codigoProducto = codigoProducto;
		this.fecha = fecha;
		
	}

	public String getCodigoVenta() {
		return codigoVenta;
	}

	public void setCodigoVenta(String codigoVenta) {
		this.codigoVenta = codigoVenta;
	}

	public String getCodigoProducto() {
		return codigoProducto;
	}

	public void setCodigoProducto(String codigoProducto) {
		this.codigoProducto = codigoProducto;
	}

	public LocalDate getFecha() {
		return fecha;
	}

	public void setFecha(LocalDate fecha) {
		this.fecha = fecha;
	}

	@Override
	public String toString() {
		return "Venta [codigoVenta=" + codigoVenta + ", codigoProducto=" + codigoProducto + ", fecha=" + fecha + "]";
	}
	
}
