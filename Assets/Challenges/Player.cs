using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Player : MonoBehaviour
{
    public float Speed = 1;

    Transform[] _targets;

    int _targetIndex = 0;

    void Start()
    {
        // your code
    }

    void Update()
    {
        // your code
    }

    /* Challenge 1:
        - Modify the script so that the player moves towards each target in the scene based on the target's priority. The priority is a public field in the target script, with higher values indicating higher priority.
        - Ensure the player is always facing the direction of movement.
        - Once a target is reached, destroy it.
        - If no targets remain, stop the player's movement. If the scene starts with no targets, the player should remain idle.
     */

    //***************** Activate enemy in hierarchy to start challenge 3 **************
    /* Challenge 3:
        - In the Unity hierarchy, activate the `Enemy` object.
        - Modify the player's behavior so that while following its targets, the player must also avoid the enemy.
        - All previous challenge requirements must be met, except that when there are no more targets, the player should focus on avoiding the enemy.
        - The enemy moves at 1/3 of the player's speed to make it possible for the player to evade
        - **Bonus:** Consider adding visual or audio cues when the enemy gets too close to the player, enhancing the challenge.
    */
}
