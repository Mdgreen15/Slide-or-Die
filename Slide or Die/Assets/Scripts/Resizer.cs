using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resizer : MonoBehaviour
{
    public GameObject obj;
    Collider coll;
    Vector3 size;
    float xSize;
    // Start is called before the first frame update
    void Start()
    {
        coll = obj.GetComponent<Collider>();
        size = coll.bounds.size;
        xSize = size.x * transform.localScale.x;
        transform.localScale = new Vector3(xSize / 3, xSize / 3, xSize / 3);
        Debug.Log(xSize);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
