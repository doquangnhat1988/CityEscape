using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallenToCharacter : MonoBehaviour
{
    [SerializeField]
    private float range;
    private bool isFalled;

    private void Awake()
    {
        isFalled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            if (!isFalled)
            {
                Animator fallAnim = GetComponent<Animator>();
                fallAnim.Play("BuildingFall");
                isFalled = true;
            }
        }
    }
}
