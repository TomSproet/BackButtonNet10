using BackNavigationTest.Models;
using BackNavigationTest.PageModels;

namespace BackNavigationTest.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}