namespace Recipes.WinForms
{
    partial class FrmRecipes
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
            this.gvResultRecepies = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btDelete = new System.Windows.Forms.Button();
            this.btValidate = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvResultRecepies)).BeginInit();
            this.SuspendLayout();
            // 
            // gvResultRecepies
            // 
            this.gvResultRecepies.AllowUserToAddRows = false;
            this.gvResultRecepies.AllowUserToDeleteRows = false;
            this.gvResultRecepies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvResultRecepies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvResultRecepies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvResultRecepies.Location = new System.Drawing.Point(12, 46);
            this.gvResultRecepies.MultiSelect = false;
            this.gvResultRecepies.Name = "gvResultRecepies";
            this.gvResultRecepies.ReadOnly = true;
            this.gvResultRecepies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvResultRecepies.Size = new System.Drawing.Size(871, 671);
            this.gvResultRecepies.TabIndex = 0;
            this.gvResultRecepies.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvResultRecepies_CellDoubleClick);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Rockwell Extra Bold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(373, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(155, 32);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Receitas";
            // 
            // btDelete
            // 
            this.btDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.Image = global::Recipes.WinForms.Properties.Resources.delete;
            this.btDelete.Location = new System.Drawing.Point(889, 158);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(107, 52);
            this.btDelete.TabIndex = 1;
            this.btDelete.Text = "Eliminar";
            this.btDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btDelete.UseVisualStyleBackColor = true;
            // 
            // btValidate
            // 
            this.btValidate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btValidate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btValidate.Image = global::Recipes.WinForms.Properties.Resources.checkmark;
            this.btValidate.Location = new System.Drawing.Point(889, 46);
            this.btValidate.Name = "btValidate";
            this.btValidate.Size = new System.Drawing.Size(107, 50);
            this.btValidate.TabIndex = 1;
            this.btValidate.Text = "Validar";
            this.btValidate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btValidate.UseVisualStyleBackColor = true;
            // 
            // btUpdate
            // 
            this.btUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdate.Image = global::Recipes.WinForms.Properties.Resources.track_changes;
            this.btUpdate.Location = new System.Drawing.Point(889, 102);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(107, 50);
            this.btUpdate.TabIndex = 1;
            this.btUpdate.Text = "Alterar";
            this.btUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btUpdate.UseVisualStyleBackColor = true;
            // 
            // FrmRecipes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btValidate);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.gvResultRecepies);
            this.Name = "FrmRecipes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receitas";
            this.Load += new System.EventHandler(this.FrmRecipes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvResultRecepies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvResultRecepies;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btValidate;
        private System.Windows.Forms.Label lblTitulo;
    }
}