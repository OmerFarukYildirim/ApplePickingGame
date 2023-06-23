using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class yonetici : MonoBehaviour
{

    public GameObject elma;

    bool oyun_durduruldu = false;

    public void tekrar_oyna_btn()
    {
        SceneManager.LoadScene("scenes/elma_oyunu");
        Time.timeScale = 1.0f;

    }

    public void cıkma_btn()
    {
        SceneManager.LoadScene("scenes/sahne_2");
        Time.timeScale = 0.0f;

    }


    public void durdur_btn()
    {
        oyun_durduruldu = !oyun_durduruldu;

        if(oyun_durduruldu==true)
        {
            Time.timeScale = 0.0f;
        }
        else
        {
            Time.timeScale = 1.0f; // canvas event system olmadan çalıştırmaz butonları, ayrıca düzenli ilerle scriptler script dosyasında, spritelar sprite da şeklinde olsun. Yazılımda duzen her şeydir öptüm :*
        }
    }




    void Start()
    {
        InvokeRepeating("elma_ekle", 0.0f, 0.37f);
    }

   void elma_ekle()
    {
        float rast = Random.Range(1.5f, 9.5f);
        GameObject yeni_elma= Instantiate(elma, new Vector3(rast, 8, -5), Quaternion.identity);
        
    }


   
}
