namespace Recipe
{
    partial class Form2
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
            this.but_rem_ingr = new System.Windows.Forms.Button();
            this.label_rec = new System.Windows.Forms.Label();
            this.label_type = new System.Windows.Forms.Label();
            this.but_add_ingr_type = new System.Windows.Forms.Button();
            this.ingr_type_name_input = new System.Windows.Forms.TextBox();
            this.clb_other = new System.Windows.Forms.CheckedListBox();
            this.clb_veg = new System.Windows.Forms.CheckedListBox();
            this.clb_meat = new System.Windows.Forms.CheckedListBox();
            this.but_add_rec = new System.Windows.Forms.Button();
            this.rec_name_input = new System.Windows.Forms.TextBox();
            this.but_add_ingr = new System.Windows.Forms.Button();
            this.ingr_name_input = new System.Windows.Forms.TextBox();
            this.ingr_type_input = new System.Windows.Forms.ComboBox();
            this.but_rem_rec = new System.Windows.Forms.Button();
            this.clb_recipe = new System.Windows.Forms.CheckedListBox();
            this.gb_type = new System.Windows.Forms.GroupBox();
            this.gb_ingr = new System.Windows.Forms.GroupBox();
            this.label_ingr = new System.Windows.Forms.Label();
            this.gb_rec = new System.Windows.Forms.GroupBox();
            this.tv_ingr = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.but_leave = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gb_type.SuspendLayout();
            this.gb_ingr.SuspendLayout();
            this.gb_rec.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // but_rem_ingr
            // 
            this.but_rem_ingr.BackColor = System.Drawing.Color.Lavender;
            this.but_rem_ingr.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.but_rem_ingr.Location = new System.Drawing.Point(811, 101);
            this.but_rem_ingr.Name = "but_rem_ingr";
            this.but_rem_ingr.Size = new System.Drawing.Size(150, 60);
            this.but_rem_ingr.TabIndex = 19;
            this.but_rem_ingr.Text = "Supprimer les Ingrédients";
            this.but_rem_ingr.UseVisualStyleBackColor = false;
            this.but_rem_ingr.Click += new System.EventHandler(this.but_remove_ingr_Click);
            // 
            // label_rec
            // 
            this.label_rec.AutoSize = true;
            this.label_rec.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_rec.Location = new System.Drawing.Point(39, 126);
            this.label_rec.Name = "label_rec";
            this.label_rec.Size = new System.Drawing.Size(53, 25);
            this.label_rec.TabIndex = 10;
            this.label_rec.Text = "swsd";
            this.label_rec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.BackColor = System.Drawing.SystemColors.Control;
            this.label_type.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_type.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_type.Location = new System.Drawing.Point(465, 48);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(30, 25);
            this.label_type.TabIndex = 9;
            this.label_type.Text = "se";
            this.label_type.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // but_add_ingr_type
            // 
            this.but_add_ingr_type.BackColor = System.Drawing.Color.Lavender;
            this.but_add_ingr_type.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.but_add_ingr_type.Location = new System.Drawing.Point(308, 45);
            this.but_add_ingr_type.Name = "but_add_ingr_type";
            this.but_add_ingr_type.Size = new System.Drawing.Size(127, 34);
            this.but_add_ingr_type.TabIndex = 1;
            this.but_add_ingr_type.Text = "Ajouter";
            this.but_add_ingr_type.UseVisualStyleBackColor = false;
            this.but_add_ingr_type.Click += new System.EventHandler(this.add_ingr_Click);
            // 
            // ingr_type_name_input
            // 
            this.ingr_type_name_input.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ingr_type_name_input.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ingr_type_name_input.Location = new System.Drawing.Point(37, 45);
            this.ingr_type_name_input.Name = "ingr_type_name_input";
            this.ingr_type_name_input.Size = new System.Drawing.Size(203, 32);
            this.ingr_type_name_input.TabIndex = 3;
            // 
            // clb_other
            // 
            this.clb_other.BackColor = System.Drawing.Color.WhiteSmoke;
            this.clb_other.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clb_other.FormattingEnabled = true;
            this.clb_other.Location = new System.Drawing.Point(649, 42);
            this.clb_other.Name = "clb_other";
            this.clb_other.Size = new System.Drawing.Size(160, 112);
            this.clb_other.TabIndex = 6;
            this.clb_other.Visible = false;
            // 
            // clb_veg
            // 
            this.clb_veg.BackColor = System.Drawing.Color.WhiteSmoke;
            this.clb_veg.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clb_veg.FormattingEnabled = true;
            this.clb_veg.Location = new System.Drawing.Point(456, 42);
            this.clb_veg.Name = "clb_veg";
            this.clb_veg.Size = new System.Drawing.Size(160, 112);
            this.clb_veg.TabIndex = 6;
            this.clb_veg.Visible = false;
            // 
            // clb_meat
            // 
            this.clb_meat.BackColor = System.Drawing.Color.WhiteSmoke;
            this.clb_meat.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clb_meat.FormattingEnabled = true;
            this.clb_meat.Location = new System.Drawing.Point(265, 42);
            this.clb_meat.Name = "clb_meat";
            this.clb_meat.Size = new System.Drawing.Size(160, 112);
            this.clb_meat.TabIndex = 6;
            this.clb_meat.Visible = false;
            // 
            // but_add_rec
            // 
            this.but_add_rec.BackColor = System.Drawing.Color.Lavender;
            this.but_add_rec.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.but_add_rec.Location = new System.Drawing.Point(839, 74);
            this.but_add_rec.Name = "but_add_rec";
            this.but_add_rec.Size = new System.Drawing.Size(127, 34);
            this.but_add_rec.TabIndex = 1;
            this.but_add_rec.Text = "Ajouter";
            this.but_add_rec.UseVisualStyleBackColor = false;
            this.but_add_rec.Click += new System.EventHandler(this.add_rec_Click);
            // 
            // rec_name_input
            // 
            this.rec_name_input.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rec_name_input.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rec_name_input.Location = new System.Drawing.Point(39, 57);
            this.rec_name_input.Multiline = true;
            this.rec_name_input.Name = "rec_name_input";
            this.rec_name_input.Size = new System.Drawing.Size(201, 60);
            this.rec_name_input.TabIndex = 3;
            // 
            // but_add_ingr
            // 
            this.but_add_ingr.BackColor = System.Drawing.Color.Lavender;
            this.but_add_ingr.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.but_add_ingr.Location = new System.Drawing.Point(506, 40);
            this.but_add_ingr.Name = "but_add_ingr";
            this.but_add_ingr.Size = new System.Drawing.Size(127, 34);
            this.but_add_ingr.TabIndex = 1;
            this.but_add_ingr.Text = "Ajouter";
            this.but_add_ingr.UseVisualStyleBackColor = false;
            this.but_add_ingr.Click += new System.EventHandler(this.add_ingr_Click);
            // 
            // ingr_name_input
            // 
            this.ingr_name_input.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ingr_name_input.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ingr_name_input.Location = new System.Drawing.Point(36, 43);
            this.ingr_name_input.Name = "ingr_name_input";
            this.ingr_name_input.Size = new System.Drawing.Size(201, 32);
            this.ingr_name_input.TabIndex = 3;
            // 
            // ingr_type_input
            // 
            this.ingr_type_input.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ingr_type_input.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ingr_type_input.FormattingEnabled = true;
            this.ingr_type_input.Location = new System.Drawing.Point(284, 42);
            this.ingr_type_input.Name = "ingr_type_input";
            this.ingr_type_input.Size = new System.Drawing.Size(174, 33);
            this.ingr_type_input.TabIndex = 2;
            // 
            // but_rem_rec
            // 
            this.but_rem_rec.BackColor = System.Drawing.Color.Lavender;
            this.but_rem_rec.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.but_rem_rec.Location = new System.Drawing.Point(328, 90);
            this.but_rem_rec.Name = "but_rem_rec";
            this.but_rem_rec.Size = new System.Drawing.Size(150, 60);
            this.but_rem_rec.TabIndex = 17;
            this.but_rem_rec.Text = "Supprimer les recettes";
            this.but_rem_rec.UseVisualStyleBackColor = false;
            this.but_rem_rec.Click += new System.EventHandler(this.but_remove_rec_Click);
            // 
            // clb_recipe
            // 
            this.clb_recipe.BackColor = System.Drawing.Color.WhiteSmoke;
            this.clb_recipe.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clb_recipe.FormattingEnabled = true;
            this.clb_recipe.Location = new System.Drawing.Point(54, 34);
            this.clb_recipe.Name = "clb_recipe";
            this.clb_recipe.Size = new System.Drawing.Size(250, 166);
            this.clb_recipe.TabIndex = 16;
            // 
            // gb_type
            // 
            this.gb_type.Controls.Add(this.ingr_type_name_input);
            this.gb_type.Controls.Add(this.but_add_ingr_type);
            this.gb_type.Controls.Add(this.label_type);
            this.gb_type.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gb_type.Location = new System.Drawing.Point(21, 33);
            this.gb_type.Name = "gb_type";
            this.gb_type.Size = new System.Drawing.Size(633, 98);
            this.gb_type.TabIndex = 20;
            this.gb_type.TabStop = false;
            this.gb_type.Text = "Type d\'Ingrédient";
            // 
            // gb_ingr
            // 
            this.gb_ingr.Controls.Add(this.label_ingr);
            this.gb_ingr.Controls.Add(this.ingr_type_input);
            this.gb_ingr.Controls.Add(this.but_add_ingr);
            this.gb_ingr.Controls.Add(this.ingr_name_input);
            this.gb_ingr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gb_ingr.Location = new System.Drawing.Point(21, 137);
            this.gb_ingr.Name = "gb_ingr";
            this.gb_ingr.Size = new System.Drawing.Size(982, 95);
            this.gb_ingr.TabIndex = 21;
            this.gb_ingr.TabStop = false;
            this.gb_ingr.Text = "Ingrédient";
            // 
            // label_ingr
            // 
            this.label_ingr.AutoSize = true;
            this.label_ingr.BackColor = System.Drawing.SystemColors.Control;
            this.label_ingr.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_ingr.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_ingr.Location = new System.Drawing.Point(658, 43);
            this.label_ingr.Name = "label_ingr";
            this.label_ingr.Size = new System.Drawing.Size(30, 25);
            this.label_ingr.TabIndex = 9;
            this.label_ingr.Text = "se";
            this.label_ingr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gb_rec
            // 
            this.gb_rec.Controls.Add(this.clb_veg);
            this.gb_rec.Controls.Add(this.label_rec);
            this.gb_rec.Controls.Add(this.clb_other);
            this.gb_rec.Controls.Add(this.clb_meat);
            this.gb_rec.Controls.Add(this.but_add_rec);
            this.gb_rec.Controls.Add(this.rec_name_input);
            this.gb_rec.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gb_rec.Location = new System.Drawing.Point(21, 238);
            this.gb_rec.Name = "gb_rec";
            this.gb_rec.Size = new System.Drawing.Size(982, 183);
            this.gb_rec.TabIndex = 22;
            this.gb_rec.TabStop = false;
            this.gb_rec.Text = "Recette";
            // 
            // tv_ingr
            // 
            this.tv_ingr.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tv_ingr.CheckBoxes = true;
            this.tv_ingr.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tv_ingr.Location = new System.Drawing.Point(561, 34);
            this.tv_ingr.Name = "tv_ingr";
            this.tv_ingr.Size = new System.Drawing.Size(225, 166);
            this.tv_ingr.TabIndex = 23;
            this.tv_ingr.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tv_ingr_AfterCheck);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.gb_type);
            this.groupBox1.Controls.Add(this.gb_ingr);
            this.groupBox1.Controls.Add(this.gb_rec);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(54, 234);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1028, 437);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajouts";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.but_leave);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(679, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 131);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            // 
            // but_leave
            // 
            this.but_leave.BackColor = System.Drawing.Color.Linen;
            this.but_leave.ForeColor = System.Drawing.Color.Red;
            this.but_leave.Location = new System.Drawing.Point(103, 33);
            this.but_leave.Name = "but_leave";
            this.but_leave.Size = new System.Drawing.Size(180, 62);
            this.but_leave.TabIndex = 1;
            this.but_leave.Text = "Quitter la Fenêtre";
            this.but_leave.UseVisualStyleBackColor = false;
            this.but_leave.Click += new System.EventHandler(this.but_leave_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(1, -2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(384, 131);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.clb_recipe);
            this.groupBox3.Controls.Add(this.but_rem_ingr);
            this.groupBox3.Controls.Add(this.tv_ingr);
            this.groupBox3.Controls.Add(this.but_rem_rec);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(54, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1028, 217);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Suppression";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1132, 673);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Modifier Recettes/Ingrédients";
            this.gb_type.ResumeLayout(false);
            this.gb_type.PerformLayout();
            this.gb_ingr.ResumeLayout(false);
            this.gb_ingr.PerformLayout();
            this.gb_rec.ResumeLayout(false);
            this.gb_rec.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_rem_ingr;
        private System.Windows.Forms.Label label_rec;
        private System.Windows.Forms.Label label_type;
        private System.Windows.Forms.Button but_add_ingr_type;
        private System.Windows.Forms.TextBox ingr_type_name_input;
        private System.Windows.Forms.CheckedListBox clb_other;
        private System.Windows.Forms.CheckedListBox clb_veg;
        private System.Windows.Forms.CheckedListBox clb_meat;
        private System.Windows.Forms.Button but_add_rec;
        private System.Windows.Forms.TextBox rec_name_input;
        private System.Windows.Forms.Button but_add_ingr;
        private System.Windows.Forms.TextBox ingr_name_input;
        private System.Windows.Forms.ComboBox ingr_type_input;
        private System.Windows.Forms.Button but_rem_rec;
        private System.Windows.Forms.CheckedListBox clb_recipe;
        private System.Windows.Forms.GroupBox gb_type;
        private System.Windows.Forms.GroupBox gb_ingr;
        private System.Windows.Forms.GroupBox gb_rec;
        private System.Windows.Forms.Label label_ingr;
        private System.Windows.Forms.TreeView tv_ingr;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button but_leave;
    }
}