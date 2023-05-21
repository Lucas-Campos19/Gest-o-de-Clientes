using Gestão_de_Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestão_de_Funcionarios
{
    public class Funcionario
    {
       public string Nome { get; set; }
       public string Cpf { get; set; }
       public string Sexo { get;set; }  
       public decimal Salario { get; set; } 
       public Setor setorFuncao { get; set; }
    }
}
