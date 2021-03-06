using System.Collections;
using System.Collections.Generic;
using UnityEngine;



//노트 움직임 구현



public class BeatScroller : MonoBehaviour
{


    public float beatTempo;
    public bool hasStarted;

    public int quad=0; //사분면


    //public float calibration= 0.4006759f;//보정 값

    void Start()
    {
        beatTempo = beatTempo / 60f;
        Vector3 pos;

        pos=this.gameObject.transform.position;
        //스프라이트의 현재 위치값 구하기


        //스프라이트의 위치에 따라서 움직이는 방향을 다르게 설정

        
        if (pos.x > 0 && pos.y > 0) //1사분면에 있을 때
        {
            quad = 1;
        }
        else if (pos.x < 0 && pos.y > 0) //2사분면에 있을 때
        {
            quad = 2;
        }
        else if (pos.x < 0 && pos.y < 0) //3사분면에 있을 때
        {
            quad = 3;
        }
        else if (pos.x > 0 && pos.y < 0) //4사분면에 있을 때
        {
            quad = 4;
        }
       

        //Debug.Log(pos);
        //Debug.Log(pos.y);

    }



    void Update()
    {
        switch (quad)
        {
            case 1: //1사분면
                gameObject.transform.position += new Vector3(-1f * beatTempo * Time.deltaTime, -1f * beatTempo * Time.deltaTime, 0f);
                break;
            case 2: //2사분면
                gameObject.transform.position += new Vector3(beatTempo * Time.deltaTime, -1f * beatTempo * Time.deltaTime, 0f);
                break;
            case 3: //3사분면
                gameObject.transform.position += new Vector3(beatTempo * Time.deltaTime, beatTempo * Time.deltaTime, 0f);
                break;
            case 4: //4사분면
                gameObject.transform.position += new Vector3(-1f * beatTempo * Time.deltaTime, beatTempo * Time.deltaTime, 0f);
                break;
        }
        
    }

}
