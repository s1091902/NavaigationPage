using System.ComponentModel;

namespace NavaigationPage
{
    public partial class MainPage : ContentPage
    {
       List<Fruitcs> list = new List<Fruitcs>() 
       { 
           new Fruitcs(){ Name="Apple",Image="apple.png"},
           new Fruitcs(){ Name="Banana",Image="banana.png"},
           new Fruitcs(){ Name="Grape",Image="grape.png"},
           new Fruitcs(){ Name="Kiwi",Image="kiwi.png"},
           new Fruitcs(){ Name="Orange",Image="orange.png"},
           new Fruitcs(){ Name="Pinaapple",Image="pinaapple.png"},
           new Fruitcs(){ Name="Strawberry",Image="strawberry.png"},
           new Fruitcs(){ Name="Watermalon",Image="watermalon.png"}
       };

       public MainPage()
        {
            InitializeComponent();
            FruitListView.ItemsSource = list;
        }

        private void FruitListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            { return; }
            var selectedItem = e.SelectedItem as Fruitcs;
            Navigation.PushAsync(new FruitDetailed(selectedItem.Name, selectedItem.Image, selectedItem.Description));
        }


    }
}