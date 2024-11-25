namespace OperacionesApp1.Pages;

private void CalcularRectangulo_Clicked(object sender, EventArgs e)
{
    if (string.IsNullOrWhiteSpace(BaseRectangulo.Text) || string.IsNullOrWhiteSpace(AlturaRectangulo.Text))
    {
        DisplayAlert("Error", "Por favor complete todos los campos", "OK");
        return;
    }
    if (double.TryParse(BaseRectangulo.Text, out double baseRect) && double.TryParse(AlturaRectangulo.Text, out double alturaRect))
    {
        double area = baseRect * alturaRect;
        ResultadoRectangulo.Text = $"Resultado: {area}";
    }
    else
    {
        DisplayAlert("Error", "Ingrese números válidos", "OK");
    }
}

private void LimpiarRectangulo_Clicked(object sender, EventArgs e)
{
    BaseRectangulo.Text = string.Empty;
    AlturaRectangulo.Text = string.Empty;
    ResultadoRectangulo.Text = "Resultado: -";
}
