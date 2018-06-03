using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_health : MonoBehaviour
{
    public int health = 10;
    public void OnTriggerEnter2D(Collider2D other)
    {
		health -= 1;
    }
}
