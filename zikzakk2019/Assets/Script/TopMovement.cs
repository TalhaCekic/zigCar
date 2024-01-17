using System.Collections;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class TopMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;

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
    void Start()
    {
        canvas = GameObject.FindWithTag("GameOverUI");
        canvasT = canvas.transform;
        GameOverScreen = canvasT.GetChild(0);
        //GameOverScreen = transform.Find("GameOverScreen");
        gameoverBackground = GameOverScreen.gameObject.GetComponent<Animator>();
        Time.timeScale = 0;
        rb = GetComponent<Rigidbody>();
        GetComponent<score>();
        //öncelikle topa ileri gitmesini istiroyuz
        rota = Vector3.forward;
        fall = false;
        speed = 2;
        transform.position = new Vector3(0, 0.5f, -0.8f);
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
                gameoverBackground.SetBool("dead", true);

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
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "zemin")
        {
            score.Score++;
            zemin = collision.gameObject;
            //collision.gameObject.AddComponent<Rigidbody>();
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