using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levelkontrol : MonoBehaviour
{
    public void level1()
    {
        SceneManager.LoadScene("1");
    }
    public void level2()
    {
        int level = PlayerPrefs.GetInt("Kayit");
        level += 1;
        if (level>2)
        {
            SceneManager.LoadScene("2");
        }
        else
        {
            Debug.Log("Lütfen önceki levelleri tamamlayýn!");
        }
    }
    public void level3()
    {
        int level = PlayerPrefs.GetInt("Kayit");
        level += 1;
        if (level > 3)
        {
            SceneManager.LoadScene("3");
        }
        else
        {
            Debug.Log("Lütfen önceki levelleri tamamlayýn!");
        }
    }
    public void level4()
    {
        int level = PlayerPrefs.GetInt("Kayit");
        level += 1;
        if (level > 4)
        {
            SceneManager.LoadScene("4");
        }
        else
        {
            Debug.Log("Lütfen önceki levelleri tamamlayýn!");
        }
    }
    public void level5()
    {
        int level = PlayerPrefs.GetInt("Kayit");
        level += 1;
        if (level > 5)
        {
            SceneManager.LoadScene("5");
        }
        else
        {
            Debug.Log("Lütfen önceki levelleri tamamlayýn!");
        }
    }
    public void level6()
    {
        int level = PlayerPrefs.GetInt("Kayit");
        level += 1;
        if (level > 6)
        {
            SceneManager.LoadScene("6");
        }
        else
        {
            Debug.Log("Lütfen önceki levelleri tamamlayýn!");
        }
    }
    public void Menudon()
    {
        SceneManager.LoadScene("AnaMenu");
    }
}
