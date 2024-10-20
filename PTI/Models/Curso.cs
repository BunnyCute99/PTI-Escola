public class Curso
{
    public string nome{ get; set; }
    public double valor{ get; set; }
    public int duracao{ get; set; }

    public Curso(){

    }

    public Curso(string nome, double valor, int duracao){
        this.nome = nome;
        this.valor = valor;
        this.duracao = duracao;
    }
}