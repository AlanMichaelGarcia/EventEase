using System.Collections.Generic;

namespace EventEase.Services
{
    public class UserSessionService
    {
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public bool IsRegistered => !string.IsNullOrEmpty(UserName) && !string.IsNullOrEmpty(Email);

        public List<string> AttendingEvents { get; set; } = new();

        public void Register(string name, string email)
        {
            UserName = name;
            Email = email;
        }

        public void AttendEvent(string eventTitle)
        {
            if (!AttendingEvents.Contains(eventTitle))
                AttendingEvents.Add(eventTitle);
        }
    }
}
