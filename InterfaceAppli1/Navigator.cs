using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using InterfaceAppli1;
using System.Windows.Controls;

namespace InterfaceAppli1
{
    public class Navigator : INotifyPropertyChanged
    {
        public const string PART_ACCUEIL = "Accueil";
        public const string PART_MONCHEF = "MonChef";
        public const string PART_REGIONS = "Regions";
        public const string PART_VEGAN = "Vegan";
        public const string PART_TOP = "Top";
        public const string PART_FAVORIS = "Favoris";
        public ReadOnlyDictionary<string, Func<UserControl>> WindowParts { get; private set; }
        Dictionary<string, Func<UserControl>> windowParts { get; set; } = new Dictionary<string, Func<UserControl>>()
        {
            [PART_ACCUEIL] = () => new UCaccueil(),
            [PART_MONCHEF] = () => new MonChefUC(),
            [PART_REGIONS] = () => new RegionsUC(),
            [PART_VEGAN] = () => new VeganUC(),
            [PART_TOP] = () => new TopRecettesUC(),
            [PART_FAVORIS] = () => new FavoritsUC()

        };

        public Navigator()
        {
            WindowParts = new ReadOnlyDictionary<string, Func<UserControl>>(windowParts);
            SelectedUserControlCreator = WindowParts.First();
        }
        public KeyValuePair<string, Func<UserControl>> SelectedUserControlCreator
        {
            get => selectedUserControlCreator;
            set
            {
                if (selectedUserControlCreator.Equals(value)) return;
                selectedUserControlCreator = value;
                OnPropertyChanged();
            }
        }
        private KeyValuePair<string, Func<UserControl>> selectedUserControlCreator;

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string propertyName = "")
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public void NavigateTo(string windowPartName)
        {
            if (WindowParts.ContainsKey(windowPartName))
            {
                SelectedUserControlCreator = WindowParts.Single(kvp => kvp.Key == windowPartName);
            }
        }
    }
}
