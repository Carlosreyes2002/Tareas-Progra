public static void CalcularIngresos(string nombreUsuario, double ingresoMes1, double ingresoMes2, double ingresoMes3)
{

    double sumaIngresos = ingresoMes1 + ingresoMes2 + ingresoMes3;
    double promedioIngresos = sumaIngresos / 3;
    
    console.WriteLine($"Hola {nombreUsuario}, en total gastaste {sumaIngresos:C} y promediaste {promedioIngresos:C en los ultimos tres meses.")};
}
