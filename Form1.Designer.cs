namespace AngleCalc
{
    partial class AngleCalc
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
            this.hour = new System.Windows.Forms.TextBox();
            this.mins = new System.Windows.Forms.MaskedTextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.angle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hour
            // 
            this.hour.Location = new System.Drawing.Point(25, 66);
            this.hour.Name = "hour";
            this.hour.Size = new System.Drawing.Size(100, 22);
            this.hour.TabIndex = 0;
            // 
            // mins
            // 
            this.mins.Location = new System.Drawing.Point(151, 66);
            this.mins.Name = "mins";
            this.mins.Size = new System.Drawing.Size(100, 22);
            this.mins.TabIndex = 1;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(97, 121);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 2;
            this.CalculateButton.Text = "Oblicz";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.Calculate);
            // 
            // angle
            // 
            this.angle.AutoSize = true;
            this.angle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.angle.Location = new System.Drawing.Point(104, 194);
            this.angle.Name = "angle";
            this.angle.Size = new System.Drawing.Size(0, 39);
            this.angle.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kąt :";
            // 
            // AngleCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.angle);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.mins);
            this.Controls.Add(this.hour);
            this.Name = "AngleCalc";
            this.Text = "Kalkulator Kątow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox hour;
        private System.Windows.Forms.MaskedTextBox mins;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label angle;
        private System.Windows.Forms.Label label1;
    }
}

