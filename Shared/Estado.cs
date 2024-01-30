using Microsoft.Extensions.Options;
using System.Text.Json;

namespace PizzaPlace.Shared;

public class Estado
{
	public Menu Menu { get; } = new Menu();
	public CarritoCompras Carrito { get; } = new CarritoCompras();
	public UI UI { get; set; } = new UI();

	public decimal PrecioTotal => Carrito.Ordenes.Sum(id => Menu.ObtenerPizza(id)!.Precio);
}
