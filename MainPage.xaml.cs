namespace CalcuCientifica;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private double total1 = 0;
    private double total2 = 0;
    bool plusButtonClicked = false;
    bool minusButtonClicked = false;
    bool multiplyButtonClicked = false;
    bool divideButtonClicked = false;
    bool squareButtonClicked = false;
    bool tanButtonClicked = false;
    bool divide1xButtonClicked = false;
    bool exponentButtonClicked = false;
    bool numberEButtonClicked = false;
    bool sinButtonClicked = false;
    bool lognButtonClicked = false;
    bool exponentEButtonClicked = false;
    bool sinNegButtonClicked = false;
    bool absoluteButtonClicked = false;
    bool sinHButtonClicked = false;
    bool sinHNegButtonClicked = false;
    bool tanHNegButtonClicked = false;
    bool cosButtonClicked = false;
    bool logarButtonClicked = false;
    bool expSquareButtonClicked = false;
    bool piButtonClicked = false;
    bool cosNegButtonClicked = false;
    bool cosHButtonClicked = false;
    bool cosHNegButtonClicked = false;
    bool tanNegButtonClicked = false;
    bool expCubedButtonClicked = false;
    bool tanHButtonClicked = false;
    bool radButtonClicked = false;
    bool factButtonClicked = false;
    bool cubedRootButtonClicked = false;
    bool twoExpButtonClicked = false;
    bool percentageButtonClicked = false;
    bool plusMinusButtonClicked = false;

    private void number0(object sender, EventArgs e)
    {
        resultText.Text += "0";
    }

    private void number00(object sender, EventArgs e)
    {
        resultText.Text += "00";
    }

    private void number1(object sender, EventArgs e)
    {
        resultText.Text += "1";
    }

    private void number2(object sender, EventArgs e)
    {
        resultText.Text += "2";
    }

    private void number3(object sender, EventArgs e)
    {
        resultText.Text += "3";
    }

    private void number4(object sender, EventArgs e)
    {
        resultText.Text += "4";
    }

    private void number5(object sender, EventArgs e)
    {
        resultText.Text += "5";
    }

    private void number6(object sender, EventArgs e)
    {
        resultText.Text += "6";
    }

    private void number7(object sender, EventArgs e)
    {
        resultText.Text += "7";
    }

    private void number8(object sender, EventArgs e)
    {
        resultText.Text += "8";
    }

    private void number9(object sender, EventArgs e)
    {
        resultText.Text += "9";
    }

    private async void plus(object sender, EventArgs e)
    {
        if (resultText.Text == "")
        {
            await DisplayAlert("Caution", "Formato no válido", "OK");
        }
        else
        {
            total1 = total1 += double.Parse(resultText.Text);
            resultText.Text = "";

            plusButtonClicked = true;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
            squareButtonClicked = false;
            tanButtonClicked = false;
            divide1xButtonClicked = false;
            exponentButtonClicked = false;
            numberEButtonClicked = false;
            sinButtonClicked = false;
            lognButtonClicked = false;
            exponentEButtonClicked = false;
            sinNegButtonClicked = false;
            absoluteButtonClicked = false;
            sinHButtonClicked = false;
            sinHNegButtonClicked = false;
            tanHNegButtonClicked = false;
            cosButtonClicked = false;
            logarButtonClicked = false;
            expSquareButtonClicked = false;
            piButtonClicked = false;
            cosNegButtonClicked = false;
            cosHButtonClicked = false;
            cosHNegButtonClicked = false;
            tanNegButtonClicked = false;
            expCubedButtonClicked = false;
            tanHButtonClicked = false;
            radButtonClicked = false;
            factButtonClicked = false;
            cubedRootButtonClicked = false;
            twoExpButtonClicked = false;
            percentageButtonClicked = false;
            plusMinusButtonClicked = false;
        }
    }

    private async void substract(object sender, EventArgs e)
    {
        if (resultText.Text == "")
        {
            await DisplayAlert("Caution", "Formato no válido", "OK");
        }
        else
        {
            total1 = total1 + double.Parse(resultText.Text);
            resultText.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = true;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
            squareButtonClicked = false;
            tanButtonClicked = false;
            divide1xButtonClicked = false;
            exponentButtonClicked = false;
            numberEButtonClicked = false;
            sinButtonClicked = false;
            lognButtonClicked = false;
            exponentEButtonClicked = false;
            sinNegButtonClicked = false;
            absoluteButtonClicked = false;
            sinHButtonClicked = false;
            sinHNegButtonClicked = false;
            tanHNegButtonClicked = false;
            cosButtonClicked = false;
            logarButtonClicked = false;
            expSquareButtonClicked = false;
            piButtonClicked = false;
            cosNegButtonClicked = false;
            cosHButtonClicked = false;
            cosHNegButtonClicked = false;
            tanNegButtonClicked = false;
            expCubedButtonClicked = false;
            tanHButtonClicked = false;
            radButtonClicked = false;
            factButtonClicked = false;
            cubedRootButtonClicked = false;
            twoExpButtonClicked = false;
            percentageButtonClicked = false;
            plusMinusButtonClicked = false;
        }
    }

    private async void multiply(object sender, EventArgs e)
    {
        if (resultText.Text == "")
        {
            await DisplayAlert("Caution", "Formato no válido", "OK");
        }
        else
        {
            total1 = total1 + double.Parse(resultText.Text);
            resultText.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = true;
            divideButtonClicked = false;
            squareButtonClicked = false;
            tanButtonClicked = false;
            divide1xButtonClicked = false;
            exponentButtonClicked = false;
            numberEButtonClicked = false;
            sinButtonClicked = false;
            lognButtonClicked = false;
            exponentEButtonClicked = false;
            sinNegButtonClicked = false;
            absoluteButtonClicked = false;
            sinHButtonClicked = false;
            sinHNegButtonClicked = false;
            tanHNegButtonClicked = false;
            cosButtonClicked = false;
            logarButtonClicked = false;
            expSquareButtonClicked = false;
            piButtonClicked = false;
            cosNegButtonClicked = false;
            cosHButtonClicked = false;
            cosHNegButtonClicked = false;
            tanNegButtonClicked = false;
            expCubedButtonClicked = false;
            tanHButtonClicked = false;
            radButtonClicked = false;
            factButtonClicked = false;
            cubedRootButtonClicked = false;
            twoExpButtonClicked = false;
            percentageButtonClicked = false;
            plusMinusButtonClicked = false;
        }
    }

    private async void divide(object sender, EventArgs e)
    {
        if (resultText.Text == "")
        {
            await DisplayAlert("Caution", "Formato no válido", "OK");
        }
        else
        {
            total1 = total1 + double.Parse(resultText.Text);
            resultText.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = true;
            squareButtonClicked = false;
            tanButtonClicked = false;
            divide1xButtonClicked = false;
            exponentButtonClicked = false;
            numberEButtonClicked = false;
            sinButtonClicked = false;
            lognButtonClicked = false;
            exponentEButtonClicked = false;
            sinNegButtonClicked = false;
            absoluteButtonClicked = false;
            sinHButtonClicked = false;
            sinHNegButtonClicked = false;
            tanHNegButtonClicked = false;
            cosButtonClicked = false;
            logarButtonClicked = false;
            expSquareButtonClicked = false;
            piButtonClicked = false;
            cosNegButtonClicked = false;
            cosHButtonClicked = false;
            cosHNegButtonClicked = false;
            tanNegButtonClicked = false;
            expCubedButtonClicked = false;
            tanHButtonClicked = false;
            radButtonClicked = false;
            factButtonClicked = false;
            cubedRootButtonClicked = false;
            twoExpButtonClicked = false;
            percentageButtonClicked = false;
            plusMinusButtonClicked = false;
        }
    }

    private void squareRoot(object sender, EventArgs e)
    {
        if (resultText.Text == "")
        {
            resultText.Text += "1";
            total1 = total1 + double.Parse(resultText.Text);
            resultText.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
            squareButtonClicked = true;
            tanButtonClicked = false;
            divide1xButtonClicked = false;
            exponentButtonClicked = false;
            numberEButtonClicked = false;
            sinButtonClicked = false;
            lognButtonClicked = false;
            exponentEButtonClicked = false;
            sinNegButtonClicked = false;
            absoluteButtonClicked = false;
            sinHButtonClicked = false;
            sinHNegButtonClicked = false;
            tanHNegButtonClicked = false;
            cosButtonClicked = false;
            logarButtonClicked = false;
            expSquareButtonClicked = false;
            piButtonClicked = false;
            cosNegButtonClicked = false;
            cosHButtonClicked = false;
            cosHNegButtonClicked = false;
            tanNegButtonClicked = false;
            expCubedButtonClicked = false;
            tanHButtonClicked = false;
            radButtonClicked = false;
            factButtonClicked = false;
            cubedRootButtonClicked = false;
            twoExpButtonClicked = false;
            percentageButtonClicked = false;
            plusMinusButtonClicked = false;
        }
        else if (resultText.Text != "")
        {
            total1 = total1 + double.Parse(resultText.Text);
            resultText.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
            squareButtonClicked = true;
            tanButtonClicked = false;
            divide1xButtonClicked = false;
            exponentButtonClicked = false;
            numberEButtonClicked = false;
            sinButtonClicked = false;
            lognButtonClicked = false;
            exponentEButtonClicked = false;
            sinNegButtonClicked = false;
            absoluteButtonClicked = false;
            sinHButtonClicked = false;
            sinHNegButtonClicked = false;
            tanHNegButtonClicked = false;
            cosButtonClicked = false;
            logarButtonClicked = false;
            expSquareButtonClicked = false;
            piButtonClicked = false;
            cosNegButtonClicked = false;
            cosHButtonClicked = false;
            cosHNegButtonClicked = false;
            tanNegButtonClicked = false;
            expCubedButtonClicked = false;
            tanHButtonClicked = false;
            radButtonClicked = false;
            factButtonClicked = false;
            cubedRootButtonClicked = false;
            twoExpButtonClicked = false;
            percentageButtonClicked = false;
            plusMinusButtonClicked = false;
        }
    }

    private void tan(object sender, EventArgs e)
    {
        if (resultText.Text == "")
        {
            resultText.Text += "1";
            total1 = total1 + double.Parse(resultText.Text);
            resultText.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
            squareButtonClicked = false;
            tanButtonClicked = true;
            divide1xButtonClicked = false;
            exponentButtonClicked = false;
            numberEButtonClicked = false;
            sinButtonClicked = false;
            lognButtonClicked = false;
            exponentEButtonClicked = false;
            sinNegButtonClicked = false;
            absoluteButtonClicked = false;
            sinHButtonClicked = false;
            sinHNegButtonClicked = false;
            tanHNegButtonClicked = false;
            cosButtonClicked = false;
            logarButtonClicked = false;
            expSquareButtonClicked = false;
            piButtonClicked = false;
            cosNegButtonClicked = false;
            cosHButtonClicked = false;
            cosHNegButtonClicked = false;
            tanNegButtonClicked = false;
            expCubedButtonClicked = false;
            tanHButtonClicked = false;
            radButtonClicked = false;
            factButtonClicked = false;
            cubedRootButtonClicked = false;
            twoExpButtonClicked = false;
            percentageButtonClicked = false;
            plusMinusButtonClicked = false;
        }
        else if (resultText.Text != "")
        {
            total1 = total1 + double.Parse(resultText.Text);
            resultText.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
            squareButtonClicked = false;
            tanButtonClicked = true;
            divide1xButtonClicked = false;
            exponentButtonClicked = false;
            numberEButtonClicked = false;
            sinButtonClicked = false;
            lognButtonClicked = false;
            exponentEButtonClicked = false;
            sinNegButtonClicked = false;
            absoluteButtonClicked = false;
            sinHButtonClicked = false;
            sinHNegButtonClicked = false;
            tanHNegButtonClicked = false;
            cosButtonClicked = false;
            logarButtonClicked = false;
            expSquareButtonClicked = false;
            piButtonClicked = false;
            cosNegButtonClicked = false;
            cosHButtonClicked = false;
            cosHNegButtonClicked = false;
            tanNegButtonClicked = false;
            expCubedButtonClicked = false;
            tanHButtonClicked = false;
            radButtonClicked = false;
            factButtonClicked = false;
            cubedRootButtonClicked = false;
            twoExpButtonClicked = false;
            percentageButtonClicked = false;
            plusMinusButtonClicked = false;
        }
    }

    private void divide1x(object sender, EventArgs e)
    {
        if (resultText.Text == "")
        {
            resultText.Text += "1";
            total1 = total1 + double.Parse(resultText.Text);
            resultText.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
            squareButtonClicked = false;
            tanButtonClicked = false;
            divide1xButtonClicked = true;
            exponentButtonClicked = false;
            numberEButtonClicked = false;
            sinButtonClicked = false;
            lognButtonClicked = false;
            exponentEButtonClicked = false;
            sinNegButtonClicked = false;
            absoluteButtonClicked = false;
            sinHButtonClicked = false;
            sinHNegButtonClicked = false;
            tanHNegButtonClicked = false;
            cosButtonClicked = false;
            logarButtonClicked = false;
            expSquareButtonClicked = false;
            piButtonClicked = false;
            cosNegButtonClicked = false;
            cosHButtonClicked = false;
            cosHNegButtonClicked = false;
            tanNegButtonClicked = false;
            expCubedButtonClicked = false;
            tanHButtonClicked = false;
            radButtonClicked = false;
            factButtonClicked = false;
            cubedRootButtonClicked = false;
            twoExpButtonClicked = false;
            percentageButtonClicked = false;
            plusMinusButtonClicked = false;
        }
        else if (resultText.Text != "")
        {
            total1 = total1 + double.Parse(resultText.Text);
            resultText.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
            squareButtonClicked = false;
            tanButtonClicked = false;
            divide1xButtonClicked = true;
            exponentButtonClicked = false;
            numberEButtonClicked = false;
            sinButtonClicked = false;
            lognButtonClicked = false;
            exponentEButtonClicked = false;
            sinNegButtonClicked = false;
            absoluteButtonClicked = false;
            sinHButtonClicked = false;
            sinHNegButtonClicked = false;
            tanHNegButtonClicked = false;
            cosButtonClicked = false;
            logarButtonClicked = false;
            expSquareButtonClicked = false;
            piButtonClicked = false;
            cosNegButtonClicked = false;
            cosHButtonClicked = false;
            cosHNegButtonClicked = false;
            tanNegButtonClicked = false;
            expCubedButtonClicked = false;
            tanHButtonClicked = false;
            radButtonClicked = false;
            factButtonClicked = false;
            cubedRootButtonClicked = false;
            twoExpButtonClicked = false;
            percentageButtonClicked = false;
            plusMinusButtonClicked = false;
        }
    }

    private void numberE(object sender, EventArgs e)
    {
        if (resultText.Text == "")
        {
            resultText.Text += "1";
            total1 = total1 + double.Parse(resultText.Text);
            resultText.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
            squareButtonClicked = false;
            tanButtonClicked = false;
            divide1xButtonClicked = false;
            exponentButtonClicked = false;
            numberEButtonClicked = true;
            sinButtonClicked = false;
            lognButtonClicked = false;
            exponentEButtonClicked = false;
            sinNegButtonClicked = false;
            absoluteButtonClicked = false;
            sinHButtonClicked = false;
            sinHNegButtonClicked = false;
            tanHNegButtonClicked = false;
            cosButtonClicked = false;
            logarButtonClicked = false;
            expSquareButtonClicked = false;
            piButtonClicked = false;
            cosNegButtonClicked = false;
            cosHButtonClicked = false;
            cosHNegButtonClicked = false;
            tanNegButtonClicked = false;
            expCubedButtonClicked = false;
            tanHButtonClicked = false;
            radButtonClicked = false;
            factButtonClicked = false;
            cubedRootButtonClicked = false;
            twoExpButtonClicked = false;
            percentageButtonClicked = false;
            plusMinusButtonClicked = false;
        }
        else if (resultText.Text != "")
        {
            total1 = total1 + double.Parse(resultText.Text);
            resultText.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
            squareButtonClicked = false;
            tanButtonClicked = false;
            divide1xButtonClicked = false;
            exponentButtonClicked = false;
            numberEButtonClicked = true;
            sinButtonClicked = false;
            lognButtonClicked = false;
            exponentEButtonClicked = false;
            sinNegButtonClicked = false;
            absoluteButtonClicked = false;
            sinHButtonClicked = false;
            sinHNegButtonClicked = false;
            tanHNegButtonClicked = false;
            cosButtonClicked = false;
            logarButtonClicked = false;
            expSquareButtonClicked = false;
            piButtonClicked = false;
            cosNegButtonClicked = false;
            cosHButtonClicked = false;
            cosHNegButtonClicked = false;
            tanNegButtonClicked = false;
            expCubedButtonClicked = false;
            tanHButtonClicked = false;
            radButtonClicked = false;
            factButtonClicked = false;
            cubedRootButtonClicked = false;
            twoExpButtonClicked = false;
            percentageButtonClicked = false;
            plusMinusButtonClicked = false;
        }
    }

    private async void exponent(object sender, EventArgs e)
    {
        if (resultText.Text == "")
        {
            await DisplayAlert("Caution", "Formato no válido", "OK");
        }
        else
        {
            total1 = total1 + double.Parse(resultText.Text);
            resultText.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
            squareButtonClicked = false;
            tanButtonClicked = false;
            divide1xButtonClicked = false;
            exponentButtonClicked = true;
            numberEButtonClicked = false;
            sinButtonClicked = false;
            lognButtonClicked = false;
            exponentEButtonClicked = false;
            sinNegButtonClicked = false;
            absoluteButtonClicked = false;
            sinHButtonClicked = false;
            sinHNegButtonClicked = false;
            tanHNegButtonClicked = false;
            cosButtonClicked = false;
            logarButtonClicked = false;
            expSquareButtonClicked = false;
            piButtonClicked = false;
            cosNegButtonClicked = false;
            cosHButtonClicked = false;
            cosHNegButtonClicked = false;
            tanNegButtonClicked = false;
            expCubedButtonClicked = false;
            tanHButtonClicked = false;
            radButtonClicked = false;
            factButtonClicked = false;
            cubedRootButtonClicked = false;
            twoExpButtonClicked = false;
            percentageButtonClicked = false;
            plusMinusButtonClicked = false;
        }
    }

    private void sin(object sender, EventArgs e)
    {
        if (resultText.Text == "")
        {
            resultText.Text += "1";
            total1 = total1 + double.Parse(resultText.Text);
            resultText.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
            squareButtonClicked = false;
            tanButtonClicked = false;
            divide1xButtonClicked = false;
            exponentButtonClicked = false;
            numberEButtonClicked = false;
            sinButtonClicked = true;
            lognButtonClicked = false;
            exponentEButtonClicked = false;
            sinNegButtonClicked = false;
            absoluteButtonClicked = false;
            sinHButtonClicked = false;
            sinHNegButtonClicked = false;
            tanHNegButtonClicked = false;
            cosButtonClicked = false;
            logarButtonClicked = false;
            expSquareButtonClicked = false;
            piButtonClicked = false;
            cosNegButtonClicked = false;
            cosHButtonClicked = false;
            cosHNegButtonClicked = false;
            tanNegButtonClicked = false;
            expCubedButtonClicked = false;
            tanHButtonClicked = false;
            radButtonClicked = false;
            factButtonClicked = false;
            cubedRootButtonClicked = false;
            twoExpButtonClicked = false;
            percentageButtonClicked = false;
            plusMinusButtonClicked = false;
        }
        else if (resultText.Text != "")
        {
            total1 = total1 + double.Parse(resultText.Text);
            resultText.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
            squareButtonClicked = false;
            tanButtonClicked = false;
            divide1xButtonClicked = false;
            exponentButtonClicked = false;
            numberEButtonClicked = false;
            sinButtonClicked = true;
            lognButtonClicked = false;
            exponentEButtonClicked = false;
            sinNegButtonClicked = false;
            absoluteButtonClicked = false;
            sinHButtonClicked = false;
            sinHNegButtonClicked = false;
            tanHNegButtonClicked = false;
            cosButtonClicked = false;
            logarButtonClicked = false;
            expSquareButtonClicked = false;
            piButtonClicked = false;
            cosNegButtonClicked = false;
            cosHButtonClicked = false;
            cosHNegButtonClicked = false;
            tanNegButtonClicked = false;
            expCubedButtonClicked = false;
            tanHButtonClicked = false;
            radButtonClicked = false;
            factButtonClicked = false;
            cubedRootButtonClicked = false;
            twoExpButtonClicked = false;
            percentageButtonClicked = false;
            plusMinusButtonClicked = false;
        }
    }

    private void logn(object sender, EventArgs e)
    {
        if (resultText.Text == "")
        {
            resultText.Text += "1";
            total1 = total1 + double.Parse(resultText.Text);
            resultText.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
            squareButtonClicked = false;
            tanButtonClicked = false;
            divide1xButtonClicked = false;
            exponentButtonClicked = false;
            numberEButtonClicked = false;
            sinButtonClicked = false;
            lognButtonClicked = true;
            exponentEButtonClicked = false;
            sinNegButtonClicked = false;
            absoluteButtonClicked = false;
            sinHButtonClicked = false;
            sinHNegButtonClicked = false;
            tanHNegButtonClicked = false;
            cosButtonClicked = false;
            logarButtonClicked = false;
            expSquareButtonClicked = false;
            piButtonClicked = false;
            cosNegButtonClicked = false;
            cosHButtonClicked = false;
            cosHNegButtonClicked = false;
            tanNegButtonClicked = false;
            expCubedButtonClicked = false;
            tanHButtonClicked = false;
            radButtonClicked = false;
            factButtonClicked = false;
            cubedRootButtonClicked = false;
            twoExpButtonClicked = false;
            percentageButtonClicked = false;
            plusMinusButtonClicked = false;
        }
        else if (resultText.Text != "")
        {
            total1 = total1 + double.Parse(resultText.Text);
            resultText.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
            squareButtonClicked = false;
            tanButtonClicked = false;
            divide1xButtonClicked = false;
            exponentButtonClicked = false;
            numberEButtonClicked = false;
            sinButtonClicked = false;
            lognButtonClicked = true;
            exponentEButtonClicked = false;
            sinNegButtonClicked = false;
            absoluteButtonClicked = false;
            sinHButtonClicked = false;
            sinHNegButtonClicked = false;
            tanHNegButtonClicked = false;
            cosButtonClicked = false;
            logarButtonClicked = false;
            expSquareButtonClicked = false;
            piButtonClicked = false;
            cosNegButtonClicked = false;
            cosHButtonClicked = false;
            cosHNegButtonClicked = false;
            tanNegButtonClicked = false;
            expCubedButtonClicked = false;
            tanHButtonClicked = false;
            radButtonClicked = false;
            factButtonClicked = false;
            cubedRootButtonClicked = false;
            twoExpButtonClicked = false;
            percentageButtonClicked = false;
            plusMinusButtonClicked = false;
        }
    }

    private void exponent_E(object sender, EventArgs e)
    {
        if (resultText.Text == "")
        {
            resultText.Text += "1";
            total1 = total1 + double.Parse(resultText.Text);
            resultText.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
            squareButtonClicked = false;
            tanButtonClicked = false;
            divide1xButtonClicked = false;
            exponentButtonClicked = false;
            numberEButtonClicked = false;
            sinButtonClicked = false;
            lognButtonClicked = false;
            exponentEButtonClicked = true;
            sinNegButtonClicked = false;
            absoluteButtonClicked = false;
            sinHButtonClicked = false;
            sinHNegButtonClicked = false;
            tanHNegButtonClicked = false;
            cosButtonClicked = false;
            logarButtonClicked = false;
            expSquareButtonClicked = false;
            piButtonClicked = false;
            cosNegButtonClicked = false;
            cosHButtonClicked = false;
            cosHNegButtonClicked = false;
            tanNegButtonClicked = false;
            expCubedButtonClicked = false;
            tanHButtonClicked = false;
            radButtonClicked = false;
            factButtonClicked = false;
            cubedRootButtonClicked = false;
            twoExpButtonClicked = false;
            percentageButtonClicked = false;
            plusMinusButtonClicked = false;
        }
        else if (resultText.Text != "")
        {
            total1 = total1 + double.Parse(resultText.Text);
            resultText.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
            squareButtonClicked = false;
            tanButtonClicked = false;
            divide1xButtonClicked = false;
            exponentButtonClicked = false;
            numberEButtonClicked = false;
            sinButtonClicked = false;
            lognButtonClicked = false;
            exponentEButtonClicked = true;
            sinNegButtonClicked = false;
            absoluteButtonClicked = false;
            sinHButtonClicked = false;
            sinHNegButtonClicked = false;
            tanHNegButtonClicked = false;
            cosButtonClicked = false;
            logarButtonClicked = false;
            expSquareButtonClicked = false;
            piButtonClicked = false;
            cosNegButtonClicked = false;
            cosHButtonClicked = false;
            cosHNegButtonClicked = false;
            tanNegButtonClicked = false;
            expCubedButtonClicked = false;
            tanHButtonClicked = false;
            radButtonClicked = false;
            factButtonClicked = false;
            cubedRootButtonClicked = false;
            twoExpButtonClicked = false;
            percentageButtonClicked = false;
            plusMinusButtonClicked = false;
        }
    }

    private void absolute(object sender, EventArgs e)
    {
        if (resultText.Text == "")
        {
            resultText.Text += "1";
            total1 = total1 + double.Parse(resultText.Text);
            resultText.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
            squareButtonClicked = false;
            tanButtonClicked = false;
            divide1xButtonClicked = false;
            exponentButtonClicked = false;
            numberEButtonClicked = false;
            sinButtonClicked = false;
            lognButtonClicked = false;
            exponentEButtonClicked = false;
            sinNegButtonClicked = false;
            absoluteButtonClicked = true;
            sinHButtonClicked = false;
            sinHNegButtonClicked = false;
            tanHNegButtonClicked = false;
            cosButtonClicked = false;
            logarButtonClicked = false;
            expSquareButtonClicked = false;
            piButtonClicked = false;
            cosNegButtonClicked = false;
            cosHButtonClicked = false;
            cosHNegButtonClicked = false;
            tanNegButtonClicked = false;
            expCubedButtonClicked = false;
            tanHButtonClicked = false;
            radButtonClicked = false;
            factButtonClicked = false;
            cubedRootButtonClicked = false;
            twoExpButtonClicked = false;
            percentageButtonClicked = false;
            plusMinusButtonClicked = false;
        }
        else if (resultText.Text != "")
        {
            total1 = total1 + double.Parse(resultText.Text);
            resultText.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
            squareButtonClicked = false;
            tanButtonClicked = false;
            divide1xButtonClicked = false;
            exponentButtonClicked = false;
            numberEButtonClicked = false;
            sinButtonClicked = false;
            lognButtonClicked = false;
            exponentEButtonClicked = false;
            sinNegButtonClicked = false;
            absoluteButtonClicked = true;
            sinHButtonClicked = false;
            sinHNegButtonClicked = false;
            tanHNegButtonClicked = false;
            cosButtonClicked = false;
            logarButtonClicked = false;
            expSquareButtonClicked = false;
            piButtonClicked = false;
            cosNegButtonClicked = false;
            cosHButtonClicked = false;
            cosHNegButtonClicked = false;
            tanNegButtonClicked = false;
            expCubedButtonClicked = false;
            tanHButtonClicked = false;
            radButtonClicked = false;
            factButtonClicked = false;
            cubedRootButtonClicked = false;
            twoExpButtonClicked = false;
            percentageButtonClicked = false;
            plusMinusButtonClicked = false;
        }
    }

    private void sinNegative(object sender, EventArgs e)
    {
        if (resultText.Text == "")
        {
            resultText.Text += "1";
            total1 = total1 + double.Parse(resultText.Text);
            resultText.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
            squareButtonClicked = false;
            tanButtonClicked = false;
            divide1xButtonClicked = false;
            exponentButtonClicked = false;
            numberEButtonClicked = false;
            sinButtonClicked = false;
            lognButtonClicked = false;
            exponentEButtonClicked = false;
            sinNegButtonClicked = true;
            absoluteButtonClicked = false;
            sinHButtonClicked = false;
            sinHNegButtonClicked = false;
            tanHNegButtonClicked = false;
            cosButtonClicked = false;
            logarButtonClicked = false;
            expSquareButtonClicked = false;
            piButtonClicked = false;
            cosNegButtonClicked = false;
            cosHButtonClicked = false;
            cosHNegButtonClicked = false;
            tanNegButtonClicked = false;
            expCubedButtonClicked = false;
            tanHButtonClicked = false;
            radButtonClicked = false;
            factButtonClicked = false;
            cubedRootButtonClicked = false;
            twoExpButtonClicked = false;
            percentageButtonClicked = false;
            plusMinusButtonClicked = false;
        }
        else if (resultText.Text != "")
        {
            total1 = total1 + double.Parse(resultText.Text);
            resultText.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
            squareButtonClicked = false;
            tanButtonClicked = false;
            divide1xButtonClicked = false;
            exponentButtonClicked = false;
            numberEButtonClicked = false;
            sinButtonClicked = false;
            lognButtonClicked = false;
            exponentEButtonClicked = false;
            sinNegButtonClicked = true;
            absoluteButtonClicked = false;
            sinHButtonClicked = false;
            sinHNegButtonClicked = false;
            tanHNegButtonClicked = false;
            cosButtonClicked = false;
            logarButtonClicked = false;
            expSquareButtonClicked = false;
            piButtonClicked = false;
            cosNegButtonClicked = false;
            cosHButtonClicked = false;
            cosHNegButtonClicked = false;
            tanNegButtonClicked = false;
            expCubedButtonClicked = false;
            tanHButtonClicked = false;
            radButtonClicked = false;
            factButtonClicked = false;
            cubedRootButtonClicked = false;
            twoExpButtonClicked = false;
            percentageButtonClicked = false;
            plusMinusButtonClicked = false;
        }
    }

    private void sinH(object sender, EventArgs e)
    {
        if (resultText.Text == "")
        {
            resultText.Text += "1";
            total1 = total1 + double.Parse(resultText.Text);
            resultText.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
            squareButtonClicked = false;
            tanButtonClicked = false;
            divide1xButtonClicked = false;
            exponentButtonClicked = false;
            numberEButtonClicked = false;
            sinButtonClicked = false;
            lognButtonClicked = false;
            exponentEButtonClicked = false;
            sinNegButtonClicked = false;
            absoluteButtonClicked = false;
            sinHButtonClicked = true;
            sinHNegButtonClicked = false;
            tanHNegButtonClicked = false;
            cosButtonClicked = false;
            logarButtonClicked = false;
            expSquareButtonClicked = false;
            piButtonClicked = false;
            cosNegButtonClicked = false;
            cosHButtonClicked = false;
            cosHNegButtonClicked = false;
            tanNegButtonClicked = false;
            expCubedButtonClicked = false;
            tanHButtonClicked = false;
            radButtonClicked = false;
            factButtonClicked = false;
            cubedRootButtonClicked = false;
            twoExpButtonClicked = false;
            percentageButtonClicked = false;
            plusMinusButtonClicked = false;
        }
        else if (resultText.Text != "")
        {
            total1 = total1 + double.Parse(resultText.Text);
            resultText.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
            squareButtonClicked = false;
            tanButtonClicked = false;
            divide1xButtonClicked = false;
            exponentButtonClicked = false;
            numberEButtonClicked = false;
            sinButtonClicked = false;
            lognButtonClicked = false;
            exponentEButtonClicked = false;
            sinNegButtonClicked = false;
            absoluteButtonClicked = false;
            sinHButtonClicked = true;
            sinHNegButtonClicked = false;
            tanHNegButtonClicked = false;
            cosButtonClicked = false;
            logarButtonClicked = false;
            expSquareButtonClicked = false;
            piButtonClicked = false;
            cosNegButtonClicked = false;
            cosHButtonClicked = false;
            cosHNegButtonClicked = false;
            tanNegButtonClicked = false;
            expCubedButtonClicked = false;
            tanHButtonClicked = false;
            radButtonClicked = false;
            factButtonClicked = false;
            cubedRootButtonClicked = false;
            twoExpButtonClicked = false;
            percentageButtonClicked = false;
            plusMinusButtonClicked = false;
        }
    }

    private void sinHNeg(object sender, EventArgs e)
    {
        if (resultText.Text == "")
        {
            resultText.Text += "1";
            total1 = total1 + double.Parse(resultText.Text);
            resultText.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
            squareButtonClicked = false;
            tanButtonClicked = false;
            divide1xButtonClicked = false;
            exponentButtonClicked = false;
            numberEButtonClicked = false;
            sinButtonClicked = false;
            lognButtonClicked = false;
            exponentEButtonClicked = false;
            sinNegButtonClicked = false;
            absoluteButtonClicked = false;
            sinHButtonClicked = false;
            sinHNegButtonClicked = true;
            tanHNegButtonClicked = false;
            cosButtonClicked = false;
            logarButtonClicked = false;
            expSquareButtonClicked = false;
            piButtonClicked = false;
            cosNegButtonClicked = false;
            cosHButtonClicked = false;
            cosHNegButtonClicked = false;
            tanNegButtonClicked = false;
            expCubedButtonClicked = false;
            tanHButtonClicked = false;
            radButtonClicked = false;
            factButtonClicked = false;
            cubedRootButtonClicked = false;
            twoExpButtonClicked = false;
            percentageButtonClicked = false;
            plusMinusButtonClicked = false;
        }
        else if (resultText.Text != "")
        {
            total1 = total1 + double.Parse(resultText.Text);
            resultText.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
            squareButtonClicked = false;
            tanButtonClicked = false;
            divide1xButtonClicked = false;
            exponentButtonClicked = false;
            numberEButtonClicked = false;
            sinButtonClicked = false;
            lognButtonClicked = false;
            exponentEButtonClicked = false;
            sinNegButtonClicked = false;
            absoluteButtonClicked = false;
            sinHButtonClicked = false;
            sinHNegButtonClicked = true;
            tanHNegButtonClicked = false;
            cosButtonClicked = false;
            logarButtonClicked = false;
            expSquareButtonClicked = false;
            piButtonClicked = false;
            cosNegButtonClicked = false;
            cosHButtonClicked = false;
            cosHNegButtonClicked = false;
            tanNegButtonClicked = false;
            expCubedButtonClicked = false;
            tanHButtonClicked = false;
            radButtonClicked = false;
            factButtonClicked = false;
            cubedRootButtonClicked = false;
            twoExpButtonClicked = false;
            percentageButtonClicked = false;
            plusMinusButtonClicked = false;
        }
    }

    private void tanHNeg(object sender, EventArgs e)
    {
        if (resultText.Text == "")
        {
            resultText.Text += "1";
            total1 = total1 + double.Parse(resultText.Text);
            resultText.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
            squareButtonClicked = false;
            tanButtonClicked = false;
            divide1xButtonClicked = false;
            exponentButtonClicked = false;
            numberEButtonClicked = false;
            sinButtonClicked = false;
            lognButtonClicked = false;
            exponentEButtonClicked = false;
            sinNegButtonClicked = false;
            absoluteButtonClicked = false;
            sinHButtonClicked = false;
            sinHNegButtonClicked = false;
            tanHNegButtonClicked = true;
            cosButtonClicked = false;
            logarButtonClicked = false;
            expSquareButtonClicked = false;
            piButtonClicked = false;
            cosNegButtonClicked = false;
            cosHButtonClicked = false;
            cosHNegButtonClicked = false;
            tanNegButtonClicked = false;
            expCubedButtonClicked = false;
            tanHButtonClicked = false;
            radButtonClicked = false;
            factButtonClicked = false;
            cubedRootButtonClicked = false;
            twoExpButtonClicked = false;
            percentageButtonClicked = false;
            plusMinusButtonClicked = false;
        }
        else if (resultText.Text != "")
        {
            total1 = total1 + double.Parse(resultText.Text);
            resultText.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
            squareButtonClicked = false;
            tanButtonClicked = false;
            divide1xButtonClicked = false;
            exponentButtonClicked = false;
            numberEButtonClicked = false;
            sinButtonClicked = false;
            lognButtonClicked = false;
            exponentEButtonClicked = false;
            sinNegButtonClicked = false;
            absoluteButtonClicked = false;
            sinHButtonClicked = false;
            sinHNegButtonClicked = false;
            tanHNegButtonClicked = true;
            cosButtonClicked = false;
            logarButtonClicked = false;
            expSquareButtonClicked = false;
            piButtonClicked = false;
            cosNegButtonClicked = false;
            cosHButtonClicked = false;
            cosHNegButtonClicked = false;
            tanNegButtonClicked = false;
            expCubedButtonClicked = false;
            tanHButtonClicked = false;
            radButtonClicked = false;
            factButtonClicked = false;
            cubedRootButtonClicked = false;
            twoExpButtonClicked = false;
            percentageButtonClicked = false;
            plusMinusButtonClicked = false;
        }
    }

    private void cos(object sender, EventArgs e)
    {
        if (resultText.Text == "")
        {
            resultText.Text += "1";
            total1 = total1 + double.Parse(resultText.Text);
            resultText.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
            squareButtonClicked = false;
            tanButtonClicked = false;
            divide1xButtonClicked = false;
            exponentButtonClicked = false;
            numberEButtonClicked = false;
            sinButtonClicked = false;
            lognButtonClicked = false;
            exponentEButtonClicked = false;
            sinNegButtonClicked = false;
            absoluteButtonClicked = false;
            sinHButtonClicked = false;
            sinHNegButtonClicked = false;
            tanHNegButtonClicked = false;
            cosButtonClicked = true;
            logarButtonClicked = false;
            expSquareButtonClicked = false;
            piButtonClicked = false;
            cosNegButtonClicked = false;
            cosHButtonClicked = false;
            cosHNegButtonClicked = false;
            tanNegButtonClicked = false;
            expCubedButtonClicked = false;
            tanHButtonClicked = false;
            radButtonClicked = false;
            factButtonClicked = false;
            cubedRootButtonClicked = false;
            twoExpButtonClicked = false;
            percentageButtonClicked = false;
            plusMinusButtonClicked = false;
        }
        else if (resultText.Text != "")
        {
            total1 = total1 + double.Parse(resultText.Text);
            resultText.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
            squareButtonClicked = false;
            tanButtonClicked = false;
            divide1xButtonClicked = false;
            exponentButtonClicked = false;
            numberEButtonClicked = false;
            sinButtonClicked = false;
            lognButtonClicked = false;
            exponentEButtonClicked = false;
            sinNegButtonClicked = false;
            absoluteButtonClicked = false;
            sinHButtonClicked = false;
            sinHNegButtonClicked = false;
            tanHNegButtonClicked = false;
            cosButtonClicked = true;
            logarButtonClicked = false;
            expSquareButtonClicked = false;
            piButtonClicked = false;
            cosNegButtonClicked = false;
            cosHButtonClicked = false;
            cosHNegButtonClicked = false;
            tanNegButtonClicked = false;
            expCubedButtonClicked = false;
            tanHButtonClicked = false;
            radButtonClicked = false;
            factButtonClicked = false;
            cubedRootButtonClicked = false;
            twoExpButtonClicked = false;
            percentageButtonClicked = false;
            plusMinusButtonClicked = false;
        }
    }

    private void logar(object sender, EventArgs e)
    {
        if (resultText.Text == "")
        {
            resultText.Text += "1";
            total1 = total1 + double.Parse(resultText.Text);
            resultText.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
            squareButtonClicked = false;
            tanButtonClicked = false;
            divide1xButtonClicked = false;
            exponentButtonClicked = false;
            numberEButtonClicked = false;
            sinButtonClicked = false;
            lognButtonClicked = false;
            exponentEButtonClicked = false;
            sinNegButtonClicked = false;
            absoluteButtonClicked = false;
            sinHButtonClicked = false;
            sinHNegButtonClicked = false;
            tanHNegButtonClicked = false;
            cosButtonClicked = false;
            logarButtonClicked = true;
            expSquareButtonClicked = false;
            piButtonClicked = false;
            cosNegButtonClicked = false;
            cosHButtonClicked = false;
            cosHNegButtonClicked = false;
            tanNegButtonClicked = false;
            expCubedButtonClicked = false;
            tanHButtonClicked = false;
            radButtonClicked = false;
            factButtonClicked = false;
            cubedRootButtonClicked = false;
            twoExpButtonClicked = false;
            percentageButtonClicked = false;
            plusMinusButtonClicked = false;
        }
        else if (resultText.Text != "")
        {
            total1 = total1 + double.Parse(resultText.Text);
            resultText.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
            squareButtonClicked = false;
            tanButtonClicked = false;
            divide1xButtonClicked = false;
            exponentButtonClicked = false;
            numberEButtonClicked = false;
            sinButtonClicked = false;
            lognButtonClicked = false;
            exponentEButtonClicked = false;
            sinNegButtonClicked = false;
            absoluteButtonClicked = false;
            sinHButtonClicked = false;
            sinHNegButtonClicked = false;
            tanHNegButtonClicked = false;
            cosButtonClicked = false;
            logarButtonClicked = true;
            expSquareButtonClicked = false;
            piButtonClicked = false;
            cosNegButtonClicked = false;
            cosHButtonClicked = false;
            cosHNegButtonClicked = false;
            tanNegButtonClicked = false;
            expCubedButtonClicked = false;
            tanHButtonClicked = false;
            radButtonClicked = false;
            factButtonClicked = false;
            cubedRootButtonClicked = false;
            twoExpButtonClicked = false;
            percentageButtonClicked = false;
            plusMinusButtonClicked = false;
        }
    }

    private async void expSquare(object sender, EventArgs e)
    {
        if (resultText.Text == "")
        {
            await DisplayAlert("Caution", "Formato no válido", "OK");
        }
        else
        {
            total1 = double.Parse(resultText.Text);

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
            squareButtonClicked = false;
            tanButtonClicked = false;
            divide1xButtonClicked = false;
            exponentButtonClicked = false;
            numberEButtonClicked = false;
            sinButtonClicked = false;
            lognButtonClicked = false;
            exponentEButtonClicked = false;
            sinNegButtonClicked = false;
            absoluteButtonClicked = false;
            sinHButtonClicked = false;
            sinHNegButtonClicked = false;
            tanHNegButtonClicked = false;
            cosButtonClicked = false;
            logarButtonClicked = false;
            expSquareButtonClicked = true;
            piButtonClicked = false;
            cosNegButtonClicked = false;
            cosHButtonClicked = false;
            cosHNegButtonClicked = false;
            tanNegButtonClicked = false;
            expCubedButtonClicked = false;
            tanHButtonClicked = false;
            radButtonClicked = false;
            factButtonClicked = false;
            cubedRootButtonClicked = false;
            twoExpButtonClicked = false;
            percentageButtonClicked = false;
            plusMinusButtonClicked = false;
        }
    }

    private void pi(object sender, EventArgs e)
    {
        if (resultText.Text == "")
        {
            resultText.Text += "1";
            total1 = total1 + double.Parse(resultText.Text);
            resultText.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
            squareButtonClicked = false;
            tanButtonClicked = false;
            divide1xButtonClicked = false;
            exponentButtonClicked = false;
            numberEButtonClicked = false;
            sinButtonClicked = false;
            lognButtonClicked = false;
            exponentEButtonClicked = false;
            sinNegButtonClicked = false;
            absoluteButtonClicked = false;
            sinHButtonClicked = false;
            sinHNegButtonClicked = false;
            tanHNegButtonClicked = false;
            cosButtonClicked = false;
            logarButtonClicked = false;
            expSquareButtonClicked = false;
            piButtonClicked = true;
            cosNegButtonClicked = false;
            cosHButtonClicked = false;
            cosHNegButtonClicked = false;
            tanNegButtonClicked = false;
            expCubedButtonClicked = false;
            tanHButtonClicked = false;
            radButtonClicked = false;
            factButtonClicked = false;
            cubedRootButtonClicked = false;
            twoExpButtonClicked = false;
            percentageButtonClicked = false;
            plusMinusButtonClicked = false;
        }
        else if (resultText.Text != "")
        {
            total1 = total1 + double.Parse(resultText.Text);
            resultText.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
            squareButtonClicked = false;
            tanButtonClicked = false;
            divide1xButtonClicked = false;
            exponentButtonClicked = false;
            numberEButtonClicked = false;
            sinButtonClicked = false;
            lognButtonClicked = false;
            exponentEButtonClicked = false;
            sinNegButtonClicked = false;
            absoluteButtonClicked = false;
            sinHButtonClicked = false;
            sinHNegButtonClicked = false;
            tanHNegButtonClicked = false;
            cosButtonClicked = false;
            logarButtonClicked = false;
            expSquareButtonClicked = false;
            piButtonClicked = true;
            cosNegButtonClicked = false;
            cosHButtonClicked = false;
            cosHNegButtonClicked = false;
            tanNegButtonClicked = false;
            expCubedButtonClicked = false;
            tanHButtonClicked = false;
            radButtonClicked = false;
            factButtonClicked = false;
            cubedRootButtonClicked = false;
            twoExpButtonClicked = false;
            percentageButtonClicked = false;
            plusMinusButtonClicked = false;
        }
    }

    private void cosNeg(object sender, EventArgs e)
    {
        if (resultText.Text == "")
        {
            resultText.Text += "1";
            total1 = total1 + double.Parse(resultText.Text);
            resultText.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
            squareButtonClicked = false;
            tanButtonClicked = false;
            divide1xButtonClicked = false;
            exponentButtonClicked = false;
            numberEButtonClicked = false;
            sinButtonClicked = false;
            lognButtonClicked = false;
            exponentEButtonClicked = false;
            sinNegButtonClicked = false;
            absoluteButtonClicked = false;
            sinHButtonClicked = false;
            sinHNegButtonClicked = false;
            tanHNegButtonClicked = false;
            cosButtonClicked = false;
            logarButtonClicked = false;
            expSquareButtonClicked = false;
            piButtonClicked = false;
            cosNegButtonClicked = true;
            cosHButtonClicked = false;
            cosHNegButtonClicked = false;
            tanNegButtonClicked = false;
            expCubedButtonClicked = false;
            tanHButtonClicked = false;
            radButtonClicked = false;
            factButtonClicked = false;
            cubedRootButtonClicked = false;
            twoExpButtonClicked = false;
            percentageButtonClicked = false;
            plusMinusButtonClicked = false;
        }
        else if (resultText.Text != "")
        {
            total1 = total1 + double.Parse(resultText.Text);
            resultText.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
            squareButtonClicked = false;
            tanButtonClicked = false;
            divide1xButtonClicked = false;
            exponentButtonClicked = false;
            numberEButtonClicked = false;
            sinButtonClicked = false;
            lognButtonClicked = false;
            exponentEButtonClicked = false;
            sinNegButtonClicked = false;
            absoluteButtonClicked = false;
            sinHButtonClicked = false;
            sinHNegButtonClicked = false;
            tanHNegButtonClicked = false;
            cosButtonClicked = false;
            logarButtonClicked = false;
            expSquareButtonClicked = false;
            piButtonClicked = false;
            cosNegButtonClicked = true;
            cosHButtonClicked = false;
            cosHNegButtonClicked = false;
            tanNegButtonClicked = false;
            expCubedButtonClicked = false;
            tanHButtonClicked = false;
            radButtonClicked = false;
            factButtonClicked = false;
            cubedRootButtonClicked = false;
            twoExpButtonClicked = false;
            percentageButtonClicked = false;
            plusMinusButtonClicked = false;
        }
    }

    private void cosH(object sender, EventArgs e)
    {
        if (resultText.Text == "")
        {
            resultText.Text += "1";
            total1 = total1 + double.Parse(resultText.Text);
            resultText.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
            squareButtonClicked = false;
            tanButtonClicked = false;
            divide1xButtonClicked = false;
            exponentButtonClicked = false;
            numberEButtonClicked = false;
            sinButtonClicked = false;
            lognButtonClicked = false;
            exponentEButtonClicked = false;
            sinNegButtonClicked = false;
            absoluteButtonClicked = false;
            sinHButtonClicked = false;
            sinHNegButtonClicked = false;
            tanHNegButtonClicked = false;
            cosButtonClicked = false;
            logarButtonClicked = false;
            expSquareButtonClicked = false;
            piButtonClicked = false;
            cosNegButtonClicked = false;
            cosHButtonClicked = true;
            cosHNegButtonClicked = false;
            tanNegButtonClicked = false;
            expCubedButtonClicked = false;
            tanHButtonClicked = false;
            radButtonClicked = false;
            factButtonClicked = false;
            cubedRootButtonClicked = false;
            twoExpButtonClicked = false;
            percentageButtonClicked = false;
            plusMinusButtonClicked = false;
        }
        else if (resultText.Text != "")
        {
            total1 = total1 + double.Parse(resultText.Text);
            resultText.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
            squareButtonClicked = false;
            tanButtonClicked = false;
            divide1xButtonClicked = false;
            exponentButtonClicked = false;
            numberEButtonClicked = false;
            sinButtonClicked = false;
            lognButtonClicked = false;
            exponentEButtonClicked = false;
            sinNegButtonClicked = false;
            absoluteButtonClicked = false;
            sinHButtonClicked = false;
            sinHNegButtonClicked = false;
            tanHNegButtonClicked = false;
            cosButtonClicked = false;
            logarButtonClicked = false;
            expSquareButtonClicked = false;
            piButtonClicked = false;
            cosNegButtonClicked = false;
            cosHButtonClicked = true;
            cosHNegButtonClicked = false;
            tanNegButtonClicked = false;
            expCubedButtonClicked = false;
            tanHButtonClicked = false;
            radButtonClicked = false;
            factButtonClicked = false;
            cubedRootButtonClicked = false;
            twoExpButtonClicked = false;
            percentageButtonClicked = false;
            plusMinusButtonClicked = false;
        }
    }

    private void cosHNeg(object sender, EventArgs e)
    {
        if (resultText.Text == "")
        {
            resultText.Text += "1";
            total1 = total1 + double.Parse(resultText.Text);
            resultText.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
            squareButtonClicked = false;
            tanButtonClicked = false;
            divide1xButtonClicked = false;
            exponentButtonClicked = false;
            numberEButtonClicked = false;
            sinButtonClicked = false;
            lognButtonClicked = false;
            exponentEButtonClicked = false;
            sinNegButtonClicked = false;
            absoluteButtonClicked = false;
            sinHButtonClicked = false;
            sinHNegButtonClicked = false;
            tanHNegButtonClicked = false;
            cosButtonClicked = false;
            logarButtonClicked = false;
            expSquareButtonClicked = false;
            piButtonClicked = false;
            cosNegButtonClicked = false;
            cosHButtonClicked = false;
            cosHNegButtonClicked = true;
            tanNegButtonClicked = false;
            expCubedButtonClicked = false;
            tanHButtonClicked = false;
            radButtonClicked = false;
            factButtonClicked = false;
            cubedRootButtonClicked = false;
            twoExpButtonClicked = false;
            percentageButtonClicked = false;
            plusMinusButtonClicked = false;
        }
        else if (resultText.Text != "")
        {
            total1 = total1 + double.Parse(resultText.Text);
            resultText.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
            squareButtonClicked = false;
            tanButtonClicked = false;
            divide1xButtonClicked = false;
            exponentButtonClicked = false;
            numberEButtonClicked = false;
            sinButtonClicked = false;
            lognButtonClicked = false;
            exponentEButtonClicked = false;
            sinNegButtonClicked = false;
            absoluteButtonClicked = false;
            sinHButtonClicked = false;
            sinHNegButtonClicked = false;
            tanHNegButtonClicked = false;
            cosButtonClicked = false;
            logarButtonClicked = false;
            expSquareButtonClicked = false;
            piButtonClicked = false;
            cosNegButtonClicked = false;
            cosHButtonClicked = false;
            cosHNegButtonClicked = true;
            tanNegButtonClicked = false;
            expCubedButtonClicked = false;
            tanHButtonClicked = false;
            radButtonClicked = false;
            factButtonClicked = false;
            cubedRootButtonClicked = false;
            twoExpButtonClicked = false;
            percentageButtonClicked = false;
            plusMinusButtonClicked = false;
        }
    }

    private async void exponentCubed(object sender, EventArgs e)
    {

        if (resultText.Text == "")
        {
            await DisplayAlert("Caution", "Formato no válido", "OK");
        }
        else
        {
            total1 = double.Parse(resultText.Text);

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
            squareButtonClicked = false;
            tanButtonClicked = false;
            divide1xButtonClicked = false;
            exponentButtonClicked = false;
            numberEButtonClicked = false;
            sinButtonClicked = false;
            lognButtonClicked = false;
            exponentEButtonClicked = false;
            sinNegButtonClicked = false;
            absoluteButtonClicked = false;
            sinHButtonClicked = false;
            sinHNegButtonClicked = false;
            tanHNegButtonClicked = false;
            cosButtonClicked = false;
            logarButtonClicked = false;
            expSquareButtonClicked = false;
            piButtonClicked = false;
            cosNegButtonClicked = false;
            cosHButtonClicked = false;
            cosHNegButtonClicked = false;
            tanNegButtonClicked = false;
            expCubedButtonClicked = true;
            tanHButtonClicked = false;
            radButtonClicked = false;
            factButtonClicked = false;
            cubedRootButtonClicked = false;
            twoExpButtonClicked = false;
            percentageButtonClicked = false;
            plusMinusButtonClicked = false;
        }
    }

    private void tanNeg(object sender, EventArgs e)
    {
        if (resultText.Text == "")
        {
            resultText.Text += "1";
            total1 = total1 + double.Parse(resultText.Text);
            resultText.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
            squareButtonClicked = false;
            tanButtonClicked = false;
            divide1xButtonClicked = false;
            exponentButtonClicked = false;
            numberEButtonClicked = false;
            sinButtonClicked = false;
            lognButtonClicked = false;
            exponentEButtonClicked = false;
            sinNegButtonClicked = false;
            absoluteButtonClicked = false;
            sinHButtonClicked = false;
            sinHNegButtonClicked = false;
            tanHNegButtonClicked = false;
            cosButtonClicked = false;
            logarButtonClicked = false;
            expSquareButtonClicked = false;
            piButtonClicked = false;
            cosNegButtonClicked = false;
            cosHButtonClicked = false;
            cosHNegButtonClicked = false;
            tanNegButtonClicked = true;
            expCubedButtonClicked = false;
            tanHButtonClicked = false;
            radButtonClicked = false;
            factButtonClicked = false;
            cubedRootButtonClicked = false;
            twoExpButtonClicked = false;
            percentageButtonClicked = false;
            plusMinusButtonClicked = false;
        }
        else if (resultText.Text != "")
        {
            total1 = total1 + double.Parse(resultText.Text);
            resultText.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
            squareButtonClicked = false;
            tanButtonClicked = false;
            divide1xButtonClicked = false;
            exponentButtonClicked = false;
            numberEButtonClicked = false;
            sinButtonClicked = false;
            lognButtonClicked = false;
            exponentEButtonClicked = false;
            sinNegButtonClicked = false;
            absoluteButtonClicked = false;
            sinHButtonClicked = false;
            sinHNegButtonClicked = false;
            tanHNegButtonClicked = false;
            cosButtonClicked = false;
            logarButtonClicked = false;
            expSquareButtonClicked = false;
            piButtonClicked = false;
            cosNegButtonClicked = false;
            cosHButtonClicked = false;
            cosHNegButtonClicked = false;
            tanNegButtonClicked = true;
            expCubedButtonClicked = false;
            tanHButtonClicked = false;
            radButtonClicked = false;
            factButtonClicked = false;
            cubedRootButtonClicked = false;
            twoExpButtonClicked = false;
            percentageButtonClicked = false;
            plusMinusButtonClicked = false;
        }
    }

    private void tanH(object sender, EventArgs e)
    {
        if (resultText.Text == "")
        {
            resultText.Text += "1";
            total1 = total1 + double.Parse(resultText.Text);
            resultText.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
            squareButtonClicked = false;
            tanButtonClicked = false;
            divide1xButtonClicked = false;
            exponentButtonClicked = false;
            numberEButtonClicked = false;
            sinButtonClicked = false;
            lognButtonClicked = false;
            exponentEButtonClicked = false;
            sinNegButtonClicked = false;
            absoluteButtonClicked = false;
            sinHButtonClicked = false;
            sinHNegButtonClicked = false;
            tanHNegButtonClicked = false;
            cosButtonClicked = false;
            logarButtonClicked = false;
            expSquareButtonClicked = false;
            piButtonClicked = false;
            cosNegButtonClicked = false;
            cosHButtonClicked = false;
            cosHNegButtonClicked = false;
            tanNegButtonClicked = false;
            expCubedButtonClicked = false;
            tanHButtonClicked = true;
            radButtonClicked = false;
            factButtonClicked = false;
            cubedRootButtonClicked = false;
            twoExpButtonClicked = false;
            percentageButtonClicked = false;
            plusMinusButtonClicked = false;
        }
        else if (resultText.Text != "")
        {
            total1 = total1 + double.Parse(resultText.Text);
            resultText.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
            squareButtonClicked = false;
            tanButtonClicked = false;
            divide1xButtonClicked = false;
            exponentButtonClicked = false;
            numberEButtonClicked = false;
            sinButtonClicked = false;
            lognButtonClicked = false;
            exponentEButtonClicked = false;
            sinNegButtonClicked = false;
            absoluteButtonClicked = false;
            sinHButtonClicked = false;
            sinHNegButtonClicked = false;
            tanHNegButtonClicked = false;
            cosButtonClicked = false;
            logarButtonClicked = false;
            expSquareButtonClicked = false;
            piButtonClicked = false;
            cosNegButtonClicked = false;
            cosHButtonClicked = false;
            cosHNegButtonClicked = true;
            tanNegButtonClicked = false;
            expCubedButtonClicked = false;
            tanHButtonClicked = true;
            radButtonClicked = false;
            factButtonClicked = false;
            cubedRootButtonClicked = false;
            twoExpButtonClicked = false;
            percentageButtonClicked = false;
            plusMinusButtonClicked = false;
        }
    }

    private async void rad(object sender, EventArgs e)
    {
        if (resultText.Text == "")
        {
            await DisplayAlert("Caution", "Formato no válido", "OK");
        }
        else
        {
            total1 = total1 + double.Parse(resultText.Text);
            resultText.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = true;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
            squareButtonClicked = false;
            tanButtonClicked = false;
            divide1xButtonClicked = false;
            exponentButtonClicked = false;
            numberEButtonClicked = false;
            sinButtonClicked = false;
            lognButtonClicked = false;
            exponentEButtonClicked = false;
            sinNegButtonClicked = false;
            absoluteButtonClicked = false;
            sinHButtonClicked = false;
            sinHNegButtonClicked = false;
            tanHNegButtonClicked = false;
            cosButtonClicked = false;
            logarButtonClicked = false;
            expSquareButtonClicked = false;
            piButtonClicked = false;
            cosNegButtonClicked = false;
            cosHButtonClicked = false;
            cosHNegButtonClicked = false;
            tanNegButtonClicked = false;
            expCubedButtonClicked = false;
            tanHButtonClicked = false;
            radButtonClicked = false;
            factButtonClicked = false;
            cubedRootButtonClicked = false;
            twoExpButtonClicked = false;
            percentageButtonClicked = false;
            plusMinusButtonClicked = false;
        }
    }

    private async void fact(object sender, EventArgs e)
    {
        if (resultText.Text == "")
        {
            await DisplayAlert("Caution", "Formato no válido", "OK");
        }
        else
        {
            total1 = total1 + double.Parse(resultText.Text);
            resultText.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
            squareButtonClicked = false;
            tanButtonClicked = false;
            divide1xButtonClicked = false;
            exponentButtonClicked = false;
            numberEButtonClicked = false;
            sinButtonClicked = false;
            lognButtonClicked = false;
            exponentEButtonClicked = false;
            sinNegButtonClicked = false;
            absoluteButtonClicked = false;
            sinHButtonClicked = false;
            sinHNegButtonClicked = false;
            tanHNegButtonClicked = false;
            cosButtonClicked = false;
            logarButtonClicked = false;
            expSquareButtonClicked = false;
            piButtonClicked = false;
            cosNegButtonClicked = false;
            cosHButtonClicked = false;
            cosHNegButtonClicked = false;
            tanNegButtonClicked = false;
            expCubedButtonClicked = false;
            tanHButtonClicked = false;
            radButtonClicked = false;
            factButtonClicked = true;
            cubedRootButtonClicked = false;
            twoExpButtonClicked = false;
            percentageButtonClicked = false;
            plusMinusButtonClicked = false;
        }
    }

    private void cubedRoot(object sender, EventArgs e)
    {
        if (resultText.Text == "")
        {
            resultText.Text += "1";
            total1 = total1 + double.Parse(resultText.Text);
            resultText.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
            squareButtonClicked = false;
            tanButtonClicked = false;
            divide1xButtonClicked = false;
            exponentButtonClicked = false;
            numberEButtonClicked = false;
            sinButtonClicked = false;
            lognButtonClicked = false;
            exponentEButtonClicked = false;
            sinNegButtonClicked = false;
            absoluteButtonClicked = false;
            sinHButtonClicked = false;
            sinHNegButtonClicked = false;
            tanHNegButtonClicked = false;
            cosButtonClicked = false;
            logarButtonClicked = false;
            expSquareButtonClicked = false;
            piButtonClicked = false;
            cosNegButtonClicked = false;
            cosHButtonClicked = false;
            cosHNegButtonClicked = false;
            tanNegButtonClicked = false;
            expCubedButtonClicked = false;
            tanHButtonClicked = false;
            radButtonClicked = false;
            factButtonClicked = false;
            cubedRootButtonClicked = true;
            twoExpButtonClicked = false;
            percentageButtonClicked = false;
            plusMinusButtonClicked = false;
        }
        else if (resultText.Text != "")
        {
            total1 = total1 + double.Parse(resultText.Text);
            resultText.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
            squareButtonClicked = false;
            tanButtonClicked = false;
            divide1xButtonClicked = false;
            exponentButtonClicked = false;
            numberEButtonClicked = false;
            sinButtonClicked = false;
            lognButtonClicked = false;
            exponentEButtonClicked = false;
            sinNegButtonClicked = false;
            absoluteButtonClicked = false;
            sinHButtonClicked = false;
            sinHNegButtonClicked = false;
            tanHNegButtonClicked = false;
            cosButtonClicked = false;
            logarButtonClicked = false;
            expSquareButtonClicked = false;
            piButtonClicked = false;
            cosNegButtonClicked = false;
            cosHButtonClicked = false;
            cosHNegButtonClicked = false;
            tanNegButtonClicked = false;
            expCubedButtonClicked = false;
            tanHButtonClicked = false;
            radButtonClicked = false;
            factButtonClicked = false;
            cubedRootButtonClicked = true;
            twoExpButtonClicked = false;
            percentageButtonClicked = false;
            plusMinusButtonClicked = false;
        }
    }

    private void twoExp(object sender, EventArgs e)
    {
        if (resultText.Text == "")
        {
            resultText.Text += "1";
            total1 = total1 + double.Parse(resultText.Text);
            resultText.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
            squareButtonClicked = false;
            tanButtonClicked = false;
            divide1xButtonClicked = false;
            exponentButtonClicked = false;
            numberEButtonClicked = false;
            sinButtonClicked = false;
            lognButtonClicked = false;
            exponentEButtonClicked = false;
            sinNegButtonClicked = false;
            absoluteButtonClicked = false;
            sinHButtonClicked = false;
            sinHNegButtonClicked = false;
            tanHNegButtonClicked = false;
            cosButtonClicked = false;
            logarButtonClicked = false;
            expSquareButtonClicked = false;
            piButtonClicked = false;
            cosNegButtonClicked = false;
            cosHButtonClicked = false;
            cosHNegButtonClicked = false;
            tanNegButtonClicked = false;
            expCubedButtonClicked = false;
            tanHButtonClicked = false;
            radButtonClicked = false;
            factButtonClicked = false;
            cubedRootButtonClicked = false;
            twoExpButtonClicked = true;
            percentageButtonClicked = false;
            plusMinusButtonClicked = false;
        }
        else if (resultText.Text != "")
        {
            total1 = total1 + double.Parse(resultText.Text);
            resultText.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = false;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
            squareButtonClicked = false;
            tanButtonClicked = false;
            divide1xButtonClicked = false;
            exponentButtonClicked = false;
            numberEButtonClicked = false;
            sinButtonClicked = false;
            lognButtonClicked = false;
            exponentEButtonClicked = false;
            sinNegButtonClicked = false;
            absoluteButtonClicked = false;
            sinHButtonClicked = false;
            sinHNegButtonClicked = false;
            tanHNegButtonClicked = false;
            cosButtonClicked = false;
            logarButtonClicked = false;
            expSquareButtonClicked = false;
            piButtonClicked = false;
            cosNegButtonClicked = false;
            cosHButtonClicked = false;
            cosHNegButtonClicked = false;
            tanNegButtonClicked = false;
            expCubedButtonClicked = false;
            tanHButtonClicked = false;
            radButtonClicked = false;
            factButtonClicked = false;
            cubedRootButtonClicked = false;
            twoExpButtonClicked = true;
            percentageButtonClicked = false;
            plusMinusButtonClicked = false;
        }
    }

    private async void plusMinus(object sender, EventArgs e)
    {
        if (resultText.Text == "")
        {
            await DisplayAlert("Caution", "Formato no válido", "OK");
        }
        else
        {
            total1 = total1 + double.Parse(resultText.Text);
            resultText.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = true;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
            squareButtonClicked = false;
            tanButtonClicked = false;
            divide1xButtonClicked = false;
            exponentButtonClicked = false;
            numberEButtonClicked = false;
            sinButtonClicked = false;
            lognButtonClicked = false;
            exponentEButtonClicked = false;
            sinNegButtonClicked = false;
            absoluteButtonClicked = false;
            sinHButtonClicked = false;
            sinHNegButtonClicked = false;
            tanHNegButtonClicked = false;
            cosButtonClicked = false;
            logarButtonClicked = false;
            expSquareButtonClicked = false;
            piButtonClicked = false;
            cosNegButtonClicked = false;
            cosHButtonClicked = false;
            cosHNegButtonClicked = false;
            tanNegButtonClicked = false;
            expCubedButtonClicked = false;
            tanHButtonClicked = false;
            radButtonClicked = false;
            factButtonClicked = false;
            cubedRootButtonClicked = false;
            twoExpButtonClicked = false;
            percentageButtonClicked = false;
            plusMinusButtonClicked = false;
        }
    }

    private async void percentage(object sender, EventArgs e)
    {
        if (resultText.Text == "")
        {
            await DisplayAlert("Caution", "Formato no válido", "OK");
        }
        else
        {
            total1 = total1 + double.Parse(resultText.Text);
            resultText.Text = "";

            plusButtonClicked = false;
            minusButtonClicked = true;
            multiplyButtonClicked = false;
            divideButtonClicked = false;
            squareButtonClicked = false;
            tanButtonClicked = false;
            divide1xButtonClicked = false;
            exponentButtonClicked = false;
            numberEButtonClicked = false;
            sinButtonClicked = false;
            lognButtonClicked = false;
            exponentEButtonClicked = false;
            sinNegButtonClicked = false;
            absoluteButtonClicked = false;
            sinHButtonClicked = false;
            sinHNegButtonClicked = false;
            tanHNegButtonClicked = false;
            cosButtonClicked = false;
            logarButtonClicked = false;
            expSquareButtonClicked = false;
            piButtonClicked = false;
            cosNegButtonClicked = false;
            cosHButtonClicked = false;
            cosHNegButtonClicked = false;
            tanNegButtonClicked = false;
            expCubedButtonClicked = false;
            tanHButtonClicked = false;
            radButtonClicked = false;
            factButtonClicked = false;
            cubedRootButtonClicked = false;
            twoExpButtonClicked = false;
            percentageButtonClicked = false;
            plusMinusButtonClicked = false;
        }
    }

    private void equals(object sender, EventArgs e)
    {
        if (plusButtonClicked == true)
        {
            try
            {
                total2 = total1 + double.Parse(resultText.Text);
                resultText.Text = total2.ToString();
                total1 = 0;
            }
            catch (Exception ex)
            {
                DisplayAlert("Caution", "Formato no válido", "OK");
            }
        }
        else if (minusButtonClicked == true)
        {
            try
            {
                total2 = total1 - double.Parse(resultText.Text);
                resultText.Text = total2.ToString();
                total1 = 0;
            }
            catch (Exception ex)
            {
                DisplayAlert("Caution", "Formato no válido", "OK");
            }
        }
        else if (multiplyButtonClicked == true)
        {
            try
            {
                total2 = total1 * double.Parse(resultText.Text);
                resultText.Text = total2.ToString();
                total1 = 0;
            }
            catch (Exception ex)
            {
                DisplayAlert("Caution", "Formato no válido", "OK");
            }
        }
        else if (divideButtonClicked == true)
        {
            try
            {
                total2 = total1 / double.Parse(resultText.Text);
                resultText.Text = total2.ToString();
                total1 = 0;
            }
            catch (Exception ex)
            {
                DisplayAlert("Caution", "Formato no válido", "OK");
            }
        }
        else if (squareButtonClicked == true)
        {
            total2 = total1 * Math.Sqrt(double.Parse(resultText.Text));
            resultText.Text = total2.ToString();
            total1 = 0;
        }
        else if (tanButtonClicked == true)
        {
            try
            {
                total2 = total1 * Math.Tan(double.Parse(resultText.Text));
                resultText.Text = total2.ToString();
                total1 = 0;
            }
            catch (Exception ex)
            {
                DisplayAlert("Caution", "Formato no válido", "OK");
            }
        }
        else if (numberEButtonClicked == true)
        {
            try
            {
                total2 = total1 * Math.E * double.Parse(resultText.Text);
                resultText.Text = total2.ToString();
                total1 = 0;
            }
            catch (Exception ex)
            {
                DisplayAlert("Caution", "Formato no válido", "OK");
            }
        }
        else if (divide1xButtonClicked == true)
        {
            try
            {
                total2 = total1 * (1 / double.Parse(resultText.Text));
                resultText.Text = total2.ToString();
                total1 = 0;
            }
            catch (Exception ex)
            {
                DisplayAlert("Caution", "Formato no válido", "OK");
            }
        }
        else if (exponentButtonClicked == true)
        {
            try
            {
                total2 = Math.Pow(total1, double.Parse(resultText.Text));
                resultText.Text = total2.ToString();
                total1 = 0;
            }
            catch (Exception ex)
            {
                DisplayAlert("Caution", "Formato no válido", "OK");
            }
        }
        else if (sinButtonClicked == true)
        {
            try
            {
                total2 = total1 * Math.Sin(double.Parse(resultText.Text));
                resultText.Text = total2.ToString();
                total1 = 0;
            }
            catch (Exception ex)
            {
                DisplayAlert("Caution", "Formato no válido", "OK");
            }
        }
        else if (sinButtonClicked == true)
        {
            try
            {
                total2 = total1 * Math.Sin(double.Parse(resultText.Text));
                resultText.Text = total2.ToString();
                total1 = 0;
            }
            catch (Exception ex)
            {
                DisplayAlert("Caution", "Formato no válido", "OK");
            }
        }
        else if (lognButtonClicked == true)
        {
            try
            {
                total2 = total1 * Math.Log(double.Parse(resultText.Text));
                resultText.Text = total2.ToString();
                total1 = 0;
            }
            catch (Exception ex)
            {
                DisplayAlert("Caution", "Formato no válido", "OK");
            }
        }
        else if (exponentEButtonClicked == true)
        {
            try
            {
                total2 = total1 * Math.Pow(Math.E, double.Parse(resultText.Text));
                resultText.Text = total2.ToString();
                total1 = 0;
            }
            catch (Exception ex)
            {
                DisplayAlert("Caution", "Formato no válido", "OK");
            }
        }
        else if (absoluteButtonClicked == true)
        {
            try
            {
                total2 = Math.Abs(double.Parse(resultText.Text));
                resultText.Text = total2.ToString();
                total1 = 0;
            }
            catch (Exception ex)
            {
                DisplayAlert("Caution", "Formato no válido", "OK");
            }
        }
        else if (sinNegButtonClicked == true)
        {
            try
            {
                total2 = total1 * (((Math.Asin(double.Parse(resultText.Text))) * 180) / Math.PI);
                resultText.Text = total2.ToString();
                total1 = 0;
            }
            catch (Exception ex)
            {
                DisplayAlert("Caution", "Formato no válido", "OK");
            }
        }
        else if (sinHButtonClicked == true)
        {
            try
            {
                total2 = total1 * Math.Sinh(double.Parse(resultText.Text));
                resultText.Text = total2.ToString();
                total1 = 0;
            }
            catch (Exception ex)
            {
                DisplayAlert("Caution", "Formato no válido", "OK");
            }
        }
        else if (sinHNegButtonClicked == true)
        {
            try
            {
                total2 = total1 * Math.Asinh(double.Parse(resultText.Text));
                resultText.Text = total2.ToString();
                total1 = 0;
            }
            catch (Exception ex)
            {
                DisplayAlert("Caution", "Formato no válido", "OK");
            }
        }
        else if (tanHNegButtonClicked == true)
        {
            try
            {
                total2 = total1 * Math.Atanh(double.Parse(resultText.Text));
                resultText.Text = total2.ToString();
                total1 = 0;
            }
            catch (Exception ex)
            {
                DisplayAlert("Caution", "Formato no válido", "OK");
            }
        }
        else if (cosButtonClicked == true)
        {
            try
            {
                total2 = total1 * Math.Cos(double.Parse(resultText.Text));
                total2 = (180 / Math.PI) * total2;
                resultText.Text = total2.ToString();
                total1 = 0;
            }
            catch (Exception ex)
            {
                DisplayAlert("Caution", "Formato no válido", "OK");
            }
        }
        else if (logarButtonClicked == true)
        {
            try
            {
                total2 = total1 * Math.Log10(double.Parse(resultText.Text));
                resultText.Text = total2.ToString();
                total1 = 0;
            }
            catch (Exception ex)
            {
                DisplayAlert("Caution", "Formato no válido", "OK");
            }
        }
        else if (expSquareButtonClicked == true)
        {
            try
            {
                total2 = Math.Pow(double.Parse(resultText.Text), 2);
                resultText.Text = total2.ToString();
                total1 = 0;
            }
            catch (Exception ex)
            {
                DisplayAlert("Caution", "Formato no válido", "OK");
            }
        }
        else if (piButtonClicked == true)
        {
            try
            {
                total2 = total1 * Math.PI * double.Parse(resultText.Text);
                resultText.Text = total2.ToString();
                total1 = 0;
            }
            catch (Exception ex)
            {
                DisplayAlert("Caution", "Formato no válido", "OK");
            }
        }
        else if (cosNegButtonClicked == true)
        {
            try
            {
                total2 = total1 * Math.Acos(double.Parse(resultText.Text));
                total2 = (180 / Math.PI) * total2;
                resultText.Text = total2.ToString();
                total1 = 0;
            }
            catch (Exception ex)
            {
                DisplayAlert("Caution", "Formato no válido", "OK");
            }
        }
        else if (cosHButtonClicked == true)
        {
            try
            {
                total2 = total1 * Math.Cosh(double.Parse(resultText.Text));
                total2 = (180 / Math.PI) * total2;
                resultText.Text = total2.ToString();
                total1 = 0;
            }
            catch (Exception ex)
            {
                DisplayAlert("Caution", "Formato no válido", "OK");
            }
        }
        else if (cosHNegButtonClicked == true)
        {
            try
            {
                total2 = total1 * Math.Acosh(double.Parse(resultText.Text));
                total2 = (180 / Math.PI) * total2;
                resultText.Text = total2.ToString();
                total1 = 0;
            }
            catch (Exception ex)
            {
                DisplayAlert("Caution", "Formato no válido", "OK");
            }
        }
        else if (tanNegButtonClicked == true)
        {
            try
            {
                total2 = total1 * Math.Atan(double.Parse(resultText.Text));
                total2 = (180 / Math.PI) * total2;
                resultText.Text = total2.ToString();
                total1 = 0;
            }
            catch (Exception ex)
            {
                DisplayAlert("Caution", "Formato no válido", "OK");
            }
        }
        else if (expCubedButtonClicked == true)
        {
            try
            {
                total2 = Math.Pow(double.Parse(resultText.Text), 3);
                resultText.Text = total2.ToString();
                total1 = 0;
            }
            catch (Exception ex)
            {
                DisplayAlert("Caution", "Formato no válido", "OK");
            }
        }
        else if (cubedRootButtonClicked == true)
        {
            try
            {
                total2 = total1 * Math.Pow(double.Parse(resultText.Text), 1.0 / 3.0);
                resultText.Text = total2.ToString();
                total1 = 0;
            }
            catch (Exception ex)
            {
                DisplayAlert("Caution", "Formato no válido", "OK");
            }
        }
        else if (twoExpButtonClicked == true)
        {
            try
            {
                total2 = total1 * Math.Pow(2.0, double.Parse(resultText.Text));
                resultText.Text = total2.ToString();
                total1 = 0;
            }
            catch (Exception ex)
            {
                DisplayAlert("Caution", "Formato no válido", "OK");
            }
        }
        if (factButtonClicked == true)
        {

            int fact = 1;

            for (int x = 1; x <= total1; x++)
            {
                fact *= x;
            }

            total2 = fact;
            resultText.Text = total2.ToString();
            total1 = 0;
        }
    }

    private void clear(object sender, EventArgs e)
    {
        resultText.Text = "";
    }

    private void decimalPoint(object sender, EventArgs e)
    {
        resultText.Text += ".";
    }
}