using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class player_movement : MonoBehaviour
{
    public float speed = 1;
    private float width_of_player = 0.5f;
    private float x_left_boundary;
    private float x_right_boundary;
    private float y_top_boundary;
    private float y_bottom_boundary;

    public void Start()
    {
        x_left_boundary = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, Camera.main.nearClipPlane)).x + width_of_player;
        x_right_boundary = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, Camera.main.nearClipPlane)).x - width_of_player;
        y_top_boundary = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, Camera.main.nearClipPlane)).y + width_of_player;
        y_bottom_boundary = Camera.main.ViewportToWorldPoint(new Vector3(0, 1, Camera.main.nearClipPlane)).y - width_of_player;
    }

    // Update is called once per frame
    public void Update()
    {
        // Set up the values for how far the player should travel
        float x_mov = transform.position.x + Input.GetAxisRaw("Horizontal") * speed;
        x_mov = Mathf.Clamp(x_mov, x_left_boundary, x_right_boundary);
        float y_mov = transform.position.y + Input.GetAxisRaw("Vertical") * speed;
        y_mov = Mathf.Clamp(y_mov, y_top_boundary, y_bottom_boundary);
        // Begin tweening for the frame
        transform.DOLocalMoveX(x_mov, 0.1f);
        transform.DOLocalMoveY(y_mov, 0.1f);
    }
}
