namespace projectX
{
    partial class RegistForm
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
            pasform = new TextBox();
            logform = new TextBox();
            Registbut = new Button();
            pascheck = new TextBox();
            perehodbut = new Button();
            SuspendLayout();
            // 
            // pasform
            // 
            pasform.Cursor = Cursors.Hand;
            pasform.Font = new Font("Segoe UI", 20F);
            pasform.Location = new Point(237, 140);
            pasform.Name = "pasform";
            pasform.PasswordChar = '*';
            pasform.PlaceholderText = "Введи пароль";
            pasform.Size = new Size(327, 52);
            pasform.TabIndex = 5;
            // 
            // logform
            // 
            logform.Cursor = Cursors.Hand;
            logform.Font = new Font("Segoe UI", 20F);
            logform.Location = new Point(237, 44);
            logform.Name = "logform";
            logform.PlaceholderText = "Введи логин";
            logform.Size = new Size(327, 52);
            logform.TabIndex = 4;
            // 
            // Registbut
            // 
            Registbut.Cursor = Cursors.Hand;
            Registbut.Location = new Point(321, 318);
            Registbut.Name = "Registbut";
            Registbut.Size = new Size(149, 49);
            Registbut.TabIndex = 3;
            Registbut.Text = "регистрация";
            Registbut.UseVisualStyleBackColor = true;
            Registbut.Click += Registbut_Click;
            // 
            // pascheck
            // 
            pascheck.Cursor = Cursors.Hand;
            pascheck.Font = new Font("Segoe UI", 20F);
            pascheck.Location = new Point(237, 216);
            pascheck.Name = "pascheck";
            pascheck.PasswordChar = '*';
            pascheck.PlaceholderText = "Повтори пароль";
            pascheck.Size = new Size(327, 52);
            pascheck.TabIndex = 6;
            // 
            // perehodbut
            // 
            perehodbut.Cursor = Cursors.Hand;
            perehodbut.Location = new Point(734, 328);
            perehodbut.Name = "perehodbut";
            perehodbut.Size = new Size(33, 29);
            perehodbut.TabIndex = 7;
            perehodbut.Text = ">";
            perehodbut.UseVisualStyleBackColor = true;
            perehodbut.Click += perehodbut_Click;
            // 
            // RegistForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(perehodbut);
            Controls.Add(pascheck);
            Controls.Add(pasform);
            Controls.Add(logform);
            Controls.Add(Registbut);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximumSize = new Size(818, 497);
            Name = "RegistForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Регистрация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox pasform;
        private TextBox logform;
        private Button Registbut;
        private TextBox pascheck;
        private Button perehodbut;
    }
}