using Godot;
using System;

public class P2Score : RichTextLabel
{
    private int score = 0;

    public void _OnP1GoalEntered(Node body)
    {
        score++;
        this.Text = score.ToString();
    }
}
