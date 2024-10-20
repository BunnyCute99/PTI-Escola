public class PessoaFisica{

    static int elements = 0;
    public int id {get; set;}
    public string nome {get; set;}
    public int idade {get; set;}
    public string cpf {get; set;}

    public PessoaFisica(){
        this.id = elements;
        elements++;
    }

    public PessoaFisica(string nome, int idade, string cpf) {
        this.id = elements;
        this.nome = nome;
        this.idade = idade;
        this.cpf = cpf;
        elements++;
    }
}