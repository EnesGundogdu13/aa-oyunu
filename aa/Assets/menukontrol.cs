using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menukontrol : MonoBehaviour
{
    public void oyunagecis()
    {
        int kayitlilevel = PlayerPrefs.GetInt("Kayit");
        if (kayitlilevel==0)
        {
            SceneManager.LoadScene(kayitlilevel + 1);
        }
        else
        {
            SceneManager.LoadScene(kayitlilevel);
        }
    }
    public void cikis()
    {
        Application.Quit();
    }

    public void leveller()
    {
        SceneManager.LoadScene("Leveller");
    }
}
