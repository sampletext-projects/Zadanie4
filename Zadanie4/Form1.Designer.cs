namespace Zadanie4
{
    partial class Form1
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
            this.textBoxD = new System.Windows.Forms.TextBox();
            this.buttonGetArea = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonConvertBase = new System.Windows.Forms.Button();
            this.textBoxVal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxD
            // 
            this.textBoxD.Location = new System.Drawing.Point(160, 16);
            this.textBoxD.Name = "textBoxD";
            this.textBoxD.Size = new System.Drawing.Size(100, 20);
            this.textBoxD.TabIndex = 0;
            // 
            // buttonGetArea
            // 
            this.buttonGetArea.Location = new System.Drawing.Point(96, 48);
            this.buttonGetArea.Name = "buttonGetArea";
            this.buttonGetArea.Size = new System.Drawing.Size(160, 23);
            this.buttonGetArea.TabIndex = 1;
            this.buttonGetArea.Text = "Рассчитать площадь";
            this.buttonGetArea.UseVisualStyleBackColor = true;
            this.buttonGetArea.Click += new System.EventHandler(this.buttonGetArea_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Диагональ шестиугольника";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Число в 8 с.с.";
            // 
            // buttonConvertBase
            // 
            this.buttonConvertBase.Location = new System.Drawing.Point(96, 160);
            this.buttonConvertBase.Name = "buttonConvertBase";
            this.buttonConvertBase.Size = new System.Drawing.Size(160, 23);
            this.buttonConvertBase.TabIndex = 4;
            this.buttonConvertBase.Text = "Перевести в 2 с.с.";
            this.buttonConvertBase.UseVisualStyleBackColor = true;
            this.buttonConvertBase.Click += new System.EventHandler(this.buttonConvertBase_Click);
            // 
            // textBoxVal
            // 
            this.textBoxVal.Location = new System.Drawing.Point(160, 128);
            this.textBoxVal.Name = "textBoxVal";
            this.textBoxVal.Size = new System.Drawing.Size(100, 20);
            this.textBoxVal.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 193);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonConvertBase);
            this.Controls.Add(this.textBoxVal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGetArea);
            this.Controls.Add(this.textBoxD);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxD;
        private System.Windows.Forms.Button buttonGetArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonConvertBase;
        private System.Windows.Forms.TextBox textBoxVal;
    }
}

