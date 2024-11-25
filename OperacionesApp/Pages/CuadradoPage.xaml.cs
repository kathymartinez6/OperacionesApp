namespace OperacionesApp.Pages;


public partial class CuadradoPage : ContentPage
{
    public CuadradoPage()
    {
        NewMethod();
    }

    private static void NewMethod()
    {
        InitializeComponent();
    }

    private static void InitializeComponent()
    {
        throw new NotImplementedException();
    }

 

    private void OnCalcularClicked(object sender, EventArgs e)
    {
        
        if (string.IsNullOrWhiteSpace(LadoEntry.Text)
        {
            DisplayAlert("Error", "Por favor ingrese el lado del cuadrado.", "OK");
            return;
        }

        if (double.TryParse(LadoEntry.Text, out double lado) && lado > 0)
        {
            double area = lado * lado;
            ResultadoLabel.Text= $"El área del cuadrado es: {area:F2}";
        }
        else
        {
            DisplayAlert("Error", "Ingrese un valor válido mayor a 0.", "OK");
        }
    }

   
}



