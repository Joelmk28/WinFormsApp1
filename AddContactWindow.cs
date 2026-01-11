using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
        }
    }
}
