using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Selection : MonoBehaviour
{
    [SerializeField] public string selectableTag = "arac";
    [SerializeField] public Material highlightMaterial;
    [SerializeField] public Material defaultMaterial;
    public NavMeshAgent agent1;
    public NavMeshAgent agent2;
    public NavMeshAgent agent3;
    //public NavMeshAgent agent4;
    public Camera cam;
    public GameObject rotaCizilecekObje;
    public LineRenderer myLineRenderer;
    //public NavMeshPath NavMeshPath;
    //public GameObject araba1;
    
    public string secilmisArac="";
    public int x = 0;
    

    private Transform _selection;

    void Start()
    {
        myLineRenderer = rotaCizilecekObje.GetComponent<LineRenderer>();
        myLineRenderer.startWidth = 1f;
        myLineRenderer.endWidth = 1f;
        //myLineRenderer.startColor = Color.black;
        //myLineRenderer.endColor = Color.white;
        //myLineRenderer.startColor = Color.blue;
        myLineRenderer.positionCount = 0;
        //NavMeshPath = new NavMeshPath();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            if (secilmisArac == "araba1")
            {
                //GameObject.Find("araba1").AddComponent<NavMeshAgent>();
                
                Ray ray = cam.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if(Physics.Raycast(ray,out hit))
                {
                    agent1.Warp(_selection.position);
                    //agent4.Warp(_selection.position);
                    //Quaternion orginalRot = transform.rotation;
                    //_selection.rotation = orginalRot * Quaternion.AngleAxis(30,Vector3.up);
                    agent1.SetDestination(hit.point);
                    x = 0;
                    //agent4.SetDestination(hit.point);
                    
                    //agent1.SetDestination(hit.point);
                    //agent1.Stop();
                    //Debug.Log("1.aracın hedefi" + hit.point);
                }
            }
            if (secilmisArac == "araba2")
            {
                //GameObject.Find("araba1").AddComponent<NavMeshAgent>();
                Ray ray = cam.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit))
                {
                    agent2.Warp(_selection.position);
                    //Quaternion orginalRot = transform.rotation;
                    //_selection.rotation = orginalRot * Quaternion.AngleAxis(30, Vector3.up);
                    //agent2.updateRotation = false;
                    agent2.SetDestination(hit.point);
                    //Debug.Log("2.aracın hedefi" + hit.point);
                }
            }
            if (secilmisArac == "araba3")
            {
                //GameObject.Find("araba1").AddComponent<NavMeshAgent>();
                Ray ray = cam.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit))
                {
                    agent3.Warp(_selection.position);
                    //Quaternion orginalRot = transform.rotation;
                    //_selection.rotation = orginalRot * Quaternion.AngleAxis(30, Vector3.up);
                    //agent3.updateRotation = false;
                    agent3.SetDestination(hit.point);
                    //Debug.Log("3.aracın hedefi" + hit.point);
                }
            }



        }


        if (Input.GetMouseButtonDown(0))
        {
            if (_selection != null)
            {
                var selectionRenderer = _selection.GetComponent<Renderer>();
                selectionRenderer.material = defaultMaterial;
                _selection = null;
            
            }

            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
            
                var selection = hit.transform;
                if (selection.tag == "arac")
                {
                    var selectionRenderer = selection.GetComponent<Renderer>();
                    
                    if (selectionRenderer != null)
                    {
                        selectionRenderer.material = highlightMaterial;
                        
                        secilmisArac = selection.name;
                        //Debug.Log(secilmisArac);
                        
                       
                    }

                    _selection = selection;
                    //Debug.Log(selection.position);
                }
            }
        }

        else if (agent1.hasPath)
        {
            rotaCiz();
            if (x <= 10)
            {
                x += 1;
            } 
        }
        

    }





    void rotaCiz()
    {
        if (x <= 5)
        {
            myLineRenderer.positionCount = agent1.path.corners.Length;
            myLineRenderer.SetPosition(0, transform.position);

            for (int i = 0; i < agent1.path.corners.Length; i++)
            {
                Vector3 pointPosition = new Vector3(agent1.path.corners[i].x, agent1.path.corners[i].y+0.05f, agent1.path.corners[i].z);
                myLineRenderer.SetPosition(i, pointPosition);
            }
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

}

