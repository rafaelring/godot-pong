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
        var paddle_p1 = GetNode<P1_Kinematic>("Player1");
        var paddle_p2 = GetNode<P1_Kinematic>("Player2");

        ball.Reset();
        paddle_p1.Reset();
        paddle_p2.Reset();
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
