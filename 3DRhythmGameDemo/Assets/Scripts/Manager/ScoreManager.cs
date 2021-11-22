using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] UnityEngine.UI.Text txtScore = null;

    [SerializeField] int increaseScore = 10;
    int currentScore = 0;

    [SerializeField] float[] weight = null;
    [SerializeField] int comboBonusScore = 10;

    Animator myAnim;
    string animScoreUp = "ScoreUp";

    ComboManager theCombo;

    // Start is called before the first frame update
    void Start()
    {
        theCombo = FindObjectOfType<ComboManager>();
        myAnim = GetComponent<Animator>();
        currentScore = 0;
        txtScore.text = "0";
    }

    public void IncreaseScore(int p_JudgementState)
    {
        //�޺� ����
        theCombo.IncreaseCombo();

        //�޺� ����ġ ���
        int t_currentCombo = theCombo.GetCurrentCombo();
        int t_bonusComboScore = (t_currentCombo / 10) * comboBonusScore;

        //����ġ ���
        int t_increaseScore = increaseScore + t_bonusComboScore;
        t_increaseScore = (int)(t_increaseScore * weight[p_JudgementState]);

        currentScore += t_increaseScore;
        txtScore.text = string.Format("{0:#,##0}", currentScore);

        //�ִϽ���
        myAnim.SetTrigger(animScoreUp);
    }

    public int GetCurrentScore()
    {
        return currentScore;
    }
}
