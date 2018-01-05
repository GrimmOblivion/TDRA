using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeForKey : MonoBehaviour
{
    public float timer = 0f;

    public GameObject timeText;

    void Update()
    {

        timer += Time.deltaTime;
        timeText.GetComponent<Text>().text = "Time: " + timer;
    }
}