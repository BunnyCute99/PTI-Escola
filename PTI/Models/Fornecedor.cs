public class Fornecedor:PessoaJuridica{

    static int elements = 0;

    public string produtos{ get; set; }
    public double saldo{ get; set; }

    public Fornecedor(){
        this.id = elements;
        elements++;
    }

    public Fornecedor(string nome, string funcao, string cnpj, string produtos, double saldo){
        this.id = elements;
        this.nome = nome;
        this.funcao = funcao;
        this.cnpj = cnpj;
        this.produtos = produtos;
        this.saldo = saldo;
        elements++;
    }

    public void AumentarSaldo(double aumento){
        if (aumento > 0)
        {
            this.saldo=saldo+aumento;
            this.saldo=Math.Round(this.saldo,2);

        }

        System.Console.WriteLine("Novo Saldo: "+saldo);
        
    }

    public void SacarSaldo(double saque){
        if (saque > 0 && saque <= this.saldo)
        {
            this.saldo=saldo-saque;
            this.saldo=Math.Round(this.saldo,2);
        }

        System.Console.WriteLine("Novo Saldo: "+saldo);
        
    }
}