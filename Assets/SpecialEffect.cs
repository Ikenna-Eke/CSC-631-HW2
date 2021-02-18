using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialEffect : MonoBehaviour
{
    [SerializeField] private Material myColor;


    // Update is called once per frame
   
    void OnControllerColliderHit(ControllerColliderHit hit)
    {
            Color random = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
            myColor.color = random;
    }
}
