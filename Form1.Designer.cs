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
            this.anchorTextBox = new System.Windows.Forms.TextBox();
            this.hideBackgroundButton = new System.Windows.Forms.Button();
            this.colorBoxR = new System.Windows.Forms.TextBox();
            this.colorBoxG = new System.Windows.Forms.TextBox();
            this.colorBoxB = new System.Windows.Forms.TextBox();
            this.frozedIndicator = new System.Windows.Forms.TextBox();
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
            // anchorTextBox
            // 
            this.anchorTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.anchorTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.anchorTextBox.Location = new System.Drawing.Point(0, 0);
            this.anchorTextBox.Name = "anchorTextBox";
            this.anchorTextBox.ReadOnly = true;
            this.anchorTextBox.Size = new System.Drawing.Size(100, 20);
            this.anchorTextBox.TabIndex = 3;
            this.anchorTextBox.Text = "anchor 0 0";
            this.anchorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.anchorTextBox.Visible = false;
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
            // colorBoxR
            // 
            this.colorBoxR.BackColor = System.Drawing.SystemColors.Info;
            this.colorBoxR.Location = new System.Drawing.Point(0, 40);
            this.colorBoxR.Name = "colorBoxR";
            this.colorBoxR.ReadOnly = true;
            this.colorBoxR.Size = new System.Drawing.Size(33, 20);
            this.colorBoxR.TabIndex = 6;
            // 
            // colorBoxG
            // 
            this.colorBoxG.BackColor = System.Drawing.SystemColors.Info;
            this.colorBoxG.Location = new System.Drawing.Point(33, 40);
            this.colorBoxG.Name = "colorBoxG";
            this.colorBoxG.ReadOnly = true;
            this.colorBoxG.Size = new System.Drawing.Size(34, 20);
            this.colorBoxG.TabIndex = 7;
            // 
            // colorBoxB
            // 
            this.colorBoxB.BackColor = System.Drawing.SystemColors.Info;
            this.colorBoxB.Location = new System.Drawing.Point(67, 40);
            this.colorBoxB.Name = "colorBoxB";
            this.colorBoxB.ReadOnly = true;
            this.colorBoxB.Size = new System.Drawing.Size(33, 20);
            this.colorBoxB.TabIndex = 8;
            // 
            // frozedIndicator
            // 
            this.frozedIndicator.BackColor = System.Drawing.SystemColors.Info;
            this.frozedIndicator.Location = new System.Drawing.Point(100, 40);
            this.frozedIndicator.Name = "frozedIndicator";
            this.frozedIndicator.ReadOnly = true;
            this.frozedIndicator.Size = new System.Drawing.Size(75, 20);
            this.frozedIndicator.TabIndex = 9;
            this.frozedIndicator.Text = "ScreenFrozed";
            this.frozedIndicator.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(179, 67);
            this.Controls.Add(this.frozedIndicator);
            this.Controls.Add(this.colorBoxB);
            this.Controls.Add(this.colorBoxG);
            this.Controls.Add(this.colorBoxR);
            this.Controls.Add(this.hideBackgroundButton);
            this.Controls.Add(this.anchorTextBox);
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
        private System.Windows.Forms.TextBox anchorTextBox;
        private System.Windows.Forms.Button hideBackgroundButton;
        private System.Windows.Forms.TextBox colorBoxR;
        private System.Windows.Forms.TextBox colorBoxG;
        private System.Windows.Forms.TextBox colorBoxB;
        private System.Windows.Forms.TextBox frozedIndicator;
    }
}

