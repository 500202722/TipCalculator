namespace TipCalculator;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }
    private void OnTipButtonClicked(object sender, System.EventArgs e)
    {
        var button = (Button)sender;
        var tipPercentage = int.Parse(button.Text.Replace("%", "")) / 100.0;

        if (double.TryParse(txtBillAmount.Text, out double billAmount))
        {
            var tipAmount = billAmount * tipPercentage;
            var totalAmount = billAmount + tipAmount;
            lblResult.Text = $"{button.Text} Tip: ${tipAmount:F2} | Total: ${totalAmount:F2}";
        }
        else
        {
            lblResult.Text = "Enter a valid bill amount.";
        }
    }
}