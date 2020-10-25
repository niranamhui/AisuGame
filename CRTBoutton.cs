using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CRTBoutton : MonoBehaviour
{
    public GameObject Player;
    Triger crtPlayer;
    anition crtAnimetion;

    private void Start()
    {
        crtPlayer = Player.GetComponent<Triger>();
        crtAnimetion = Player.GetComponent<anition>();
    }
    public void MoveLeft()
    {
        crtPlayer.LeftPressBtt();
    }
    public void MoveRigt()
    {
        crtPlayer.RigtPressBtt();
    }
    public void StopMove()
    {
        crtPlayer.UpBtt();
    }
}
