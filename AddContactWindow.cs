using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.Models;

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

            if (CB_Groupe.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un groupe.");
                return;
            }

            Group group = (Group)CB_Groupe.SelectedItem;

            

            MessageBox.Show($"Contact ajouté :\nNom : {nom}\nPrénom : {prenom}\nEmail : {email}\nTéléphone : {phone}\nAdresse : {adresse}\nVille : {ville}\nGroupe : {group.Name}");




        }
    }
}
