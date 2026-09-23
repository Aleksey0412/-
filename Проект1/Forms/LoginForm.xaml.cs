using System;
using System.Linq;
using System.Windows;
using BlockchainConferenceApp.Data;
using BlockchainConferenceApp.Models;

namespace Проект1.Forms
{
    public partial class LoginForm : Window
    {
        private string captcha;
        public User CurrentUser { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
            GenerateCaptcha();
        }

        private void GenerateCaptcha()
        {
            var rand = new Random();
            string chars = "ABCDEFGHJKLMNPQRSTUVWXYZ23456789";
            captcha = "";
            for (int i = 0; i < 4; i++)
                captcha += chars[rand.Next(chars.Length)];

            txtCaptcha.Text = captcha;
            txtCaptchaInput.Clear();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (txtCaptchaInput.Text.ToUpper() != captcha)
            {
                MessageBox.Show("Неверный код CAPTCHA", "Ошибка",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                GenerateCaptcha();
                return;
            }

            if (int.TryParse(txtIdNumber.Text, out int id))
            {
                User user = TestData.Users.FirstOrDefault(u => u.IdNumber == id && u.Password == txtPassword.Password);

                if (user != null)
                {
                    CurrentUser = user;
                    DialogResult = true;
                    Close();
                    return;
                }
            }

            MessageBox.Show("Неверный Id Number или пароль", "Ошибка",
                MessageBoxButton.OK, MessageBoxImage.Error);
            txtPassword.Password = "";
            GenerateCaptcha();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}