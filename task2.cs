1:
while (!AtGoal())
{
    if (CanMoveRight()) 
    {
        TurnRight();
        Move();
    }
    else if (Peek())
    {
        Move();
    }
    else // 
    {
        TurnLeft();
    }
}

/*
2:
while (!AtGoal())
{
    
    if (Peek()) 
    {
        Move();

        Turn();
        if (Peek())
        {
            Move();
        }
        else
        {
            
            Turn();
            Turn();
            Turn();
        }
    }
    else 
    {
        Turn();
        Turn();
        Turn();
    }
}
*/

#region Basic functions
// These functions are just her to make your intelisense work. 
// They only have a conceptual function.

void Move()
{
    // Moves the car 1 cell in the direction it is heading. 
}

void Turn()
{
    // Turns the car 90 deg clockwise.
}

bool Peek()
{
    // Returns true if the next cell is open, otherwise false.
    return true; // Just a placeholder value. 
}

bool AtGoal()
{
    // Returns true if the current cell is the goal cell.
    return true; // just a placholder
}

#endregion


