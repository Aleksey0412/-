using System;
using System.Collections.Generic;
using BlockchainConferenceApp.Models;

namespace BlockchainConferenceApp.Data
{
    public static class TestData
    {
        // === Пользователи (все роли) ===
        public static List<User> Users = new List<User>
        {
            new User
            {
                IdNumber = 1000,
                Password = "123",
                Role = "Organizer",
                FirstName = "Иван",
                LastName = "Петров",
                Patronymic = "Сергеевич",
                Email = "petrov@test.com"
            },

            new User
            {
                IdNumber = 1001,
                Password = "123",
                Role = "Participant",
                FirstName = "Анна",
                LastName = "Сидорова",
                Patronymic = "Михайловна",
                Email = "sidorova@test.com"
            },

            new User
            {
                IdNumber = 1002,
                Password = "123",
                Role = "Moderator",
                FirstName = "Дмитрий",
                LastName = "Козлов",
                Patronymic = "Александрович",
                Email = "kozlov@test.com"
            },

            new User
            {
                IdNumber = 1003,
                Password = "123",
                Role = "Jury",
                FirstName = "Елена",
                LastName = "Новикова",
                Patronymic = "Ивановна",
                Email = "novikova@test.com"
            }
        };

        // === Мероприятия ===
        public static List<Event> Events = new List<Event>
        {
            new Event
            {
                EventId = 1,
                EventName = "Blockchain Summit 2026",
                Direction = "Блокчейн",
                City = "Москва",
                StartDateTime = new DateTime(2026, 10, 15, 9, 0, 0),
                EndDateTime = new DateTime(2026, 10, 15, 18, 0, 0),
                OrganizerId = 1000,
                Description = "Крупнейшая конференция по блокчейну"
            },

            new Event
            {
                EventId = 2,
                EventName = "AI Conference",
                Direction = "ИИ",
                City = "Санкт-Петербург",
                StartDateTime = new DateTime(2026, 11, 20, 10, 0, 0),
                EndDateTime = new DateTime(2026, 11, 20, 17, 0, 0),
                OrganizerId = 1000,
                Description = "Конференция по искусственному интеллекту"
            },

            new Event
            {
                EventId = 3,
                EventName = "CyberSecurity Forum",
                Direction = "Кибербезопасность",
                City = "Казань",
                StartDateTime = new DateTime(2026, 12, 5, 11, 0, 0),
                EndDateTime = new DateTime(2026, 12, 5, 16, 0, 0),
                OrganizerId = 1000,
                Description = "Форум по информационной безопасности"
            }
        };

        // === Активности ===
        public static List<Activity> Activities = new List<Activity>
        {
            new Activity
            {
                ActivityId = 1,
                EventId = 1,
                ActivityName = "Открытие конференции",
                StartDateTime = new DateTime(2026, 10, 15, 9, 0, 0),
                EndDateTime = new DateTime(2026, 10, 15, 10, 30, 0),
                JuryNames = "Новикова Е.И."
            },

            new Activity
            {
                ActivityId = 2,
                EventId = 1,
                ActivityName = "Панельная дискуссия",
                StartDateTime = new DateTime(2026, 10, 15, 10, 45, 0),
                EndDateTime = new DateTime(2026, 10, 15, 12, 15, 0),
                JuryNames = "Новикова Е.И., Петров И.С."
            },

            new Activity
            {
                ActivityId = 3,
                EventId = 2,
                ActivityName = "Ключевой доклад",
                StartDateTime = new DateTime(2026, 11, 20, 10, 0, 0),
                EndDateTime = new DateTime(2026, 11, 20, 11, 30, 0),
                JuryNames = "Козлов Д.А."
            }
        };

        // === Задачи (для Kanban) ===
        public static List<TaskItem> Tasks = new List<TaskItem>
        {
            new TaskItem
            {
                TaskId = 1,
                ActivityId = 1,
                Description = "Подготовить презентацию",
                UserName = "Сидорова А.М.",
                Status = "InProgress"
            },

            new TaskItem
            {
                TaskId = 2,
                ActivityId = 1,
                Description = "Написать отчёт",
                UserName = "Петров И.С.",
                Status = "New"
            }
        };

        // === Справочники (для ComboBox) ===
        public static List<string> Directions = new List<string>
        {
            "Блокчейн",
            "ИИ",
            "Кибербезопасность",
            "Веб-разработка",
            "Мобильные приложения"
        };

        public static List<string> Cities = new List<string>
        {
            "Москва",
            "Санкт-Петербург",
            "Казань",
            "Екатеринбург",
            "Новосибирск"
        };

        public static List<string> Genders = new List<string>
        {
            "М",
            "Ж"
        };

        public static List<string> Roles = new List<string>
        {
            "Participant",
            "Moderator",
            "Jury"
        };
    }
}