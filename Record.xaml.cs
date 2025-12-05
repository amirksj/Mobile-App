namespace IngridDemo3;

public partial class Record : ContentPage
{
    FirebaseHelper firebaseHelper = new FirebaseHelper();
    protected async override void OnAppearing()
    {
        base.OnAppearing();
        displayRecord.ItemsSource = await firebaseHelper.GetAllBmiRecord();
    }
    //string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "BMIRecord.txt");
    public Record()
	{
		InitializeComponent();
        //displayRecord.Text = File.ReadAllText(fileName);
    }
}
