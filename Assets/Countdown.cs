using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Countdown : MonoBehaviour
{
    [SerializeField] float setTime = 10.0f;
    [SerializeField] Text countdownText;
    void Start()
    {
        countdownText.text = setTime.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        setTime -= Time.deltaTime;
        countdownText.text = setTime.ToString();
    }
}
