namespace JogoGourmet.Views
{
    partial class frmOPratoEh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOPratoEh));
            this.txtAdjetivo = new System.Windows.Forms.TextBox();
            this.lblOPratoEh = new System.Windows.Forms.Label();
            this.btnCancelOPratoEh = new System.Windows.Forms.Button();
            this.btnOkOPratoEh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAdjetivo
            // 
            this.txtAdjetivo.Location = new System.Drawing.Point(37, 43);
            this.txtAdjetivo.Margin = new System.Windows.Forms.Padding(5);
            this.txtAdjetivo.Name = "txtAdjetivo";
            this.txtAdjetivo.Size = new System.Drawing.Size(289, 23);
            this.txtAdjetivo.TabIndex = 1;
            // 
            // lblOPratoEh
            // 
            this.lblOPratoEh.AutoSize = true;
            this.lblOPratoEh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOPratoEh.Location = new System.Drawing.Point(14, 9);
            this.lblOPratoEh.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblOPratoEh.Name = "lblOPratoEh";
            this.lblOPratoEh.Size = new System.Drawing.Size(0, 15);
            this.lblOPratoEh.TabIndex = 6;
            // 
            // btnCancelOPratoEh
            // 
            this.btnCancelOPratoEh.Location = new System.Drawing.Point(211, 84);
            this.btnCancelOPratoEh.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancelOPratoEh.Name = "btnCancelOPratoEh";
            this.btnCancelOPratoEh.Size = new System.Drawing.Size(100, 28);
            this.btnCancelOPratoEh.TabIndex = 3;
            this.btnCancelOPratoEh.Text = "Cancelar";
            this.btnCancelOPratoEh.UseVisualStyleBackColor = true;
            this.btnCancelOPratoEh.Click += new System.EventHandler(this.btnCancelOPratoEh_Click);
            // 
            // btnOkOPratoEh
            // 
            this.btnOkOPratoEh.Location = new System.Drawing.Point(48, 84);
            this.btnOkOPratoEh.Margin = new System.Windows.Forms.Padding(5);
            this.btnOkOPratoEh.Name = "btnOkOPratoEh";
            this.btnOkOPratoEh.Size = new System.Drawing.Size(100, 28);
            this.btnOkOPratoEh.TabIndex = 2;
            this.btnOkOPratoEh.Text = "OK";
            this.btnOkOPratoEh.UseVisualStyleBackColor = true;
            this.btnOkOPratoEh.Click += new System.EventHandler(this.btnOkOPratoEh_Click);
            // 
            // frmOPratoEh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 126);
            this.Controls.Add(this.txtAdjetivo);
            this.Controls.Add(this.lblOPratoEh);
            this.Controls.Add(this.btnCancelOPratoEh);
            this.Controls.Add(this.btnOkOPratoEh);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmOPratoEh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Complete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdjetivo;
        private System.Windows.Forms.Label lblOPratoEh;
        private System.Windows.Forms.Button btnCancelOPratoEh;
        private System.Windows.Forms.Button btnOkOPratoEh;
    }
}