namespace Recipe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tv_search_by_ingr = new System.Windows.Forms.TreeView();
            this.but_give_rec_2 = new System.Windows.Forms.Button();
            this.but_make_recipe = new System.Windows.Forms.Button();
            this.but_add_rec = new System.Windows.Forms.Button();
            this.gb_choix = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_chosen = new System.Windows.Forms.Label();
            this.label_ingr = new System.Windows.Forms.Label();
            this.tb_ingr = new System.Windows.Forms.TextBox();
            this.tb_date = new System.Windows.Forms.TextBox();
            this.label_date = new System.Windows.Forms.Label();
            this.tb_chosen_rec = new System.Windows.Forms.TextBox();
            this.gb_choix.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tv_search_by_ingr
            // 
            this.tv_search_by_ingr.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tv_search_by_ingr.CheckBoxes = true;
            this.tv_search_by_ingr.FullRowSelect = true;
            this.tv_search_by_ingr.Location = new System.Drawing.Point(32, 34);
            this.tv_search_by_ingr.Name = "tv_search_by_ingr";
            this.tv_search_by_ingr.Size = new System.Drawing.Size(275, 377);
            this.tv_search_by_ingr.TabIndex = 13;
            this.tv_search_by_ingr.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tv_search_by_ingr_AfterCheck);
            // 
            // but_give_rec_2
            // 
            this.but_give_rec_2.BackColor = System.Drawing.Color.Lavender;
            this.but_give_rec_2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.but_give_rec_2.Location = new System.Drawing.Point(83, 505);
            this.but_give_rec_2.Name = "but_give_rec_2";
            this.but_give_rec_2.Size = new System.Drawing.Size(239, 41);
            this.but_give_rec_2.TabIndex = 14;
            this.but_give_rec_2.Text = "Trouver une recette";
            this.but_give_rec_2.UseVisualStyleBackColor = false;
            this.but_give_rec_2.Click += new System.EventHandler(this.but_give_rec_2_Click);
            // 
            // but_make_recipe
            // 
            this.but_make_recipe.BackColor = System.Drawing.Color.Lavender;
            this.but_make_recipe.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.but_make_recipe.Location = new System.Drawing.Point(487, 505);
            this.but_make_recipe.Name = "but_make_recipe";
            this.but_make_recipe.Size = new System.Drawing.Size(239, 41);
            this.but_make_recipe.TabIndex = 18;
            this.but_make_recipe.Text = "Choisir cette recette";
            this.but_make_recipe.UseVisualStyleBackColor = false;
            this.but_make_recipe.Click += new System.EventHandler(this.but_make_recipe_Click);
            // 
            // but_add_rec
            // 
            this.but_add_rec.BackColor = System.Drawing.Color.Lavender;
            this.but_add_rec.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.but_add_rec.Location = new System.Drawing.Point(847, 262);
            this.but_add_rec.Name = "but_add_rec";
            this.but_add_rec.Size = new System.Drawing.Size(238, 81);
            this.but_add_rec.TabIndex = 19;
            this.but_add_rec.Text = "Modifier la liste des recettes et ingrédients";
            this.but_add_rec.UseVisualStyleBackColor = false;
            this.but_add_rec.Click += new System.EventHandler(this.but_add_rec_Click);
            // 
            // gb_choix
            // 
            this.gb_choix.Controls.Add(this.tv_search_by_ingr);
            this.gb_choix.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gb_choix.Location = new System.Drawing.Point(29, 50);
            this.gb_choix.Name = "gb_choix";
            this.gb_choix.Size = new System.Drawing.Size(335, 439);
            this.gb_choix.TabIndex = 20;
            this.gb_choix.TabStop = false;
            this.gb_choix.Text = "Choix des Ingrédients (facultatif)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_chosen);
            this.groupBox1.Controls.Add(this.label_ingr);
            this.groupBox1.Controls.Add(this.tb_ingr);
            this.groupBox1.Controls.Add(this.tb_date);
            this.groupBox1.Controls.Add(this.label_date);
            this.groupBox1.Controls.Add(this.tb_chosen_rec);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(429, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 439);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recette Obtenue";
            // 
            // label_chosen
            // 
            this.label_chosen.AutoSize = true;
            this.label_chosen.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_chosen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_chosen.Location = new System.Drawing.Point(101, 37);
            this.label_chosen.Name = "label_chosen";
            this.label_chosen.Size = new System.Drawing.Size(150, 25);
            this.label_chosen.TabIndex = 23;
            this.label_chosen.Text = "Recette Choisie !";
            // 
            // label_ingr
            // 
            this.label_ingr.AutoSize = true;
            this.label_ingr.Location = new System.Drawing.Point(118, 227);
            this.label_ingr.Name = "label_ingr";
            this.label_ingr.Size = new System.Drawing.Size(119, 28);
            this.label_ingr.TabIndex = 22;
            this.label_ingr.Text = "Ingrédients :";
            this.label_ingr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_ingr
            // 
            this.tb_ingr.AcceptsReturn = true;
            this.tb_ingr.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_ingr.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_ingr.Location = new System.Drawing.Point(55, 258);
            this.tb_ingr.Multiline = true;
            this.tb_ingr.Name = "tb_ingr";
            this.tb_ingr.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tb_ingr.Size = new System.Drawing.Size(242, 150);
            this.tb_ingr.TabIndex = 13;
            this.tb_ingr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_date
            // 
            this.tb_date.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_date.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_date.Location = new System.Drawing.Point(54, 179);
            this.tb_date.Name = "tb_date";
            this.tb_date.Size = new System.Drawing.Size(242, 32);
            this.tb_date.TabIndex = 13;
            this.tb_date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Location = new System.Drawing.Point(51, 139);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(252, 28);
            this.label_date.TabIndex = 22;
            this.label_date.Text = "Fait pour la dernière fois le :";
            // 
            // tb_chosen_rec
            // 
            this.tb_chosen_rec.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_chosen_rec.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_chosen_rec.Location = new System.Drawing.Point(51, 81);
            this.tb_chosen_rec.Name = "tb_chosen_rec";
            this.tb_chosen_rec.Size = new System.Drawing.Size(242, 34);
            this.tb_chosen_rec.TabIndex = 13;
            this.tb_chosen_rec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1132, 673);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_choix);
            this.Controls.Add(this.but_add_rec);
            this.Controls.Add(this.but_make_recipe);
            this.Controls.Add(this.but_give_rec_2);
            this.Name = "Form1";
            this.Text = "Générateur de Recette";
            this.gb_choix.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView tv_search_by_ingr;
        private System.Windows.Forms.Button but_give_rec_2;
        private System.Windows.Forms.Button but_make_recipe;
        private System.Windows.Forms.Button but_add_rec;
        private System.Windows.Forms.GroupBox gb_choix;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_ingr;
        private System.Windows.Forms.TextBox tb_ingr;
        private System.Windows.Forms.TextBox tb_date;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.TextBox tb_chosen_rec;
        private System.Windows.Forms.Label label_chosen;
    }
}

