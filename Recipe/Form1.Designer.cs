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
            this.con_but = new System.Windows.Forms.Button();
            this.but_give_rec = new System.Windows.Forms.Button();
            this.label_chosen_rec = new System.Windows.Forms.Label();
            this.tv_search_by_ingr = new System.Windows.Forms.TreeView();
            this.but_give_rec_2 = new System.Windows.Forms.Button();
            this.clb_recipe = new System.Windows.Forms.CheckedListBox();
            this.but_remove_rec = new System.Windows.Forms.Button();
            this.but_make_recipe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // con_but
            // 
            this.con_but.Location = new System.Drawing.Point(947, 189);
            this.con_but.Name = "con_but";
            this.con_but.Size = new System.Drawing.Size(94, 29);
            this.con_but.TabIndex = 1;
            this.con_but.Text = "Connect";
            this.con_but.UseVisualStyleBackColor = true;
            this.con_but.Click += new System.EventHandler(this.con_but_Click);
            // 
            // but_give_rec
            // 
            this.but_give_rec.Location = new System.Drawing.Point(295, 34);
            this.but_give_rec.Name = "but_give_rec";
            this.but_give_rec.Size = new System.Drawing.Size(171, 29);
            this.but_give_rec.TabIndex = 11;
            this.but_give_rec.Text = "GIMME GIMME LOVE";
            this.but_give_rec.UseVisualStyleBackColor = true;
            this.but_give_rec.Click += new System.EventHandler(this.but_give_rec_Click);
            // 
            // label_chosen_rec
            // 
            this.label_chosen_rec.AutoSize = true;
            this.label_chosen_rec.Location = new System.Drawing.Point(364, 189);
            this.label_chosen_rec.Name = "label_chosen_rec";
            this.label_chosen_rec.Size = new System.Drawing.Size(0, 20);
            this.label_chosen_rec.TabIndex = 12;
            this.label_chosen_rec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tv_search_by_ingr
            // 
            this.tv_search_by_ingr.CheckBoxes = true;
            this.tv_search_by_ingr.FullRowSelect = true;
            this.tv_search_by_ingr.Location = new System.Drawing.Point(46, 34);
            this.tv_search_by_ingr.Name = "tv_search_by_ingr";
            this.tv_search_by_ingr.Size = new System.Drawing.Size(198, 163);
            this.tv_search_by_ingr.TabIndex = 13;
            this.tv_search_by_ingr.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tv_search_by_ingr_AfterCheck);
            // 
            // but_give_rec_2
            // 
            this.but_give_rec_2.Location = new System.Drawing.Point(295, 119);
            this.but_give_rec_2.Name = "but_give_rec_2";
            this.but_give_rec_2.Size = new System.Drawing.Size(191, 29);
            this.but_give_rec_2.TabIndex = 14;
            this.but_give_rec_2.Text = "GIMME A BIT LESS LOVE";
            this.but_give_rec_2.UseVisualStyleBackColor = true;
            this.but_give_rec_2.Click += new System.EventHandler(this.but_give_rec_2_Click);
            // 
            // clb_recipe
            // 
            this.clb_recipe.FormattingEnabled = true;
            this.clb_recipe.Location = new System.Drawing.Point(572, 34);
            this.clb_recipe.Name = "clb_recipe";
            this.clb_recipe.Size = new System.Drawing.Size(167, 158);
            this.clb_recipe.TabIndex = 16;
            // 
            // but_remove_rec
            // 
            this.but_remove_rec.Location = new System.Drawing.Point(583, 198);
            this.but_remove_rec.Name = "but_remove_rec";
            this.but_remove_rec.Size = new System.Drawing.Size(139, 49);
            this.but_remove_rec.TabIndex = 17;
            this.but_remove_rec.Text = "Remove Selected Recipes";
            this.but_remove_rec.UseVisualStyleBackColor = true;
            this.but_remove_rec.Click += new System.EventHandler(this.but_remove_rec_Click);
            // 
            // but_make_recipe
            // 
            this.but_make_recipe.Location = new System.Drawing.Point(325, 212);
            this.but_make_recipe.Name = "but_make_recipe";
            this.but_make_recipe.Size = new System.Drawing.Size(141, 29);
            this.but_make_recipe.TabIndex = 18;
            this.but_make_recipe.Text = "Make this Recipe";
            this.but_make_recipe.UseVisualStyleBackColor = true;
            this.but_make_recipe.Click += new System.EventHandler(this.but_make_recipe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 513);
            this.Controls.Add(this.but_make_recipe);
            this.Controls.Add(this.but_remove_rec);
            this.Controls.Add(this.clb_recipe);
            this.Controls.Add(this.but_give_rec_2);
            this.Controls.Add(this.tv_search_by_ingr);
            this.Controls.Add(this.label_chosen_rec);
            this.Controls.Add(this.but_give_rec);
            this.Controls.Add(this.con_but);
            this.Name = "Form1";
            this.Text = "Remove Ingredients";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button con_but;
        private System.Windows.Forms.Button but_give_rec;
        private System.Windows.Forms.Label label_chosen_rec;
        private System.Windows.Forms.TreeView tv_search_by_ingr;
        private System.Windows.Forms.Button but_give_rec_2;
        private System.Windows.Forms.CheckedListBox clb_recipe;
        private System.Windows.Forms.Button but_remove_rec;
        private System.Windows.Forms.Button but_make_recipe;
    }
}

