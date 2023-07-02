using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursorScript : MonoBehaviour
{
    // Start is called before the first frame update
    private Camera mainCamera;

    private void Start()
    {
        mainCamera = Camera.main;
    }

    private void Update()
    {
        // Get the position of the cursor in screen space
        Vector3 cursorScreenPosition = Input.mousePosition;

        // Convert the screen space position to world space
        Vector3 cursorWorldPosition = mainCamera.ScreenToWorldPoint(cursorScreenPosition);
        cursorWorldPosition.z = 0f; // Make sure the sprite stays on the 2D plane

        // Set the position of the sprite to the cursor position
        transform.position = cursorWorldPosition;
    }
}
