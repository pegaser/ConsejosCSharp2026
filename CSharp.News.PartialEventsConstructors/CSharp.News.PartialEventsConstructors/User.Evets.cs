using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.News.PartialEventsConstructors
{
    internal partial class User
    {
        public partial event Action UserLoggedIn
        {
            add
            {
                Console.WriteLine("Suscripción al evento de inicio de sesión");
            }
            remove
            {
                Console.WriteLine("Cancelación de suscripción al evento");
            }
        }
    }
}
