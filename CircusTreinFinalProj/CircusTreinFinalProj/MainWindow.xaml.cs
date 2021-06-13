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

        Carnivore C5 = new Carnivore(AnimalSize.Large);
        Carnivore C3 = new Carnivore(AnimalSize.Medium);
        Carnivore C1 = new Carnivore(AnimalSize.Small);

        Herbivore H5 = new Herbivore(AnimalSize.Large);
        Herbivore H3 = new Herbivore(AnimalSize.Medium);
        Herbivore H1 = new Herbivore(AnimalSize.Small);
        public MainWindow()
        {
            InitializeComponent();
            fillTrain();
            lbAnimalsTotal.ItemsSource = train.Animals;
        }

        public void fillTrain()
        {
            train.Animals.Add(C5);
            train.Animals.Add(C3);
            train.Animals.Add(C1);
            train.Animals.Add(C5);
            train.Animals.Add(C5);
            train.Animals.Add(C5);
        }
    }
}
