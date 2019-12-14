using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D BallRigidbody2D;
    public int Speed = 10;
    [SerializeField]
    public Player Player;


    private void Awake()
    {
        BallRigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        transform.position = new Vector3(0,4,0);
        Move(Player.transform.position - transform.position);
    }

    private void Update()
    {
        SetBallPositionRestrict();
    }

    private void Move(Vector2 Direction)
    {
        BallRigidbody2D.velocity = Direction.normalized * (Mathf.Clamp(Speed, 10f, 15f));
    }

    private void SetBallPositionRestrict()
    {
        float BallXPosition = Mathf.Clamp(transform.position.x, -4.8f, 4.8f);
        float BallYPosition = Mathf.Clamp(transform.position.y, -9f, 9f);
    }
}
