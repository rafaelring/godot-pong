using Godot;
using System;

public class P1_Kinematic : KinematicBody2D
{

	[Export] public int speed = 600;
	[Export] public String key_up = "p1_move_up";
	[Export] public String key_down = "p1_move_down";
	public Vector2 velocity = new Vector2();

	public override void _Ready()
	{
		base._Ready();
	}

	public override void _PhysicsProcess(float delta)
	{
		velocity = new Vector2();

		if (Input.IsActionPressed(this.key_up))
			velocity.y -= 1;

		if (Input.IsActionPressed(this.key_down))
			velocity.y += 1;

		MoveAndSlide(velocity.Normalized() * speed);
	}

}
