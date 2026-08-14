namespace kaswarga
{
    partial class Login
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            button = new Guna.UI2.WinForms.Guna2Button();
            passbox = new Guna.UI2.WinForms.Guna2TextBox();
            userbox = new Guna.UI2.WinForms.Guna2TextBox();
            label2 = new Label();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 38.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 32);
            label1.Name = "label1";
            label1.Size = new Size(327, 74);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.Transparent;
            guna2Panel1.BackgroundImageLayout = ImageLayout.None;
            guna2Panel1.BorderRadius = 25;
            guna2Panel1.Controls.Add(button);
            guna2Panel1.Controls.Add(passbox);
            guna2Panel1.Controls.Add(userbox);
            guna2Panel1.CustomizableEdges = customizableEdges7;
            guna2Panel1.FillColor = SystemColors.MenuHighlight;
            guna2Panel1.Location = new Point(39, 138);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Panel1.Size = new Size(286, 297);
            guna2Panel1.TabIndex = 1;
            // 
            // button
            // 
            button.BackColor = Color.Transparent;
            button.BorderRadius = 8;
            button.CustomizableEdges = customizableEdges1;
            button.DisabledState.BorderColor = Color.DarkGray;
            button.DisabledState.CustomBorderColor = Color.DarkGray;
            button.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            button.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            button.FillColor = Color.DodgerBlue;
            button.Font = new Font("Segoe UI", 9F);
            button.ForeColor = Color.White;
            button.Location = new Point(20, 218);
            button.Name = "button";
            button.ShadowDecoration.CustomizableEdges = customizableEdges2;
            button.Size = new Size(241, 35);
            button.TabIndex = 2;
            button.Text = "Masuk";
            button.Click += button_Click;
            // 
            // passbox
            // 
            passbox.BackColor = Color.Transparent;
            passbox.BorderColor = Color.DodgerBlue;
            passbox.BorderRadius = 8;
            passbox.CustomizableEdges = customizableEdges3;
            passbox.DefaultText = "";
            passbox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            passbox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            passbox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            passbox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            passbox.FillColor = SystemColors.HotTrack;
            passbox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            passbox.Font = new Font("Segoe UI", 10F);
            passbox.ForeColor = Color.White;
            passbox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            passbox.Location = new Point(20, 77);
            passbox.Name = "passbox";
            passbox.PlaceholderForeColor = Color.White;
            passbox.PlaceholderText = "Password";
            passbox.SelectedText = "";
            passbox.ShadowDecoration.CustomizableEdges = customizableEdges4;
            passbox.Size = new Size(241, 41);
            passbox.TabIndex = 1;
            passbox.UseSystemPasswordChar = true;
            // 
            // userbox
            // 
            userbox.BackColor = Color.Transparent;
            userbox.BorderColor = Color.DodgerBlue;
            userbox.BorderRadius = 8;
            userbox.CustomizableEdges = customizableEdges5;
            userbox.DefaultText = "";
            userbox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            userbox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            userbox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            userbox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            userbox.FillColor = SystemColors.HotTrack;
            userbox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            userbox.Font = new Font("Segoe UI", 10F);
            userbox.ForeColor = Color.White;
            userbox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            userbox.Location = new Point(20, 30);
            userbox.Name = "userbox";
            userbox.PlaceholderForeColor = Color.White;
            userbox.PlaceholderText = "Username";
            userbox.SelectedText = "";
            userbox.ShadowDecoration.CustomizableEdges = customizableEdges6;
            userbox.Size = new Size(241, 41);
            userbox.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(39, 451);
            label2.Name = "label2";
            label2.Size = new Size(45, 17);
            label2.TabIndex = 2;
            label2.Text = "Keluar";
            label2.Click += label2_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(373, 513);
            Controls.Add(label2);
            Controls.Add(guna2Panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            guna2Panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox userbox;
        private Guna.UI2.WinForms.Guna2TextBox passbox;
        private Guna.UI2.WinForms.Guna2Button button;
        private Label label2;
    }
}