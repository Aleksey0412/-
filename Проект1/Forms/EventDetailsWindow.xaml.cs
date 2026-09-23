using BlockchainConferenceApp.Models;
using System.Windows;
using System.Xml.Linq;

namespace Проект1.Forms
{
    public partial class EventDetailsWindow : Window
    {
        public EventDetailsWindow(Event ev)
        {
            InitializeComponent();
            txtName.Text = ev.EventName;
            txtDirection.Text = $"Направление: {ev.Direction}";
            txtCity.Text = $"Город: {ev.City}";
            txtDate.Text = $"Дата: {ev.StartDateTime:dd.MM.yyyy}";
            txtTime.Text = $"Время: {ev.StartDateTime:HH:mm} - {ev.EndDateTime:HH:mm}";
            txtDescription.Text = ev.Description;
        }

        private void btnBack_Click(object sender, RoutedEventArgs e) => Close();
    }
}