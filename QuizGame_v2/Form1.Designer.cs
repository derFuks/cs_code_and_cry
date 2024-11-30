namespace QuizGame_v2
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnOption1 = new System.Windows.Forms.Button();
            this.btnOption2 = new System.Windows.Forms.Button();
            this.btnOption3 = new System.Windows.Forms.Button();
            this.btnOption4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblQuestion.Location = new System.Drawing.Point(12, 9);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(277, 24);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Text of the question will be here";
            // 
            // btnOption1
            // 
            this.btnOption1.Location = new System.Drawing.Point(16, 105);
            this.btnOption1.Name = "btnOption1";
            this.btnOption1.Size = new System.Drawing.Size(75, 23);
            this.btnOption1.TabIndex = 1;
            this.btnOption1.Text = "Option 1";
            this.btnOption1.UseVisualStyleBackColor = true;
            // 
            // btnOption2
            // 
            this.btnOption2.Location = new System.Drawing.Point(16, 134);
            this.btnOption2.Name = "btnOption2";
            this.btnOption2.Size = new System.Drawing.Size(75, 23);
            this.btnOption2.TabIndex = 2;
            this.btnOption2.Text = "Option 2";
            this.btnOption2.UseVisualStyleBackColor = true;
            // 
            // btnOption3
            // 
            this.btnOption3.Location = new System.Drawing.Point(16, 163);
            this.btnOption3.Name = "btnOption3";
            this.btnOption3.Size = new System.Drawing.Size(75, 23);
            this.btnOption3.TabIndex = 3;
            this.btnOption3.Text = "Option 3";
            this.btnOption3.UseVisualStyleBackColor = true;
            // 
            // btnOption4
            // 
            this.btnOption4.Location = new System.Drawing.Point(16, 192);
            this.btnOption4.Name = "btnOption4";
            this.btnOption4.Size = new System.Drawing.Size(75, 23);
            this.btnOption4.TabIndex = 4;
            this.btnOption4.Text = "Option 4";
            this.btnOption4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOption4);
            this.Controls.Add(this.btnOption3);
            this.Controls.Add(this.btnOption2);
            this.Controls.Add(this.btnOption1);
            this.Controls.Add(this.lblQuestion);
            this.Name = "Form1";
            this.Text = "Quiz Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnOption1;
        private System.Windows.Forms.Button btnOption2;
        private System.Windows.Forms.Button btnOption3;
        private System.Windows.Forms.Button btnOption4;
    }
}

