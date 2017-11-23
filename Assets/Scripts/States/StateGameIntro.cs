using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateGameIntro : GameState {

	private float m_countdown = 5f;

	public StateGameIntro(GameManager gm):base(gm) { }

	public override void Enter() {
		m_countdown = 5f;
	}

	public override void Execute() {
		if(m_countdown <= 0) {
			m_gm.NewGameState(m_gm.m_stateGameMenu);
			m_gm.UpdateFSM(GameStates.MENU);
		} else {
			m_countdown -= Time.deltaTime;
		}
	}

	public override void Exit() {
		//nothing here
	}
}

