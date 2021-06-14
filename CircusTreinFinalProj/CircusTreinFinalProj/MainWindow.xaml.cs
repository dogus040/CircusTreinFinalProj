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
        Wagon wagon = new Wagon();

        Carnivore C5 = new Carnivore(AnimalSizeEnum.Large);
        Carnivore C3 = new Carnivore(AnimalSizeEnum.Medium);
        Carnivore C1 = new Carnivore(AnimalSizeEnum.Small);

        Herbivore H5 = new Herbivore(AnimalSizeEnum.Large);
        Herbivore H3 = new Herbivore(AnimalSizeEnum.Medium);
        Herbivore H1 = new Herbivore(AnimalSizeEnum.Small);
        public MainWindow()
        {
            InitializeComponent();
            fillTrain();
        }

        public void fillTrain()
        {
            if (wagon.doesAnimalFitIntoWagon(C5) == true && C5.isAnimalSafe(wagon.Animals) == true )
            {
                train.Animals.Add(C5);
            }
            if (wagon.doesAnimalFitIntoWagon(C3) == true && C3.isAnimalSafe(wagon.Animals) == true)
            {
                train.Animals.Add(C3);
            }
            if (wagon.doesAnimalFitIntoWagon(C1) == true && C1.isAnimalSafe(wagon.Animals) == true)
            {
                train.Animals.Add(C1);
            }
            lbAnimalsTotal.ItemsSource = wagon.Animals;
        }

        public void newListBox()
        {
            ListBox lb = new ListBox();
        }
    }
}
