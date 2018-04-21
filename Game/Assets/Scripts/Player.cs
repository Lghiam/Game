using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    //https://www.youtube.com/watch?v=WFO1GUKYARQ&t=333s this code was taken to create a respawn function in the game 
    [System.Serializable]
	public class PlayerStats
    {
        public int Life = 100;
    }

    public PlayerStats playerStats = new PlayerStats();

    public int fBoundary = -20;

    void Update()
    {
        if (transform.position.y <= -20)
            DamagePlayer(999999);

        
    }

    public void DamagePlayer (int damage)
    {
        playerStats.Life -= damage;
        if(playerStats.Life <= 0)
        {
            GameMaster.Kill(this);
        }
    }
}
