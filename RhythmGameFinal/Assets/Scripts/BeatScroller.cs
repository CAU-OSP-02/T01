using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatScroller : MonoBehaviour
{


    public float beatTempo;
    public bool hasStarted;

    public int quad=0; 

    void Start()
    {
        beatTempo = beatTempo / 60f;
        Vector3 pos;

        pos=this.gameObject.transform.position;
        //��������Ʈ�� ���� ��ġ�� ���ϱ�


        //��������Ʈ�� ��ġ�� ���� �����̴� ������ �ٸ��� ����

        if (pos.x > 0 && pos.y > 0) //1��и鿡 ���� ��
        {
            quad = 1;
        }
        else if (pos.x < 0 && pos.y > 0) //2��и鿡 ���� ��
        {
            quad = 2;
        }
        else if (pos.x < 0 && pos.y < 0) //3��и鿡 ���� ��
        {
            quad = 3;
        }
        else if (pos.x > 0 && pos.y < 0) //4��и鿡 ���� ��
        {
            quad = 4;
        }


        //Debug.Log(pos);
        //Debug.Log(pos.y);

    }

    // Update is called once per frame
    void Update()
    {
        if(!hasStarted)
        {
            
            if(Input.anyKeyDown)
            {
                hasStarted = true;

            }
                       
        }
        else
        {
            switch (quad)
            {
                case 1: //1��и�
                    transform.position += new Vector3(-1f*beatTempo * Time.deltaTime, -1f*beatTempo * Time.deltaTime, 0f);
                    break;
                case 2: //2��и�
                    transform.position += new Vector3(beatTempo * Time.deltaTime, -1f*beatTempo * Time.deltaTime, 0f);
                    break;
                case 3: //3��и�
                    transform.position += new Vector3(beatTempo * Time.deltaTime, beatTempo * Time.deltaTime, 0f);
                    break;
                case 4: //4��и�
                    transform.position += new Vector3(-1f*beatTempo * Time.deltaTime, beatTempo * Time.deltaTime, 0f);
                    break;


            }

            
        }
    }
}
