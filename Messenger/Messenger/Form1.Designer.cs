namespace Messenger
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
            this.tb_Post = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_Subject = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_Post
            // 
            this.tb_Post.Location = new System.Drawing.Point(22, 89);
            this.tb_Post.Multiline = true;
            this.tb_Post.Name = "tb_Post";
            this.tb_Post.Size = new System.Drawing.Size(526, 315);
            this.tb_Post.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(285, 58);
            this.button1.TabIndex = 1;
            this.button1.Text = "Опубликовать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_Subject
            // 
            this.tb_Subject.Location = new System.Drawing.Point(22, 30);
            this.tb_Subject.Name = "tb_Subject";
            this.tb_Subject.Size = new System.Drawing.Size(526, 22);
            this.tb_Subject.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 525);
            this.Controls.Add(this.tb_Subject);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_Post);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Post;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_Subject;
    }
}

