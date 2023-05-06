namespace pharmacies.controller.pharmacist
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
            this.label1 = new System.Windows.Forms.Label();
            this.medicineBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.WhereCanBuyCost = new System.Windows.Forms.Button();
            this.WhereCanBuy = new System.Windows.Forms.Button();
            this.wellcome = new System.Windows.Forms.Label();
            this.PostingThisMonth = new System.Windows.Forms.Button();
            this.firmButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pharmacyBox = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.firmBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Выбирите лекарство";
            // 
            // medicineBox
            // 
            this.medicineBox.FormattingEnabled = true;
            this.medicineBox.Location = new System.Drawing.Point(131, 47);
            this.medicineBox.Name = "medicineBox";
            this.medicineBox.Size = new System.Drawing.Size(165, 21);
            this.medicineBox.TabIndex = 7;
            this.medicineBox.SelectedIndexChanged += new System.EventHandler(this.medicineBox_SelectedIndexChanged);
            this.medicineBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.medicineBox_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.WhereCanBuyCost);
            this.groupBox1.Controls.Add(this.WhereCanBuy);
            this.groupBox1.Location = new System.Drawing.Point(15, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 127);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбирите действие";
            // 
            // WhereCanBuyCost
            // 
            this.WhereCanBuyCost.Location = new System.Drawing.Point(7, 70);
            this.WhereCanBuyCost.Name = "WhereCanBuyCost";
            this.WhereCanBuyCost.Size = new System.Drawing.Size(268, 44);
            this.WhereCanBuyCost.TabIndex = 1;
            this.WhereCanBuyCost.Text = "По названию лекарства информацию о том, где можно купить данное лекарство дешевле" +
    "";
            this.WhereCanBuyCost.UseVisualStyleBackColor = true;
            this.WhereCanBuyCost.Click += new System.EventHandler(this.WhereCanBuyCost_Click);
            // 
            // WhereCanBuy
            // 
            this.WhereCanBuy.Location = new System.Drawing.Point(7, 20);
            this.WhereCanBuy.Name = "WhereCanBuy";
            this.WhereCanBuy.Size = new System.Drawing.Size(268, 44);
            this.WhereCanBuy.TabIndex = 0;
            this.WhereCanBuy.Text = "По названию лекарства определить, где его можно купить";
            this.WhereCanBuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.WhereCanBuy.UseVisualStyleBackColor = true;
            this.WhereCanBuy.Click += new System.EventHandler(this.WhereCanBuy_Click);
            // 
            // wellcome
            // 
            this.wellcome.AutoSize = true;
            this.wellcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wellcome.ForeColor = System.Drawing.Color.Blue;
            this.wellcome.Location = new System.Drawing.Point(58, 9);
            this.wellcome.Name = "wellcome";
            this.wellcome.Size = new System.Drawing.Size(287, 33);
            this.wellcome.TabIndex = 5;
            this.wellcome.Text = "Добро пожаловать";
            // 
            // PostingThisMonth
            // 
            this.PostingThisMonth.Location = new System.Drawing.Point(7, 20);
            this.PostingThisMonth.Name = "PostingThisMonth";
            this.PostingThisMonth.Size = new System.Drawing.Size(275, 44);
            this.PostingThisMonth.TabIndex = 2;
            this.PostingThisMonth.Text = "Какие лекарства определённой аптеки подлежат списанию в данном месяце";
            this.PostingThisMonth.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.PostingThisMonth.UseVisualStyleBackColor = true;
            this.PostingThisMonth.Click += new System.EventHandler(this.PostingThisMonth_Click);
            // 
            // firmButton
            // 
            this.firmButton.Location = new System.Drawing.Point(7, 19);
            this.firmButton.Name = "firmButton";
            this.firmButton.Size = new System.Drawing.Size(268, 44);
            this.firmButton.TabIndex = 3;
            this.firmButton.Text = "По изготовителю перечень лекарств, находящихся в данной аптеке";
            this.firmButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.firmButton.UseVisualStyleBackColor = true;
            this.firmButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.firmBox);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.PostingThisMonth);
            this.groupBox2.Location = new System.Drawing.Point(302, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 171);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выбирите действие";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Выбирите аптеку";
            // 
            // pharmacyBox
            // 
            this.pharmacyBox.FormattingEnabled = true;
            this.pharmacyBox.Location = new System.Drawing.Point(402, 47);
            this.pharmacyBox.Name = "pharmacyBox";
            this.pharmacyBox.Size = new System.Drawing.Size(175, 21);
            this.pharmacyBox.TabIndex = 9;
            this.pharmacyBox.SelectedIndexChanged += new System.EventHandler(this.pharmacyBox_SelectedIndexChanged);
            this.pharmacyBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pharmacyBox_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.firmButton);
            this.groupBox3.Location = new System.Drawing.Point(7, 93);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(281, 71);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Выбирите действие";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Выбирите фирму";
            // 
            // firmBox
            // 
            this.firmBox.FormattingEnabled = true;
            this.firmBox.Location = new System.Drawing.Point(106, 69);
            this.firmBox.Name = "firmBox";
            this.firmBox.Size = new System.Drawing.Size(176, 21);
            this.firmBox.TabIndex = 11;
            this.firmBox.SelectedIndexChanged += new System.EventHandler(this.firmBox_SelectedIndexChanged);
            this.firmBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firmBox_KeyPress);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 399);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pharmacyBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.medicineBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.wellcome);
            this.Name = "StartForm";
            this.Text = "StartForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StartForm_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox medicineBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button WhereCanBuyCost;
        private System.Windows.Forms.Button WhereCanBuy;
        private System.Windows.Forms.Label wellcome;
        private System.Windows.Forms.Button firmButton;
        private System.Windows.Forms.Button PostingThisMonth;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox pharmacyBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox firmBox;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}