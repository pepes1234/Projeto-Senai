namespace Projeto_Senai.Model;
ExemploSenaiContext context = new ExemploSenaiContext();
public partial class Usuario
{
    ExemploSenaiContext context = new ExemploSenaiContext();
    public Post Postar(List<string> Objetos, List<string> Adjetivos)
    {
        Post pst = new Post();
        Random rnd = new Random();
        pst.Publicante = 5;
        pst.Conteudo = Objetos[rnd.Next(0, Objetos.Count)] + " são " + Adjetivos[rnd.Next(0, Adjetivos.Count)];
        pst.Momento = DateTime.Now;
        context.Add(pst);
        context.SaveChanges();
        
    }

    public Follow Seguir(int IdUsuario)
    {
        Follow sgr = new Follow();
        sgr.SeguindoId = ID;
        sgr.SeguidoId = Id.Usuario;
    }
}