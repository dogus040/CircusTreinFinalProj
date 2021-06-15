﻿using System;
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
            train.Animals.Add(C5);
            train.Animals.Add(H3);
            fillTrain();
            //newListBox();
        }

        public void fillTrain()
        {
            train.spreadAnimals(wagon);
        }

        /*public void newListBox()
        {
            foreach (var wagon in train.Wagons)
            {
                Window w = new Window();
                w.Show();
            }
            lb.ItemsSource = wagon.Animals;
        } */
    }
}
