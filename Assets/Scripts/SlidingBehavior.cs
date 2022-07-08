using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlidingBehavior : ObstacleBehavior //INHERITANCE
{
    float speed = 2.0f;
    void Start()
    {
        StartCoroutine(ChangeDirection()); //ABSTRACTION
    }
    void Update()
    {
        Mouvement(); //ABSTRACTION
    }
    protected override void Mouvement() //POLYMORPHISM
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
