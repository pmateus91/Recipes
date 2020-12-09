
namespace Recipes.WinForms
{
    partial class FrmRecipesInsert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRecipesInsert));
            this.lblIngredients = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gvInsertedIngredients = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbIngredients = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btInsertIngredient = new System.Windows.Forms.Button();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.tbInstructions = new System.Windows.Forms.TextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.cbUnity = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cbDifficulty = new System.Windows.Forms.ComboBox();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.tbDuration = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvInsertedIngredients)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIngredients
            // 
            this.lblIngredients.AutoSize = true;
            this.lblIngredients.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredients.Location = new System.Drawing.Point(439, 408);
            this.lblIngredients.Name = "lblIngredients";
            this.lblIngredients.Size = new System.Drawing.Size(69, 21);
            this.lblIngredients.TabIndex = 12;
            this.lblIngredients.Text = "Unidade";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.Font = new System.Drawing.Font("Gill Sans MT", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(-87, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1008, 38);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "――――――   INSERIR  RECEITA ――――――";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gvInsertedIngredients
            // 
            this.gvInsertedIngredients.AllowUserToAddRows = false;
            this.gvInsertedIngredients.AllowUserToDeleteRows = false;
            this.gvInsertedIngredients.AllowUserToResizeColumns = false;
            this.gvInsertedIngredients.AllowUserToResizeRows = false;
            this.gvInsertedIngredients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvInsertedIngredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvInsertedIngredients.Location = new System.Drawing.Point(12, 451);
            this.gvInsertedIngredients.Name = "gvInsertedIngredients";
            this.gvInsertedIngredients.Size = new System.Drawing.Size(818, 211);
            this.gvInsertedIngredients.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Quantidade";
            // 
            // cbIngredients
            // 
            this.cbIngredients.FormattingEnabled = true;
            this.cbIngredients.Location = new System.Drawing.Point(100, 410);
            this.cbIngredients.Name = "cbIngredients";
            this.cbIngredients.Size = new System.Drawing.Size(157, 21);
            this.cbIngredients.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ingrediente";
            // 
            // btInsertIngredient
            // 
            this.btInsertIngredient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btInsertIngredient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInsertIngredient.Image = global::Recipes.WinForms.Properties.Resources.add;
            this.btInsertIngredient.Location = new System.Drawing.Point(636, 397);
            this.btInsertIngredient.Name = "btInsertIngredient";
            this.btInsertIngredient.Size = new System.Drawing.Size(187, 40);
            this.btInsertIngredient.TabIndex = 16;
            this.btInsertIngredient.Text = "Adicionar Ingrediente";
            this.btInsertIngredient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btInsertIngredient.UseVisualStyleBackColor = true;
            this.btInsertIngredient.Click += new System.EventHandler(this.btInsertIngredient_Click);
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(15, 190);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(87, 21);
            this.lblInstructions.TabIndex = 17;
            this.lblInstructions.Text = "Instruções:";
            // 
            // tbInstructions
            // 
            this.tbInstructions.Location = new System.Drawing.Point(114, 192);
            this.tbInstructions.Multiline = true;
            this.tbInstructions.Name = "tbInstructions";
            this.tbInstructions.Size = new System.Drawing.Size(716, 190);
            this.tbInstructions.TabIndex = 18;
            // 
            // btSave
            // 
            this.btSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.Image = global::Recipes.WinForms.Properties.Resources.add;
            this.btSave.Location = new System.Drawing.Point(658, 673);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(172, 40);
            this.btSave.TabIndex = 19;
            this.btSave.Text = "Guardar Receita";
            this.btSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(364, 409);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(66, 20);
            this.tbQuantity.TabIndex = 15;
            // 
            // cbUnity
            // 
            this.cbUnity.FormattingEnabled = true;
            this.cbUnity.Items.AddRange(new object[] {
            "gramas",
            "colher de chá",
            "colher de café",
            "colher de sopa",
            "xícara",
            "ml",
            "q.b"});
            this.cbUnity.Location = new System.Drawing.Point(511, 410);
            this.cbUnity.Name = "cbUnity";
            this.cbUnity.Size = new System.Drawing.Size(105, 21);
            this.cbUnity.TabIndex = 20;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(16, 70);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(58, 21);
            this.lblName.TabIndex = 21;
            this.lblName.Text = "Nome:";
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDifficulty.Location = new System.Drawing.Point(16, 130);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(94, 21);
            this.lblDifficulty.TabIndex = 22;
            this.lblDifficulty.Text = "Dificuldade:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(114, 72);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(350, 20);
            this.tbName.TabIndex = 27;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(114, 102);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(175, 21);
            this.cbCategory.TabIndex = 25;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(16, 100);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(83, 21);
            this.lblCategory.TabIndex = 23;
            this.lblCategory.Text = "Categoria:";
            // 
            // cbDifficulty
            // 
            this.cbDifficulty.FormattingEnabled = true;
            this.cbDifficulty.Location = new System.Drawing.Point(114, 132);
            this.cbDifficulty.Name = "cbDifficulty";
            this.cbDifficulty.Size = new System.Drawing.Size(175, 21);
            this.cbDifficulty.TabIndex = 26;
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.Location = new System.Drawing.Point(16, 160);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(75, 21);
            this.lblDuration.TabIndex = 24;
            this.lblDuration.Text = "Duração:";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Font = new System.Drawing.Font("Gill Sans MT", 10F, System.Drawing.FontStyle.Bold);
            this.lblMin.Location = new System.Drawing.Point(227, 161);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(62, 21);
            this.lblMin.TabIndex = 29;
            this.lblMin.Text = "Minutos";
            // 
            // tbDuration
            // 
            this.tbDuration.Location = new System.Drawing.Point(114, 162);
            this.tbDuration.Name = "tbDuration";
            this.tbDuration.Size = new System.Drawing.Size(107, 20);
            this.tbDuration.TabIndex = 28;
            // 
            // FrmRecipesInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 725);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblDifficulty);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cbDifficulty);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.tbDuration);
            this.Controls.Add(this.cbUnity);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.tbInstructions);
            this.Controls.Add(this.btInsertIngredient);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.cbIngredients);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblIngredients);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.gvInsertedIngredients);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRecipesInsert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalhes da Receita";
            this.Load += new System.EventHandler(this.FrmRecipesInsert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvInsertedIngredients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblIngredients;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView gvInsertedIngredients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbIngredients;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btInsertIngredient;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.TextBox tbInstructions;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.ComboBox cbUnity;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cbDifficulty;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.TextBox tbDuration;
    }
}