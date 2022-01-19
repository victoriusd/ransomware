namespace Rasomware2._0
{
    partial class Ransomware2
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ransomware2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.RichTextBox();
            this.codebox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.boxtimer = new System.Windows.Forms.GroupBox();
            this.timer2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Label();
            this.textTimer1 = new System.Windows.Forms.Label();
            this.textTimer2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tmr_hide = new System.Windows.Forms.Timer(this.components);
            this.tmr_show = new System.Windows.Forms.Timer(this.components);
            this.tmr_if = new System.Windows.Forms.Timer(this.components);
            this.tmr_encrypt = new System.Windows.Forms.Timer(this.components);
            this.tmr_clock = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.boxtimer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(196, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 418);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.ReadOnly = true;
            this.label1.ShortcutsEnabled = false;
            this.label1.Size = new System.Drawing.Size(528, 399);
            this.label1.TabIndex = 0;
            this.label1.TabStop = false;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // codebox
            // 
            this.codebox.BackColor = System.Drawing.Color.DarkRed;
            this.codebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codebox.Location = new System.Drawing.Point(197, 462);
            this.codebox.Name = "codebox";
            this.codebox.Size = new System.Drawing.Size(515, 31);
            this.codebox.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Orange;
            this.button1.Location = new System.Drawing.Point(301, 499);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(308, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "DESENCRIPTAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // boxtimer
            // 
            this.boxtimer.Controls.Add(this.timer2);
            this.boxtimer.Controls.Add(this.timer1);
            this.boxtimer.Controls.Add(this.textTimer1);
            this.boxtimer.Controls.Add(this.textTimer2);
            this.boxtimer.Cursor = System.Windows.Forms.Cursors.No;
            this.boxtimer.Location = new System.Drawing.Point(12, 165);
            this.boxtimer.Name = "boxtimer";
            this.boxtimer.Size = new System.Drawing.Size(175, 328);
            this.boxtimer.TabIndex = 4;
            this.boxtimer.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.AutoSize = true;
            this.timer2.BackColor = System.Drawing.Color.Red;
            this.timer2.Cursor = System.Windows.Forms.Cursors.No;
            this.timer2.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer2.Location = new System.Drawing.Point(38, 87);
            this.timer2.Name = "timer2";
            this.timer2.Size = new System.Drawing.Size(102, 32);
            this.timer2.TabIndex = 3;
            this.timer2.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.AutoSize = true;
            this.timer1.BackColor = System.Drawing.Color.Red;
            this.timer1.Cursor = System.Windows.Forms.Cursors.No;
            this.timer1.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer1.Location = new System.Drawing.Point(38, 217);
            this.timer1.Name = "timer1";
            this.timer1.Size = new System.Drawing.Size(102, 32);
            this.timer1.TabIndex = 2;
            this.timer1.Text = "00:00:00";
            // 
            // textTimer1
            // 
            this.textTimer1.AutoSize = true;
            this.textTimer1.BackColor = System.Drawing.Color.Transparent;
            this.textTimer1.Cursor = System.Windows.Forms.Cursors.No;
            this.textTimer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTimer1.ForeColor = System.Drawing.Color.Orange;
            this.textTimer1.Location = new System.Drawing.Point(-3, 32);
            this.textTimer1.Name = "textTimer1";
            this.textTimer1.Size = new System.Drawing.Size(143, 25);
            this.textTimer1.TabIndex = 1;
            this.textTimer1.Text = "Precio X2 En:";
            // 
            // textTimer2
            // 
            this.textTimer2.AutoSize = true;
            this.textTimer2.BackColor = System.Drawing.Color.Transparent;
            this.textTimer2.Cursor = System.Windows.Forms.Cursors.No;
            this.textTimer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTimer2.ForeColor = System.Drawing.Color.Orange;
            this.textTimer2.Location = new System.Drawing.Point(-3, 162);
            this.textTimer2.Name = "textTimer2";
            this.textTimer2.Size = new System.Drawing.Size(181, 25);
            this.textTimer2.TabIndex = 0;
            this.textTimer2.Text = "Tiempo Restante:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Cursor = System.Windows.Forms.Cursors.No;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(251, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(405, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ingrese la contraseña para desencriptar :";
            // 
            // tmr_hide
            // 
            this.tmr_hide.Enabled = true;
            this.tmr_hide.Interval = 10000;
            this.tmr_hide.Tick += new System.EventHandler(this.tmr_hide_Tick);
            // 
            // tmr_show
            // 
            this.tmr_show.Enabled = true;
            this.tmr_show.Interval = 1000;
            this.tmr_show.Tick += new System.EventHandler(this.tmr_show_Tick);
            // 
            // tmr_if
            // 
            this.tmr_if.Enabled = true;
            this.tmr_if.Interval = 300;
            this.tmr_if.Tick += new System.EventHandler(this.tmr_if_Tick);
            // 
            // tmr_encrypt
            // 
            this.tmr_encrypt.Enabled = true;
            this.tmr_encrypt.Interval = 1000;
            this.tmr_encrypt.Tick += new System.EventHandler(this.tmr_encrypt_Tick);
            // 
            // tmr_clock
            // 
            this.tmr_clock.Enabled = true;
            this.tmr_clock.Interval = 3600000;
            this.tmr_clock.Tick += new System.EventHandler(this.tmr_clock_Tick);
            // 
            // Ransomware2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(742, 555);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxtimer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.codebox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ransomware2";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ransomware2.0";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ransomware2_FormClosing);
            this.Load += new System.EventHandler(this.Ransomware2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.boxtimer.ResumeLayout(false);
            this.boxtimer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox label1;
        private System.Windows.Forms.TextBox codebox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox boxtimer;
        private System.Windows.Forms.Label timer2;
        private System.Windows.Forms.Label timer1;
        private System.Windows.Forms.Label textTimer1;
        private System.Windows.Forms.Label textTimer2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer tmr_hide;
        private System.Windows.Forms.Timer tmr_show;
        private System.Windows.Forms.Timer tmr_if;
        private System.Windows.Forms.Timer tmr_encrypt;
        private System.Windows.Forms.Timer tmr_clock;
    }
}

