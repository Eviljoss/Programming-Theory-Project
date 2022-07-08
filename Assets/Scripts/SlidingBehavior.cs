using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlidingBehavior : ObstacleBehavior
{
    float speed = 2.0f;
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
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        if (!goingForward)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
    }
    protected override void Rotation()
    { }
}
