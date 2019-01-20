using DesignPatterns.Source.CreationalPatterns.Builder.CarPart;

namespace DesignPatterns.Source.CreationalPatterns.Builder.Interface
{
    interface ICar
    {
        ITripComputer TripComputer { set; }
        Seat Seat { set; }
        IEngine Engine { set; }
        string Description();
    } 
}
