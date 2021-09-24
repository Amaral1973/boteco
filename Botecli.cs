using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Boteco
{
    class Botecli
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string data_nascimento { get; set; }
        public string celular { get; set; }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Programas\\Boteco\\DbBoteco.mdf;Integrated Security=True");

        public void InserirCli(string nome, string cpf, string data_nascimento, string celular)
        {
            string sql = "INSERT INTO Cliente(nome,cpf,data_nascimento,celular) VALUES ('"+nome+"','"+cpf+"','"+data_nascimento+"','"+celular+"')";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public List<Botecli> listacli()
        {
            List<Botecli> li = new List<Botecli>();
            string sql = "SELECT * FROM Cliente";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Botecli f = new Botecli();
                f.Id = Convert.ToInt32(dr["Id"]);
                f.nome = dr["nome"].ToString();
                f.cpf = dr["cpf"].ToString();
                f.data_nascimento = dr["data_nascimento"].ToString();
                f.celular = dr["celular"].ToString();
                li.Add(f);
            }
            dr.Close();
            con.Close();
            return li;
        }

        public void ExcluirCli(int id)
        {
            string sql = "DELETE FROM Cliente WHERE Id = '" + id + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void LocalizaCli(int id)
        {
            con.Open();
            string sql = "SELECT * FROM Cliente WHERE Id = '" + id + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                nome = dr["nome"].ToString();
                cpf = dr["cpf"].ToString();
                data_nascimento = dr["data_nascimento"].ToString();
                celular = dr["celular"].ToString();
            }
            dr.Close();
            con.Close();
        }

        public void AtualizaCli(int id,string nome, string cpf, string data_nascimento, string celular)
        {
            string sql = "UPDATE Cliente SET nome='"+nome+"',cpf='"+cpf+"',data_nascimento='"+data_nascimento+"',celular='"+celular+"' WHERE Id='"+id+"'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
