public class ProfessorPJ:PessoaJuridica
{
    static int elements = 0;
    public int matricula{get;set;}
    public double salario{get;set;}
    private List<Curso> cursos = new List<Curso>();


    public ProfessorPJ(){
        this.id = elements;
        elements++ ;
    }

    public ProfessorPJ(string nome, string funcao, string cnpj, int matricula, double salario){
        this.nome = nome;
        this.funcao = funcao;
        this.cnpj = cnpj;
        this.matricula = matricula;
        this.salario = salario;
        this.id = elements;
        elements++;
    }
    public void AdicionarCurso(Curso curso){
        this.cursos.Add(curso);
    }

    public List<Curso> GetCursos(){
        return this.cursos;
    }
}