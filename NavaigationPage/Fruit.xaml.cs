namespace NavaigationPage;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}

	internal class Fruit
	{
		public string Name { get; set; }
		public string Image { get; set; }
		public string Description { get; set; }
	}
}