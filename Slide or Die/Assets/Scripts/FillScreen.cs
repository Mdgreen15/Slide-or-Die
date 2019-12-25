using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FillScreen : MonoBehaviour
{
    public float multipler = 1f;
    public float zScale = 1f;
    Camera cam;
    // Start is called before the first frame update
    void Awake()
    {
        cam = Camera.main;

        float pos = (cam.nearClipPlane + 0.01f);

        //transform.position = cam.transform.position + cam.transform.forward * pos;
        //transform.position = new Vector3(0, 0, transform.position.z);

        float h = Mathf.Tan(cam.fieldOfView * Mathf.Deg2Rad * 0.5f) * pos * 2f;
        h *= multipler;

        transform.localScale = new Vector3(h * cam.aspect, h, zScale);
    }

    void Update()
    {

    }
}
