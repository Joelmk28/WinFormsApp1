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
            if (SelectedIndex == 0) {
                ShowAllContacts();
            }
            else if (SelectedIndex > 0) {
                Group group = (Group) CB_GroupeInMyContacts.SelectedItem;
                ShowContactsOf(group);
            }

        }

        private void Btn_AddContact_Click(object sender, EventArgs e)
        {
            AddContactWindow addContactWindow = new AddContactWindow();
        
            DialogResult result = addContactWindow.ShowDialog();

            if (result == DialogResult.OK) {
                UpdateContactsList();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
    }
}
