namespace OperacionesApp.Pages;

public partial class RectanguloPage : ContentPage
{
    public RectanguloPage()
    {
        NewMethod();

        static void NewMethod()
        {
            InitializeComponent();
        }
    }

    private static void InitializeComponent()
    {
        throw new NotImplementedException();
    }

    private void OnCalcularClicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(BaseEntry.Text) || string.IsNullOrWhiteSpace(AlturaEntry.Text))
        {
            DisplayAlert("Error", "Por favor ingrese todos los valores.", "OK");
            return;
        }

        if (double.TryParse(BaseEntry.Text, out double baseValue) &&
            double.TryParse(AlturaEntry.Text, out double altura) &&
            baseValue > 0 && altura > 0)
        {
            double area = baseValue * altura;
            ResultadoLabel.Text = $"El área del rectángulo es: {area:F2}";
        }
        else
        {
            DisplayAlert("Error", "Ingrese valores válidos mayores a 0.", "OK");
        }
    }

    private void OnLimpiarClicked(object sender, EventArgs e)
    {
        BaseEntry.Text = string.Empty;
        AlturaEntry.Text = string.Empty;
        ResultadoLabel.Text = string.Empty;
    }
}
