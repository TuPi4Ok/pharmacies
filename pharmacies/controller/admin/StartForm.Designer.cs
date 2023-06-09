﻿namespace pharmacies.controller.admin
{
    partial class StartForm
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
            this.wellcome = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Read = new System.Windows.Forms.Button();
            this.Create = new System.Windows.Forms.Button();
            this.table = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // wellcome
            // 
            this.wellcome.AutoSize = true;
            this.wellcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wellcome.ForeColor = System.Drawing.Color.Blue;
            this.wellcome.Location = new System.Drawing.Point(77, 9);
            this.wellcome.Name = "wellcome";
            this.wellcome.Size = new System.Drawing.Size(287, 33);
            this.wellcome.TabIndex = 0;
            this.wellcome.Text = "Добро пожаловать";
            this.wellcome.Click += new System.EventHandler(this.wellcome_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Delete);
            this.groupBox1.Controls.Add(this.Update);
            this.groupBox1.Controls.Add(this.Read);
            this.groupBox1.Controls.Add(this.Create);
            this.groupBox1.Location = new System.Drawing.Point(91, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 177);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите что вы хотите сделать";
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(6, 133);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(248, 32);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "Удалить запись";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(5, 95);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(248, 32);
            this.Update.TabIndex = 2;
            this.Update.Text = "Изменить запись";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Read
            // 
            this.Read.Location = new System.Drawing.Point(6, 57);
            this.Read.Name = "Read";
            this.Read.Size = new System.Drawing.Size(248, 32);
            this.Read.TabIndex = 1;
            this.Read.Text = "Просмотреть записи";
            this.Read.UseVisualStyleBackColor = true;
            this.Read.Click += new System.EventHandler(this.Read_Click);
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(6, 19);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(248, 32);
            this.Create.TabIndex = 0;
            this.Create.Text = "Создать запись";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // table
            // 
            this.table.FormattingEnabled = true;
            this.table.Location = new System.Drawing.Point(97, 65);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(243, 21);
            this.table.TabIndex = 5;
            this.table.SelectedIndexChanged += new System.EventHandler(this.table_SelectedIndexChanged);
            this.table.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.table_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Выберите таблицу";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 355);
            this.Controls.Add(this.table);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wellcome);
            this.Name = "StartForm";
            this.Text = "StartForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StartForm_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label wellcome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Read;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.ComboBox table;
        private System.Windows.Forms.Label label1;
    }
}