﻿using System.Text.Json;

namespace PizzaPlace.Client;

public static class ExtensionesDepuracion
{
	private static JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
	public static string ToJson(this object obj) => JsonSerializer.Serialize(obj, options);
}
