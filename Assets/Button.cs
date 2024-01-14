using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public Animator button;
    public Animator toOpenLeft;
    public Animator toOpenRight;

    void Start()
    {
        button.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        button.enabled = true;
        toOpenLeft.enabled = true;
        toOpenRight.enabled = true;
    }
}
