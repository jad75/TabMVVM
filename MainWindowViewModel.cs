using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace TabDemo
{
    public class MainWindowViewModel :INotifyPropertyChanged
    {
        public ObservableCollection<TabItem> Tabs { get; set; }
        private int _selectedTabIndex;

        public int SelectedTabIndex
        {
            get { return _selectedTabIndex; }
            set 
            { _selectedTabIndex = value;
                NotifyPropertyChanged();
            }
        }

     
        public MainWindowViewModel()
        {
            Tabs = new ObservableCollection<TabItem>();
            SelectedTabIndex = 1;
            Tabs.Add(new TabItem { Header = "One", Content = new FirstView() });
            Tabs.Add(new TabItem { Header = "Two", Content = "Two's content" });
            Tabs.Add(new TabItem { Header = "Three", Content = "Third's content" });
        }

        public event PropertyChangedEventHandler PropertyChanged;
        // This method is called by the Set accessor of each property.
        // The CallerMemberName attribute that is applied to the optional propertyName
        // parameter causes the property name of the caller to be substituted as an argument.
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
