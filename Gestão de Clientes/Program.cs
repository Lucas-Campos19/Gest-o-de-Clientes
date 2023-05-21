// See https://aka.ms/new-console-template for more information
using Gestão_de_Clientes;
using Gestão_de_Funcionarios;
using System.ComponentModel;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

Console.WriteLine("Cadastro de funcionários");
Console.WriteLine("-----------------------------------------------------------------------------------");
var lista = new List<Funcionario>();
var cont = 0;
double media = 0;
for (int i = 1; i <= 2; i++)
{
    var funcionario = new Funcionario();
    Console.WriteLine("Escolha do 1 ao 5 o setor da empresa em que o funcionário trabalha: ");
    var recebeValor = Console.ReadLine();
    var intValor = int.Parse(recebeValor);
    var funcao = (int)(Setor)intValor;
    funcionario.setorFuncao = (Setor)funcao;

    Console.Write("Digite o nome do funcionário: ");
    funcionario.Nome = Console.ReadLine();

    Console.Write("Digite o cpf do funcionário: ");
    funcionario.Cpf = Console.ReadLine();

    Console.Write("Digite o sexo do funcionário: ");
    funcionario.Sexo = Console.ReadLine();

    Console.Write("Digite o salario do funcionário: ");
    funcionario.Salario = decimal.Parse(Console.ReadLine());

    Console.WriteLine();

    lista.Add(funcionario);
}
Console.WriteLine("Digite o código do setor para fazer a consulta dos funcionários");
int codigoSetor = int.Parse(Console.ReadLine()); 

 foreach (var funcionario in lista)
 {
      if((int)funcionario.setorFuncao == codigoSetor)
      {
        Console.WriteLine($"Nome: {funcionario.Nome}\nCPF: {funcionario.Cpf}\nSexo: {funcionario.Sexo}\nSalario: {funcionario.Salario}");
        Console.WriteLine("-----------------------------------------------------------------------------------");
        Console.WriteLine($"Total funcionários de MKT: {lista.Where(f => f.setorFuncao == Setor.Marketing).Count()}");
      }
 }
var mediaPorSetor = lista.GroupBy(f => f.setorFuncao).Select(m => new { Setor = m.Key, MediaSalario = m.Average(f => (double)f.Salario) });
foreach(var item in mediaPorSetor)
{
    Console.WriteLine($"Setor: {item.Setor}");
    Console.WriteLine($"Média Salarial: {item.MediaSalario}");
    Console.WriteLine("-------------------------------------------------------------------------------");
}
Console.WriteLine($"Total funcionários do setor MKT: {lista.Where(f => f.setorFuncao == Setor.Marketing).Count()}");
Console.WriteLine($"Total funcionários do setor TI: {lista.Where(f => f.setorFuncao == Setor.Ti).Count()}");
Console.WriteLine($"Total funcionários do setor FINANCEIRO: {lista.Where(f => f.setorFuncao == Setor.Financeiro).Count()}");
Console.WriteLine($"Total funcionários do setor ADIMINISTRATIVO: {lista.Where(f => f.setorFuncao == Setor.Administrativo).Count()}");
Console.WriteLine($"Total funcionários do setor COMERCIAL: {lista.Where(f => f.setorFuncao == Setor.Comercial).Count()}");
Console.ReadKey();