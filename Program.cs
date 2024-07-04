Empresa empresa = new Empresa();

bool menu = true;
while (menu)
{
    Console.WriteLine("Olá! Seja bem-vindo ao sistema de Gestão de Empresas. O que deseja fazer");
    Console.WriteLine("1 - Adicionar Funcionário de Tempo Integral\n2 - Adicionar Funcionário de Meio período\n3 - Remover um funcionário\n4 - Exibir informações dos funcionários\n5 - Adicionar um projeto a um funcionário\n0 - Sair do Programa");
    Console.Write("Opção aqui: ");
    int opcao = Convert.ToInt32(Console.ReadLine());

    switch (opcao)
    {
        case 1: 
            Console.WriteLine("Certo, qual o nome do funcionário?");
            string nome = Console.ReadLine();
            Console.WriteLine("Número da matrícula:");
            int matricula = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Salário mensal:");
            double salario = Convert.ToDouble(Console.ReadLine());
            Funcionarios mensal = new FuncionarioTempoIntegral(nome, matricula, salario);
            empresa.AdicionarFuncionario(mensal);
            Console.WriteLine("------------------------------------------");
            break;
        case 2:
            Console.WriteLine("Certo, qual o nome do funcionário?");
            string nomeMeioPeriodo = Console.ReadLine();
            Console.WriteLine("Número da matrícula:");
            int matriculaMeioPeriodo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Salário por hora:");
            double salarioPorHora = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Quantidade de horas trabalhadas");
            double horasTrabalhadas = Convert.ToDouble(Console.ReadLine());
            Funcionarios meioPeriodo = new FuncionarioMeioPeriodo(nomeMeioPeriodo, matriculaMeioPeriodo, salarioPorHora, horasTrabalhadas);
            empresa.AdicionarFuncionario(meioPeriodo);
            Console.WriteLine("------------------------------------------");
            break;
        case 3:
            Console.WriteLine("Digite o número de matrícula do funcionario:");
            int matriculaRemocao = Convert.ToInt32(Console.ReadLine());
            empresa.RemoverFuncionario(matriculaRemocao);
            Console.WriteLine("------------------------------------------");
            break;
        case 4:
            empresa.ExibirFuncionarios();
            Console.WriteLine("------------------------------------------");
            break;
        case 5:
            Console.WriteLine("Digite o nome do projeto:");
            string projeto = Console.ReadLine();
            Funcionarios.AdicionarProjeto(projeto);
            break;
        case 0:
            menu = false;
            break;
    }
}
