using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication4.Models
{
    public class Information
    {
     public List<Accounts> Accounts;

        public Information()
        {
            Accounts = new List<Accounts>();
            Accounts.Add(new Accounts { Id = 4, Name = "Huskar", Age = 6 });
            Accounts.Add(new Accounts { Id = 1, Name = "InVoker", Age = 8});
            Accounts.Add(new Accounts { Id = 3, Name = "QOP", Age = 9 });
            Accounts.Add(new Accounts { Id = 2, Name = "Necro", Age = 7 });
        }
    }
}