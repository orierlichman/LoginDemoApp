﻿namespace LoginDemoApp.Models
{
    public class User
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public string Name { get; set; }

        public ICollection<Grade> UserGrades { get; set; } = new List<Grade>();
    }
}
