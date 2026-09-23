using System.Linq;
using System.Windows;
using BlockchainConferenceApp.Data;

namespace Проект1.Forms
{
    public partial class JuryModeratorsViewWindow : Window
    {
        public JuryModeratorsViewWindow()
        {
            InitializeComponent();
            LoadPeople();
        }

        private void LoadPeople()
        {
            var people = TestData.Users.Where(u => u.Role == "Jury" || u.Role == "Moderator").ToList();
            dgPeople.ItemsSource = people;
        }

        private void btnBack_Click(object sender, RoutedEventArgs e) => Close();
    }
}