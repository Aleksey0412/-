using System.Linq;
using System.Windows;
using BlockchainConferenceApp.Data;
using BlockchainConferenceApp.Models;

namespace Проект1.Forms
{
    public partial class KanbanWindow : Window
    {
        private readonly int _eventId;

        public KanbanWindow(int eventId)
        {
            InitializeComponent();
            _eventId = eventId;
            LoadActivities();
        }

        private void LoadActivities()
        {
            var activities = TestData.Activities.Where(a => a.EventId == _eventId).ToList();
            lbActivities.ItemsSource = activities;
        }

        private void btnTasks_Click(object sender, RoutedEventArgs e)
        {
            if (lbActivities.SelectedItem is Activity activity)
            {
                var tasks = TestData.Tasks.Where(t => t.ActivityId == activity.ActivityId).ToList();
                string taskList = tasks.Count > 0
                    ? string.Join("\n", tasks.Select(t => $"• {t.Description} ({t.UserName})"))
                    : "Нет задач";

                MessageBox.Show($"Задачи активности \"{activity.ActivityName}\":\n\n{taskList}",
                    "Задачи", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e) => Close();
    }
}