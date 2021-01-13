using Godot;
using System;

public class P1Score : RichTextLabel
{
    private int score = 0;

    public void _OnP2GoalEntered(Node body)
    {
        score++;
        this.Text = score.ToString();
    }
}
