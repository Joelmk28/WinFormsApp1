using WinFormsApp1.Models;
namespace WinFormsApp1
{
    public partial class MyContacts : Form
    {
        public MyContacts()
        {
            InitializeComponent();
            LoadGroupsInComboBox();
            UpdateContactsList();

        }

        private void GroupBoxMesContatcs_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Contact contact = (Contact)LB_Contacts.SelectedItem;
            Group group = GetGroupOf(contact);
            if (group != null) {   
              DialogResult dialogResult = MessageBox.Show("Etes-vous sûr de vouloir supprimer ce contact ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    group.ContactsList.Remove(contact);
                    UpdateContactsList();
                }
            }

             }
        private void ShowAllContacts()
        {
            this.LB_Contacts.Items.Clear();
            foreach (Group group in Global.ContactsGroups)
            {
                this.LB_Contacts.Items.AddRange(group.ContactsList.ToArray());
            }
        }

        private void ShowContactsOf(Group group)
        {
            this.LB_Contacts.Items.Clear();
            this.LB_Contacts.Items.AddRange(group.ContactsList.ToArray());
        }

        // mettre a jour la liste de contact

        private void UpdateContactsList()
        {
            int SelectedIndex = this.CB_GroupeInMyContacts.SelectedIndex;
            if (SelectedIndex == 0)
            {
                ShowAllContacts();
            }
            else if (SelectedIndex > 0)
            {
                Group group = (Group)CB_GroupeInMyContacts.SelectedItem;
                ShowContactsOf(group);
            }
            if (this.LB_Contacts.Items.Count > 0)
            {
                this.LB_Contacts.SelectedIndex = 0;
            }
            else
            {
                ClearInfos();
            }

        }

        private void Btn_AddContact_Click(object sender, EventArgs e)
        {
            AddContactWindow addContactWindow = new AddContactWindow();

            DialogResult result = addContactWindow.ShowDialog();

            if (result == DialogResult.OK)
            {
                UpdateContactsList();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateContactsList();
        }

        private void LoadGroupsInComboBox()
        {
            //code to load groups in combobox
            this.CB_GroupeInMyContacts.Items.Clear();//Pas trop necessaire mais bon :)
            this.CB_GroupeInMyContacts.Items.Add("All Contacts");
            this.CB_GroupeInMyContacts.Items.AddRange(Global.ContactsGroups.ToArray());
            if (this.CB_GroupeInMyContacts.Items.Count > 0)
            {
                this.CB_GroupeInMyContacts.SelectedIndex = 0;
            }
        }


        private void ClearInfos()
        {
            this.LB_Name.Text = "";
            this.LB_Adress.Text = "";
            this.LB_Email.Text = "";
            this.LB_Tel.Text = "";
            this.LB_Groupe.Text = "";
            this.LB_Ville.Text = "";
            this.PB_Contact_Photo.Image = null;

        }


        private void ShowInfoOf(Contact contact)
        {
            ClearInfos();
            this.LB_Name.Text = contact.ToString();
            this.LB_Adress.Text = contact.Address;
            this.LB_Email.Text = contact.Email;
            this.LB_Tel.Text = contact.PhoneNumber;
            this.LB_Groupe.Text = GetGroupOf(contact).Name;
            this.LB_Ville.Text = contact.City;
            if (contact.Photo != null)
            {
                this.PB_Contact_Photo.Image = contact.Photo;
            }
            else
            {
                this.PB_Contact_Photo.Image = null; // assuming you have a default image in resources
            }
        }
        private void LB_Contacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Contact contact = (Contact)LB_Contacts.SelectedItem;
            if (contact != null)
            {
                ShowInfoOf(contact);
            }

        }

        private void PB_Contact_Photo_Click(object sender, EventArgs e)
        {

        }

        private void LB_Name_Click(object sender, EventArgs e)
        {

        }




        private Group GetGroupOf(Contact contact)
        {
           return Global.ContactsGroups.FirstOrDefault(g => g.ContactsList.Contains(contact));
        }
    }
}
