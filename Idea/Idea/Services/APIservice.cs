using Idea.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Idea.Services
{
    public class APIservice 
    {
        public async Task<bool> RegisterAsync(string Email, string Password, string ConfirmPassword)
        {
            bool Response = false;
          //  await Task.Run(() =>
           // {
                var client = new HttpClient();

                var model = new RegisterBindingModel
                {
                    Email = Email,
                    Password = Password,
                    ConfirmPassword = ConfirmPassword

                };
                var json = JsonConvert.SerializeObject(model);
                HttpContent content = new StringContent(json);
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                var response = client.PostAsync("https://localhost:44302/api/Account/Register", content);
            string mystring = response.GetAwaiter().GetResult().ToString();

                if (response.Result.IsSuccessStatusCode)
                {
                    Response = true;
                }

       //     });
            return Response;
            
        }
    }
}
