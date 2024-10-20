public class Aluno:PessoaFisica{

    static int elements = 0;

    public int matricula { get; set; }
    public string periodo{ get; set; }
    public string escola{ get; set; }
    private List<Curso> cursos = new List<Curso>();

    public Aluno(){
        this.cursos = new List<Curso>();
        this.id = elements;
        elements ++;
    }

    public Aluno(int matricula, string periodo, string escola, string nome, int idade, string cpf){
        this.nome = nome;
        this.idade = idade;
        this.cpf = cpf;
        this.id = elements;
        this.matricula=matricula;
        this.periodo=periodo;
        this.escola=escola;
        elements++;
    }

    public void AdicionarCurso(Curso curso){
        this.cursos.Add(curso);
    }

    public List<Curso> GetCursos(){
        return this.cursos;
    }

    

    
}