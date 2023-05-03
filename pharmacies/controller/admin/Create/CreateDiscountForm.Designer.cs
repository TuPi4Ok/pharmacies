namespace pharmacies.controller.admin.Create
{
    partial class CreateDiscountForm
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
            this.medicineBox = new System.Windows.Forms.ComboBox();
            this.procent = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.medicineBox);
            this.groupBox1.Controls.Add(this.procent);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.save);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(14, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 129);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Введите данные";
            // 
            // medicineBox
            // 
            this.medicineBox.FormattingEnabled = true;
            this.medicineBox.Location = new System.Drawing.Point(104, 18);
            this.medicineBox.Name = "medicineBox";
            this.medicineBox.Size = new System.Drawing.Size(121, 21);
            this.medicineBox.TabIndex = 8;
            this.medicineBox.SelectedIndexChanged += new System.EventHandler(this.medicineBox_SelectedIndexChanged);
            this.medicineBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.medicineBox_KeyPress);
            // 
            // procent
            // 
            this.procent.Location = new System.Drawing.Point(104, 45);
            this.procent.Name = "procent";
            this.procent.Size = new System.Drawing.Size(121, 20);
            this.procent.TabIndex = 7;
            this.procent.TextChanged += new System.EventHandler(this.procent_TextChanged);
            this.procent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.procent_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Лекарство";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(9, 80);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(216, 32);
            this.save.TabIndex = 5;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Процент";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(73, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Скидка";
            // 
            // CreateDiscountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 188);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "CreateDiscountForm";
            this.Text = "CreateDiscountForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox procent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox medicineBox;
    }
}