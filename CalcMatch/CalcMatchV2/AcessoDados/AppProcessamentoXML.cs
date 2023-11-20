using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CalcMatchV2.AcessoDados
{
    public class AppProcessamentoXML
    {


        public static void LerXML()
        {
            //Caminhos
            string pastaOrigem = @"E:\Projetos\CalcMatchV2\CalcMatchV2\PontosXML\";
            string caminhoArquivo = "";
            string pastaDestino = @"E:\Projetos\CalcMatchV2\CalcMatchV2\PontosXML_Lidos\";
            //Variáveis
            string formatoHoras = "HH:mm:ss";
            DateTime hrEntrada = DateTime.Today;
            DateTime hrSaida = DateTime.Today;
            DateTime hrAlmoco = DateTime.Today;
            DateTime hrRetAlmoco = DateTime.Today;
            string Matricula = "";

            try
            {
                //Navega no diretório sobre os arquivos que existem no mesmo
                var files = Directory.EnumerateFiles(pastaOrigem, "*.*", SearchOption.AllDirectories);
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
                    DateTime data = DateTime.ParseExact(words[2], formato, CultureInfo.InvariantCulture);

                    if (data == DateTime.Today)//Verifica se a data que consta no nome do arquivo é igual ao dia de hoje
                    {
                        //Carrega e lê o arquivo XML
                        XmlDocument xmlDoc = new XmlDocument();
                        xmlDoc.Load(caminhoArquivo);

                        foreach (XmlNode node in xmlDoc.DocumentElement.ChildNodes)
                        {
                            //Captura os pontos do arquivo conforme a tag
                            switch (node.Name)
                            {
                                case "Matricula":
                                    Matricula = node.InnerText;
                                    break;

                                case "Entrada":
                                    hrEntrada = DateTime.ParseExact(node.InnerText, formatoHoras, CultureInfo.InvariantCulture);
                                    break;

                                case "IdaAlmoco":
                                    hrAlmoco = DateTime.ParseExact(node.InnerText, formatoHoras, CultureInfo.InvariantCulture);
                                    break;

                                case "RetornoAlmoco":
                                    hrRetAlmoco = DateTime.ParseExact(node.InnerText, formatoHoras, CultureInfo.InvariantCulture);
                                    break;

                                case "Saida":
                                    hrSaida = DateTime.ParseExact(node.InnerText, formatoHoras, CultureInfo.InvariantCulture);
                                    break;

                                default:
                                    break;
                            }
                        }
                        //Calcula a quantidade de horas trabalhadas
                        TimeSpan tempoTotal = hrSaida - hrEntrada;
                        TimeSpan tempoAlmoco = hrRetAlmoco - hrAlmoco;
                        TimeSpan hrTotalDia = tempoTotal - tempoAlmoco;

                        //Captura a entidade do banco, atualiza o atributo e salva o objeto no banco
                        using (var db = new AppDbContext())
                        {
                            var funcionario = db.Funcionarios.Single(f => f.Id == Convert.ToInt32(Matricula));
                            funcionario.HorasTrabalhadas += Convert.ToDouble(hrTotalDia.TotalHours);
                            db.Funcionarios.Attach(funcionario);
                            db.SaveChanges();
                        }
                        //
                        //Move o arquivo lido para outra pasta
                        File.Move(caminhoArquivo, Path.Combine(pastaDestino, name));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}