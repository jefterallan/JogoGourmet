namespace JogoGourmet.Views
{
    partial class frmQualPrato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQualPrato));
            this.btnOkQualPrato = new System.Windows.Forms.Button();
            this.btnCancelQualPrato = new System.Windows.Forms.Button();
            this.lblQualPrato = new System.Windows.Forms.Label();
            this.txtQualPrato = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOkQualPrato
            // 
            this.btnOkQualPrato.Location = new System.Drawing.Point(48, 84);
            this.btnOkQualPrato.Margin = new System.Windows.Forms.Padding(4);
            this.btnOkQualPrato.Name = "btnOkQualPrato";
            this.btnOkQualPrato.Size = new System.Drawing.Size(100, 28);
            this.btnOkQualPrato.TabIndex = 2;
            this.btnOkQualPrato.Text = "OK";
            this.btnOkQualPrato.UseVisualStyleBackColor = true;
            this.btnOkQualPrato.Click += new System.EventHandler(this.btnOkQualPrato_Click);
            // 
            // btnCancelQualPrato
            // 
            this.btnCancelQualPrato.Location = new System.Drawing.Point(211, 84);
            this.btnCancelQualPrato.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelQualPrato.Name = "btnCancelQualPrato";
            this.btnCancelQualPrato.Size = new System.Drawing.Size(100, 28);
            this.btnCancelQualPrato.TabIndex = 3;
            this.btnCancelQualPrato.Text = "Cancelar";
            this.btnCancelQualPrato.UseVisualStyleBackColor = true;
            this.btnCancelQualPrato.Click += new System.EventHandler(this.btnCancelQualPrato_Click);
            // 
            // lblQualPrato
            // 
            this.lblQualPrato.AutoSize = true;
            this.lblQualPrato.Location = new System.Drawing.Point(92, 9);
            this.lblQualPrato.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQualPrato.Name = "lblQualPrato";
            this.lblQualPrato.Size = new System.Drawing.Size(168, 17);
            this.lblQualPrato.TabIndex = 2;
            this.lblQualPrato.Text = "Qual prato voce pensou?";
            // 
            // txtQualPrato
            // 
            this.txtQualPrato.Location = new System.Drawing.Point(37, 43);
            this.txtQualPrato.Margin = new System.Windows.Forms.Padding(4);
            this.txtQualPrato.Name = "txtQualPrato";
            this.txtQualPrato.Size = new System.Drawing.Size(289, 23);
            this.txtQualPrato.TabIndex = 1;
            // 
            // frmQualPrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 126);
            this.Controls.Add(this.txtQualPrato);
            this.Controls.Add(this.lblQualPrato);
            this.Controls.Add(this.btnCancelQualPrato);
            this.Controls.Add(this.btnOkQualPrato);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQualPrato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desisto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOkQualPrato;
        private System.Windows.Forms.Button btnCancelQualPrato;
        private System.Windows.Forms.Label lblQualPrato;
        private System.Windows.Forms.TextBox txtQualPrato;
    }
}