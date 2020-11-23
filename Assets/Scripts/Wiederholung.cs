using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wiederholung : MonoBehaviour
{
    public Canvas canvasVariable;
    public Vector3 vectorVariable;
    public Transform transVariable;
    public Wiederholung whVariable;
    public float xValue;
    public Vector3 testVec = new Vector3(3, 3, 5);

    // Start is called before the first frame update
    void Start()
    {
        xValue = whVariable.transVariable.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
