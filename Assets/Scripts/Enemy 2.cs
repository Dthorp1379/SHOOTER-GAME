using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    public float moveSpeed = 3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move towards left of the screen
        transform.Translate(new Vector3(-1, -1, 0) * Time.deltaTime * moveSpeed);

        if (transform.position.y < -8f)
        {
            Destroy(this.gameObject);
        }

    }
}
