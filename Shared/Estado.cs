namespace PizzaPlace.Shared;

public class Estado
{
	public Menu Menu { get; } = new Menu();
	public CarritoCompras Carrito { get; } = new CarritoCompras();
	public UI UI { get; set; } = new UI();
}
