using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using System.Diagnostics; //��Ÿ��ġ�� ���


public class NoteMaker : MonoBehaviour
{
    public GameObject[] note1;  //��Ʈ1 �� ���� ������Ʈ�� ����
    //public bool[] ary={ true, false, true, false, true  
    // };          //�Ҹ� ������ Ȱ�� ��Ȱ�� �� �ֱ�
    //public bool[] used;

    void Start()
    {
        note1[1].SetActive(true);
        note1[2].SetActive(true);
        note1[3].SetActive(true);
        note1[4].SetActive(true);
    }

    void Update()
    {
        
        
        
    }
    public int Done()
    {
        return 0;
    }

    
}
