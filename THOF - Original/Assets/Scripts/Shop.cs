using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    moving player;

    [HideInInspector]
    public bool isOpen = false;
    public bool inShop1 = false;
    public bool inShop2 = false;
    public bool inShop3 = false;
    
    public Image item1;
    public Image item2;
    public Image item3;
    public Image item5;
    public Image item6;
    public Image item7;
    public Image item8;

    public Text item1_text;
    public Text item2_text;
    public Text item3_text;

    public ShopItems snow;
    public ShopItems blade;
    public ShopItems charge;
    public ShopItems castle;
    public ShopItems water;
    public ShopItems shock;
    public ShopItems arson;

    public GameObject hp;

    private Text noMoney;
    private Text buyInfo;

    public GameObject shop1;
    public GameObject shop2;

    Stats stats;
    ShopItems shopItems;
    InventoryUI invUI;

    // Update is called once per frame
    void Update()
    {
        player = GameObject.Find("Player").GetComponent<moving>();
        stats = GameObject.Find("Player").GetComponent<Stats>();
        invUI = GameObject.Find("UI").GetComponent<InventoryUI>();

        noMoney = GameObject.Find("Canvas/Error").GetComponent<Text>();
        buyInfo = GameObject.Find("Canvas/BuyInfo").GetComponent<Text>();

        if(player.inShop == true && Input.GetKeyDown(KeyCode.E))
        {
            OpenShop();
        }
    }

    public void OpenShop()
    {
        isOpen = !isOpen;

        if(isOpen == true && invUI.isOpen == true)
        {
            ChangeItems();
            transform.GetChild(0).gameObject.SetActive(true);
            invUI.ui_Anchor.SetActive(false);
            invUI.isOpen = false;
            player.shopText.text = "Press E To Close Shop";
            player.inAction = false;
        }
        else
        {
            ChangeItems();
            transform.GetChild(0).gameObject.SetActive(true);
            player.shopText.text = "Press E To Close Shop";
        }
        
        if(isOpen == false)
        {
            transform.GetChild(0).gameObject.SetActive(false);
            player.shopText.text = "Press E To Open Shop";
        }
        
    }

    void ChangeItems()
    {
        if(inShop1 == true)
        {
            item1.sprite = charge.image;
            item1_text.text = charge.itemName.ToString() + " for " + charge.howMuch.ToString() + " Coins";
            item1.tag = "Attack1";

            item2.sprite = castle.image;
            item2_text.text = castle.itemName.ToString() + " for " + castle.howMuch.ToString() + " Coins";
            item2.tag = "Attack2";

            item1.enabled = true;
            item1_text.enabled = true;
            item2.enabled = true;
            item2_text.enabled = true;
            item3.enabled = false;
            item3_text.enabled = false;

            Debug.Log("changed items for shop1");
        }

        if(inShop2 == true)
        {
            item1.sprite = snow.image;
            item1_text.text = snow.itemName.ToString() + " for " + snow.howMuch.ToString() + " Coins";
            item1.tag = "Attack8";

            item2.sprite = water.image;
            item2_text.text = water.itemName.ToString() + " for " + water.howMuch.ToString() + " Coins";
            item2.tag = "Attack3";

            item1.enabled = true;
            item1_text.enabled = true;
            item2.enabled = true;
            item2_text.enabled = true;
            item3.enabled = false;
            item3_text.enabled = false;

            Debug.Log("changed items for shop2");
        }

        if(inShop3 == true)
        {
            item1.sprite = arson.image;
            item1_text.text = arson.itemName.ToString() + " for " + arson.howMuch.ToString() + " Coins";
            item1.tag = "Attack7";

            item2.sprite = shock.image;
            item2_text.text = shock.itemName.ToString() + " for " + shock.howMuch.ToString() + " Coins";
            item2.tag = "Attack6";

            item3.sprite = blade.image;
            item3_text.text = blade.itemName.ToString() + " for " + blade.howMuch.ToString() + " Coins";
            item3.tag = "Attack5";


            item1.enabled = true;
            item1_text.enabled = true;
            item2.enabled = true;
            item2_text.enabled = true;
            item3.enabled = true;
            item3_text.enabled = true;

            Debug.Log("changed items for shop3");
        }
    }

    public void BuyItem(Button btn)
    {
        #region Phone
        if (stats.coins >= charge.howMuch & btn.tag == "Attack1")
        {
            item1.enabled = false;
            item1_text.enabled = false;
            stats.coins -= charge.howMuch;
            invUI.attack1.isBought = true;
            invUI.CheckItems();
            buyInfo.text = "Bought " + charge.itemName.ToString();
            buyInfo.enabled = true;
            StartCoroutine(BuyWait());
        }
        else if(stats.coins <= charge.howMuch & btn.tag == "Attack1")
        {
            noMoney.text = "Not enough money";
            noMoney.enabled = true;
            StartCoroutine(Wait());
        }
        #endregion

        #region Sandcastle
        if (stats.coins >= castle.howMuch & btn.tag == "Attack2")
        {
            item2.enabled = false;
            item2_text.enabled = false;
            stats.coins -= castle.howMuch;
            invUI.attack2.isBought = true;
            invUI.CheckItems();
            buyInfo.text = "Bought " + castle.itemName.ToString();
            buyInfo.enabled = true;
            StartCoroutine(BuyWait());
        }
        else if(stats.coins <= castle.howMuch & btn.tag == "Attack2")
        {
            noMoney.text = "Not enough money";
            noMoney.enabled = true;
            StartCoroutine(Wait());
        }
        #endregion

        #region Water Gun
        if (stats.coins >= water.howMuch & btn.tag == "Attack3")
        {
            item2.enabled = false;
            item2_text.enabled = false;
            stats.coins -= water.howMuch;
            invUI.attack3.isBought = true;
            invUI.CheckItems();
            buyInfo.text = "Bought " + water.itemName.ToString();
            buyInfo.enabled = true;
            StartCoroutine(BuyWait());
        }
        else if(stats.coins <= water.howMuch & btn.tag == "Attack3")
        {
            noMoney.text = "Not enough money";
            noMoney.enabled = true;
            StartCoroutine(Wait());
        }
        #endregion

        #region Blade
        if (stats.coins >= blade.howMuch & btn.tag == "Attack5")
        {
            item3.enabled = false;
            item3_text.enabled = false;
            stats.coins -= blade.howMuch;
            invUI.attack5.isBought = true;
            invUI.CheckItems();
            buyInfo.text = "Bought " + blade.itemName.ToString();
            buyInfo.enabled = true;
            StartCoroutine(BuyWait());
        }
        else if (stats.coins <= blade.howMuch & btn.tag == "Attack5")
        {
            noMoney.text = "Not enough money";
            noMoney.enabled = true;
            StartCoroutine(Wait());
        }
        #endregion

        #region Shock
        if (stats.coins >= shock.howMuch & btn.tag == "Attack6")
        {
            item2.enabled = false;
            item2_text.enabled = false;
            stats.coins -= shock.howMuch;
            invUI.attack6.isBought = true;
            invUI.CheckItems();
            buyInfo.text = "Bought " + shock.itemName.ToString();
            buyInfo.enabled = true;
            StartCoroutine(BuyWait());
        }
        else if (stats.coins <= 200 & btn.tag == "Attack6")
        {
            noMoney.text = "Not enough money";
            noMoney.enabled = true;
            StartCoroutine(Wait());
        }
        #endregion

        #region Arson
        if (stats.coins >= arson.howMuch & btn.tag == "Attack7")
        {
            item1.enabled = false;
            item1_text.enabled = false;
            stats.coins -= arson.howMuch;
            invUI.attack7.isBought = true;
            invUI.CheckItems();
            buyInfo.text = "Bought " + arson.itemName.ToString();
            buyInfo.enabled = true;
            StartCoroutine(BuyWait());
        }
        else if (stats.coins <= 200 & btn.tag == "Attack7")
        {
            noMoney.text = "Not enough money";
            noMoney.enabled = true;
            StartCoroutine(Wait());
        }
        #endregion

        #region Snowball
        if (stats.coins >= snow.howMuch & btn.tag == "Attack8")
        {
            item1.enabled = false;
            item1_text.enabled = false;
            stats.coins -= snow.howMuch;
            invUI.attack8.isBought = true;
            invUI.CheckItems();
            buyInfo.text = "Bought " + snow.itemName.ToString();
            buyInfo.enabled = true;
            StartCoroutine(BuyWait());
        }
        else if (stats.coins <= snow.howMuch & btn.tag == "Attack8")
        {
            noMoney.text = "Not enough money";
            noMoney.enabled = true;
            StartCoroutine(Wait());
        }
        #endregion
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(3);
        noMoney.enabled = false;
    }

    IEnumerator BuyWait()
    {
        yield return new WaitForSeconds(3);
        buyInfo.enabled = false;
    }
}
