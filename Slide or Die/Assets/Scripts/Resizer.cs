using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resizer : MonoBehaviour
{
    public GameObject obj;
    float size;
    // Start is called before the first frame update
    void Start()
    {
        size = 10 * obj.transform.localScale.x;
        transform.localScale = new Vector3(size / 3, size / 3, size / 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
