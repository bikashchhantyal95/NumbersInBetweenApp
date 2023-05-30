namespace NumbersInBetween;

public partial class MainPage : ContentPage
{
	string output_number = "";
	public MainPage()
	{
		InitializeComponent();
		incrementBy.Text = "1";
	}

	public void displayNumbers(object sender, EventArgs e)
	{
		output_number = "";
	
		if(!int.TryParse(firstNumber.Text, out int first_number) || !int.TryParse(secondNumber.Text, out int second_number))
		{
			OutputValue.Text = "Input is not valid. Enter valid stard and end numbers.";
			return;
			
		}

		int incrementValue;

		if (!string.IsNullOrEmpty(incrementBy.Text))
		{
			if(int.TryParse(incrementBy.Text, out int increment_value))
			{
				incrementValue = increment_value;
			}
			else
			{
				OutputValue.Text = "Invalid input. Please enter a valid input.";
				return;
				
			}
		}
		else
		{
			incrementValue = 1;
			incrementBy.Text = $"{incrementValue}";
		}

		if(first_number > second_number)
		{
			OutputValue.Text = "First number must  less than second number.";
			return;
		}
		if(second_number < first_number)
		{
            OutputValue.Text = "Second number must greater than first number.";
            return;
        }
		for(int i = first_number + incrementValue; i<second_number; i += incrementValue)
		{
			output_number += $"{i} ";
		}
		OutputValue.Text = output_number;
	}
}


