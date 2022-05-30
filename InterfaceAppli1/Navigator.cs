using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace InterfaceAppli1
{
    public class Navigator : INotifyPropertyChanged
    {
        public ReadOnlyDictionary<string, Func<Page>> WindowParts { get; private set; }
        Dictionary<string, Func<Page>> windowParts { get; set; } = new Dictionary<string, Func<Page>>()
        {
            ["Regions"] = () => new Regions(),
            ["Vegan"] = () => new Vegan(),
            ["Top"] = () => new TopRecettes(),
            ["Favorits"] = () => new Favorits(),
            ["MonChef"] = () => new MonChef()
        };

        public Navigator()
        {
            WindowParts = new ReadOnlyDictionary<string, Func<Page>>(windowParts);
            SelectedPageCreator = WindowParts.First();
        }
        public KeyValuePair<string, Func<Page>> SelectedPageCreator
        {
            get => selectedPageCreator;
            set
            {
                if (selectedPageCreator.Equals(value)) return;
                selectedPageCreator = value;
            }
        }
        private KeyValuePair<string, Func<Page>> selectedPageCreator;

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string propertyName = "")
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
