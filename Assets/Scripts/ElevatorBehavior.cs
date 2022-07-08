using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorBehavior : ObstacleBehavior //INHERITANCE
{
    float speed = 1.0f;
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
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        if (!goingForward)
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
    }
    protected override void Rotation()
    { }
}
