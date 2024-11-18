using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2move : MonoBehaviour
{
    public GameObject otherplayer;

    bool paused = false;

    void Start()
    {

    }

    void Update()
    {
        if (paused == false)
        {
            movement();
        }
    }

    void movement()
    {
        //anlamsiz bir sekilde isinlanacagimiz yerde diger oyuncu varsa kipirdamamasi gerekirken 1birim disari cikiyordu. bu sorunu bu sekilde cozebildim.
        if (GetComponent<Rigidbody>().transform.position.z == 3.5)
            GetComponent<Rigidbody>().transform.position = new Vector3(GetComponent<Rigidbody>().transform.position.x, GetComponent<Rigidbody>().transform.position.y, 2.5f);
        if (GetComponent<Rigidbody>().transform.position.z == -3.5)
            GetComponent<Rigidbody>().transform.position = new Vector3(GetComponent<Rigidbody>().transform.position.x, GetComponent<Rigidbody>().transform.position.y, -2.5f);
        if (GetComponent<Rigidbody>().transform.position.x == 3.5)
            GetComponent<Rigidbody>().transform.position = new Vector3(2.5f, GetComponent<Rigidbody>().transform.position.y, GetComponent<Rigidbody>().transform.position.z);
        if (GetComponent<Rigidbody>().transform.position.x == -3.5)
            GetComponent<Rigidbody>().transform.position = new Vector3(-2.5f, GetComponent<Rigidbody>().transform.position.y, GetComponent<Rigidbody>().transform.position.z);
    }

    public void pausebutton()
    {
        if (paused == false)
        {
            Time.timeScale = 0f;
            paused = true;
        }
        else
        {
            Time.timeScale = 1f;
            paused = false;
        }
    }

    public void redleftarrow()
    {
        if (paused == false && GetComponent<Rigidbody>().transform.position.x != -3.5)
        {
            if (otherplayer.transform.position != new Vector3(GetComponent<Rigidbody>().transform.position.x - 1, otherplayer.transform.position.y, GetComponent<Rigidbody>().transform.position.z))
                GetComponent<Rigidbody>().transform.position += new Vector3(-1, 0, 0);
        }
        if (paused == false && GetComponent<Rigidbody>().transform.position.x == -3.5)
        {
            if (otherplayer.transform.position != new Vector3(GetComponent<Rigidbody>().transform.position.x + 6, otherplayer.transform.position.y, GetComponent<Rigidbody>().transform.position.z))
                GetComponent<Rigidbody>().transform.position += new Vector3(6, 0, 0);
        }
    }

    public void reddownarrow()
    {
        if (paused == false && GetComponent<Rigidbody>().transform.position.z != -3.5)
        {
            if (otherplayer.transform.position != new Vector3(GetComponent<Rigidbody>().transform.position.x, otherplayer.transform.position.y, GetComponent<Rigidbody>().transform.position.z - 1))
                GetComponent<Rigidbody>().transform.position += new Vector3(0, 0, -1);
        }
        if (paused == false && GetComponent<Rigidbody>().transform.position.z == -3.5)
        {
            if (otherplayer.transform.position != new Vector3(GetComponent<Rigidbody>().transform.position.x, otherplayer.transform.position.y, GetComponent<Rigidbody>().transform.position.z + 6))
                GetComponent<Rigidbody>().transform.position += new Vector3(0, 0, 6);
        }
    }

    public void redrightarrow()
    {
        if (paused == false && GetComponent<Rigidbody>().transform.position.x != 3.5)
        {
            if (otherplayer.transform.position != new Vector3(GetComponent<Rigidbody>().transform.position.x + 1, otherplayer.transform.position.y, GetComponent<Rigidbody>().transform.position.z))
                GetComponent<Rigidbody>().transform.position += new Vector3(1, 0, 0);
        }
        if (paused == false && GetComponent<Rigidbody>().transform.position.x == 3.5)
        {
            if (otherplayer.transform.position != new Vector3(GetComponent<Rigidbody>().transform.position.x - 6, otherplayer.transform.position.y, GetComponent<Rigidbody>().transform.position.z))
                GetComponent<Rigidbody>().transform.position += new Vector3(-6, 0, 0);
        }
    }

    public void reduparrow()
    {
        if (paused == false && GetComponent<Rigidbody>().transform.position.z != 3.5)
        {
            if (otherplayer.transform.position != new Vector3(GetComponent<Rigidbody>().transform.position.x, otherplayer.transform.position.y, GetComponent<Rigidbody>().transform.position.z + 1))
                GetComponent<Rigidbody>().transform.position += new Vector3(0, 0, 1);
        }
        if (paused == false && GetComponent<Rigidbody>().transform.position.z == 3.5)
        {
            if (otherplayer.transform.position != new Vector3(GetComponent<Rigidbody>().transform.position.x, otherplayer.transform.position.y, GetComponent<Rigidbody>().transform.position.z - 6))
                GetComponent<Rigidbody>().transform.position += new Vector3(0, 0, -6);
        }
    }
}
