using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class count : MonoBehaviour
{
    public int hiscore;
    public int score;
    [SerializeField] TMP_Text zombieCountUI, hiscoreUI;

    string SCORETINGGI = "hiscore";
    [SerializeField] GameObject player;
    [SerializeField] GameObject dedPanel;
    [SerializeField] GameObject pausePanel;
    [SerializeField] GameObject gameController;
    // Update is called once per frame

    private void Start()
    {
        player = GameObject.Find("player gagal");
        hiscore = PlayerPrefs.GetInt(SCORETINGGI);
    }
    void Update()
    {
        zombieCountUI.text = "Tuan berbibir besar : " + score.ToString();

        hiscoreUI.text = "Most kill : " + hiscore.ToString();

        if (player.GetComponent<playerBehavior>().hp == 0)
        {
           Debug.Log("KALAH");
            playerLose();
        }

        if (dedPanel.activeSelf || pausePanel.activeSelf)
            Time.timeScale = 0;
        else
            Time.timeScale = 1;
    }

    void playerLose()
    {
        if (score > hiscore)
        {
            hiscore = score;
            PlayerPrefs.SetInt(SCORETINGGI, hiscore);
        }
        hiscoreUI.text = "Most kill : " + hiscore.ToString();
        //hiscoreUI.text = $"Most kill : {hiscore.ToString()}";
        
        dedPanel.SetActive(true);

        mainMenu.instance.ded();
        //mostKillUI.text = "Most kill : " + mostKill.ToString();
    }
}
