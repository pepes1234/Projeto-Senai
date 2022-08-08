namespace Projeto_Senai.Model;
public partial class Usuario
{
    ExemploSenaiContext context = new ExemploSenaiContext();
    public void Postar(List<string> Objetos, List<string> Adjetivos)
    {
        Post pst = new Post();
        Random rnd = new Random();
        pst.Publicante = 1;
        pst.Conteudo = Objetos[rnd.Next(0, Objetos.Count)] + " são " + Adjetivos[rnd.Next(0, Adjetivos.Count)];
        pst.Momento = DateTime.Now;
        context.Add(pst);
        context.SaveChanges();
    }

    public void Seguir(int IdSeguidor, int IdSeguido)
    {
        Usuario usr = new Usuario();
        Random rnd = new Random();
        Follow sgr = new Follow();
        
        sgr.Seguindo = IdSeguidor;
        sgr.Seguido = IdSeguido;

        context.Add(sgr);
        context.SaveChanges();
    }
}