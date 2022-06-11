using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathUIManager : MonoBehaviour
{
    public void PlayAgainButton()
    {
      SceneManager.LoadScene("Level1");
    }

    public void BackButton()
    {
      SceneManager.LoadScene("MainMenu");
    }
}
