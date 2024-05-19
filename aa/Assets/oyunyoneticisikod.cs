using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class oyunyoneticisikod : MonoBehaviour
{
    GameObject donencember;
    GameObject Anacember;
    public Animator animator;
    public Text DonenCemberLevel;
    public Text bir;
    public Text iki;
    public Text uc;
    public int kackuccemberolsun;
    bool kontrol = true;
    void Start()
    {
        PlayerPrefs.SetInt("Kayit",int.Parse(SceneManager.GetActiveScene().name));
        donencember = GameObject.FindGameObjectWithTag("donencembertag");
        Anacember = GameObject.FindGameObjectWithTag("anacembertag");
        DonenCemberLevel.text = SceneManager.GetActiveScene().name;
        if (kackuccemberolsun<2)
        {
            bir.text = kackuccemberolsun.ToString();
        }
        else if (kackuccemberolsun<3)
        {
            bir.text = kackuccemberolsun.ToString();
            iki.text = (kackuccemberolsun - 1).ToString();
        }
        else
        {
            bir.text = kackuccemberolsun.ToString();
            iki.text = (kackuccemberolsun - 1).ToString();
            uc.text = (kackuccemberolsun - 2).ToString();
        }
    }

    public void kcemberdetextgoster()
    {
        kackuccemberolsun--;
        if (kackuccemberolsun < 2)
        {
            bir.text = kackuccemberolsun.ToString();
            iki.text = "";
        }
        else if (kackuccemberolsun < 3)
        {
            bir.text = kackuccemberolsun.ToString();
            iki.text = (kackuccemberolsun - 1).ToString();
            uc.text = "";
        }
        else
        {
            bir.text = kackuccemberolsun.ToString();
            iki.text = (kackuccemberolsun - 1).ToString();
            uc.text = (kackuccemberolsun - 2).ToString();
        }
        if (kackuccemberolsun <= 0)
        {
            StartCoroutine(yenilevel());
        }
    }

    IEnumerator yenilevel()
    {
        donencember.GetComponent<dondurme>().enabled = false;
        Anacember.GetComponent<anacember>().enabled = false;
        yield return new WaitForSeconds(0.5f);
        if (kontrol)
        {
            animator.SetTrigger("yenilevel");
            yield return new WaitForSeconds(1.5f);
            int deger = (int.Parse(SceneManager.GetActiveScene().name) + 1);
            SceneManager.LoadScene(deger);
            if (deger ==7)
            {
                SceneManager.LoadScene("AnaMenu");
            }
        }
        
    }

    public void oyunbitti()
    {
        StartCoroutine(cagrilanmetot());
    }

    IEnumerator cagrilanmetot()
    {
        donencember.GetComponent<dondurme>().enabled = false;
        Anacember.GetComponent <anacember>().enabled = false;
        animator.SetTrigger("oyunbitti");
        kontrol = false;
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("AnaMenu");
    }
}
