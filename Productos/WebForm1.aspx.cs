using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;


namespace Productos
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source = DESKTOP-JGG5C02;" +
 "Initial Catalog = VENTAS; Integrated Security = True";
            string selectSQL = "SELECT nompro FROM Productos";
            SqlConnection conexion = new SqlConnection(connectionString);
            SqlCommand comando = new SqlCommand(selectSQL, conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataSet ventas = new DataSet();
            adapter.Fill(ventas, "clientes");
            // enlazar el gridview
            GridView1.DataSource = ventas;
            GridView1.DataBind();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source = DESKTOP-JGG5C02;" +
 "Initial Catalog = VENTAS; Integrated Security = True";
            string selectSQL = "SELECT codpro FROM Productos";
            SqlConnection conexion = new SqlConnection(connectionString);
            SqlCommand comando = new SqlCommand(selectSQL, conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataSet ventas = new DataSet();
            adapter.Fill(ventas, "clientes");
            // enlazar el gridview
            GridView1.DataSource = ventas;
            GridView1.DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source = DESKTOP-JGG5C02;" +
"Initial Catalog = VENTAS; Integrated Security = True";
            string selectSQL = "SELECT precio FROM Productos";
            SqlConnection conexion = new SqlConnection(connectionString);
            SqlCommand comando = new SqlCommand(selectSQL, conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataSet ventas = new DataSet();
            adapter.Fill(ventas, "clientes");
            // enlazar el gridview
            GridView1.DataSource = ventas;
            GridView1.DataBind();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source = DESKTOP-JGG5C02;" +
"Initial Catalog = VENTAS; Integrated Security = True";
            string selectSQL = "SELECT stock FROM Productos";
            SqlConnection conexion = new SqlConnection(connectionString);
            SqlCommand comando = new SqlCommand(selectSQL, conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataSet ventas = new DataSet();
            adapter.Fill(ventas, "clientes");
            // enlazar el gridview
            GridView1.DataSource = ventas;
            GridView1.DataBind();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source = DESKTOP-JGG5C02;" +
"Initial Catalog = VENTAS; Integrated Security = True";
            string selectSQL = "SELECT *FROM Productos";
            SqlConnection conexion = new SqlConnection(connectionString);
            SqlCommand comando = new SqlCommand(selectSQL, conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataSet ventas = new DataSet();
            adapter.Fill(ventas, "clientes");
            // enlazar el gridview
            GridView1.DataSource = ventas;
            GridView1.DataBind();
        }
    }
}