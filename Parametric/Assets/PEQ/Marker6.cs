using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marker6 : MonoBehaviour
{
    TrailRenderer tr;
    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<TrailRenderer>();
        tr.enabled = false;
        transform.position = PEQ.Rhodonea(0);
        tr.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        float t = Time.time;
        transform.position = PEQ.Rhodonea(t);
    }
}
