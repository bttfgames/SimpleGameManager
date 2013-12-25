using UnityEngine;
using System.Collections;

public class GMTest : MonoBehaviour {
	
	SimpleGameManager GM;
	
	void Awake () {
		GM = SimpleGameManager.Instance;
		GM.OnStateChange += HandleOnStateChange;
		
		Debug.Log("Current game state when Awakes: " + GM.gameState);
	}
	
	void Start () {
		Debug.Log("Current game state when Starts: " + GM.gameState);
	}
	
	public void HandleOnStateChange ()
	{
		GM.SetGameState(GameState.MAIN_MENU);
		Debug.Log("Handling state change to: " + GM.gameState);
		Invoke("LoadLevel", 3f);
	}

	public void LoadLevel(){
		Application.LoadLevel("Menu");
	}
	

}
