using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public AudioSource theMusic;
    
    //���ӽ�����?
    public bool startPlaying;
    
    //�ν��Ͻ� ����
    public static GameManager instance;

    //����
    public int currentScore;
    public int scorePerNote = 100;

    //��Ƽ�ö��̾�
    //public int currentMultiplier;
    //public int multiplierTracker;
    //public int[] multiplierThersholds;

    //����ǥ��, ��Ƽǥ��
    public Text scoreText;
    public Text multiText;


    

    void Start()
    {
        instance = this; // �ڱ� ȣ��
        scoreText.text = "Score : 0";
        //
        //currentMultiplier = 1;
    }


    void Update()
    {
        if(!startPlaying)
        {
            if(Input.anyKeyDown)
            {
                startPlaying = true;
                theMusic.Play();
            }
        }
    }
    public void NoteHit()
    {
        Debug.Log("Hit On Time");
        
        /*
        multiplierTracker++;
        if(multiplierThersholds[currentMultiplier-1]<=multiplierTracker)
        {
            multiplierTracker = 0;
            currentMultiplier++;
        }
        */

        currentScore += scorePerNote;
        scoreText.text = "Score : " + currentScore;
    }

    public void NoteMissed()
    {
        Debug.Log("Missed Note");

    }
}
