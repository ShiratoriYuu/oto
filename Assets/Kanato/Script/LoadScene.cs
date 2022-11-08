using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void LD1()
    {
        SceneManager.LoadScene("Kanato1Scene");
    }
    public void LD2()
    {
        SceneManager.LoadScene("Kanato2Scene");
    }
}
