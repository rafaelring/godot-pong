using Godot;
using System;

public class Pong : Node2D
{
    public override void _PhysicsProcess(float delta)
    {
        if (Input.IsActionPressed("reset_game"))
        {
            Reset();
        }

    }

    public void Reset()
    {
        var ball = GetNode<Ball>("Ball");
        ball.Reset();
    }

    public void _OnP1GoalEntered(Node body)
    {
        Reset();
    }
    public void _onP2GoalEntered(Node body)
    {
        Reset();
    }
}
