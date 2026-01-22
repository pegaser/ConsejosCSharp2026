using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.News.PartialEventsConstructors
{
    internal partial class User
    {
        partial void OnUserCreated()
        {
            Console.WriteLine("Usuario creado correctamente");
        }
    }
}
