namespace Zoo.BusinessLogic.Models.Animals
{
    public interface ILargeAnimal
    {
        void Feed();
        bool IsHungry { get; }
    }
}