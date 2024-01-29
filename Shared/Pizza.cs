namespace PizzaPlace.Shared;

public class Pizza
{
	public Pizza(int id, string nombre, decimal precio, Picantez picantez)
	{
		this.Id = id;
		this.Nombre = nombre;
		this.Precio = precio;
		this.Picantez = picantez;
	}
	public int Id { get; }
	public string Nombre { get; }
	public decimal Precio { get; }
	public Picantez Picantez { get; }
}
