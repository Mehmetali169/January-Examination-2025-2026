using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace January_Examination_2025_2026
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Robot> allRobots = new List<Robot>();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void CreateRobot()
        {
            Robot HouseBot = new Robot()
            {
                robotName = "Housebot 01 - HouseHoldRobot",
                
            };
            Robot GardenMate = new Robot()
            {
                robotName = "GardenMate - HouseHoldRobot",
                Skills = HouseholdSkill.Gardening
                // could add the skills here but not the Quetion 
            };
            Robot HouseMate = new Robot()
            {
                robotName = "HouseMate 3000 - HouseHoldRobot",
            };
            Robot DeliveryBot = new Robot()
            {
                robotName = "DeliveryBot - DeliveryRotot",
            };
            Robot FlyBot = new Robot()
            {
                robotName = "FlyBot - DeliveryBot",
            };
            Robot Driver = new Robot()
            {
                robotName = "Driver - DeliveryBot",
            };
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CreateRobot();
        }
    }
}