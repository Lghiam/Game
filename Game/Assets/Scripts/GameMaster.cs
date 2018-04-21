using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour {
    //https://www.youtube.com/watch?v=WFO1GUKYARQ&t=333s this code was also used to create the respawn function
    public static GameMaster gm;

    void Start ()
    {
        if (gm == null) { 
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        }
    }

    public Transform playerPrefab;
    public Transform spawnPoint;

    public void RespawnPlayer ()
    {
        Instantiate(playerPrefab, spawnPoint.position, spawnPoint.rotation);
    }

    public static void Kill (Player player)
    {
        Destroy(player);
        gm.RespawnPlayer();
    }



}
