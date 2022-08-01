using Projeto_Senai.Model;

Usuario usuario = new Usuario();
usuario.Nome = "Lucas";
usuario.Senha = "1234";

ExemploSenaiContext context = new ExemploSenaiContext();
context.Add(usuario);
context.SaveChanges();
