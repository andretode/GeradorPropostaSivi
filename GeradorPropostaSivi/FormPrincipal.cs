using Microsoft.Office.Interop.Word;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GeradorPropostaSivi
{
    public partial class FormPrincipal : Form
    {
        System.Drawing.Font fonteEmNegrito;
        System.Drawing.Font fonteEmItalico;
        object doNotSaveChanges = WdSaveOptions.wdDoNotSaveChanges;
        object missing = Type.Missing;
        Parametros parametrosProposta;

        public FormPrincipal()
        {
            InitializeComponent();
            fonteEmNegrito = new System.Drawing.Font(this.Font.FontFamily, 8, FontStyle.Bold);
            fonteEmItalico = new System.Drawing.Font(this.Font.FontFamily, 8, FontStyle.Italic);
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            CarregarParametros();
        }

        private void buttonAplicar_Click(object sender, EventArgs e)
        {
            openFileDialogModelo.Title = "Carregar Proposta Modelo";
            openFileDialogModelo.FileName = "";
            DialogResult dialogResult = openFileDialogModelo.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                AplicarValoresProposta(openFileDialogModelo.FileName);
                MessageBox.Show(this, "O processamento foi finalizado com sucesso!", "Processamento Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            CalcularValoresMensalidadeDasCelula();
            CalcularValoresImplantacao();
            tabControlValores.SelectedTab = tabControlValores.TabPages[1];
        }

        private void CarregarParametrosNaInterface()
        {
            textBoxValorBasedoModuloPlano.Text = parametrosProposta.ValorBaseModuloPlano.ToString();
            textBoxValorBasedoModuloImplantacao.Text = parametrosProposta.ValorBaseModuloImplantacao.ToString();
            textBoxPorcetagemDescontoImplantacao.Text = parametrosProposta.PorcetagemDescontoImplantacao.ToString();

            dataGridViewPesoQuantEmpreendimento.Rows.Clear();
            foreach (QuantEmpreendimentos quantEmpreendimentos in parametrosProposta.listaDeQuantEmpreendimentos)
            {
                dataGridViewPesoQuantEmpreendimento.Rows.Add(new object[] { quantEmpreendimentos.Quantidade, quantEmpreendimentos.Peso });
            }

            dataGridViewPesoPlano.Rows.Clear();
            foreach (PlanoAtendimento planoAtendimento in parametrosProposta.listaDePlanosAtendimento)
            {
                dataGridViewPesoPlano.Rows.Add(new object[] { planoAtendimento.Nome, planoAtendimento.Peso });
            }

            dataGridViewPesoModulo.Rows.Clear();
            foreach (Modulo modulo in parametrosProposta.listaDeModulos)
            {
                dataGridViewPesoModulo.Rows.Add(new object[] { modulo.Nome, modulo.PesoMensalidade, modulo.PesoImplantacao, modulo.Incluso });
            }
        }

        private void CalcularValoresMensalidadeDasCelula()
        {
            dataGridViewResultadoPlano.Rows.Clear();
            float valorBaseDoModuloPlano = Single.Parse(textBoxValorBasedoModuloPlano.Text);

            //Loop por plano
            for(int linhaPlano = 0; linhaPlano < dataGridViewPesoPlano.Rows.Count; linhaPlano++)
            {
                dataGridViewResultadoPlano.Rows.Add(new object[] { dataGridViewPesoPlano[0, linhaPlano].Value.ToString() });
                var estiloFonteLinhaModulo = dataGridViewResultadoPlano.Rows[linhaPlano * (dataGridViewPesoModulo.Rows.Count + 2)].DefaultCellStyle;
                estiloFonteLinhaModulo.BackColor = Color.LightBlue;
                estiloFonteLinhaModulo.Font = fonteEmNegrito;

                float fatorMultiplicardorPlano = Single.Parse(dataGridViewPesoPlano[1, linhaPlano].Value.ToString());

                //Loop por módulo
                float[] valoresTotalPorQuantEmpreendimento = new float[dataGridViewPesoQuantEmpreendimento.Rows.Count];
                for (int linhaModulo = 0; linhaModulo < dataGridViewPesoModulo.Rows.Count; linhaModulo++)
                {
                    float pesoDoModuloNoPlano = Single.Parse(dataGridViewPesoModulo[1, linhaModulo].Value.ToString());

                    //Loop por quantidade de empreendimentos
                    string[] valoresPorQuantEmpreendimento = new string[dataGridViewPesoQuantEmpreendimento.Rows.Count];
                    for (int linhaQuantEmpreend = 0; linhaQuantEmpreend < dataGridViewPesoQuantEmpreendimento.Rows.Count; linhaQuantEmpreend++)
                    {
                        float fatorMultiplicardorQuantEmpreend = Single.Parse(dataGridViewPesoQuantEmpreendimento[1, linhaQuantEmpreend].Value.ToString());
                        float valor = 0;
                        if (Boolean.Parse(dataGridViewPesoModulo[3, linhaModulo].Value.ToString()))
                            valor = CalcularValorMensalidade(valorBaseDoModuloPlano, fatorMultiplicardorPlano, fatorMultiplicardorQuantEmpreend, pesoDoModuloNoPlano);
                        valoresPorQuantEmpreendimento[linhaQuantEmpreend] = valor.ToString("C");
                        valoresTotalPorQuantEmpreendimento[linhaQuantEmpreend] += valor;
                    }

                    dataGridViewResultadoPlano.Rows.Add(new object[] { dataGridViewPesoModulo[0, linhaModulo].Value.ToString(), valoresPorQuantEmpreendimento[0],
                    valoresPorQuantEmpreendimento[1], valoresPorQuantEmpreendimento[2], valoresPorQuantEmpreendimento[3]});
                }
                dataGridViewResultadoPlano.Rows.Add(new object[] { "Total", valoresTotalPorQuantEmpreendimento[0].ToString("C"), valoresTotalPorQuantEmpreendimento[1].ToString("C"),
                valoresTotalPorQuantEmpreendimento[2].ToString("C"), valoresTotalPorQuantEmpreendimento[3].ToString("C")});
                
                int ultimaLinha = dataGridViewResultadoPlano.Rows.Count - 1;
                dataGridViewResultadoPlano.Rows[ultimaLinha].DefaultCellStyle.Font = fonteEmItalico;
            }
        }

        private float CalcularValorMensalidade(float valorBasedoModulo, float fatorMultiplicardorPlano, float fatorMultiplicardorQuantEmpreend, float pesoDoModulo)
        {
            float resultado = 0;

            resultado = valorBasedoModulo * fatorMultiplicardorPlano * fatorMultiplicardorQuantEmpreend * pesoDoModulo;

            return resultado;
        }

        private void CalcularValoresImplantacao()
        {
            dataGridViewResultadoImplantacao.Rows.Clear();
            float valorBaseDoModuloImplantacao = Single.Parse(textBoxValorBasedoModuloImplantacao.Text);

            //Loop por módulo
            float valorTotal = 0;
            for (int linhaModulo = 0; linhaModulo < dataGridViewPesoModulo.Rows.Count - 1; linhaModulo++)
            {
                float pesoDoModuloNaImplantacao = Single.Parse(dataGridViewPesoModulo[2, linhaModulo].Value.ToString());

                float valor = 0;
                string incluir = "Não";
                if (Boolean.Parse(dataGridViewPesoModulo[3, linhaModulo].Value.ToString()))
                {
                    valor = valorBaseDoModuloImplantacao * pesoDoModuloNaImplantacao;
                    incluir = "Sim";
                }

                valorTotal += valor;
                dataGridViewResultadoImplantacao.Rows.Add(new object[] { dataGridViewPesoModulo[0, linhaModulo].Value.ToString(), valor.ToString("C"), incluir} );
            }
            dataGridViewResultadoImplantacao.Rows.Add(new object[] { "Total", valorTotal.ToString("C") });
            dataGridViewResultadoImplantacao.Rows.Add(new object[] { "Total com desconto de " + textBoxPorcetagemDescontoImplantacao.Text + "%", 
                aplicarDesconto(valorTotal,Single.Parse(textBoxPorcetagemDescontoImplantacao.Text)).ToString("C") });

            int ultimaLinha = dataGridViewResultadoImplantacao.Rows.Count - 1;
            dataGridViewResultadoImplantacao.Rows[ultimaLinha].DefaultCellStyle.Font = fonteEmItalico;
        }

        private float aplicarDesconto(float valor, float desconto)
        {
            return valor - valor * desconto / 100;
        }

        private void AplicarValoresProposta(string caminhoArquivoWord)
        {
            //abre o documento word
            Microsoft.Office.Interop.Word.Application WordApplication = new Microsoft.Office.Interop.Word.Application();
            Document doc = WordApplication.Documents.Open(caminhoArquivoWord);

            //aplica valores dos planos
            int quantModulos = dataGridViewPesoModulo.Rows.Count + 2; //soma 2 porque tem a linha que descreve o plano e a linha da soma total dos valores dos módulos
            for (int linhaDoGridPlano = 0; linhaDoGridPlano < dataGridViewResultadoPlano.Rows.Count; linhaDoGridPlano++)
            {
                int linhaPlano = Int32.Parse(Math.Floor((double)linhaDoGridPlano / quantModulos).ToString());
                int linhaInvalida = linhaPlano * quantModulos;
                int linhaModulo = linhaDoGridPlano % quantModulos;
                if (linhaDoGridPlano != linhaInvalida)
                {
                    DataGridViewRow linhaDoResultado = dataGridViewResultadoPlano.Rows[linhaDoGridPlano];
                    for (int colDoGrid = 1; colDoGrid < dataGridViewResultadoPlano.Columns.Count; colDoGrid++)
                    {
                        DataGridViewColumn colDoResultado = dataGridViewResultadoPlano.Columns[colDoGrid];
                        string identPlanoWord = "<p" + (linhaPlano + 1) + "l" + linhaModulo + "c" + colDoResultado.Index + ">";
                        string valorCelula = linhaDoResultado.Cells[colDoResultado.Index].Value.ToString();
                        if (valorCelula == "R$ 0,00")
                            valorCelula = "R$ --";
                        SearchReplace(WordApplication, identPlanoWord, valorCelula.ToString());
                    }
                }
            }

            //aplicar valores da implantação e treinamento
            for (int linhaDoGridImplantacao = 0; linhaDoGridImplantacao < dataGridViewResultadoImplantacao.Rows.Count; linhaDoGridImplantacao++)
            {
                DataGridViewRow linhaDoGrid = dataGridViewResultadoImplantacao.Rows[linhaDoGridImplantacao];

                //valor da implantaação
                string identImplantacaoWord = "<itv" + (linhaDoGridImplantacao + 1) + ">";
                string valorImplantacao = linhaDoGrid.Cells[1].Value.ToString();
                if (valorImplantacao == "R$ 0,00")
                    valorImplantacao = "R$ --";
                SearchReplace(WordApplication, identImplantacaoWord, valorImplantacao.ToString());

                //indicador se módulo está ou não incluso
                if(linhaDoGrid.Cells[2].Value != null)
                {
                    string identInclusaoWord = "<iti" + (linhaDoGridImplantacao + 1) + ">";
                    string valorInclusao = linhaDoGrid.Cells[2].Value.ToString();
                    SearchReplace(WordApplication, identInclusaoWord, valorInclusao);
                }
            }

            //salva as alterações
            saveFileDialogProposta.Title = "Salvar proposta alterada como";
            saveFileDialogProposta.Filter = "Word |*" + Regex.Match(caminhoArquivoWord, @"\.doc[x]*");
            var dialogResult = saveFileDialogProposta.ShowDialog();
            if (dialogResult == DialogResult.OK)
                doc.SaveAs2(saveFileDialogProposta.FileName);

            //fecha a aplicação word
            WordApplication.Documents.Close(doNotSaveChanges, missing, false);
            WordApplication.Quit();
        }

        private void SearchReplace(Microsoft.Office.Interop.Word.Application WordApplication, string findWord, string replaceWord)
        {
            Microsoft.Office.Interop.Word.Find findObject = WordApplication.Selection.Find;
            findObject.ClearFormatting();
            findObject.Text = findWord;
            findObject.Replacement.ClearFormatting();
            findObject.Replacement.Text = replaceWord;

            object replaceAll = WdReplace.wdReplaceAll;
            object missing = Type.Missing;
            findObject.Execute(ref missing, ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing, ref missing,
                ref replaceAll, ref missing, ref missing, ref missing, ref missing);
        }

        private void buttonSalvarParametros_Click(object sender, EventArgs e)
        {
            SalvarParametros();
        }

        private void buttonCarregarParametros_Click(object sender, EventArgs e)
        {
            CarregarParametros();
        }

        private void CarregarParametros()
        {
            openFileDialogParametros.Title = "Carregar arquivo de parâmetros da proposta";
            openFileDialogParametros.FileName = "";
            openFileDialogParametros.Filter = "Parâmetros da Propostas|*.json";
            DialogResult dialogResult = openFileDialogParametros.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                string linhaJson = System.IO.File.ReadAllText(openFileDialogParametros.FileName);
                parametrosProposta = JsonConvert.DeserializeObject<Parametros>(linhaJson);

                CarregarParametrosNaInterface();
            }
            this.Activate();
        }

        private void SalvarParametros()
        {
            saveFileDialogParametros.Title = "Salvar arquivo de parâmetros da proposta";
            openFileDialogParametros.FileName = "ParametrosPropostaSivi";
            saveFileDialogParametros.Filter = "Parâmetros da Propostas|*.json";
            saveFileDialogParametros.DefaultExt = "json";
            saveFileDialogParametros.AddExtension = true;
            DialogResult dialogResult = saveFileDialogParametros.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                AtualizarParametrosDaInterfaceParaMemoria();
                string parametros = JsonConvert.SerializeObject(parametrosProposta);
                System.IO.File.WriteAllText(saveFileDialogParametros.FileName, parametros);
            }
        }

        private void AtualizarParametrosDaInterfaceParaMemoria()
        {
            parametrosProposta.ValorBaseModuloPlano = Single.Parse(textBoxValorBasedoModuloPlano.Text);
            parametrosProposta.ValorBaseModuloImplantacao = Single.Parse(textBoxValorBasedoModuloImplantacao.Text);
            parametrosProposta.PorcetagemDescontoImplantacao = Single.Parse(textBoxPorcetagemDescontoImplantacao.Text);

            List<QuantEmpreendimentos> listaDeQuantEmpreendimentos = new List<QuantEmpreendimentos>();
            foreach(DataGridViewRow linha in dataGridViewPesoQuantEmpreendimento.Rows)
            {
                int quantidade = Int32.Parse(linha.Cells[0].Value.ToString());
                float peso = Single.Parse(linha.Cells[1].Value.ToString());
                listaDeQuantEmpreendimentos.Add(new QuantEmpreendimentos { Quantidade = quantidade, Peso = peso});
            }
            parametrosProposta.listaDeQuantEmpreendimentos = listaDeQuantEmpreendimentos;

            List<PlanoAtendimento> listaDePlanosAtendimento = new List<PlanoAtendimento>();
            foreach (DataGridViewRow linha in dataGridViewPesoPlano.Rows)
            {
                string nome = linha.Cells[0].Value.ToString();
                float peso = Single.Parse(linha.Cells[1].Value.ToString());
                listaDePlanosAtendimento.Add(new PlanoAtendimento { Nome = nome, Peso = peso });
            }
            parametrosProposta.listaDePlanosAtendimento = listaDePlanosAtendimento;

            List<Modulo> listaDeModulos = new List<Modulo>();
            foreach (DataGridViewRow linha in dataGridViewPesoModulo.Rows)
            {
                string nome = linha.Cells[0].Value.ToString();
                float pesoMensalidade = Single.Parse(linha.Cells[1].Value.ToString());
                float pesoImplantacao = Single.Parse(linha.Cells[2].Value.ToString());
                bool incluso = Boolean.Parse(linha.Cells[3].Value.ToString());
                listaDeModulos.Add(new Modulo { Nome = nome, PesoMensalidade = pesoMensalidade, PesoImplantacao = pesoImplantacao, Incluso = incluso });
            }
            parametrosProposta.listaDeModulos = listaDeModulos;
        }
    }
}
