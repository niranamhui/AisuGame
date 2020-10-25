using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anition : MonoBehaviour
{
    SpriteRenderer sr;
    Animator anime;
    public float speed ;
    Rigidbody rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        anime = GetComponent<Animator>();
       
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Space))
        {
            anime.SetInteger("Student", 3);
        }
      
        else if(Input.GetKey(KeyCode.DownArrow))
        {
           // anime.SetInteger("Student", 4);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(speed, 0, 0);
            anime.SetInteger("Student", 1);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            anime.SetInteger("Student", 2);
            transform.Translate( speed, 0, 0);
        }
        else
        {
            anime.SetInteger("Student", 0);
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Date"))
        {
            anime.SetInteger("Student", 4);
        }
    }


}
