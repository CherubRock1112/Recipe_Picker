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
            try
            {
                update_treeview_ingredient();
                hide_recipe();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }
        }



        /*
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
}*/


        private void but_give_rec_2_Click(object sender, EventArgs e)
        {
            bool first = true;
            DateTime min_date, max_date, recipe_date;
            recipe_date = new DateTime(1, 1, 1);
            TimeSpan ts;
            String recipe_name = "", base_query = "";
            Random rand = new Random();
            int n_recipe = 0, index = 0, min_throw = 0, throw_100 = 0;
            float factor = 0f;
            SqlDataReader reader;
            SqlCommand sc;
            DataTable data = new DataTable();
            checkedNodes.Clear();
            get_checked_node(tv_search_by_ingr.Nodes); //get all the checked nodes from the tree view into checkNodes
            con.Open();
            sc = new SqlCommand("", con);
            hide_recipe();


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
            //MessageBox.Show(base_query);
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
                    //MessageBox.Show(String.Format("{0}, {1}\nts = {2}, factor = {3}, min_throw = {4}, throw = {5}", recipe_name, recipe_date.ToString(), ts.Days.ToString(), factor.ToString(), min_throw.ToString(), throw_100.ToString()));
                }
                display_recipe(recipe_name, recipe_date);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }

        }

        

        private void get_checked_node(TreeNodeCollection nodes)
        {
            foreach (TreeNode node in nodes)
                if (node.Checked && (node.Parent != null))
                {
                    checkedNodes.Add(node);
                    //MessageBox.Show(node.Text);
                }
                else
                    get_checked_node(node.Nodes);
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



        private void update_treeview_ingredient()
        {
            con.Open();
            SqlCommand sc = new SqlCommand("", con);
            SqlDataReader reader;
            int n_type = 0;
            tv_search_by_ingr.Nodes.Clear();
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


        private void display_recipe(String name, DateTime date)
        {
            show_recipe();
            tb_chosen_rec.Text = name;
            tb_date.Text = date.Date.ToString();

            String query = "SELECT name_ingredient FROM dbo.Liaison WHERE name_recipe IN ('" + name + "')";
            con.Open();
            SqlCommand sc = new SqlCommand(query, con);
            SqlDataReader reader = sc.ExecuteReader();
            List<String> types = new List<String>();
            while (reader.Read())
            {
                tb_ingr.Text += (String)reader[0] + "\r";
            }
            con.Close();
        }

        private void tv_search_by_ingr_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Nodes.Count > 0)
                for (int i = 0; i < e.Node.Nodes.Count; i++)
                    e.Node.Nodes[i].Checked = e.Node.Checked;
        }

        private void but_make_recipe_Click(object sender, EventArgs e)
        {
            label_chosen.Visible = true;
            String query = String.Format("UPDATE dbo.Recipe SET last_made = SYSDATETIME() WHERE name = '{0}'", tb_chosen_rec.Text);
            execute_cmd_nq(query);
        }

        private void hide_recipe()
        {
            tb_chosen_rec.Visible = false;
            tb_date.Visible = false;
            tb_ingr.Visible = false;
            label_ingr.Visible = false;
            label_date.Visible = false;
            label_chosen.Visible = false;
            but_make_recipe.Visible = false;
        }

        private void show_recipe()
        {
            tb_chosen_rec.Visible = true;
            tb_date.Visible = true;
            tb_ingr.Visible = true;
            label_ingr.Visible = true;
            label_date.Visible = true;
            //label_chosen.Visible = true;
            but_make_recipe.Visible = true;

        }

        private void but_add_rec_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
