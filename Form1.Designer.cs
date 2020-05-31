namespace ITMO.Group124.Bajurov.Lab1.Task1
{
    partial class formTreyResearch
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
            this.buttonBorderStyle = new System.Windows.Forms.Button();
            this.buttonResize = new System.Windows.Forms.Button();
            this.buttonOpacity = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBorderStyle
            // 
            this.buttonBorderStyle.Location = new System.Drawing.Point(12, 248);
            this.buttonBorderStyle.Name = "buttonBorderStyle";
            this.buttonBorderStyle.Size = new System.Drawing.Size(180, 90);
            this.buttonBorderStyle.TabIndex = 0;
            this.buttonBorderStyle.Text = "Border Style";
            this.buttonBorderStyle.UseVisualStyleBackColor = true;
            this.buttonBorderStyle.Click += new System.EventHandler(this.buttonBorderStyle_Click);
            // 
            // buttonResize
            // 
            this.buttonResize.Location = new System.Drawing.Point(268, 248);
            this.buttonResize.Name = "buttonResize";
            this.buttonResize.Size = new System.Drawing.Size(180, 90);
            this.buttonResize.TabIndex = 1;
            this.buttonResize.Text = "Resize";
            this.buttonResize.UseVisualStyleBackColor = true;
            this.buttonResize.Click += new System.EventHandler(this.buttonResize_Click);
            // 
            // buttonOpacity
            // 
            this.buttonOpacity.Location = new System.Drawing.Point(526, 248);
            this.buttonOpacity.Name = "buttonOpacity";
            this.buttonOpacity.Size = new System.Drawing.Size(180, 90);
            this.buttonOpacity.TabIndex = 2;
            this.buttonOpacity.Text = "Opacity";
            this.buttonOpacity.UseVisualStyleBackColor = true;
            this.buttonOpacity.Click += new System.EventHandler(this.button3_Click);
            // 
            // formTreyResearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 353);
            this.Controls.Add(this.buttonOpacity);
            this.Controls.Add(this.buttonResize);
            this.Controls.Add(this.buttonBorderStyle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Location = new System.Drawing.Point(100, 200);
            this.Name = "formTreyResearch";
            this.Opacity = 0.75D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Trey Research";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBorderStyle;
        private System.Windows.Forms.Button buttonResize;
        private System.Windows.Forms.Button buttonOpacity;
    }
}

