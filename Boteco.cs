using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Boteco
{
    class Boteco
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public string celular { get; set; }
        public string endereco { get; set; }
        public string complemento { get; set; }
        public string cidade { get; set; }
        public string cep { get; set; }
        public string cpf { get; set; }
        public string cc { get; set; }
        public string pix { get; set; }
        public string genero { get; set; }
        public string data_nascimento { get; set; }
        public string funcao { get; set; }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Programas\\Boteco\\DbBoteco.mdf;Integrated Security=True");

        public void InserirFunc(string nome, string celular, string endereco, string complemento, string cidade, string cep, string cpf, string cc, string pix, string genero, string data_nascimento, string funcao)
        {
            string sql = "INSERT INTO Funcionario(nome,celular,endereco,complemento,cidade,cep,cpf,cc,pix,genero,data_nascimento,funcao) VALUES ('"+nome+"','"+celular+"','"+endereco+"','"+complemento+"','"+cidade+"','"+cep+"','"+cpf+"','"+cc+"','"+pix+"','"+genero+"','"+data_nascimento+"','"+funcao+"')";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public List<Boteco> listafuncionario()
        {
            List<Boteco> li = new List<Boteco>();
            string sql = "SELECT * FROM Funcionario";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Boteco f = new Boteco();
                f.Id = Convert.ToInt32(dr["Id"]);
                f.nome = dr["nome"].ToString();
                f.celular = dr["celular"].ToString();
                f.endereco = dr["endereco"].ToString();
                f.complemento = dr["complemento"].ToString();
                f.cidade = dr["cidade"].ToString();
                f.cep = dr["cep"].ToString();
                f.cpf = dr["cpf"].ToString();
                f.cc = dr["cc"].ToString();
                f.pix = dr["pix"].ToString();
                f.genero = dr["genero"].ToString();
                f.data_nascimento = dr["data_nascimento"].ToString();
                f.funcao = dr["funcao"].ToString();
                li.Add(f);
            }
            return li;
        }

        public void ExcluirFunc(int id)
        {
            string sql = "DELETE FROM Funcionario WHERE Id = '"+id+"'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void LocalizaFunc(int id)
        {
            con.Open();
            string sql = "SELECT * FROM Funcionario WHERE Id = '"+id+"'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            string data = Convert.ToString(data_nascimento);
            while (dr.Read())
            {
                nome = dr["nome"].ToString();
                cpf = dr["cpf"].ToString();
                data_nascimento = dr["data_nascimento"].ToString();
                celular = dr["celular"].ToString();
                genero = dr["genero"].ToString();
                cep = dr["cep"].ToString();
                endereco = dr["endereco"].ToString();
                cidade = dr["cidade"].ToString();
                complemento = dr["complemento"].ToString();
                cc = dr["cc"].ToString();
                pix = dr["pix"].ToString();
                funcao = dr["funcao"].ToString();
            }
            dr.Close();
            con.Close();
        }

        public void AtualizarFunc(int id, string nome, string celular, string endereco, string complemento, string cidade, string cep, string cpf, string cc, string pix, string genero, string data_nascimento, string funcao)
        {
            string sql = "UPDATE Funcionario SET nome='"+nome+"',celular='"+celular+"',endereco='"+endereco+"',complemento='"+complemento+"',cidade='"+cidade+"',cep='"+cep+"',cc='"+cc+"',pix='"+pix+"',genero='"+genero+"',data_nascimento='"+data_nascimento+"',funcao='"+funcao+"' WHERE Id='"+id+"'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public int NFuncionario()
        {
            int total = 0;
            string sql = "SELECT COUNT(*) AS total FROM Funcionario";
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
