namespace APPNumeroDaSorte;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void GenerateLuckyNumber(object sender, EventArgs e)
    {
		LabelTitle.IsVisible = false;
		VerticalStackLayoutShowLuckyNumber.IsVisible = true;

		var numbers = GenerateNumbers().OrderBy(x => x).ToList();

		LabelNumber01.Text = numbers[0].ToString("D2");
		LabelNumber02.Text = numbers[1].ToString("D2");
		LabelNumber03.Text = numbers[2].ToString("D2");
		LabelNumber04.Text = numbers[3].ToString("D2");
		LabelNumber05.Text = numbers[4].ToString("D2");
		LabelNumber06.Text = numbers[5].ToString("D2");
    }

	private List<int> GenerateNumbers()
	{
		var numbers = new List<int>();

		while (numbers.Count <= 6)
		{
			var random = new Random();

			var number = random.Next(1, 60);

			if (!numbers.Any(x => x == number))
			{
				numbers.Add(number);
			}
		}

		return numbers;

	}
}