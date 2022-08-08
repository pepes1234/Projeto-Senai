
using Projeto_Senai.Model;
using System.Collections.Generic;

ExemploSenaiContext context = new ExemploSenaiContext();

List<string> Nomes = new List<string>();
List<string> Sobrenomes = new List<string>();
List<string> Objetos = new List<string>();
List<string> Adjetivos = new List<string>();
List<string> Caracteres = new List<string>();


Nomes.Add("Pedro");
Nomes.Add("João");
Nomes.Add("DAVI.");
Nomes.Add("Jhonny");
Nomes.Add("Gabriel");
Nomes.Add("Clara");
Nomes.Add("Elisa");
Nomes.Add("Mateus");
Nomes.Add("Guilherme");
Nomes.Add("Vinicius");
Nomes.Add("Alice");

Sobrenomes.Add("Silva");
Sobrenomes.Add("Souza");
Sobrenomes.Add("Pepes");
Sobrenomes.Add("Ferraz");
Sobrenomes.Add("Piratelo");
Sobrenomes.Add("Padrin");
Sobrenomes.Add("Pain");
Sobrenomes.Add("Copas");
Sobrenomes.Add("Ouros");
Sobrenomes.Add("Bispo");
Sobrenomes.Add("Cabello");

Objetos.Add("Carro");
Objetos.Add("Avião");
Objetos.Add("Quadro");
Objetos.Add("Televisão");
Objetos.Add("Celular");
Objetos.Add("Fone");
Objetos.Add("Teclado");
Objetos.Add("Piano");
Objetos.Add("Guitarra");
Objetos.Add("Caixa");
Objetos.Add("Monitor");

Adjetivos.Add("Atraentes");
Adjetivos.Add("Doces");
Adjetivos.Add("Amargos");
Adjetivos.Add("Diferentes");
Adjetivos.Add("Sapecas");
Adjetivos.Add("Curiosos");
Adjetivos.Add("Estranhos");
Adjetivos.Add("Feios");
Adjetivos.Add("Lindos");
Adjetivos.Add("Legals");
Adjetivos.Add("Chatos");

Caracteres.Add("/");
Caracteres.Add(".");
Caracteres.Add(",");
Caracteres.Add("1");
Caracteres.Add("2");
Caracteres.Add(";");
Caracteres.Add("");
Caracteres.Add("'");
Caracteres.Add("{");
Caracteres.Add("y");
Caracteres.Add(".");


void CriarUsuarioAleatorio()
{
    string senhausuario = "";
    Random rnd = new Random();
    Usuario usr = new Usuario();
    usr.Nome = Nomes[rnd.Next(0, Nomes.Count)] + " " + Sobrenomes[rnd.Next(0, Sobrenomes.Count)];
    for(var i = 0; i<rnd.Next(10, 16); i++)
    {
        senhausuario += Caracteres[rnd.Next(0, Caracteres.Count)];
    }
    usr.Senha = senhausuario;
    context.Add(usr);
    context.SaveChanges();
}



Usuario u = new Usuario();
CriarUsuarioAleatorio();
u.Postar(Objetos, Adjetivos);
u.Postar(Objetos, Adjetivos);
u.Postar(Objetos, Adjetivos);
u.Postar(Objetos, Adjetivos);
u.Postar(Objetos, Adjetivos);
u.Postar(Objetos, Adjetivos);
u.Postar(Objetos, Adjetivos);
u.Postar(Objetos, Adjetivos);
u.Seguir(2, 2);
