while (!AtGoal())
{
if (Peek())
{
    Move();
 }
else 
 {
    Turn();
         if (!Peek()) 
        {
            Turn(); 
            
            if (!Peek()) 
            {
                Turn();
                if (!Peek()) 
                {
                    Console.WriteLine("The car is stuck and cannot move to the finish line.");
                    return;
                }
            }
        }
           Move();
    }
}

Console.WriteLine("The car has reached the finish line!");
