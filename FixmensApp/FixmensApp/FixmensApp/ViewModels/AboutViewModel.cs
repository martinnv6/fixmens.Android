using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace FixmensApp
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "Acerca de";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://www.fixmens.com.mx")));
        }

        public ICommand OpenWebCommand { get; }
    }
}