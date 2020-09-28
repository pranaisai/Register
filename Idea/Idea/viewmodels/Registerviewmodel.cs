using Android.OS;
using Android.Views;
using Idea.Services;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.TizenSpecific;
using static Android.App.Notification.MessagingStyle;
using System.Threading.Tasks;

namespace Idea.viewmodels
{
    public class Registerviewmodel
    {


        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        
    }
 
}
