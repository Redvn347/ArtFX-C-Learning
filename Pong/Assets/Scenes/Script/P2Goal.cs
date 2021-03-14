using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class P2Goal : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject _scoretext;
    public GameObject Ball;
    public Rigidbody2D rb;
    public float speed;
    private int _score = 0;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("trigerred,P1 WIns");
        _score++;
        _scoretext.gameObject.GetComponent<TextMeshProUGUI>().text = _score.ToString();
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Ball.GetComponent<Transform>().position = new Vector2(0, 0);
    }

}
