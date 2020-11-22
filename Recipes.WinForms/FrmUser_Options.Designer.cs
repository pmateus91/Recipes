namespace Recipes.WinForms
{
    partial class FrmUser_Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUser));
            this.btDelete = new System.Windows.Forms.Button();
            this.btUnblock = new System.Windows.Forms.Button();
            this.btBlock = new System.Windows.Forms.Button();
            this.btChange = new System.Windows.Forms.Button();
            this.gvResultUsers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvResultUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // btDelete
            // 
            this.btDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.Image = global::Recipes.WinForms.Properties.Resources.delete;
            this.btDelete.Location = new System.Drawing.Point(850, 463);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(146, 50);
            this.btDelete.TabIndex = 4;
            this.btDelete.Text = "Eliminar";
            this.btDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Visible = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btUnblock
            // 
            this.btUnblock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btUnblock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUnblock.Image = global::Recipes.WinForms.Properties.Resources.patient_boy;
            this.btUnblock.Location = new System.Drawing.Point(850, 407);
            this.btUnblock.Name = "btUnblock";
            this.btUnblock.Size = new System.Drawing.Size(146, 50);
            this.btUnblock.TabIndex = 3;
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
            this.btBlock.Location = new System.Drawing.Point(850, 351);
            this.btBlock.Name = "btBlock";
            this.btBlock.Size = new System.Drawing.Size(146, 50);
            this.btBlock.TabIndex = 2;
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
            this.btChange.Location = new System.Drawing.Point(850, 295);
            this.btChange.Name = "btChange";
            this.btChange.Size = new System.Drawing.Size(146, 50);
            this.btChange.TabIndex = 1;
            this.btChange.Text = "Alterar";
            this.btChange.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btChange.UseVisualStyleBackColor = true;
            this.btChange.Click += new System.EventHandler(this.btChange_Click);
            // 
            // gvResultUsers
            // 
            this.gvResultUsers.AllowUserToAddRows = false;
            this.gvResultUsers.AllowUserToDeleteRows = false;
            this.gvResultUsers.AllowUserToResizeRows = false;
            this.gvResultUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvResultUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvResultUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvResultUsers.Location = new System.Drawing.Point(12, 62);
            this.gvResultUsers.MultiSelect = false;
            this.gvResultUsers.Name = "gvResultUsers";
            this.gvResultUsers.ReadOnly = true;
            this.gvResultUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvResultUsers.Size = new System.Drawing.Size(832, 656);
            this.gvResultUsers.TabIndex = 7;
            // 
            // FrmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btChange);
            this.Controls.Add(this.btBlock);
            this.Controls.Add(this.btUnblock);
            this.Controls.Add(this.gvResultUsers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Utilizadores";
            this.Load += new System.EventHandler(this.FrmUpdateBlockDelete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvResultUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btChange;
        private System.Windows.Forms.Button btBlock;
        private System.Windows.Forms.Button btUnblock;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.DataGridView gvResultUsers;
    }
}