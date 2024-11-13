using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YBoundary : MonoBehaviour
{
    private float minY = -5f; // Set your lower limit
    private float maxY = 0f;  // Set your upper limit

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Sets the horizontal movement
        transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime, 0, 0);

        // Sets the vertical movement
        float inputY = Input.GetAxis("Vertical") * Time.deltaTime;
        Vector3 newPosition = transform.position + new Vector3(0, inputY, 0);

        // Sets boundary and restricts vertical movement within the minY and maxY
        if (newPosition.y < minY)
            newPosition.y = minY;
        else if (newPosition.y > maxY)
            newPosition.y = maxY;

        // Applies the y boundary created by the newPosition to the player
        transform.position = newPosition;

    }
}
