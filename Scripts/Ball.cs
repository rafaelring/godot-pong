using Godot;
using System;

public class Ball : RigidBody2D
{
    private bool shouldReset = false;
    static Random random = new Random();
    static Vector2[] startDirections = {
        new Vector2(1f, 1f), new Vector2(1f, -1f),
        new Vector2(-1f, 1f), new Vector2(-1f, -1f)
    };

    public override void _Ready()
    {
        Reset();
    }

    public void Reset()
    {
        shouldReset = true;
    }

    public override void _IntegrateForces(Physics2DDirectBodyState state)
    {
        if (shouldReset)
        {
            state.Transform = new Transform2D(0f, Vector2.Zero);
            state.LinearVelocity = GetRandomVelocity();
            shouldReset = false;
        }

        base._IntegrateForces(state);
    }

    private Vector2 GetRandomVelocity()
    {
        var direction = startDirections[random.Next(0, 4)];
        return direction.Normalized() * 500f;
    }

}
