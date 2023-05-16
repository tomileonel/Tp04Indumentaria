namespace TpIndumentaria.Models;
public static class Equipos
{
    // Definicion de Propiedades
 

    public static List<string> ListMedias{get;set;} = new List<string> { "m1.png", "m2.png","m3.png", "m4.png", "m5.png",
        "m6.png", "m7.png", "m8.png", "m9.png", "m10.png" };
    public static List<string> ListPantalon{get;set;} = new List<string> { "p1.png", "p2.png", "p3.png", "p4.png", "p5.png",
        "p6.png", "p7.png", "p8.png", "p9.png", "p10.png"};

    
    public static List<string> ListCamiseta{get;set;} = new List<string> {
        "c1.png", "c2.png","c3.png", "c4.png", "c5.png",
        "c6.png", "c7.png", "c8.png", "c9.png", "c10.png"};
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
