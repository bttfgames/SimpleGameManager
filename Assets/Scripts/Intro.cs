using UnityEngine;
using System.Collections;

public class Intro : MonoBehaviour {
	
	SimpleGameManager GM;
	
	void Awake () {
		GM = SimpleGameManager.Instance;
		GM.OnStateChange += HandleOnStateChange;
		Debug.Log("Current game state when Awakes: " + GM.gameState);
	}
	
	void Start () {
		Debug.Log("Current game state when Starts: " + GM.gameState);
		GM.SetGameState(GameState.MAIN_MENU);
	}
	
	public void HandleOnStateChange ()
	{
		Debug.Log("Handling state change to: " + GM.gameState);
		Invoke("LoadLevel", 3f);
	}

	public void LoadLevel(){
		Debug.Log("Invoking LoadLevel");
		Application.LoadLevel("Menu");
	}
	

}
