using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer rendererr;
    Rigidbody rigidBody;
    [SerializeField]float timeToWait = 5f;

    // Start is called before the first frame update
    void Start()
    {
        rendererr = GetComponent<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();

        rendererr.enabled = false;
        rigidBody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToWait)
        {
            rendererr.enabled = true;
            rigidBody.useGravity = true;
        }
    }
}
