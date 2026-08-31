using BackNavigationTest.Models;
using BackNavigationTest.PageModels;

namespace BackNavigationTest.Pages
{
    public partial class MainPageNoShell : ContentPage
    {
        public MainPageNoShell()
        {
            InitializeComponent();
            var btn = new Button
            {
                Text = "Go to Page 1",
                Command = new Command(async () =>
                {
                    Application.Current.Windows[0].Page = new AppShell();
                })
            };
            var stckl = new StackLayout()
            {
                Orientation = StackOrientation.Vertical,
            };
            stckl.Children.Add(btn);
            Content = stckl;
        }

    }
}