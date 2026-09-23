namespace BlockchainConferenceApp.Models
{
    public class User
    {
        public int IdNumber { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public string PhotoPath { get; set; }

        // Свойство для полного ФИО 
        public string FullName => $"{LastName} {FirstName} {Patronymic}";
    }
}