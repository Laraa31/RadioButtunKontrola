namespace Radio_Kontrola
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
            this.radioButtonAvion = new System.Windows.Forms.RadioButton();
            this.radioButtonAutobus = new System.Windows.Forms.RadioButton();
            this.radioButtonVlastiti = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonRezerviraj = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonAvion
            // 
            this.radioButtonAvion.AutoSize = true;
            this.radioButtonAvion.Location = new System.Drawing.Point(60, 41);
            this.radioButtonAvion.Name = "radioButtonAvion";
            this.radioButtonAvion.Size = new System.Drawing.Size(52, 17);
            this.radioButtonAvion.TabIndex = 0;
            this.radioButtonAvion.TabStop = true;
            this.radioButtonAvion.Text = "Avion";
            this.radioButtonAvion.UseVisualStyleBackColor = true;
            // 
            // radioButtonAutobus
            // 
            this.radioButtonAutobus.AutoSize = true;
            this.radioButtonAutobus.Location = new System.Drawing.Point(60, 77);
            this.radioButtonAutobus.Name = "radioButtonAutobus";
            this.radioButtonAutobus.Size = new System.Drawing.Size(64, 17);
            this.radioButtonAutobus.TabIndex = 1;
            this.radioButtonAutobus.TabStop = true;
            this.radioButtonAutobus.Text = "Autobus";
            this.radioButtonAutobus.UseVisualStyleBackColor = true;
            this.radioButtonAutobus.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonVlastiti
            // 
            this.radioButtonVlastiti.AutoSize = true;
            this.radioButtonVlastiti.Location = new System.Drawing.Point(60, 116);
            this.radioButtonVlastiti.Name = "radioButtonVlastiti";
            this.radioButtonVlastiti.Size = new System.Drawing.Size(94, 17);
            this.radioButtonVlastiti.TabIndex = 2;
            this.radioButtonVlastiti.TabStop = true;
            this.radioButtonVlastiti.Text = "Vlastiti prijevoz";
            this.radioButtonVlastiti.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonAvion);
            this.groupBox1.Controls.Add(this.radioButtonVlastiti);
            this.groupBox1.Controls.Add(this.radioButtonAutobus);
            this.groupBox1.Location = new System.Drawing.Point(278, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 212);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Odaberite vrstu prijevoza";
            // 
            // buttonRezerviraj
            // 
            this.buttonRezerviraj.Location = new System.Drawing.Point(338, 289);
            this.buttonRezerviraj.Name = "buttonRezerviraj";
            this.buttonRezerviraj.Size = new System.Drawing.Size(146, 29);
            this.buttonRezerviraj.TabIndex = 4;
            this.buttonRezerviraj.Text = "Rezerviraj";
            this.buttonRezerviraj.UseVisualStyleBackColor = true;
            this.buttonRezerviraj.Click += new System.EventHandler(this.buttonRezerviraj_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(278, 355);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(259, 72);
            this.textBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonRezerviraj);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonAvion;
        private System.Windows.Forms.RadioButton radioButtonAutobus;
        private System.Windows.Forms.RadioButton radioButtonVlastiti;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonRezerviraj;
        private System.Windows.Forms.TextBox textBox1;
    }
}

