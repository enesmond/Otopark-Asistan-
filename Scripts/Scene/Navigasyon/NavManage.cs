using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class NavManage : MonoBehaviour
{
    [SerializeField] public string selectableTag = "arac";
    [SerializeField] public Material highlightMaterial;
    [SerializeField] public Material defaultMaterial;
    public NavMeshAgent agent1;
    public NavMeshAgent agent2;
    public NavMeshAgent agent3;
    public GameObject araba1;
    public GameObject araba2;
    public GameObject araba3;

    public GameObject hedefa1;
    public GameObject hedefa2;
    public GameObject hedefa3;
    public GameObject hedefa4;
    public GameObject hedefa5;
    public GameObject hedefa6;

    public GameObject hedefb1;
    public GameObject hedefb2;
    public GameObject hedefb3;
    public GameObject hedefb4;
    public GameObject hedefb5;
    public GameObject hedefb6;
    public GameObject hedefb7;
    public GameObject hedefb8;

    public GameObject hedefc1;
    public GameObject hedefc2;
    public GameObject hedefc3;
    public GameObject hedefc4;
    public GameObject hedefc5;
    public GameObject hedefc6;
    public GameObject hedefc7;
    public GameObject hedefc8;

    public GameObject hedefd1;
    public GameObject hedefd2;
    public GameObject hedefd3;
    public GameObject hedefd4;

    public GameObject panel;
    public GameObject panel2;
    public GameObject panel3;
    public Canvas canvas;
    public Canvas canvas2;
    public Canvas canvas3;

    public Vector3 myHedef;
    public Vector3 geciciHedef;

    
    public Vector3 suanKiKonum;

    public float distance = 3f;

    public string seciliArabaAdi;

    public bool update=false;



    //public NavMeshAgent agent4;
    public Camera cam;
    public GameObject rotaCizilecekObje;
    public LineRenderer myLineRenderer;
    public NavMeshAgent myAgent;
    public aracVeri aV;
    public parkYeriVeri pyv;
    public DBManager db;

    //public NavMeshPath NavMeshPath;
    //public GameObject araba1;

    public string secilmisArac = "";
    
    public int x = 0;
    public int y = 0;



    //private Transform _selection;



    void Awake()
    {
        
    }

    void Start()
    {
        db = DBManager.Instance;
        aV = aracVeri.Instance;
        pyv = parkYeriVeri.Instance;
        //panel = GameObject.FindGameObjectWithTag("canvas");
        //panel2 = GameObject.FindGameObjectWithTag("canvas2");
        //panel3 = GameObject.FindGameObjectWithTag("canvas3");
        canvas = panel.GetComponent<Canvas>();
        canvas2 = panel2.GetComponent<Canvas>();
        canvas3 = panel3.GetComponent<Canvas>();

        
        seciliArabaAdi = db.seciliArabaAdi;
        if (aV.hedef == "a1")
        {
            myHedef = hedefa1.transform.position;
        }
        if (aV.hedef == "a2")
        {
            myHedef = hedefa2.transform.position;
        }
        if (aV.hedef == "a3")
        {
            myHedef = hedefa3.transform.position;
        }
        if (aV.hedef == "a4")
        {
            myHedef = hedefa4.transform.position;
        }
        if (aV.hedef == "a5")
        {
            myHedef = hedefa5.transform.position;
        }
        if (aV.hedef == "a6")
        {
            myHedef = hedefa6.transform.position;
        }



        if (aV.hedef == "b1")
        {
            myHedef = hedefb1.transform.position;
        }
        if (aV.hedef == "b2")
        {
            myHedef = hedefb2.transform.position;
        }
        if (aV.hedef == "b3")
        {
            myHedef = hedefb3.transform.position;
        }
        if (aV.hedef == "b4")
        {
            myHedef = hedefb4.transform.position;
        }
        if (aV.hedef == "b5")
        {
            myHedef = hedefb5.transform.position;
        }
        if (aV.hedef == "b6")
        {
            myHedef = hedefb6.transform.position;
        }
        if (aV.hedef == "b7")
        {
            myHedef = hedefb7.transform.position;
        }
        if (aV.hedef == "b8")
        {
            myHedef = hedefb8.transform.position;
        }



        if (aV.hedef == "c1")
        {
            myHedef = hedefc1.transform.position;
        }
        if (aV.hedef == "c2")
        {
            myHedef = hedefc2.transform.position;
        }
        if (aV.hedef == "c3")
        {
            myHedef = hedefc3.transform.position;
        }
        if (aV.hedef == "c4")
        {
            myHedef = hedefc4.transform.position;
        }
        if (aV.hedef == "c5")
        {
            myHedef = hedefc5.transform.position;
        }
        if (aV.hedef == "c6")
        {
            myHedef = hedefc6.transform.position;
        }
        if (aV.hedef == "c7")
        {
            myHedef = hedefc7.transform.position;
        }
        if (aV.hedef == "c8")
        {
            myHedef = hedefc8.transform.position;
        }



        if (aV.hedef == "d1")
        {
            myHedef = hedefd1.transform.position;
        }
        if (aV.hedef == "d2")
        {
            myHedef = hedefd2.transform.position;
        }
        if (aV.hedef == "d3")
        {
            myHedef = hedefd3.transform.position;
        }
        if (aV.hedef == "d4")
        {
            myHedef = hedefd4.transform.position;
        }


        if (seciliArabaAdi == "araba1")
        {
            rotaCizilecekObje = araba1;
            myAgent = agent1;
            Debug.Log("nav managede araba 1 çalıştı");
            //araba1.transform.position = new Vector3(araba1.transform.position.x, 0f, araba1.transform.position.z);
            //araba2.transform.position = new Vector3(araba2.transform.position.x, 100f, araba2.transform.position.z);
            //araba3.transform.position = new Vector3(araba3.transform.position.x, 100f, araba3.transform.position.z);
            araba1.SetActive(true);
            araba2.SetActive(false);
            araba3.SetActive(false);
            //araba1.GetComponent<NavMeshAgent>().enabled = true;
            //araba2.GetComponent<NavMeshAgent>().enabled = false;
            //araba3.GetComponent<NavMeshAgent>().enabled = false;
        }
        if (seciliArabaAdi == "araba2")
        {
            rotaCizilecekObje = araba2;
            myAgent = agent2;
            Debug.Log("nav managede araba 2 çalıştı");
            //araba1.transform.position = new Vector3(araba1.transform.position.x, 100f, araba1.transform.position.z);
            //araba2.transform.position = new Vector3(araba2.transform.position.x, 0f, araba2.transform.position.z);
            //araba3.transform.position = new Vector3(araba3.transform.position.x, 100f, araba3.transform.position.z);
            araba1.SetActive(false);
            araba2.SetActive(true);
            araba3.SetActive(false);
            //araba1.GetComponent<NavMeshAgent>().enabled = false;
            //araba2.GetComponent<NavMeshAgent>().enabled = true;
            //araba3.GetComponent<NavMeshAgent>().enabled = false;
        }

        if (seciliArabaAdi == "araba3")
        {
            rotaCizilecekObje = araba3;
            myAgent = agent3;
            Debug.Log("nav managede araba 3 çalıştı");
            //araba1.transform.position = new Vector3(araba1.transform.position.x, 100f, araba1.transform.position.z);
            //araba2.transform.position = new Vector3(araba2.transform.position.x, 100f, araba2.transform.position.z);
            //araba3.transform.position = new Vector3(araba3.transform.position.x, 0f, araba3.transform.position.z);
            //araba1.GetComponent<NavMeshAgent>().enabled = false;
            //araba2.GetComponent<NavMeshAgent>().enabled = false;
            //araba3.GetComponent<NavMeshAgent>().enabled = true;
            araba1.SetActive(false);
            araba2.SetActive(false);
            araba3.SetActive(true);
        }


        myLineRenderer = rotaCizilecekObje.GetComponent<LineRenderer>();
        myLineRenderer.startWidth = 1f;
        myLineRenderer.endWidth = 1f;
        //myLineRenderer.startColor = Color.black;
        //myLineRenderer.endColor = Color.white;
        //myLineRenderer.startColor = Color.blue;
        myLineRenderer.positionCount = 0;
        //NavMeshPath = new NavMeshPath();
        //agent4.Warp(_selection.position);
        //Quaternion orginalRot = transform.rotation;
        //_selection.rotation = orginalRot * Quaternion.AngleAxis(30,Vector3.up);
        myAgent.Warp(rotaCizilecekObje.transform.position);
        myAgent.SetDestination(myHedef);

        

    }

    void Update()
    {
        
        
        
        
        
        if (rotaCizilecekObje.activeSelf == true)
        {
            if (myAgent.hasPath && x == 0)
            {
                rotaCiz();
                if (x == 1)
                {
                    myAgent.speed = 0;
                }
            }
            
            

            

            myAgent.speed = 5f;
            if (rotaCizilecekObje == araba1)
            {
                myAgent.SetDestination(aV.ar1konum);
                
            }
            if (rotaCizilecekObje == araba2)
            {
                myAgent.SetDestination(aV.ar2konum);
                
            }
            if (rotaCizilecekObje == araba3)
            {
                myAgent.SetDestination(aV.ar3konum);
                
            }


        }




        string a = aV.hedef;

        Debug.Log("HEDEFİMİZ AKDENİZ İLERİ:" + a);

        if (aV.hedef == "a1" && pyv.a1 == "True")
        {
            myAgent.speed = 0;

            //panel.GetComponent<Canvas>().enabled = true;
            if (rotaCizilecekObje.activeSelf == true)
            {
                rotaCizilecekObje.SetActive(false);
                canvas.enabled = true;
            }




        }

        if (aV.hedef == "a2" && pyv.a2 == "True")
        {
            myAgent.speed = 0;
            if (rotaCizilecekObje.activeSelf == true)
            {
                rotaCizilecekObje.SetActive(false);
                canvas.enabled = true;
            }


        }
        if (aV.hedef == "a3" && pyv.a3 == "True")
        {
            myAgent.speed = 0;
            if (rotaCizilecekObje.activeSelf == true)
            {
                rotaCizilecekObje.SetActive(false);
                canvas.enabled = true;
            }


        }
        if (aV.hedef == "a4" && pyv.a4 == "True")
        {
            myAgent.speed = 0;
            if (rotaCizilecekObje.activeSelf == true)
            {
                rotaCizilecekObje.SetActive(false);
                canvas.enabled = true;
            }


        }
        if (aV.hedef == "a5" && pyv.a5 == "True")
        {
            myAgent.speed = 0;
            if (rotaCizilecekObje.activeSelf == true)
            {
                rotaCizilecekObje.SetActive(false);
                canvas.enabled = true;
            }

        }
        if (aV.hedef == "a6" && pyv.a6 == "True")
        {
            myAgent.speed = 0;
            if (rotaCizilecekObje.activeSelf == true)
            {
                rotaCizilecekObje.SetActive(false);
                canvas.enabled = true;
            }


        }



        if (aV.hedef == "b1" && pyv.b1 == "True")
        {
            myAgent.speed = 0;
            if (rotaCizilecekObje.activeSelf == true)
            {
                rotaCizilecekObje.SetActive(false);
                canvas.enabled = true;
            }

        }
        if (aV.hedef == "b2" && pyv.b2 == "True")
        {
            myAgent.speed = 0;
            if (rotaCizilecekObje.activeSelf == true)
            {
                rotaCizilecekObje.SetActive(false);
                canvas.enabled = true;
            }

        }
        if (aV.hedef == "b3" && pyv.b3 == "True")
        {
            myAgent.speed = 0;
            if (rotaCizilecekObje.activeSelf == true)
            {
                rotaCizilecekObje.SetActive(false);
                canvas.enabled = true;
            }


        }
        if (aV.hedef == "b4" && pyv.b4 == "True")
        {
            myAgent.speed = 0;
            if (rotaCizilecekObje.activeSelf == true)
            {
                rotaCizilecekObje.SetActive(false);
                canvas.enabled = true;
            }


        }
        if (aV.hedef == "b5" && pyv.b5 == "True")
        {
            myAgent.speed = 0;
            if (rotaCizilecekObje.activeSelf == true)
            {
                rotaCizilecekObje.SetActive(false);
                canvas.enabled = true;
            }


        }
        if (aV.hedef == "b6" && pyv.b6 == "True")
        {
            myAgent.speed = 0;
            if (rotaCizilecekObje.activeSelf == true)
            {
                rotaCizilecekObje.SetActive(false);
                canvas.enabled = true;
            }


        }
        if (aV.hedef == "b7" && pyv.b7 == "True")
        {
            myAgent.speed = 0;
            if (rotaCizilecekObje.activeSelf == true)
            {
                rotaCizilecekObje.SetActive(false);
                canvas.enabled = true;
            }


        }
        if (aV.hedef == "b8" && pyv.b8 == "True")
        {
            myAgent.speed = 0;
            if (rotaCizilecekObje.activeSelf == true)
            {
                rotaCizilecekObje.SetActive(false);
                canvas.enabled = true;
            }


        }



        if (aV.hedef == "c1" && pyv.c1 == "True")
        {
            myAgent.speed = 0;
            if (rotaCizilecekObje.activeSelf == true)
            {
                rotaCizilecekObje.SetActive(false);
                canvas.enabled = true;
            }


        }

        if (aV.hedef == "c2" && pyv.c2 == "True")
        {
            myAgent.speed = 0;
            if (rotaCizilecekObje.activeSelf == true)
            {
                rotaCizilecekObje.SetActive(false);
                canvas.enabled = true;
            }


        }
        if (aV.hedef == "c3" && pyv.c3 == "True")
        {
            myAgent.speed = 0;
            if (rotaCizilecekObje.activeSelf == true)
            {
                rotaCizilecekObje.SetActive(false);
                canvas.enabled = true;
            }

        }
        if (aV.hedef == "c4" && pyv.c4 == "True")
        {
            myAgent.speed = 0;
            if (rotaCizilecekObje.activeSelf == true)
            {
                rotaCizilecekObje.SetActive(false);
                canvas.enabled = true;
            }

        }
        if (aV.hedef == "c5" && pyv.c5 == "True")
        {
            myAgent.speed = 0;
            if (rotaCizilecekObje.activeSelf == true)
            {
                rotaCizilecekObje.SetActive(false);
                canvas.enabled = true;
            }

        }
        if (aV.hedef == "c6" && pyv.c6 == "True")
        {
            myAgent.speed = 0;
            if (rotaCizilecekObje.activeSelf == true)
            {
                rotaCizilecekObje.SetActive(false);
                canvas.enabled = true;
            }

        }
        if (aV.hedef == "c7" && pyv.c7 == "True")
        {
            myAgent.speed = 0;
            if (rotaCizilecekObje.activeSelf == true)
            {
                rotaCizilecekObje.SetActive(false);
                canvas.enabled = true;
            }

        }
        if (aV.hedef == "c8" && pyv.c8 == "True")
        {
            myAgent.speed = 0;
            if (rotaCizilecekObje.activeSelf == true)
            {
                rotaCizilecekObje.SetActive(false);
                canvas.enabled = true;
            }

        }




        if (aV.hedef == "d1" && pyv.d1 == "True")
        {
            myAgent.speed = 0;
            if (rotaCizilecekObje.activeSelf == true)
            {
                rotaCizilecekObje.SetActive(false);
                canvas.enabled = true;
            }

        }
        if (aV.hedef == "d2" && pyv.d2 == "True")
        {
            myAgent.speed = 0;
            if (rotaCizilecekObje.activeSelf == true)
            {
                rotaCizilecekObje.SetActive(false);
                canvas.enabled = true;
            }

        }
        if (aV.hedef == "d3" && pyv.d3 == "True")
        {
            myAgent.speed = 0;
            if (rotaCizilecekObje.activeSelf == true)
            {
                rotaCizilecekObje.SetActive(false);
                canvas.enabled = true;
            }

        }
        if (aV.hedef == "d4" && pyv.d4 == "True")
        {
            myAgent.speed = 0;
            if (rotaCizilecekObje.activeSelf == true)
            {
                rotaCizilecekObje.SetActive(false);
                canvas.enabled = true;
            }

        }

        /*if (Vector3.Distance(rotaCizilecekObje.transform.position, aV.ar1konum)<distance)
        {

            Debug.Log(Vector3.Distance(rotaCizilecekObje.transform.position, aV.ar1konum));
            myAgent.speed = 5f;
            myAgent.SetDestination(aV.ar1konum);
        }
        else
        {
            myAgent.speed = 0;
        }
        */

        /*if (x < 5)
        {
            x += 1;
            if (x == 5)
            {
                myAgent.speed = 0;
            }
        }*/


    

}





    void rotaCiz()
    {
        
        
        myLineRenderer.positionCount = myAgent.path.corners.Length;
        myLineRenderer.SetPosition(0, transform.position);

        for (int i = 0; i < myAgent.path.corners.Length; i++)
        {
                
            Vector3 pointPosition = new Vector3(myAgent.path.corners[i].x, myAgent.path.corners[i].y + 0.05f, myAgent.path.corners[i].z);
            myLineRenderer.SetPosition(i, pointPosition);
        }
        x++;
    }

    


    void rotaHareket()
    {

        if(rotaCizilecekObje == araba1)
        {
            myAgent.SetDestination(aV.ar1konum);
            myAgent.speed = 3.5f;
        }

        if (rotaCizilecekObje == araba2)
        {
            myAgent.SetDestination(aV.ar2konum);
            myAgent.speed = 3.5f;
        }

        if (rotaCizilecekObje == araba3)
        {
            myAgent.SetDestination(aV.ar3konum);
            myAgent.speed = 3.5f;
        }


    }


    /*void pause()
    {
        lastAgentVelocity = agent.velocity;
        lastAgentPath = agent.path;
        lastAgentDestination = agent.destination;
        agent.velocity = Vector3.zero;
        agent.ResetPath();
    }

    void resume()
    {
        if (agent.destination == lastAgentDestination)
        {
            agent.SetPath(lastAgentPath);
        }
        else
        {
            agent.SetDestination(lastAgentDestination);
        }

        agent.velocity = lastAgentVelocity;
    }*/


    public void girEvet()
    {
        //panel = GameObject.FindGameObjectWithTag("canvas");
        //panel2 = GameObject.FindGameObjectWithTag("canvas2");
        //panel3 = GameObject.FindGameObjectWithTag("canvas3");
        panel.GetComponent<Canvas>().enabled = false;
        canvas.enabled = false;
        panel3.GetComponent<Canvas>().enabled = true;
        canvas3.enabled = true;
        

    }

    public void girHayir()
    {
        //panel = GameObject.FindGameObjectWithTag("canvas");
        // panel2 = GameObject.FindGameObjectWithTag("canvas2");
        //panel3 = GameObject.FindGameObjectWithTag("canvas3");
        //panel.SetActive(false);
        //panel2.SetActive(true);
        panel.GetComponent<Canvas>().enabled = false;
        canvas.enabled = false;
        panel2.GetComponent<Canvas>().enabled = true;
        canvas2.enabled = true;

    }

    public void girTamam()
    {
        //panel = GameObject.FindGameObjectWithTag("canvas");
        //panel2 = GameObject.FindGameObjectWithTag("canvas2");
        //panel3 = GameObject.FindGameObjectWithTag("canvas3");
        panel2.GetComponent<Canvas>().enabled = false;
        canvas2.enabled = false;
        
    }


    public void baslangicNM()
    {
        

    }
}

