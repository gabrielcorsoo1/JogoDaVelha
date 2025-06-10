using System.Diagnostics;
using Aula03.Models;
using Microsoft.AspNetCore.Mvc;

namespace Aula03.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View("../JogoVelha/Index");
        }


        [HttpGet]
        public string GetIf(int x)
        {
            /*
             
             Estrutura Sintática do IF:

                if(expressão booleana)
                {
                    senteça de código a ser
                    executada caso a condição
                    seja atinjida como verdadeira;
                }
                
             Caso o IF tenha apenas uma linha de comando a ser executada
             na condicional, não há necessidade do uso de chaves{};
                
                if(expressão booleana)
                    apenas um comando;

             */

            // int x = 10;
            string retorno = string.Empty;

            if (x < 9)
            {
                retorno = "x é maior que 9";
            }

            // x = 8;

            if(x > 9)
            {
                retorno = "x é maior que 9";
            }

            else
            {
                retorno = "x é menor que 9";
            }

            // x = 11;
            
            if(x == 10)
            {
                retorno = "ora ora";
                retorno += "x é igual a 10";
            }

            else if(x == 9)
            {
                retorno = "hmmmmmmmm";
                retorno += "x é igual a 9";
            }

            else if(x == 8)
            {
                retorno = "bahhhhhhhh";
                retorno += "x é igual a 8";
            }

            else
            {
                retorno = "sei lá que número é x";
            }

            return retorno;
        }

        [HttpGet]
        public string GetSwitch(int x)
        {
            string retorno = string.Empty;

            switch (x)
            {
                case 0:
                    retorno = "x é zero";
                    break;
                case 1:
                    retorno = "x é um";
                    break;
                case 2:
                    retorno = "x é dois";
                    break;
                case 3:
                    retorno = "x é três";
                    break;
                default:
                    retorno = "x é algum número imprevisto";
                    break;
            }

            return retorno;
        }

        [HttpGet]
        public string GetFor(int x)
        {
            /*
             
                O comando de repetição FOR possui a seguinte sintaxe:
                
                for(<inicializador>; <expressão condicional>; <expressão de repetição>)
                {
                    comandos a serem executados;
                }
                
               * inicializador: elemento contador utilizado o "i";

               * expressão condicional: especifica o teste a ser verificado quando o loop
                estiver executando o número definido de iterações;
  
               * expressão de repetição: especifica a ação a ser executada com a variável
                contadora. Geralmente um acúmulo ou decréscimo;

             */

            string retorno = string.Empty;

            for(int i=1; i<=x; i++)
            {
                //E se eu quisesse interromper o laço caso ele fosse maior que 5
                if(i > 50)
                {
                    break; //Interrompe o laço
                }

                //Caso eu deseje que o laço siga em frente
                //Forçando-o a continuar a execução
                if((i%2) != 0)
                {
                    continue;
                }

                retorno += $"{i}; ";
            }

            return retorno;
        }

        [HttpGet]
        public string GetForEach(string color)
        {
            /*
               O comando Foreach() (para cada)
               é utilizado para iterar por uma
               sequência de itens em uma coleção,
               e servir como uma opção simples de repetição.
            */

            string[] colors = ["Vermelho", "Preto", "Azul", "Amarelo", "Verde", "Branco", "Azul-Marinho", "Rosa", "Roxo", "Cinza"];

            string retorno = string.Empty;

            if (colors.Contains(char.ToUpper(color[0]) + color.Substring(1)))
            {
                retorno = "A cor escolhida é válida";
            }

            else
            {
                retorno = "Cor escolhida Inválida";
            }

            foreach(string s in colors)
            {
                retorno += $" [{s}]";
            }

            return retorno;
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
