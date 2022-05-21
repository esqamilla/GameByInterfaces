
namespace GameByInterfaces
{
    partial class Parent
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
            this.testBtn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // testBtn1
            // 
            this.testBtn1.Location = new System.Drawing.Point(706, 43);
            this.testBtn1.Name = "testBtn1";
            this.testBtn1.Size = new System.Drawing.Size(127, 48);
            this.testBtn1.TabIndex = 1;
            this.testBtn1.Text = "Открытие формы игры";
            this.testBtn1.UseVisualStyleBackColor = true;
            this.testBtn1.Click += new System.EventHandler(this.testBtn1_Click);
            // 
            // Parent
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 501);
            this.Controls.Add(this.testBtn1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(900, 540);
            this.Name = "Parent";
            this.Text = "Игра по интерфейсам";
            this.Load += new System.EventHandler(this.Parent_Load);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Button testBtn1;
    }
}



