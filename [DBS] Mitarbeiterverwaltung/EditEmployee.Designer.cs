namespace _DBS__Mitarbeiterverwaltung
{
    partial class EditEmployee
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
            this.btn_save = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ClearInput = new System.Windows.Forms.Button();
            this.cBox_covid = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radBtn_female = new System.Windows.Forms.RadioButton();
            this.radBtn_male = new System.Windows.Forms.RadioButton();
            this.radBtn_other = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tBox_salary = new System.Windows.Forms.TextBox();
            this.tBox_name = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(285, 213);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(244, 35);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_ClearInput);
            this.groupBox1.Controls.Add(this.cBox_covid);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tBox_salary);
            this.groupBox1.Controls.Add(this.tBox_name);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 195);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee";
            // 
            // btn_ClearInput
            // 
            this.btn_ClearInput.Location = new System.Drawing.Point(10, 146);
            this.btn_ClearInput.Name = "btn_ClearInput";
            this.btn_ClearInput.Size = new System.Drawing.Size(244, 35);
            this.btn_ClearInput.TabIndex = 6;
            this.btn_ClearInput.Text = "Clear";
            this.btn_ClearInput.UseVisualStyleBackColor = true;
            // 
            // cBox_covid
            // 
            this.cBox_covid.AutoSize = true;
            this.cBox_covid.Location = new System.Drawing.Point(260, 152);
            this.cBox_covid.Name = "cBox_covid";
            this.cBox_covid.Size = new System.Drawing.Size(124, 24);
            this.cBox_covid.TabIndex = 5;
            this.cBox_covid.Text = "Covid Bonus";
            this.cBox_covid.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radBtn_female);
            this.groupBox2.Controls.Add(this.radBtn_male);
            this.groupBox2.Controls.Add(this.radBtn_other);
            this.groupBox2.Location = new System.Drawing.Point(260, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 115);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sex";
            // 
            // radBtn_female
            // 
            this.radBtn_female.AutoSize = true;
            this.radBtn_female.Location = new System.Drawing.Point(6, 55);
            this.radBtn_female.Name = "radBtn_female";
            this.radBtn_female.Size = new System.Drawing.Size(87, 24);
            this.radBtn_female.TabIndex = 3;
            this.radBtn_female.TabStop = true;
            this.radBtn_female.Text = "Female";
            this.radBtn_female.UseVisualStyleBackColor = true;
            // 
            // radBtn_male
            // 
            this.radBtn_male.AutoSize = true;
            this.radBtn_male.Location = new System.Drawing.Point(6, 25);
            this.radBtn_male.Name = "radBtn_male";
            this.radBtn_male.Size = new System.Drawing.Size(68, 24);
            this.radBtn_male.TabIndex = 2;
            this.radBtn_male.TabStop = true;
            this.radBtn_male.Text = "Male";
            this.radBtn_male.UseVisualStyleBackColor = true;
            // 
            // radBtn_other
            // 
            this.radBtn_other.AutoSize = true;
            this.radBtn_other.Location = new System.Drawing.Point(6, 85);
            this.radBtn_other.Name = "radBtn_other";
            this.radBtn_other.Size = new System.Drawing.Size(74, 24);
            this.radBtn_other.TabIndex = 4;
            this.radBtn_other.TabStop = true;
            this.radBtn_other.Text = "Other";
            this.radBtn_other.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salary:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // tBox_salary
            // 
            this.tBox_salary.Location = new System.Drawing.Point(10, 106);
            this.tBox_salary.Name = "tBox_salary";
            this.tBox_salary.Size = new System.Drawing.Size(244, 26);
            this.tBox_salary.TabIndex = 1;
            // 
            // tBox_name
            // 
            this.tBox_name.Location = new System.Drawing.Point(10, 54);
            this.tBox_name.Name = "tBox_name";
            this.tBox_name.Size = new System.Drawing.Size(244, 26);
            this.tBox_name.TabIndex = 0;
            // 
            // EditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 257);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.groupBox1);
            this.Name = "EditEmployee";
            this.Text = "EditEmployee";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ClearInput;
        private System.Windows.Forms.CheckBox cBox_covid;
        private System.Windows.Forms.RadioButton radBtn_other;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radBtn_female;
        private System.Windows.Forms.RadioButton radBtn_male;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBox_salary;
        private System.Windows.Forms.TextBox tBox_name;
    }
}