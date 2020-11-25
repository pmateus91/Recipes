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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRecipes));
            this.gvResultRecepies = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvResultRecepies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.gvResultRecepies.Location = new System.Drawing.Point(12, 108);
            this.gvResultRecepies.MultiSelect = false;
            this.gvResultRecepies.Name = "gvResultRecepies";
            this.gvResultRecepies.ReadOnly = true;
            this.gvResultRecepies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvResultRecepies.Size = new System.Drawing.Size(984, 609);
            this.gvResultRecepies.TabIndex = 0;
            this.gvResultRecepies.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvResultRecepies_CellDoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::Recipes.WinForms.Properties.Resources.zoom;
            this.pictureBox1.Location = new System.Drawing.Point(258, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 34);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbSearch.Location = new System.Drawing.Point(416, 65);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(325, 20);
            this.tbSearch.TabIndex = 13;
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
            this.lblSearch.TabIndex = 14;
            this.lblSearch.Text = "Pesquisar";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.Font = new System.Drawing.Font("Gill Sans MT", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(-7, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1022, 38);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "――――――   RECEITAS   ――――――";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmRecipes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.gvResultRecepies);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRecipes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receitas";
            this.Load += new System.EventHandler(this.FrmRecipes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvResultRecepies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvResultRecepies;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblTitle;
    }
}