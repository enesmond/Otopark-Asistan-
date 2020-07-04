using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GirisButonlar : MonoBehaviour
{
    public string secimm="";
    public string hedeff="";
    public DBManager db;

    public aracVeri aV;
    
    public GameObject panel;
    public GameObject panel2;
    public GameObject panel3;
    public GameObject panel4;
   

    void Start()
    {
        
        aV = aracVeri.Instance;
        db = DBManager.Instance;
    }

    public void girSimulasyon()
    {
        SceneManager.LoadScene("Gameplay");
        
    }

    

    public void girNavigasyon()
    {
        
        SceneManager.LoadScene("navAracSecim");
        
    }

    public void kapat()
    {
        Application.Quit();
    }

    

    public void girAraba1()
    {

        db.eniyiparkUpdate();
        aV.hedef = hedeff;
        SceneManager.LoadScene("navRotaSecimi");
        
    }

    public void girAraba2()
    {

        //araba 2 yi seç ve rota sahnesini yükle

        secimm = "araba2";
        aV.secim = secimm;

        db.seciliArabaAdi = "araba2";

        hedeff = aV.enIyıHedef;
        aV.hedef = hedeff;

        db.seciliArabaAdi = "araba2";

        Debug.Log("gir 1e basınca av secim:" + aV.secim);
        //panel4 = GameObject.FindGameObjectWithTag("canvas4");

        SceneManager.LoadScene("navRotaSecimi");
    }

    public void girAraba3()
    {

        //araba 3 ü seç ve rota sahnesini yükle

        secimm = "araba3";
        aV.secim = secimm;
        db.seciliArabaAdi = "araba3";


        hedeff = aV.enIyıHedef;
        aV.hedef = hedeff;

        db.seciliArabaAdi = "araba3";
        Debug.Log("gir 1e basınca av secim:" + aV.secim);
        //panel4 = GameObject.FindGameObjectWithTag("canvas4");

        SceneManager.LoadScene("navRotaSecimi");


    }

    public void donGiris()
    {
        SceneManager.LoadScene("giris");
    }

    public void girRota()
    {

        //seçilen araba ile navigasyon sahnesini yükle

        //db.eniyiparkUpdate();

        db.bilgiAlParkYeri();


        SceneManager.LoadScene("Navigasyon");
    }


    public void donAracSecim()
    {

        //seçilen araba ile navigasyon sahnesini yükle
        SceneManager.LoadScene("navAracSecim");
    }


    public void yeniRotaSecim()
    {

        //seçilen araba ile navigasyon sahnesini yükle
        SceneManager.LoadScene("navAracSecim");
    }

   

    /*public void girEvet()
    {
        panel = GameObject.FindGameObjectWithTag("canvas2");
        db.eniyiparkUpdate();
        hedeff = aV.enIyıHedef;
        aV.hedef = hedeff;
        panel.SetActive(false);
        
    }*/

    
}
