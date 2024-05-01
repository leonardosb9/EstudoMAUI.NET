namespace FlayoutPageApp;

public partial class Page1 : ContentPage
{
	public Page1()
	{
		InitializeComponent();
	}

    private void Button_Clicked_GoToPage2(object sender, EventArgs e)
    {
		Navigation.PushAsync(new Page2());
    }
}