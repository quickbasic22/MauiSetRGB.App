namespace MauiSetRGB;

public partial class MainPage : ContentPage
{
	double Red;
	double Green;
	double Blue;
	public MainPage()
	{
		InitializeComponent();
		OnSliderValueChanged(redSlider, new ValueChangedEventArgs(0, 30));
        OnSliderValueChanged(greenSlider, new ValueChangedEventArgs(0, 255));
        OnSliderValueChanged(blueSlider, new ValueChangedEventArgs(0, 128));
    }

    private void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
	{
		if (sender == redSlider)
		{
            redLabel.Text = String.Format("Red = {0:X2} Hex; {0:F0} Dec", (int)redSlider.Value);
        }
		else if (sender == greenSlider)
		{
            greenLabel.Text = String.Format("Green = {0:X2} Hex; {0:F0} Dec", (int)greenSlider.Value);
        }
		else if (sender == blueSlider)
		{
            blueLabel.Text = String.Format("Blue = {0:X2} Hex; {0:F0} Dec", (int)blueSlider.Value);
        }

		boxView.Color = Color.FromRgb((int)redSlider.Value,
			                          (int)greenSlider.Value,
									  (int)blueSlider.Value);

        Red = redSlider.Value;
        Green = greenSlider.Value;
        Blue = blueSlider.Value;

    }

    private void Button_Clicked(object sender, EventArgs e)
	{

		if (redSlider.Value == Red)
		{
            redSlider.Value = Green;
            greenSlider.Value = Red;
            blueSlider.Value = Blue;
        }
		else if (greenSlider.Value == Red)
		{
            redSlider.Value = Blue;
            greenSlider.Value = Green;
            blueSlider.Value = Red;
        }
		else if (blueSlider.Value == Red)
		{
			redSlider.Value = Red;
            greenSlider.Value = Green;
            blueSlider.Value = Blue;
        }
    }
}

