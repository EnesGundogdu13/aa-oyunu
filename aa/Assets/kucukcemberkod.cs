using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kucukcemberkod : MonoBehaviour
{   
    public float hiz;
    Rigidbody2D fizik;
    bool hareketkontrol = false;
    GameObject oyunYoneticisi;
    void Start()
    {
        fizik = GetComponent<Rigidbody2D>();
        oyunYoneticisi = GameObject.FindGameObjectWithTag("oyunyoneticisitag");
    }

    void FixedUpdate()
    {
        if (hareketkontrol==false)
        {
            fizik.MovePosition(fizik.position + Vector2.up * hiz * Time.deltaTime);
        }

    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag=="donencembertag")
        {
            transform.SetParent(col.transform);
            hareketkontrol=true;
        }
        if (col.tag=="kucukcembertag")
        {
            oyunYoneticisi.GetComponent<oyunyoneticisikod>().oyunbitti();
        }
    }
}
