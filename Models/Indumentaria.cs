public class Indumentaria
{
    // Definicion de Propiedades
    public string Medias{get;set;}
    public string Pantalon{get;set;}
    public string Camiseta{get;set;}

// Constructor
    public Indumentaria()
    {

    }
    public Indumentaria(string medias,string pantalon,string camiseta)
    {
        Medias = medias;
        Pantalon = pantalon;
        Camiseta = camiseta;
    }
}