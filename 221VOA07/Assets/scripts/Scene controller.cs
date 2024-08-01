using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenecontroller : MonoBehaviour
{
    public void SwitchScene(string Scenename)
    {
        SceneManager.LoadScene(Scenename);
    }

}
