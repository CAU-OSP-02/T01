using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObjectLong : MonoBehaviour
{

    public bool canBePressed;
    public KeyCode KeyToPress; //Ű ����
    //public Collider col1, col2;

    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetKey(KeyToPress)&& canBePressed==true) //�� ������ �ֱ�! GetKey
        {

            //GameManager.instance.LongHit();

            if (gameObject.transform.localScale.y > 0.1f) //y�� ���̰� ����� ��(�����̸� �ݴ�α��� �̹����� ����)
                gameObject.transform.localScale += new Vector3(0, -0.6f * Time.deltaTime, 0f);
            else
                gameObject.SetActive(false); ;
            //}
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Activator")
        {
            canBePressed = true;
        }
    }



}
