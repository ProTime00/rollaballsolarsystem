using System.Collections;
using System.Collections.Generic;
    {
        // Calculate the initial offset between the camera's position and the player's position.
        offset = transform.position - player.transform.position; 
    }

    // LateUpdate is called once per frame after all Update functions have been completed.
    void LateUpdate()
    {
        // Maintain the same offset between the camera and player throughout the game.
        transform.position = player.transform.position + offset;  
    }
}

