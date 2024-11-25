namespace OperacionesApp.Pages;


public partial class CirculoPage : ContentPage
{
    public CirculoPage()
    {
        NewMethod();
    }

    private void NewMethod()
    {
        InitializeComponent();
    }

    private void OnCalcularClicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(RadioEntry.Text))
        {
            DisplayAlert("Error", "Por favor ingrese el radio del círculo.", "OK");
            return;
        }

        if (double.TryParse(RadioEntry.Text, out double radio) && radio > 0)
        {
            double area = Math.PI * Math.Pow(radio, 2);
            ResultadoLabel.Text = $"El área del círculo es: {area:F2}";
        }
        else
        {
            DisplayAlert("Error", "Ingrese un valor válido mayor a 0.", "OK");
        }
    }

    private void OnLimpiarClicked(object sender, EventArgs e)
    {
        RadioEntry.Text = string.Empty;
        ResultadoLabel.Text = string.Empty;
    }
}
