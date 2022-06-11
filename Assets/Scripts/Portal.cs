using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
  public string levelName = "";

  private void OnTriggerEnter2D(Collider2D other)
   {
     if (other.gameObject.tag == "Player"){
      SceneManager.LoadScene(levelName);
     }
   }
}
