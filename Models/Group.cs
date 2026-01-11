using System;


namespace WinFormsApp1.Models
{
    public class Group
    {
        public string ? Name { get; set; }
        public List<Contact> ? ContactsList { get; set; }


        override public string ToString()
        {
            return Name ?? string.Empty;
        }
    }

    
}
