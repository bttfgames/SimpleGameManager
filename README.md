SimpleGameManager
=================

A simple GameManager Class to Unity3D projects.

The SimpleGameManager class is implemented using the Singleton Pattern and uses the DontDestroyOnLoad function on the class instance. It's a enum state based class that can be used to manipulate all the game states on your projects.

## Simple Usage

  ```csharp
  using UnityEngine;
  using System.Collections;
  
  public class YourClass : MonoBehaviour {
  
  	SimpleGameManager GM;
  
  	void Awake () {
  	  // call the instance 
  		GM = SimpleGameManager.Instance;
  		// add a callback for when the game state changes
  		GM.OnStateChange += HandleOnStateChange;
  	}
  
  	void Start(){
  		Debug.Log("Started!");
  		// You define all the game states on SimpleGameManager.cs class
  		GM.SetGameState(GameState.YOUR_GAME_STATE);
  	}
  
  	public void HandleOnStateChange(){
  		Debug.Log("State change called!");
  	}
  }
  ```
