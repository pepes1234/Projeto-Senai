using Projeto_Senai.Model;


ExemploSenaiContext context = new ExemploSenaiContext();
foreach (var usuario in context.Usuarios)
{
    Console.WriteLine(usuario.Nome);
}
