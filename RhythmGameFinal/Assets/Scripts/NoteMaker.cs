using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
//using System.Diagnostics; //��Ÿ��ġ�� ���


public class NoteMaker : MonoBehaviour
{
    public GameObject[] note1;  //��Ʈ1 �� ���� ������Ʈ�� ����(����Ƽ �ν����Ϳ���)
    public GameObject[] note2;  //��Ʈ1 �� ���� ������Ʈ�� ����(����Ƽ �ν����Ϳ���)
    public GameObject[] note3;  //��Ʈ1 �� ���� ������Ʈ�� ����(����Ƽ �ν����Ϳ���)
    public GameObject[] note4;  //��Ʈ1 �� ���� ������Ʈ�� ����(����Ƽ �ν����Ϳ���)



    //�뷡 ����********************************************************************
    //��Ƽ�� ������ Ȱ�� ��Ȱ�� �� �ֱ�
    private int[] noteAry1 ={ 1,1,1,1,1,1,1,1
    };          
    private int[] noteAry2 ={ 1,1,1,1,1,1,1,1

    };          
    private int[] noteAry3 ={ 1,1,1,1,1,1,1,1
    };          
    private int[] noteAry4 ={ 1,1,1,1,1,1,1,1
    };

    //***************************************************************************


    public int noteLenght;//��Ʈ ����-�ν����Ϳ��� �������� �Է�

    private int tmp1;//�ӽ�����
    private int tmp2;
    private int tmp3;
    private int tmp4;
    
    //public bool[] used;




    void Start()
    {


        //noteLenght = 0;

        // 1��и�
        for (int i = 0; i < noteLenght; i++)
        {
            tmp1 = noteAry1[i];
            note1[i].SetActive(Convert.ToBoolean(tmp1));
        }

        // 2��и�
        for (int i = 0; i < noteLenght; i++)
        {
            tmp2 = noteAry2[i];
            note2[i].SetActive(Convert.ToBoolean(tmp2));
        }
        
        
        // 3��и�
        for (int i = 0; i < noteLenght; i++)
        {
            tmp3 = noteAry3[i];
            note3[i].SetActive(Convert.ToBoolean(tmp3));
        }
        
        // 4��и�
        for (int i = 0; i < noteLenght; i++)
        {
            tmp4 = noteAry4[i];
            note4[i].SetActive(Convert.ToBoolean(tmp4));
        }
        
        
    }

    void Update()
    {
        
        
        
    }
    
    
}
