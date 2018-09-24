using Godot;
using System;
using System.Collections;
//using Nakama;

public class ControllerMultiplayer : Node
{
    // Member variables here, example:
    // private int a = 2;
    // private string b = "textvar";

    public override void _Ready()
    {
        // Called every time the node is added to the scene.
        // Initialization here
		Setup();
    }

    public override void _Process(float delta)
    {
        // Called every frame. Delta is time since last frame.
        // Update game logic here.
    }

	private void Setup() {
		//var client = new Client("defaultkey", "127.0.0.1", 7350, false);
		//const string email = "hello@example.com";
		//const string password = "somesupersecretpassword";
		//var session = await client.AuthenticateEmailAsync(email, password);
		//Debug.LogFormat("Authenticated session: {0}", session);
	}
}
