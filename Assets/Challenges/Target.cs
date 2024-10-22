using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public int Priority;

    public Sprite[] Numbers;

    void Awake()
    {
        Priority = Random.Range(0, 9);

        GetComponent<SpriteRenderer>().sprite = Numbers[Priority];
    }
}
