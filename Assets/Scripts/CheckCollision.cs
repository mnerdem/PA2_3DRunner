using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CheckCollision : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI CoinText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            //Debug.Log("coin collected!..");
            AddCoin();
            other.gameObject.SetActive(false);
        }
    }

    public void AddCoin()
    {
        score++;
        CoinText.text = "Score: " + score.ToString();

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
