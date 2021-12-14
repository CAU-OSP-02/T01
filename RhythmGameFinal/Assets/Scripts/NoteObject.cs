using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject : MonoBehaviour
{

    public bool canBePressed;
    public KeyCode KeyToPress;

    public GameObject PerfectEffect, GoodEffect, BadEffect, MissEffect;
    //private SpriteRenderer noteRenderer= self;

    void Start()
    {
        //renderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyToPress))
        {
            if(canBePressed)  //��Ʈ ������ �� 
            {
                GameManager.instance.NoteHit();
                gameObject.SetActive(false);            
                //sprite.enabled = false;
                //Destroy(gameObject);
            }
            
            if (Mathf.Abs(transform.position.y) > 2.2)
            {
                
            } 
            else if (Mathf.Abs(transform.position.y) > 1.7)//1.9
            {
                Debug.Log("Perfect!");
                GameManager.instance.PerfectHit();
                Instantiate(PerfectEffect, PerfectEffect.transform.position ,PerfectEffect.transform.rotation);
            } else if (Mathf.Abs(transform.position.y) > 1.0 )//1.3
            {
                Debug.Log("Good");
                GameManager.instance.GoodHit();
                Instantiate(GoodEffect, GoodEffect.transform.position, GoodEffect.transform.rotation);
            } else
            {
                Debug.Log("Bad");
                GameManager.instance.BadHit();
                Instantiate(BadEffect, BadEffect.transform.position, BadEffect.transform.rotation);
            }

        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag=="Activator")
        {
            canBePressed = true;

        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Activator")
        {
            canBePressed = false;

            GameManager.instance.NoteMissed();
            Instantiate(MissEffect, MissEffect.transform.position, MissEffect.transform.rotation);
        }
    }
}
