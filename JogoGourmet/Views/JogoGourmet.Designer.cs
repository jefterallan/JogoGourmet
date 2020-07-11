namespace JogoGourmet.Views
{
    partial class frmJogoGourmet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJogoGourmet));
            this.lblInit = new System.Windows.Forms.Label();
            this.btnOkInit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInit
            // 
            this.lblInit.AutoSize = true;
            this.lblInit.Location = new System.Drawing.Point(86, 24);
            this.lblInit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInit.Name = "lblInit";
            this.lblInit.Size = new System.Drawing.Size(198, 17);
            this.lblInit.TabIndex = 0;
            this.lblInit.Text = "Pense em um prato que gosta";
            // 
            // btnOkInit
            // 
            this.btnOkInit.Location = new System.Drawing.Point(122, 71);
            this.btnOkInit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOkInit.Name = "btnOkInit";
            this.btnOkInit.Size = new System.Drawing.Size(100, 28);
            this.btnOkInit.TabIndex = 1;
            this.btnOkInit.Text = "OK";
            this.btnOkInit.UseVisualStyleBackColor = true;
            this.btnOkInit.Click += new System.EventHandler(this.btnOkInit_Click);
            // 
            // frmJogoGourmet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 126);
            this.Controls.Add(this.btnOkInit);
            this.Controls.Add(this.lblInit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmJogoGourmet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo Gourmet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInit;
        private System.Windows.Forms.Button btnOkInit;
    }
}

