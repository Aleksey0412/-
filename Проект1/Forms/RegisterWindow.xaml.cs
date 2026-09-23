using System;
using System.Windows;
using BlockchainConferenceApp.Data;
using BlockchainConferenceApp.Models;

namespace Проект1.Forms
{
    public partial class RegisterWindow : Window
    {
        public RegisterWindow()
        {
            InitializeComponent();
            cmbRole.ItemsSource = TestData.Roles;
            cmbRole.SelectedIndex = 0;
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Заполните все поля", "Ошибка",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            var parts = txtFullName.Text.Split(' ');
            var newUser = new User
            {
                IdNumber = TestData.Users.Count + 1000,
                FirstName = parts.Length > 0 ? parts[0] : "",
                LastName = parts.Length > 1 ? parts[1] : "",
                Patronymic = parts.Length > 2 ? parts[2] : "",
                Role = cmbRole.Text,
                Email = txtEmail.Text,
                Password = "123"
            };

            TestData.Users.Add(newUser);

            MessageBox.Show($"Пользователь зарегистрирован!\nID: {newUser.IdNumber}", "Успех",
                MessageBoxButton.OK, MessageBoxImage.Information);

            DialogResult = true;
            Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}