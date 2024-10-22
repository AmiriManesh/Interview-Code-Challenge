using System.Collections;
using System.Collections.Generic;
using UnityEditor.IMGUI.Controls;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private Target _targetPrefab;

    [SerializeField]
    private GameObject _targetsParent;

    [SerializeField]
    private float _mixSpawnTime;

    [SerializeField]
    private float _maxSpawnTime;

    // your code

    void Start()
    {
        // your code

    }

    void Update()
    {
        // your code
    }

    //***************** Activate spawner in hierarchy to start challenge 2 **************

    /*Challenge 2: 
        - In the Unity hierarchy, activate the `Spawner` object.
        - Modify spawner script to spawn new targets.
        - Targets must spawn with a random delay, using two fields in the spawner script: `_minSpawnTime` and `_maxSpawnTime`. These fields define the range for the random delay.
        - Ensure the player follows newly spawned targets just like existing targets.
        - New targets must spawn within the camera's view range.
        - **Bonus:** Implement a simple event system to notify the player when a new target is added to the scene.
     */
}
