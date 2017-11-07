using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public float m_rocketHits { get; set; }

	public StateManager m_stateManager;
	private GameState m_currentState;
	public StateGamePlay m_stateGamePlay { get; set; }
	public StateGameWin m_stateGameWin { get; set; }
	public StateGameLose m_stateGameLose { get; set; }
	public StateGameIntro m_stateGameIntro { get; set; }
	public StateGameMenu m_stateGameMenu { get; set; }

	public static GameManager Instance {get { return m_instance; } }
	public static GameManager m_instance = null;

	// Use this for initialization
	void Awake () {
		if(m_instance != null && m_instance != this) {
			Destroy(this.gameObject);
			return;
		} else {
			m_instance = this;
		}
		DontDestroyOnLoad(this.gameObject);

		m_stateGamePlay = new StateGamePlay(this);
		m_stateGameWin = new StateGameWin(this);
		m_stateGameLose = new StateGameLose(this);
		m_stateGameIntro = new StateGameIntro(this);
		m_stateGameMenu = new StateGameMenu(this);
	}
	
	public void StartGame() {
		NewGameState(m_stateGameIntro);
	}

	private void Update () {
		if(m_currentState != null) {
			m_currentState.Execute();
		}
	}

	public void NewGameState(GameState newState) {
		if(m_currentState != null) {
			m_currentState.Exit();
		}
		m_currentState = newState;
		m_currentState.Enter();
	}

	public void UpdateFSM(GameStates newState) {
		m_stateManager.ChangeStates(newState);
	}

	public void RocketHit() {
		m_rocketHits++;
	}

	public void resetStats() {
		m_rocketHits = 0;
	}
}
