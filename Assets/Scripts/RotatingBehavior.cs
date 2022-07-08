using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingBehavior : ObstacleBehavior
{
    bool clockwise = true;
    void Start()
    {
        StartCoroutine(ChangeDirection());
    }
    void Update()
    {
        Rotation();
    }
    protected override void Mouvement()
    { }
    protected override void Rotation()
    {
        float angle = transform.eulerAngles.z;
        if (clockwise && angle < 90 && angle >= 0)
        {
            transform.Rotate(0, 0, 45 * Time.deltaTime);
        }
        else if (clockwise && angle >= 90)
        {
            transform.rotation = Quaternion.Euler(0, 0, 90);
        }
        if (!clockwise && angle > 0 && angle <= 91)
        {
            transform.Rotate(0, 0, -45 * Time.deltaTime);
        }
        if (!clockwise && angle <= 1)
        {
            transform.rotation = Quaternion.Euler(0, 0, 1);
        }
    }
    protected override IEnumerator ChangeDirection()
    {
        yield return new WaitForSeconds(delay * 15);
        if (clockwise)
        {
            clockwise = false;
        }
        else clockwise = true;
        StartCoroutine(ChangeDirection());
    }
}
