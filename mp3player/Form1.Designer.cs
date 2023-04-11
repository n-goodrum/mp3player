namespace mp3player
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
            this.playbutton = new System.Windows.Forms.Button();
            this.nextbutton = new System.Windows.Forms.Button();
            this.openfile = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playbutton
            // 
            this.playbutton.Location = new System.Drawing.Point(336, 369);
            this.playbutton.Name = "playbutton";
            this.playbutton.Size = new System.Drawing.Size(50, 50);
            this.playbutton.TabIndex = 0;
            this.playbutton.Text = "PLAY";
            this.playbutton.UseVisualStyleBackColor = true;
            this.playbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // nextbutton
            // 
            this.nextbutton.Location = new System.Drawing.Point(428, 369);
            this.nextbutton.Name = "nextbutton";
            this.nextbutton.Size = new System.Drawing.Size(50, 50);
            this.nextbutton.TabIndex = 1;
            this.nextbutton.Text = "NEXT";
            this.nextbutton.UseVisualStyleBackColor = true;
            this.nextbutton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // openfile
            // 
            this.openfile.Location = new System.Drawing.Point(53, 369);
            this.openfile.Name = "openfile";
            this.openfile.Size = new System.Drawing.Size(50, 50);
            this.openfile.TabIndex = 2;
            this.openfile.Text = "OPEN";
            this.openfile.UseVisualStyleBackColor = true;
            this.openfile.Click += new System.EventHandler(this.openfile_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(738, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(50, 50);
            this.close.TabIndex = 3;
            this.close.Text = "CLOSE";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.close);
            this.Controls.Add(this.openfile);
            this.Controls.Add(this.nextbutton);
            this.Controls.Add(this.playbutton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button playbutton;
        private System.Windows.Forms.Button nextbutton;
        private System.Windows.Forms.Button openfile;
        private System.Windows.Forms.Button close;
    }
}

