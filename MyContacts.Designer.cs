namespace WinFormsApp1
{
    partial class MyContacts
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PNL_Left = new Panel();
            Group_Search = new GroupBox();
            TB_Search = new TextBox();
            Btn_AddContact = new Button();
            GroupBoxMesContatcs = new GroupBox();
            LB_Contacts = new ListBox();
            comboBox1 = new ComboBox();
            button2 = new Button();
            button1 = new Button();
            PNL_Right = new Panel();
            LB_Ville = new Label();
            LB_Adress = new Label();
            LB_Tel = new Label();
            label3 = new Label();
            Label5 = new Label();
            Label4 = new Label();
            LB_Email = new Label();
            Email = new Label();
            LB_Name = new Label();
            LB_Groupe = new Label();
            PB_Contact_Photo = new PictureBox();
            Btn_DeleteImage = new Button();
            PNL_Left.SuspendLayout();
            Group_Search.SuspendLayout();
            GroupBoxMesContatcs.SuspendLayout();
            PNL_Right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PB_Contact_Photo).BeginInit();
            SuspendLayout();
            // 
            // PNL_Left
            // 
            PNL_Left.Controls.Add(Group_Search);
            PNL_Left.Controls.Add(Btn_AddContact);
            PNL_Left.Controls.Add(GroupBoxMesContatcs);
            PNL_Left.Controls.Add(button2);
            PNL_Left.Controls.Add(button1);
            PNL_Left.Location = new Point(5, 2);
            PNL_Left.Name = "PNL_Left";
            PNL_Left.Size = new Size(307, 447);
            PNL_Left.TabIndex = 0;
            // 
            // Group_Search
            // 
            Group_Search.Controls.Add(TB_Search);
            Group_Search.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Group_Search.Location = new Point(4, 349);
            Group_Search.Name = "Group_Search";
            Group_Search.Size = new Size(295, 95);
            Group_Search.TabIndex = 4;
            Group_Search.TabStop = false;
            Group_Search.Text = "Rechercher";
            // 
            // TB_Search
            // 
            TB_Search.Location = new Point(6, 45);
            TB_Search.Name = "TB_Search";
            TB_Search.Size = new Size(283, 39);
            TB_Search.TabIndex = 0;
            // 
            // Btn_AddContact
            // 
            Btn_AddContact.Location = new Point(0, 309);
            Btn_AddContact.Name = "Btn_AddContact";
            Btn_AddContact.Size = new Size(298, 34);
            Btn_AddContact.TabIndex = 3;
            Btn_AddContact.Text = "Ajouter";
            Btn_AddContact.UseVisualStyleBackColor = true;
            // 
            // GroupBoxMesContatcs
            // 
            GroupBoxMesContatcs.Controls.Add(LB_Contacts);
            GroupBoxMesContatcs.Controls.Add(comboBox1);
            GroupBoxMesContatcs.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GroupBoxMesContatcs.Location = new Point(0, 10);
            GroupBoxMesContatcs.Name = "GroupBoxMesContatcs";
            GroupBoxMesContatcs.Size = new Size(304, 284);
            GroupBoxMesContatcs.TabIndex = 2;
            GroupBoxMesContatcs.TabStop = false;
            GroupBoxMesContatcs.Text = "Mes contacts";
            GroupBoxMesContatcs.Enter += GroupBoxMesContatcs_Enter;
            // 
            // LB_Contacts
            // 
            LB_Contacts.FormattingEnabled = true;
            LB_Contacts.Location = new Point(0, 110);
            LB_Contacts.Name = "LB_Contacts";
            LB_Contacts.Size = new Size(298, 164);
            LB_Contacts.Sorted = true;
            LB_Contacts.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(6, 54);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(293, 40);
            comboBox1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(81, 156);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(65, 60);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // PNL_Right
            // 
            PNL_Right.Controls.Add(Btn_DeleteImage);
            PNL_Right.Controls.Add(LB_Ville);
            PNL_Right.Controls.Add(LB_Adress);
            PNL_Right.Controls.Add(LB_Tel);
            PNL_Right.Controls.Add(label3);
            PNL_Right.Controls.Add(Label5);
            PNL_Right.Controls.Add(Label4);
            PNL_Right.Controls.Add(LB_Email);
            PNL_Right.Controls.Add(Email);
            PNL_Right.Controls.Add(LB_Name);
            PNL_Right.Controls.Add(LB_Groupe);
            PNL_Right.Controls.Add(PB_Contact_Photo);
            PNL_Right.Location = new Point(318, 2);
            PNL_Right.Name = "PNL_Right";
            PNL_Right.Size = new Size(470, 444);
            PNL_Right.TabIndex = 1;
            // 
            // LB_Ville
            // 
            LB_Ville.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LB_Ville.Location = new Point(106, 402);
            LB_Ville.Name = "LB_Ville";
            LB_Ville.Size = new Size(333, 32);
            LB_Ville.TabIndex = 10;
            LB_Ville.Text = "Kinshasa";
            LB_Ville.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LB_Adress
            // 
            LB_Adress.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LB_Adress.Location = new Point(106, 364);
            LB_Adress.Name = "LB_Adress";
            LB_Adress.Size = new Size(333, 32);
            LB_Adress.TabIndex = 9;
            LB_Adress.Text = "Kinsuka Ngaliema";
            LB_Adress.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LB_Tel
            // 
            LB_Tel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LB_Tel.Location = new Point(106, 324);
            LB_Tel.Name = "LB_Tel";
            LB_Tel.Size = new Size(333, 32);
            LB_Tel.TabIndex = 8;
            LB_Tel.Text = "0xxxxxxxxx";
            LB_Tel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 403);
            label3.Name = "label3";
            label3.Size = new Size(76, 23);
            label3.TabIndex = 7;
            label3.Text = "Ville :";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label5
            // 
            Label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label5.Location = new Point(3, 364);
            Label5.Name = "Label5";
            Label5.Size = new Size(95, 32);
            Label5.TabIndex = 6;
            Label5.Text = "Adresse :";
            Label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label4
            // 
            Label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label4.Location = new Point(24, 324);
            Label4.Name = "Label4";
            Label4.Size = new Size(76, 23);
            Label4.TabIndex = 5;
            Label4.Text = "Tél :";
            Label4.TextAlign = ContentAlignment.MiddleRight;
            Label4.Click += label1_Click_1;
            // 
            // LB_Email
            // 
            LB_Email.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LB_Email.Location = new Point(106, 280);
            LB_Email.Name = "LB_Email";
            LB_Email.Size = new Size(333, 32);
            LB_Email.TabIndex = 4;
            LB_Email.Text = "joelmuhindok@gmail.com";
            LB_Email.TextAlign = ContentAlignment.MiddleLeft;
            LB_Email.Click += label1_Click;
            // 
            // Email
            // 
            Email.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Email.Location = new Point(24, 284);
            Email.Name = "Email";
            Email.Size = new Size(76, 23);
            Email.TabIndex = 3;
            Email.Text = "Email :";
            Email.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LB_Name
            // 
            LB_Name.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LB_Name.Location = new Point(12, 246);
            LB_Name.Name = "LB_Name";
            LB_Name.Size = new Size(458, 38);
            LB_Name.TabIndex = 2;
            LB_Name.Text = "Prénom Nom";
            LB_Name.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LB_Groupe
            // 
            LB_Groupe.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LB_Groupe.Location = new Point(274, 207);
            LB_Groupe.Name = "LB_Groupe";
            LB_Groupe.Size = new Size(184, 38);
            LB_Groupe.TabIndex = 1;
            LB_Groupe.Text = "Groupe";
            LB_Groupe.TextAlign = ContentAlignment.MiddleRight;
            // 
            // PB_Contact_Photo
            // 
            PB_Contact_Photo.BorderStyle = BorderStyle.FixedSingle;
            PB_Contact_Photo.Location = new Point(12, 16);
            PB_Contact_Photo.Name = "PB_Contact_Photo";
            PB_Contact_Photo.Size = new Size(446, 229);
            PB_Contact_Photo.SizeMode = PictureBoxSizeMode.CenterImage;
            PB_Contact_Photo.TabIndex = 0;
            PB_Contact_Photo.TabStop = false;
            // 
            // Btn_DeleteImage
            // 
            Btn_DeleteImage.BackColor = Color.Red;
            Btn_DeleteImage.Location = new Point(347, 16);
            Btn_DeleteImage.Name = "Btn_DeleteImage";
            Btn_DeleteImage.Size = new Size(111, 34);
            Btn_DeleteImage.TabIndex = 5;
            Btn_DeleteImage.Text = "Supprimer";
            Btn_DeleteImage.UseVisualStyleBackColor = false;
            Btn_DeleteImage.Click += button3_Click;
            // 
            // MyContacts
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PNL_Right);
            Controls.Add(PNL_Left);
            Name = "MyContacts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyContacts";
            PNL_Left.ResumeLayout(false);
            Group_Search.ResumeLayout(false);
            Group_Search.PerformLayout();
            GroupBoxMesContatcs.ResumeLayout(false);
            PNL_Right.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PB_Contact_Photo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PNL_Left;
        private Button button2;
        private Button button1;
        private GroupBox GroupBoxMesContatcs;
        private ListBox LB_Contacts;
        private ComboBox comboBox1;
        private GroupBox Group_Search;
        private Button Btn_AddContact;
        private TextBox TB_Search;
        private Panel PNL_Right;
        private PictureBox PB_Contact_Photo;
        private Label LB_Groupe;
        private Label LB_Email;
        private Label Email;
        private Label LB_Name;
        private Label LB_Ville;
        private Label LB_Adress;
        private Label LB_Tel;
        private Label label3;
        private Label Label5;
        private Label Label4;
        private Button Btn_DeleteImage;
    }
}
