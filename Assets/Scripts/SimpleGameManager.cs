using UnityEngine;
using System.Collections;

// Game States
public enum GameState { INTRO, MAIN_MENU, PAUSED, GAME, CREDITS, HELP }

public delegate void OnStateChangeHandler();

public class SimpleGameManager {
	protected SimpleGameManager() {}
	private static SimpleGameManager instance = null;
	public event OnStateChangeHandler OnStateChange;
	public  GameState gameState { get; private set; }

	public static SimpleGameManager Instance{
		get {
			if (SimpleGameManager.instance == null){
				DontDestroyOnLoad(SimpleGameManager.instance);
				SimpleGameManager.instance = new SimpleGameManager();
			}
			return SimpleGameManager.instance;
		}

	}

	public void SetGameState(GameState state){
		this.gameState = state;
		OnStateChange();
	}

	public void OnApplicationQuit(){
		SimpleGameManager.instance = null;
	}

}
