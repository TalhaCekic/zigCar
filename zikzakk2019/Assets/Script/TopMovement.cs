using System;
using System.Collections;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class TopMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;

    public static TopMovement instance;
    //hýz ve yn veriyoruz
    Vector3 rota;
    public float speed;
    public ZeminSpawn zeminSPAWN;
    public GameObject zemin;
    public static bool fall;
    public float run;

    public GameObject canvas;
    public Transform canvasT;
    public Transform GameOverScreen;
    public Animator gameoverBackground;

    public float rotationSpeed;

    public string fuelString = "fuel";
    public string wheelString = "wheel";
    public float MaxFuel;
    public float currentFuel;
    public int fuelAdd;
    public int wheel;
    public int wheelAdd;
    void Start()
    {
        instance = this;
        canvas = GameObject.FindWithTag("GameOverUI");
        canvasT = canvas.transform;
        GameOverScreen = canvasT.GetChild(0);
        //GameOverScreen = transform.Find("GameOverScreen");
        gameoverBackground = GameOverScreen.gameObject.GetComponent<Animator>();
        Time.timeScale = 0;
        rb = GetComponent<Rigidbody>();
        GetComponent<score>();
        //öncelikle aracın ileri gitmesini istiroyuz
        rota = Vector3.forward;
        fall = false;
        speed = 2;
        transform.position = new Vector3(0, 0.5f, -0.8f);

        currentFuel = MaxFuel;
        fuelAdd = 20;
        wheelAdd= 1;
        wheel = PlayerPrefs.GetInt(wheelString, wheel);
    }

    void Update()
    {
        if (transform.position.y <= -1f)
        {
            fall = true;
            //ölme:::
            GameOverScreen.gameObject.SetActive(true);
            if (GameOverScreen == true)
            {
                if (transform.position.y <= -25f)
                {
                    Time.timeScale = 0;
                }
            }

            if (fall == true)
            {
                return;
            }
        }
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began && !EventSystem.current.IsPointerOverGameObject(touch.fingerId))
            {
                Time.timeScale = 1;
                if (rota.x == 0)
                {
                    rota = Vector3.left;
                }
                else
                {
                    rota = Vector3.forward;
                }

                speed += run * Time.deltaTime;
            }
        }

        if (rota == Vector3.left)
        {
            transform.localRotation = Quaternion.Lerp(transform.rotation,quaternion.RotateY(4.7f), Time.deltaTime * rotationSpeed);
        }
        else
        {
            transform.localRotation = Quaternion.Lerp(transform.rotation,quaternion.RotateY(0), Time.deltaTime * rotationSpeed);
        }
    }

    private void FixedUpdate()
    {
        Vector3 hareket = rota * Time.deltaTime * speed;
        transform.position += hareket;

    
        currentFuel -= Time.deltaTime;
        if (currentFuel > MaxFuel)
        {
            currentFuel = MaxFuel;
        }
        else if(currentFuel <=0)
        {
            //ölme:::
            GameOverScreen.gameObject.SetActive(true);
            if (GameOverScreen == true)
            {
                if (transform.position.y <= -25f)
                {
                    Time.timeScale = 0;
                }
            }
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "fuelTank")
        {
            currentFuel += fuelAdd;
            collision.gameObject.GetComponent<thisRotation>().activeFalse();
        }
        if (collision.gameObject.tag == "wheel")
        {
            wheel += 500;
           // wheel += wheelAdd;
            collision.gameObject.GetComponent<wheelRotation>().activeFalse();
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "zemin")
        {
            score.Score++;
            zemin = collision.gameObject;
            zeminSPAWN.zeminOlustur();
            StartCoroutine(ZeminSil(collision.gameObject));
            StartCoroutine(ZeminRbAdd(collision.gameObject));
        }
    }


    IEnumerator ZeminSil(GameObject silinecekZemin)
    {
        yield return new WaitForSeconds(3f);
        Destroy(silinecekZemin);
    }  
    IEnumerator ZeminRbAdd(GameObject silinecekZemin)
    {
        yield return new WaitForSeconds(0.2f);
        zemin.AddComponent<Rigidbody>();
    }
}