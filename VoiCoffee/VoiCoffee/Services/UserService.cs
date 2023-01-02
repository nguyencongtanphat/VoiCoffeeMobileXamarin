using Firebase.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoiCoffee.Model;
using Firebase.Database.Query;
using Xamarin.Forms;

namespace VoiCoffee.Services
{
    public class UserService
    {
        FirebaseClient client;

        public UserService()
        {
            client = new FirebaseClient("https://coffeorderingapp-cef55-default-rtdb.asia-southeast1.firebasedatabase.app");

        }

        public async Task<bool> IsUserExists(string uname)
        {
            var user = (await client.Child("Users").OnceAsync<User>()).Where(u => u.Object.Username == uname).FirstOrDefault();
            return (user != null);
        }

        public async Task<int> RegisterUser(string Fullname, string Username, string Password, string Address, string Number)
        {
            if (Fullname == null || Username == null || Password == null || Address == null || Number == null) return 2;
            if (await IsUserExists(Username) == false)
            {
                await client.Child("Users")
                    .PostAsync(new User()
                    {
                        Fullname = Fullname,
                        Username = Username,
                        Password = Password,
                        Address = Address,
                        Phonenumber = Number
                    });
                return 0;
            }
            return 1;
        }

        public async Task<User> getUserInfo(string uname)
        {
            var user = (await client.Child("Users").OnceAsync<User>()).Where(u => u.Object.Username == uname).FirstOrDefault();
            return new User
            {
                Fullname = user.Object.Fullname,
                Username = user.Object.Username,
                Password = user.Object.Password,
                Address = user.Object.Address,
                Phonenumber = user.Object.Phonenumber,
            };
        }

        public async Task<bool> LoginUser(string uname, string passwd)
        {
            var user = (await client.Child("Users").OnceAsync<User>()).Where(u => u.Object.Username == uname).Where(u => u.Object.Password == passwd).FirstOrDefault();
            return (user != null);
        }
    }
}
