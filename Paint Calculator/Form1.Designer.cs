namespace Paint_Calculator
{
    partial class PaintCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.textLength = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textWidth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textHeight = new System.Windows.Forms.TextBox();
            this.Go = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.displayArea = new System.Windows.Forms.TextBox();
            this.displayVolume = new System.Windows.Forms.TextBox();
            this.paintRequired = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Length (m)";
            // 
            // textLength
            // 
            this.textLength.Location = new System.Drawing.Point(13, 43);
            this.textLength.Name = "textLength";
            this.textLength.Size = new System.Drawing.Size(100, 20);
            this.textLength.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Width (m)";
            // 
            // textWidth
            // 
            this.textWidth.Location = new System.Drawing.Point(12, 111);
            this.textWidth.Name = "textWidth";
            this.textWidth.Size = new System.Drawing.Size(100, 20);
            this.textWidth.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Height (m)";
            // 
            // textHeight
            // 
            this.textHeight.Location = new System.Drawing.Point(12, 177);
            this.textHeight.Name = "textHeight";
            this.textHeight.Size = new System.Drawing.Size(100, 20);
            this.textHeight.TabIndex = 5;
            // 
            // Go
            // 
            this.Go.Location = new System.Drawing.Point(103, 226);
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(75, 23);
            this.Go.TabIndex = 6;
            this.Go.Text = "GO";
            this.Go.UseVisualStyleBackColor = true;
            this.Go.Click += new System.EventHandler(this.Go_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(169, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Area";
            // 
            // displayArea
            // 
            this.displayArea.Enabled = false;
            this.displayArea.Location = new System.Drawing.Point(172, 43);
            this.displayArea.Name = "displayArea";
            this.displayArea.Size = new System.Drawing.Size(100, 20);
            this.displayArea.TabIndex = 8;
            // 
            // displayVolume
            // 
            this.displayVolume.Enabled = false;
            this.displayVolume.Location = new System.Drawing.Point(172, 111);
            this.displayVolume.Name = "displayVolume";
            this.displayVolume.Size = new System.Drawing.Size(100, 20);
            this.displayVolume.TabIndex = 9;
            // 
            // paintRequired
            // 
            this.paintRequired.Enabled = false;
            this.paintRequired.Location = new System.Drawing.Point(171, 177);
            this.paintRequired.Name = "paintRequired";
            this.paintRequired.Size = new System.Drawing.Size(100, 20);
            this.paintRequired.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(169, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Volume";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(172, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Paint Required";
            // 
            // PaintCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.paintRequired);
            this.Controls.Add(this.displayVolume);
            this.Controls.Add(this.displayArea);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Go);
            this.Controls.Add(this.textHeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textWidth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textLength);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "PaintCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textLength;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textHeight;
        private System.Windows.Forms.Button Go;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox displayArea;
        private System.Windows.Forms.TextBox displayVolume;
        private System.Windows.Forms.TextBox paintRequired;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

