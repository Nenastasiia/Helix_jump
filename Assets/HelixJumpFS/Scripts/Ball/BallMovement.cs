using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BallMovement))]
public class BallMovement : MonoBehaviour
{
    [Header("Fall")]
    [SerializeField] private float fallHeight;
    [SerializeField] private float fallSpeedDefault;
    [SerializeField] private float fallSpeedMax;
    [SerializeField] private float testgit;
    [SerializeField] private float fallSpeedAcceleration;

    private Animator animator;

    private float floorY;
    private float fallSpeed;

    private void Start()
    {
        enabled = false;
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        if (transform.position.y > floorY)
        {
            transform.Translate(0, -fallSpeed * Time.deltaTime, 0);
            //transform.position += Vector3.down * fallSpeed * Time.deltaTime; global coordinate
            if (fallSpeed < fallSpeedMax)
            {
                fallSpeed += fallSpeedAcceleration * Time.deltaTime;
            }
        }
        else
        {
            enabled = false;
        }
    }
    public void Jump()
    {
        animator.speed = 1;
        fallSpeed = fallSpeedDefault;
    }

    public void Fall(float startFloorY)
    {
        animator.speed = 0;
        enabled = true; //update is enable

        floorY = startFloorY - fallHeight;
    }

    public void Stop()
    {
        animator.speed = 0;
    }
}
