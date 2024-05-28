using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using VariablePartLibrary.Models;
using VariablePartLibrary.Services;

namespace DemoLibApp2012.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            DGPlants.ItemsSource = DBService.Instance.GetModelData<Plant>().ToList();
            CBPlantTypes.ItemsSource = DBService.Instance.GetModelData<PlantType>().ToList();
        }

        private void DGPlants_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var selectedPlant = DGPlants.SelectedItem as Plant;
            NavigationService.Navigate(new PlantPage(selectedPlant));
        }

        private void TBSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            Refresh();
        }

        private void CBPlantTypes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Refresh();
        }

        private void Refresh()
        {
            var searchText = TBSearch.Text.ToLower();
            var selectedType = CBPlantTypes.SelectedItem as PlantType;
            var plants = DBService.Instance.GetModelData<Plant>().ToList();

            if (string.IsNullOrWhiteSpace(searchText) == false)
                plants = plants.Where(x => x.Name.ToLower().Contains(searchText)).ToList();
            if (selectedType != null)
                plants = plants.Where(x => x.PlantTypeId == selectedType.Id).ToList();

            DGPlants.ItemsSource = plants.ToList();
        }
    }
}
