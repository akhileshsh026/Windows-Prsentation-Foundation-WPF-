using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_PluralSight.Data_Bindings
{
   public class Person
    {
        public string Name { get; set; }
        public Address Address { get; set; }

        public Person()
        {
            this.Address = new Address();
        }
    }
}
