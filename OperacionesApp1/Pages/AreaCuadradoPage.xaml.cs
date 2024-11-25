namespace OperacionesApp1.Pages;

public void CalcularCuadrado_Clicked(object sender, EventArgs e)
{
    if (string.IsNullOrWhiteSpace(LadoCuadrado.Text))
    {
        DisplayAlert("Error", "Por favor ingrese el lado del cuadrado", "OK");
        return;
    }
    if (double.TryParse(LadoCuadrado.Text, out double lado))
    {
        double area = lado * lado;
        ResultadoCuadrado.Text = $"Resultado: {area}";
    }
    else
    {
        DisplayAlert("Error", "Ingrese un número válido", "OK");
    }
}

public void LimpiarCuadrado_Clicked(object sender, EventArgs e)
{
    LadoCuadrado.Text = string.Empty;
    ResultadoCuadrado.Text = "Resultado: -";
}
