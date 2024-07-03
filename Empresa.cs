public class Empresa 
{
    List<Funcionarios> funcionarios = new List<Funcionarios>();

    public void AdicionarFuncionario(Funcionarios funcionario)
    {
        funcionarios.Add(funcionario);
        Console.WriteLine("Funcionario adicionado com sucesso!");
    }
    public void RemoverFuncionario(int matricula)
    {
        foreach (Funcionarios funcionario in funcionarios)
        {
            if (matricula == funcionario.Matricula)
            {
                funcionarios.Remove(funcionario);
                Console.WriteLine("Removido com sucesso!");
            }
        }
    }
    public void ExibirFuncionarios()
    {
        foreach (Funcionarios funcionario in funcionarios)
        {
            Console.WriteLine($"-------------\nFuncionário {funcionario.Matricula}:\n{funcionario.Nome}\nSalário {funcionario.CalcularSalario():C}");
        }
    }
}