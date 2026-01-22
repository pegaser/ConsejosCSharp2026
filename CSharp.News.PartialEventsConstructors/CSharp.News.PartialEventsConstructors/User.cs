using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.News.PartialEventsConstructors
{
    internal partial class User
    {
        public partial event Action UserLoggedIn;

        public string Name;
        public User()
        {
            Name = "Usuario sin nombre";
            OnUserCreated();
        }
        partial void OnUserCreated();

        public void Login()
        {
            Console.WriteLine("Usuario inició sesión");
            UserLoggedIn?.Invoke();
        }
    }
}
