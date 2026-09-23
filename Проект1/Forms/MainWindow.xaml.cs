using System;
using System.Linq;
using System.Windows;
using BlockchainConferenceApp.Data;
using BlockchainConferenceApp.Models;
using Проект1.Forms;

namespace Проект1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            // Заполняем ComboBox направлениями
            cmbDirection.ItemsSource = TestData.Directions;
            cmbDirection.SelectedIndex = -1;

            // Показываем все мероприятия
            dgEvents.ItemsSource = TestData.Events;
        }

        private void btnFilter_Click(object sender, RoutedEventArgs e)
        {
            var filtered = TestData.Events.AsEnumerable();

            // Фильтр по направлению
            if (cmbDirection.SelectedItem != null)
            {
                string dir = cmbDirection.SelectedItem.ToString();
                filtered = filtered.Where(ev => ev.Direction == dir);
            }

            // Фильтр по дате
            if (dpDate.SelectedDate.HasValue)
            {
                DateTime date = dpDate.SelectedDate.Value.Date;
                filtered = filtered.Where(ev => ev.StartDateTime.Date == date);
            }

            dgEvents.ItemsSource = filtered.ToList();
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            cmbDirection.SelectedIndex = -1;
            dpDate.SelectedDate = null;
            dgEvents.ItemsSource = TestData.Events;
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            var loginForm = new LoginForm();

            if (loginForm.ShowDialog() == true)
            {
                OpenRoleWindow(loginForm.CurrentUser);
            }
        }

        private void btnDetails_Click(object sender, RoutedEventArgs e)
        {
            if (dgEvents.SelectedItem is Event ev)
            {
                MessageBox.Show(
                    $"Мероприятие: {ev.EventName}\n" +
                    $"Направление: {ev.Direction}\n" +
                    $"Город: {ev.City}\n" +
                    $"Дата: {ev.StartDateTime:dd.MM.yyyy}\n" +
                    $"Время: {ev.StartDateTime:HH:mm} - {ev.EndDateTime:HH:mm}\n" +
                    $"Описание: {ev.Description}",
                    "Информация о мероприятии",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Выберите мероприятие в таблице", "Внимание",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void OpenRoleWindow(User user)
        {
            Window win = user.Role switch
            {
                "Organizer" => new OrganizerWindow(user),
                "Moderator" => new ModeratorWindow(user),
                "Participant" => new ParticipantWindow(user),
                "Jury" => new JuryWindow(user),
                _ => null
            };

            win?.ShowDialog();
        }
    }
}