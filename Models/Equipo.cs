namespace TpIndumentaria.Models;
public static class Equipo
{
    // Definicion de Propiedades
 

    public static List<string> ListMedias{get;set;} = new List<string> { "img/c1.png", "img/c2.png","img/c3.png", "img/c4.png", "img/c5.png",
        "img/c6.png", "img/c7.png", "img/c8.png", "img/c9.png", "img/c10.png" };
    public static List<string> ListPantalon{get;set;} = new List<string> { "img/p1.png", "img/p2.png", "img/p3.png", "img/p4.png", "img/p5.png",
        "img/p6.png", "img/p7.png", "img/p8.png", "img/p9.png", "img/p10.png"};

    
    public static List<string> ListCamiseta{get;set;} = new List<string> {
        "img/m1.png", "img/p2.png", "img/p3.png", "img/p4.png", "img/p5.png",
        "img/p6.png", "img/p7.png", "img/p8.png", "img/p9.png", "img/p10.png"};
    public static List<string> ListEquipos{get;set;} = new List<string> {
    "Real Madrid",
    "Barcelona",
    "Manchester United",
    "Bayern Munich",
    "Liverpool",
    "Paris Saint-Germain",
    "Juventus",
    "Manchester City",
    "Chelsea",
    "Atlético de Madrid"};

    public static Dictionary<string,Indumentaria> DicEquipos {get; private set;}= new Dictionary<string, Indumentaria>();

// Constructor
    public static bool ingresarIndumentaria(string EquipoSeleccionado, Indumentaria Item){
        bool Valido = true;
        if(DicEquipos.ContainsKey(EquipoSeleccionado)){
            Valido = false;
        }else{
            DicEquipos.Add(EquipoSeleccionado,Item);
        }
        return Valido;


    }
}
