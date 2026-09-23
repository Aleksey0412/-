using System;
using System.Windows;
using BlockchainConferenceApp.Models;

namespace Проект1.Forms
{
    public partial class OrganizerWindow : Window
    {
        public OrganizerWindow(User user)
        {
            InitializeComponent();
            txtGreeting.Text = $"Здравствуйте, {user.LastName} {user.FirstName} {user.Patronymic}";

            int h = DateTime.Now.Hour;
            txtTime.Text = h >= 9 && h <= 11 ? "Утро (9:00-11:00)" :
                          h >= 11 && h <= 18 ? "День (11:01-18:00)" : "Вечер (18:01-24:00)";
        }

        private void btnBack_Click(object sender, RoutedEventArgs e) => Close();
    }
}