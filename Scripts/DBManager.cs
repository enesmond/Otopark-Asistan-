using Firebase;
using Firebase.Database;
using Firebase.Unity.Editor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Globalization;

public class DBManager : Singleton<DBManager>
{

    public DatabaseReference parkReference;
    public DatabaseReference arabaReference;
    public DatabaseReference seciliReference;
    public parkYeriVeri pyv;
    public aracVeri aV;

    



    public string veri = "";
    public string _veri = "";
    public bool sonuc = false;

    public string birKonumX;
    public string birKonumY;
    public string birKonumZ;

    public Vector3 birKonum;

    public string ikiKonumX;
    public string ikiKonumY;
    public string ikiKonumZ;

    public Vector3 ikiKonum;

    public string ucKonumX;
    public string ucKonumY;
    public string ucKonumZ;

    public Vector3 ucKonum;

    public string seciliArabaAdi;





    void Awake()
    {

        Init();


    }



     void Start()
    {
        pyv = parkYeriVeri.Instance;
        aV = aracVeri.Instance;
    }
    void Init()
    {

        FirebaseApp.DefaultInstance.SetEditorDatabaseUrl("https://proje-29618.firebaseio.com/");

        FirebaseApp.CheckAndFixDependenciesAsync().ContinueWith(task =>
        {
            var dependencyStatus = task.Result;
            if (dependencyStatus==Firebase.DependencyStatus.Available)
            {
                parkReference = FirebaseDatabase.DefaultInstance.GetReference("park");
                arabaReference = FirebaseDatabase.DefaultInstance.GetReference("araba");
                seciliReference = FirebaseDatabase.DefaultInstance.GetReference("secili");

                parkReference.ValueChanged += parkVeriDegisti;
                arabaReference.ValueChanged += aracVeriDegisti;
                seciliReference.ValueChanged += seciliAracDegisti;
                
                Debug.Log("Bağlantı başarılı");
            }
            else
            {
                Debug.Log("Bağlantı başarısız");
            }

        }

        );

        
    }

    public void UpdateParkYeri(string yerAdi,bool dolumu)
    {
        Dictionary<string, object> children = new Dictionary<string, object>();
        children["dolumu"] = dolumu;
        //children["level"] =1;
        parkReference.Child(yerAdi).UpdateChildrenAsync(children);
    }

    public void parkYeriBilgisi(object sender, ValueChangedEventArgs args)
    {
        if (args.DatabaseError != null)
        {
            Debug.LogError(args.DatabaseError.Message);
            return;
        }
        Debug.Log("Değişiklik var");
        
    }
    public void UpdateLastPosition(string aracName, float konumx, float konumy, float konumz)
    {
        
        Dictionary<string, object> children = new Dictionary<string, object>();
        children["konumx"] = konumx;
        children["konumy"] = konumy;
        children["konumz"] = konumz;
        //children["level"] =1;
        arabaReference.Child(aracName).UpdateChildrenAsync(children);
    }


    public void bilgiAlParkYeri()
    {

        Debug.Log("çalış artık");
        //GameObject _objemiz = new GameObject();
        string _parkYeriAdi = "";


        parkReference.GetValueAsync().ContinueWith(task =>
        {
            if (task.IsFaulted)
            {
                Debug.Log("a1" + "için" + "Çalışmadı");
                sonuc = false;

            }
            else if (task.IsCompleted)
            {
                DataSnapshot degisen = task.Result;
                
                //veri = snapshot.Child(_parkYeriAdi).Child("dolumu").Value.ToString();
                
                _veri = veri;

                pyv.a1 = degisen.Child("a1").Child("dolumu").Value.ToString();
                pyv.a2 = degisen.Child("a2").Child("dolumu").Value.ToString();
                pyv.a3 = degisen.Child("a3").Child("dolumu").Value.ToString();
                pyv.a4 = degisen.Child("a4").Child("dolumu").Value.ToString();
                pyv.a5 = degisen.Child("a5").Child("dolumu").Value.ToString();
                pyv.a6 = degisen.Child("a6").Child("dolumu").Value.ToString();
                pyv.b1 = degisen.Child("b1").Child("dolumu").Value.ToString();
                pyv.b2 = degisen.Child("b2").Child("dolumu").Value.ToString();
                pyv.b3 = degisen.Child("b3").Child("dolumu").Value.ToString();
                pyv.b4 = degisen.Child("b4").Child("dolumu").Value.ToString();
                pyv.b5 = degisen.Child("b5").Child("dolumu").Value.ToString();
                pyv.b6 = degisen.Child("b6").Child("dolumu").Value.ToString();
                pyv.b7 = degisen.Child("b7").Child("dolumu").Value.ToString();
                pyv.b8 = degisen.Child("b8").Child("dolumu").Value.ToString();
                pyv.c1 = degisen.Child("c1").Child("dolumu").Value.ToString();
                pyv.c2 = degisen.Child("c2").Child("dolumu").Value.ToString();
                pyv.c3 = degisen.Child("c3").Child("dolumu").Value.ToString();
                pyv.c4 = degisen.Child("c4").Child("dolumu").Value.ToString();
                pyv.c5 = degisen.Child("c5").Child("dolumu").Value.ToString();
                pyv.c6 = degisen.Child("c6").Child("dolumu").Value.ToString();
                pyv.c7 = degisen.Child("c7").Child("dolumu").Value.ToString();
                pyv.c8 = degisen.Child("c8").Child("dolumu").Value.ToString();
                pyv.d1 = degisen.Child("d1").Child("dolumu").Value.ToString();
                pyv.d2 = degisen.Child("d2").Child("dolumu").Value.ToString();
                pyv.d3 = degisen.Child("d3").Child("dolumu").Value.ToString();
                pyv.d4 = degisen.Child("d4").Child("dolumu").Value.ToString();

                //veri = "" + snapshot.Key;
                /*if (_veri == "True")
                {

                    sonuc = true;

                    Debug.Log("İçerde true çalıştı" + _parkYeriAdi + "için------------veri-----------" + _veri + "------------sonuc-----------" + sonuc);


                }


                else
                {
                    sonuc = false;
                    //_objemiz.transform.position = new Vector3(_objemiz.transform.position.x, 100f, objemiz.transform.position.z);
                    Debug.Log("İçerde false çalıştı" + _parkYeriAdi + "için------------veri-----------" + _veri + "------------sonuc-----------" + sonuc);

                }*/


            }

        });





    }



    public void parkVeriDegisti(object sender, ValueChangedEventArgs args)
    {
        if (args.DatabaseError != null)
        {
            Debug.LogError(args.DatabaseError.Message);
            return;
        }

        DataSnapshot degisen = args.Snapshot;

        Debug.Log(" değeri:    "+degisen.Child("a1").Child("dolumu").Value.ToString());
        Debug.Log(" değeri:    "+degisen.Child("a2").Child("dolumu").Value.ToString());
        Debug.Log(" değeri:    "+degisen.Child("a3").Child("dolumu").Value.ToString());
        Debug.Log(" değeri:    "+degisen.Child("a4").Child("dolumu").Value.ToString());
        Debug.Log(" değeri:    "+degisen.Child("a5").Child("dolumu").Value.ToString());
        Debug.Log(" değeri:    "+degisen.Child("a6").Child("dolumu").Value.ToString());
        Debug.Log(" değeri:    "+degisen.Child("b1").Child("dolumu").Value.ToString());
        Debug.Log(" değeri:    "+degisen.Child("b2").Child("dolumu").Value.ToString());
        Debug.Log(" değeri:    "+degisen.Child("b3").Child("dolumu").Value.ToString());
        Debug.Log(" değeri:    "+degisen.Child("b4").Child("dolumu").Value.ToString());
        Debug.Log(" değeri:    "+degisen.Child("b5").Child("dolumu").Value.ToString());
        Debug.Log(" değeri:    "+degisen.Child("b6").Child("dolumu").Value.ToString());
        Debug.Log(" değeri:    "+degisen.Child("b7").Child("dolumu").Value.ToString());
        Debug.Log(" değeri:    "+degisen.Child("b8").Child("dolumu").Value.ToString());
        Debug.Log(" değeri:    " + degisen.Child("c1").Child("dolumu").Value.ToString());
        Debug.Log(" değeri:    " + degisen.Child("c2").Child("dolumu").Value.ToString());
        Debug.Log(" değeri:    " + degisen.Child("c3").Child("dolumu").Value.ToString());
        Debug.Log(" değeri:    " + degisen.Child("c4").Child("dolumu").Value.ToString());
        Debug.Log(" değeri:    " + degisen.Child("c5").Child("dolumu").Value.ToString());
        Debug.Log(" değeri:    " + degisen.Child("c6").Child("dolumu").Value.ToString());
        Debug.Log(" değeri:    " + degisen.Child("c7").Child("dolumu").Value.ToString());
        Debug.Log(" değeri:    " + degisen.Child("c8").Child("dolumu").Value.ToString());
        Debug.Log(" değeri:    " + degisen.Child("d1").Child("dolumu").Value.ToString());
        Debug.Log(" değeri:    " + degisen.Child("d2").Child("dolumu").Value.ToString());
        Debug.Log(" değeri:    " + degisen.Child("d3").Child("dolumu").Value.ToString());
        Debug.Log(" değeri:    " + degisen.Child("d4").Child("dolumu").Value.ToString());


        
        pyv.a1 = degisen.Child("a1").Child("dolumu").Value.ToString();
        pyv.a2 = degisen.Child("a2").Child("dolumu").Value.ToString();
        pyv.a3 = degisen.Child("a3").Child("dolumu").Value.ToString();
        pyv.a4 = degisen.Child("a4").Child("dolumu").Value.ToString();
        pyv.a5 = degisen.Child("a5").Child("dolumu").Value.ToString();
        pyv.a6 = degisen.Child("a6").Child("dolumu").Value.ToString();
        pyv.b1 = degisen.Child("b1").Child("dolumu").Value.ToString();
        pyv.b2 = degisen.Child("b2").Child("dolumu").Value.ToString();
        pyv.b3 = degisen.Child("b3").Child("dolumu").Value.ToString();
        pyv.b4 = degisen.Child("b4").Child("dolumu").Value.ToString();
        pyv.b5 = degisen.Child("b5").Child("dolumu").Value.ToString();
        pyv.b6 = degisen.Child("b6").Child("dolumu").Value.ToString();
        pyv.b7 = degisen.Child("b7").Child("dolumu").Value.ToString();
        pyv.b8 = degisen.Child("b8").Child("dolumu").Value.ToString();
        pyv.c1 = degisen.Child("c1").Child("dolumu").Value.ToString();
        pyv.c2 = degisen.Child("c2").Child("dolumu").Value.ToString();
        pyv.c3 = degisen.Child("c3").Child("dolumu").Value.ToString();
        pyv.c4 = degisen.Child("c4").Child("dolumu").Value.ToString();
        pyv.c5 = degisen.Child("c5").Child("dolumu").Value.ToString();
        pyv.c6 = degisen.Child("c6").Child("dolumu").Value.ToString();
        pyv.c7 = degisen.Child("c7").Child("dolumu").Value.ToString();
        pyv.c8 = degisen.Child("c8").Child("dolumu").Value.ToString();
        pyv.d1 = degisen.Child("d1").Child("dolumu").Value.ToString();
        pyv.d2 = degisen.Child("d2").Child("dolumu").Value.ToString();
        pyv.d3 = degisen.Child("d3").Child("dolumu").Value.ToString();
        pyv.d4 = degisen.Child("d4").Child("dolumu").Value.ToString();



    }

    public void seciliAracDegisti(object sender, ValueChangedEventArgs args)
    {
        if (args.DatabaseError != null)
        {
            Debug.LogError(args.DatabaseError.Message);
            return;
        }

        DataSnapshot degisen = args.Snapshot;

        seciliArabaAdi= degisen.Child("secili").Value.ToString();
    }

    public void aracVeriDegisti(object sender, ValueChangedEventArgs args)
    {
        if (args.DatabaseError != null)
        {
            Debug.LogError(args.DatabaseError.Message);
            return;
        }

        DataSnapshot degisen = args.Snapshot;

        /*Debug.Log(" değeri:    "+degisen.Child("a1").Child("dolumu").Value.ToString());
        Debug.Log(" değeri:    "+degisen.Child("a2").Child("dolumu").Value.ToString());
        Debug.Log(" değeri:    "+degisen.Child("a3").Child("dolumu").Value.ToString());
        Debug.Log(" değeri:    "+degisen.Child("a4").Child("dolumu").Value.ToString());
        Debug.Log(" değeri:    "+degisen.Child("a5").Child("dolumu").Value.ToString());
        Debug.Log(" değeri:    "+degisen.Child("a6").Child("dolumu").Value.ToString());
        Debug.Log(" değeri:    "+degisen.Child("b1").Child("dolumu").Value.ToString());
        Debug.Log(" değeri:    "+degisen.Child("b2").Child("dolumu").Value.ToString());
        Debug.Log(" değeri:    "+degisen.Child("b3").Child("dolumu").Value.ToString());
        Debug.Log(" değeri:    "+degisen.Child("b4").Child("dolumu").Value.ToString());
        Debug.Log(" değeri:    "+degisen.Child("b5").Child("dolumu").Value.ToString());
        Debug.Log(" değeri:    "+degisen.Child("b6").Child("dolumu").Value.ToString());
        Debug.Log(" değeri:    "+degisen.Child("b7").Child("dolumu").Value.ToString());
        Debug.Log(" değeri:    "+degisen.Child("b8").Child("dolumu").Value.ToString());
        Debug.Log(" değeri:    " + degisen.Child("c1").Child("dolumu").Value.ToString());
        Debug.Log(" değeri:    " + degisen.Child("c2").Child("dolumu").Value.ToString());
        Debug.Log(" değeri:    " + degisen.Child("c3").Child("dolumu").Value.ToString());
        Debug.Log(" değeri:    " + degisen.Child("c4").Child("dolumu").Value.ToString());
        Debug.Log(" değeri:    " + degisen.Child("c5").Child("dolumu").Value.ToString());
        Debug.Log(" değeri:    " + degisen.Child("c6").Child("dolumu").Value.ToString());
        Debug.Log(" değeri:    " + degisen.Child("c7").Child("dolumu").Value.ToString());
        Debug.Log(" değeri:    " + degisen.Child("c8").Child("dolumu").Value.ToString());
        Debug.Log(" değeri:    " + degisen.Child("d1").Child("dolumu").Value.ToString());
        Debug.Log(" değeri:    " + degisen.Child("d2").Child("dolumu").Value.ToString());
        Debug.Log(" değeri:    " + degisen.Child("d3").Child("dolumu").Value.ToString());
        Debug.Log(" değeri:    " + degisen.Child("d4").Child("dolumu").Value.ToString());*/




        /*birKonumX = degisen.Child("araba1").Child("konumx").Value;
        birKonumY = degisen.Child("araba1").Child("konumy").Value.ToString();
        birKonumZ = degisen.Child("araba1").Child("konumz").Value.ToString();

        birKonum = new Vector3(float.Parse(birKonumX,CultureInfo.InvariantCulture.NumberFormat), float.Parse(birKonumY, CultureInfo.InvariantCulture.NumberFormat),
            float.Parse(birKonumZ, CultureInfo.InvariantCulture.NumberFormat));

        Debug.Log("x:"+birKonum.x.ToString() +"  ------ y: "+ birKonum.y.ToString() + "  ------ z: " + birKonum.z.ToString());
        aV.ar1konum = birKonum;



        ikiKonumX = degisen.Child("araba2").Child("konumx").Value.ToString();
        ikiKonumY = degisen.Child("araba2").Child("konumy").Value.ToString();
        ikiKonumZ = degisen.Child("araba2").Child("konumz").Value.ToString();

        ikiKonum = new Vector3(float.Parse(ikiKonumX, CultureInfo.InvariantCulture.NumberFormat), float.Parse(ikiKonumY, CultureInfo.InvariantCulture.NumberFormat),
            float.Parse(ikiKonumZ, CultureInfo.InvariantCulture.NumberFormat));

        aV.ar2konum = ikiKonum;



        ucKonumX = degisen.Child("araba3").Child("konumx").Value.ToString();
        ucKonumY = degisen.Child("araba3").Child("konumy").Value.ToString();
        ucKonumZ = degisen.Child("araba3").Child("konumz").Value.ToString();

        ucKonum = new Vector3(float.Parse(ucKonumX, CultureInfo.InvariantCulture.NumberFormat), float.Parse(ucKonumY, CultureInfo.InvariantCulture.NumberFormat),
            float.Parse(ucKonumZ, CultureInfo.InvariantCulture.NumberFormat));

        aV.ar3konum = ucKonum;
        */


        birKonumX = degisen.Child("araba1").Child("konumx").Value.ToString();
        birKonumY = degisen.Child("araba1").Child("konumy").Value.ToString();
        birKonumZ = degisen.Child("araba1").Child("konumz").Value.ToString();

        birKonum = new Vector3(float.Parse(birKonumX), float.Parse(birKonumY),
            float.Parse(birKonumZ));

        Debug.Log("x:" + birKonum.x.ToString() + "  ------ y: " + birKonum.y.ToString() + "  ------ z: " + birKonum.z.ToString());
        aV.ar1konum = birKonum;



        ikiKonumX = degisen.Child("araba2").Child("konumx").Value.ToString();
        ikiKonumY = degisen.Child("araba2").Child("konumy").Value.ToString();
        ikiKonumZ = degisen.Child("araba2").Child("konumz").Value.ToString();

        ikiKonum = new Vector3(float.Parse(ikiKonumX), float.Parse(ikiKonumY),
            float.Parse(ikiKonumZ));

        aV.ar2konum = ikiKonum;



        ucKonumX = degisen.Child("araba3").Child("konumx").Value.ToString();
        ucKonumY = degisen.Child("araba3").Child("konumy").Value.ToString();
        ucKonumZ = degisen.Child("araba3").Child("konumz").Value.ToString();

        ucKonum = new Vector3(float.Parse(ucKonumX), float.Parse(ucKonumY),
            float.Parse(ucKonumZ));

        aV.ar3konum = ucKonum;

    }
    public void eniyiparkUpdate()
    {
        Debug.Log("çalış artık");
        //GameObject _objemiz = new GameObject();
        //string parkYeriAdi = "";


        parkReference.OrderByChild("level").GetValueAsync().ContinueWith(task =>
        {
            if (task.IsFaulted)
            {
                Debug.Log("a1" + "için" + "Çalışmadı");
                sonuc = false;

            }
            else if (task.IsCompleted)
            {
                DataSnapshot snapshot = task.Result;
                string yer = "";

                foreach (DataSnapshot parkYeriAdi in snapshot.Children)
                {
                    string _parkYeriAdi = parkYeriAdi.Key;
                    int level = int.Parse(snapshot.Child(_parkYeriAdi).Child("level").Value.ToString());

                    
                    
                    if (snapshot.Child(_parkYeriAdi).Child("dolumu").Value.ToString() == "False")
                    {
                        yer= _parkYeriAdi.ToString();
                        aV.enIyıHedef = yer;
                        Debug.Log("yer: "+yer +" : "+ level);
                        Debug.Log("av de yer: "+ aV.enIyıHedef + " : "+ level);
                        return;
                    }
                    
                    
                }
                if (yer == "")
                {
                    aV.enIyıHedef = "yok";
                    Debug.Log("boş yer yok!!!!");
                }






                /*veri = snapshot.Child(_parkYeriAdi).Child("dolumu").Value.ToString();
                Debug.Log("completed çalıştı ----------" + "x" + "için------------veri-----------:" + veri);
                _veri = veri;


                //veri = "" + snapshot.Key;
                if (_veri == "True")
                {

                    sonuc = true;

                    Debug.Log("İçerde true çalıştı" + "x" + "için------------veri-----------" + _veri + "------------sonuc-----------" + sonuc);


                }


                else
                {
                    sonuc = false;
                    //_objemiz.transform.position = new Vector3(_objemiz.transform.position.x, 100f, objemiz.transform.position.z);
                    Debug.Log("İçerde false çalıştı" + _parkYeriAdi + "için------------veri-----------" + _veri + "------------sonuc-----------" + sonuc);

                }
                */

            }

        });




    }

    /*public void baslangicParkYerleriDoluMu()
    {
        bilgiAlParkYeri("a1");
        bilgiAlParkYeri("a2");
        bilgiAlParkYeri("a3");
        bilgiAlParkYeri("a4");
        bilgiAlParkYeri("a5");
        bilgiAlParkYeri("a6");
        bilgiAlParkYeri("b1");
        bilgiAlParkYeri("b2");
        bilgiAlParkYeri("b3");
        bilgiAlParkYeri("b4");
        bilgiAlParkYeri("b5");
        bilgiAlParkYeri("b6");
        bilgiAlParkYeri("b7");
        bilgiAlParkYeri("b8");
        bilgiAlParkYeri("c1");
        bilgiAlParkYeri("c2");
        bilgiAlParkYeri("c3");
        bilgiAlParkYeri("c4");
        bilgiAlParkYeri("c5");
        bilgiAlParkYeri("c6");
        bilgiAlParkYeri("c7");
        bilgiAlParkYeri("c8");
        bilgiAlParkYeri("d1");
        bilgiAlParkYeri("d2");
        bilgiAlParkYeri("d3");
        bilgiAlParkYeri("d4");

    }*/




}
