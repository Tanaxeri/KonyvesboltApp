namespace KonyvesboltApp
{
    partial class KonyvekForm
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
            this.KonyvekList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // KonyvekList
            // 
            this.KonyvekList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KonyvekList.FormattingEnabled = true;
            this.KonyvekList.ItemHeight = 19;
            this.KonyvekList.Location = new System.Drawing.Point(0, 0);
            this.KonyvekList.Name = "KonyvekList";
            this.KonyvekList.Size = new System.Drawing.Size(1200, 658);
            this.KonyvekList.TabIndex = 0;
            // 
            // KonyvekForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.KonyvekList);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "KonyvekForm";
            this.Text = "KonyvekForm";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox KonyvekList;
    }
}