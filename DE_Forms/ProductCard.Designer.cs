namespace DE_Forms
{
    partial class ProductCard
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NameAndCategoryProduct_label = new System.Windows.Forms.Label();
            this.discount_label = new System.Windows.Forms.Label();
            this.descriptioinProduct_label = new System.Windows.Forms.Label();
            this.manufacturer_label = new System.Windows.Forms.Label();
            this.supplier_label = new System.Windows.Forms.Label();
            this.price_label = new System.Windows.Forms.Label();
            this.unit_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 155);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // NameAndCategoryProduct_label
            // 
            this.NameAndCategoryProduct_label.AutoSize = true;
            this.NameAndCategoryProduct_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameAndCategoryProduct_label.Location = new System.Drawing.Point(161, 4);
            this.NameAndCategoryProduct_label.Name = "NameAndCategoryProduct_label";
            this.NameAndCategoryProduct_label.Size = new System.Drawing.Size(311, 19);
            this.NameAndCategoryProduct_label.TabIndex = 1;
            this.NameAndCategoryProduct_label.Text = "Категория товара | Наименование товара";
            // 
            // discount_label
            // 
            this.discount_label.AutoSize = true;
            this.discount_label.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.discount_label.Location = new System.Drawing.Point(39, 68);
            this.discount_label.Name = "discount_label";
            this.discount_label.Size = new System.Drawing.Size(28, 31);
            this.discount_label.TabIndex = 3;
            this.discount_label.Text = "0";
            // 
            // descriptioinProduct_label
            // 
            this.descriptioinProduct_label.CausesValidation = false;
            this.descriptioinProduct_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptioinProduct_label.Location = new System.Drawing.Point(161, 23);
            this.descriptioinProduct_label.Name = "descriptioinProduct_label";
            this.descriptioinProduct_label.Size = new System.Drawing.Size(352, 38);
            this.descriptioinProduct_label.TabIndex = 4;
            this.descriptioinProduct_label.Text = "Описание товара:";
            // 
            // manufacturer_label
            // 
            this.manufacturer_label.CausesValidation = false;
            this.manufacturer_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.manufacturer_label.Location = new System.Drawing.Point(161, 60);
            this.manufacturer_label.Name = "manufacturer_label";
            this.manufacturer_label.Size = new System.Drawing.Size(352, 21);
            this.manufacturer_label.TabIndex = 5;
            this.manufacturer_label.Text = "Производитель:";
            // 
            // supplier_label
            // 
            this.supplier_label.CausesValidation = false;
            this.supplier_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.supplier_label.Location = new System.Drawing.Point(161, 80);
            this.supplier_label.Name = "supplier_label";
            this.supplier_label.Size = new System.Drawing.Size(352, 21);
            this.supplier_label.TabIndex = 6;
            this.supplier_label.Text = "Поставщик:";
            // 
            // price_label
            // 
            this.price_label.CausesValidation = false;
            this.price_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.price_label.Location = new System.Drawing.Point(161, 101);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(352, 21);
            this.price_label.TabIndex = 7;
            this.price_label.Text = "Цена:";
            // 
            // unit_label
            // 
            this.unit_label.CausesValidation = false;
            this.unit_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.unit_label.Location = new System.Drawing.Point(161, 121);
            this.unit_label.Name = "unit_label";
            this.unit_label.Size = new System.Drawing.Size(352, 21);
            this.unit_label.TabIndex = 8;
            this.unit_label.Text = "Единица измерения:";
            // 
            // label1
            // 
            this.label1.CausesValidation = false;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(161, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Количество на складе:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.discount_label);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox1.Location = new System.Drawing.Point(516, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(101, 161);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // ProductCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.unit_label);
            this.Controls.Add(this.price_label);
            this.Controls.Add(this.supplier_label);
            this.Controls.Add(this.manufacturer_label);
            this.Controls.Add(this.descriptioinProduct_label);
            this.Controls.Add(this.NameAndCategoryProduct_label);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ProductCard";
            this.Size = new System.Drawing.Size(620, 163);
            this.Load += new System.EventHandler(this.ProductCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label NameAndCategoryProduct_label;
        private System.Windows.Forms.Label discount_label;
        private System.Windows.Forms.Label descriptioinProduct_label;
        private System.Windows.Forms.Label manufacturer_label;
        private System.Windows.Forms.Label supplier_label;
        private System.Windows.Forms.Label price_label;
        private System.Windows.Forms.Label unit_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
