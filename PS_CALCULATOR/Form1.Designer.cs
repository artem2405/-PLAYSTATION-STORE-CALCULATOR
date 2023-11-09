namespace PS_CALCULATOR
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lira_price = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ruble_price = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lira_price
            // 
            this.lira_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lira_price.Location = new System.Drawing.Point(17, 68);
            this.lira_price.Name = "lira_price";
            this.lira_price.Size = new System.Drawing.Size(247, 30);
            this.lira_price.TabIndex = 0;
            this.lira_price.TextChanged += new System.EventHandler(this.lira_price_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(526, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "ВВЕДИТЕ ЦЕНУ ИГРЫ В ЛИРАХ: ";
            // 
            // ruble_price
            // 
            this.ruble_price.Enabled = false;
            this.ruble_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ruble_price.Location = new System.Drawing.Point(17, 216);
            this.ruble_price.Name = "ruble_price";
            this.ruble_price.Size = new System.Drawing.Size(247, 30);
            this.ruble_price.TabIndex = 2;
            this.ruble_price.TextChanged += new System.EventHandler(this.ruble_price_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "ЦЕНА В РУБЛЯХ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(309, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(374, 375);
            this.label3.TabIndex = 4;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(732, 473);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ruble_price);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lira_price);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(750, 520);
            this.MinimumSize = new System.Drawing.Size(750, 520);
            this.Name = "MainForm";
            this.Text = "PS STORE CALCULATOR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lira_price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ruble_price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

