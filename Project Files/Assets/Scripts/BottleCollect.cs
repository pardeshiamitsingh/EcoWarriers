using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BottleCollect : MonoBehaviour {
    public static int NumBottlesRemaining = 0;
    public static int NumBagsRemaining = 0;
    public Text countText;
    public Text winText;
    private int count;

    void Start()
    {
        NumBottlesRemaining += 1;
        NumBagsRemaining += 1;
        count = 0;
        countText.text = "";
        setCountText();
        winText.text = "";
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("bottle"))
        {
            NumBottlesRemaining -= 1;
            other.gameObject.SetActive(false);
            count = count + 20;
            setCountText();
        }
        else if (other.gameObject.CompareTag("bag"))
        {
            NumBagsRemaining -= 1;
            other.gameObject.SetActive(false);
            count = count + 50;
            setCountText();
        }

        if (NumBottlesRemaining <= 0 && NumBagsRemaining <= 0)
        {
            winText.text = "You Win !";
        }
    }

    void setCountText()
    {
        countText.text = "Count: " + count.ToString();
    }
}
