namespace MauiApp1;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        Label1.Text = """
                      <strong>Bold Text</strong><br>
                      <em>italics</em><br>
                      <ul>
                        <li>Item 1</li>
                        <li>Item 2</li>
                      </ul>
                      """;
    }
}