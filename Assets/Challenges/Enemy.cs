using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Player _player;

    void Start()
    {
        _player = FindAnyObjectByType<Player>();
    }

    void Update()
    {
        if (_player != null)
        {
            var dir = _player.transform.position - transform.position;
            transform.position += dir.normalized * (_player.Speed / 3) * Time.deltaTime;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
    }
}
