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

    [SerializeField]
    private float initialDelay = 5f;

    [SerializeField]
    private Player _player;

    [SerializeField]
    private Camera _mainCamera;

    private float _spawnTime;

    private void Start()
    {
        InvokeRepeating("SpawnObject", initialDelay, GetSpawnTime());
    }

    private void Update()
    {

    }

    private float GetSpawnTime()
    {
        return Random.Range(_mixSpawnTime, _maxSpawnTime);
    }

    private void SpawnObject()
    {
        Target newTarget =  Instantiate(_targetPrefab, _targetsParent.transform);
        newTarget.transform.position = GetRandomPositionInCameraView();
        newTarget.transform.position = new Vector3(newTarget.transform.position.x, newTarget.transform.position.y, 0f);
        _player.AddNewTargets(newTarget.transform);
    }

    private Vector3 GetRandomPositionInCameraView()
    {
        // Generate random screen position in the camera's viewport (0 to 1)
        float randomX = Random.Range(0f, 1f);
        float randomY = Random.Range(0f, 1f);

        // Convert the viewport position to world position
        Vector3 viewportPoint = new Vector3(randomX, randomY, 0f); // Z = 1 to spawn in front of the camera
        Vector3 worldPoint = _mainCamera.ViewportToWorldPoint(viewportPoint);

        return worldPoint;
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