

namespace _1003
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
        List<Class1> list = new List<Class1>()
        {
             new Class1(){Name = "Apple" , Image = "apple.png",Description = "This is an apple" },
             new Class1(){Name = "Orange" , Image = "Orange.png",Description = "This is an Orange" },
             new Class1(){Name = "Banana" , Image = "Banana.png",Description = "This is a Banana" },
             new Class1(){Name = "Kiwi" , Image = "Kiwi.png",Description = "This is a Kiwi" },
             new Class1(){Name = "Strawberry" , Image = "Strawberry.png",Description = "This is a Strawberry" },
             new Class1(){Name = "Pineapple" , Image = "Pineapple.png",Description = "This is a Pineapple" },
             new Class1(){Name = "Watermelon" , Image = "Watermelon.png",Description = "This is a Watermelon" },
             new Class1(){Name = "Grapes" , Image = "Grapes.png",Description = "This is a Grapes" },
        };
        InitializeComponent();
        FruitListView.ItemsSource = list;
      }
        private void FruitListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
            
        {

            if (e.SelectedItem == null)
                return;
            var selectedItem = e.SelectedItem as Class1;
            Navigation.PushAsync(new NewPage1(selectedItem.Name, selectedItem.Image, selectedItem.Description));
        }
    }
}