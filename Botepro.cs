using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Boteco
{
    class Botepro
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public string tipo { get; set; }
        public int quantidade { get; set; }
        public string preco { get; set; }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Programas\\Boteco\\DbBoteco.mdf;Integrated Security=True");

        public void InserirPro(string nome, string tipo, int quantidade, string preco)
        {
                string sql = "INSERT INTO Produto(nome,tipo,quantidade,preco) VALUES ('" + nome + "','" + tipo + "','" + quantidade + "','" + preco + "')";
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
        }

        public List<Botepro> listaproduto()
        {
            List<Botepro> li = new List<Botepro>();
            string sql = "SELECT * FROM Produto";
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Botepro f = new Botepro();
                f.Id = Convert.ToInt32(dr["Id"]);
                f.nome = dr["nome"].ToString();
                f.tipo = dr["tipo"].ToString();
                f.quantidade = Convert.ToInt32(dr["quantidade"]);
                f.preco = dr["preco"].ToString();
                li.Add(f);
            }
            return li;
        }

        public void ExcluirPro(int id)
        {
            string sql = "DELETE FROM Produto WHERE Id = '" + id + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void LocalizaPro(int id)
        {
            con.Open();
            string sql = "SELECT * FROM Produto WHERE Id = '" + id + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                nome = dr["nome"].ToString();
                tipo = dr["tipo"].ToString();
                quantidade = Convert.ToInt32(dr["quantidade"]);
                preco = dr["preco"].ToString();
            }
            dr.Close();
            con.Close();
        }

        public void AtualizarPro(int id, string nome, string tipo, int quantidade, string preco)
        {
            string sql = "UPDATE Produto SET nome='" + nome + "',tipo='" + tipo + "',quantidade='" + quantidade + "',preco='" + preco + "' WHERE Id='" + id + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public int NProduto()
        {
            int total = 0;
            string sql = "SELECT COUNT(*) AS total FROM Produto";
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                total = Convert.ToInt32(dr["total"]);
            }
            dr.Close();
            con.Close();
            return total;
        }
    }
}
