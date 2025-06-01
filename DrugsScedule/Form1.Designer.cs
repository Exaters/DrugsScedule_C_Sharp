namespace DrugsScedule
{
    partial class Form1
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
            Welcome = new Label();
            login = new TextBox();
            password = new TextBox();
            show_pass = new CheckBox();
            autorisation = new Button();
            registration = new Button();
            to_drugs_scedule = new Label();
            SuspendLayout();
            // 
            // Welcome
            // 
            Welcome.AutoSize = true;
            Welcome.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Welcome.Location = new Point(439, 59);
            Welcome.Margin = new Padding(4, 0, 4, 0);
            Welcome.Name = "Welcome";
            Welcome.Size = new Size(194, 51);
            Welcome.TabIndex = 0;
            Welcome.Text = "Welcome";
            // 
            // login
            // 
            login.AllowDrop = true;
            login.Location = new Point(406, 145);
            login.Margin = new Padding(4, 3, 4, 3);
            login.MaxLength = 27;
            login.Name = "login";
            login.Size = new Size(266, 30);
            login.TabIndex = 1;
            // 
            // password
            // 
            password.AllowDrop = true;
            password.Location = new Point(406, 181);
            password.Margin = new Padding(4, 3, 4, 3);
            password.MaxLength = 16;
            password.Name = "password";
            password.Size = new Size(266, 30);
            password.TabIndex = 2;
            password.UseSystemPasswordChar = true;
            // 
            // show_pass
            // 
            show_pass.AutoSize = true;
            show_pass.Location = new Point(459, 217);
            show_pass.Margin = new Padding(4, 3, 4, 3);
            show_pass.Name = "show_pass";
            show_pass.Size = new Size(156, 26);
            show_pass.TabIndex = 3;
            show_pass.Text = "show password";
            show_pass.UseVisualStyleBackColor = true;
            show_pass.CheckedChanged += show_pass_CheckedChanged;
            // 
            // autorisation
            // 
            autorisation.Location = new Point(406, 249);
            autorisation.Margin = new Padding(4, 3, 4, 3);
            autorisation.Name = "autorisation";
            autorisation.Size = new Size(266, 32);
            autorisation.TabIndex = 4;
            autorisation.Text = "sing in";
            autorisation.UseVisualStyleBackColor = true;
            autorisation.Click += autorisation_Click;
            // 
            // registration
            // 
            registration.Location = new Point(406, 288);
            registration.Margin = new Padding(4, 3, 4, 3);
            registration.Name = "registration";
            registration.Size = new Size(266, 32);
            registration.TabIndex = 5;
            registration.Text = "sing up";
            registration.UseVisualStyleBackColor = true;
            registration.Click += registration_Click;
            // 
            // to_drugs_scedule
            // 
            to_drugs_scedule.AutoSize = true;
            to_drugs_scedule.Location = new Point(468, 110);
            to_drugs_scedule.Name = "to_drugs_scedule";
            to_drugs_scedule.Size = new Size(138, 22);
            to_drugs_scedule.TabIndex = 6;
            to_drugs_scedule.Text = "to drugs scedule";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 494);
            Controls.Add(to_drugs_scedule);
            Controls.Add(registration);
            Controls.Add(autorisation);
            Controls.Add(show_pass);
            Controls.Add(password);
            Controls.Add(login);
            Controls.Add(Welcome);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "DrugsScedule";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Welcome;
        private TextBox login;
        private TextBox password;
        private CheckBox show_pass;
        private Button autorisation;
        private Button registration;
        private Label to_drugs_scedule;
    }
}
