
namespace Recipes.WinForms
{
    partial class FrmRecipesDetails
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPageIngredientes = new System.Windows.Forms.TabPage();
            this.lblProductName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gvResultadoIngredientes = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPageIngredientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvResultadoIngredientes)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPageIngredientes);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblProductName);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Descrição";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPageIngredientes
            // 
            this.tabPageIngredientes.Controls.Add(this.gvResultadoIngredientes);
            this.tabPageIngredientes.Location = new System.Drawing.Point(4, 22);
            this.tabPageIngredientes.Name = "tabPageIngredientes";
            this.tabPageIngredientes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageIngredientes.Size = new System.Drawing.Size(768, 400);
            this.tabPageIngredientes.TabIndex = 1;
            this.tabPageIngredientes.Text = "Ingredientes";
            this.tabPageIngredientes.UseVisualStyleBackColor = true;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(99, 16);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(0, 13);
            this.lblProductName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Product Name:";
            // 
            // gvResultadoIngredientes
            // 
            this.gvResultadoIngredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvResultadoIngredientes.Location = new System.Drawing.Point(0, 0);
            this.gvResultadoIngredientes.Name = "gvResultadoIngredientes";
            this.gvResultadoIngredientes.Size = new System.Drawing.Size(768, 400);
            this.gvResultadoIngredientes.TabIndex = 0;
            // 
            // FrmRecipesDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmRecipesDetails";
            this.Text = "FrmRecipesDetails";
            this.Load += new System.EventHandler(this.FrmRecipesDetails_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPageIngredientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvResultadoIngredientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageIngredientes;
        private System.Windows.Forms.DataGridView gvResultadoIngredientes;
    }
}