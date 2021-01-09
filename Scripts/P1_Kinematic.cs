using Godot;
using System;

public class P1_Kinematic : KinematicBody2D
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";

	[Export] public int speed = 600;

	public Vector2 velocity = new Vector2();

	public override void _PhysicsProcess(float delta)
	{
		velocity = new Vector2();

		if (Input.IsActionPressed("p1_move_up"))
			velocity.y -= 1;

		if (Input.IsActionPressed("p1_move_down"))
			velocity.y += 1;


		MoveAndSlide(velocity.Normalized() * speed);
	}

	//  // Called every frame. 'delta' is the elapsed time since the previous frame.
	//  public override void _Process(float delta)
	//  {
	//      
	//  }
}
