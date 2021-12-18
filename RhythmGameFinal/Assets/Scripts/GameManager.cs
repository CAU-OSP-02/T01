using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//���� ���



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
    public int scorePerGoodNote = 125;
    public int scorePerPerfectNote = 150;

    //��Ƽ�ö��̾�
    public int currentMultiplier;
    public int multiplierTracker;
    public int[] multiplierThresholds;

    public float totalNotes;
    public float badHits;
    public float goodHits;
    public float perfectHits;
    public float missedHits;

    //����ǥ��, ��Ƽǥ��
    public Text scoreText;
    public Text multiText;

    public GameObject resultsScreen;
    public Text badsText, goodsText, perfectsText, missesText, rankText, finalScoreText, comboText;

    public GameObject ComboEffect;
    public int frameRate=60;
    
    
    //���������� ����

    private void Awake()
    {
        Application.targetFrameRate = frameRate; //
    }

    void Start()
    {
        instance = this; // �ڱ� ȣ��
        scoreText.text = "Score : 0";
        
        currentMultiplier = 1;

        totalNotes = FindObjectsOfType<NoteObject>().Length;
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
        else
        {
            if(!theMusic.isPlaying && !resultsScreen.activeInHierarchy)
            {
                resultsScreen.SetActive(true);

                badsText.text = "" + badHits;
                goodsText.text = goodHits.ToString();
                perfectsText.text = perfectHits.ToString();
                missesText.text = "" + missedHits;
                comboText.text = "x" + currentMultiplier;

                string rankVal = "F";
                
                if(perfectHits > 10)
                {
                    rankVal = "D";
                    if(perfectHits>20)
                    {
                        rankVal = "C";
                        if (perfectHits > 30)
                        {
                            rankVal = "B";
                            if (perfectHits > 40)
                            {
                                rankVal = "A";
                                if (perfectHits > 45)
                                {
                                    rankVal = "S";
                                }
                            }
                                
                        }      
                    }
                }

                rankText.text = rankVal;

                finalScoreText.text = currentScore.ToString();    
            }

        }


    }
    public void NoteHit()
    {
        //Debug.Log("Hit On Time");

        if (currentMultiplier - 1 < multiplierThresholds.Length)
        {
            multiplierTracker++;
            

            if (multiplierThresholds[currentMultiplier - 1] <= multiplierTracker)
            {
                multiplierTracker = 0;
                currentMultiplier++;
                Instantiate(ComboEffect, ComboEffect.transform.position, ComboEffect.transform.rotation);
            }
        }

        multiText.text = "Multiplier: x" + currentMultiplier;

        currentScore += scorePerNote * currentMultiplier;
        scoreText.text = "Score : " + currentScore;
    }


    public void PerfectHit()
    {
        currentScore += scorePerPerfectNote * currentMultiplier;
        NoteHit();
        perfectHits++;
    }

    public void GoodHit()
    {
        currentScore += scorePerGoodNote * currentMultiplier;
        NoteHit();
        goodHits++;
    }

    public void BadHit()
    {
        currentScore += scorePerNote * currentMultiplier;
        NoteHit();
        badHits++;
    }

    public void NoteMissed()
    {
        //Debug.Log("Missed Note");

        currentMultiplier = 1;
        multiplierTracker = 0;

        multiText.text = "Multiplier: x" + currentMultiplier;

        missedHits++;
    }
}
