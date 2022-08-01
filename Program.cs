using Projeto_Senai.Model;


ExemploSenaiContext context = new ExemploSenaiContext();



while(true)
{
    Console.WriteLine("1 - Login, 2 - Registrar, 3 - Sair");
    string num = Console.ReadLine();
    if(num == "1")
    {
        Console.WriteLine("usuario:");
        string login = Console.ReadLine();
        Console.WriteLine("senha:");
        string senha = Console.ReadLine();
        foreach(var usuario in context.Usuarios)
        {
            if(usuario.Nome == login && usuario.Senha == senha)
            {
                Console.WriteLine("Login efetuado com sucesso");
            }
        }
    }
    else if(num == "2")
    {
        Console.Write("usuario:");
        string usuarioRegistro = Console.ReadLine();
        Console.WriteLine("senha");
        string senhaRegistro = Console.ReadLine();
        Console.WriteLine("Confirmar senha");
        string confirmarSenhaRegistro = Console.ReadLine();
        if(senhaRegistro != confirmarSenhaRegistro)
            Console.WriteLine("as senhas são diferentes");
        else
        {
                    Usuario usr = new Usuario();
                    usr.Nome = usuarioRegistro;
                    usr.Senha = senhaRegistro;

                    context.Add(usr);
                    context.SaveChanges();
        
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