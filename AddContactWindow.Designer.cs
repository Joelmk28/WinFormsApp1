namespace WinFormsApp1
{
    partial class AddContactWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PB_Contact_Photo = new PictureBox();
            panel1 = new Panel();
            CB_Groupe = new ComboBox();
            TB_City = new TextBox();
            TB_Adresse = new TextBox();
            TB_Tel = new TextBox();
            TB_Email = new TextBox();
            TB_Name = new TextBox();
            TB_FirstName = new TextBox();
            label6 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Label5 = new Label();
            Label4 = new Label();
            Email = new Label();
            Btn_AddContact = new Button();
            Btn_Choise_Image = new Button();
            ((System.ComponentModel.ISupportInitialize)PB_Contact_Photo).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // PB_Contact_Photo
            // 
            PB_Contact_Photo.BorderStyle = BorderStyle.FixedSingle;
            PB_Contact_Photo.Location = new Point(9, 8);
            PB_Contact_Photo.Name = "PB_Contact_Photo";
            PB_Contact_Photo.Size = new Size(299, 229);
            PB_Contact_Photo.SizeMode = PictureBoxSizeMode.CenterImage;
            PB_Contact_Photo.TabIndex = 1;
            PB_Contact_Photo.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(CB_Groupe);
            panel1.Controls.Add(TB_City);
            panel1.Controls.Add(TB_Adresse);
            panel1.Controls.Add(TB_Tel);
            panel1.Controls.Add(TB_Email);
            panel1.Controls.Add(TB_Name);
            panel1.Controls.Add(TB_FirstName);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(Label5);
            panel1.Controls.Add(Label4);
            panel1.Controls.Add(Email);
            panel1.Location = new Point(9, 243);
            panel1.Name = "panel1";
            panel1.Size = new Size(299, 292);
            panel1.TabIndex = 2;
            // 
            // CB_Groupe
            // 
            CB_Groupe.DropDownStyle = ComboBoxStyle.DropDownList;
            CB_Groupe.FlatStyle = FlatStyle.Flat;
            CB_Groupe.FormattingEnabled = true;
            CB_Groupe.Location = new Point(105, 254);
            CB_Groupe.Name = "CB_Groupe";
            CB_Groupe.Size = new Size(182, 33);
            CB_Groupe.TabIndex = 22;
            // 
            // TB_City
            // 
            TB_City.Location = new Point(107, 220);
            TB_City.Name = "TB_City";
            TB_City.Size = new Size(176, 31);
            TB_City.TabIndex = 21;
            // 
            // TB_Adresse
            // 
            TB_Adresse.Location = new Point(107, 182);
            TB_Adresse.Name = "TB_Adresse";
            TB_Adresse.Size = new Size(176, 31);
            TB_Adresse.TabIndex = 20;
            // 
            // TB_Tel
            // 
            TB_Tel.Location = new Point(107, 141);
            TB_Tel.Name = "TB_Tel";
            TB_Tel.Size = new Size(176, 31);
            TB_Tel.TabIndex = 19;
            // 
            // TB_Email
            // 
            TB_Email.Location = new Point(107, 102);
            TB_Email.Name = "TB_Email";
            TB_Email.Size = new Size(176, 31);
            TB_Email.TabIndex = 18;
            // 
            // TB_Name
            // 
            TB_Name.Location = new Point(107, 64);
            TB_Name.Name = "TB_Name";
            TB_Name.Size = new Size(176, 31);
            TB_Name.TabIndex = 17;
            // 
            // TB_FirstName
            // 
            TB_FirstName.Location = new Point(107, 27);
            TB_FirstName.Name = "TB_FirstName";
            TB_FirstName.Size = new Size(176, 31);
            TB_FirstName.TabIndex = 16;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(4, 250);
            label6.Name = "label6";
            label6.Size = new Size(97, 37);
            label6.TabIndex = 15;
            label6.Text = "Groupe :";
            label6.TextAlign = ContentAlignment.MiddleRight;
            label6.Click += label6_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(4, 24);
            label1.Name = "label1";
            label1.Size = new Size(97, 37);
            label1.TabIndex = 14;
            label1.Text = "Prénom :";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 61);
            label2.Name = "label2";
            label2.Size = new Size(76, 23);
            label2.TabIndex = 13;
            label2.Text = "Nom :";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 222);
            label3.Name = "label3";
            label3.Size = new Size(76, 23);
            label3.TabIndex = 11;
            label3.Text = "Ville :";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label5
            // 
            Label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label5.Location = new Point(4, 183);
            Label5.Name = "Label5";
            Label5.Size = new Size(95, 32);
            Label5.TabIndex = 10;
            Label5.Text = "Adresse :";
            Label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label4
            // 
            Label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label4.Location = new Point(25, 143);
            Label4.Name = "Label4";
            Label4.Size = new Size(76, 23);
            Label4.TabIndex = 9;
            Label4.Text = "Tél :";
            Label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Email
            // 
            Email.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Email.Location = new Point(25, 103);
            Email.Name = "Email";
            Email.Size = new Size(76, 23);
            Email.TabIndex = 8;
            Email.Text = "Email :";
            Email.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Btn_AddContact
            // 
            Btn_AddContact.Dock = DockStyle.Bottom;
            Btn_AddContact.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Btn_AddContact.Location = new Point(0, 540);
            Btn_AddContact.Name = "Btn_AddContact";
            Btn_AddContact.Size = new Size(317, 43);
            Btn_AddContact.TabIndex = 3;
            Btn_AddContact.Text = "Ajouter";
            Btn_AddContact.UseVisualStyleBackColor = true;
            Btn_AddContact.Click += Btn_AddContact_Click_1;
            // 
            // Btn_Choise_Image
            // 
            Btn_Choise_Image.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Btn_Choise_Image.Location = new Point(9, 203);
            Btn_Choise_Image.Name = "Btn_Choise_Image";
            Btn_Choise_Image.Size = new Size(299, 34);
            Btn_Choise_Image.TabIndex = 23;
            Btn_Choise_Image.Text = "Choisir une image";
            Btn_Choise_Image.UseVisualStyleBackColor = true;
            // 
            // AddContactWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 583);
            Controls.Add(Btn_Choise_Image);
            Controls.Add(Btn_AddContact);
            Controls.Add(panel1);
            Controls.Add(PB_Contact_Photo);
            Name = "AddContactWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ajouter un contact";
            ((System.ComponentModel.ISupportInitialize)PB_Contact_Photo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox PB_Contact_Photo;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private Label Label5;
        private Label Label4;
        private Label Email;
        private Label label1;
        private Label label6;
        private TextBox TB_City;
        private TextBox TB_Adresse;
        private TextBox TB_Tel;
        private TextBox TB_Email;
        private TextBox TB_Name;
        private TextBox TB_FirstName;
        private ComboBox CB_Groupe;
        private Button Btn_AddContact;
        private Button Btn_Choise_Image;
    }
}