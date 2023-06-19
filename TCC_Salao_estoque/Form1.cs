using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace TCC_Salao_estoque
{
    public partial class Estoque : Form
    {
        MySqlConnection Conexao;
        private string data_source = "datasource=localhost;username=root;password=Tel@3921;database=salaoTCC";

        public Estoque()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                //Criar conexao com MySQL
                Conexao = new MySqlConnection(data_source);
                string q = "'%" + tb_produto.Text + "%'";
                string sql = "SELECT * FROM estoque WHERE nomeProduto LIKE " + q;


                Conexao.Open();
                MySqlCommand comando = new MySqlCommand(sql, Conexao);
                MySqlDataReader reader = comando.ExecuteReader();

                tb_produto.Items.Clear();
                while (reader.Read())
                {

                     tb_produto.Items.Add(reader["nomeProduto"].ToString());
;                    tb_marca.Text = reader["marca"].ToString();
                     tb_quantidade.Text = reader["quantidade"].ToString();
                     tb_validade.Text = reader["validate"].ToString();
                     tb_obs.Text = reader["observacao"].ToString();
                     tb_id.Text = reader["idProduto"].ToString();

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            limpar();
            carregar_banco();
        }

        private void limpar()
        {
            tb_produto.Text = "";
            tb_marca.Text = "";
            tb_obs.Text = "";
            tb_quantidade.Text = "";
            tb_validade.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                //Criar conexao com MySQL
                Conexao = new MySqlConnection(data_source);
                var dataFormatada = "";
                if (DateTime.TryParse(tb_validade.Text, out var data)) dataFormatada = data.ToString("yyyy-MM-dd");


                string sql = "INSERT INTO estoque (nomeProduto, quantidade, validate, marca, observacao) VALUES ('" + tb_produto.Text + "','" + tb_quantidade.Text + "','" + dataFormatada + "', '" + tb_marca.Text + "','" + tb_obs.Text + "')";
                MySqlCommand comando = new MySqlCommand(sql, Conexao);
 
                Conexao.Open();
                comando.ExecuteReader();
                MessageBox.Show("Cadastro Inserido");
                //Executar comando Insert
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
            limpar();
            carregar_banco();

        }

        private void Estoque_Load(object sender, EventArgs e)
        {
            carregar_banco();

        }

        private void carregar_banco()
        {
                       try
            {

                //Criar conexao com MySQL
                Conexao = new MySqlConnection(data_source);
                string q = "'%" + tb_produto.Text + "%'";
                string sql = "SELECT * FROM estoque WHERE nomeProduto LIKE " + q;


                Conexao.Open();
                MySqlCommand comando = new MySqlCommand(sql, Conexao);
                MySqlDataReader reader = comando.ExecuteReader();
                tb_produto.Items.Clear();
                while (reader.Read())
                {
                    ; tb_produto.Items.Add(reader["nomeProduto"].ToString());
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                //Criar conexao com MySQL
                Conexao = new MySqlConnection(data_source);
                var dataFormatada = "";
                if (DateTime.TryParse(tb_validade.Text, out var data)) dataFormatada = data.ToString("yyyy-MM-dd");

             
                string sql = "DELETE FROM estoque WHERE idProduto = '" + tb_id.Text + "'";
                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                Conexao.Open();
                comando.ExecuteReader();
                MessageBox.Show("Cadastro Deletado");
                //Executar comando Insert
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
            carregar_banco();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                //Criar conexao com MySQL
                Conexao = new MySqlConnection(data_source);
                var dataFormatada = "";
                if (DateTime.TryParse(tb_validade.Text, out var data)) dataFormatada = data.ToString("yyyy-MM-dd");

                
                string sql = "UPDATE estoque SET nomeProduto = '" + tb_produto.Text + "', quantidade = '" + tb_quantidade.Text + "', validate = '" + dataFormatada + "',marca = '" + tb_marca.Text + "',observacao = '" + tb_obs + "' WHERE idProduto = '" + tb_id.Text + "'";
                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                Conexao.Open();
                comando.ExecuteReader();
                MessageBox.Show("Cadastro atualizado");
                //Executar comando Insert
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
            limpar();
            carregar_banco();

        }
    }
}
