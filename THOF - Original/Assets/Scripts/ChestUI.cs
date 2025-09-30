using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChestUI : MonoBehaviour
{
    public bool isOpen;

    public ChestItems coins;

    public Image item1;
    public Text item1_text;

    public Button btn_1;

    public Text takeText;

    Stats stats;
    InventoryUI invUI;
    moving player;


    private void Start()
    {
        stats = GameObject.Find("Player").GetComponent<Stats>();
        player = GameObject.Find("Player").GetComponent<moving>();
        invUI = GameObject.Find("Canvas/UI").GetComponent<InventoryUI>();

        takeText.text = "";
        item1_text.text = "";
    }

    private void Update()
    {
        if(player.inChest == true && Input.GetKeyDown(KeyCode.E))
        {
            OpenChest();
        }
    }

    public void OpenChest()
    {
        isOpen = !isOpen;

        if(isOpen == true && invUI.isOpen == true)
        {
            transform.GetChild(0).gameObject.SetActive(true);
            invUI.ui_Anchor.SetActive(false);
            invUI.isOpen = false;
            player.chestText.text = "Press E To Close Chest";
            player.inAction = false;
            CheckItems();
        }
        else
        {
            transform.GetChild(0).gameObject.SetActive(true);
            player.chestText.text = "Press E To Close Chest";
            CheckItems();
        }

        if(isOpen == false)
        {
            transform.GetChild(0).gameObject.SetActive(false);
            player.chestText.text = "Press E To Open Chest";
        }
    }

    void CheckItems()
    {
        if(coins.inChest == true)
        {
            item1.sprite = coins.image;
            item1_text.text = coins.amount.ToString() + coins.type.ToString();
        }
    }

    public void TakeStuff(Button btn)
    {
        if(btn.tag == "Coins")
        {
            item1.enabled = false;
            stats.coins += coins.amount;
            takeText.text = "You got " + coins.amount.ToString() + coins.type.ToString();
            StartCoroutine(TakeWait());
        }
    }

    IEnumerator TakeWait()
    {
        yield return new WaitForSeconds(2);
        takeText.text = "";
    }
}
