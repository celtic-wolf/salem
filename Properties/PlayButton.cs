using Godot;
using System;

public class PlayButton : MenuButton
{
    // Member variables here, example:
    // private int a = 2;
    // private string b = "textvar";

    public override void _Ready()
    {
        // Called every time the node is added to the scene.
        // Initialization here
		var popup = GetPopup();
		popup.AddItem("item a");
	    popup.AddItem("item b");
	    popup.AddItem("item c");
	    popup.Connect("id_pressed", this, "OnItemPressed");
	}

	private void OnItemPressed(string id) {
	    var label = (Label)GetNode("../Label");
	    label.Text = id;
		GD.Print("blah.");
    }

//    public override void _Process(float delta)
//    {
//        // Called every frame. Delta is time since last frame.
//        // Update game logic here.
//
//    }
}
