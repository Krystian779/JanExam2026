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

namespace JanuaryExam2026
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 



   

    //
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Robot robot1d = new HouseholdRobot("HouseHold Robot","I can help with chores around the house" ,25 , 0, Robot.HouseholdSkill.Cleaning);
            Robot robot2d = new HouseholdRobot("HouseHold Robot", "I can help with chores around the house", 25, 0, Robot.HouseholdSkill.Cleaning);
            Robot robot3d = new HouseholdRobot("HouseHold Robot", "I can help with chores around the house", 25, 0, Robot.HouseholdSkill.Cleaning);
            Robot robot4d = new DeliveryRobot("HouseHold Robot", "I can help with chores around the house", 25, 0, Robot.DeliveryMode.Walking);
            Robot robot5d = new DeliveryRobot("HouseHold Robot", "I can help with chores around the house", 25, 0, Robot.DeliveryMode.Driving);
            Robot robot6d = new DeliveryRobot("HouseHold Robot", "I can help with chores around the house", 25, 0, Robot.DeliveryMode.Flying);

            List<Robot> robotsDescription = new List<Robot>();
            robotsDescription.Add(robot1d);

            lbxRobots.ItemsSource = robotsDescription;


        }

        private void btnAddRobot_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}