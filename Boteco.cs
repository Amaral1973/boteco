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
        public DateTime data_nascimento { get; set; }
        public string funcao { get; set; }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Programas\\Boteco\\DbBoteco.mdf;Integrated Security=True");

        public void InserirFunc(string nome, string celular, string endereco, string complemento, string cidade, string cep, string cpf, string cc, string pix, string genero, DateTime data_nascimento, string funcao)
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
                f.nome = dr["nome"].ToString();
                f.celular = dr["celular"].ToString();
                f.cpf = dr["cpf"].ToString();
                f.cc = dr["cc"].ToString();
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
            string sql = "SELECT * FROM Funcionario WHERE Id = '"+id+"'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            string data = Convert.ToString(data_nascimento);
            while (dr.Read())
            {
                nome = dr["nome"].ToString();
                cpf = dr["cpf"].ToString();
                data = Convert.ToString(dr["data_nascimento"]);
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
        }

        public void AtualizarFunc(int id, string nome, string celular, string endereco, string complemento, string cidade, string cep, string cpf, string cc, string pix, string genero, DateTime data_nascimento, string funcao)
        {
            string sql = "UPDATE Funcionario SET nome='"+nome+"',celular='"+celular+"',endereco='"+endereco+"',complemento='"+complemento+"',cidade='"+cidade+"',cep='"+cep+"',cc='"+cc+"',pix='"+pix+"',genero='"+genero+"',data_nascimento='"+data_nascimento+"',funcao='"+funcao+"' WHERE Id='"+id+"'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
