namespace NavaigationPage;

public partial class FruitDetailed : ContentPage
{
	public FruitDetailed(string Name, string Image ,string Description)
	{
		InitializeComponent();
        fruitImg.Source = Image;
        fruitName.Text = Name;
        fruitDescription.Text = Description;
    }
}