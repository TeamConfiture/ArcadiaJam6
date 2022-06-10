using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jouer : MonoBehaviour
{
    
    public void PushPlay(string NomScene)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(NomScene);
    }

}
