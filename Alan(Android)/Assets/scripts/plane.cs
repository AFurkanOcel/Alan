using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;

public class plane : MonoBehaviour
{
    public int blackcount = 0;
    public int redcount = 0;
    public float time = 0;

    public TextMeshProUGUI blackcounttext;
    public TextMeshProUGUI redcounttext;
    public TextMeshProUGUI timetext;

    public GameObject player;
    public GameObject player2;
    public GameObject blackcup;
    public GameObject redcup;
    public GameObject leftcup;
    public GameObject rightcup;

    public Material plane0;
    public Material plane1;
    public Material plane2;
    public Material plane3;
    public Material plane4;
    public Material plane5;
    public Material plane6;
    public Material plane7;
    public Material plane8;
    public Material plane9;
    public Material plane10;
    public Material plane11;
    public Material plane12;
    public Material plane13;
    public Material plane14;
    public Material plane15;
    public Material plane16;
    public Material plane17;
    public Material plane18;
    public Material plane19;
    public Material plane20;
    public Material plane21;
    public Material plane22;
    public Material plane23;
    public Material plane24;
    public Material plane25;
    public Material plane26;
    public Material plane27;
    public Material plane28;
    public Material plane29;
    public Material plane30;
    public Material plane31;
    public Material plane32;
    public Material plane33;
    public Material plane34;
    public Material plane35;

    public Material[] planedizi;

    void Start()
    {
        Time.timeScale = 1f;

        blackcup.SetActive(false);
        redcup.SetActive(false);
        leftcup.SetActive(false);
        rightcup.SetActive(false);

        plane0.color = Color.white;
        plane1.color = Color.white;
        plane2.color = Color.white;
        plane3.color = Color.white;
        plane4.color = Color.white;
        plane5.color = Color.white;
        plane6.color = Color.white;
        plane7.color = Color.white;
        plane8.color = Color.white;
        plane9.color = Color.white;
        plane10.color = Color.white;
        plane11.color = Color.white;
        plane12.color = Color.white;
        plane13.color = Color.white;
        plane14.color = Color.white;
        plane15.color = Color.white;
        plane16.color = Color.white;
        plane17.color = Color.white;
        plane18.color = Color.white;
        plane19.color = Color.white;
        plane20.color = Color.white;
        plane21.color = Color.white;
        plane22.color = Color.white;
        plane23.color = Color.white;
        plane24.color = Color.white;
        plane25.color = Color.white;
        plane26.color = Color.white;
        plane27.color = Color.white;
        plane28.color = Color.white;
        plane29.color = Color.white;
        plane30.color = Color.white;
        plane31.color = Color.white;
        plane32.color = Color.white;
        plane33.color = Color.white;
        plane34.color = Color.white;
        plane35.color = Color.white;

        planedizi = new Material[36];

        planedizi[0] = plane0;

        planedizi[1] = plane1;
        planedizi[2] = plane2;
        planedizi[3] = plane3;
        planedizi[4] = plane4;
        planedizi[5] = plane5;
        planedizi[6] = plane6;
        planedizi[7] = plane7;
        planedizi[8] = plane8;
        planedizi[9] = plane9;
        planedizi[10] = plane10;
        planedizi[11] = plane11;
        planedizi[12] = plane12;
        planedizi[13] = plane13;
        planedizi[14] = plane14;
        planedizi[15] = plane15;
        planedizi[16] = plane16;
        planedizi[17] = plane17;
        planedizi[18] = plane18;
        planedizi[19] = plane19;
        planedizi[20] = plane20;
        planedizi[21] = plane21;
        planedizi[22] = plane22;
        planedizi[23] = plane23;
        planedizi[24] = plane24;
        planedizi[25] = plane25;
        planedizi[26] = plane26;
        planedizi[27] = plane27;
        planedizi[28] = plane28;
        planedizi[29] = plane29;
        planedizi[30] = plane30;
        planedizi[31] = plane31;
        planedizi[32] = plane32;
        planedizi[33] = plane33;
        planedizi[34] = plane34;
        planedizi[35] = plane35;

        Invoke("planecode", 5f);
        Invoke("planecode", 10f);
        Invoke("planecode", 15f);
        Invoke("planecode", 20f);
        Invoke("planecode", 25f);
        Invoke("planecode", 30f);
        Invoke("planecode", 35f);
        Invoke("planecode", 40f);
        Invoke("planecode", 45f);
        Invoke("planecode", 50f);
        Invoke("planecode", 55f);
        Invoke("planecode", 60f);
        Invoke("planecode", 65f);
        Invoke("planecode", 70f);
        Invoke("planecode", 75f);
        Invoke("planecode", 80f);
        Invoke("planecode", 85f);
        Invoke("planecode", 90f);
        Invoke("planecode", 95f);
        Invoke("planecode", 100f);
        Invoke("planecode", 105f);
        Invoke("planecode", 110f);
        Invoke("planecode", 115f);
        Invoke("planecode", 120f);
        Invoke("planecode", 125f);
        Invoke("planecode", 130f);
        Invoke("planecode", 135f);
        Invoke("planecode", 140f);
        Invoke("planecode", 145f);
        Invoke("planecode", 150f);
        Invoke("planecode", 155f);
        Invoke("planecode", 160f);
        Invoke("planecode", 165f);
        Invoke("planecode", 170f);
        Invoke("planecode", 175f);
        Invoke("planecode", 180f);
    }

    private void FixedUpdate()
    {
        time += Time.deltaTime;

        blackcounttext.text = "" + blackcount;
        redcounttext.text = "" + redcount;

        if (blackcount + redcount == 36)
        {
            Invoke("winner", 0f);
        }
        else
        {
            timetext.text = "" + (int)time;
        }
    }

    void Update()
    {
        //line1
        if(plane0.color == Color.blue && player.transform.position == new Vector3(-2.5f,player.transform.position.y, 2.5f))
        {
            plane0.color = Color.gray;
            blackcount++;
        }
        if (plane0.color == Color.blue && player2.transform.position == new Vector3(-2.5f, player2.transform.position.y, 2.5f))
        {
            plane0.color = Color.magenta;
            redcount++;
        }

        if (plane1.color == Color.blue && player.transform.position == new Vector3(-1.5f, player.transform.position.y, 2.5f))
        {
            plane1.color = Color.gray;
            blackcount++;
        }
        if (plane1.color == Color.blue && player2.transform.position == new Vector3(-1.5f, player2.transform.position.y, 2.5f))
        {
            plane1.color = Color.magenta;
            redcount++;
        }

        if (plane2.color == Color.blue && player.transform.position == new Vector3(-0.5f, player.transform.position.y, 2.5f))
        {
            plane2.color = Color.gray;
            blackcount++;
        }
        if (plane2.color == Color.blue && player2.transform.position == new Vector3(-0.5f, player2.transform.position.y, 2.5f))
        {
            plane2.color = Color.magenta;
            redcount++;
        }

        if (plane3.color == Color.blue && player.transform.position == new Vector3(0.5f, player.transform.position.y, 2.5f))
        {
            plane3.color = Color.gray;
            blackcount++;
        }
        if (plane3.color == Color.blue && player2.transform.position == new Vector3(0.5f, player2.transform.position.y, 2.5f))
        {
            plane3.color = Color.magenta;
            redcount++;
        }

        if (plane4.color == Color.blue && player.transform.position == new Vector3(1.5f, player.transform.position.y, 2.5f))
        {
            plane4.color = Color.gray;
            blackcount++;
        }
        if (plane4.color == Color.blue && player2.transform.position == new Vector3(1.5f, player2.transform.position.y, 2.5f))
        {
            plane4.color = Color.magenta;
            redcount++;
        }

        if (plane5.color == Color.blue && player.transform.position == new Vector3(2.5f, player.transform.position.y, 2.5f))
        {
            plane5.color = Color.gray;
            blackcount++;
        }
        if (plane5.color == Color.blue && player2.transform.position == new Vector3(2.5f, player2.transform.position.y, 2.5f))
        {
            plane5.color = Color.magenta;
            redcount++;
        }


        //line2
        if (plane6.color == Color.blue && player.transform.position == new Vector3(-2.5f, player.transform.position.y, 1.5f))
        {
            plane6.color = Color.gray;
            blackcount++;
        }
        if (plane6.color == Color.blue && player2.transform.position == new Vector3(-2.5f, player2.transform.position.y, 1.5f))
        {
            plane6.color = Color.magenta;
            redcount++;
        }

        if (plane7.color == Color.blue && player.transform.position == new Vector3(-1.5f, player.transform.position.y, 1.5f))
        {
            plane7.color = Color.gray;
            blackcount++;
        }
        if (plane7.color == Color.blue && player2.transform.position == new Vector3(-1.5f, player2.transform.position.y, 1.5f))
        {
            plane7.color = Color.magenta;
            redcount++;
        }

        if (plane8.color == Color.blue && player.transform.position == new Vector3(-0.5f, player.transform.position.y, 1.5f))
        {
            plane8.color = Color.gray;
            blackcount++;
        }
        if (plane8.color == Color.blue && player2.transform.position == new Vector3(-0.5f, player2.transform.position.y, 1.5f))
        {
            plane8.color = Color.magenta;
            redcount++;
        }

        if (plane9.color == Color.blue && player.transform.position == new Vector3(0.5f, player.transform.position.y, 1.5f))
        {
            plane9.color = Color.gray;
            blackcount++;
        }
        if (plane9.color == Color.blue && player2.transform.position == new Vector3(0.5f, player2.transform.position.y, 1.5f))
        {
            plane9.color = Color.magenta;
            redcount++;
        }

        if (plane10.color == Color.blue && player.transform.position == new Vector3(1.5f, player.transform.position.y, 1.5f))
        {
            plane10.color = Color.gray;
            blackcount++;
        }
        if (plane10.color == Color.blue && player2.transform.position == new Vector3(1.5f, player2.transform.position.y, 1.5f))
        {
            plane10.color = Color.magenta;
            redcount++;
        }

        if (plane11.color == Color.blue && player.transform.position == new Vector3(2.5f, player.transform.position.y, 1.5f))
        {
            plane11.color = Color.gray;
            blackcount++;
        }
        if (plane11.color == Color.blue && player2.transform.position == new Vector3(2.5f, player2.transform.position.y, 1.5f))
        {
            plane11.color = Color.magenta;
            redcount++;
        }


        //line3
        if (plane12.color == Color.blue && player.transform.position == new Vector3(-2.5f, player.transform.position.y, 0.5f))
        {
            plane12.color = Color.gray;
            blackcount++;
        }
        if (plane12.color == Color.blue && player2.transform.position == new Vector3(-2.5f, player2.transform.position.y, 0.5f))
        {
            plane12.color = Color.magenta;
            redcount++;
        }

        if (plane13.color == Color.blue && player.transform.position == new Vector3(-1.5f, player.transform.position.y, 0.5f))
        {
            plane13.color = Color.gray;
            blackcount++;
        }
        if (plane13.color == Color.blue && player2.transform.position == new Vector3(-1.5f, player2.transform.position.y, 0.5f))
        {
            plane13.color = Color.magenta;
            redcount++;
        }

        if (plane14.color == Color.blue && player.transform.position == new Vector3(-0.5f, player.transform.position.y, 0.5f))
        {
            plane14.color = Color.gray;
            blackcount++;
        }
        if (plane14.color == Color.blue && player2.transform.position == new Vector3(-0.5f, player2.transform.position.y, 0.5f))
        {
            plane14.color = Color.magenta;
            redcount++;
        }

        if (plane15.color == Color.blue && player.transform.position == new Vector3(0.5f, player.transform.position.y, 0.5f))
        {
            plane15.color = Color.gray;
            blackcount++;
        }
        if (plane15.color == Color.blue && player2.transform.position == new Vector3(0.5f, player2.transform.position.y, 0.5f))
        {
            plane15.color = Color.magenta;
            redcount++;
        }

        if (plane16.color == Color.blue && player.transform.position == new Vector3(1.5f, player.transform.position.y, 0.5f))
        {
            plane16.color = Color.gray;
            blackcount++;
        }
        if (plane16.color == Color.blue && player2.transform.position == new Vector3(1.5f, player2.transform.position.y, 0.5f))
        {
            plane16.color = Color.magenta;
            redcount++;
        }

        if (plane17.color == Color.blue && player.transform.position == new Vector3(2.5f, player.transform.position.y, 0.5f))
        {
            plane17.color = Color.gray;
            blackcount++;
        }
        if (plane17.color == Color.blue && player2.transform.position == new Vector3(2.5f, player2.transform.position.y, 0.5f))
        {
            plane17.color = Color.magenta;
            redcount++;
        }


        //line4
        if (plane18.color == Color.blue && player.transform.position == new Vector3(-2.5f, player.transform.position.y, -0.5f))
        {
            plane18.color = Color.gray;
            blackcount++;
        }
        if (plane18.color == Color.blue && player2.transform.position == new Vector3(-2.5f, player2.transform.position.y, -0.5f))
        {
            plane18.color = Color.magenta;
            redcount++;
        }

        if (plane19.color == Color.blue && player.transform.position == new Vector3(-1.5f, player.transform.position.y, -0.5f))
        {
            plane19.color = Color.gray;
            blackcount++;
        }
        if (plane19.color == Color.blue && player2.transform.position == new Vector3(-1.5f, player2.transform.position.y, -0.5f))
        {
            plane19.color = Color.magenta;
            redcount++;
        }

        if (plane20.color == Color.blue && player.transform.position == new Vector3(-0.5f, player.transform.position.y, -0.5f))
        {
            plane20.color = Color.gray;
            blackcount++;
        }
        if (plane20.color == Color.blue && player2.transform.position == new Vector3(-0.5f, player2.transform.position.y, -0.5f))
        {
            plane20.color = Color.magenta;
            redcount++;
        }

        if (plane21.color == Color.blue && player.transform.position == new Vector3(0.5f, player.transform.position.y, -0.5f))
        {
            plane21.color = Color.gray;
            blackcount++;
        }
        if (plane21.color == Color.blue && player2.transform.position == new Vector3(0.5f, player2.transform.position.y, -0.5f))
        {
            plane21.color = Color.magenta;
            redcount++;
        }

        if (plane22.color == Color.blue && player.transform.position == new Vector3(1.5f, player.transform.position.y, -0.5f))
        {
            plane22.color = Color.gray;
            blackcount++;
        }
        if (plane22.color == Color.blue && player2.transform.position == new Vector3(1.5f, player2.transform.position.y, -0.5f))
        {
            plane22.color = Color.magenta;
            redcount++;
        }

        if (plane23.color == Color.blue && player.transform.position == new Vector3(2.5f, player.transform.position.y, -0.5f))
        {
            plane23.color = Color.gray;
            blackcount++;
        }
        if (plane23.color == Color.blue && player2.transform.position == new Vector3(2.5f, player2.transform.position.y, -0.5f))
        {
            plane23.color = Color.magenta;
            redcount++;
        }


        //line5
        if (plane24.color == Color.blue && player.transform.position == new Vector3(-2.5f, player.transform.position.y, -1.5f))
        {
            plane24.color = Color.gray;
            blackcount++;
        }
        if (plane24.color == Color.blue && player2.transform.position == new Vector3(-2.5f, player2.transform.position.y, -1.5f))
        {
            plane24.color = Color.magenta;
            redcount++;
        }

        if (plane25.color == Color.blue && player.transform.position == new Vector3(-1.5f, player.transform.position.y, -1.5f))
        {
            plane25.color = Color.gray;
            blackcount++;
        }
        if (plane25.color == Color.blue && player2.transform.position == new Vector3(-1.5f, player2.transform.position.y, -1.5f))
        {
            plane25.color = Color.magenta;
            redcount++;
        }

        if (plane26.color == Color.blue && player.transform.position == new Vector3(-0.5f, player.transform.position.y, -1.5f))
        {
            plane26.color = Color.gray;
            blackcount++;
        }
        if (plane26.color == Color.blue && player2.transform.position == new Vector3(-0.5f, player2.transform.position.y, -1.5f))
        {
            plane26.color = Color.magenta;
            redcount++;
        }

        if (plane27.color == Color.blue && player.transform.position == new Vector3(0.5f, player.transform.position.y, -1.5f))
        {
            plane27.color = Color.gray;
            blackcount++;
        }
        if (plane27.color == Color.blue && player2.transform.position == new Vector3(0.5f, player2.transform.position.y, -1.5f))
        {
            plane27.color = Color.magenta;
            redcount++;
        }

        if (plane28.color == Color.blue && player.transform.position == new Vector3(1.5f, player.transform.position.y, -1.5f))
        {
            plane28.color = Color.gray;
            blackcount++;
        }
        if (plane28.color == Color.blue && player2.transform.position == new Vector3(1.5f, player2.transform.position.y, -1.5f))
        {
            plane28.color = Color.magenta;
            redcount++;
        }

        if (plane29.color == Color.blue && player.transform.position == new Vector3(2.5f, player.transform.position.y, -1.5f))
        {
            plane29.color = Color.gray;
            blackcount++;
        }
        if (plane29.color == Color.blue && player2.transform.position == new Vector3(2.5f, player2.transform.position.y, -1.5f))
        {
            plane29.color = Color.magenta;
            redcount++;
        }


        //line6
        if (plane30.color == Color.blue && player.transform.position == new Vector3(-2.5f, player.transform.position.y, -2.5f))
        {
            plane30.color = Color.gray;
            blackcount++;
        }
        if (plane30.color == Color.blue && player2.transform.position == new Vector3(-2.5f, player2.transform.position.y, -2.5f))
        {
            plane30.color = Color.magenta;
            redcount++;
        }

        if (plane31.color == Color.blue && player.transform.position == new Vector3(-1.5f, player.transform.position.y, -2.5f))
        {
            plane31.color = Color.gray;
            blackcount++;
        }
        if (plane31.color == Color.blue && player2.transform.position == new Vector3(-1.5f, player2.transform.position.y, -2.5f))
        {
            plane31.color = Color.magenta;
            redcount++;
        }

        if (plane32.color == Color.blue && player.transform.position == new Vector3(-0.5f, player.transform.position.y, -2.5f))
        {
            plane32.color = Color.gray;
            blackcount++;
        }
        if (plane32.color == Color.blue && player2.transform.position == new Vector3(-0.5f, player2.transform.position.y, -2.5f))
        {
            plane32.color = Color.magenta;
            redcount++;
        }

        if (plane33.color == Color.blue && player.transform.position == new Vector3(0.5f, player.transform.position.y, -2.5f))
        {
            plane33.color = Color.gray;
            blackcount++;
        }
        if (plane33.color == Color.blue && player2.transform.position == new Vector3(0.5f, player2.transform.position.y, -2.5f))
        {
            plane33.color = Color.magenta;
            redcount++;
        }

        if (plane34.color == Color.blue && player.transform.position == new Vector3(1.5f, player.transform.position.y, -2.5f))
        {
            plane34.color = Color.gray;
            blackcount++;
        }
        if (plane34.color == Color.blue && player2.transform.position == new Vector3(1.5f, player2.transform.position.y, -2.5f))
        {
            plane34.color = Color.magenta;
            redcount++;
        }

        if (plane35.color == Color.blue && player.transform.position == new Vector3(2.5f, player.transform.position.y, -2.5f))
        {
            plane35.color = Color.gray;
            blackcount++;
        }
        if (plane35.color == Color.blue && player2.transform.position == new Vector3(2.5f, player2.transform.position.y, -2.5f))
        {
            plane35.color = Color.magenta;
            redcount++;
        }
    }

    void planecode()
    {
        int kura = Random.Range(0, 36);
        if(planedizi[kura].color == Color.white)
        {
            planedizi[kura].color = Color.blue;
        }
        else
        {
            Invoke("planecode", 0f);
        }
    }

    void winner()
    {
        player.SetActive(false);
        player2.SetActive(false);

        if (blackcount > redcount)
        {
            blackcup.SetActive(true);
        }
        else if (redcount > blackcount)
        {
            redcup.SetActive(true);
        }
        else
        {
            leftcup.SetActive(true);
            rightcup.SetActive(true);
        }
    }
}
