using UnityEngine;
using System.Linq;
using System.Collections.Generic;

public class Player : MonoBehaviour
{
    public float Speed = 1;

    [SerializeField] Transform[] _targets = new Transform[5];
    private List<Transform> _newTargets = new List<Transform>();
    public List<Transform> tempTargets = new List<Transform>();

    private Transform currentTarget;

    private int _targetIndex = 0;
    private int currentTargetIndex = 0;

    private void Start()
    {
        SetSortedTargets();
    }

    private void Update()
    {
        if(currentTarget != null)
            MoveTowardsTarget();
    }

    private void SetSortedTargets()
    {
        SortTargetsByPriority();
        NextTarget();
    }
    private void SortTargetsByPriority()
    {
        // Sort targets by priority (highest number = highest priority)
        _targets = _targets.OrderByDescending(a => a.GetComponent<Target>().Priority).ToArray();
    }
    private void NextTarget()
    {
        if (currentTargetIndex >= _targets.Length)
        {
            currentTarget = null;
            return;
        }

        currentTarget = _targets[currentTargetIndex];
        Debug.Log(_targets[currentTargetIndex].gameObject, _targets[currentTargetIndex].gameObject);
    }

    private void MoveTowardsTarget()
    {
        // Rotate the player to face the target
        transform.right = currentTarget.position - transform.position;

        // Move player towards the target
        transform.position = Vector2.MoveTowards(transform.position, currentTarget.position, Speed * Time.deltaTime);

        // Check if the player reached the target
        if (Vector2.Distance(transform.position, currentTarget.position) < 0.1f)
        {
            DestroyTarget();
            NextTarget();
        }
    }
    private void DestroyTarget()
    {
        tempTargets = _targets.ToList();
        tempTargets.RemoveAt(currentTargetIndex);
        _targets = tempTargets.ToArray();
        Destroy(currentTarget.gameObject);
    }

    public void AddNewTargets(Transform Target)
    {
        _newTargets.Add(Target);
        SetNewTargets();
    }
    private void SetNewTargets()
    {
        _newTargets.AddRange(_targets.ToList());

        _targets = _newTargets.ToArray();
        _newTargets.Clear();

        SetSortedTargets();
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
