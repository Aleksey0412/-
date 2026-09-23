using BlockchainConferenceApp.Data;
using BlockchainConferenceApp.Models;
using System;
using System.Linq;
using System.Windows;
using Проект1;
using Проект1.Forms;

namespace Проект1.Forms
{
    public partial class OrganizerWindow : Window
    {
        private readonly User _organizer;

        public OrganizerWindow(User user)
        {
            InitializeComponent();
            _organizer = user;
            InitializeWindow();
        }

        private void InitializeWindow()
        {
            // Приветствие
            txtGreeting.Text = $"Здравствуйте, {_organizer.LastName} {_organizer.FirstName} {_organizer.Patronymic}";

            // Время работы
            int h = DateTime.Now.Hour;
            txtTime.Text = h >= 9 && h <= 11 ? "Утро (9:00-11:00)" :
                         h >= 11 && h <= 18 ? "День (11:01-18:00)" : "Вечер (18:01-24:00)";
        }

        private void btnCreateEvent_Click(object sender, RoutedEventArgs e)
        {
            var win = new CreateEventWindow();
            win.ShowDialog();
        }

        private void btnEvents_Click(object sender, RoutedEventArgs e)
        {
            // Возвращаемся на главный экран со списком мероприятий
            var mainWin = new MainWindow();
            mainWin.Show();
            Close();
        }

        private void btnKanban_Click(object sender, RoutedEventArgs e)
        {
            // Выбираем первое мероприятие для примера
            if (TestData.Events.Count > 0)
            {
                var win = new KanbanWindow(TestData.Events[0].EventId);
                win.ShowDialog();
            }
            else
            {
                MessageBox.Show("Сначала создайте мероприятие", "Внимание",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void btnParticipants_Click(object sender, RoutedEventArgs e)
        {
            var win = new ParticipantsViewWindow();
            win.ShowDialog();
        }

        private void btnJuryModerators_Click(object sender, RoutedEventArgs e)
        {
            var win = new JuryModeratorsViewWindow();
            win.ShowDialog();
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            var win = new RegisterWindow();
            win.ShowDialog();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}