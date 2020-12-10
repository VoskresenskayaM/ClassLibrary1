namespace WindowsFormsApp1
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnSerialze = new System.Windows.Forms.Button();
            this.btnDeserialse = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(35, 312);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(107, 38);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(175, 309);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(112, 41);
            this.btnSort.TabIndex = 1;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnSerialze
            // 
            this.btnSerialze.Location = new System.Drawing.Point(330, 309);
            this.btnSerialze.Name = "btnSerialze";
            this.btnSerialze.Size = new System.Drawing.Size(105, 41);
            this.btnSerialze.TabIndex = 2;
            this.btnSerialze.Text = "Serialse";
            this.btnSerialze.UseVisualStyleBackColor = true;
            this.btnSerialze.Click += new System.EventHandler(this.btnSerialze_Click);
            // 
            // btnDeserialse
            // 
            this.btnDeserialse.Location = new System.Drawing.Point(476, 307);
            this.btnDeserialse.Name = "btnDeserialse";
            this.btnDeserialse.Size = new System.Drawing.Size(116, 42);
            this.btnDeserialse.TabIndex = 3;
            this.btnDeserialse.Text = "Deserialse";
            this.btnDeserialse.UseVisualStyleBackColor = true;
            this.btnDeserialse.Click += new System.EventHandler(this.btnDeserialse_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(35, 40);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(557, 199);
            this.listBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 392);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnDeserialse);
            this.Controls.Add(this.btnSerialze);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnCreate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnSerialze;
        private System.Windows.Forms.Button btnDeserialse;
        private System.Windows.Forms.ListBox listBox1;
    }
}

