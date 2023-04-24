namespace pharmacies.controller.admin.Create
{
    partial class CreatePharmacyForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.save = new System.Windows.Forms.Button();
            this.addMedicins = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.medicinesList = new System.Windows.Forms.ListBox();
            this.address = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(52, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Аптека";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.save);
            this.groupBox1.Controls.Add(this.addMedicins);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.medicinesList);
            this.groupBox1.Controls.Add(this.address);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 202);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Введите данные";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(6, 164);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(181, 32);
            this.save.TabIndex = 5;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // addMedicins
            // 
            this.addMedicins.Location = new System.Drawing.Point(74, 135);
            this.addMedicins.Name = "addMedicins";
            this.addMedicins.Size = new System.Drawing.Size(107, 23);
            this.addMedicins.TabIndex = 4;
            this.addMedicins.Text = "Добавить";
            this.addMedicins.UseVisualStyleBackColor = true;
            this.addMedicins.Click += new System.EventHandler(this.addMedicins_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Лекарства";
            // 
            // medicinesList
            // 
            this.medicinesList.FormattingEnabled = true;
            this.medicinesList.Location = new System.Drawing.Point(74, 46);
            this.medicinesList.Name = "medicinesList";
            this.medicinesList.Size = new System.Drawing.Size(107, 82);
            this.medicinesList.TabIndex = 2;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(74, 16);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(107, 20);
            this.address.TabIndex = 1;
            this.address.TextChanged += new System.EventHandler(this.address_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Адрес";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // CreatePharmacyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 265);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "CreatePharmacyForm";
            this.Text = "CreatePharmacyForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.ListBox medicinesList;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button addMedicins;
        private System.Windows.Forms.Label label3;
    }
}