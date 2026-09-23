using System;
using System.Windows;
using BlockchainConferenceApp.Models;

namespace Проект1.Forms
{
    public partial class JuryWindow : Window
    {
        public JuryWindow(User user)
        {
            InitializeComponent();
            txtGreeting.Text = $"Здравствуйте, {user.LastName} {user.FirstName} {user.Patronymic}";
        }

        private void btnBack_Click(object sender, RoutedEventArgs e) => Close();
    }
}