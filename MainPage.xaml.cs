using CalculadoraTarea1.Views;

namespace CalculadoraTarea1
{
    public partial class MainPage : ContentPage
    {
        decimal varNum1 = 0;
        decimal varNum2 = 0;
        decimal varResult = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnBtnSumaClicked(object sender, EventArgs e)
        {
            varNum1 = Convert.ToDecimal(Num1.Text == "" ? 0 : Num1.Text);
            varNum2 = Convert.ToDecimal(Num2.Text == "" ? 0 : Num2.Text);
            varResult = varNum1 + varNum2;
            PageResult pageResult = new PageResult(varResult, "suma");
            Navigation.PushAsync(pageResult);
        }

        private void OnBtnRestaClicked(object sender, EventArgs e)
        {
            varNum1 = Convert.ToDecimal(Num1.Text == "" ? 0 : Num1.Text);
            varNum2 = Convert.ToDecimal(Num2.Text == "" ? 0 : Num2.Text);
            varResult = varNum1 - varNum2;
            PageResult pageResult = new PageResult(varResult, "resta");
            Navigation.PushAsync(pageResult);
        }

        private void OnBtnMultiplacionClicked(object sender, EventArgs e)
        {
            varNum1 = Convert.ToDecimal(Num1.Text == "" ? 0 : Num1.Text);
            varNum2 = Convert.ToDecimal(Num2.Text == "" ? 0 : Num2.Text);
            varResult = varNum1 * varNum2;

            PageResult pageResult = new PageResult(varResult, "multiplicación");
            Navigation.PushAsync(pageResult);
        }

        private void OnBtnDivisionClicked(object sender, EventArgs e)
        {
            varNum1 = Convert.ToDecimal(Num1.Text == "" ? 0 : Num1.Text);
            varNum2 = Convert.ToDecimal(Num2.Text == "" ? 0 : Num2.Text);

            if (varNum2 == 0)
            {
                DisplayAlert("Aviso", "No se puede dividir entre 0", "OK");
            }
            else
            {
                varResult = Math.Round((varNum1 / varNum2), 2);
                PageResult pageResult = new PageResult(varResult, "división");
                Navigation.PushAsync(pageResult);
            }
            
        }

    }

}
