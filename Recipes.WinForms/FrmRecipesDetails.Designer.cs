
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRecipesDetails));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblRating_Output = new System.Windows.Forms.Label();
            this.lblStatus_Output = new System.Windows.Forms.Label();
            this.lblUser_Output = new System.Windows.Forms.Label();
            this.lblDuration_Output = new System.Windows.Forms.Label();
            this.lblDifficulty_Output = new System.Windows.Forms.Label();
            this.lblCategory_Output = new System.Windows.Forms.Label();
            this.lblName_Output = new System.Windows.Forms.Label();
            this.lblInstructions_Output = new System.Windows.Forms.Label();
            this.lblIngredients = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvDetalhesReceitaIngredientes = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btDelete = new System.Windows.Forms.Button();
            this.btDeactive = new System.Windows.Forms.Button();
            this.btActive = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalhesReceitaIngredientes)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1012, 733);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Controls.Add(this.lblIngredients);
            this.tabPage1.Controls.Add(this.lblTitle);
            this.tabPage1.Controls.Add(this.dgvDetalhesReceitaIngredientes);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1004, 702);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Detalhes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.7894F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.2106F));
            this.tableLayoutPanel1.Controls.Add(this.lblName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblStatus, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblUser, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblDifficulty, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblCategory, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblInstructions, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblDuration, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblRating, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblRating_Output, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblStatus_Output, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblUser_Output, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblDuration_Output, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblDifficulty_Output, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblCategory_Output, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblName_Output, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblInstructions_Output, 1, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 66);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 290F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(624, 624);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(3, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(58, 21);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Nome:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(3, 175);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(62, 21);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Estado:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(3, 140);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(69, 21);
            this.lblUser.TabIndex = 7;
            this.lblUser.Text = "Criador:";
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDifficulty.Location = new System.Drawing.Point(3, 70);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(94, 21);
            this.lblDifficulty.TabIndex = 7;
            this.lblDifficulty.Text = "Dificuldade:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(3, 35);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(83, 21);
            this.lblCategory.TabIndex = 7;
            this.lblCategory.Text = "Categoria:";
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(3, 245);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(87, 21);
            this.lblInstructions.TabIndex = 7;
            this.lblInstructions.Text = "Instruções:";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.Location = new System.Drawing.Point(3, 105);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(75, 21);
            this.lblDuration.TabIndex = 7;
            this.lblDuration.Text = "Duração:";
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRating.Location = new System.Drawing.Point(3, 210);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(90, 35);
            this.lblRating.TabIndex = 7;
            this.lblRating.Text = "Classificação:";
            // 
            // lblRating_Output
            // 
            this.lblRating_Output.AutoSize = true;
            this.lblRating_Output.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRating_Output.Location = new System.Drawing.Point(107, 210);
            this.lblRating_Output.Name = "lblRating_Output";
            this.lblRating_Output.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.lblRating_Output.Size = new System.Drawing.Size(97, 19);
            this.lblRating_Output.TabIndex = 8;
            this.lblRating_Output.Text = "lblRating_Output";
            // 
            // lblStatus_Output
            // 
            this.lblStatus_Output.AutoSize = true;
            this.lblStatus_Output.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStatus_Output.Location = new System.Drawing.Point(107, 175);
            this.lblStatus_Output.Name = "lblStatus_Output";
            this.lblStatus_Output.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.lblStatus_Output.Size = new System.Drawing.Size(95, 19);
            this.lblStatus_Output.TabIndex = 8;
            this.lblStatus_Output.Text = "lblStatus_Output";
            // 
            // lblUser_Output
            // 
            this.lblUser_Output.AutoSize = true;
            this.lblUser_Output.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblUser_Output.Location = new System.Drawing.Point(107, 140);
            this.lblUser_Output.Name = "lblUser_Output";
            this.lblUser_Output.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.lblUser_Output.Size = new System.Drawing.Size(86, 19);
            this.lblUser_Output.TabIndex = 8;
            this.lblUser_Output.Text = "lblUser_Output";
            // 
            // lblDuration_Output
            // 
            this.lblDuration_Output.AutoSize = true;
            this.lblDuration_Output.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDuration_Output.Location = new System.Drawing.Point(107, 105);
            this.lblDuration_Output.Name = "lblDuration_Output";
            this.lblDuration_Output.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.lblDuration_Output.Size = new System.Drawing.Size(109, 19);
            this.lblDuration_Output.TabIndex = 8;
            this.lblDuration_Output.Text = "lblDuration_Output";
            // 
            // lblDifficulty_Output
            // 
            this.lblDifficulty_Output.AutoSize = true;
            this.lblDifficulty_Output.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDifficulty_Output.Location = new System.Drawing.Point(107, 70);
            this.lblDifficulty_Output.Name = "lblDifficulty_Output";
            this.lblDifficulty_Output.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.lblDifficulty_Output.Size = new System.Drawing.Size(111, 19);
            this.lblDifficulty_Output.TabIndex = 8;
            this.lblDifficulty_Output.Text = "lblDifficulty_Output";
            // 
            // lblCategory_Output
            // 
            this.lblCategory_Output.AutoSize = true;
            this.lblCategory_Output.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCategory_Output.Location = new System.Drawing.Point(107, 35);
            this.lblCategory_Output.Name = "lblCategory_Output";
            this.lblCategory_Output.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.lblCategory_Output.Size = new System.Drawing.Size(111, 19);
            this.lblCategory_Output.TabIndex = 8;
            this.lblCategory_Output.Text = "lblCategory_Output";
            // 
            // lblName_Output
            // 
            this.lblName_Output.AutoSize = true;
            this.lblName_Output.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblName_Output.Location = new System.Drawing.Point(107, 0);
            this.lblName_Output.Name = "lblName_Output";
            this.lblName_Output.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.lblName_Output.Size = new System.Drawing.Size(95, 19);
            this.lblName_Output.TabIndex = 8;
            this.lblName_Output.Text = "lblName_Output";
            // 
            // lblInstructions_Output
            // 
            this.lblInstructions_Output.AutoSize = true;
            this.lblInstructions_Output.Location = new System.Drawing.Point(107, 245);
            this.lblInstructions_Output.Name = "lblInstructions_Output";
            this.lblInstructions_Output.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.lblInstructions_Output.Size = new System.Drawing.Size(125, 19);
            this.lblInstructions_Output.TabIndex = 8;
            this.lblInstructions_Output.Text = "lblInstructions_Output";
            // 
            // lblIngredients
            // 
            this.lblIngredients.AutoSize = true;
            this.lblIngredients.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredients.Location = new System.Drawing.Point(742, 42);
            this.lblIngredients.Name = "lblIngredients";
            this.lblIngredients.Size = new System.Drawing.Size(155, 21);
            this.lblIngredients.TabIndex = 7;
            this.lblIngredients.Text = "Lista de Ingredientes";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.Font = new System.Drawing.Font("Gill Sans MT", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(-4, -2);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1008, 38);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "――――――   DETALHES   ――――――";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvDetalhesReceitaIngredientes
            // 
            this.dgvDetalhesReceitaIngredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalhesReceitaIngredientes.Location = new System.Drawing.Point(638, 66);
            this.dgvDetalhesReceitaIngredientes.Name = "dgvDetalhesReceitaIngredientes";
            this.dgvDetalhesReceitaIngredientes.Size = new System.Drawing.Size(354, 624);
            this.dgvDetalhesReceitaIngredientes.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btDelete);
            this.tabPage2.Controls.Add(this.btDeactive);
            this.tabPage2.Controls.Add(this.btActive);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1004, 702);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Comentários";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(-4, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1008, 38);
            this.label1.TabIndex = 7;
            this.label1.Text = "――――――   COMENTÁRIOS   ――――――";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btDelete
            // 
            this.btDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.Image = global::Recipes.WinForms.Properties.Resources.delete;
            this.btDelete.Location = new System.Drawing.Point(871, 178);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(127, 52);
            this.btDelete.TabIndex = 2;
            this.btDelete.Text = "Eliminar";
            this.btDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btDelete.UseVisualStyleBackColor = true;
            // 
            // btDeactive
            // 
            this.btDeactive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btDeactive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeactive.Image = global::Recipes.WinForms.Properties.Resources.checkbox_cross;
            this.btDeactive.Location = new System.Drawing.Point(871, 122);
            this.btDeactive.Name = "btDeactive";
            this.btDeactive.Size = new System.Drawing.Size(127, 50);
            this.btDeactive.TabIndex = 3;
            this.btDeactive.Text = "Desactivar";
            this.btDeactive.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btDeactive.UseVisualStyleBackColor = true;
            // 
            // btActive
            // 
            this.btActive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btActive.Image = global::Recipes.WinForms.Properties.Resources.checkbox_circle;
            this.btActive.Location = new System.Drawing.Point(871, 66);
            this.btActive.Name = "btActive";
            this.btActive.Size = new System.Drawing.Size(127, 50);
            this.btActive.TabIndex = 3;
            this.btActive.Text = "Activar";
            this.btActive.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btActive.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(862, 630);
            this.dataGridView1.TabIndex = 0;
            // 
            // FrmRecipesDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRecipesDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalhes da Receita";
            this.Load += new System.EventHandler(this.FrmRecipesDetails_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalhesReceitaIngredientes)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvDetalhesReceitaIngredientes;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btActive;
        private System.Windows.Forms.Button btDeactive;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblInstructions_Output;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.Label lblIngredients;
        private System.Windows.Forms.Label lblRating_Output;
        private System.Windows.Forms.Label lblStatus_Output;
        private System.Windows.Forms.Label lblUser_Output;
        private System.Windows.Forms.Label lblDuration_Output;
        private System.Windows.Forms.Label lblDifficulty_Output;
        private System.Windows.Forms.Label lblCategory_Output;
        private System.Windows.Forms.Label lblName_Output;
        private System.Windows.Forms.Label label1;
    }
}