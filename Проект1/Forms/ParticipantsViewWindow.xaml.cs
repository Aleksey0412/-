using BlockchainConferenceApp.Data;
using System.Linq;
using System.Windows;
using Проект1.Forms;

namespace Проект1.Forms
{
    public partial class ParticipantsViewWindow : Window
    {
        public ParticipantsViewWindow()
        {
            InitializeComponent();
            LoadParticipants();
        }

        private void LoadParticipants()
        {
            var participants = TestData.Users.Where(u => u.Role == "Participant").ToList();
            dgParticipants.ItemsSource = participants;
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            var win = new RegisterWindow();
            if (win.ShowDialog() == true)
            {
                LoadParticipants();
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e) => Close();
    }
}