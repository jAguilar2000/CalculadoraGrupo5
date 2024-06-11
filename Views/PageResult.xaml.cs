namespace CalculadoraTarea1.Views;

public partial class PageResult : ContentPage
{
	public PageResult(decimal resultado, string operacion)
	{
		InitializeComponent();
		LabelResultado.Text = $"El resultado de la {operacion}: {resultado}";

    }
}