using DesignPatterns.Source.CreationalPatterns.Builder.Interface;

namespace DesignPatterns.Source.CreationalPatterns.Builder
{
    interface ICarBuilder
    {
        ICar Car { get; set; }
        void SetSeats();
        void SetEngine();
        void SetTripComputer();

    }
}
