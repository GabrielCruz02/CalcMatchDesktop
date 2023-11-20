using System.Data;
using System.Globalization;
using System.Xml;

namespace CalcMatchV2.UI
{
    public partial class frmApontamentoHoras : Form
    {
        public frmApontamentoHoras()
        {
            InitializeComponent();
        }

        private void btnBuscarColaboradorFiltro_Click_1(object sender, EventArgs e)
        {
            string pastaDestino = @"E:\Projetos\CalcMatchV2\CalcMatchV2\PontosXML_Lidos\";
            string caminhoArquivo = ""; 

            if (Directory.Exists(pastaDestino))
            {
                try
                {
                    //Navega no diretório sobre os arquivos que existem no mesmo
                    var files = Directory.EnumerateFiles(pastaDestino, "*.*", SearchOption.AllDirectories);
                    foreach (var file in files)
                    {
                        if (Path.GetExtension(file) == ".xml")
                        {
                            caminhoArquivo = Path.GetFullPath(file);
                        }

                        //Pega o nome do arquivo
                        string name = Path.GetFileNameWithoutExtension(caminhoArquivo);
                        string[] words = name.Split("_");
                        //Pega a data do arquivo
                        string formato = "dd-MM-yyyy";
                        DateTime data = DateTime.ParseExact(words[1], formato, CultureInfo.InvariantCulture);
                        
                        if (words[1] == dtpBuscarData.Text.Replace('/', '-'))
                        {
                            //Carrega e lê o arquivo XML
                            XmlDocument xmlDoc = new XmlDocument();
                            xmlDoc.Load(caminhoArquivo);

                            //XmlNodeList registros = xmlDoc.SelectNodes("//Registro");
                            XmlNodeList nodes = xmlDoc.SelectNodes($"//Registro[Matricula={txtBuscarColaborador.Text}]");
                            

                            // Cria um objeto DataTable para armazenar os registros obtidos
                            DataTable dataTable = new DataTable();
                            

                            // Adiciona as colunas ao DataTable
                            dataTable.Columns.Add("Matricula", typeof(string));
                            dataTable.Columns.Add("Entrada", typeof(string));
                            dataTable.Columns.Add("IdaAlmoco", typeof(string));
                            dataTable.Columns.Add("RetornoAlmoco", typeof(string));
                            dataTable.Columns.Add("Saida", typeof(string));

                            // Itera sobre cada elemento selecionado e adiciona uma nova linha ao DataTable
                            foreach (XmlNode node in nodes)
                            {
                                DataRow row = dataTable.NewRow();
                                row["Matricula"] = node.SelectSingleNode("Matricula").InnerText;
                                row["Entrada"] = node.SelectSingleNode("Entrada").InnerText;
                                row["IdaAlmoco"] = node.SelectSingleNode("IdaAlmoco").InnerText;
                                row["RetornoAlmoco"] = node.SelectSingleNode("RetornoAlmoco").InnerText;
                                row["Saida"] = node.SelectSingleNode("Saida").InnerText;
                                dataTable.Rows.Add(row);
                            }

                            // Define o DataSource do DataGridView como o objeto DataTable
                            dataGridView1.DataSource = dataTable;
                        }
                    }
                }
                catch (IOException Ex)
                {
                    Console.WriteLine(Ex.Message);
                }
                catch (XmlException ex)
                {
                    Console.WriteLine(ex.Message);

                }

            }
            else
            {
                MessageBox.Show($"O diretorio solicitado pelo programa não exite no local atual!");
            }

        }
    }
}

