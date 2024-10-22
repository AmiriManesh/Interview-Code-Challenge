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

    /*Challenge 1:
     *Modify the script to get the player to follow each 
     *target inside the scene based on targets priority,
     *player must facing in the direction he is moving.
     *when there is no more target stop the player.
     *destroy target whenever reach it.
     */

    //***************** Activate enemy in hierarchy to start challenge 3 **************
    /*Challenge 1:
    *avoid the enemy while the player following its
    *targets, all previous challenge must be past in this one exept
    *when where is no more targer the player must avoid enemy
    *enemy move this 1/3 of the player speed
    */
}
