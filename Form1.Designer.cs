namespace projectX
{
    partial class LoginForm
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
            Logbut = new Button();
            logform = new TextBox();
            pasform = new TextBox();
            perehodbut = new Button();
            SuspendLayout();
            // 
            // Logbut
            // 
            Logbut.Cursor = Cursors.Hand;
            Logbut.Location = new Point(296, 344);
            Logbut.Name = "Logbut";
            Logbut.Size = new Size(149, 49);
            Logbut.TabIndex = 0;
            Logbut.Text = "войти";
            Logbut.UseVisualStyleBackColor = true;
            Logbut.Click += Logbut_Click;
            // 
            // logform
            // 
            logform.Cursor = Cursors.Hand;
            logform.Font = new Font("Segoe UI", 20F);
            logform.Location = new Point(212, 110);
            logform.Name = "logform";
            logform.PlaceholderText = "Введи логин";
            logform.Size = new Size(327, 52);
            logform.TabIndex = 1;
            // 
            // pasform
            // 
            pasform.Cursor = Cursors.Hand;
            pasform.Font = new Font("Segoe UI", 20F);
            pasform.Location = new Point(212, 225);
            pasform.Name = "pasform";
            pasform.PasswordChar = '*';
            pasform.PlaceholderText = "Введи пароль";
            pasform.Size = new Size(327, 52);
            pasform.TabIndex = 2;
            // 
            // perehodbut
            // 
            perehodbut.Cursor = Cursors.Hand;
            perehodbut.Location = new Point(687, 354);
            perehodbut.Name = "perehodbut";
            perehodbut.Size = new Size(33, 29);
            perehodbut.TabIndex = 3;
            perehodbut.Text = ">";
            perehodbut.UseVisualStyleBackColor = true;
            perehodbut.Click += button1_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(747, 450);
            Controls.Add(perehodbut);
            Controls.Add(pasform);
            Controls.Add(logform);
            Controls.Add(Logbut);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximumSize = new Size(765, 497);
            MinimumSize = new Size(765, 497);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Вход";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Logbut;
        private TextBox logform;
        private TextBox pasform;
        private Button perehodbut;
    }
}
