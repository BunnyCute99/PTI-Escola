public class PessoaJuridica{

    static int elements = 0;
    public int id {get; set;}
    public string nome {get; set;}
    public string funcao {get; set;}
    public string cnpj {get; set;}

    public PessoaJuridica(){
        this.id = elements;
        elements++;
    }

    public PessoaJuridica(string nome, string funcao, string cnpj) {
        this.id = elements;
        this.nome = nome;
        this.funcao = funcao;
        this.cnpj = cnpj;
        elements++;
    }
}