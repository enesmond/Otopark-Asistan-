using Firebase.Database;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastPosition : MonoBehaviour
{
    public string aracName="";
    public string lastPositionString;
    public float lastPositionx;
    public float lastPositiony;
    public float lastPositionz;
    public string xString;
    public string yString;
    public string zString;
    private DBManager db;
    public DatabaseReference dbdb;
    public aracVeri aV;

    void Start()
    {
        db = DBManager.Instance;
        aV = aracVeri.Instance;
        lastPositionx=0.0f;
        lastPositiony= 0.0f;
        lastPositionz= 0.0f;

}

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("kendisi"+this.name);
        Debug.Log("araç"+other.name);
        lastPositionx = this.transform.position.x;
        lastPositiony = this.transform.position.y;
        lastPositionz = this.transform.position.z;
        //xString = ""+lastPositionx;
        //yString = ""+lastPositiony;
        //zString = ""+lastPositionz;
        aracName = other.name;
        Debug.Log("x------" + xString);
        Debug.Log("y------" + yString);
        Debug.Log("z------" + zString);
        //dbdb = db.arabaReference;
        //dbdb = FirebaseDatabase.DefaultInstance.GetReference("araba");
        db.UpdateLastPosition(aracName, lastPositionx, lastPositiony, lastPositionz);
        /*if (other.name =="araba1")
        {
            aV.ar1konum = new Vector3(lastPositionx,lastPositiony,lastPositionz);
        }
        if (other.name == "araba2")
        {
            aV.ar2konum = new Vector3(lastPositionx, lastPositiony, lastPositionz);
        }
        if (other.name == "araba3")
        {
            aV.ar3konum = new Vector3(lastPositionx, lastPositiony, lastPositionz);
        }
        */

    }
    
}
