using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Wpf_PluralSight.Data_Bindings
{
    public class BindableBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propertyname)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged.Invoke(this,
                    new PropertyChangedEventArgs(propertyname));
            }
        }
    }
}
