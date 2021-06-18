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

namespace CircusTreinFinalProj
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Train train = new Train();

        List<Animal> animals = new List<Animal>()
                {
                    new Carnivore(AnimalSizeEnum.Small), new Carnivore(AnimalSizeEnum.Medium), new Carnivore(AnimalSizeEnum.Medium),
                    new Carnivore(AnimalSizeEnum.Medium), new Carnivore(AnimalSizeEnum.Medium), new Carnivore(AnimalSizeEnum.Medium),
                    new Carnivore(AnimalSizeEnum.Large), new Herbivore(AnimalSizeEnum.Large), new Herbivore(AnimalSizeEnum.Large),
                    new Herbivore(AnimalSizeEnum.Large), new Herbivore(AnimalSizeEnum.Large), new Herbivore(AnimalSizeEnum.Large),
                    new Herbivore(AnimalSizeEnum.Medium), new Herbivore(AnimalSizeEnum.Medium), new Herbivore(AnimalSizeEnum.Small),
                    new Herbivore(AnimalSizeEnum.Small)
                };

        public MainWindow()
        {
            InitializeComponent();

            foreach (Animal animal in animals)
            {
                train.Animals.Add(animal);
            }

            train.spreadAnimals();
            newListBox();
        }

        public void newListBox()
        {
            StackPanel sp = new StackPanel() { Orientation = Orientation.Horizontal};
            foreach (Wagon wagon in train.Wagons)
            {
                ListBox lb = new ListBox()
                {
                    ItemsSource = wagon.Animals,
                    Background = Brushes.Red
                };
                sp.Children.Add(lb);
            }
            gridLayout.Children.Add(sp);
        }
    }
}
