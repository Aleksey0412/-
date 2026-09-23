using System;
using System.Windows;
using BlockchainConferenceApp.Models;

namespace Проект1.Forms
{
    public partial class ModeratorWindow : Window
    {
        public ModeratorWindow(User user)
        {
            InitializeComponent();
            txtGreeting.Text = $"Здравствуйте, {user.LastName} {user.FirstName} {user.Patronymic}";
        }

        private void btnBack_Click(object sender, RoutedEventArgs e) => Close();
    }
}