using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector2 playerPosition = new Vector2 (0,0);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      Movement();
    }

    private void Movement()
    {
      playerPosition = transform.localPosition;

      // UpArrow and 'W' Key Input
      if (Input.GetKeyDown(KeyCode.UpArrow))
      {
        this.transform.rotation = Quaternion.Euler(0, 0, 0);
        playerPosition= playerPosition + Vector2.up;

      }

      else if (Input.GetKeyDown(KeyCode.W))
      {
        this.transform.rotation = Quaternion.Euler(0, 0, 0);
        playerPosition+= Vector2.up;

      }

      // DownArrow and 'S' Key Input
      else if (Input.GetKeyDown(KeyCode.DownArrow))
      {
        this.transform.rotation = Quaternion.Euler(0, 0, 180);
        playerPosition+= Vector2.down;
      }

      else if (Input.GetKeyDown(KeyCode.S))
      {
        this.transform.rotation = Quaternion.Euler(0, 0, 180);
        playerPosition+= Vector2.down;
      }

      // RightArrow and 'D' Key Input
      else if (Input.GetKeyDown(KeyCode.RightArrow))
      {
        this.transform.rotation = Quaternion.Euler(0, 0, -90);
        playerPosition+= Vector2.right;
      }

      else if (Input.GetKeyDown(KeyCode.D))
      {
        this.transform.rotation = Quaternion.Euler(0, 0, -90);
        playerPosition+= Vector2.right;
      }

      // LeftArrow and 'A' Key Input
      else if (Input.GetKeyDown(KeyCode.LeftArrow))
      {
        this.transform.rotation = Quaternion.Euler(0, 0, 90);
        playerPosition+= Vector2.left;
      }

      else if (Input.GetKeyDown(KeyCode.A))
      {
        this.transform.rotation = Quaternion.Euler(0, 0, 90);
        playerPosition+= Vector2.left;
      }

      transform.localPosition = playerPosition;
    }
}
