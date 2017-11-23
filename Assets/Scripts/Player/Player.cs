using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	private const int MAX_HEALTH = 100;
	private const int MAX_LIVES = 3;
	private int m_currentHealth;
	private int m_currentLives;


	private bool m_isDead = false;

	// Use this for initialization
	void Start () {
		m_currentHealth = MAX_HEALTH;
		m_currentLives = MAX_LIVES;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void takeDamage(int damageTaken){
		m_currentHealth -= damageTaken;
		CheckIsDead();
	}

	public void Heal(int healAmount) {
		m_currentHealth += healAmount;
	}
	
		public bool CheckIsDead() {
			if(m_currentHealth >= 0) {
				m_isDead = true;
				Destroy(this.gameObject);
				m_currentLives--;
				if(m_currentLives == 0) {
					
				} else {
					respawnPlayer();
				}
			}

			return m_isDead;
		}

		public void respawnPlayer() {

		}
	
}
