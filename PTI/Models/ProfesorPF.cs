public class ProfesorPF:PessoaFisica{

    static int elements = 0;

    public int matricula{get;set;}
    public double salario{get;set;}
    public string ocupacao{get;set;}
    private List<Curso> cursos = new List<Curso>();


    public ProfesorPF(){
        this.id = elements;
        elements++;
    }

    public ProfesorPF(string nome, int idade, string cpf, int matricula, double salario, string ocupacao){
        this.nome = nome;
        this.idade = idade;
        this.cpf = cpf;
        this.matricula = matricula;
        this.salario = salario;
        this.ocupacao = ocupacao;
        this.id = elements;
        elements++ ;
    }

    public void AdicionarCurso(Curso curso){
        this.cursos.Add(curso);
    }

    public List<Curso> GetCursos(){
        return this.cursos;
    }
    
}