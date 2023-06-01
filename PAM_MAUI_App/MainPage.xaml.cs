namespace PAM_MAUI_App;

public partial class MainPage : ContentPage
{
	int count = 0;
	string nome = "Alex";

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

        CTexto.Text = $"Olá {nome}!!!";

        SemanticScreenReader.Announce(CounterBtn.Text);
        SemanticScreenReader.Announce(CTexto.Text);
    }
}

