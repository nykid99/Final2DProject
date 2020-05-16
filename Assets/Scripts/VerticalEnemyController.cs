using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalEnemyController : MonoBehaviour
{
    // Start is called before the first frame update
    private float floatingTimer = 0f;
    private float floatingMax = 1.8f;
    private float floatingDir = 0.05f;


    private void FixedUpdate()
    {
        if (floatingTimer < floatingMax)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + floatingDir);
            floatingTimer += Time.fixedDeltaTime;
        }
        else
        {
            floatingDir *= -1;
            floatingTimer = 0f;
        }
    }
}
