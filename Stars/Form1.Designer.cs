namespace Stars
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            rowChooser = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)rowChooser).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(299, 224);
            button1.Name = "button1";
            button1.Size = new Size(284, 115);
            button1.TabIndex = 0;
            button1.Text = "按我吧";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(299, 120);
            label1.Name = "label1";
            label1.Size = new Size(64, 29);
            label1.TabIndex = 1;
            label1.Text = "列數:";
            // 
            // rowChooser
            // 
            rowChooser.Font = new Font("標楷體", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            rowChooser.Location = new Point(433, 120);
            rowChooser.Name = "rowChooser";
            rowChooser.Size = new Size(150, 35);
            rowChooser.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rowChooser);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)rowChooser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private NumericUpDown rowChooser;
    }
}