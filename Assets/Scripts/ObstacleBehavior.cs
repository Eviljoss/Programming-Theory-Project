using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ObstacleBehavior : MonoBehaviour
{
    protected bool goingForward = true;
    protected const float delay = 0.5f;
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