using System.Linq;
using System.Windows;
using BlockchainConferenceApp.Data;
using BlockchainConferenceApp.Models;

namespace Проект1.Forms
{
    public partial class MyActivitiesWindow : Window
    {
        private readonly User _moderator;

        public MyActivitiesWindow(User moderator)
        {
            InitializeComponent();
            _moderator = moderator;
            LoadActivities();
        }

        private void LoadActivities()
        {
            var activities = TestData.Activities.ToList();
            lbActivities.ItemsSource = activities;
        }

        private void btnBack_Click(object sender, RoutedEventArgs e) => Close();
    }
}