namespace lab1_
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.MinimizeFormButton = new System.Windows.Forms.Button();
            this.CloseFormButton = new System.Windows.Forms.Button();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.OpenTask7Button = new System.Windows.Forms.Button();
            this.OpenTask6Button = new System.Windows.Forms.Button();
            this.OpenTask3Button = new System.Windows.Forms.Button();
            this.OpenTask4Button = new System.Windows.Forms.Button();
            this.OpenTask2Button = new System.Windows.Forms.Button();
            this.OpenTask1Button = new System.Windows.Forms.Button();
            this.OpenTask5Button = new System.Windows.Forms.Button();
            this.TitlePanel.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitlePanel
            // 
            this.TitlePanel.BackColor = System.Drawing.Color.White;
            this.TitlePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TitlePanel.Controls.Add(this.TitleLabel);
            this.TitlePanel.Controls.Add(this.MinimizeFormButton);
            this.TitlePanel.Controls.Add(this.CloseFormButton);
            this.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitlePanel.Location = new System.Drawing.Point(0, 0);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(220, 40);
            this.TitlePanel.TabIndex = 1;
            this.TitlePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitlePanel_MouseDown);
            this.TitlePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitlePanel_MouseMove);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(2, 8);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(62, 25);
            this.TitleLabel.TabIndex = 5;
            this.TitleLabel.Text = "Menu";
            this.TitleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitlePanel_MouseDown);
            this.TitleLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitlePanel_MouseMove);
            // 
            // MinimizeFormButton
            // 
            this.MinimizeFormButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MinimizeFormButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinimizeFormButton.FlatAppearance.BorderSize = 0;
            this.MinimizeFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeFormButton.Location = new System.Drawing.Point(134, 0);
            this.MinimizeFormButton.Name = "MinimizeFormButton";
            this.MinimizeFormButton.Size = new System.Drawing.Size(42, 38);
            this.MinimizeFormButton.TabIndex = 8;
            this.MinimizeFormButton.Text = "-";
            this.MinimizeFormButton.UseVisualStyleBackColor = false;
            this.MinimizeFormButton.Click += new System.EventHandler(this.MinimizeFormButton_Click);
            // 
            // CloseFormButton
            // 
            this.CloseFormButton.BackColor = System.Drawing.Color.Red;
            this.CloseFormButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.CloseFormButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseFormButton.FlatAppearance.BorderSize = 0;
            this.CloseFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseFormButton.Location = new System.Drawing.Point(176, 0);
            this.CloseFormButton.Name = "CloseFormButton";
            this.CloseFormButton.Size = new System.Drawing.Size(42, 38);
            this.CloseFormButton.TabIndex = 9;
            this.CloseFormButton.Text = "X";
            this.CloseFormButton.UseVisualStyleBackColor = false;
            this.CloseFormButton.Click += new System.EventHandler(this.CloseFormButton_Click);
            // 
            // ContentPanel
            // 
            this.ContentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContentPanel.Controls.Add(this.OpenTask7Button);
            this.ContentPanel.Controls.Add(this.OpenTask6Button);
            this.ContentPanel.Controls.Add(this.OpenTask3Button);
            this.ContentPanel.Controls.Add(this.OpenTask4Button);
            this.ContentPanel.Controls.Add(this.OpenTask2Button);
            this.ContentPanel.Controls.Add(this.OpenTask1Button);
            this.ContentPanel.Controls.Add(this.OpenTask5Button);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(0, 40);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(220, 330);
            this.ContentPanel.TabIndex = 2;
            // 
            // OpenTask7Button
            // 
            this.OpenTask7Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenTask7Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenTask7Button.Location = new System.Drawing.Point(36, 279);
            this.OpenTask7Button.Name = "OpenTask7Button";
            this.OpenTask7Button.Size = new System.Drawing.Size(140, 40);
            this.OpenTask7Button.TabIndex = 7;
            this.OpenTask7Button.Text = "Task 7";
            this.OpenTask7Button.UseVisualStyleBackColor = true;
            this.OpenTask7Button.Click += new System.EventHandler(this.OpenTasksButton_Click);
            // 
            // OpenTask6Button
            // 
            this.OpenTask6Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenTask6Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenTask6Button.Location = new System.Drawing.Point(36, 233);
            this.OpenTask6Button.Name = "OpenTask6Button";
            this.OpenTask6Button.Size = new System.Drawing.Size(140, 40);
            this.OpenTask6Button.TabIndex = 6;
            this.OpenTask6Button.Text = "Task 6";
            this.OpenTask6Button.UseVisualStyleBackColor = true;
            this.OpenTask6Button.Click += new System.EventHandler(this.OpenTasksButton_Click);
            // 
            // OpenTask3Button
            // 
            this.OpenTask3Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenTask3Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenTask3Button.Location = new System.Drawing.Point(36, 95);
            this.OpenTask3Button.Name = "OpenTask3Button";
            this.OpenTask3Button.Size = new System.Drawing.Size(140, 40);
            this.OpenTask3Button.TabIndex = 3;
            this.OpenTask3Button.Text = "Task 3";
            this.OpenTask3Button.UseVisualStyleBackColor = true;
            this.OpenTask3Button.Click += new System.EventHandler(this.OpenTasksButton_Click);
            // 
            // OpenTask4Button
            // 
            this.OpenTask4Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenTask4Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenTask4Button.Location = new System.Drawing.Point(36, 141);
            this.OpenTask4Button.Name = "OpenTask4Button";
            this.OpenTask4Button.Size = new System.Drawing.Size(140, 40);
            this.OpenTask4Button.TabIndex = 4;
            this.OpenTask4Button.Text = "Task 4";
            this.OpenTask4Button.UseVisualStyleBackColor = true;
            this.OpenTask4Button.Click += new System.EventHandler(this.OpenTasksButton_Click);
            // 
            // OpenTask2Button
            // 
            this.OpenTask2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenTask2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenTask2Button.Location = new System.Drawing.Point(36, 49);
            this.OpenTask2Button.Name = "OpenTask2Button";
            this.OpenTask2Button.Size = new System.Drawing.Size(140, 40);
            this.OpenTask2Button.TabIndex = 2;
            this.OpenTask2Button.Text = "Task 2";
            this.OpenTask2Button.UseVisualStyleBackColor = true;
            this.OpenTask2Button.Click += new System.EventHandler(this.OpenTasksButton_Click);
            // 
            // OpenTask1Button
            // 
            this.OpenTask1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenTask1Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenTask1Button.Location = new System.Drawing.Point(36, 5);
            this.OpenTask1Button.Name = "OpenTask1Button";
            this.OpenTask1Button.Size = new System.Drawing.Size(140, 40);
            this.OpenTask1Button.TabIndex = 1;
            this.OpenTask1Button.Text = "Task 1";
            this.OpenTask1Button.UseVisualStyleBackColor = true;
            this.OpenTask1Button.Click += new System.EventHandler(this.OpenTasksButton_Click);
            // 
            // OpenTask5Button
            // 
            this.OpenTask5Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenTask5Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenTask5Button.Location = new System.Drawing.Point(36, 187);
            this.OpenTask5Button.Name = "OpenTask5Button";
            this.OpenTask5Button.Size = new System.Drawing.Size(140, 40);
            this.OpenTask5Button.TabIndex = 5;
            this.OpenTask5Button.Text = "Task 5";
            this.OpenTask5Button.UseVisualStyleBackColor = true;
            this.OpenTask5Button.Click += new System.EventHandler(this.OpenTasksButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 370);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.TitlePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            this.ContentPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TitlePanel;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Button OpenTask5Button;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button MinimizeFormButton;
        private System.Windows.Forms.Button CloseFormButton;
        private System.Windows.Forms.Button OpenTask3Button;
        private System.Windows.Forms.Button OpenTask4Button;
        private System.Windows.Forms.Button OpenTask2Button;
        private System.Windows.Forms.Button OpenTask1Button;
        private System.Windows.Forms.Button OpenTask7Button;
        private System.Windows.Forms.Button OpenTask6Button;
    }
}

