namespace Snake
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
            this.components = new System.ComponentModel.Container();
            this.pbCanvas1 = new System.Windows.Forms.PictureBox();
            this.gameTimer1 = new System.Windows.Forms.Timer(this.components);
            this.pbCanvas2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gametimer2 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas2)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCanvas1
            // 
            this.pbCanvas1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pbCanvas1.Location = new System.Drawing.Point(440, 46);
            this.pbCanvas1.Name = "pbCanvas1";
            this.pbCanvas1.Size = new System.Drawing.Size(432, 424);
            this.pbCanvas1.TabIndex = 0;
            this.pbCanvas1.TabStop = false;
            this.pbCanvas1.Paint += new System.Windows.Forms.PaintEventHandler(this.pbCanvas1_Paint);
            // 
            // pbCanvas2
            // 
            this.pbCanvas2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pbCanvas2.Location = new System.Drawing.Point(2, 46);
            this.pbCanvas2.Name = "pbCanvas2";
            this.pbCanvas2.Size = new System.Drawing.Size(432, 424);
            this.pbCanvas2.TabIndex = 4;
            this.pbCanvas2.TabStop = false;
            this.pbCanvas2.Paint += new System.Windows.Forms.PaintEventHandler(this.pbCanvas2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(636, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(382, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(874, 471);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbCanvas2);
            this.Controls.Add(this.pbCanvas1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCanvas1;
        private System.Windows.Forms.Timer gameTimer1;
        private System.Windows.Forms.PictureBox pbCanvas2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer gametimer2;
        private System.Windows.Forms.Label label3;
    }
}

