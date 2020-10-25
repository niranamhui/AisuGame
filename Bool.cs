using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bool : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Update()
    {
        GetComponent<Rigidbody2D>().transform.position += new Vector3(0.01f, 0, 0) * speed;
    }
}
