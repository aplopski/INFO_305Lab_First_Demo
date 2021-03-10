using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicDemo : MonoBehaviour
{

    bool moving = false;
    float offset = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(0, 20 * Time.deltaTime, 0, Space.Self);
        if (moving)
        {
            this.transform.Translate(offset * Time.deltaTime, 0, 0, Space.World);
            if (Mathf.Abs(this.transform.position.x) > 1)
            {
                offset = -offset;
            }

        }
        
    }

    public void toggleMove()
    {
        moving = !moving;
    }
}
