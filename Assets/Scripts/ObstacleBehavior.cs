using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ObstacleBehavior : MonoBehaviour //ENCAPSULATION
{
    protected bool goingForward = true; //ENCAPSULATION
    protected const float delay = 0.5f; //ENCAPSULATION
    protected abstract void Mouvement();
    protected abstract void Rotation();
    protected virtual IEnumerator ChangeDirection()
    {
        yield return new WaitForSeconds(delay * 6);
        if (goingForward)
        {
            goingForward = false;
        }
        else goingForward = true;
        StartCoroutine(ChangeDirection());
    }
}