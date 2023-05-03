namespace pharmacies.controller.admin.Create
{
    partial class CreateFirmForm
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
            this.name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.telefonNumber = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.telefonNumber);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.save);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.address);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 141);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Введите данные";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(105, 19);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(107, 20);
            this.name.TabIndex = 7;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Наименование";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(9, 97);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(203, 32);
            this.save.TabIndex = 5;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Номер телефона";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(105, 45);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(107, 20);
            this.address.TabIndex = 1;
            this.address.TextChanged += new System.EventHandler(this.address_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Адрес";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(63, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Фирма";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // telefonNumber
            // 
            this.telefonNumber.Location = new System.Drawing.Point(105, 71);
            this.telefonNumber.Name = "telefonNumber";
            this.telefonNumber.Size = new System.Drawing.Size(107, 20);
            this.telefonNumber.TabIndex = 8;
            this.telefonNumber.TextChanged += new System.EventHandler(this.telefonNumber_TextChanged);
            this.telefonNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telefonNumber_KeyPress);
            // 
            // CreateFirmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 189);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "CreateFirmForm";
            this.Text = "CreateFirmForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox telefonNumber;
    }
}