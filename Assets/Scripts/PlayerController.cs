using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Vector2 position = this.transform.position;
            position.y += .01f;
            this.transform.position = position;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            Vector2 position = this.transform.position;
            position.y -= .01f;
            this.transform.position = position;
        }

        if (Input.GetKey(KeyCode.D))
        {
            Vector2 position = this.transform.position;
            position.x += .01f;
            this.transform.position = position;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            Vector2 position = this.transform.position;
            position.x -= .01f;
            this.transform.position = position;
        }
    }
}
