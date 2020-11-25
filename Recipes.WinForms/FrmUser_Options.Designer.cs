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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUser_Options));
            this.btUnblock = new System.Windows.Forms.Button();
            this.btChange = new System.Windows.Forms.Button();
            this.gvResultUsers = new System.Windows.Forms.DataGridView();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvResultUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btUnblock
            // 
            this.btUnblock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btUnblock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUnblock.Image = global::Recipes.WinForms.Properties.Resources.patient_boy;
            this.btUnblock.Location = new System.Drawing.Point(871, 164);
            this.btUnblock.Name = "btUnblock";
            this.btUnblock.Size = new System.Drawing.Size(130, 50);
            this.btUnblock.TabIndex = 2;
            this.btUnblock.Text = "Desbloquear";
            this.btUnblock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btUnblock.UseVisualStyleBackColor = true;
            this.btUnblock.Visible = false;
            this.btUnblock.Click += new System.EventHandler(this.btUnblock_Click);
            // 
            // btChange
            // 
            this.btChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChange.Image = global::Recipes.WinForms.Properties.Resources.track_changes;
            this.btChange.Location = new System.Drawing.Point(871, 108);
            this.btChange.Name = "btChange";
            this.btChange.Size = new System.Drawing.Size(130, 50);
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
            this.gvResultUsers.Location = new System.Drawing.Point(12, 108);
            this.gvResultUsers.MultiSelect = false;
            this.gvResultUsers.Name = "gvResultUsers";
            this.gvResultUsers.ReadOnly = true;
            this.gvResultUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvResultUsers.Size = new System.Drawing.Size(852, 609);
            this.gvResultUsers.TabIndex = 0;
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbSearch.Location = new System.Drawing.Point(416, 65);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(325, 20);
            this.tbSearch.TabIndex = 15;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Gill Sans MT", 16F, System.Drawing.FontStyle.Bold);
            this.lblSearch.Location = new System.Drawing.Point(298, 58);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(112, 31);
            this.lblSearch.TabIndex = 16;
            this.lblSearch.Text = "Pesquisar";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.Font = new System.Drawing.Font("Gill Sans MT", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(-7, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1022, 38);
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Text = "――――――   UTILIZADORES   ――――――";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::Recipes.WinForms.Properties.Resources.zoom;
            this.pictureBox1.Location = new System.Drawing.Point(258, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 34);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // FrmUser_Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btChange);
            this.Controls.Add(this.btUnblock);
            this.Controls.Add(this.gvResultUsers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUser_Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Utilizadores";
            this.Load += new System.EventHandler(this.FrmUser_Options_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvResultUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btChange;
        private System.Windows.Forms.Button btUnblock;
        private System.Windows.Forms.DataGridView gvResultUsers;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}