namespace PicByPics
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ChooseFolderBut = new System.Windows.Forms.Button();
            this.TakeImageBut = new System.Windows.Forms.Button();
            this.ChoosenImageLabel = new System.Windows.Forms.Label();
            this.ChoosenFolderLabel = new System.Windows.Forms.Label();
            this.MatrixTB = new System.Windows.Forms.TextBox();
            this.SizeTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SaveBut = new System.Windows.Forms.Button();
            this.SaveTB = new System.Windows.Forms.TextBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.ChoosePathBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChooseFolderBut
            // 
            this.ChooseFolderBut.Location = new System.Drawing.Point(12, 41);
            this.ChooseFolderBut.Name = "ChooseFolderBut";
            this.ChooseFolderBut.Size = new System.Drawing.Size(85, 23);
            this.ChooseFolderBut.TabIndex = 0;
            this.ChooseFolderBut.Text = "Folder of parts";
            this.ChooseFolderBut.UseVisualStyleBackColor = true;
            this.ChooseFolderBut.Click += new System.EventHandler(this.ChooseFolderBut_Click);
            // 
            // TakeImageBut
            // 
            this.TakeImageBut.Location = new System.Drawing.Point(12, 12);
            this.TakeImageBut.Name = "TakeImageBut";
            this.TakeImageBut.Size = new System.Drawing.Size(85, 23);
            this.TakeImageBut.TabIndex = 1;
            this.TakeImageBut.Text = "Source Image";
            this.TakeImageBut.UseVisualStyleBackColor = true;
            this.TakeImageBut.Click += new System.EventHandler(this.TakeImageBut_Click);
            // 
            // ChoosenImageLabel
            // 
            this.ChoosenImageLabel.AutoSize = true;
            this.ChoosenImageLabel.Location = new System.Drawing.Point(103, 17);
            this.ChoosenImageLabel.Name = "ChoosenImageLabel";
            this.ChoosenImageLabel.Size = new System.Drawing.Size(0, 13);
            this.ChoosenImageLabel.TabIndex = 2;
            // 
            // ChoosenFolderLabel
            // 
            this.ChoosenFolderLabel.AutoSize = true;
            this.ChoosenFolderLabel.Location = new System.Drawing.Point(103, 46);
            this.ChoosenFolderLabel.Name = "ChoosenFolderLabel";
            this.ChoosenFolderLabel.Size = new System.Drawing.Size(0, 13);
            this.ChoosenFolderLabel.TabIndex = 3;
            // 
            // MatrixTB
            // 
            this.MatrixTB.Location = new System.Drawing.Point(12, 71);
            this.MatrixTB.Name = "MatrixTB";
            this.MatrixTB.Size = new System.Drawing.Size(85, 20);
            this.MatrixTB.TabIndex = 4;
            // 
            // SizeTB
            // 
            this.SizeTB.Location = new System.Drawing.Point(12, 97);
            this.SizeTB.Name = "SizeTB";
            this.SizeTB.Size = new System.Drawing.Size(85, 20);
            this.SizeTB.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Choose size of puzzle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Choose the accuracy";
            // 
            // SaveBut
            // 
            this.SaveBut.Location = new System.Drawing.Point(458, 124);
            this.SaveBut.Name = "SaveBut";
            this.SaveBut.Size = new System.Drawing.Size(85, 23);
            this.SaveBut.TabIndex = 8;
            this.SaveBut.Text = "Path to Save Image";
            this.SaveBut.UseVisualStyleBackColor = true;
            this.SaveBut.Click += new System.EventHandler(this.SaveBut_Click);
            // 
            // SaveTB
            // 
            this.SaveTB.Location = new System.Drawing.Point(106, 126);
            this.SaveTB.Name = "SaveTB";
            this.SaveTB.Size = new System.Drawing.Size(346, 20);
            this.SaveTB.TabIndex = 9;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(12, 168);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(56, 13);
            this.StatusLabel.TabIndex = 10;
            this.StatusLabel.Text = "Status Bar";
            // 
            // ChoosePathBut
            // 
            this.ChoosePathBut.Location = new System.Drawing.Point(12, 123);
            this.ChoosePathBut.Name = "ChoosePathBut";
            this.ChoosePathBut.Size = new System.Drawing.Size(85, 23);
            this.ChoosePathBut.TabIndex = 11;
            this.ChoosePathBut.Text = "Path to Save Image";
            this.ChoosePathBut.UseVisualStyleBackColor = true;
            this.ChoosePathBut.Click += new System.EventHandler(this.ChoosePathBut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 192);
            this.Controls.Add(this.ChoosePathBut);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.SaveTB);
            this.Controls.Add(this.SaveBut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SizeTB);
            this.Controls.Add(this.MatrixTB);
            this.Controls.Add(this.ChoosenFolderLabel);
            this.Controls.Add(this.ChoosenImageLabel);
            this.Controls.Add(this.TakeImageBut);
            this.Controls.Add(this.ChooseFolderBut);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChooseFolderBut;
        private System.Windows.Forms.Button TakeImageBut;
        private System.Windows.Forms.Label ChoosenImageLabel;
        private System.Windows.Forms.Label ChoosenFolderLabel;
        private System.Windows.Forms.TextBox MatrixTB;
        private System.Windows.Forms.TextBox SizeTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SaveBut;
        private System.Windows.Forms.TextBox SaveTB;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Button ChoosePathBut;
    }
}

