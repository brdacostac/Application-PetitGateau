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
        public const string PART_APROPOS = "Apropos";
        public const string PART_CONNEXION = "Connexion";
        public const string PART_INSCRIPTION = "Inscription";

        public const string PART_NORTE = "Norte";
        public const string PART_NORDESTE = "Nordeste";
        public const string PART_CENTRO_OESTE = "Centro-Oeste";
        public const string PART_SUDESTE = "Sudeste";
        public const string PART_SUL = "Sul";

        public const string PART_RECDETAILEE = "Detail";

        public ReadOnlyDictionary<string, Func<UserControl>> WindowParts { get; private set; }
        Dictionary<string, Func<UserControl>> windowParts { get; set; } = new Dictionary<string, Func<UserControl>>()
        {
            [PART_ACCUEIL] = () => new UCaccueil(),
            [PART_MONCHEF] = () => new MonChefUC(),
            [PART_REGIONS] = () => new RegionsUC(),
            [PART_VEGAN] = () => new VeganUC(),
            [PART_TOP] = () => new TopRecettesUC(),
            [PART_FAVORIS] = () => new FavoritsUC(),
            [PART_APROPOS] = () => new AproposUC(),
            [PART_CONNEXION] = () => new ConnexionUC(),
            [PART_INSCRIPTION] = () => new InscriptionUC(),

            [PART_NORTE] = () => new NorteUC(),
            [PART_NORDESTE] = () => new NordesteUC(),
            [PART_CENTRO_OESTE] = () => new CentroOesteUC(),
            [PART_SUDESTE] = () => new SudesteUC(),
            [PART_SUL] = () => new SulUC(),

            [PART_RECDETAILEE] = () => new UCrecDetailee()


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
