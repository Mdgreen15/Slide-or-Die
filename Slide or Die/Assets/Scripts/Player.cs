using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 2f;

    float leftSide = -4f;
    float midSide = 0f;
    float rightSide = 4f;
    float curSide = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (curSide == -1f)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(leftSide, transform.position.y, transform.position.z), speed);//go to left side
        }
        else if (curSide == 0f)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(midSide, transform.position.y, transform.position.z), speed);//go to middle
        }
        else if (curSide == 1f)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(rightSide, transform.position.y, transform.position.z), speed);//go to right side
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            if (curSide != -1f) curSide--;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            if (curSide != 1f) curSide++;
        }
    }
}
