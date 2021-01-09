using Godot;
using System;

public class P1_Paddle : Sprite
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    private float speed = 300.0;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {

    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(float delta)
    {
        if (Input.IsActionPressed("p1_move_up"))
        {
        }

    }
}
