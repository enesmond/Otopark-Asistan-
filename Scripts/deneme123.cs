using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class deneme123 : MonoBehaviour
{
    // Start is called before the first frame update
    public Button buton;
    public aracVeri aV;
    public string yazi;

    void Start()
    {
        aV = aracVeri.Instance;

        yazi = aV.enIyıHedef;

        buton.GetComponent<Button>().GetComponentInChildren<Text>().text = yazi;
    }
}
