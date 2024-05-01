namespace FlayoutPageApp;

public partial class Page3 : ContentPage
{
	public Page3()
	{
		InitializeComponent();
	}

    private void Button_Clicked_GoToPage2(object sender, EventArgs e)
    {
		Navigation.PopAsync();
    }
}