using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class playerBehavior : MonoBehaviour
{
    public float playerSpeed;

    public float hp;
    float maxHp;
    public Image HPbar;

    GameObject zomb;
    //public GameObject dedPanel;

    [SerializeField] float maxPos;

    public Material playerMat;
    public Color startColor;
    public Color endColor;


    // Start is called before the first frame update
    void Start()
    {
        zomb = GameObject.Find("zspawner");
        maxHp = hp;
    }

    // Update is called once per frame
    void Update()
    {
        //gameOver();
        this.transform.position = new Vector3(Mathf.PingPong(Time.time * playerSpeed, maxPos), this.transform.position.y, this.transform.position.z);
        colorLerp();
    }

    public void takeDamage()
    {
        hp--;
        HPbar.fillAmount = hp / maxHp;
    }

    //public void gameOver()
    //{
    //    if (hp == 0)
    //    {
    //        Debug.Log("MATI LO");
    //        Time.timeScale = 0;
    //        dedPanel.SetActive(true);
    //    }
    //}

    void colorLerp()
    {
        playerMat.SetColor("_EmissionColor", Color.Lerp(startColor, endColor, Mathf.PingPong(Time.time, 1)));
    }
}
