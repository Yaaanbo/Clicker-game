using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class zombieBehavior : MonoBehaviour
{
    public float movementSpeed;
    [SerializeField] GameObject gameController;
    [SerializeField] GameObject player;
    //public GameObject target;

    [SerializeField] Material zombMat;
    // Update is called once per frame
    private void Start()
    {
        gameController = GameObject.Find("game contoller");
        player = GameObject.Find("player gagal");
        zombMat = gameObject.GetComponent<SpriteRenderer>().material;
    }
    void Update()
    {
        //Vector3 movedir = target.transform.position - this.transform.position;
        //Vector3 velocity = movedir.normalized * movementSpeed * Time.deltaTime;
        //this.transform.position += velocity;
        this.transform.position += Vector3.down * movementSpeed * Time.deltaTime;
        //zombieLerp();
    }

    private void OnMouseDown()
    {
        //this.gameObject.SetActive(false);
        Destroy(gameObject);
        Debug.Log("Anu");
        gameController.GetComponent<count>().score++;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            player.GetComponent<playerBehavior>().takeDamage();
            Destroy(this.gameObject);
        }
    }

    //void zombieLerp()
    //{
    //    zombMat.SetColor("_EmissionColor", Color.Lerp(Color.,Random.ColorHSV(), Time.time));
    //}
}
