using Idea.Services;
using Java.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Idea.viewmodels.view
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        APIservice _aPIservice = new APIservice();
        public RegisterPage()
        {
            InitializeComponent();
        }
        private async void Register_Clicked(object sender, EventArgs e)
        {
            bool response = await _aPIservice.RegisterAsync(Email.Text, Pass.Text, confirm.Text);

                if (response)
            {
                
                await DisplayAlert("Alert", "Registration OK", "ok");

            }
                else
            {
                await DisplayAlert("Alert", "Registration Fail", "ok");
            }
        }
    }
}