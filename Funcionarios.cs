
public abstract class Funcionarios
{
    public Funcionarios(string nome, int matricula)
    {
        this.Nome = nome;
        this.Matricula = matricula;
    }

    public string Nome;
    public int Matricula;

    public abstract double CalcularSalario();
    public abstract void ExibirInformacoes();

    public string AdicionarProjeto(string projeto)
    {
        List<string> projetos = new List<string>();
        projetos.Add(projeto);
        return "Adicionado com sucesso";
    }
    public string AdicionarProjeto(List<string> projetos)
    {
        List<string> projeto = new List<string>();
        projeto.Add(projetos.ToString());
        return "Adicionado com sucesso!";
    }
}
