namespace FlayoutPageApp;

public partial class Page2 : ContentPage
{
	public Page2()
	{
		InitializeComponent();
	}

    private void Button_Clicked_GoToPage3(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Page3());
    }

    private void Button_Clicked_GoToPage2(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}