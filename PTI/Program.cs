// programa
MenuPrincipal();

// Métodos

// Menu Principal

static void MenuPrincipal(){
    bool continua = true;
    System.Console.WriteLine();
    while (continua){
        Menu();
        int op = InteiroEntrada();
        switch (op)
        {
            case 1:
                MenuRegistro();
            break;
            case 2:
                MenuListar();
            break;
            case 3:
                MenuAdcionarCursos();
            break;
            case 0:
                continua=false;
            break;
        }
    }
}


static void Menu(){
    System.Console.WriteLine("Digite qual sua opção");
    System.Console.WriteLine("[1] - Registar Entidade");
    System.Console.WriteLine("[2] - Listar Entidades");
    System.Console.WriteLine("[3] - Adicionar Cursos a Entidades");
    System.Console.WriteLine("[0] - Sair do Programa");
    System.Console.WriteLine("");
}

// Resgistrar entidades

static void MenuRegistro(){
    bool continua2 = true;
    while(continua2){
        MenuRegistroTexto();
        int op2 = InteiroEntrada();
        switch(op2){
            case 1:
                RegistrarPessoaFisica();
            break;
            
            case 2:
                RegistrarAluno();
            break;
            
            case 3:
                MenuRegistarProfessor();
            break;
            
            case 4:
                RegistrarPessoaJuridica();
            break;
            
            case 5:
                RegistrarFornecedor();
            break;
            
            case 0:
                continua2=false;
            break;

        }
        
    }
}

static void MenuRegistroTexto(){
    System.Console.WriteLine("Digite Qual Entidade Você quer Registrar ?");
    System.Console.WriteLine("[1] - Pessoa Física");
    System.Console.WriteLine("[2] - Aluno");
    System.Console.WriteLine("[3] - Professor");
    System.Console.WriteLine("[4] - Pessoa Jurídica");
    System.Console.WriteLine("[5] - Fornecedor");
    System.Console.WriteLine("[0] - Sair");
    System.Console.WriteLine("");
}

static void RegistrarPessoaFisica(){
    PessoaFisica pf = new PessoaFisica();
    System.Console.WriteLine("Digite o Nome da Pessoa");
    pf.nome = TextoEntrada();
    System.Console.WriteLine("Digite a Idade da Pessoa");
    pf.idade = InteiroEntrada();
    System.Console.WriteLine("Digite o CPF da Pessoa");
    pf.cpf = TextoEntrada();
    System.Console.WriteLine("");
    System.Console.WriteLine("Pronto");
    System.Console.WriteLine("");
    Listas.pessoaFisicas.Add(pf);
}

static void RegistrarAluno(){
    Aluno a = new Aluno();
    System.Console.WriteLine("Digite o nome do Aluno");
    a.nome = TextoEntrada();
    System.Console.WriteLine("Digite a idade do Aluno");
    a.idade = InteiroEntrada();
    System.Console.WriteLine("Digite o CPF do Aluno");    
    a.cpf = TextoEntrada();
    System.Console.WriteLine("Digite a Matricula do Aluno");
    a.matricula = InteiroEntrada();
    System.Console.WriteLine("Digite o nome da escola do Aluno");
    a.escola = TextoEntrada();
    System.Console.WriteLine("Digite o período em que ele estuda do Aluno");
    a.periodo = TextoEntrada();
    Listas.alunos.Add(a);
}

static void MenuRegistarProfessor(){
    bool continuaProfessor = true;
    while(continuaProfessor){
        MenuRegistarProfessorTexto();
        int opprof = InteiroEntrada();
        switch(opprof){
            case 1:
                RegistrarProfessorPF();
            break;
            case 2:
                RegistrarProfessorPJ();
            break;
            case 0:
                continuaProfessor=false;
            break;
        }
    }
}

static void MenuRegistarProfessorTexto(){
    System.Console.WriteLine("Qual o tipo de Professor Registrar");
    System.Console.WriteLine("[1] Pessoa Física");
    System.Console.WriteLine("[2] Pessoa Jurídica");
    System.Console.WriteLine("[0] Sair");
}

static void RegistrarProfessorPF(){
    ProfesorPF profesorPF= new ProfesorPF();
    System.Console.WriteLine("Digite o Nome do Professor");
    profesorPF.nome = TextoEntrada();
    System.Console.WriteLine("Digite a Idade do Professor");
    profesorPF.idade = InteiroEntrada();
    System.Console.WriteLine("Digite o CPF do Professor");
    profesorPF.cpf = TextoEntrada();
    System.Console.WriteLine("Digite o número da Matrícula");
    profesorPF.matricula = InteiroEntrada();
    System.Console.WriteLine("Digite o Salário do Professor");
    profesorPF.salario = DoubleEntrada();
    System.Console.WriteLine("Digite a Ocupação do Professor");
    profesorPF.ocupacao = TextoEntrada();
    Listas.profesorPFs.Add(profesorPF);
}

static void RegistrarProfessorPJ(){
    ProfessorPJ professorPJ= new ProfessorPJ();
    System.Console.WriteLine("Digite o Nome do Professor");
    professorPJ.nome = TextoEntrada();
    System.Console.WriteLine("Digite a Função do Professor");
    professorPJ.funcao = TextoEntrada();
    System.Console.WriteLine("Digite o CNPJ do Professor");
    professorPJ.cnpj = TextoEntrada();
    System.Console.WriteLine("Digite o número da Matrícula");
    professorPJ.matricula = InteiroEntrada();
    System.Console.WriteLine("Digite o Salário do Professor");
    professorPJ.salario = DoubleEntrada();
    Listas.professorPJs.Add(professorPJ);
}




static void RegistrarPessoaJuridica(){
    PessoaJuridica pj = new PessoaJuridica();
    System.Console.WriteLine("Digite o Nome da Entidade");
    pj.nome = TextoEntrada();
    System.Console.WriteLine("Digite a Funçao da Entidade");
    pj.funcao = TextoEntrada();
    System.Console.WriteLine("Digite o CNPJ da Entidade");
    pj.cnpj = TextoEntrada();
    Listas.pessoaJuridicas.Add(pj);
}

static void RegistrarFornecedor(){
    Fornecedor f = new Fornecedor();
    System.Console.WriteLine("Digite o Nome do Fornecedor");
    f.nome = TextoEntrada();
    System.Console.WriteLine("Digite a Funçao do Fornecedor");
    f.funcao = TextoEntrada();
    System.Console.WriteLine("Digite o CNPJ do Fornecedor");
    f.cnpj = TextoEntrada();
    System.Console.WriteLine("Digite os Produtos do Fornecedor");
    f.produtos = TextoEntrada();
    System.Console.WriteLine("Digite o Saldo do Fornecedor");
    f.saldo = DoubleEntrada();
    Listas.fornecedores.Add(f);
}

// Listar

static void MenuListar(){
    bool continua3 = true;
    while(continua3){
        MenuListarTexto();
        int op3 = InteiroEntrada();
        switch(op3){
            case 1:
                ListarPF();
            break;
            case 2:
                ListarAluno();
            break;
            case 3:
                ListarProfessor();
            break;
            case 4:
                ListarProfessorPJ();
            break;
            case 5:
                ListarPJ();
            break;
            case 6:
                ListarFornecedor();
            break;

            case 0:
                continua3=false;
            break;
        }
    }

}

static void MenuListarTexto(){
    System.Console.WriteLine("Digite Qual Entidade Você quer Listar ?");
    System.Console.WriteLine("[1] - Pessoa Física");
    System.Console.WriteLine("[2] - Aluno");
    System.Console.WriteLine("[3] - Professor");
    System.Console.WriteLine("[4] - Professor PJ");
    System.Console.WriteLine("[5] - Pessoa Jurídica");
    System.Console.WriteLine("[6] - Fornecedor");
    System.Console.WriteLine("[0] - Sair");
}

static void ListarPF(){
    System.Console.WriteLine("LISTA DE PESSOAS FÍSICAS \n");
    foreach(PessoaFisica pf in Listas.pessoaFisicas){
        System.Console.WriteLine($"****************************");
        System.Console.WriteLine($"ID: {pf.id}");
        System.Console.WriteLine($"Nome: {pf.nome}");
        System.Console.WriteLine($"Idade: {pf.idade}");
        System.Console.WriteLine($"CPF: {pf.cpf}");
        System.Console.WriteLine($"****************************");
    }
}

static void ListarAluno(){
    System.Console.WriteLine("LISTA DE ALUNOS \n");
    foreach(Aluno a in Listas.alunos){
        System.Console.WriteLine($"****************************");
        System.Console.WriteLine($"ID: {a.id}");
        System.Console.WriteLine($"Nome: {a.nome}");
        System.Console.WriteLine($"Idade: {a.idade}");
        System.Console.WriteLine($"CPF: {a.cpf}");
        System.Console.WriteLine($"Matricula: {a.matricula}");
        System.Console.WriteLine($"Escola: {a.escola}");
        System.Console.WriteLine($"Período: {a.periodo}");
        System.Console.WriteLine($"Cursos:");
        try
        {
            foreach (Curso c in a.GetCursos())
            {
                System.Console.WriteLine($"{c.nome}: {c.duracao} Horas, {c.valor} R$");
            }
            
        }
        catch (System.Exception)
        {
            
        }

        System.Console.WriteLine($"****************************");
    }
}

static void ListarProfessor(){
    System.Console.WriteLine("LISTA DE PROFESSORES \n");
    foreach(ProfesorPF p in Listas.profesorPFs){
        System.Console.WriteLine($"****************************");
        System.Console.WriteLine($"ID: {p.id}");
        System.Console.WriteLine($"Nome: {p.nome}");
        System.Console.WriteLine($"Idade: {p.idade}");
        System.Console.WriteLine($"CPF: {p.cpf}");
        System.Console.WriteLine($"Matricula: {p.matricula}");
        System.Console.WriteLine($"Salário: {p.salario}");
        System.Console.WriteLine($"Ocupação: {p.ocupacao}");
        System.Console.WriteLine($"Cursos:");
        try
        {
            foreach (Curso c in p.GetCursos())
            {
                System.Console.WriteLine($"{c.nome}: {c.duracao} Horas");
            }
            
        }
        catch (System.Exception)
        {
            
        }
        System.Console.WriteLine($"****************************");
    }
}

static void ListarProfessorPJ(){
    System.Console.WriteLine("LISTA DE PROFESSORES PJ \n");
    foreach(ProfessorPJ p in Listas.professorPJs){
        System.Console.WriteLine($"****************************");
        System.Console.WriteLine($"ID: {p.id}");
        System.Console.WriteLine($"Nome: {p.nome}");
        System.Console.WriteLine($"Função: {p.funcao}");
        System.Console.WriteLine($"CNPJ: {p.cnpj}");
        System.Console.WriteLine($"Matricula: {p.matricula}");
        System.Console.WriteLine($"Salário: {p.salario}");
        try
        {
            foreach (Curso c in p.GetCursos())
            {
                System.Console.WriteLine($"{c.nome}: {c.duracao} Horas");
            }
            
        }
        catch (System.Exception)
        {
            
        }
        System.Console.WriteLine($"****************************");
    }
}

static void ListarPJ(){
    System.Console.WriteLine("LISTA DE PESSOAS JURÍDICAS \n");
    foreach (PessoaJuridica pj in Listas.pessoaJuridicas)
    {
        System.Console.WriteLine("*****************************");
        System.Console.WriteLine($"ID {pj.id}");
        System.Console.WriteLine($"Nome {pj.nome}");
        System.Console.WriteLine($"Função {pj.funcao}");
        System.Console.WriteLine($"CNPJ {pj.cnpj}");
        System.Console.WriteLine("*****************************");
    }
}

static void ListarFornecedor(){
    System.Console.WriteLine("LISTA DE FORNECEDORES \n");
    foreach (Fornecedor f in Listas.fornecedores){
        System.Console.WriteLine("*****************************");
        System.Console.WriteLine($"ID {f.id}");
        System.Console.WriteLine($"Nome {f.nome}");
        System.Console.WriteLine($"Função {f.funcao}");
        System.Console.WriteLine($"CNPJ {f.cnpj}");
        System.Console.WriteLine($"Produto {f.produtos}");
        System.Console.WriteLine($"Saldo {f.saldo}");
        System.Console.WriteLine("*****************************");
    }
}

// Adicionar Cursos

static void MenuAdcionarCursos(){
    bool continuarAdcionar = true;
    while (continuarAdcionar)
    {
        MenuAdcionarCursosTexto();
        int op = InteiroEntrada();
        
        switch (op){
            case 1:
                SelecionarAluno();
            break;
            case 2:
                SelecionarProfessprPF();
            break;
            case 3:
                SelecionarProfessprPJ();
            break;
            case 0:
                continuarAdcionar = false;
            break;
        }
    }
}

static void MenuAdcionarCursosTexto(){
    System.Console.WriteLine("Digite de Quem você quer Adcionar Cursos ?");
    System.Console.WriteLine("[1] - Aluno");
    System.Console.WriteLine("[2] - Professor");
    System.Console.WriteLine("[3] - Professor PJ");
    System.Console.WriteLine("[0] - Sair");
}

static void SelecionarAluno(){
    ListarAluno();
    System.Console.WriteLine("Digite o id do Aluno que Você quer Adicionar o Curso");
    int op = InteiroEntrada();
    if (op >= Listas.alunos.Count || op < 0){return;}
    System.Console.WriteLine(op);
    AdcionarCursoAluno(op);
}

static void AdcionarCursoAluno(int op){
    Curso c = new Curso();
    System.Console.WriteLine("Digite nome do Curso");
    c.nome = TextoEntrada();
    System.Console.WriteLine("Digite o Valor do Curso");
    c.valor = DoubleEntrada();
    System.Console.WriteLine("Digite a duração em  Horas");
    c.duracao = InteiroEntrada();
    System.Console.WriteLine(op);
    Listas.alunos[op].AdicionarCurso(c);
}

static void SelecionarProfessprPF(){
    ListarProfessor();
    System.Console.WriteLine("Digite o id do Professor que Você quer Adicionar o Curso");
    int op = InteiroEntrada();
    if (op >= Listas.profesorPFs.Count || op < 0){return;}
    System.Console.WriteLine(op);
    AdcionarCursoProfessorPF(op);
}

static void AdcionarCursoProfessorPF(int op){
    Curso c = new Curso();
    System.Console.WriteLine("Digite nome do Curso");
    c.nome = TextoEntrada();
    System.Console.WriteLine("Digite o Valor do Curso");
    c.valor = DoubleEntrada();
    System.Console.WriteLine("Digite a duração em  Horas");
    c.duracao = InteiroEntrada();
    System.Console.WriteLine(op);
    Listas.profesorPFs[op].AdicionarCurso(c);
}

static void SelecionarProfessprPJ(){
    ListarProfessorPJ();
    System.Console.WriteLine("Digite o id do Professor que Você quer Adicionar o Curso");
    int op = InteiroEntrada();
    if (op >= Listas.professorPJs.Count || op < 0){return;}
    System.Console.WriteLine(op);
    AdcionarCursoProfessorPJ(op);
}

static void AdcionarCursoProfessorPJ(int op){
    Curso c = new Curso();
    System.Console.WriteLine("Digite nome do Curso");
    c.nome = TextoEntrada();
    System.Console.WriteLine("Digite o Valor do Curso");
    c.valor = DoubleEntrada();
    System.Console.WriteLine("Digite a duração em  Horas");
    c.duracao = InteiroEntrada();
    System.Console.WriteLine(op);
    Listas.professorPJs[op].AdicionarCurso(c);
}

// métodos de Entrada de Dados

static int InteiroEntrada(){
    int i;
    try
    {
        Console.Write(">> ");
        i = int.Parse(Console.ReadLine());
        System.Console.WriteLine("");
    }
    catch (System.Exception)
    {
        System.Console.WriteLine("Erro !!!, número não é inteiro");
        System.Console.WriteLine("adotar valor igual a 0");
        i = 0;
    }
    
    return i;
}

static string TextoEntrada(){
    string s;
    try
    {
        Console.Write(">> ");
        s = Console.ReadLine();
        System.Console.WriteLine("");
    }
    catch (System.Exception)
    {
        System.Console.WriteLine("Erro !!!");
        System.Console.WriteLine("adotar valor igual a vazio");
        s = "";
    }
    
    return s;
}

static Double DoubleEntrada(){
    double d;
    try
    {
        Console.Write(">> ");
        d = double.Parse(Console.ReadLine());
        d=Math.Round(d,2);
        System.Console.WriteLine("");
    }
    catch (System.Exception)
    {
        System.Console.WriteLine("Erro !!!");
        System.Console.WriteLine("adotar valor igual a vazio");
        d = 0.0;
    }
    return d;
}

