namespace _1003;

public partial class NewPage1 : ContentPage
{
	public NewPage1(string fruitName,string fruitImage ,string fruitDescription)
	{
		InitializeComponent();
		showName.Text = fruitName;
		showImage.Source = fruitImage;
		showDescription.Text = fruitDescription;
	}
}