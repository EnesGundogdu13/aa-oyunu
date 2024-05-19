using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anacember : MonoBehaviour
{
    public GameObject kucukcember;
    GameObject OyunYoneticisi;
    void Start()
    {
        OyunYoneticisi = GameObject.FindGameObjectWithTag("oyunyoneticisitag");
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            kucukcemberolustur();
        }
    }
    void kucukcemberolustur()
    {
        Instantiate(kucukcember, transform.position, transform.rotation);
        OyunYoneticisi.GetComponent<oyunyoneticisikod>().kcemberdetextgoster();
    }


}
