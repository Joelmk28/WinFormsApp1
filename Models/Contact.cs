using System;
using System.Drawing;


namespace WinFormsApp1.Models
{
    public class Contact
    {
        
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; }  = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public Image ? Photo { get; set; }


        override public string ToString()
        {
            return $"{FirstName} {LastName}";
        }

    }
}
