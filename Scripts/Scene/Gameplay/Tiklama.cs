using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiklama : MonoBehaviour
{
    public GameObject obje;
    public void tiklama()
    {  
        if (obje.transform.position.y >= -0.1f && obje.transform.position.y <= 0.2f)
        {
            obje.transform.position = new Vector3(obje.transform.position.x,
                100f, obje.transform.position.z);
        }
        else
        {
            obje.transform.position = new Vector3(obje.transform.position.x, 0f,
                obje.transform.position.z);
        }
    }
}
