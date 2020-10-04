using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.Data.SqlTypes;

namespace Recipe
{
    public partial class Form2 : Form
    {
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=C:\USERS\RBOUI\SOURCE\REPOS\RECIPE\RECIPE\DATABASE1.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlConnection con = new SqlConnection();
        Form1 form1;
        List<TreeNode> checkedNodes = new List<TreeNode>();
        public Form2(Form1 form, String conString)
        {
            InitializeComponent();
            form1 = form;
            con.ConnectionString = conString;
            try
            {
                update_ingredient_type_list();
                update_ingredient_list();
                update_recipe_list();
                reset_label();
                update_treeview_ingredient();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }
        }


        private void reset_label()
        {
            label_ingr.Text = "";
            label_rec.Text = "";
            label_type.Text = "";
        }


        private void display_message_label(Label label, Color color, String msg)
        {
            label.ForeColor = color;
            label.Text = msg;
        }


        private void update_recipe_list()
        {
            con.Open();
            SqlCommand sc = new SqlCommand("", con);
            SqlDataReader reader;
            clb_recipe.Items.Clear();

            sc.CommandText = "SELECT name FROM dbo.Recipe";
            reader = sc.ExecuteReader();
            while (reader.Read())
            {
                clb_recipe.Items.Add(reader[0]);
            }
            clb_recipe.Visible = true;

            con.Close();
        }


        private void update_ingredient_list()
        {
            con.Open();
            SqlCommand sc = new SqlCommand("", con);
            SqlDataReader reader;
            clb_meat.Items.Clear();
            clb_veg.Items.Clear();
            clb_other.Items.Clear();

            sc.CommandText = "SELECT name FROM dbo.Ingredient WHERE type IN ('Viande', 'Poisson') ";
            reader = sc.ExecuteReader();
            while (reader.Read())
            {
                clb_meat.Items.Add(reader[0]);
            }
            clb_meat.Visible = true;

            reader.Close();
            sc.CommandText = "SELECT name FROM dbo.Ingredient WHERE type IN ('Légume', 'Fruit') ";
            reader = sc.ExecuteReader();
            while (reader.Read())
            {
                clb_veg.Items.Add(reader[0]);
            }
            clb_veg.Visible = true;

            reader.Close();
            sc.CommandText = "SELECT name FROM dbo.Ingredient WHERE type NOT IN ('Viande', 'Poisson', 'Légume', 'Fruit') ";
            reader = sc.ExecuteReader();
            while (reader.Read())
            {
                clb_other.Items.Add(reader[0]);
            }
            clb_other.Visible = true;

            con.Close();
        }


        private void update_ingredient_type_list()
        {
            String query = "SELECT Name FROM dbo.Ingredient_Type";
            con.Open();
            SqlCommand sc = new SqlCommand(query, con);
            SqlDataReader reader = sc.ExecuteReader();
            List<String> types = new List<String>();
            while (reader.Read())
            {
                types.Add((String)reader[0]);
            }
            ingr_type_input.DataSource = types;
            con.Close();
        }


        private void execute_cmd_nq(String cmd)
        {
            try
            {
                SqlCommand sc;
                con.Open();
                sc = new SqlCommand(cmd, con);
                sc.ExecuteNonQuery();
                sc.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(cmd + " : " + ex.ToString());
                con.Close();
            }
        }


        private void add_recipe(String name)
        {
            String query = String.Format("INSERT INTO dbo.Recipe VALUES ('{0}', SYSDATETIME())", name);
            execute_cmd_nq(query);
        }

        private void add_ingredient(String name, String type)
        {

            String query = String.Format("INSERT INTO dbo.Ingredient VALUES ('{0}', '{1}')", name, type);
            execute_cmd_nq(query);
        }

        private void add_ingredient_type(String type)
        {

            String query = String.Format("INSERT INTO dbo.Ingredient_Type VALUES ('{0}')", type);
            execute_cmd_nq(query);
        }


        private void delete_ingredient()
        {
            String query1 = "DELETE FROM dbo.Liaison WHERE name_ingredient IN (";
            String query2 = "DELETE FROM dbo.Ingredient WHERE name IN (";
            bool first = true;
            checkedNodes.Clear();
            get_checked_node(tv_ingr.Nodes);

            foreach (TreeNode node in checkedNodes)
            {
                if (first)
                    first = false;
                else
                {
                    query1 += ',';
                    query2 += ',';
                }
                query1 += String.Format("'{0}'", node.Text);
                query2 += String.Format("'{0}'", node.Text);
            }
            if (!first)
            {
                query1 += ");";
                execute_cmd_nq(query1);
                //MessageBox.Show(query1);
                query2 += ");";
                execute_cmd_nq(query2);
            }
        }

        private void but_remove_rec_Click(object sender, EventArgs e)
        {
            String query1 = "DELETE FROM dbo.Liaison WHERE name_recipe IN (";
            String query2 = "DELETE FROM dbo.Recipe WHERE name IN (";
            bool first = true;
            foreach (int checkedIndex in clb_recipe.CheckedIndices)
            {
                if (first)
                    first = false;
                else
                {
                    query1 += ',';
                    query2 += ',';
                }
                query1 += String.Format("'{0}'", clb_recipe.Items[checkedIndex].ToString());
                query2 += String.Format("'{0}'", clb_recipe.Items[checkedIndex].ToString());
            }

            if (!first)
            {
                query1 += ");";
                execute_cmd_nq(query1);
                query2 += ");";
                execute_cmd_nq(query2);
            }
            update_recipe_list();
        }

        private void add_ingr_to_rec(String rec, CheckedListBox clb)
        {
            String query = "INSERT INTO dbo.Liaison VALUES ";
            bool first = true;
            foreach (int checkedIndex in clb.CheckedIndices)
            {
                if (first)
                    first = false;
                else
                    query += ',';
                query += String.Format("('{0}', '{1}')", rec, clb.Items[checkedIndex].ToString());
            }

            if (!first)
            {
                query += ';';
                execute_cmd_nq(query);
            }
        }


        private void but_remove_ingr_Click(object sender, EventArgs e)
        {
            delete_ingredient();
            update_ingredient_list();
            update_treeview_ingredient();
        }


        private void add_ingr_Click(object sender, EventArgs e)
        {
            try
            {
                String ingr_type = (String)ingr_type_input.SelectedItem;
                String ingr_name = ingr_name_input.Text;
                reset_label();
                add_ingredient(ingr_name, ingr_type);
                update_ingredient_list();
                display_message_label(label_ingr, Color.Green, "Ingredient ajouté !");
                ingr_name_input.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }
        }

        private void add_ingr_type_Click(object sender, EventArgs e)
        {
            try
            {
                String ingr_type = ingr_type_name_input.Text;
                reset_label();
                add_ingredient_type(ingr_type);
                update_ingredient_type_list();
                display_message_label(label_type, Color.Green, "Type d'Ingrédient ajouté !");
                ingr_type_name_input.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }
        }

        private void add_rec_Click(object sender, EventArgs e)
        {
            try
            {
                String rec_name = rec_name_input.Text;
                reset_label();
                add_recipe(rec_name);
                add_ingr_to_rec(rec_name, clb_meat);
                add_ingr_to_rec(rec_name, clb_veg);
                add_ingr_to_rec(rec_name, clb_other);
                display_message_label(label_rec, Color.Green, "Recette ajouté !");
                update_recipe_list();
                update_ingredient_list(); //Pour enlever les sélections
                rec_name_input.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }

        }

        private void get_checked_node(TreeNodeCollection nodes)
        {
            foreach (TreeNode node in nodes)
                if (node.Checked && (node.Parent != null))
                    checkedNodes.Add(node);
                else
                    get_checked_node(node.Nodes);
        }

        private void update_treeview_ingredient()
        {
            con.Open();
            SqlCommand sc = new SqlCommand("", con);
            SqlDataReader reader;
            int n_type = 0;
            tv_ingr.Nodes.Clear();
            tv_ingr.BeginUpdate();
            String type;

            sc.CommandText = "SELECT name FROM dbo.Ingredient_Type";
            reader = sc.ExecuteReader();
            while (reader.Read())
            {
                tv_ingr.Nodes.Add((String)reader[0]);
            }
            reader.Close();

            sc.CommandText = "SELECT COUNT(*) FROM dbo.Ingredient_Type";
            reader = sc.ExecuteReader();
            reader.Read();
            n_type = (int)reader[0];
            reader.Close();

            for (int i = 0; i < n_type; i++)
            {
                type = tv_ingr.Nodes[i].Text;
                sc.CommandText = String.Format("SELECT name FROM dbo.Ingredient WHERE type IN ('{0}')", type);
                reader = sc.ExecuteReader();
                while (reader.Read())
                {
                    tv_ingr.Nodes[i].Nodes.Add((String)reader[0]);
                }
                reader.Close();
            }
            tv_ingr.EndUpdate();
            con.Close();
        }

        private void but_leave_Click(object sender, EventArgs e)
        {
            form1.update_treeview_ingredient();
            this.Close();
        }

        private void tv_ingr_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Nodes.Count > 0)
                for (int i = 0; i < e.Node.Nodes.Count; i++)
                    e.Node.Nodes[i].Checked = e.Node.Checked;
        }


        private void ingr_name_input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    String ingr_type = (String)ingr_type_input.SelectedItem;
                    String ingr_name = ingr_name_input.Text;
                    reset_label();
                    add_ingredient(ingr_name, ingr_type);
                    update_ingredient_list();
                    display_message_label(label_ingr, Color.Green, "Ingredient ajouté !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    con.Close();
                }
            }
        }

        private void ingr_type_name_input_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                String ingr_type = ingr_type_name_input.Text;
                reset_label();
                add_ingredient_type(ingr_type);
                update_ingredient_type_list();
                display_message_label(label_type, Color.Green, "Type d'Ingrédient ajouté !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }
        }
    }
}
