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
    // Update is called once per frame

    private void Start()
    {
        player = GameObject.Find("player gagal");
        hiscore = PlayerPrefs.GetInt(SCORETINGGI);
    }
    void Update()
    {
        zombieCountUI.text = "Zombie ded : " + score.ToString();

        hiscoreUI.text = "Most kill : " + hiscore.ToString();

        if (player.GetComponent<playerBehavior>().hp == 0)
        {
           Debug.Log("KALAH");
            playerLose();
        }
    }

    void playerLose()
    {
        if (score > hiscore)
        {
            hiscore = score;
            PlayerPrefs.SetInt(SCORETINGGI, hiscore);
        }
        hiscoreUI.text = "Most kill : " + hiscore.ToString();
        Time.timeScale = 0;
        dedPanel.SetActive(true);
        //mostKillUI.text = "Most kill : " + mostKill.ToString();
    }
}
