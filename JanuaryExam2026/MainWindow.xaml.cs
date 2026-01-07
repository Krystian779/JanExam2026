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



    // Krystian Chmielak
    // S00271020
    // https://github.com/Krystian779/JanExam2026
    // Keith Mcmanus

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CreateRobots();

            


        }

        

        private void btnAddRobot_Click(object sender, RoutedEventArgs e)
        {

        }

        public void CreateRobots()
        {
            // Didnt realise robotname and robot type were differant until too late
            Robot robot1d = new HouseholdRobot("HouseHold Robot", "I can help with chores around the house", 25, 0, Robot.HouseholdSkill.Cleaning);
            Robot robot2d = new HouseholdRobot("HouseHold Robot", "I can help with chores around the house", 25, 0, Robot.HouseholdSkill.Cleaning);
            Robot robot3d = new HouseholdRobot("HouseHold Robot", "I can help with chores around the house", 25, 0, Robot.HouseholdSkill.Cleaning);
            Robot robot4d = new DeliveryRobot("Delivery Robot", "I specialize in delivery",100, 25, 0, Robot.DeliveryMode.Walking);
            Robot robot5d = new DeliveryRobot("Delivery Robot", "I specialize in delivery",150, 25, 0, Robot.DeliveryMode.Driving);
            Robot robot6d = new DeliveryRobot("Delivery Robot", "I specialize in delivery",160, 25, 0, Robot.DeliveryMode.Flying);

            List<Robot> robotsDescription = new List<Robot>();
            robotsDescription.Add(robot1d);
            robotsDescription.Add(robot2d);
            robotsDescription.Add(robot3d);
            robotsDescription.Add(robot4d);
            robotsDescription.Add(robot5d);
            robotsDescription.Add(robot6d);

            lbxRobots.ItemsSource = robotsDescription;
        }

        private void lbxRobots_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            // determine which robot is selected

            Robot selectedRobot = lbxRobots.SelectedItem as Robot;

            // check its not null
            if (selectedRobot != null)
            {
                // display robot description in the robot textbox

                tbxDetails.ItemsSource = null;
                tbxDetails.ItemsSource = selectedRobot.robots;


            }
        }
    }
}