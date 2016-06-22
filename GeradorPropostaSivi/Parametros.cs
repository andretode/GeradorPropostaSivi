using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorPropostaSivi
{
    class Parametros
    {
        public float ValorBaseModuloPlano { get; set; }
        public float ValorBaseModuloImplantacao { get; set; }
        public float PorcetagemDescontoImplantacao { get; set; }

        public List<QuantEmpreendimentos> listaDeQuantEmpreendimentos { get; set; }
        public List<PlanoAtendimento> listaDePlanosAtendimento { get; set; }
        public List<Modulo> listaDeModulos { get; set; }

        public static void CriarJsonComParametrosDoSistema()
        {
            List<string> linhasJson = new List<string>();

            Parametros parametros = new Parametros();
            parametros.ValorBaseModuloPlano = 180.0f;
            parametros.ValorBaseModuloImplantacao = 699.0f;
            parametros.PorcetagemDescontoImplantacao = 10.0f;

            List<QuantEmpreendimentos> listaDeQuantEmpreendimentos = new List<QuantEmpreendimentos>();
            listaDeQuantEmpreendimentos.Add(new QuantEmpreendimentos { Quantidade = 2, Peso = 1.0f });
            listaDeQuantEmpreendimentos.Add(new QuantEmpreendimentos { Quantidade = 5, Peso = 1.4f });
            listaDeQuantEmpreendimentos.Add(new QuantEmpreendimentos { Quantidade = 10, Peso = 1.8f });
            listaDeQuantEmpreendimentos.Add(new QuantEmpreendimentos { Quantidade = 15, Peso = 2.2f });
            parametros.listaDeQuantEmpreendimentos = listaDeQuantEmpreendimentos;

            List<PlanoAtendimento> listaDePlanosAtendimento = new List<PlanoAtendimento>();
            listaDePlanosAtendimento.Add(new PlanoAtendimento { Nome = "VIP", Peso = 1.00f });
            listaDePlanosAtendimento.Add(new PlanoAtendimento { Nome = "Essencial", Peso = 0.75f });
            listaDePlanosAtendimento.Add(new PlanoAtendimento { Nome = "Econômico", Peso = 0.60f });
            parametros.listaDePlanosAtendimento = listaDePlanosAtendimento;

            List<Modulo> listaDeModulos = new List<Modulo>();
            listaDeModulos.Add(new Modulo() { Nome = "Adm, Fin., Com. e Rel.", PesoMensalidade = 4.00f, PesoImplantacao = 12.00f, Incluso = true });
            listaDeModulos.Add(new Modulo() { Nome = "Compras", PesoMensalidade = 1.00f, PesoImplantacao = 2.00f, Incluso = false });
            listaDeModulos.Add(new Modulo() { Nome = "Contábil", PesoMensalidade = 1.00f, PesoImplantacao = 3.00f, Incluso = false });
            listaDeModulos.Add(new Modulo() { Nome = "Mapas", PesoMensalidade = 0.70f, PesoImplantacao = 1.00f, Incluso = false });
            listaDeModulos.Add(new Modulo() { Nome = "Cobrança", PesoMensalidade = 0.70f, PesoImplantacao = 2.00f, Incluso = false });
            listaDeModulos.Add(new Modulo() { Nome = "Geração 2° via boleto", PesoMensalidade = 0.50f, PesoImplantacao = 0.00f, Incluso = false });
            parametros.listaDeModulos = listaDeModulos;

            linhasJson.Add(JsonConvert.SerializeObject(parametros));

            System.IO.File.AppendAllLines("GeradorPropostaSivi2.config.json", linhasJson);
        }
    }
}
