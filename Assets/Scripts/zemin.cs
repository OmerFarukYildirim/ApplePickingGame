using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class zemin : MonoBehaviour
{
    float can = 100.0f;
    float suanki_can = 100.0f;

    public GameObject gameover;
    public Image can_bari;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "elma")
        {

            Destroy(collision.gameObject);

            suanki_can -= 10.0f;
            can_bari.fillAmount = suanki_can / can;
        }
        if(suanki_can<=0)
        {
            gameover.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
