using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.Models;
using System.Drawing;

namespace WinFormsApp1
{
    public partial class AddContactWindow : Form
    {
        public AddContactWindow()
        {
            InitializeComponent();
            LoadGroupsInComboBox();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Btn_AddContact_Click(object sender, EventArgs e)
        {

        }


        //fonctions custom

        private void LoadGroupsInComboBox()
        {
            //code to load groups in combobox
            this.CB_Groupe.Items.Clear();//Pas trop necessaire mais bon :)
            this.CB_Groupe.Items.Add("All Contacts");
            this.CB_Groupe.Items.AddRange(Global.ContactsGroups.ToArray());
            if (this.CB_Groupe.Items.Count > 0)
            {
                this.CB_Groupe.SelectedIndex = 0;
            }
        }

        private void Btn_AddContact_Click_1(object sender, EventArgs e)
        {
            string nom = TB_Name.Text;
            string prenom = TB_FirstName.Text;
            string email = TB_Email.Text;
            string phone = TB_Tel.Text;
            string adresse = TB_Adresse.Text;
            string ville = TB_City.Text;

            if (CheckInputs(nom, prenom, email, phone, adresse, ville) == false)
            {
                MessageBox.Show("Veuillez remplir tous les champs obligatoires.", "Contacts", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            if (CB_Groupe.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un groupe.");
                return;
            }

            if (PB_Contact_Photo.Image == null)
            {
                MessageBox.Show("Veuillez sélectionner une photo de contact.");
                return;
            }
            
            Image photo = PB_Contact_Photo.Image;
            
            Group group = (Group)CB_Groupe.SelectedItem;
            //  MessageBox.Show($"Contact ajouté :\nNom : {nom}\nPrénom : {prenom}\nEmail : {email}\nTéléphone : {phone}\nAdresse : {adresse}\nVille : {ville}\nGroupe : {group.Name}");

            Contact contact = new Contact()
            {

                FirstName = nom,
                LastName = prenom,
                PhoneNumber = phone,
                Email = email,
                Address = adresse,
                City = ville,
                Photo = photo,

            };

            
Global:
            group.ContactsList.Add(contact);
           // CB_Groupe.Items.Add(contact);

            //fermeture de la fenetre
            DialogResult = DialogResult.OK;

        }


        private bool CheckInputs(string nom, string prenom, string email, string phone, string adresse, string ville)
        {
            //code to check input
            return !string.IsNullOrEmpty(nom) &&
                !string.IsNullOrEmpty(prenom) &&
                !string.IsNullOrEmpty(email) &&
                !string.IsNullOrEmpty(phone) &&
                !string.IsNullOrEmpty(adresse) &&
                !string.IsNullOrEmpty(ville);

        }

        private void Btn_Choise_Image_Click(object sender, EventArgs e)
        {
            DialogResult result = OFD_ImageFile.ShowDialog();
            if (result == DialogResult.OK) {
                string filePath = OFD_ImageFile.FileName;
                Image image = Image.FromFile(filePath);
                PB_Contact_Photo.Image = image;
            }

        }

        private void AddContactWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
