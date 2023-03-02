using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public GameObject explosion;
    // Add a logic of the code here

    public void destroyExplosion()
    {
        Destroy(this.gameObject);
    }
}
