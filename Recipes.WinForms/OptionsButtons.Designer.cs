
namespace Recipes.WinForms
{
    partial class OptionsButtons
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsButtons));
            this.btDelete = new System.Windows.Forms.Button();
            this.btChange = new System.Windows.Forms.Button();
            this.btInsert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btDelete
            // 
            this.btDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.Image = global::Recipes.WinForms.Properties.Resources.delete;
            this.btDelete.Location = new System.Drawing.Point(20, 124);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(146, 50);
            this.btDelete.TabIndex = 6;
            this.btDelete.Text = "Eliminar";
            this.btDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Visible = false;
            // 
            // btChange
            // 
            this.btChange.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChange.Image = global::Recipes.WinForms.Properties.Resources.track_changes;
            this.btChange.Location = new System.Drawing.Point(20, 68);
            this.btChange.Name = "btChange";
            this.btChange.Size = new System.Drawing.Size(146, 50);
            this.btChange.TabIndex = 5;
            this.btChange.Text = "Alterar";
            this.btChange.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btChange.UseVisualStyleBackColor = true;
            // 
            // btInsert
            // 
            this.btInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInsert.Image = global::Recipes.WinForms.Properties.Resources.add;
            this.btInsert.Location = new System.Drawing.Point(20, 12);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(146, 50);
            this.btInsert.TabIndex = 5;
            this.btInsert.Text = "Inserir";
            this.btInsert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btInsert.UseVisualStyleBackColor = true;
            // 
            // OptionsButtons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 192);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btInsert);
            this.Controls.Add(this.btChange);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(197, 231);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(197, 231);
            this.Name = "OptionsButtons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opções";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btChange;
        private System.Windows.Forms.Button btInsert;
    }
}