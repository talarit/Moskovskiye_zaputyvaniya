using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerM : MonoBehaviour
{
    [SerializeField] private Text timerText;
    private float _timeLeft = 0f;
    public static int minusscore = 1;

    private IEnumerator StartTimer()
    {
        while (GameM.paranum < 9)
        {
            _timeLeft += Time.deltaTime;
            //минус 150 очков каждые 30 секунд
            if (_timeLeft >= 30 * minusscore)
            {
                minusscore++;
                if (GameM.scorePl > 150)
                {
                    GameM.scorePl -= 150;
                }
                else
                {
                    GameM.scorePl = 0;
                }

            }
            UpdateTimeText();
            yield return null;
        }

    }

    public void StartTime()
    {
        _timeLeft = 0f;
        GameM.timerStart = false;
        GameM.timerStart1 = false;
        StartCoroutine(StartTimer());
    }

    private void UpdateTimeText()
    {
        float minutes = Mathf.FloorToInt(_timeLeft / 60);
        float seconds = Mathf.FloorToInt(_timeLeft % 60);
        timerText.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }
}
