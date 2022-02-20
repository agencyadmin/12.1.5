using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._1._5_;

public class User
{
    public string Login { get; set; }
    public string Name { get; set; }
    public string IsPremium { get; set; }
    public User(string Login, string Name, string IsPremium)
    {
        this.Login = Login;
        this.Name = Name;
        this.IsPremium = IsPremium;
    }
}

