
namespace WindowsFormsApp1
{
    partial class PixelSort
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LoadImageButton = new System.Windows.Forms.Button();
            this.SaveImageButton = new System.Windows.Forms.Button();
            this.SortAllHorizontalButton = new System.Windows.Forms.Button();
            this.SortRandomRowsButton = new System.Windows.Forms.Button();
            this.RowChanceField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ColumnChanceField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SortRandomColumnsButton = new System.Windows.Forms.Button();
            this.SortAllColumnsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(94, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(354, 425);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LoadImageButton
            // 
            this.LoadImageButton.Location = new System.Drawing.Point(13, 13);
            this.LoadImageButton.Name = "LoadImageButton";
            this.LoadImageButton.Size = new System.Drawing.Size(75, 23);
            this.LoadImageButton.TabIndex = 1;
            this.LoadImageButton.Text = "Load Image";
            this.LoadImageButton.UseVisualStyleBackColor = true;
            this.LoadImageButton.Click += new System.EventHandler(this.LoadImageButtonClick);
            // 
            // SaveImageButton
            // 
            this.SaveImageButton.Location = new System.Drawing.Point(13, 414);
            this.SaveImageButton.Name = "SaveImageButton";
            this.SaveImageButton.Size = new System.Drawing.Size(75, 23);
            this.SaveImageButton.TabIndex = 2;
            this.SaveImageButton.Text = "Save Image";
            this.SaveImageButton.UseVisualStyleBackColor = true;
            this.SaveImageButton.Click += new System.EventHandler(this.SaveImageClick);
            // 
            // SortAllHorizontalButton
            // 
            this.SortAllHorizontalButton.Location = new System.Drawing.Point(455, 12);
            this.SortAllHorizontalButton.Name = "SortAllHorizontalButton";
            this.SortAllHorizontalButton.Size = new System.Drawing.Size(136, 23);
            this.SortAllHorizontalButton.TabIndex = 3;
            this.SortAllHorizontalButton.Text = "Sort All Rows";
            this.SortAllHorizontalButton.UseVisualStyleBackColor = true;
            this.SortAllHorizontalButton.Click += new System.EventHandler(this.SortAllRows);
            // 
            // SortRandomRowsButton
            // 
            this.SortRandomRowsButton.Location = new System.Drawing.Point(454, 70);
            this.SortRandomRowsButton.Name = "SortRandomRowsButton";
            this.SortRandomRowsButton.Size = new System.Drawing.Size(136, 23);
            this.SortRandomRowsButton.TabIndex = 4;
            this.SortRandomRowsButton.Text = "Sort Random Rows";
            this.SortRandomRowsButton.UseVisualStyleBackColor = true;
            this.SortRandomRowsButton.Click += new System.EventHandler(this.SortRandomRowsButton_Click);
            // 
            // RowChanceField
            // 
            this.RowChanceField.Location = new System.Drawing.Point(640, 29);
            this.RowChanceField.Name = "RowChanceField";
            this.RowChanceField.Size = new System.Drawing.Size(130, 20);
            this.RowChanceField.TabIndex = 5;
            this.RowChanceField.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(640, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "chance per row (0-1)";
            // 
            // ColumnChanceField
            // 
            this.ColumnChanceField.Location = new System.Drawing.Point(640, 74);
            this.ColumnChanceField.Name = "ColumnChanceField";
            this.ColumnChanceField.Size = new System.Drawing.Size(130, 20);
            this.ColumnChanceField.TabIndex = 5;
            this.ColumnChanceField.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(640, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "chance per column (0-1)";
            // 
            // SortRandomColumnsButton
            // 
            this.SortRandomColumnsButton.Location = new System.Drawing.Point(454, 99);
            this.SortRandomColumnsButton.Name = "SortRandomColumnsButton";
            this.SortRandomColumnsButton.Size = new System.Drawing.Size(136, 23);
            this.SortRandomColumnsButton.TabIndex = 4;
            this.SortRandomColumnsButton.Text = "Sort Random Columns";
            this.SortRandomColumnsButton.UseVisualStyleBackColor = true;
            this.SortRandomColumnsButton.Click += new System.EventHandler(this.SortRandomColumnsButton_Click);
            // 
            // SortAllColumnsButton
            // 
            this.SortAllColumnsButton.Location = new System.Drawing.Point(455, 41);
            this.SortAllColumnsButton.Name = "SortAllColumnsButton";
            this.SortAllColumnsButton.Size = new System.Drawing.Size(136, 23);
            this.SortAllColumnsButton.TabIndex = 7;
            this.SortAllColumnsButton.Text = "Sort All Columns";
            this.SortAllColumnsButton.UseVisualStyleBackColor = true;
            this.SortAllColumnsButton.Click += new System.EventHandler(this.SortAllColumnsButton_Click);
            // 
            // PixelSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SortAllColumnsButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ColumnChanceField);
            this.Controls.Add(this.RowChanceField);
            this.Controls.Add(this.SortRandomColumnsButton);
            this.Controls.Add(this.SortRandomRowsButton);
            this.Controls.Add(this.SortAllHorizontalButton);
            this.Controls.Add(this.SaveImageButton);
            this.Controls.Add(this.LoadImageButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PixelSort";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button LoadImageButton;
        private System.Windows.Forms.Button SaveImageButton;
        private System.Windows.Forms.Button SortAllHorizontalButton;
        private System.Windows.Forms.Button SortRandomRowsButton;
        private System.Windows.Forms.TextBox RowChanceField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ColumnChanceField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SortRandomColumnsButton;
        private System.Windows.Forms.Button SortAllColumnsButton;
    }
}

