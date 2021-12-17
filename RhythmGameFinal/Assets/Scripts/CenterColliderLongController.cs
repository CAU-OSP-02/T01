using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterColliderLongController : MonoBehaviour
{
    public GameObject MissEffect;
    public bool isCrashed;

    void Start()
    {
        isCrashed = false;
    }


    void Update()   //Miss ��
    {
        if (isCrashed == true)
        {
            gameObject.SetActive(false);
        }

    }

    /*
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "ColliderLong")
        {
            //gameObject.transform.localScale += new Vector3(0, -0.5f * Time.deltaTime, 0f);
        }

    }
    */

    private void OnTriggerStay2D(Collider2D other)
    {
        if(other.tag=="ColliderLong")
        {
            //���� �پ��� �ִϸ��̼�
            if(gameObject.transform.localScale.y > 0.1f) //y�� ���̰� ����� ��(�����̸� �ݴ�α��� �̹����� ����)
                gameObject.transform.localScale += new Vector3(0, -0.6f *Time.deltaTime, 0f);
            else
                isCrashed = true; //��Ȱ��ȭ ���ѹ���
            //Debug.Log(gameObject.transform.localScale.y);
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "ColliderLong")
        {
            isCrashed = true;
            //isCrashed = false;
            GameManager.instance.NoteMissed();
            Instantiate(MissEffect, MissEffect.transform.position, MissEffect.transform.rotation);
        }
    }
}
