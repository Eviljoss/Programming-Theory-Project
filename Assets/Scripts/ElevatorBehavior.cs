using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorBehavior : ObstacleBehavior
{
    float speed = 1.0f;
    void Start()
    {
        StartCoroutine(ChangeDirection());
    }
    void Update()
    {
        Mouvement();
    }
    protected override void Mouvement()
    {
        if (goingForward)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        if (!goingForward)
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
    }
    protected override void Rotation()
    {

    }
}
