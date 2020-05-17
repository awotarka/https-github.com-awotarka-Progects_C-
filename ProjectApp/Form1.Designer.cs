namespace ProjectApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Time = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.learning1 = new ProjectApp.Argently();
            this.books1 = new ProjectApp.Today();
            this.targets1 = new ProjectApp.Week();
            this.ideas1 = new ProjectApp.Others();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(174)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 570);
            this.panel1.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Image = global::ProjectApp.Properties.Resources.icons8_minimize_window_26;
            this.button6.Location = new System.Drawing.Point(0, 510);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(200, 60);
            this.button6.TabIndex = 6;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Image = global::ProjectApp.Properties.Resources.icons8_exit_50;
            this.button5.Location = new System.Drawing.Point(0, 450);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(200, 60);
            this.button5.TabIndex = 5;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Image = global::ProjectApp.Properties.Resources.icons8_registration_50;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 370);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 80);
            this.button4.TabIndex = 4;
            this.button4.Text = "Прочее";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Image = global::ProjectApp.Properties.Resources.icons8_registration_50;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 290);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 80);
            this.button3.TabIndex = 3;
            this.button3.Text = "На неделю";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Image = global::ProjectApp.Properties.Resources.icons8_registration_50;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 80);
            this.button2.TabIndex = 2;
            this.button2.Text = "На день";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Image = global::ProjectApp.Properties.Resources.icons8_registration_50;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 80);
            this.button1.TabIndex = 1;
            this.button1.Text = "Срочно";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(146)))), ((int)(((byte)(216)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 130);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjectApp.Properties.Resources.peron;
            this.pictureBox1.Location = new System.Drawing.Point(45, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 88);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Dock = System.Windows.Forms.DockStyle.Right;
            this.Time.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(26)))), ((int)(((byte)(127)))));
            this.Time.Location = new System.Drawing.Point(735, 0);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(125, 36);
            this.Time.TabIndex = 5;
            this.Time.Text = "00:00:00";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(26)))), ((int)(((byte)(127)))));
            this.Date.Location = new System.Drawing.Point(707, 36);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(153, 30);
            this.Date.TabIndex = 6;
            this.Date.Text = "16 мая 2020";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // learning1
            // 
            this.learning1.Location = new System.Drawing.Point(200, 130);
            this.learning1.Name = "learning1";
            this.learning1.Size = new System.Drawing.Size(650, 420);
            this.learning1.TabIndex = 4;
            // 
            // books1
            // 
            this.books1.Location = new System.Drawing.Point(200, 130);
            this.books1.Name = "books1";
            this.books1.Size = new System.Drawing.Size(650, 420);
            this.books1.TabIndex = 3;
            // 
            // targets1
            // 
            this.targets1.Location = new System.Drawing.Point(200, 130);
            this.targets1.Name = "targets1";
            this.targets1.Size = new System.Drawing.Size(650, 420);
            this.targets1.TabIndex = 2;
            // 
            // ideas1
            // 
            this.ideas1.Location = new System.Drawing.Point(200, 130);
            this.ideas1.Name = "ideas1";
            this.ideas1.Size = new System.Drawing.Size(650, 420);
            this.ideas1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 570);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.learning1);
            this.Controls.Add(this.books1);
            this.Controls.Add(this.targets1);
            this.Controls.Add(this.ideas1);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private Others ideas1;
        private Week targets1;
        private Today books1;
        private Argently learning1;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Timer timer1;
    }
}

