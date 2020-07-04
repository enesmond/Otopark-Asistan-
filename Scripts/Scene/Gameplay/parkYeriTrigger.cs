using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase;
using Firebase.Database;
using Firebase.Unity.Editor;

public class parkYeriTrigger : MonoBehaviour
{
    public GameObject araba;
    public GameObject yer;
    private DBManager db;
    public DatabaseReference dbdb;
    

    void Start()
    {
        db = DBManager.Instance;
    }
    private void OnTriggerEnter(Collider other)
    {

        dbdb = db.parkReference;
        dbdb = FirebaseDatabase.DefaultInstance.GetReference("park");
        db.UpdateParkYeri(this.name, true);




    }

    private void OnTriggerExit(Collider other)
    {
        dbdb = db.parkReference;
        dbdb = FirebaseDatabase.DefaultInstance.GetReference("park");
        db.UpdateParkYeri(this.name, false);
    }

    public void tiklandi()
    {
       // Debug.Log(this.name);
    }
    
}
