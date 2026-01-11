using System;
using System.Collections.Generic;
using System.Text;
using WinFormsApp1.Models;

namespace WinFormsApp1;

    public static class Global
    {
    public static List<Group> ContactsGroups = new List<Group>()
        {
            new Group()
            {
                Name = "Family",
                ContactsList = new List<Contact>()
                {
                    new Contact()
                    {
                        FirstName = "Sarah",
                        LastName = "Kirengo",
                        Email = "sarahmasikak@gmail.com"
                        },
                    new Contact() {
                        FirstName = "Noemie",
                        LastName = "Kirengo",
                        Email = "noemivangu@gmail.com   "
                        }



                }
             },

            new Group()
            {
                Name = "Friends",
                ContactsList = new List<Contact>()
                {
                    new Contact()
                    {
                        FirstName = "Claudien",
                        LastName = "Bakaly",
                        Email = "bakalyclaudien@gmail.com"
                    },
                    new Contact()
                    {
                        FirstName = "Gabriel",
                        LastName = "Kanyimbu",
                        Email = "mbgabriel@gmail.com"
                    },
                    new Contact()
                    {
                        FirstName = "Jonathan",
                        LastName = "Mutendi",
                        Email = "jonathamb@gmail.com"
                    }
                }
            },
            new Group()
            {
                Name = "Work",
                ContactsList = new List<Contact>()
                {
                    new Contact()
                    {
                        FirstName = "Mardoché",
                        LastName = "Ngatsau",
                        Email = "ndebongatsau@gmail.com"
                    },
                    new Contact()
                    {
                        FirstName = "Van",
                        LastName = "Patrice",
                        Email = "vanpatrice@gmail.com"
                    }
                }
            }

        };
     }

