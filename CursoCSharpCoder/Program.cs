using CursoCSharpCoder;
using CursoCSharpCoder.ClassesEMetodos;
using CursoCSharpCoder.Colecoes;
using CursoCSharpCoder.EstruturasDeControle;
using CursoCSharpCoder.Fundamentos;
using CursoCSharpCoder.OO;
using CursoCSharpCoder.MetodosEFuncoes;
using CursoCSharpCoder.Excecoes;
using CursoCSharpCoder.Api;
using CursoCSharpCoder.TopicosAvancados;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Váriaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Número - Fundamentos", FormatandoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritméticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operador Ternário - Fundamentos", OperadorTernario.Executar},
                // Estruturas de Controle
                {"Estrutura If - Estruturas de Controle", EstruturaIf.Executar},
                {"Estrutura If/Else - Estruturas de Controle", EstruturaIfElse.Executar},
                {"Estrutura If/Else If - Estruturas de Controle", EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Estruturas de Controle", EstruturaSwitch.Executar},
                {"Estrutura While - Estruturas de Controle", EstruturaWhile.Executar},
                {"Estrutura Do While - Estruturas de Controle", EstruturaDoWhile.Executar},
                {"Estrutura For - Estruturas de Controle", EstruturaFor.Executar},
                {"Estrutura Foreach - Estruturas de Controle", EstruturaForEach.Executar},
                {"Usando Break - Estruturas de Controle", UsandoBreak.Executar},
                {"Usando Continue - Estruturas de Controle", UsandoContinue.Executar},
                // Classes e Métodos
                {"Membros - Classes e Metodos", Membros.Executar},
                {"Construtores - Classes e Metodos", Construtores.Executar},
                {"Métodos com Retorno - Classes e Metodos", MetodosComRetorno.Executar},
                {"Métodos Estáticos - Classes e Metodos", MetodosEstaticos.Executar},
                {"Atributos Estáticos - Classes e Metodos", AtributosEstaticos.Executar},
                {"Desafio Atributo - Classes e Metodos", DesafioAtributo.Executar},
                {"Parametros Variáveis - Classes e Metodos", Params.Executar},
                {"Parametros Nomeados - Classes e Metodos", ParametrosNomeados.Executar},
                {"Getters e Setters - Classes e Metodos", GetSet.Executar},
                {"Propriedades - Classes e Metodos", Props.Executar},
                {"Readonly - Classes e Metodos", Readonly.Executar},
                {"Enum - Classes e Metodos", ExemploEnum.Executar},
                {"Struct - Classes e Metodos", Struct.Executar},
                {"Struct Vs Classe - Classes e Metodos", StructVsClasse.Executar},
                {"Valor Vs Referência - Classes e Metodos", ValorVsReferencia.Executar},
                {"Parametros por Referência - Classes e Metodos", ParamentrosPorReferencia.Executar},
                {"Parametros por valor Padrão - Classes e Metodos", ParametroPadrao.Executar},
                // Coleções
                {"Array - Coleções", CursoCSharpCoder.Colecoes.Array.Executar},
                {"List - Coleções", ColecoesList.Executar},
                {"ArrayList - Coleções", ColecoesArrayList.Executar},
                {"Set - Coleções", ColecoesSet.Executar},
                {"Queue - Coleções", ColecoesQueue.Executar},
                {"Igualdade - Coleções", Igualdade.Executar},
                {"Stack - Coleções", ColecoesStack.Executar},
                {"Dictionary - Coleções", ColecoesDictionary.Executar},
                // OO
                {"Herança - OO", Heranca.Executar},
                {"Construtor This - OO", ConstrutorThis.Executar},
                {"Encapsulamento - OO", CursoCSharpCoder.OO.Encapsulamento.Executar},
                {"Polimorfismo - OO", Polimorfismo.Executar},
                {"Abstract - OO", Abstract.Executar},
                {"Interface - OO", Interface.Executar},
                {"Sealed - OO", Sealed.Executar},
                // Métodos e Funções
                {"Exemplo Lambda - Métodos e Funções", ExemploLambda.Executar},
                {"Lambdas Com Delegates - Métodos e Funções", LambdasDelegate.Executar},
                {"Usando Delegate - Métodos e Funções", UsandoDelegate.Executar},
                {"Delegate com Função Anonima - Métodos e Funções", DelegateFuncAnonima.Executar},
                {"Delegate como Parametro - Métodos e Funções", DelegatesComoParametros.Executar},
                {"Métodos de Extensão - Métodos e Funções", MetodosDeExtensao.Executar},
                // Exceções
                {"Exceções - Primeira Exceção", PrimeiraExcecao.Executar},
                {"Exceções - Exceções Personalizadas", ExcecoesPersonalizadas.Executar},
                // Api
                {"Primeiro Arquivo - Usando API", PrimeiroArquivo.Executar},
                {"Lendo Arquivos - Usando API", LendoArquivos.Executar},
                {"Exemplo FileInfo - Usando API", ExemploFileInfo.Executar},
                {"Diretórios - Usando API", Diretorios.Executar},
                {"Exemplo DirectoryInfo - Usando API", ExemploDirectoryInfo.Executar},
                {"Exemplo Path - Usando API", ExemploPath.Executar},
                {"Exemplo DateTime - Usando API", ExemploDateTime.Executar},
                {"Exemplo TimeSpan - Usando API", ExemploTimeSpan.Executar},
                // Tópicos avançados
                {"LINQ1 - Tópicos Avançados", LINQ1.Executar},
                {"LINQ2 - Tópicos Avançados", LINQ2.Executar},
                {"Nullables - Tópicos Avançados", Nullables.Executar},
                {"Dynamics - Tópicos Avançados", Dynamics.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}
