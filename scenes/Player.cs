using Godot;


public partial class Player : CharacterBody2D
{
    [Export]private float MoveSpeed = 200f;

    private void GetInput()
    {
        Vector2 inputDirection = Vector2.Zero;
        //jobbra
        if (Input.IsActionPressed("ui_right"))
        {
            inputDirection.X += 1;
        }
        //balra
        if (Input.IsActionPressed("ui_left"))
        {
            inputDirection.X -= 1;
        }
       
        //fel
        if (Input.IsActionPressed("ui_up"))
        {
            inputDirection.Y -= 1;
        }
       

        //le
        if (Input.IsActionPressed("ui_down"))
        {
            inputDirection.Y += 1;
        }

        inputDirection = inputDirection.Normalized();
        
        Velocity = inputDirection * MoveSpeed;

    }

    public override void _PhysicsProcess(double delta)
    {
        GetInput();
        MoveAndSlide();
    }

}
