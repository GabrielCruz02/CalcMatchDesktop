using CalcMatchV1.Entities;
using iTextSharp.text.pdf;
using iTextSharp.text;
using Font = iTextSharp.text.Font;
using Image = iTextSharp.text.Image;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcMatchV2.AcessoDados
{
    public class Holerite
    {
        public static void GerarHolerite(Funcionario funcionario)
        {
            string pathFile = @$"E:\Projetos\CalcMatchV2\CalcMatchV2\Holerites\{funcionario.Nome} {DateTime.Now.ToString("dd-MM-yyyy")}.pdf";

            if (File.Exists(pathFile))
            {
                MessageBox.Show($"O arquivo solicitado ja existe no seguinte destino: {pathFile} \nPorfavor tente acessa-lo atraves do destino mensionado e se continuar com problemas contate o suporte da sua aplicação! ");
            }
            else
            {
                Font titleFont = FontFactory.GetFont(FontFactory.TIMES_BOLD, 18);
                Font subtitleFont = FontFactory.GetFont(FontFactory.TIMES_BOLD, 10);
                Font elementoFont = FontFactory.GetFont(FontFactory.TIMES_BOLD, 12);
                Font valorFont = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12);
                Document documento = new Document();

                var inss = funcionario.CalculaINSS();
                var ir = funcionario.CalculaImpostoRenda();
                var aliquotaINSS = funcionario.aliquotaINSS * 100;
                var aliquotaIR = funcionario.aliquotaIR * 100;
                var deducoes = funcionario.CalculaImpostoRenda() + funcionario.CalculaINSS() + funcionario.CalculaVT();
                try
                {
                    //Instancia e cria o documento no caminho
                    PdfWriter write = PdfWriter.GetInstance(documento, new FileStream(pathFile, FileMode.Create));
                    PdfPCell celula;
                    Paragraph espaco = new Paragraph("\n");

                    //Abre o documento
                    documento.Open();

                    //Logotipo da CalcMath
                    Image logo = Image.GetInstance(@"E:\Projetos\CalcMatchV2\CalcMatchV2\Calcmatch Logo.png");
                    logo.ScalePercent(15f);
                    documento.Add(logo);

                    //Titulo do documento e mês do holerite
                    Paragraph titulo = new Paragraph("Recebimento de Pagamento de Salário", titleFont);
                    titulo.Alignment = Element.ALIGN_CENTER;
                    documento.Add(titulo);
                    Paragraph dataHolerite = new Paragraph(DateTime.Today.Month + "/" + DateTime.Today.Year, titleFont);
                    dataHolerite.Alignment = Element.ALIGN_CENTER;
                    documento.Add(dataHolerite);
                    documento.Add(espaco);
                    documento.Add(espaco);

                    //Design da Tabela de informações da empresa
                    PdfPTable tabelaEmpregador = new PdfPTable(2);
                    //Linha 1
                    celula = new PdfPCell(new Phrase("Empregador", subtitleFont));
                    celula.Colspan = 2;
                    celula.HorizontalAlignment = Element.ALIGN_CENTER;
                    celula.BorderWidthBottom = 0;
                    tabelaEmpregador.AddCell(celula);
                    //Linha 2
                    celula = new PdfPCell(new Phrase("Nome:", elementoFont));
                    celula.BorderWidthRight = 0;
                    celula.BorderWidthTop = 0;
                    celula.BorderWidthBottom = 0;
                    tabelaEmpregador.AddCell(celula);
                    celula = new PdfPCell(new Phrase("-", valorFont));
                    celula.BorderWidthTop = 0;
                    celula.BorderWidthLeft = 0;
                    celula.BorderWidthBottom = 0;
                    celula.HorizontalAlignment = Element.ALIGN_RIGHT;
                    tabelaEmpregador.AddCell(celula);
                    //Linha 3
                    celula = new PdfPCell(new Phrase("Endereço:", elementoFont));
                    celula.BorderWidthTop = 0;
                    celula.BorderWidthRight = 0;
                    celula.BorderWidthBottom = 0;
                    tabelaEmpregador.AddCell(celula);
                    celula = new PdfPCell(new Phrase("-", valorFont));
                    celula.BorderWidthTop = 0;
                    celula.BorderWidthLeft = 0;
                    celula.HorizontalAlignment = Element.ALIGN_RIGHT;
                    celula.BorderWidthBottom = 0;
                    tabelaEmpregador.AddCell(celula);
                    //Linha 4
                    celula = new PdfPCell(new Phrase("CNPJ:", elementoFont));
                    celula.BorderWidthTop = 0;
                    celula.BorderWidthRight = 0;
                    tabelaEmpregador.AddCell(celula);
                    celula = new PdfPCell(new Phrase("-", valorFont));
                    celula.BorderWidthTop = 0;
                    celula.BorderWidthLeft = 0;
                    celula.HorizontalAlignment = Element.ALIGN_RIGHT;
                    tabelaEmpregador.AddCell(celula);
                    //Fim do design da tabela
                    documento.Add(tabelaEmpregador); //Adiciona a tabela ao documento

                    documento.Add(espaco);

                    //Tabela de informações do funcionário
                    PdfPTable tabelaFuncionario = new PdfPTable(3);
                    //Linha 1
                    celula = new PdfPCell(new Phrase("Codigo", subtitleFont));
                    celula.BorderWidthBottom = 0;
                    celula.BorderWidthRight = 0;
                    tabelaFuncionario.AddCell(celula);
                    celula = new PdfPCell(new Phrase("Nome do Funcionario", subtitleFont));
                    celula.BorderWidthRight = 0;
                    celula.BorderWidthLeft = 0;
                    celula.BorderWidthBottom = 0;
                    tabelaFuncionario.AddCell(celula);
                    celula = new PdfPCell(new Phrase("Cargo", subtitleFont));
                    celula.BorderWidthLeft = 0;
                    celula.BorderWidthBottom = 0;
                    tabelaFuncionario.AddCell(celula);
                    //Linha 2
                    celula = new PdfPCell(new Phrase(funcionario.Id.ToString(), valorFont));
                    celula.BorderWidthRight = 0;
                    celula.BorderWidthTop = 0;
                    tabelaFuncionario.AddCell(celula);
                    celula = new PdfPCell(new Phrase(funcionario.Nome, valorFont));
                    celula.BorderWidthRight = 0;
                    celula.BorderWidthLeft = 0;
                    celula.BorderWidthTop = 0;
                    tabelaFuncionario.AddCell(celula);
                    celula = new PdfPCell(new Phrase(funcionario.Cargo, valorFont));
                    celula.BorderWidthLeft = 0;
                    celula.BorderWidthTop = 0;
                    tabelaFuncionario.AddCell(celula);
                    //Fim da tabela
                    documento.Add(tabelaFuncionario);//Adiciona a tabela ao documento
                    documento.Add(espaco);

                    //Tabela do Pagamento.
                    PdfPTable tabelaPagamento = new PdfPTable(4);
                    //Linha 1 -  Cabeçalho
                    celula = new PdfPCell(new Phrase("Descrição", elementoFont));//coluna 1
                    celula.HorizontalAlignment = Element.ALIGN_CENTER;
                    tabelaPagamento.AddCell(celula);
                    celula = new PdfPCell(new Phrase("Referência", elementoFont));//coluna 2
                    celula.HorizontalAlignment = Element.ALIGN_CENTER;
                    tabelaPagamento.AddCell(celula);
                    celula = new PdfPCell(new Phrase("Proventos", elementoFont));//coluna 3
                    celula.HorizontalAlignment = Element.ALIGN_CENTER;
                    tabelaPagamento.AddCell(celula);
                    celula = new PdfPCell(new Phrase("Deduções", elementoFont));//coluna 4
                    celula.HorizontalAlignment = Element.ALIGN_CENTER;
                    tabelaPagamento.AddCell(celula);
                    //Linha 2 - 
                    celula = new PdfPCell(new Phrase("Salário Base", valorFont));
                    celula.BorderWidthBottom = 0;
                    celula.BorderWidthTop = 0;
                    celula.BorderWidthRight = 0;
                    tabelaPagamento.AddCell(celula);
                    celula = new PdfPCell(new Phrase("", valorFont));
                    celula.BorderWidthBottom = 0;
                    celula.BorderWidthTop = 0;
                    celula.HorizontalAlignment = Element.ALIGN_RIGHT;
                    tabelaPagamento.AddCell(celula);
                    celula = new PdfPCell(new Phrase(funcionario.CalculaSalarioBruto().ToString("F2"), valorFont));
                    celula.BorderWidthTop = 0;
                    celula.BorderWidthBottom = 0;
                    celula.HorizontalAlignment = Element.ALIGN_RIGHT;
                    tabelaPagamento.AddCell(celula);
                    celula = new PdfPCell(new Phrase("0,00", valorFont));
                    celula.BorderWidthBottom = 0;
                    celula.BorderWidthTop = 0;
                    celula.BorderWidthLeft = 0;
                    celula.HorizontalAlignment = Element.ALIGN_RIGHT;
                    tabelaPagamento.AddCell(celula);
                    //Linha 3
                    celula = new PdfPCell(new Phrase("INSS", valorFont));
                    celula.BorderWidthBottom = 0;
                    celula.BorderWidthTop = 0;
                    celula.BorderWidthRight = 0;
                    tabelaPagamento.AddCell(celula);
                    celula = new PdfPCell(new Phrase(aliquotaINSS.ToString("F2") + "%", valorFont));
                    celula.BorderWidthBottom = 0;
                    celula.BorderWidthTop = 0;
                    celula.HorizontalAlignment = Element.ALIGN_RIGHT;
                    tabelaPagamento.AddCell(celula);
                    celula = new PdfPCell(new Phrase("0,00", valorFont));
                    celula.BorderWidthTop = 0;
                    celula.BorderWidthBottom = 0;
                    celula.HorizontalAlignment = Element.ALIGN_RIGHT;
                    tabelaPagamento.AddCell(celula);
                    celula = new PdfPCell(new Phrase(inss.ToString("F2"), valorFont));
                    celula.BorderWidthBottom = 0;
                    celula.BorderWidthTop = 0;
                    celula.BorderWidthLeft = 0;
                    celula.HorizontalAlignment = Element.ALIGN_RIGHT;
                    tabelaPagamento.AddCell(celula);
                    //Linha 4
                    celula = new PdfPCell(new Phrase("Imposto de Renda", valorFont));
                    celula.BorderWidthBottom = 0;
                    celula.BorderWidthTop = 0;
                    celula.BorderWidthRight = 0;
                    tabelaPagamento.AddCell(celula);
                    celula = new PdfPCell(new Phrase(aliquotaIR.ToString("F2") + "%", valorFont));
                    celula.BorderWidthBottom = 0;
                    celula.BorderWidthTop = 0;
                    celula.HorizontalAlignment = Element.ALIGN_RIGHT;
                    tabelaPagamento.AddCell(celula);
                    celula = new PdfPCell(new Phrase("0,00", valorFont));
                    celula.BorderWidthTop = 0;
                    celula.BorderWidthBottom = 0;
                    celula.HorizontalAlignment = Element.ALIGN_RIGHT;
                    tabelaPagamento.AddCell(celula);
                    celula = new PdfPCell(new Phrase(funcionario.CalculaImpostoRenda().ToString("F2"), valorFont));
                    celula.BorderWidthBottom = 0;
                    celula.BorderWidthTop = 0;
                    celula.BorderWidthLeft = 0;
                    celula.HorizontalAlignment = Element.ALIGN_RIGHT;
                    tabelaPagamento.AddCell(celula);
                    //Linha 5
                    celula = new PdfPCell(new Phrase("Vale Transporte", valorFont));
                    celula.BorderWidthBottom = 0;
                    celula.BorderWidthTop = 0;
                    celula.BorderWidthRight = 0;
                    tabelaPagamento.AddCell(celula);
                    celula = new PdfPCell(new Phrase("6,00%", valorFont));
                    celula.BorderWidthBottom = 0;
                    celula.BorderWidthTop = 0;
                    celula.HorizontalAlignment = Element.ALIGN_RIGHT;
                    tabelaPagamento.AddCell(celula);
                    celula = new PdfPCell(new Phrase("0,00", valorFont));
                    celula.BorderWidthTop = 0;
                    celula.BorderWidthBottom = 0;
                    celula.HorizontalAlignment = Element.ALIGN_RIGHT;
                    tabelaPagamento.AddCell(celula);
                    celula = new PdfPCell(new Phrase(funcionario.CalculaVT().ToString("F2"), valorFont));
                    celula.BorderWidthBottom = 0;
                    celula.BorderWidthTop = 0;
                    celula.BorderWidthLeft = 0;
                    celula.HorizontalAlignment = Element.ALIGN_RIGHT;
                    tabelaPagamento.AddCell(celula);
                    //Linha 6
                    celula = new PdfPCell(new Phrase("Salário Familia", valorFont));
                    celula.BorderWidthBottom = 0;
                    celula.BorderWidthTop = 0;
                    celula.BorderWidthRight = 0;
                    tabelaPagamento.AddCell(celula);
                    celula = new PdfPCell(new Phrase("Nro. Dep.", valorFont));
                    celula.BorderWidthBottom = 0;
                    celula.BorderWidthTop = 0;
                    celula.HorizontalAlignment = Element.ALIGN_RIGHT;
                    tabelaPagamento.AddCell(celula);
                    celula = new PdfPCell(new Phrase(funcionario.CalculaSalarioFamilia().ToString("F2"), valorFont));
                    celula.BorderWidthTop = 0;
                    celula.BorderWidthBottom = 0;
                    celula.HorizontalAlignment = Element.ALIGN_RIGHT;
                    tabelaPagamento.AddCell(celula);
                    celula = new PdfPCell(new Phrase("0,00", valorFont));
                    celula.BorderWidthBottom = 0;
                    celula.BorderWidthTop = 0;
                    celula.BorderWidthLeft = 0;
                    celula.HorizontalAlignment = Element.ALIGN_RIGHT;
                    tabelaPagamento.AddCell(celula);
                    //Linha 7
                    celula = new PdfPCell(new Phrase("FGTS", valorFont));
                    celula.BorderWidthBottom = 0;
                    celula.BorderWidthTop = 0;
                    celula.BorderWidthRight = 0;
                    tabelaPagamento.AddCell(celula);
                    celula = new PdfPCell(new Phrase("8,00%", valorFont));
                    celula.BorderWidthBottom = 0;
                    celula.BorderWidthTop = 0;
                    celula.HorizontalAlignment = Element.ALIGN_RIGHT;
                    tabelaPagamento.AddCell(celula);
                    celula = new PdfPCell(new Phrase("0,00", valorFont));
                    celula.BorderWidthTop = 0;
                    celula.BorderWidthBottom = 0;
                    celula.HorizontalAlignment = Element.ALIGN_RIGHT;
                    tabelaPagamento.AddCell(celula);
                    celula = new PdfPCell(new Phrase("0,00", valorFont));
                    celula.BorderWidthBottom = 0;
                    celula.BorderWidthTop = 0;
                    celula.BorderWidthLeft = 0;
                    celula.HorizontalAlignment = Element.ALIGN_RIGHT;
                    tabelaPagamento.AddCell(celula);
                    //Linha 8 a 11?
                    for (int i = 0; i < 3; i++)
                    {
                        celula = new PdfPCell(new Phrase(" ", valorFont));
                        celula.BorderWidthBottom = 0;
                        celula.BorderWidthTop = 0;
                        celula.BorderWidthRight = 0;
                        tabelaPagamento.AddCell(celula);
                        celula = new PdfPCell(new Phrase(" ", valorFont));
                        celula.BorderWidthBottom = 0;
                        celula.BorderWidthTop = 0;
                        tabelaPagamento.AddCell(celula);
                        celula = new PdfPCell(new Phrase(" ", valorFont));
                        celula.BorderWidthTop = 0;
                        celula.BorderWidthBottom = 0;
                        tabelaPagamento.AddCell(celula);
                        celula = new PdfPCell(new Phrase(" ", valorFont));
                        celula.BorderWidthBottom = 0;
                        celula.BorderWidthTop = 0;
                        celula.BorderWidthLeft = 0;
                        tabelaPagamento.AddCell(celula);
                    }
                    //Linha 12
                    celula = new PdfPCell(new Phrase("Observações", elementoFont));
                    celula.BorderWidthBottom = 0;
                    celula.Colspan = 2;//Mescla a célula em 2 colunas
                    tabelaPagamento.AddCell(celula);
                    celula = new PdfPCell(new Phrase("Total adicionais", elementoFont));
                    celula.BorderWidthBottom = 0;
                    tabelaPagamento.AddCell(celula);
                    celula = new PdfPCell(new Phrase("Total descontos", elementoFont));
                    celula.BorderWidthBottom = 0;
                    celula.BorderWidthLeft = 0;
                    tabelaPagamento.AddCell(celula);
                    //Antepenúltima
                    celula = new PdfPCell(new Phrase("", valorFont));
                    celula.BorderWidthTop = 0;
                    celula.BorderWidthBottom = 0;
                    celula.Colspan = 2;
                    tabelaPagamento.AddCell(celula);
                    celula = new PdfPCell(new Phrase((funcionario.CalculaSalarioBruto() + funcionario.CalculaSalarioFamilia()).ToString("F2"), valorFont)); //Valor total dos proventos
                    celula.HorizontalAlignment = Element.ALIGN_RIGHT;
                    celula.BorderWidthTop = 0;
                    tabelaPagamento.AddCell(celula);
                    celula = new PdfPCell(new Phrase(deducoes.ToString("F2"), valorFont)); //Valor total dos descontos
                    celula.BorderWidthTop = 0;
                    celula.BorderWidthLeft = 0;
                    celula.HorizontalAlignment = Element.ALIGN_RIGHT;
                    tabelaPagamento.AddCell(celula);
                    //Últimas 2 linhas
                    celula = new PdfPCell(new Phrase("FGTS: ", elementoFont));
                    celula.BorderWidthRight = 0;
                    tabelaPagamento.AddCell(celula);
                    celula = new PdfPCell(new Phrase(funcionario.CalculaFGTS().ToString("F2"), valorFont)); //Valor calculado do FGTS
                    celula.HorizontalAlignment = Element.ALIGN_RIGHT;
                    celula.BorderWidthLeft = 0;
                    tabelaPagamento.AddCell(celula);
                    celula = new PdfPCell(new Phrase("Total a receber líq.", elementoFont));
                    tabelaPagamento.AddCell(celula);
                    celula = new PdfPCell(new Phrase(funcionario.calculaSalarioLiquido().ToString("F2"), valorFont));
                    celula.HorizontalAlignment = Element.ALIGN_RIGHT;
                    tabelaPagamento.AddCell(celula);
                    //Fim dos cálculos
                    //Fim da tabela
                    documento.Add(tabelaPagamento);//Adiciona a tabela ao documento
                    documento.Add(espaco);
                    documento.Add(espaco);
                    documento.Add(espaco);
                    documento.Add(espaco);

                    Paragraph assinatura = new Paragraph("Assinatura do empregado", valorFont);
                    documento.Add(assinatura);
                    Paragraph linha = new Paragraph("_________________________________", valorFont);
                    documento.Add(linha);
                    Paragraph data = new Paragraph("Data da assinatura", valorFont);
                    documento.Add(data);
                    Paragraph dataAssinada = new Paragraph("___/___/___", valorFont);
                    documento.Add(dataAssinada);
                    documento.Add(espaco);

                    //Fim do design do documento
                    documento.Close(); //Fecha o documento

                    //Sinalização de que o documento foi gerado
                    MessageBox.Show($"Holerite gerado com sucesso em formato PDF no destino:\n{pathFile}");
                }
                catch (DocumentException ex)
                {
                    MessageBox.Show("Falha ao gerar o holerite! erro: " + ex.Message + "contate o suporte da sua aplicação para mais informações");
                }
            }
        }
    }
}