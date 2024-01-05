
namespace Geometric_figures
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
            this.button_polygon = new System.Windows.Forms.Button();
            this.button_rectangle = new System.Windows.Forms.Button();
            this.button_circle = new System.Windows.Forms.Button();
            this.button_curve = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(36, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1029, 391);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button_polygon
            // 
            this.button_polygon.Location = new System.Drawing.Point(36, 453);
            this.button_polygon.Name = "button_polygon";
            this.button_polygon.Size = new System.Drawing.Size(110, 42);
            this.button_polygon.TabIndex = 1;
            this.button_polygon.Text = "polygon";
            this.button_polygon.UseVisualStyleBackColor = true;
            this.button_polygon.Click += new System.EventHandler(this.polygon_Click);
            // 
            // button_rectangle
            // 
            this.button_rectangle.Location = new System.Drawing.Point(196, 454);
            this.button_rectangle.Name = "button_rectangle";
            this.button_rectangle.Size = new System.Drawing.Size(110, 41);
            this.button_rectangle.TabIndex = 2;
            this.button_rectangle.Text = "rectangle";
            this.button_rectangle.UseVisualStyleBackColor = true;
            this.button_rectangle.Click += new System.EventHandler(this.button_rectangle_Click);
            // 
            // button_circle
            // 
            this.button_circle.Location = new System.Drawing.Point(358, 455);
            this.button_circle.Name = "button_circle";
            this.button_circle.Size = new System.Drawing.Size(110, 40);
            this.button_circle.TabIndex = 3;
            this.button_circle.Text = "circle";
            this.button_circle.UseVisualStyleBackColor = true;
            this.button_circle.Click += new System.EventHandler(this.button_circle_Click);
            // 
            // button_curve
            // 
            this.button_curve.Location = new System.Drawing.Point(521, 456);
            this.button_curve.Name = "button_curve";
            this.button_curve.Size = new System.Drawing.Size(110, 39);
            this.button_curve.TabIndex = 4;
            this.button_curve.Text = "curve";
            this.button_curve.UseVisualStyleBackColor = true;
            this.button_curve.Click += new System.EventHandler(this.button_curve_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 592);
            this.Controls.Add(this.button_curve);
            this.Controls.Add(this.button_circle);
            this.Controls.Add(this.button_rectangle);
            this.Controls.Add(this.button_polygon);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_polygon;
        private System.Windows.Forms.Button button_rectangle;
        private System.Windows.Forms.Button button_circle;
        private System.Windows.Forms.Button button_curve;
    }
}

