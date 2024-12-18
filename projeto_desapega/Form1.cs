using MySql.Data.MySqlClient;
using Org.BouncyCastle.Math.EC;

namespace projeto_desapega
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string bd = "string para conectar";

                var conn = new MySqlConnection(bd);

                conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message, "Erro ao conectar ao banco");
            }
        }
    }
}
