using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rotaYoksa : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject panel4;
    
    public aracVeri aV;
    void Start()
    {
        aV = aracVeri.Instance;
        //panel4 = GameObject.FindGameObjectWithTag("canvas4");
        if (aV.hedef == "yok")
        {
            panel4.SetActive(true);
        }

    }

    
}
