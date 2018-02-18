using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_PluralSight.Data_Bindings
{
   public class Person : BindableBase
    {
        private string _name;
        public string Name
        { get
            {
                return _name;
            }

            set
            {
                if(value !=  _name)
                {
                    _name = value;
                    RaisePropertyChanged("Name");
                }
            }

        }

        public Address Address { get; set; }

        public Person()
        {
            this.Address = new Address();
        }
    }
}
