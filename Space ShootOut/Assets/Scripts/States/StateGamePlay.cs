using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateGamePlay : GameState {

	Player p1 = new Player();
	private bool m_isPaused = false;
	private float m_gameTime = 600f;

	public StateGamePlay(GameManager gm):base(gm) { }

	public override void Enter() {
		m_gameTime = 600f;
		m_gm.resetStats();
	}

	public override void Execute() {
		m_gameTime -= Time.deltaTime;
		if(p1.CheckIsDead() == true || m_gameTime <= 0) {
			m_gm.NewGameState(m_gm.m_stateGameLose);
			m_gm.UpdateFSM(GameStates.LOSE);
		}

		if(Input.GetKeyDown(KeyCode.Escape)) {
			if(m_isPaused) {
				ResumeGameMode();
			} else {
				PauseGameMode();
			}
		}
	}

	public override void Exit() {
		//nothing here
	}

	private void ResumeGameMode() {
		Time.timeScale = 1.0f;
		m_isPaused = false;
	}

	private void PauseGameMode() {
		Time.timeScale = 0.0f;
		m_isPaused = true;
	}
}
