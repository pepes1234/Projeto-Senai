namespace Projeto_Senai.Model;
public partial class Usuario
{
    Program prg = new Program();
    void Postar()
    {
        Post pst = new Post();
        pst.Publicante = this.ID;
        pst.Conteudo = Objetos[rnd.Next(0, Objetos.Count)] + " são " + Adjetivos[rnd.Next(0, Adjetivos.Count)];
        pst.Momento = DateTime.Now;
        context.Add(pst);
        context.SaveChanges();
    }

    void Seguir(int IdUsuario)
    {
        Segue sgr = new Segue();
        sgr.SeguindoID = this.ID;
        sgr.SeguindoID = Id.Usuario;
    }
}