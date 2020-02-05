using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
	private int minute;

	private float seconds;

	private float oldSeconds;

	private Text timerText;

    // Start is called before the first frame update
    void Start()
    {
		minute = 0;
		seconds = 0f;
		oldSeconds = 0f;
		timerText = GetComponent<Text> ();
    }

    // Update is called once per frame
    void Update()
    {
		seconds += Time.deltaTime;
		if (seconds >= 60f) {
			minute++;
			seconds = seconds - 60;
		}

		if ((int)seconds != (int)oldSeconds) {
			timerText.text = minute.ToString("00") + ":" + ((int)seconds).ToString("00");
		}
		oldSeconds = seconds;
    }
}
