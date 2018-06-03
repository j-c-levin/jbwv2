using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class kezia_movement : MonoBehaviour
{
    public float speed = 1;
    private Transform player;

    public void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public void Update()
    {
        // Rotate to look at the player
        Vector3 dir = player.position - transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.AngleAxis(angle, Vector3.forward), 0.05f);
        // Move forward
        // Stuck here
        // transform.DOMove(new_position, 0.1f);
    }
}
