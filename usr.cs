namespace Projeto_Senai.Model;
public partial class Usuario
{
    ExemploSenaiContext ctx = new ExemploSenaiContext();
    public void Postar(List<string> Objetos, List<string> Adjetivos)
    {
        Post pst = new Post();
        Random rnd = new Random();
        pst.Publicante = 1;
        pst.Conteudo = Objetos[rnd.Next(0, Objetos.Count)] + " são " + Adjetivos[rnd.Next(0, Adjetivos.Count)];
        pst.Momento = DateTime.Now;
        Console.WriteLine(pst.Publicante + " " + pst.Conteudo + " " +  pst.Momento);
        ctx.Add(pst);
        ctx.SaveChanges();
    }

    public void Seguir(int IdUsuario)
    {
        Follow sgr = new Follow();
        sgr.Seguindo = 1;
        sgr.Seguido = 1;
        
        ctx.Add(sgr);
        ctx.SaveChanges();
    }
}