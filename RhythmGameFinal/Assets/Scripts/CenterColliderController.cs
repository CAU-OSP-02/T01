using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//MISS �� �߾� �ݶ��̴� 


public class CenterColliderController : MonoBehaviour
{
    public GameObject MissEffect;
    public bool isCrashed;

    void Start()
    {
        isCrashed = false;
    }


    void Update()   //Miss ��
    {
        if(isCrashed == true)
        {
            gameObject.SetActive(false);

            
        }

    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Collider")
        {
            isCrashed = true;
        }
        
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Collider" )
        {
            isCrashed = false;
            GameManager.instance.NoteMissed();
            Instantiate(MissEffect, MissEffect.transform.position, MissEffect.transform.rotation);

        }
    }

}
