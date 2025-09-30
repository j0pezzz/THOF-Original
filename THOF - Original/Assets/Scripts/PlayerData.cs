using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class PlayerData : MonoBehaviour
{
    public int level;
    public int coins;
    public int health;
    //public float[] position;
    public bool saved;

    //public GameObject player;
    public Stats stats;

    public Vector3 pos;

    public PlayerData()
    {
        level = stats.level;
        coins = stats.coins;
        health = stats.health;
        

        //player.transform.position = pos;
    }
}
