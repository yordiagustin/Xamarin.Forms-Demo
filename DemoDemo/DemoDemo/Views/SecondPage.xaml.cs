using DemoDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoDemo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SecondPage : ContentPage
    {
        private SecondViewModel viewModel;
        public SecondPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new SecondViewModel();
        }
    }
}