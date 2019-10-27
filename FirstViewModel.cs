using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TabDemo 
{
    public class FirstViewModel
    {
       
        public ICommand OnLoadedTabCommand { get; set; }
        public FirstViewModel()
        {
            OnLoadedTabCommand = new RelayCommand(DoSimpleCommand);
        }

        /// <summary>
        /// The SimpleCommand function.
        /// </summary>
        private void DoSimpleCommand(object obj)
        {
            
        }

    }
}
