namespace CursorPosition
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
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.anchorBox = new System.Windows.Forms.TextBox();
            this.hideBackgroundButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxX
            // 
            this.textBoxX.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxX.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxX.Location = new System.Drawing.Point(0, 20);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.ReadOnly = true;
            this.textBoxX.Size = new System.Drawing.Size(50, 20);
            this.textBoxX.TabIndex = 0;
            this.textBoxX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxY
            // 
            this.textBoxY.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxY.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxY.Location = new System.Drawing.Point(50, 20);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.ReadOnly = true;
            this.textBoxY.Size = new System.Drawing.Size(50, 20);
            this.textBoxY.TabIndex = 1;
            this.textBoxY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // anchorBox
            // 
            this.anchorBox.BackColor = System.Drawing.SystemColors.Info;
            this.anchorBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.anchorBox.Location = new System.Drawing.Point(0, 0);
            this.anchorBox.Name = "anchorBox";
            this.anchorBox.ReadOnly = true;
            this.anchorBox.Size = new System.Drawing.Size(100, 20);
            this.anchorBox.TabIndex = 3;
            this.anchorBox.Text = "anchor 0 0";
            this.anchorBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hideBackgroundButton
            // 
            this.hideBackgroundButton.Location = new System.Drawing.Point(100, 0);
            this.hideBackgroundButton.Name = "hideBackgroundButton";
            this.hideBackgroundButton.Size = new System.Drawing.Size(75, 40);
            this.hideBackgroundButton.TabIndex = 5;
            this.hideBackgroundButton.Text = "Hide background";
            this.hideBackgroundButton.UseVisualStyleBackColor = true;
            this.hideBackgroundButton.Click += new System.EventHandler(this.HideBackground);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(179, 44);
            this.Controls.Add(this.hideBackgroundButton);
            this.Controls.Add(this.anchorBox);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxX);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.TextBox anchorBox;
        private System.Windows.Forms.Button hideBackgroundButton;
    }
}

