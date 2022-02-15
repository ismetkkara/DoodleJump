using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.GetComponent<Rigidbody2D>().velocity.y <= 0)
        {
            col.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 70f);
        }
    }
}
