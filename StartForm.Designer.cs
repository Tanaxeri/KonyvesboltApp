namespace KonyvesboltApp
{
    partial class StartForm
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
            this.cimlbl = new System.Windows.Forms.Label();
            this.konyvekbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cimlbl
            // 
            this.cimlbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cimlbl.AutoEllipsis = true;
            this.cimlbl.AutoSize = true;
            this.cimlbl.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cimlbl.Location = new System.Drawing.Point(475, 44);
            this.cimlbl.Name = "cimlbl";
            this.cimlbl.Size = new System.Drawing.Size(213, 42);
            this.cimlbl.TabIndex = 0;
            this.cimlbl.Text = "Könyvesbolt";
            this.cimlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // konyvekbtn
            // 
            this.konyvekbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.konyvekbtn.AutoEllipsis = true;
            this.konyvekbtn.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.konyvekbtn.Location = new System.Drawing.Point(89, 268);
            this.konyvekbtn.Name = "konyvekbtn";
            this.konyvekbtn.Size = new System.Drawing.Size(244, 96);
            this.konyvekbtn.TabIndex = 1;
            this.konyvekbtn.Text = "Könyvek";
            this.konyvekbtn.UseVisualStyleBackColor = true;
            this.konyvekbtn.Click += new System.EventHandler(this.konyvekbtn_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.konyvekbtn);
            this.Controls.Add(this.cimlbl);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Konyvesbolt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cimlbl;
        private System.Windows.Forms.Button konyvekbtn;
    }
}

