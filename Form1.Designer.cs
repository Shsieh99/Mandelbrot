namespace Mandelbrot
{
    partial class Form1
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
            this.Schaal = new System.Windows.Forms.TextBox();
            this.Iteraties = new System.Windows.Forms.TextBox();
            this.MiddenX = new System.Windows.Forms.TextBox();
            this.MiddenY = new System.Windows.Forms.TextBox();
            this.Convert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(100, 110);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Schaal
            // 
            this.Schaal.Location = new System.Drawing.Point(442, 21);
            this.Schaal.Name = "Schaal";
            this.Schaal.Size = new System.Drawing.Size(181, 22);
            this.Schaal.TabIndex = 1;
            this.Schaal.TextChanged += new System.EventHandler(this.Schaal_TextChanged);
            // 
            // Iteraties
            // 
            this.Iteraties.Location = new System.Drawing.Point(442, 74);
            this.Iteraties.Name = "Iteraties";
            this.Iteraties.Size = new System.Drawing.Size(100, 22);
            this.Iteraties.TabIndex = 2;
            this.Iteraties.TextChanged += new System.EventHandler(this.Max_TextChanged);
            // 
            // MiddenX
            // 
            this.MiddenX.Location = new System.Drawing.Point(123, 21);
            this.MiddenX.Name = "MiddenX";
            this.MiddenX.Size = new System.Drawing.Size(153, 22);
            this.MiddenX.TabIndex = 3;
            this.MiddenX.TextChanged += new System.EventHandler(this.MiddenX_TextChanged);
            // 
            // MiddenY
            // 
            this.MiddenY.Location = new System.Drawing.Point(123, 74);
            this.MiddenY.Name = "MiddenY";
            this.MiddenY.Size = new System.Drawing.Size(153, 22);
            this.MiddenY.TabIndex = 4;
            this.MiddenY.TextChanged += new System.EventHandler(this.MiddenY_TextChanged);
            // 
            // Convert
            // 
            this.Convert.Location = new System.Drawing.Point(561, 74);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(62, 23);
            this.Convert.TabIndex = 5;
            this.Convert.Text = "Convert";
            this.Convert.UseVisualStyleBackColor = true;
            this.Convert.Click += new System.EventHandler(this.MiddenX_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "Midden X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "Midden Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(401, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "Schaal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(395, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "Iteraties";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 628);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Convert);
            this.Controls.Add(this.MiddenY);
            this.Controls.Add(this.MiddenX);
            this.Controls.Add(this.Iteraties);
            this.Controls.Add(this.Schaal);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Schaal;
        private System.Windows.Forms.TextBox Iteraties;
        private System.Windows.Forms.TextBox MiddenX;
        private System.Windows.Forms.TextBox MiddenY;
        private System.Windows.Forms.Button Convert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

