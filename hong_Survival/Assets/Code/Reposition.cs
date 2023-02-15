using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reposition : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerExit2D(Collider2D collision)
    {
        if(!collision.CompareTag("Area")) {
            return;


        }
    }
}
