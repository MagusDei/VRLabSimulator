using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {

    public GameObject destroyed;

    void OnMouseDown()
    {
        Instantiate(destroyed, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
