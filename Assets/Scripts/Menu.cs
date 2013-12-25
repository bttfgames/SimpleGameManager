using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {
	SimpleGameManager GM;

	void Awake () {
		GM = SimpleGameManager.Instance;
		GM.OnStateChange += HandleOnStateChange;
	}

	public void HandleOnStateChange ()
	{
		Debug.Log("OnStateChange!");
	}


	public void OnGUI(){
		//menu layout
		GUI.BeginGroup (new Rect (Screen.width / 2 - 50, Screen.height / 2 - 50, 100, 800));
		GUI.Box (new Rect (0, 0, 100, 200), "Menu");
		if (GUI.Button (new Rect (10, 40, 80, 30), "Start")){
			StartGame();
		}
		if (GUI.Button (new Rect (10, 80, 80, 30), "Help")){
			ShowHelp();
		}
		if (GUI.Button (new Rect (10, 120, 80, 30), "Credits")){
			ShowCredits();
		}
		if (GUI.Button (new Rect (10, 160, 80, 30), "Quit")){
			Quit();
		}
		GUI.EndGroup();
	}


	public void ShowCredits(){
		// show credits scene or GUI
		GM.SetGameState(GameState.CREDITS);
		Debug.Log(GM.gameState);
	}

	public void StartGame(){
		//start game scene
		GM.SetGameState(GameState.GAME);
		Debug.Log(GM.gameState);
	}

	public void ShowHelp(){
		// show Help scene or GUI
		GM.SetGameState(GameState.HELP);
		Debug.Log(GM.gameState);
	}

	public void Quit(){
		Debug.Log("Quit!");
		Application.Quit();
	}
}
