using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NavigasyonSahnesi : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject objea1;
    public GameObject objea2;
    public GameObject objea3;
    public GameObject objea4;
    public GameObject objea5;
    public GameObject objea6;
    public GameObject objeb1;
    public GameObject objeb2;
    public GameObject objeb3;
    public GameObject objeb4;
    public GameObject objeb5;
    public GameObject objeb6;
    public GameObject objeb7;
    public GameObject objeb8;
    public GameObject objec1;
    public GameObject objec2;
    public GameObject objec3;
    public GameObject objec4;
    public GameObject objec5;
    public GameObject objec6;
    public GameObject objec7;
    public GameObject objec8;
    public GameObject objed1;
    public GameObject objed2;
    public GameObject objed3;
    public GameObject objed4;

    public parkYeriVeri pyv;
    public NavManage nM;


   

    void Start()
    {

       
        pyv = parkYeriVeri.Instance;
        





    }
    void Update()
    {
        pyv.objea1 = objea1;
        pyv.objea2 = objea2;
        pyv.objea3 = objea3;
        pyv.objea4 = objea4;
        pyv.objea5 = objea5;
        pyv.objea6 = objea6;


        pyv.objeb1 = objeb1;
        pyv.objeb2 = objeb2;
        pyv.objeb3 = objeb3;
        pyv.objeb4 = objeb4;
        pyv.objeb5 = objeb5;
        pyv.objeb6 = objeb6;
        pyv.objeb7 = objeb7;
        pyv.objeb8 = objeb8;


        pyv.objec1 = objec1;
        pyv.objec2 = objec2;
        pyv.objec3 = objec3;
        pyv.objec4 = objec4;
        pyv.objec5 = objec5;
        pyv.objec6 = objec6;
        pyv.objec7 = objec7;
        pyv.objec8 = objec8;

        pyv.objed1 = objed1;
        pyv.objed2 = objed2;
        pyv.objed3 = objed3;
        pyv.objed4 = objed4;

        
        
    }
    

}
