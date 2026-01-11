namespace WinFormsApp1
{
    public partial class MyContacts : Form
    {
        public MyContacts()
        {
            InitializeComponent();
            LoadGroupsInComboBox();
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

        private void Btn_AddContact_Click(object sender, EventArgs e)
        {
            AddContactWindow addContactWindow = new AddContactWindow();
            addContactWindow.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadGroupsInComboBox()
        {
            //code to load groups in combobox
            this.CB_GroupeInMyContacts.Items.Clear();//Pas trop necessaire mais bon :)
            this.CB_GroupeInMyContacts.Items.AddRange(Global.ContactsGroups.ToArray());
            if (this.CB_GroupeInMyContacts.Items.Count > 0)
            {
                this.CB_GroupeInMyContacts.SelectedIndex = 0;
            }
        }
    }
}
