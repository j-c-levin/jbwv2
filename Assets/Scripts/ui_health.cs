using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class ui_health : MonoBehaviour
{
    public player_health player;
    private Text health_text;

    public void Start()
    {
        health_text = GetComponent<Text>();
    }

    public void Update()
    {
        health_text.text = "Health: " + player.health;
    }
}
