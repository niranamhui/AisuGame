using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rigtanition : MonoBehaviour
{
    public GameObject shot;
    public Transform shotspot;
    public float firtrate;
    private float nextfirt;
    public float speedd;
  
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1) && Time.time > nextfirt)
        {
            GetComponent<Rigidbody2D>().transform.position += new Vector3(-0.01f, 0, 0) * speedd;
            nextfirt = Time.time + firtrate;
            Instantiate(shot, shotspot.position, shotspot.rotation);

        }

    }
}
