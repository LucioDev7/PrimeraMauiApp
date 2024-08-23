using System.Collections.ObjectModel;

namespace PrimeraMauiApp.Pages;

public partial class ControlesComunesPage : ContentPage
{
    public ObservableCollection<string> Fruits { get; set; } = new ObservableCollection<string>();
    public ControlesComunesPage()
	{
		InitializeComponent();
        Fruits = new ObservableCollection<string>
        {
            "Manzana",
            "Banana",
            "Naranja",
            "Fresa",
            "Mango",
            "Pi�a",
            "Uvas",
            "Pera",
            "Cereza",
            "Kiwi",
            "Mel�n",
            "Sand�a",
            "Papaya",
            "Melocot�n",
            "Granada"
        };
        BindingContext = this;
    }
}