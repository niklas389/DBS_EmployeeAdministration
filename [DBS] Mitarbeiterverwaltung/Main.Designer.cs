namespace _DBS__Mitarbeiterverwaltung
{
    partial class Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
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
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_deleteItem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBox1.Size = new System.Drawing.Size(260, 385);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mitarbeiter";
            // 
            // btn_ClearInput
            // 
            this.btn_ClearInput.Location = new System.Drawing.Point(148, 344);
            this.btn_ClearInput.Name = "btn_ClearInput";
            this.btn_ClearInput.Size = new System.Drawing.Size(106, 35);
            this.btn_ClearInput.TabIndex = 0;
            this.btn_ClearInput.TabStop = false;
            this.btn_ClearInput.Text = "Clear";
            this.btn_ClearInput.UseVisualStyleBackColor = true;
            this.btn_ClearInput.Click += new System.EventHandler(this.btn_ClearInput_Click);
            // 
            // cBox_covid
            // 
            this.cBox_covid.AutoSize = true;
            this.cBox_covid.Location = new System.Drawing.Point(10, 270);
            this.cBox_covid.Name = "cBox_covid";
            this.cBox_covid.Size = new System.Drawing.Size(124, 24);
            this.cBox_covid.TabIndex = 3;
            this.cBox_covid.Text = "Covid Bonus";
            this.cBox_covid.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radBtn_female);
            this.groupBox2.Controls.Add(this.radBtn_male);
            this.groupBox2.Controls.Add(this.radBtn_other);
            this.groupBox2.Location = new System.Drawing.Point(10, 149);
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
            this.radBtn_female.TabIndex = 1;
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
            this.radBtn_male.TabIndex = 0;
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
            this.radBtn_other.TabIndex = 2;
            this.radBtn_other.TabStop = true;
            this.radBtn_other.Text = "Other";
            this.radBtn_other.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 94);
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
            this.tBox_salary.Location = new System.Drawing.Point(6, 117);
            this.tBox_salary.Name = "tBox_salary";
            this.tBox_salary.Size = new System.Drawing.Size(248, 26);
            this.tBox_salary.TabIndex = 1;
            // 
            // tBox_name
            // 
            this.tBox_name.Location = new System.Drawing.Point(6, 54);
            this.tBox_name.Name = "tBox_name";
            this.tBox_name.Size = new System.Drawing.Size(248, 26);
            this.tBox_name.TabIndex = 0;
            // 
            // btn_edit
            // 
            this.btn_edit.Enabled = false;
            this.btn_edit.Location = new System.Drawing.Point(278, 403);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(106, 35);
            this.btn_edit.TabIndex = 5;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(22, 403);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(244, 35);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.HotTracking = true;
            this.listView1.HoverSelection = true;
            this.listView1.Location = new System.Drawing.Point(278, 12);
            this.listView1.Name = "listView1";
            this.listView1.ShowGroups = false;
            this.listView1.Size = new System.Drawing.Size(540, 385);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Salary";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Sex";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Bonus";
            // 
            // btn_deleteItem
            // 
            this.btn_deleteItem.Enabled = false;
            this.btn_deleteItem.Location = new System.Drawing.Point(712, 403);
            this.btn_deleteItem.Name = "btn_deleteItem";
            this.btn_deleteItem.Size = new System.Drawing.Size(106, 35);
            this.btn_deleteItem.TabIndex = 6;
            this.btn_deleteItem.Text = "Remove";
            this.btn_deleteItem.UseVisualStyleBackColor = true;
            this.btn_deleteItem.Click += new System.EventHandler(this.btn_deleteItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 450);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_deleteItem);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radBtn_female;
        private System.Windows.Forms.RadioButton radBtn_male;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBox_salary;
        private System.Windows.Forms.TextBox tBox_name;
        private System.Windows.Forms.RadioButton radBtn_other;
        private System.Windows.Forms.CheckBox cBox_covid;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btn_ClearInput;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_deleteItem;
    }
}

