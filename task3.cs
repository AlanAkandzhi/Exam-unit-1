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
    }

    private void Move() { }
    private void Turn() { }
    private char Peek() { return 'Clear'; }
    private bool AtGoal() { return false; }
}

class Program
{
    static void Main()
    {
        new MazeCar().NavigateToGoal();
    }
}
