using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Master : MonoBehaviour
{
    public float x;
    public Rigidbody rigidBody;
    public bool boolVar;
    public BoxCollider boxCollider;
    public float y;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody.mass = x+20; // eingestellter Wert + 20 
        rigidBody.useGravity = boolVar;
        rigidBody.isKinematic = boolVar;
        boxCollider.isTrigger = boolVar;
    }

    // Update is called once per frame
    void Update()
    {
        rigidBody.angularDrag = x+50;
        // rigidBody.drag = x - y;
        rigidBody.drag = x - rigidBody.mass;
    }
}
