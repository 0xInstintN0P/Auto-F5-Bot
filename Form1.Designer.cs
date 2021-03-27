namespace S4LeagueAutoF5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.metroChecker1 = new MetroSuite.MetroChecker();
            this.metroControlBox1 = new MetroSuite.MetroControlBox();
            this.tF5 = new System.Windows.Forms.Timer(this.components);
            this.tAutoClick = new System.Windows.Forms.Timer(this.components);
            this.tEscape = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // metroChecker1
            // 
            this.metroChecker1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroChecker1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroChecker1.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.metroChecker1.CheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.metroChecker1.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.metroChecker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.metroChecker1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.metroChecker1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.metroChecker1.Location = new System.Drawing.Point(82, 64);
            this.metroChecker1.Name = "metroChecker1";
            this.metroChecker1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(165)))));
            this.metroChecker1.Size = new System.Drawing.Size(118, 14);
            this.metroChecker1.Style = MetroSuite.Design.Style.Dark;
            this.metroChecker1.TabIndex = 0;
            this.metroChecker1.Text = "Activate - Auto F5";
            this.metroChecker1.CheckedChanged += new MetroSuite.MetroChecker.CheckedChangedEventHandler(this.metroChecker1_CheckedChanged);
            // 
            // metroControlBox1
            // 
            this.metroControlBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroControlBox1.Location = new System.Drawing.Point(176, 3);
            this.metroControlBox1.Name = "metroControlBox1";
            this.metroControlBox1.Size = new System.Drawing.Size(96, 32);
            this.metroControlBox1.TabIndex = 1;
            // 
            // tF5
            // 
            this.tF5.Interval = 2100;
            this.tF5.Tick += new System.EventHandler(this.tF5_Tick);
            // 
            // tAutoClick
            // 
            this.tAutoClick.Interval = 2200;
            this.tAutoClick.Tick += new System.EventHandler(this.tAutoClick_Tick);
            // 
            // tEscape
            // 
            this.tEscape.Interval = 2300;
            this.tEscape.Tick += new System.EventHandler(this.tEscape_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 126);
            this.Controls.Add(this.metroControlBox1);
            this.Controls.Add(this.metroChecker1);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.State = MetroSuite.MetroForm.FormState.Normal;
            this.Style = MetroSuite.Design.Style.Dark;
            this.Text = "S4 League - Auto F5 ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSuite.MetroChecker metroChecker1;
        private MetroSuite.MetroControlBox metroControlBox1;
        private System.Windows.Forms.Timer tF5;
        private System.Windows.Forms.Timer tAutoClick;
        private System.Windows.Forms.Timer tEscape;
    }
}

