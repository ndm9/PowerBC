
namespace PowerBC
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txbInput0 = new System.Windows.Forms.TextBox();
            this.txbInput1 = new System.Windows.Forms.TextBox();
            this.nudCustomBase1 = new System.Windows.Forms.NumericUpDown();
            this.nudCustomBase2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudCustomBase1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCustomBase2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Binary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Octal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Decimal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Duodecimal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hexadecimal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Vigesimal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Base";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Base";
            // 
            // txbInput0
            // 
            this.txbInput0.BackColor = System.Drawing.SystemColors.Control;
            this.txbInput0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbInput0.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbInput0.Location = new System.Drawing.Point(94, 7);
            this.txbInput0.Name = "txbInput0";
            this.txbInput0.Size = new System.Drawing.Size(466, 22);
            this.txbInput0.TabIndex = 8;
            // 
            // txbInput1
            // 
            this.txbInput1.BackColor = System.Drawing.SystemColors.Control;
            this.txbInput1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbInput1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbInput1.Location = new System.Drawing.Point(94, 31);
            this.txbInput1.Name = "txbInput1";
            this.txbInput1.Size = new System.Drawing.Size(466, 22);
            this.txbInput1.TabIndex = 9;
            // 
            // nudCustomBase1
            // 
            this.nudCustomBase1.Location = new System.Drawing.Point(50, 151);
            this.nudCustomBase1.Maximum = new decimal(new int[] {
            62,
            0,
            0,
            0});
            this.nudCustomBase1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCustomBase1.Name = "nudCustomBase1";
            this.nudCustomBase1.Size = new System.Drawing.Size(39, 23);
            this.nudCustomBase1.TabIndex = 18;
            this.nudCustomBase1.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.nudCustomBase1.ValueChanged += new System.EventHandler(this.nudCustomBase_ValueChanged);
            // 
            // nudCustomBase2
            // 
            this.nudCustomBase2.Location = new System.Drawing.Point(50, 175);
            this.nudCustomBase2.Maximum = new decimal(new int[] {
            62,
            0,
            0,
            0});
            this.nudCustomBase2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCustomBase2.Name = "nudCustomBase2";
            this.nudCustomBase2.Size = new System.Drawing.Size(39, 23);
            this.nudCustomBase2.TabIndex = 19;
            this.nudCustomBase2.Value = new decimal(new int[] {
            62,
            0,
            0,
            0});
            this.nudCustomBase2.ValueChanged += new System.EventHandler(this.nudCustomBase_ValueChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 206);
            this.Controls.Add(this.nudCustomBase2);
            this.Controls.Add(this.nudCustomBase1);
            this.Controls.Add(this.txbInput1);
            this.Controls.Add(this.txbInput0);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "PowerBC";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCustomBase1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCustomBase2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbInput0;
        private System.Windows.Forms.TextBox txbInput1;
        private System.Windows.Forms.NumericUpDown nudCustomBase1;
        private System.Windows.Forms.NumericUpDown nudCustomBase2;
    }
}

