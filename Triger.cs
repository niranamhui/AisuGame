using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triger : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
    public float JumpForce;
    bool checkJump = false;
    float xInput ;
    bool checkPressBtt = false;
    SpriteRenderer sr;
    Animator anime;
   
    // Start is called before the first frame update
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
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-speed, 0, 0);
            MoveHoirizontall();
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(speed, 0, 0);
            MoveHoirizontall();
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += new Vector3(0, 0.1f, 0);
        }
        if (checkPressBtt)
        {
            MoveHoirizontall();
        }
    }

    public void RigtPressBtt()
    {
        xInput = speed * 10 * Time.deltaTime;
        checkPressBtt = true;

    }
    public void LeftPressBtt()
    {
        xInput = -speed * 10 * Time.deltaTime;
        checkPressBtt = true;
    }
    public void UpBtt()
    {
        checkPressBtt = false;
    }

    public void MoveHoirizontall()
    {
        transform.Translate(xInput, 0, 0);
    }
    // private void FixedUpdate()
    //{
    //  if (checkJump == true)
    // {
    //     Jump();
    //     checkJump = false;
    // }


    // }
    // void Jump()
    // {
    //   rb.AddForce(0, JumpForce, 0);
    // }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("DAter"))
        {
           transform.position = GameObject.Find("Start").transform.position;

        }
        if (collision.gameObject.CompareTag("Box"))
        {
            collision.gameObject.SetActive(false);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Floor")
        {
            checkJump = true;
        }

    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Floor")
        {
            checkJump = false;
        }

    }

}
