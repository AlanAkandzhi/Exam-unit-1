public class MazeCar
{
    public void NavigateToGoal()
    {
        while (!AtGoal())
        {
            if (Peek() == 'Clear')
            {
                Move();
            }
            else
            {
                Turn();
            }
        }
        Console.WriteLine("The car has reached the goal!");
    }

    private void Move() 
    private void Turn() 
    private char Peek() { return 'Clear';}
    private bool AtGoal() { return false;}
}

class Program
{
    static void Main()
    {
        MazeCar car = new MazeCar();
        car.NavigateToGoal();
    }
}
