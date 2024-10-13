using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int StagePoint = 0;
    [SerializeField] private int goal_Point;
    [SerializeField] private Image[] UI_Image;
    [SerializeField] private TMP_Text UI_Point;
    [SerializeField] private TMP_Text UI_GoalPoint;
    [SerializeField] private Button Next_Button;
    [SerializeField] private Button Main_Button;
    [SerializeField] private string Next_Scene_name;
    [SerializeField] private Button End_Button;
    [SerializeField] private Timer timer;
    [SerializeField] private TMP_Text UI_Complete_Timer;
    [SerializeField] private float completeTime;
    
    void Awake()
    {
        Instance = this;

        if(UI_Point != null)
        {
            UI_Point.text = StagePoint.ToString();
        }
        if(UI_GoalPoint != null)
        {
            UI_GoalPoint.text = goal_Point.ToString();
        }
        if (Next_Button != null)
        {
            Next_Button.onClick.AddListener(Next_Stage);
        }


    }

    private void Start()
    {

    }

    private void Update()
    {
        if (SceneManager.GetActiveScene().name == "Main")
            return;

        if (UI_Point != null)
        {
            UI_Point.text = StagePoint.ToString();
        }


        if (StagePoint == goal_Point)
        {
            timer.StopTimer_Cor();
            completeTime = timer.timer;
            int minutes = Mathf.FloorToInt(completeTime / 60);
            int seconds = Mathf.FloorToInt(completeTime % 60);
            float milliseconds = (completeTime * 100) % 100;
            UI_Complete_Timer.text = string.Format("{0:D2}:{1:D2}:{2:00}", minutes, seconds, Mathf.FloorToInt(milliseconds));
            UI_Image[0].gameObject.SetActive(false);
            UI_Image[1].gameObject.SetActive(true);
        }
    }

    void Next_Stage()
    {
        SceneManager.LoadScene(Next_Scene_name);
    }


}