using Firebase;
using Firebase.Database;
using Firebase.Unity.Editor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class parkYeriVeri : Singleton<parkYeriVeri>
{

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

    public DBManager db;

    
    

    /*public string MyFloat
    {
        get
        {
            return _myFloat;
        }
        set
        {
            if (_myFloat == value) return;
            _myFloat = value;
            if (OnVariableChange != null)
                OnVariableChange(_myFloat);
        }
    }
    */

    

    private string _a1;
    public string a1
    {
        get
        {
            return _a1;
        }
        set
        {
            if (value != _a1)
            {
                if (value == "True")
                {

                    //objea1.transform.position = new Vector3(objea1.transform.position.x, 0f, objea1.transform.position.z);
                }
                else if (value == "False")
                {
                    //objea1.transform.position = new Vector3(objea1.transform.position.x, 100f, objea1.transform.position.z);
                }
                //GameObject.Find("s2").GetComponent<GameController>().status = true;
            }
            _a1 = value;
        }
    }


    private string _a2;
    public string a2
    {
        get
        {
            return _a2;
        }
        set
        {
            if (value != _a2)
            {
                if (value == "True")
                {

                    //objea2.transform.position = new Vector3(objea2.transform.position.x, 0f, objea2.transform.position.z);
                }
                else if (value == "False")
                {
                    //objea2.transform.position = new Vector3(objea2.transform.position.x, 100f, objea2.transform.position.z);
                }
                //GameObject.Find("s2").GetComponent<GameController>().status = true;
            }
            _a2 = value;
        }
    }

    private string _a3;
    public string a3
    {
        get
        {
            return _a3;
        }
        set
        {
            if (value != _a3)
            {
                if (value == "True")
                {

                    // objea3.transform.position = new Vector3(objea3.transform.position.x, 0f, objea3.transform.position.z);
                }
                else if (value == "False")
                {
                    //objea3.transform.position = new Vector3(objea3.transform.position.x, 100f, objea3.transform.position.z);
                }
                //GameObject.Find("s2").GetComponent<GameController>().status = true;
            }
            _a3 = value;
        }
    }

    private string _a4;
    public string a4
    {
        get
        {
            return _a4;
        }
        set
        {
            if (value != _a4)
            {
                if (value == "True")
                {

                    // objea4.transform.position = new Vector3(objea4.transform.position.x, 0f, objea4.transform.position.z);
                }
                else if (value == "False")
                {
                    //objea4.transform.position = new Vector3(objea4.transform.position.x, 100f, objea4.transform.position.z);
                }
                //GameObject.Find("s2").GetComponent<GameController>().status = true;
            }
            _a4 = value;
        }
    }


    private string _a5;
    public string a5
    {
        get
        {
            return _a5;
        }
        set
        {
            if (value != _a5)
            {
                if (value == "True")
                {

                    //objea5.transform.position = new Vector3(objea5.transform.position.x, 0f, objea5.transform.position.z);
                }
                else if (value == "False")
                {
                    //objea5.transform.position = new Vector3(objea5.transform.position.x, 100f, objea5.transform.position.z);
                }
                //GameObject.Find("s2").GetComponent<GameController>().status = true;
            }
            _a5 = value;
        }
    }

    private string _a6;
    public string a6
    {
        get
        {
            return _a6;
        }
        set
        {
            if (value != _a6)
            {
                if (value == "True")
                {

                    //objea6.transform.position = new Vector3(objea6.transform.position.x, 0f, objea6.transform.position.z);
                }
                else if (value == "False")
                {
                    //objea6.transform.position = new Vector3(objea6.transform.position.x, 100f, objea6.transform.position.z);
                }
                //GameObject.Find("s2").GetComponent<GameController>().status = true;
            }
            _a6 = value;
        }
    }

    private string _b1;
    public string b1
    {
        get
        {
            return _b1;
        }
        set
        {
            if (value != _b1)
            {
                if (value == "True")
                {

                    //objeb1.transform.position = new Vector3(objeb1.transform.position.x, 0f, objeb1.transform.position.z);
                }
                else if (value == "False")
                {
                    //objeb1.transform.position = new Vector3(objeb1.transform.position.x, 100f, objeb1.transform.position.z);
                }
                //GameObject.Find("s2").GetComponent<GameController>().status = true;
            }
            _b1 = value;
        }
    }

    private string _b2;
    public string b2
    {
        get
        {
            return _b2;
        }
        set
        {
            if (value != _b2)
            {
                if (value == "True")
                {

                    //objeb2.transform.position = new Vector3(objeb2.transform.position.x, 0f, objeb2.transform.position.z);
                }
                else if (value == "False")
                {
                    //objeb2.transform.position = new Vector3(objeb2.transform.position.x, 100f, objeb2.transform.position.z);
                }
                //GameObject.Find("s2").GetComponent<GameController>().status = true;
            }
            _b2 = value;
        }
    }


    private string _b3;
    public string b3
    {
        get
        {
            return _b3;
        }
        set
        {
            if (value != _b3)
            {
                if (value == "True")
                {

                    //objeb3.transform.position = new Vector3(objeb3.transform.position.x, 0f, objeb3.transform.position.z);
                }
                else if (value == "False")
                {
                    //objeb3.transform.position = new Vector3(objeb3.transform.position.x, 100f, objeb3.transform.position.z);
                }
                //GameObject.Find("s2").GetComponent<GameController>().status = true;
            }
            _b3 = value;
        }
    }


    private string _b4;
    public string b4
    {
        get
        {
            return _b4;
        }
        set
        {
            if (value != _b4)
            {
                if (value == "True")
                {

                    //objeb4.transform.position = new Vector3(objeb4.transform.position.x, 0f, objeb4.transform.position.z);
                }
                else if (value == "False")
                {
                    //objeb4.transform.position = new Vector3(objeb4.transform.position.x, 100f, objeb4.transform.position.z);
                }
                //GameObject.Find("s2").GetComponent<GameController>().status = true;
            }
            _b4 = value;
        }
    }


    private string _b5;
    public string b5
    {
        get
        {
            return _b5;
        }
        set
        {
            if (value != _b5)
            {
                if (value == "True")
                {

                    //objeb5.transform.position = new Vector3(objeb5.transform.position.x, 0f, objeb5.transform.position.z);
                }
                else if (value == "False")
                {
                    //objeb5.transform.position = new Vector3(objeb5.transform.position.x, 100f, objeb5.transform.position.z);
                }
                //GameObject.Find("s2").GetComponent<GameController>().status = true;
            }
            _b5 = value;
        }
    }

    private string _b6;
    public string b6
    {
        get
        {
            return _b6;
        }
        set
        {
            if (value != _b6)
            {
                if (value == "True")
                {

                    //objeb6.transform.position = new Vector3(objeb6.transform.position.x, 0f, objeb6.transform.position.z);
                }
                else if (value == "False")
                {
                    //objeb6.transform.position = new Vector3(objeb6.transform.position.x, 100f, objeb6.transform.position.z);
                }
                //GameObject.Find("s2").GetComponent<GameController>().status = true;
            }
            _b6 = value;
        }
    }


    private string _b7;
    public string b7
    {
        get
        {
            return _b7;
        }
        set
        {
            if (value != _b7)
            {
                if (value == "True")
                {

                    //objeb7.transform.position = new Vector3(objeb7.transform.position.x, 0f, objeb7.transform.position.z);
                }
                else if (value == "False")
                {
                    //objeb7.transform.position = new Vector3(objeb7.transform.position.x, 100f, objeb7.transform.position.z);
                }
                //GameObject.Find("s2").GetComponent<GameController>().status = true;
            }
            _b7 = value;
        }
    }


    private string _b8;
    public string b8
    {
        get
        {
            return _b8;
        }
        set
        {
            if (value != _b8)
            {
                if (value == "True")
                {

                    // objeb8.transform.position = new Vector3(objeb8.transform.position.x, 0f, objeb8.transform.position.z);
                }
                else if (value == "False")
                {
                    //objeb8.transform.position = new Vector3(objeb8.transform.position.x, 100f, objeb8.transform.position.z);
                }
                //GameObject.Find("s2").GetComponent<GameController>().status = true;
            }
            _b8 = value;
        }
    }


    private string _c1;
    public string c1
    {
        get
        {
            return _c1;
        }
        set
        {
            if (value != _c1)
            {
                if (value == "True")
                {

                    //objec1.transform.position = new Vector3(objec1.transform.position.x, 0f, objec1.transform.position.z);
                }
                else if (value == "False")
                {
                    //objec1.transform.position = new Vector3(objec1.transform.position.x, 100f, objec1.transform.position.z);
                }
                //GameObject.Find("s2").GetComponent<GameController>().status = true;
            }
            _c1 = value;
        }
    }

    private string _c2;
    public string c2
    {
        get
        {
            return _c2;
        }
        set
        {
            if (value != _c2)
            {
                if (value == "True")
                {

                    // objec2.transform.position = new Vector3(objec2.transform.position.x, 0f, objec2.transform.position.z);
                }
                else if (value == "False")
                {
                    //objec2.transform.position = new Vector3(objec2.transform.position.x, 100f, objec2.transform.position.z);
                }
                //GameObject.Find("s2").GetComponent<GameController>().status = true;
            }
            _c2 = value;
        }
    }

    private string _c3;
    public string c3
    {
        get
        {
            return _c3;
        }
        set
        {
            if (value != _c3)
            {
                if (value == "True")
                {

                    //objec3.transform.position = new Vector3(objec3.transform.position.x, 0f, objec3.transform.position.z);
                }
                else if (value == "False")
                {
                    //objec3.transform.position = new Vector3(objec3.transform.position.x, 100f, objec3.transform.position.z);
                }
                //GameObject.Find("s2").GetComponent<GameController>().status = true;
            }
            _c3 = value;
        }
    }

    private string _c4;
    public string c4
    {
        get
        {
            return _c4;
        }
        set
        {
            if (value != _c4)
            {
                if (value == "True")
                {

                    //objec4.transform.position = new Vector3(objec4.transform.position.x, 0f, objec4.transform.position.z);
                }
                else if (value == "False")
                {
                    //objec4.transform.position = new Vector3(objec4.transform.position.x, 100f, objec4.transform.position.z);
                }
                //GameObject.Find("s2").GetComponent<GameController>().status = true;
            }
            _c4 = value;
        }
    }

    private string _c5;
    public string c5
    {
        get
        {
            return _c5;
        }
        set
        {
            if (value != _c5)
            {
                if (value == "True")
                {

                    // objec5.transform.position = new Vector3(objec5.transform.position.x, 0f, objec5.transform.position.z);
                }
                else if (value == "False")
                {
                    // objec5.transform.position = new Vector3(objec5.transform.position.x, 100f, objec5.transform.position.z);
                }
                //GameObject.Find("s2").GetComponent<GameController>().status = true;
            }
            _c5 = value;
        }
    }

    private string _c6;
    public string c6
    {
        get
        {
            return _c6;
        }
        set
        {
            if (value != _c6)
            {
                if (value == "True")
                {

                    // objec6.transform.position = new Vector3(objec6.transform.position.x, 0f, objec6.transform.position.z);
                }
                else if (value == "False")
                {
                    // objec6.transform.position = new Vector3(objec6.transform.position.x, 100f, objec6.transform.position.z);
                }
                //GameObject.Find("s2").GetComponent<GameController>().status = true;
            }
            _c6 = value;
        }
    }

    private string _c7;
    public string c7
    {
        get
        {
            return _c7;
        }
        set
        {
            if (value != _c7)
            {
                if (value == "True")
                {

                    // objec7.transform.position = new Vector3(objec7.transform.position.x, 0f, objec7.transform.position.z);
                }
                else if (value == "False")
                {
                    // objec7.transform.position = new Vector3(objec7.transform.position.x, 100f, objec7.transform.position.z);
                }
                //GameObject.Find("s2").GetComponent<GameController>().status = true;
            }
            _c7 = value;
        }
    }


    private string _c8;
    public string c8
    {
        get
        {
            return _c8;
        }
        set
        {
            if (value != _c8)
            {
                if (value == "True")
                {

                    // objec8.transform.position = new Vector3(objec8.transform.position.x, 0f, objec8.transform.position.z);
                }
                else if (value == "False")
                {
                    // objec8.transform.position = new Vector3(objec8.transform.position.x, 100f, objec8.transform.position.z);
                }
                //GameObject.Find("s2").GetComponent<GameController>().status = true;
            }
            _c8 = value;
        }
    }

    private string _d1;
    public string d1
    {
        get
        {
            return _d1;
        }
        set
        {
            if (value != _d1)
            {
                if (value == "True")
                {

                    // objed1.transform.position = new Vector3(objed1.transform.position.x, 0f, objed1.transform.position.z);
                }
                else if (value == "False")
                {
                    // objed1.transform.position = new Vector3(objed1.transform.position.x, 100f, objed1.transform.position.z);
                }
                //GameObject.Find("s2").GetComponent<GameController>().status = true;
            }
            _d1 = value;
        }
    }

    private string _d2;
    public string d2
    {
        get
        {
            return _d2;
        }
        set
        {
            if (value != _d2)
            {
                if (value == "True")
                {

                    // objed2.transform.position = new Vector3(objed2.transform.position.x, 0f, objed2.transform.position.z);
                }
                else if (value == "False")
                {
                    //objed2.transform.position = new Vector3(objed2.transform.position.x, 100f, objed2.transform.position.z);
                }
                //GameObject.Find("s2").GetComponent<GameController>().status = true;
            }
            _d2 = value;
        }
    }

    private string _d3;
    public string d3
    {
        get
        {
            return _d3;
        }
        set
        {
            if (value != _d3)
            {
                if (value == "True")
                {

                    //objed3.transform.position = new Vector3(objed3.transform.position.x, 0f, objed3.transform.position.z);
                }
                else if (value == "False")
                {
                    //objed3.transform.position = new Vector3(objed3.transform.position.x, 100f, objed3.transform.position.z);
                }
                //GameObject.Find("s2").GetComponent<GameController>().status = true;
            }
            _d3 = value;
        }
    }

    private string _d4;
    public string d4
    {
        get
        {
            return _d4;
        }
        set
        {
            if (value != _d4)
            {
                if (value == "True")
                {

                    //objed4.transform.position = new Vector3(objed4.transform.position.x, 0f, objed4.transform.position.z);
                }
                else if (value == "False")
                {
                    //objed4.transform.position = new Vector3(objed4.transform.position.x, 100f, objed4.transform.position.z);
                }
                //GameObject.Find("s2").GetComponent<GameController>().status = true;
            }
            _d4 = value;
        }
    }
    /*public string a1;
    public string a2;
    public string a3;
    public string a4;
    public string a5;
    public string a6;

    public string b1;
    public string b2;
    public string b3;
    public string b4;
    public string b5;
    public string b6;
    public string b7;
    public string b8;

    public string c1;
    public string c2;
    public string c3;
    public string c4;
    public string c5;
    public string c6;
    public string c7;
    public string c8;

    public string d1;
    public string d2;
    public string d3;
    public string d4;
    */


    void Start()
    {
        db = DBManager.Instance;
        //dbdb = db.parkReference;

        //db.bilgiAlParkYerleri(this.name, obje);




    }

    void Update()
    {
        if (a1 == "True")
        {
            objea1.transform.position = new Vector3(objea1.transform.position.x, 0f, objea1.transform.position.z);
        }
        else if (a1 == "False")
        {
            objea1.transform.position = new Vector3(objea1.transform.position.x, 100f, objea1.transform.position.z);
        }

        if (a2 == "True")
        {
            objea2.transform.position = new Vector3(objea2.transform.position.x, 0f, objea2.transform.position.z);
        }
        else if (a2 == "False")
        {
            objea2.transform.position = new Vector3(objea2.transform.position.x, 100f, objea2.transform.position.z);
        }
        if (a3 == "True")
        {
            objea3.transform.position = new Vector3(objea3.transform.position.x, 0f, objea3.transform.position.z);
        }
        else if (a3 == "False")
        {
            objea3.transform.position = new Vector3(objea3.transform.position.x, 100f, objea3.transform.position.z);
        }
        if (a4 == "True")
        {
            objea4.transform.position = new Vector3(objea4.transform.position.x, 0f, objea4.transform.position.z);
        }
        else if (a4 == "False")
        {
            objea4.transform.position = new Vector3(objea4.transform.position.x, 100f, objea4.transform.position.z);
        }
        if (a5 == "True")
        {
            objea5.transform.position = new Vector3(objea5.transform.position.x, 0f, objea5.transform.position.z);
        }
        else if (a5 == "False")
        {
            objea5.transform.position = new Vector3(objea5.transform.position.x, 100f, objea5.transform.position.z);
        }
        if (a6 == "True")
        {
            objea6.transform.position = new Vector3(objea6.transform.position.x, 0f, objea6.transform.position.z);
        }
        else if (a6 == "False")
        {
            objea6.transform.position = new Vector3(objea6.transform.position.x, 100f, objea6.transform.position.z);
        }
        if (b1 == "True")
        {
            objeb1.transform.position = new Vector3(objeb1.transform.position.x, 0f, objeb1.transform.position.z);
        }
        else if (b1 == "False")
        {
            objeb1.transform.position = new Vector3(objeb1.transform.position.x, 100f, objeb1.transform.position.z);
        }
        if (b2 == "True")
        {
            objeb2.transform.position = new Vector3(objeb2.transform.position.x, 0f, objeb2.transform.position.z);
        }
        else if (b2 == "False")
        {
            objeb2.transform.position = new Vector3(objeb2.transform.position.x, 100f, objeb2.transform.position.z);
        }
        if (b3 == "True")
        {
            objeb3.transform.position = new Vector3(objeb3.transform.position.x, 0f, objeb3.transform.position.z);
        }
        else if (b3 == "False")
        {
            objeb3.transform.position = new Vector3(objeb3.transform.position.x, 100f, objeb3.transform.position.z);
        }
        if (b4 == "True")
        {
            objeb4.transform.position = new Vector3(objeb4.transform.position.x, 0f, objeb4.transform.position.z);
        }
        else if (b4 == "False")
        {
            objeb4.transform.position = new Vector3(objeb4.transform.position.x, 100f, objeb4.transform.position.z);
        }
        if (b5 == "True")
        {
            objeb5.transform.position = new Vector3(objeb5.transform.position.x, 0f, objeb5.transform.position.z);
        }
        else if (b5 == "False")
        {
            objeb5.transform.position = new Vector3(objeb5.transform.position.x, 100f, objeb5.transform.position.z);
        }
        if (b6 == "True")
        {
            objeb6.transform.position = new Vector3(objeb6.transform.position.x, 0f, objeb6.transform.position.z);

        }
        else if (b6 == "False")
        {
            objeb6.transform.position = new Vector3(objeb6.transform.position.x, 100f, objeb6.transform.position.z);
        }
        if (b7 == "True")
        {
            objeb7.transform.position = new Vector3(objeb7.transform.position.x, 0f, objeb7.transform.position.z);
        }
        else if (b7 == "False")
        {
            objeb7.transform.position = new Vector3(objeb7.transform.position.x, 100f, objeb7.transform.position.z);

        }
        if (b8 == "True")
        {
            objeb8.transform.position = new Vector3(objeb8.transform.position.x, 0f, objeb8.transform.position.z);
        }
        else if (b8 == "False")
        {
            objeb8.transform.position = new Vector3(objeb8.transform.position.x, 100f, objeb8.transform.position.z);
        }



        if (c1 == "True")
        {
            objec1.transform.position = new Vector3(objec1.transform.position.x, 0f, objec1.transform.position.z);
        }
        else if (c1 == "False")
        {
            objec1.transform.position = new Vector3(objec1.transform.position.x, 100f, objec1.transform.position.z);
        }
        if (c2 == "True")
        {
            objec2.transform.position = new Vector3(objec2.transform.position.x, 0f, objec2.transform.position.z);
        }
        else if (c2 == "False")
        {
            objec2.transform.position = new Vector3(objec2.transform.position.x, 100f, objec2.transform.position.z);
        }
        if (c3 == "True")
        {
            objec3.transform.position = new Vector3(objec3.transform.position.x, 0f, objec3.transform.position.z);
        }
        else if (c3 == "False")
        {
            objec3.transform.position = new Vector3(objec3.transform.position.x, 100f, objec3.transform.position.z);
        }
        if (c4 == "True")
        {
            objec4.transform.position = new Vector3(objec4.transform.position.x, 0f, objec4.transform.position.z);
        }
        else if (c4 == "False")
        {
            objec4.transform.position = new Vector3(objec4.transform.position.x, 100f, objec4.transform.position.z);
        }
        if (c5 == "True")
        {
            objec5.transform.position = new Vector3(objec5.transform.position.x, 0f, objec5.transform.position.z);
        }
        else if (c5 == "False")
        {
            objec5.transform.position = new Vector3(objec5.transform.position.x, 100f, objec5.transform.position.z);
        }
        if (c6 == "True")
        {
            objec6.transform.position = new Vector3(objec6.transform.position.x, 0f, objec6.transform.position.z);
        }
        else if (c6 == "False")
        {
            objec6.transform.position = new Vector3(objec6.transform.position.x, 100f, objec6.transform.position.z);
        }
        if (c7 == "True")
        {
            objec7.transform.position = new Vector3(objec7.transform.position.x, 0f, objec7.transform.position.z);
        }
        else if (c7 == "False")
        {
            objec7.transform.position = new Vector3(objec7.transform.position.x, 100f, objec7.transform.position.z);
        }
        if (c8 == "True")
        {
            objec8.transform.position = new Vector3(objec8.transform.position.x, 0f, objec8.transform.position.z);
        }
        else if (c8 == "False")
        {
            objec8.transform.position = new Vector3(objec8.transform.position.x, 100f, objec8.transform.position.z);
        }



        if (d1 == "True")
        {
            objed1.transform.position = new Vector3(objed1.transform.position.x, 0f, objed1.transform.position.z);
        }
        else if (d1 == "False")
        {
            objed1.transform.position = new Vector3(objed1.transform.position.x, 100f, objed1.transform.position.z);

        }
        if (d2 == "True")
        {
            objed2.transform.position = new Vector3(objed2.transform.position.x, 0f, objed2.transform.position.z);
        }
        else if (d2 == "False")
        {
            objed2.transform.position = new Vector3(objed2.transform.position.x, 100f, objed2.transform.position.z);
        }
        if (d3 == "True")
        {
            objed3.transform.position = new Vector3(objed3.transform.position.x, 0f, objed3.transform.position.z);
        }
        else if (d3 == "False")
        {
            objed3.transform.position = new Vector3(objed3.transform.position.x, 100f, objed3.transform.position.z);
        }
        if (d4 == "True")
        {
            objed4.transform.position = new Vector3(objed4.transform.position.x, 0f, objed4.transform.position.z);
        }
        else if (d4 == "False")
        {
            objed4.transform.position = new Vector3(objed4.transform.position.x, 100f, objed4.transform.position.z);
        }
    }








    public void yolla()
    {

        //dbdb = FirebaseDatabase.DefaultInstance.GetReference("park");
        //db.bilgiAlParkYeri("a1");


        Debug.Log("a1"+a1);
        Debug.Log("a2"+a2);
        Debug.Log("a3"+a3);
        Debug.Log("a4"+a4);
    }



}
