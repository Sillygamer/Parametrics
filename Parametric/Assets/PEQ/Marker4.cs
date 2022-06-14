using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marker4 : MonoBehaviour
{
    TrailRenderer tr;
    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<TrailRenderer>();
        tr.enabled = false;
        transform.position = PEQ.Epitrochiod(0, 11,.2f,1);
        tr.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        float t = Time.time;
        transform.position = PEQ.Epitrochiod(t, 11,.2f,1);
    }
}
