namespace pogoda
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.Weather_PictureBox_Image = new System.Windows.Forms.PictureBox();
            this.Weather_Label_Description_ = new System.Windows.Forms.Label();
            this.Weather_Label_Temperature = new System.Windows.Forms.Label();
            this.Weather_Label_TemperatureFeel = new System.Windows.Forms.Label();
            this.Weather_Label_Pressure = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dodajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuńRSSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Weather_Label_Location = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Weather_PictureBox_Image)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Weather_PictureBox_Image
            // 
            this.Weather_PictureBox_Image.Dock = System.Windows.Forms.DockStyle.Left;
            this.Weather_PictureBox_Image.Location = new System.Drawing.Point(0, 0);
            this.Weather_PictureBox_Image.Name = "Weather_PictureBox_Image";
            this.Weather_PictureBox_Image.Size = new System.Drawing.Size(65, 46);
            this.Weather_PictureBox_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Weather_PictureBox_Image.TabIndex = 0;
            this.Weather_PictureBox_Image.TabStop = false;
            // 
            // Weather_Label_Description_
            // 
            this.Weather_Label_Description_.AutoSize = true;
            this.Weather_Label_Description_.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Weather_Label_Description_.Location = new System.Drawing.Point(71, -2);
            this.Weather_Label_Description_.Name = "Weather_Label_Description_";
            this.Weather_Label_Description_.Size = new System.Drawing.Size(70, 25);
            this.Weather_Label_Description_.TabIndex = 1;
            this.Weather_Label_Description_.Text = "label1";
            // 
            // Weather_Label_Temperature
            // 
            this.Weather_Label_Temperature.AutoSize = true;
            this.Weather_Label_Temperature.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Weather_Label_Temperature.Location = new System.Drawing.Point(340, -6);
            this.Weather_Label_Temperature.Name = "Weather_Label_Temperature";
            this.Weather_Label_Temperature.Size = new System.Drawing.Size(91, 32);
            this.Weather_Label_Temperature.TabIndex = 2;
            this.Weather_Label_Temperature.Text = "label2";
            // 
            // Weather_Label_TemperatureFeel
            // 
            this.Weather_Label_TemperatureFeel.AutoSize = true;
            this.Weather_Label_TemperatureFeel.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Weather_Label_TemperatureFeel.Location = new System.Drawing.Point(443, 1);
            this.Weather_Label_TemperatureFeel.Name = "Weather_Label_TemperatureFeel";
            this.Weather_Label_TemperatureFeel.Size = new System.Drawing.Size(70, 25);
            this.Weather_Label_TemperatureFeel.TabIndex = 3;
            this.Weather_Label_TemperatureFeel.Text = "label3";
            this.Weather_Label_TemperatureFeel.Click += new System.EventHandler(this.label3_Click);
            // 
            // Weather_Label_Pressure
            // 
            this.Weather_Label_Pressure.AutoSize = true;
            this.Weather_Label_Pressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Weather_Label_Pressure.Location = new System.Drawing.Point(528, 5);
            this.Weather_Label_Pressure.Name = "Weather_Label_Pressure";
            this.Weather_Label_Pressure.Size = new System.Drawing.Size(57, 20);
            this.Weather_Label_Pressure.TabIndex = 4;
            this.Weather_Label_Pressure.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gold;
            this.label5.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(271, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "label5";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajToolStripMenuItem,
            this.usuńRSSToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(128, 48);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            this.contextMenuStrip1.Click += new System.EventHandler(this.contextMenuStrip1_Click);
            // 
            // dodajToolStripMenuItem
            // 
            this.dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            this.dodajToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.dodajToolStripMenuItem.Text = "Dodaj RSS";
            this.dodajToolStripMenuItem.Click += new System.EventHandler(this.dodajToolStripMenuItem_Click_1);
            // 
            // usuńRSSToolStripMenuItem
            // 
            this.usuńRSSToolStripMenuItem.Name = "usuńRSSToolStripMenuItem";
            this.usuńRSSToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.usuńRSSToolStripMenuItem.Text = "Usuń RSS";
            this.usuńRSSToolStripMenuItem.Click += new System.EventHandler(this.usuńRSSToolStripMenuItem_Click);
            // 
            // Weather_Label_Location
            // 
            this.Weather_Label_Location.AutoSize = true;
            this.Weather_Label_Location.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Weather_Label_Location.Location = new System.Drawing.Point(612, 5);
            this.Weather_Label_Location.Name = "Weather_Label_Location";
            this.Weather_Label_Location.Size = new System.Drawing.Size(57, 20);
            this.Weather_Label_Location.TabIndex = 6;
            this.Weather_Label_Location.Text = "label6";
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 46);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.Weather_PictureBox_Image);
            this.Controls.Add(this.Weather_Label_Location);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Weather_Label_Pressure);
            this.Controls.Add(this.Weather_Label_TemperatureFeel);
            this.Controls.Add(this.Weather_Label_Temperature);
            this.Controls.Add(this.Weather_Label_Description_);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HelpButton = true;
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Pogoda";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.Weather_PictureBox_Image)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

   
     

        #endregion
     
        private System.Windows.Forms.PictureBox Weather_PictureBox_Image;
        private System.Windows.Forms.Label Weather_Label_Description_;
        private System.Windows.Forms.Label Weather_Label_Temperature;
        private System.Windows.Forms.Label Weather_Label_TemperatureFeel;
        private System.Windows.Forms.Label Weather_Label_Pressure;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuńRSSToolStripMenuItem;
        private System.Windows.Forms.Label Weather_Label_Location;
        private System.Windows.Forms.Timer timer1;
    }
}

