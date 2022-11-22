using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript: MonoBehaviour
{
    public GameObject Enemydude;
    public GameObject keydude;
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D other)
    {
       Destroy(Enemydude);
     Destroy(keydude);
    }
}
