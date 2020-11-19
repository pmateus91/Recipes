
namespace Recipes.WinForms
{
    partial class FrmComments_Update
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
            this.tbComentario = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbComentario
            // 
            this.tbComentario.Location = new System.Drawing.Point(12, 56);
            this.tbComentario.Multiline = true;
            this.tbComentario.Name = "tbComentario";
            this.tbComentario.Size = new System.Drawing.Size(410, 126);
            this.tbComentario.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.Control;
            this.lblTitle.Font = new System.Drawing.Font("Gill Sans MT", 18.25F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblTitle.Location = new System.Drawing.Point(3, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(429, 34);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "―――  Alterar Comentário  ―――";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btSave
            // 
            this.btSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btSave.Image = global::Recipes.WinForms.Properties.Resources.add;
            this.btSave.Location = new System.Drawing.Point(301, 197);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(121, 40);
            this.btSave.TabIndex = 2;
            this.btSave.Text = "Guardar";
            this.btSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // FrmComents_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 251);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tbComentario);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 290);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(450, 290);
            this.Name = "FrmComents_Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Comentário";
            this.Load += new System.EventHandler(this.FrmInsertIngredient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbComentario;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btSave;
    }
}