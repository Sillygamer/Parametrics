using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marker8 : MonoBehaviour
{
    TrailRenderer tr;
    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<TrailRenderer>();
        tr.enabled = false;
        transform.position = PEQ.Hypocycloid(0, 15,6f);
        tr.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        float t = Time.time;
        transform.position = PEQ.Hypocycloid(t,15,6f);
    }
}
