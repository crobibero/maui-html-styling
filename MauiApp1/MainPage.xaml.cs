namespace MauiApp1;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        var str = """
                    <strong>Bold Text</strong><br>
                    <em>italics</em><br>
                    <ul>
                      <li>Item 1</li>
                      <li>Item 2</li>
                    </ul>
                    """;

        Label1.Text = str;
        Label2.Text = str;
    }
}