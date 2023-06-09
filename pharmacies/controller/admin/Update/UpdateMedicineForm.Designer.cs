﻿namespace pharmacies.controller.admin.Update
{
    partial class UpdateMedicineForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contraindications = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.methodOfConsumption = new System.Windows.Forms.ComboBox();
            this.typeOfPackaging = new System.Windows.Forms.ComboBox();
            this.bestBeforeDate = new System.Windows.Forms.DateTimePicker();
            this.cost = new System.Windows.Forms.TextBox();
            this.firmBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addMedicins = new System.Windows.Forms.Button();
            this.PharmacyList = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.medicineBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.contraindications);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.methodOfConsumption);
            this.groupBox1.Controls.Add(this.typeOfPackaging);
            this.groupBox1.Controls.Add(this.bestBeforeDate);
            this.groupBox1.Controls.Add(this.cost);
            this.groupBox1.Controls.Add(this.firmBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.addMedicins);
            this.groupBox1.Controls.Add(this.PharmacyList);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.save);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 276);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Введите данные";
            // 
            // contraindications
            // 
            this.contraindications.Location = new System.Drawing.Point(121, 122);
            this.contraindications.Name = "contraindications";
            this.contraindications.Size = new System.Drawing.Size(107, 20);
            this.contraindications.TabIndex = 23;
            this.contraindications.TextChanged += new System.EventHandler(this.contraindications_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Противопоказания";
            // 
            // methodOfConsumption
            // 
            this.methodOfConsumption.FormattingEnabled = true;
            this.methodOfConsumption.Location = new System.Drawing.Point(122, 66);
            this.methodOfConsumption.Name = "methodOfConsumption";
            this.methodOfConsumption.Size = new System.Drawing.Size(106, 21);
            this.methodOfConsumption.TabIndex = 21;
            this.methodOfConsumption.SelectedIndexChanged += new System.EventHandler(this.methodOfConsumption_SelectedIndexChanged);
            // 
            // typeOfPackaging
            // 
            this.typeOfPackaging.FormattingEnabled = true;
            this.typeOfPackaging.Location = new System.Drawing.Point(122, 36);
            this.typeOfPackaging.Name = "typeOfPackaging";
            this.typeOfPackaging.Size = new System.Drawing.Size(106, 21);
            this.typeOfPackaging.TabIndex = 20;
            this.typeOfPackaging.SelectedIndexChanged += new System.EventHandler(this.typeOfPackaging_SelectedIndexChanged);
            // 
            // bestBeforeDate
            // 
            this.bestBeforeDate.Location = new System.Drawing.Point(121, 174);
            this.bestBeforeDate.Name = "bestBeforeDate";
            this.bestBeforeDate.Size = new System.Drawing.Size(107, 20);
            this.bestBeforeDate.TabIndex = 19;
            this.bestBeforeDate.ValueChanged += new System.EventHandler(this.bestBeforeDate_ValueChanged);
            // 
            // cost
            // 
            this.cost.Location = new System.Drawing.Point(121, 91);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(107, 20);
            this.cost.TabIndex = 17;
            this.cost.TextChanged += new System.EventHandler(this.cost_TextChanged);
            this.cost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cost_KeyPress);
            // 
            // firmBox
            // 
            this.firmBox.FormattingEnabled = true;
            this.firmBox.Location = new System.Drawing.Point(122, 148);
            this.firmBox.Name = "firmBox";
            this.firmBox.Size = new System.Drawing.Size(106, 21);
            this.firmBox.TabIndex = 12;
            this.firmBox.SelectedIndexChanged += new System.EventHandler(this.firmBox_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Фирма";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(234, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Аптеки";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Стоимость";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Срок годности";
            // 
            // addMedicins
            // 
            this.addMedicins.Location = new System.Drawing.Point(283, 97);
            this.addMedicins.Name = "addMedicins";
            this.addMedicins.Size = new System.Drawing.Size(107, 23);
            this.addMedicins.TabIndex = 4;
            this.addMedicins.Text = "Добавить";
            this.addMedicins.UseVisualStyleBackColor = true;
            this.addMedicins.Click += new System.EventHandler(this.addMedicins_Click);
            // 
            // PharmacyList
            // 
            this.PharmacyList.FormattingEnabled = true;
            this.PharmacyList.Location = new System.Drawing.Point(283, 10);
            this.PharmacyList.Name = "PharmacyList";
            this.PharmacyList.Size = new System.Drawing.Size(107, 82);
            this.PharmacyList.TabIndex = 2;
            this.PharmacyList.SelectedIndexChanged += new System.EventHandler(this.PharmacyList_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Способ применения";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(9, 221);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(381, 32);
            this.save.TabIndex = 5;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Тип упаковки";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(121, 10);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(107, 20);
            this.name.TabIndex = 1;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Наименование";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(133, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Лекарство";
            // 
            // medicineBox
            // 
            this.medicineBox.FormattingEnabled = true;
            this.medicineBox.Location = new System.Drawing.Point(139, 43);
            this.medicineBox.Name = "medicineBox";
            this.medicineBox.Size = new System.Drawing.Size(121, 21);
            this.medicineBox.TabIndex = 10;
            this.medicineBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.medicineBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Выбирите лекарство";
            // 
            // UpdateMedicineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 380);
            this.Controls.Add(this.medicineBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "UpdateMedicineForm";
            this.Text = "UpdateMedicineForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox contraindications;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox methodOfConsumption;
        private System.Windows.Forms.ComboBox typeOfPackaging;
        private System.Windows.Forms.DateTimePicker bestBeforeDate;
        private System.Windows.Forms.TextBox cost;
        private System.Windows.Forms.ComboBox firmBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addMedicins;
        private System.Windows.Forms.ListBox PharmacyList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox medicineBox;
        private System.Windows.Forms.Label label10;
    }
}