using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shurikencollision : MonoBehaviour
{
    public GameObject Shuriken1;
    public GameObject Shuriken2;
    public GameObject Crush1;
    public GameObject Crush2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(Crush1);
        }
        if (collision.gameObject.tag == "Enemy2")
        {
            Destroy(Crush2);
        }
    }
}
