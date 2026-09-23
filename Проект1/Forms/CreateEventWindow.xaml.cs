using BlockchainConferenceApp.Data;
using BlockchainConferenceApp.Models;
using System;
using System.Windows;
using System.Xml.Linq;

namespace Проект1.Forms
{
    public partial class CreateEventWindow : Window
    {
        public CreateEventWindow()
        {
            InitializeComponent();

            // Заполняем ComboBox
            cmbDirection.ItemsSource = TestData.Directions;
            cmbDirection.SelectedIndex = 0;

            cmbCity.ItemsSource = TestData.Cities;
            cmbCity.SelectedIndex = 0;

            dpStart.SelectedDate = DateTime.Today;
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            // Проверка названия
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Введите название мероприятия", "Ошибка",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                txtName.Focus();
                return;
            }

            // Создаём новое мероприятие
            var newEvent = new Event
            {
                EventId = TestData.Events.Count + 1,
                EventName = txtName.Text,
                Direction = cmbDirection.Text,
                City = cmbCity.Text,
                StartDateTime = dpStart.SelectedDate.Value.Date.AddHours(9),
                EndDateTime = dpStart.SelectedDate.Value.Date.AddHours(18),
                OrganizerId = 1000
            };

            // Добавляем в список
            TestData.Events.Add(newEvent);

            MessageBox.Show($"Мероприятие \"{newEvent.EventName}\" создано!", "Успех",
                MessageBoxButton.OK, MessageBoxImage.Information);

            // Добавляем активности (для примера)
            TestData.Activities.Add(new Activity
            {
                ActivityId = TestData.Activities.Count + 1,
                EventId = newEvent.EventId,
                ActivityName = "Открытие",
                StartDateTime = newEvent.StartDateTime,
                EndDateTime = newEvent.StartDateTime.AddMinutes(90),
                JuryNames = ""
            });

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