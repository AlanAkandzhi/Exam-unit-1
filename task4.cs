public class MazeCar
{
    public void NavigateToGoal()
    {
        while (!AtGoal())
        {
            if (CanTurnRight())
            {
                TurnRight();
                Move();
            }
            else if (IsPathForward())
            {
                Move();
            }
            else if (CanTurnLeft())
            {
                TurnLeft();
                Move();
            }
            else
            {
                TurnAround();
            }
        }
    }

    private bool CanTurnRight() { return false;}
    private bool IsPathForward() {return false;}
    private bool CanTurnLeft() {return false;}
    private void Move() 
    private void TurnRight() 
    private void TurnLeft() 
    private void TurnAround() 
    private bool AtGoal() {return false;}
}

class Program
{
    static void Main()
    {
        MazeCar car = new MazeCar();
        car.NavigateToGoal();
    }
}
