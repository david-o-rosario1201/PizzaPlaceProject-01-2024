using System.Collections.Generic;

namespace PizzaPlace.Shared;

public class CarritoCompras
{
	public Cliente Cliente { get; set; } = new Cliente();
	public List<int> Ordenes { get; set; } = new List<int>();
	public bool HaPagado { get; set; }

	public void Agregar(int pizzaId) => Ordenes.Add(pizzaId);

	public void Remover(int pos) => Ordenes.RemoveAt(pos);
}
