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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.anchorTextBox = new System.Windows.Forms.TextBox();
            this.hideBackgroundButton = new System.Windows.Forms.Button();
            this.colorBoxR = new System.Windows.Forms.TextBox();
            this.colorBoxG = new System.Windows.Forms.TextBox();
            this.colorBoxB = new System.Windows.Forms.TextBox();
            this.frozedIndicator = new System.Windows.Forms.TextBox();
            this.dataSavedIndicator = new System.Windows.Forms.TextBox();
            this.ScaleComboBox = new System.Windows.Forms.ComboBox();
            this.ScaledTextBoxY = new System.Windows.Forms.TextBox();
            this.ScaledTextBoxX = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxX
            // 
            this.textBoxX.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxX.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxX.Location = new System.Drawing.Point(0, 13);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.ReadOnly = true;
            this.textBoxX.Size = new System.Drawing.Size(50, 13);
            this.textBoxX.TabIndex = 0;
            this.textBoxX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxY
            // 
            this.textBoxY.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxY.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxY.Location = new System.Drawing.Point(50, 13);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.ReadOnly = true;
            this.textBoxY.Size = new System.Drawing.Size(50, 13);
            this.textBoxY.TabIndex = 1;
            this.textBoxY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // anchorTextBox
            // 
            this.anchorTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.anchorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.anchorTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.anchorTextBox.Location = new System.Drawing.Point(0, 0);
            this.anchorTextBox.Name = "anchorTextBox";
            this.anchorTextBox.ReadOnly = true;
            this.anchorTextBox.Size = new System.Drawing.Size(100, 13);
            this.anchorTextBox.TabIndex = 3;
            this.anchorTextBox.Text = "anchor 0 0";
            this.anchorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.anchorTextBox.Visible = false;
            // 
            // hideBackgroundButton
            // 
            this.hideBackgroundButton.BackColor = System.Drawing.SystemColors.Info;
            this.hideBackgroundButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hideBackgroundButton.Image = ((System.Drawing.Image)(resources.GetObject("hideBackgroundButton.Image")));
            this.hideBackgroundButton.Location = new System.Drawing.Point(100, 0);
            this.hideBackgroundButton.Name = "hideBackgroundButton";
            this.hideBackgroundButton.Size = new System.Drawing.Size(25, 25);
            this.hideBackgroundButton.TabIndex = 5;
            this.hideBackgroundButton.UseVisualStyleBackColor = false;
            this.hideBackgroundButton.Click += new System.EventHandler(this.HideBackground);
            // 
            // colorBoxR
            // 
            this.colorBoxR.BackColor = System.Drawing.SystemColors.Info;
            this.colorBoxR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.colorBoxR.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.colorBoxR.Location = new System.Drawing.Point(0, 26);
            this.colorBoxR.Name = "colorBoxR";
            this.colorBoxR.ReadOnly = true;
            this.colorBoxR.Size = new System.Drawing.Size(33, 13);
            this.colorBoxR.TabIndex = 6;
            this.colorBoxR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colorBoxG
            // 
            this.colorBoxG.BackColor = System.Drawing.SystemColors.Info;
            this.colorBoxG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.colorBoxG.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.colorBoxG.Location = new System.Drawing.Point(33, 26);
            this.colorBoxG.Name = "colorBoxG";
            this.colorBoxG.ReadOnly = true;
            this.colorBoxG.Size = new System.Drawing.Size(34, 13);
            this.colorBoxG.TabIndex = 7;
            this.colorBoxG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colorBoxB
            // 
            this.colorBoxB.BackColor = System.Drawing.SystemColors.Info;
            this.colorBoxB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.colorBoxB.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.colorBoxB.Location = new System.Drawing.Point(67, 26);
            this.colorBoxB.Name = "colorBoxB";
            this.colorBoxB.ReadOnly = true;
            this.colorBoxB.Size = new System.Drawing.Size(33, 13);
            this.colorBoxB.TabIndex = 8;
            this.colorBoxB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frozedIndicator
            // 
            this.frozedIndicator.BackColor = System.Drawing.SystemColors.Info;
            this.frozedIndicator.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.frozedIndicator.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.frozedIndicator.Location = new System.Drawing.Point(100, 26);
            this.frozedIndicator.Name = "frozedIndicator";
            this.frozedIndicator.ReadOnly = true;
            this.frozedIndicator.Size = new System.Drawing.Size(75, 13);
            this.frozedIndicator.TabIndex = 9;
            this.frozedIndicator.Text = "ScreenFrozed";
            this.frozedIndicator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.frozedIndicator.Visible = false;
            // 
            // dataSavedIndicator
            // 
            this.dataSavedIndicator.BackColor = System.Drawing.SystemColors.Info;
            this.dataSavedIndicator.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataSavedIndicator.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataSavedIndicator.Location = new System.Drawing.Point(100, 39);
            this.dataSavedIndicator.Name = "dataSavedIndicator";
            this.dataSavedIndicator.ReadOnly = true;
            this.dataSavedIndicator.Size = new System.Drawing.Size(75, 13);
            this.dataSavedIndicator.TabIndex = 10;
            this.dataSavedIndicator.Text = "Data saved";
            this.dataSavedIndicator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dataSavedIndicator.Visible = false;
            // 
            // ScaleComboBox
            // 
            this.ScaleComboBox.FormattingEnabled = true;
            this.ScaleComboBox.Items.AddRange(new object[] {
            "100",
            "125"});
            this.ScaleComboBox.Location = new System.Drawing.Point(125, 2);
            this.ScaleComboBox.Name = "ScaleComboBox";
            this.ScaleComboBox.Size = new System.Drawing.Size(50, 21);
            this.ScaleComboBox.TabIndex = 11;
            this.ScaleComboBox.Tag = "";
            this.ScaleComboBox.Text = "100";
            this.ScaleComboBox.SelectedIndexChanged += new System.EventHandler(this.ScaleComboBox_SelectedIndexChanged);
            // 
            // ScaledTextBoxY
            // 
            this.ScaledTextBoxY.BackColor = System.Drawing.SystemColors.Info;
            this.ScaledTextBoxY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ScaledTextBoxY.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ScaledTextBoxY.Location = new System.Drawing.Point(50, 39);
            this.ScaledTextBoxY.Name = "ScaledTextBoxY";
            this.ScaledTextBoxY.ReadOnly = true;
            this.ScaledTextBoxY.Size = new System.Drawing.Size(50, 13);
            this.ScaledTextBoxY.TabIndex = 13;
            this.ScaledTextBoxY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ScaledTextBoxY.Visible = false;
            // 
            // ScaledTextBoxX
            // 
            this.ScaledTextBoxX.BackColor = System.Drawing.SystemColors.Info;
            this.ScaledTextBoxX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ScaledTextBoxX.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ScaledTextBoxX.Location = new System.Drawing.Point(0, 39);
            this.ScaledTextBoxX.Name = "ScaledTextBoxX";
            this.ScaledTextBoxX.ReadOnly = true;
            this.ScaledTextBoxX.Size = new System.Drawing.Size(50, 13);
            this.ScaledTextBoxX.TabIndex = 12;
            this.ScaledTextBoxX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ScaledTextBoxX.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(178, 57);
            this.Controls.Add(this.ScaledTextBoxY);
            this.Controls.Add(this.ScaledTextBoxX);
            this.Controls.Add(this.ScaleComboBox);
            this.Controls.Add(this.dataSavedIndicator);
            this.Controls.Add(this.frozedIndicator);
            this.Controls.Add(this.colorBoxB);
            this.Controls.Add(this.colorBoxG);
            this.Controls.Add(this.colorBoxR);
            this.Controls.Add(this.hideBackgroundButton);
            this.Controls.Add(this.anchorTextBox);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
        private System.Windows.Forms.TextBox dataSavedIndicator;
        private System.Windows.Forms.ComboBox ScaleComboBox;
        private System.Windows.Forms.TextBox ScaledTextBoxY;
        private System.Windows.Forms.TextBox ScaledTextBoxX;
    }
}

