namespace Malmoinl3
{
    partial class MainForm
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
            groupBox1 = new GroupBox();
            label12 = new Label();
            btnCalculate = new Button();
            groupBox6 = new GroupBox();
            rbtnImperial = new RadioButton();
            rbtnMetric = new RadioButton();
            label8 = new Label();
            groupBox5 = new GroupBox();
            lblGlasses = new Label();
            lblWaterIntake = new Label();
            label10 = new Label();
            label9 = new Label();
            groupBox2 = new GroupBox();
            txtWeight = new TextBox();
            txtHeight = new TextBox();
            txtName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox4 = new GroupBox();
            label11 = new Label();
            cmbActivityLevel = new ComboBox();
            label7 = new Label();
            groupBox3 = new GroupBox();
            rbtnMale = new RadioButton();
            rbtnFemale = new RadioButton();
            label6 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(btnCalculate);
            groupBox1.Controls.Add(groupBox6);
            groupBox1.Controls.Add(groupBox5);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(53, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1173, 465);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(100, 276);
            label12.Name = "label12";
            label12.Size = new Size(0, 20);
            label12.TabIndex = 16;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(92, 268);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(207, 51);
            btnCalculate.TabIndex = 15;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(rbtnImperial);
            groupBox6.Controls.Add(rbtnMetric);
            groupBox6.Controls.Add(label8);
            groupBox6.Location = new Point(672, 268);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(444, 75);
            groupBox6.TabIndex = 3;
            groupBox6.TabStop = false;
            // 
            // rbtnImperial
            // 
            rbtnImperial.AutoSize = true;
            rbtnImperial.Location = new Point(253, 36);
            rbtnImperial.Name = "rbtnImperial";
            rbtnImperial.Size = new Size(135, 24);
            rbtnImperial.TabIndex = 12;
            rbtnImperial.TabStop = true;
            rbtnImperial.Text = "Imperial (ft, lbs)";
            rbtnImperial.UseVisualStyleBackColor = true;
            // 
            // rbtnMetric
            this.rbtnMetric.AutoSize = true;
            this.rbtnMetric.Location = new System.Drawing.Point(35, 36);
            this.rbtnMetric.Name = "rbtnMetric";
            this.rbtnMetric.Size = new System.Drawing.Size(129, 24);
            this.rbtnMetric.TabIndex = 11;
            this.rbtnMetric.TabStop = true;
            this.rbtnMetric.Text = "Metric (kg, cm)";
            this.rbtnMetric.UseVisualStyleBackColor = true;
            this.rbtnMetric.Checked = true; // Set Metric as the default selection
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 0);
            label8.Name = "label8";
            label8.Size = new Size(36, 20);
            label8.TabIndex = 10;
            label8.Text = "Unit";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(lblGlasses);
            groupBox5.Controls.Add(lblWaterIntake);
            groupBox5.Controls.Add(label10);
            groupBox5.Controls.Add(label9);
            groupBox5.Location = new Point(23, 375);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(1141, 78);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "groupBox5";
            // 
            // lblGlasses
            // 
            lblGlasses.BorderStyle = BorderStyle.FixedSingle;
            lblGlasses.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblGlasses.ForeColor = SystemColors.HotTrack;
            lblGlasses.Location = new Point(703, 38);
            lblGlasses.Name = "lblGlasses";
            lblGlasses.Size = new Size(284, 25);
            lblGlasses.TabIndex = 14;
            // 
            // lblWaterIntake
            // 
            lblWaterIntake.BackColor = SystemColors.Control;
            lblWaterIntake.BorderStyle = BorderStyle.FixedSingle;
            lblWaterIntake.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblWaterIntake.ForeColor = SystemColors.HotTrack;
            lblWaterIntake.Location = new Point(269, 38);
            lblWaterIntake.Name = "lblWaterIntake";
            lblWaterIntake.Size = new Size(284, 25);
            lblWaterIntake.TabIndex = 13;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 0);
            label10.Name = "label10";
            label10.Size = new Size(304, 20);
            label10.TabIndex = 12;
            label10.Text = "Recommended daily water consumption for ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(16, 38);
            label9.Name = "label9";
            label9.Size = new Size(128, 20);
            label9.TabIndex = 11;
            label9.Text = "Daily water intake";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtWeight);
            groupBox2.Controls.Add(txtHeight);
            groupBox2.Controls.Add(txtName);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Location = new Point(23, 44);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1141, 181);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(179, 137);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(125, 27);
            txtWeight.TabIndex = 10;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(179, 96);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(125, 27);
            txtHeight.TabIndex = 9;
            // 
            // txtName
            // 
            txtName.Location = new Point(179, 50);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 140);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 7;
            label5.Text = "Weight (lbs)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 96);
            label4.Name = "label4";
            label4.Size = new Size(126, 20);
            label4.TabIndex = 6;
            label4.Text = "Height (ft. and in)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 50);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 5;
            label3.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 0);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 4;
            label2.Text = "Personal info";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(cmbActivityLevel);
            groupBox4.Controls.Add(label7);
            groupBox4.Location = new Point(821, 62);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(302, 87);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "groupBox4";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 27);
            label11.Name = "label11";
            label11.Size = new Size(93, 20);
            label11.TabIndex = 14;
            label11.Text = "Activity level";
            // 
            // cmbActivityLevel
            // 
            cmbActivityLevel.FormattingEnabled = true;
            cmbActivityLevel.Location = new Point(135, 24);
            cmbActivityLevel.Name = "cmbActivityLevel";
            cmbActivityLevel.Size = new Size(151, 28);
            cmbActivityLevel.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 0);
            label7.Name = "label7";
            label7.Size = new Size(82, 20);
            label7.TabIndex = 9;
            label7.Text = "Other Data";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rbtnMale);
            groupBox3.Controls.Add(rbtnFemale);
            groupBox3.Controls.Add(label6);
            groupBox3.Location = new Point(649, 62);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(118, 87);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            // 
            // rbtnMale
            // 
            rbtnMale.AutoSize = true;
            rbtnMale.Location = new Point(6, 51);
            rbtnMale.Name = "rbtnMale";
            rbtnMale.Size = new Size(63, 24);
            rbtnMale.TabIndex = 10;
            rbtnMale.TabStop = true;
            rbtnMale.Text = "Male";
            rbtnMale.UseVisualStyleBackColor = true;
            // 
            // rbtnFemale
            // 
            rbtnFemale.AutoSize = true;
            rbtnFemale.Location = new Point(6, 23);
            rbtnFemale.Name = "rbtnFemale";
            rbtnFemale.Size = new Size(78, 24);
            rbtnFemale.TabIndex = 9;
            rbtnFemale.TabStop = true;
            rbtnFemale.Text = "Female";
            rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 0);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 8;
            label6.Text = "Gender";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(6, 0);
            label1.Name = "label1";
            label1.Size = new Size(138, 20);
            label1.TabIndex = 0;
            label1.Text = "Daily Water Intake";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1843, 684);
            Controls.Add(groupBox1);
            Name = "MainForm";
            Text = "Daily Water Intake Calculator";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnCalculate; // Corrected button name
        private System.Windows.Forms.RadioButton rbtnImperial;
        private System.Windows.Forms.RadioButton rbtnMetric;
        private System.Windows.Forms.Label lblWaterIntake;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbActivityLevel;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.Label lblGlasses;
    }
}
