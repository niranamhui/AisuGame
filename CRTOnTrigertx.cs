using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CRTOnTrigertx : MonoBehaviour
{
    public int amountIncrease;
    int coint;
    public Text TxtScore;
    public Text TxteWin;
    public Text TxteEnd;
    public Text TxteSuty;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Box"))
        {
            coint += amountIncrease;
            TxtScore.text = "Score  " + coint.ToString();
        }
        if (coint >= 70)
        {
            increaseCoin();
        }
    }

    public void increaseCoin()
    {
        TxteWin.text = "Win";
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
         if (collision.gameObject.CompareTag("Date"))
            {
                TxteEnd.text = "END";
            }


        if (collision.gameObject.CompareTag("Boxx"))
            {
                TxteSuty.text = "Collert";
             }
    }
}
