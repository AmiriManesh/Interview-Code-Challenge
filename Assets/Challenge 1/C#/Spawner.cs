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
     *Write a spawner for spawning new targets.
     *targets must spawn with a random delay in given range
     *player must follow new targget like other targets.
     *new target must be in the camra view range.
     *Bounes: write a simple event system to tell theplayer
     *a new target was added to the scene
     */
}
