using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FixmensApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Login : ContentPage
	{
		public Login ()
		{
			InitializeComponent ();
		    OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://www.fixmens.com.mx")));
        }
	    public ICommand OpenWebCommand { get; }
    }
}