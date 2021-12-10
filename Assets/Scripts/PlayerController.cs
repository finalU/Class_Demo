using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int score = 0;
    

    private void Start()
    {
        meshRenderer.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            score++;
        }
        elif(other.gameObject.CompareTag("Finish"))
        {
            if(score == 15)
            {
                other.gameObject.SetActive(false);
                meshRenderer.enabled = true;
            }
        }
    }
}
