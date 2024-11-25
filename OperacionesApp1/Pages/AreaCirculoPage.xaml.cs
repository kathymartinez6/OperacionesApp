namespace OperacionesApp1.Pages;

public  void CalcularCirculo_Clicked(object sender, EventArgs e)
{
    if (string.IsNullOrWhiteSpace(RadioCirculo.Text))
    {
        DisplayAlert("Error", "Por favor ingrese el radio del c�rculo", "OK");
        return;
    }
    if (double.TryParse(RadioCirculo.Text, out double radio))
    {
        double area = Math.PI * Math.Pow(radio, 2);
        ResultadoCirculo.Text = $"Resultado: {area:F2}";
    }
    else
    {
        DisplayAlert("Error", "Ingrese un n�mero v�lido", "OK");
    }
}

public void LimpiarCirculo_Clicked(object sender, EventArgs e)
{
    RadioCirculo.Text = string.Empty;
    ResultadoCirculo.Text = "Resultado: -";
}
