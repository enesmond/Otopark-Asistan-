using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aracVeri : Singleton<aracVeri>
{

    /*public Vector3 a1 = new Vector3(7.5f,0,-17.5f);
    public Vector3 a2 = new Vector3(4.5f, 0, -17.5f);
    public Vector3 a3 = new Vector3(1.5f, 0, -17.5f);
    public Vector3 a4 = new Vector3(-1.5f, 0, -17.5f);
    public Vector3 a5 = new Vector3(-4.5f, 0, -17.5f);
    public Vector3 a6 = new Vector3(-7.5f, 0, -17.5f);

    public Vector3 b1 = new Vector3(4.5f, 0, -8.5f);
    public Vector3 b2 = new Vector3(1.5f, 0, -8.5f);
    public Vector3 b3 = new Vector3(-1.5f, 0, -8.5f);
    public Vector3 b4 = new Vector3(-4.5f, 0, -8.5f);
    public Vector3 b5 = new Vector3(4.5f, 0, -4.5f);
    public Vector3 b6 = new Vector3(1.5f, 0, -4.5f);
    public Vector3 b7 = new Vector3(-1.5f, 0, -4.5f);
    public Vector3 b8 = new Vector3(-4.5f, 0, -4.5f);

    public Vector3 c1 = new Vector3(4.5f, 0, 4.5f);
    public Vector3 c2 = new Vector3(1.5f, 0, 4.5f);
    public Vector3 c3 = new Vector3(-1.5f, 0, 4.5f);
    public Vector3 c4 = new Vector3(-4.5f, 0, 4.5f);
    public Vector3 c5 = new Vector3(4.5f, 0, 8.5f);
    public Vector3 c6 = new Vector3(1.5f, 0, 8.5f);
    public Vector3 c7 = new Vector3(-1.5f, 0, 8.5f);
    public Vector3 c8 = new Vector3(-4.5f, 0, 8.5f);

    public Vector3 d1 = new Vector3(7.5f, 0, 17.5f);
    public Vector3 d2 = new Vector3(4.5f, 0, 17.5f);
    public Vector3 d3 = new Vector3(-4.5f, 0, 17.5f);
    public Vector3 d4 = new Vector3(-7.5f, 0, 17.5f);
    

    public GameObject a1;
    public GameObject araba1;
    public GameObject araba2;
    public GameObject araba3;
    */






    private void Start()
    {
        //nV = NavManage.Instance;
        ar1konum = new Vector3(0, 0, 0);
        ar2konum = new Vector3(0, 0, 0);
        ar3konum = new Vector3(0, 0, 0);
        //araba1 = nV.rotaCizilecekObje;
        //araba2 = nV.rotaCizilecekObje;
        //araba3 = nV.rotaCizilecekObje;
        //araba1 = GameObject.Find("araba1");
        //araba2 = GameObject.Find("araba2");
        //araba3 = GameObject.Find("araba3");
        //secim = "araba1";



    }

    








    private Vector3 _ar1konum;
    public Vector3 ar1konum
    {
        get
        {
            return _ar1konum;
        }
        set
        {
            if (value != _ar1konum)
            {

                
                
                /*if (value == "True")
                {

                    //objea1.transform.position = new Vector3(objea1.transform.position.x, 0f, objea1.transform.position.z);
                }
                else if (value == "False")
                {
                    //objea1.transform.position = new Vector3(objea1.transform.position.x, 100f, objea1.transform.position.z);
                }
                //GameObject.Find("s2").GetComponent<GameController>().status = true;
                */
            }
            _ar1konum = value;

            //Debug.Log("normal" + ar1konum.x.ToString());
            //Debug.Log("alt tireli" + _ar1konum.x.ToString());
        }
    }

    private Vector3 _ar2konum;
    public Vector3 ar2konum
    {
        get
        {
            return _ar2konum;
        }
        set
        {
            if (value != _ar2konum)
            {
                /*if (value == "True")
                {

                    //objea1.transform.position = new Vector3(objea1.transform.position.x, 0f, objea1.transform.position.z);
                }
                else if (value == "False")
                {
                    //objea1.transform.position = new Vector3(objea1.transform.position.x, 100f, objea1.transform.position.z);
                }
                //GameObject.Find("s2").GetComponent<GameController>().status = true;
                */
            }
            _ar2konum = value;
        }
    }





    private Vector3 _ar3konum;
    public Vector3 ar3konum
    {
        get
        {
            return _ar3konum;
        }
        set
        {
            if (value != _ar3konum)
            {
                /*if (value == "True")
                {

                    //objea1.transform.position = new Vector3(objea1.transform.position.x, 0f, objea1.transform.position.z);
                }
                else if (value == "False")
                {
                    //objea1.transform.position = new Vector3(objea1.transform.position.x, 100f, objea1.transform.position.z);
                }
                //GameObject.Find("s2").GetComponent<GameController>().status = true;
                */
            }
            _ar3konum = value;
        }
    }



    private string _secim;
    public string secim
    {
        get
        {
            return _secim;
        }
        set
        {
            if (value != _secim)
            {
                if (value == "araba1")
                {

                    Debug.Log("araba 1 secildi");
                   /* if(araba1!=null&&araba2!=null&& araba3 != null)
                    {
                        araba1.transform.position = new Vector3(araba1.transform.position.x, 0f, araba1.transform.position.z);
                        araba2.transform.position = new Vector3(araba2.transform.position.x, 100f, araba2.transform.position.z);
                        araba3.transform.position = new Vector3(araba3.transform.position.x, 100f, araba3.transform.position.z);

                        //objea1.transform.position = new Vector3(objea1.transform.position.x, 0f, objea1.transform.position.z);
                    }*/

                }
                else if (value == "araba2")
                {

                    Debug.Log("araba 2 secildi");
                    /*if (araba1 != null && araba2 != null && araba3 != null)
                    {
                        araba1.transform.position = new Vector3(araba1.transform.position.x, 100f, araba1.transform.position.z);
                        araba2.transform.position = new Vector3(araba2.transform.position.x, 0f, araba2.transform.position.z);
                        araba3.transform.position = new Vector3(araba3.transform.position.x, 100f, araba3.transform.position.z);
                    }*/
                        

                    //objea1.transform.position = new Vector3(objea1.transform.position.x, 100f, objea1.transform.position.z);
                }
                else if (value == "araba3")
                {

                    Debug.Log("araba 3 secildi");

                    /*if (araba1 != null && araba2 != null && araba3 != null)
                    {
                        araba1.transform.position = new Vector3(araba1.transform.position.x, 100f, araba1.transform.position.z);
                        araba2.transform.position = new Vector3(araba2.transform.position.x, 100f, araba2.transform.position.z);
                        araba3.transform.position = new Vector3(araba3.transform.position.x, 0f, araba3.transform.position.z);
                    }
                    
                     */
                    
                    //objea1.transform.position = new Vector3(objea1.transform.position.x, 0f, objea1.transform.position.z);
                }
                else
                {
                    Debug.Log("HATAAAAAAAAAAAAAAA!!!!!!!!!!!!!!");
                }



                //GameObject.Find("s2").GetComponent<GameController>().status = true;

            }
            _secim = value;
        }
    }


    private string _hedef;
    public string hedef
    {
        get
        {
            return _hedef;
        }
        set
        {
            if (value != _hedef)
            {
                /*if (value == "a1")
                {

                    hedefKonum = a1.transform.position;
                    //objea1.transform.position = new Vector3(objea1.transform.position.x, 0f, objea1.transform.position.z);
                }
                else if (value == "a2")
                {
                    hedefKonum = a2;
                    //objea1.transform.position = new Vector3(objea1.transform.position.x, 100f, objea1.transform.position.z);
                }
                else if (value == "a3")
                {
                    hedefKonum = a3;
                    //objea1.transform.position = new Vector3(objea1.transform.position.x, 100f, objea1.transform.position.z);
                }
                else if (value == "a4")
                {
                    hedefKonum = a4;
                    //objea1.transform.position = new Vector3(objea1.transform.position.x, 100f, objea1.transform.position.z);
                }
                else if (value == "a5")
                {
                    hedefKonum = a5;
                    //objea1.transform.position = new Vector3(objea1.transform.position.x, 100f, objea1.transform.position.z);
                }
                else if (value == "a6")
                {
                    hedefKonum = a6;
                    //objea1.transform.position = new Vector3(objea1.transform.position.x, 100f, objea1.transform.position.z);
                }
                else if (value == "b1")
                {
                    hedefKonum = b1;
                    //objea1.transform.position = new Vector3(objea1.transform.position.x, 100f, objea1.transform.position.z);
                }
                else if (value == "b2")
                {
                    hedefKonum = b2;
                    //objea1.transform.position = new Vector3(objea1.transform.position.x, 100f, objea1.transform.position.z);
                }
                else if (value == "b3")
                {
                    hedefKonum = b3;
                    //objea1.transform.position = new Vector3(objea1.transform.position.x, 100f, objea1.transform.position.z);
                }
                else if (value == "b4")
                {
                    hedefKonum = b4;
                    //objea1.transform.position = new Vector3(objea1.transform.position.x, 100f, objea1.transform.position.z);
                }
                else if (value == "b5")
                {
                    hedefKonum = b5;
                    //objea1.transform.position = new Vector3(objea1.transform.position.x, 100f, objea1.transform.position.z);
                }
                else if (value == "b6")
                {
                    hedefKonum = b6;
                    //objea1.transform.position = new Vector3(objea1.transform.position.x, 100f, objea1.transform.position.z);
                }
                else if (value == "b7")
                {
                    hedefKonum = b7;
                    //objea1.transform.position = new Vector3(objea1.transform.position.x, 100f, objea1.transform.position.z);
                }
                else if (value == "b8")
                {
                    hedefKonum = b8;
                    //objea1.transform.position = new Vector3(objea1.transform.position.x, 100f, objea1.transform.position.z);
                }
                else if (value == "c1")
                {
                    hedefKonum = c1;
                    //objea1.transform.position = new Vector3(objea1.transform.position.x, 100f, objea1.transform.position.z);
                }
                else if (value == "c2")
                {
                    hedefKonum = c2;
                    //objea1.transform.position = new Vector3(objea1.transform.position.x, 100f, objea1.transform.position.z);
                }
                else if (value == "c3")
                {
                    hedefKonum = c3;
                    //objea1.transform.position = new Vector3(objea1.transform.position.x, 100f, objea1.transform.position.z);
                }
                else if (value == "c4")
                {
                    hedefKonum = c4;
                    //objea1.transform.position = new Vector3(objea1.transform.position.x, 100f, objea1.transform.position.z);
                }
                else if (value == "c5")
                {
                    hedefKonum = c5;
                    //objea1.transform.position = new Vector3(objea1.transform.position.x, 100f, objea1.transform.position.z);
                }
                else if (value == "c6")
                {
                    hedefKonum = c6;
                    //objea1.transform.position = new Vector3(objea1.transform.position.x, 100f, objea1.transform.position.z);
                }
                else if (value == "c7")
                {
                    hedefKonum = c7;
                    //objea1.transform.position = new Vector3(objea1.transform.position.x, 100f, objea1.transform.position.z);
                }
                else if (value == "c8")
                {
                    hedefKonum = c8;
                    //objea1.transform.position = new Vector3(objea1.transform.position.x, 100f, objea1.transform.position.z);
                }
                else if (value == "d1")
                {
                    hedefKonum = d1;
                    //objea1.transform.position = new Vector3(objea1.transform.position.x, 100f, objea1.transform.position.z);
                }
                else if (value == "d2")
                {
                    hedefKonum = d2;
                    //objea1.transform.position = new Vector3(objea1.transform.position.x, 100f, objea1.transform.position.z);
                }
                else if (value == "d3")
                {
                    hedefKonum = d3;
                    //objea1.transform.position = new Vector3(objea1.transform.position.x, 100f, objea1.transform.position.z);
                }
                else if (value == "d4")
                {
                    hedefKonum = d4;
                    //objea1.transform.position = new Vector3(objea1.transform.position.x, 100f, objea1.transform.position.z);
                }*/




            }
            _hedef = value;
        }
    }


    private Vector3 _hedefKonum;
    public Vector3 hedefKonum
    {
        get
        {
            return _hedefKonum;
        }
        set
        {
            if (value != _hedefKonum)
            {
                /*if (value == "True")
                {

                    //objea1.transform.position = new Vector3(objea1.transform.position.x, 0f, objea1.transform.position.z);
                }
                else if (value == "False")
                {
                    //objea1.transform.position = new Vector3(objea1.transform.position.x, 100f, objea1.transform.position.z);
                }
                //GameObject.Find("s2").GetComponent<GameController>().status = true;
                */
            }
            _hedefKonum = value;
        }
    }


    private string _enIyıHedef;
    public string enIyıHedef
    {
        get
        {
            return _enIyıHedef;
        }
        set
        {
            if (value != _enIyıHedef)
            {

                if (value == "yok")
                {
                    Debug.Log("En iyi hedef yok");
                }
                /*if (value == "True")
                {

                    //objea1.transform.position = new Vector3(objea1.transform.position.x, 0f, objea1.transform.position.z);
                }
                else if (value == "False")
                {
                    //objea1.transform.position = new Vector3(objea1.transform.position.x, 100f, objea1.transform.position.z);
                }
                //GameObject.Find("s2").GetComponent<GameController>().status = true;
                */
            }
            _enIyıHedef = value;
        }
    }

}
