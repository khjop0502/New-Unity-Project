using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour
{
    Renderer capsuleColor;
    public Transform cubePrefeb;

    void Start()
    {
        capsuleColor = gameObject.GetComponent<Renderer>();
        capsuleColor.material.color = Color.white;
    }
    void OnMouseEnter()
    {
        //Debug.Log("hello");
        capsuleColor.material.color = Color.blue;
    }
    void OnMouseExit()
    {
        capsuleColor.material.color = Color.white;
    }
    void OnMouseDown()
    {
        Vector3 playerPosition = new Vector3(transform.localPosition.x,1,transform.localPosition.z);
        //Transform player = Instantiate(cubePrefeb, playerPosition, Quaternion.Euler(Vector3.right)) as Transform;

        //Debug.Log("hello");
    }
}