using Projeto_Senai.Model;


ExemploSenaiContext context = new ExemploSenaiContext();

bool logincorreto = false;
bool senhacorreta = false;

while(true)
{
    Console.Clear();
    Console.WriteLine("1 - Login, 2 - Senha, 3 - Sair");
    string num = Console.ReadLine();
    if(num == "1")
    {
        Console.Clear();
        string login = Console.ReadLine();
        foreach(var nome in context.Usuarios)
        {
            if(login == nome.Nome)
            {
                logincorreto = true;
                if(logincorreto == true && senhacorreta == true)
                {
                Console.WriteLine("login efetuado com sucesso!");
                }
            }
        }
    }
    else if(num == "2")
    {
        Console.Clear();
        string senha  = Console.ReadLine();
        foreach(var senha1 in context.Usuarios)
        {
            if(senha1.Senha == senha)
            {
                senhacorreta = true;
            }
            if(logincorreto == true && senhacorreta == true)
            {
                Console.WriteLine("login efetuado com sucesso!");
            }
        }
    }
    else if (num == "3")
    {
        break;
    }
    else
    {

    }
    
}
if(logincorreto == true && senhacorreta == true)
{
    Console.WriteLine("login efetuado com sucesso!");
}