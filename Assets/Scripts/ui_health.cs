using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class ui_health : MonoBehaviour
{
    private player_health player;
    private Text health_text;

    public void Start()
    {
        health_text = GetComponent<Text>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<player_health>();
    }

    public void Update()
    {
        health_text.text = "Health: " + player.health;
    }
}
