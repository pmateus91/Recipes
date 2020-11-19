namespace Recipes.WinForms
{
    partial class FrmUser_UpdateBlockDelete
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
            this.gvResult = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btDelete = new System.Windows.Forms.Button();
            this.btUnblock = new System.Windows.Forms.Button();
            this.btBlock = new System.Windows.Forms.Button();
            this.btChange = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // gvResult
            // 
            this.gvResult.AllowUserToAddRows = false;
            this.gvResult.AllowUserToDeleteRows = false;
            this.gvResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvResult.Location = new System.Drawing.Point(12, 46);
            this.gvResult.Name = "gvResult";
            this.gvResult.ReadOnly = true;
            this.gvResult.Size = new System.Drawing.Size(832, 671);
            this.gvResult.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Rockwell Extra Bold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(341, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(0, 32);
            this.lblTitulo.TabIndex = 4;
            // 
            // btDelete
            // 
            this.btDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.Image = global::Recipes.WinForms.Properties.Resources.delete;
            this.btDelete.Location = new System.Drawing.Point(850, 214);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(146, 50);
            this.btDelete.TabIndex = 6;
            this.btDelete.Text = "Eliminar";
            this.btDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Visible = false;
            // 
            // btUnblock
            // 
            this.btUnblock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btUnblock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUnblock.Image = global::Recipes.WinForms.Properties.Resources.patient_boy;
            this.btUnblock.Location = new System.Drawing.Point(850, 158);
            this.btUnblock.Name = "btUnblock";
            this.btUnblock.Size = new System.Drawing.Size(146, 50);
            this.btUnblock.TabIndex = 6;
            this.btUnblock.Text = "Desbloquear";
            this.btUnblock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btUnblock.UseVisualStyleBackColor = true;
            this.btUnblock.Visible = false;
            // 
            // btBlock
            // 
            this.btBlock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btBlock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBlock.Image = global::Recipes.WinForms.Properties.Resources.status_busy;
            this.btBlock.Location = new System.Drawing.Point(850, 102);
            this.btBlock.Name = "btBlock";
            this.btBlock.Size = new System.Drawing.Size(146, 50);
            this.btBlock.TabIndex = 6;
            this.btBlock.Text = "Bloquear";
            this.btBlock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btBlock.UseVisualStyleBackColor = true;
            this.btBlock.Visible = false;
            // 
            // btChange
            // 
            this.btChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChange.Image = global::Recipes.WinForms.Properties.Resources.track_changes;
            this.btChange.Location = new System.Drawing.Point(850, 46);
            this.btChange.Name = "btChange";
            this.btChange.Size = new System.Drawing.Size(146, 50);
            this.btChange.TabIndex = 6;
            this.btChange.Text = "Alterar";
            this.btChange.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btChange.UseVisualStyleBackColor = true;
            this.btChange.Click += new System.EventHandler(this.btChange_Click);
            // 
            // FrmUpdateBlockDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btUnblock);
            this.Controls.Add(this.btBlock);
            this.Controls.Add(this.btChange);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.gvResult);
            this.Name = "FrmUpdateBlockDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmUpdateBlockDelete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvResult;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btChange;
        private System.Windows.Forms.Button btBlock;
        private System.Windows.Forms.Button btUnblock;
        private System.Windows.Forms.Button btDelete;
    }
}