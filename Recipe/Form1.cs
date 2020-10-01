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
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=C:\USERS\RBOUI\SOURCE\REPOS\RECIPE\RECIPE\DATABASE1.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        List<TreeNode> checkedNodes = new List<TreeNode>();
        public Form1()
        {
            InitializeComponent();
        }

        private void con_but_Click(object sender, EventArgs e)
        {
            SqlCommand sc;
            try
            {
                update_ingredient_type_list();
                update_ingredient_list();
                update_treeview_ingredient();
                update_recipe_list();


                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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
                display_message_label(label_ingr, Color.Green, "Ingredient added successfully !");
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
                display_message_label(label_type, Color.Green, "Ingredient type added successfully !");
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
                display_message_label(label_rec, Color.Green, "Recipe added successfully !");
                update_recipe_list();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }

        }


        private void but_give_rec_Click(object sender, EventArgs e)
        {
            DateTime min_date, max_date, recipe_date;
            TimeSpan ts;
            String recipe_name = "";
            Random rand = new Random();
            int n_recipe = 0, index = 0, min_throw = 0, throw_100 = 0;
            float factor = 0f;
            SqlDataReader reader;
            SqlCommand sc;
            DataTable data = new DataTable();
            con.Open();
            sc = new SqlCommand("", con);
            try
            {
                sc.CommandText = "SELECT COUNT(*) FROM dbo.Recipe"; //Nombre de recettes
                reader = sc.ExecuteReader();
                reader.Read();
                n_recipe = (int)reader[0];
                reader.Close();

                sc.CommandText = "SELECT MAX(last_made) FROM dbo.Recipe"; //Date la plus récente
                reader = sc.ExecuteReader();
                reader.Read();
                max_date = ((DateTime)reader[0]).Date;
                reader.Close();

                sc.CommandText = "SELECT MIN(last_made) FROM dbo.Recipe"; //Date la plus ancienne
                reader = sc.ExecuteReader();
                reader.Read();
                min_date = ((DateTime)reader[0]).Date;
                reader.Close();


                sc.CommandText = "SELECT name, last_made FROM dbo.Recipe"; //Récupère les recettes, et peuple une DataTable avec les données
                data.Load(sc.ExecuteReader());
                con.Close();

                ts = max_date - min_date; //Ecart entre date plus recente et plus ancienne
                while (throw_100 <= min_throw)
                {
                    DataTableReader tableReader = data.CreateDataReader(); //Crée itérateur de la table à chaque passage dans le while
                    index = rand.Next(n_recipe); //Index de la recette à récupérer
                    for (int i = 0; i <= index; i++) // Récupère la index-ième recette
                        tableReader.Read();
                    recipe_name = (String)tableReader[0];
                    recipe_date = ((DateTime)tableReader[1]).Date;
                    tableReader.Close();
                    float temp = (recipe_date - min_date).Days;
                    factor = temp / (float)ts.Days; //Récupère un pourcentage de l'ancienneté de la recette par rapport à la plus ancienne (ancienneté -> dernière fois qu'elle a été faite)
                    min_throw = (int)(factor * 100); //Plus le facteur est proche de 0, plus la recette est ancienne, plus le jet minimum à faire pour qu'elle soit choisie sera petit
                    throw_100 = rand.Next(100);
                    MessageBox.Show(String.Format("{0}, {1}\nts = {2}, factor = {3}, min_throw = {4}, throw = {5}", recipe_name, recipe_date.ToString(), ts.Days.ToString(), factor.ToString(), min_throw.ToString(), throw_100.ToString()));
                }
                display_message_label(label_chosen_rec, Color.Green, recipe_name);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }
}


        private void but_give_rec_2_Click(object sender, EventArgs e)
        {
            bool first = true;
            DateTime min_date, max_date, recipe_date;
            TimeSpan ts;
            String recipe_name = "", base_query = "";
            Random rand = new Random();
            int n_recipe = 0, index = 0, min_throw = 0, throw_100 = 0;
            float factor = 0f;
            SqlDataReader reader;
            SqlCommand sc;
            DataTable data = new DataTable();
            con.Open();
            sc = new SqlCommand("", con);

            checkedNodes.Clear();
            get_checked_node(tv_search_by_ingr.Nodes); //get all the checked nodes from the tree view into checkNodes

            if (checkedNodes.Count > 0)
            {
                foreach (TreeNode node in checkedNodes) //Adds an intersect condition for every node
                {
                    if (first)
                    {
                        base_query += String.Format("SELECT name_recipe FROM dbo.Liaison WHERE name_ingredient IN ('{0}')", node.Text);
                        first = false;
                    }
                    else
                    {
                        base_query += String.Format("\nINTERSECT\nSELECT name_recipe FROM dbo.Liaison WHERE name_ingredient IN ('{0}')", node.Text);
                    }
                }
            }
            else //if no nodes were checked, simply select every recipe
            {
                base_query = "SELECT DISTINCT name_recipe FROM dbo.Liaison";
            }
            MessageBox.Show(base_query);
            //base_query constitutes the query to get the sub-table containing the name of the recipes that have every ingredients wanted

            try
            {
                sc.CommandText = "SELECT COUNT(*) FROM dbo.Recipe WHERE name IN (" + base_query + ")"; //Nombre de recettes
                reader = sc.ExecuteReader();
                reader.Read();
                n_recipe = (int)reader[0];
                reader.Close();

                sc.CommandText = "SELECT MAX(last_made) FROM dbo.Recipe WHERE name IN (" + base_query + ")"; //Date la plus récente
                reader = sc.ExecuteReader();
                reader.Read();
                max_date = ((DateTime)reader[0]).Date;
                reader.Close();

                sc.CommandText = "SELECT MIN(last_made) FROM dbo.Recipe WHERE name IN (" + base_query + ")"; //Date la plus ancienne
                reader = sc.ExecuteReader();
                reader.Read();
                min_date = ((DateTime)reader[0]).Date;
                reader.Close();


                sc.CommandText = "SELECT name, last_made FROM dbo.Recipe WHERE name IN (" + base_query + ")"; //Récupère les recettes, et peuple une DataTable avec les données
                data.Load(sc.ExecuteReader());
                con.Close();

                ts = max_date - min_date; //Ecart entre date plus recente et plus ancienne
                while (throw_100 <= min_throw)
                {
                    DataTableReader tableReader = data.CreateDataReader(); //Crée itérateur de la table à chaque passage dans le while
                    index = rand.Next(n_recipe); //Index de la recette à récupérer
                    for (int i = 0; i <= index; i++) // Récupère la index-ième recette
                        tableReader.Read();
                    recipe_name = (String)tableReader[0];
                    recipe_date = ((DateTime)tableReader[1]).Date;
                    tableReader.Close();
                    float temp = (recipe_date - min_date).Days;
                    factor = temp / (float)ts.Days; //Récupère un pourcentage de l'ancienneté de la recette par rapport à la plus ancienne (ancienneté -> dernière fois qu'elle a été faite)
                    min_throw = (int)(factor * 100); //Plus le facteur est proche de 0, plus la recette est ancienne, plus le jet minimum à faire pour qu'elle soit choisie sera petit
                    throw_100 = rand.Next(100);
                    MessageBox.Show(String.Format("{0}, {1}\nts = {2}, factor = {3}, min_throw = {4}, throw = {5}", recipe_name, recipe_date.ToString(), ts.Days.ToString(), factor.ToString(), min_throw.ToString(), throw_100.ToString()));
                }
                display_message_label(label_chosen_rec, Color.Green, recipe_name);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
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

        private void but_remove_ingr_Click(object sender, EventArgs e)
        {
            delete_ingredient(clb_meat);
            delete_ingredient(clb_veg);
            delete_ingredient(clb_other);
            update_ingredient_list();
        }

        private void get_checked_node(TreeNodeCollection nodes)
        {
            foreach(TreeNode node in nodes)
                if (node.Checked && (node.Parent != null))
                    checkedNodes.Add(node);
                else
                    get_checked_node(node.Nodes);
        }

        private void add_ingr_to_rec (String rec, CheckedListBox clb)
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

        private void delete_ingredient (CheckedListBox clb)
        {
            String query1 = "DELETE FROM dbo.Liaison WHERE name_ingredient IN (";
            String query2 = "DELETE FROM dbo.Ingredient WHERE name IN (";
            bool first = true;

            foreach (int checkedIndex in clb.CheckedIndices)
            {
                if (first)
                    first = false;
                else
                {
                    query1 += ',';
                    query2 += ',';
                }
                query1 += String.Format("'{0}'", clb.Items[checkedIndex].ToString());
                query2 += String.Format("'{0}'", clb.Items[checkedIndex].ToString());
            }

            if (!first)
            {
                query1 += ");";
                execute_cmd_nq(query1);
                query2 += ");";
                execute_cmd_nq(query2);
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
            }catch(Exception ex)
            {
                MessageBox.Show(cmd + " : " + ex.ToString());
                con.Close();
            }
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

        private void update_treeview_ingredient()
        {
            con.Open();
            SqlCommand sc = new SqlCommand("", con);
            SqlDataReader reader;
            int n_type = 0;
            tv_search_by_ingr.BeginUpdate();
            String type;

            sc.CommandText = "SELECT name FROM dbo.Ingredient_Type";
            reader = sc.ExecuteReader();
            while (reader.Read())
            {
                tv_search_by_ingr.Nodes.Add((String)reader[0]);
            }
            reader.Close();

            sc.CommandText = "SELECT COUNT(*) FROM dbo.Ingredient_Type";
            reader = sc.ExecuteReader();
            reader.Read();
            n_type = (int)reader[0];
            reader.Close();

            for (int i = 0; i < n_type; i ++)
            {
                type = tv_search_by_ingr.Nodes[i].Text;
                sc.CommandText = String.Format("SELECT name FROM dbo.Ingredient WHERE type IN ('{0}')", type);
                reader = sc.ExecuteReader();
                while (reader.Read())
                {
                    tv_search_by_ingr.Nodes[i].Nodes.Add((String)reader[0]);
                }
                reader.Close();
            }
            tv_search_by_ingr.EndUpdate();
            con.Close();
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

        private void display_message_label(Label label, Color color, String msg)
        {
            label.ForeColor = color;
            label.Text = msg;
        }

        private void reset_label()
        {
            label_ingr.Text = "";
            label_rec.Text = "";
            label_type.Text = "";
            label_chosen_rec.Text = "";
        }

        private void tv_search_by_ingr_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Nodes.Count > 0)
                for (int i = 0; i < e.Node.Nodes.Count; i++)
                    e.Node.Nodes[i].Checked = e.Node.Checked;
        }

        private void but_make_recipe_Click(object sender, EventArgs e)
        {
            String recipe = label_chosen_rec.Text;
            String query = String.Format("UPDATE dbo.Recipe SET last_made = SYSDATETIME() WHERE name = '{0}'", recipe);
            execute_cmd_nq(query);

        }
    }
}
