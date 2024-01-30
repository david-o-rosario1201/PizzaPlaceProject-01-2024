using System.ComponentModel.DataAnnotations;

namespace PizzaPlace.Shared;

public class Cliente
{
	[Key]
	public int Id { get; set; }

	[Required(ErrorMessage = "Debe ingresar su nombre")]
	public string Nombre { get; set; } = default!;

	[Required(ErrorMessage = "Debe ingresar una calle con el numero de casa")]
	public string Calle { get; set; } = default!;

	[Required(ErrorMessage = "Debe ingresar una ciudad")]
	public string Ciudad { get; set; } = default!;
}
