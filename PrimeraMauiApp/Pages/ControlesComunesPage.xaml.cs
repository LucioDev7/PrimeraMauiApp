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
            "Piña",
            "Uvas",
            "Pera",
            "Cereza",
            "Kiwi",
            "Melón",
            "Sandía",
            "Papaya",
            "Melocotón",
            "Granada"
        };
        BindingContext = this;
    }
}