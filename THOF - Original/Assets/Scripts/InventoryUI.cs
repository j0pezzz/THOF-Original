using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class InventoryUI : MonoBehaviour
{

    public ShopItems attack1;
    public ShopItems attack2;
    public ShopItems attack3;
    public ShopItems attack4;
    public ShopItems attack5;
    public ShopItems attack6;
    public ShopItems attack7;
    public ShopItems attack8;

    public ShopItems n_attack1;
    public ShopItems n_attack2;

    public Image attack_img;
    public Image attack2_img;
    public Image attack3_img;
    public Image attack4_img;
    public Image attack5_img;
    public Image attack6_img;
    public Image attack7_img;
    public Image attack8_img;

    public Button btn_1;
    public Button btn_2;
    public Button btn_3;
    public Button btn_4;
    public Button btn_5;
    public Button btn_6;
    public Button btn_7;
    public Button btn_8;

    public Image currentAttack_img;
    public Image cur_nAttack_img;
    public Image cur_nAttack2_img;

    public GameObject bAttacksTab;
    public GameObject cAttacksTab;

    public GameObject invTab;
    public GameObject upgradeTab;
    public GameObject mapTab;

    public GameObject ui_Anchor;

    public GameObject weaponInfo;
    public Text weaponName;
    public Text weaponStrength;
    public Text weaponSpeed;
    public Text weaponHealing;

    Stats stats;
    Shop shop;
    moving player;
    ChestUI chestUI;

    public Text equipText;

    public bool isOpen = false;



    private void Start()
    {
        attack1.isBought = false;
        attack2.isBought = false;
        attack3.isBought = false;
        attack5.isBought = false;
        attack6.isBought = false;
        attack7.isBought = false;
        attack8.isBought = false;

        attack4.isEquip = true;
        n_attack1.isEquip = true;
        n_attack2.isEquip = true;

        attack1.isEquip = false;
        attack2.isEquip = false;
        attack3.isEquip = false;
        attack5.isEquip = false;
        attack6.isEquip = false;
        attack7.isEquip = false;
        attack8.isEquip = false;

        attack1.isInv = false;
        attack2.isInv = false;
        attack3.isInv = false;
        attack4.isInv = false;
        attack5.isInv = false;
        attack6.isInv = false;
        attack7.isInv = false;
        attack8.isInv = false;

        CheckItems();

        stats = GameObject.Find("Player").GetComponent<Stats>();
        shop = GameObject.Find("Canvas/Shop").GetComponent<Shop>();
        player = GameObject.Find("Player").GetComponent<moving>();
        chestUI = GameObject.Find("Canvas/ChestUI").GetComponent<ChestUI>();
    }

    public void OpenUI()
    {
        isOpen = !isOpen;

        if (isOpen == true && shop.isOpen == true)
        {
            ui_Anchor.SetActive(true);
            shop.transform.GetChild(0).gameObject.SetActive(false);
            shop.isOpen = false;
            player.shopText.text = "Press E To Open Shop";
            player.inAction = true;
        }
        else if (isOpen == true && chestUI.isOpen == true)
        {
            ui_Anchor.SetActive(true);
            chestUI.transform.GetChild(0).gameObject.SetActive(false);
            chestUI.isOpen = false;
            player.chestText.text = "Press E To Open Chest";
            player.inAction = true;
        }
        else
        {
            ui_Anchor.SetActive(true);
            player.inAction = true;
        }

        if (isOpen == false)
        {
            ui_Anchor.SetActive(false);
            player.inAction = false;
        }
    }

    #region Tabs

    public void OpenInventory()
    {
        CloseMainTabs();
        invTab.SetActive(true);
    }

    public void OpenUpgrade()
    {
        CloseMainTabs();
        upgradeTab.SetActive(true);
    }

    public void OpenMap()
    {
        CloseMainTabs();
        mapTab.SetActive(true);
    }

    private void CloseMainTabs()
    {
        upgradeTab.SetActive(false);
        invTab.SetActive(false);
        mapTab.SetActive(false);
    }



    public void boughtAttacksTab()
    {
        CloseTabs();
        bAttacksTab.SetActive(true);
        weaponInfo.SetActive(false);
    }

    public void currentAttacksTab()
    {
        CloseTabs();
        cAttacksTab.SetActive(true);
        CurrentWeapons();
    }

    void CloseTabs()
    {
        bAttacksTab.SetActive(false);
        cAttacksTab.SetActive(false);
    }

    #endregion


    public void CheckItems()
    {
        #region Phone
        if (attack1.isBought == true && attack1.isInv == false && attack_img.enabled == false)
        {
            attack_img.sprite = attack1.image;
            attack_img.enabled = true;
            btn_1 = attack_img.GetComponent<Button>();
            attack_img.tag = "phone";
            attack1.isInv = true;
        }
        else if (attack1.isBought == true && attack1.isInv == false && attack2_img.enabled == false)
        {
            attack2_img.sprite = attack1.image;
            attack2_img.enabled = true;
            btn_2 = attack2_img.GetComponent<Button>();
            attack2_img.tag = "phone";
            attack1.isInv = true;
        }
        else if (attack1.isBought == true && attack1.isInv == false && attack3_img.enabled == false)
        {
            attack3_img.sprite = attack1.image;
            attack3_img.enabled = true;
            btn_3 = attack3_img.GetComponent<Button>();
            attack3_img.tag = "phone";
            attack1.isInv = true;
        }
        else if (attack1.isBought == true && attack1.isInv == false && attack4_img.enabled == false)
        {
            attack4_img.sprite = attack1.image;
            attack4_img.enabled = true;
            btn_4 = attack4_img.GetComponent<Button>();
            attack4_img.tag = "phone";
            attack1.isInv = true;
        }
        else if (attack1.isBought == true && attack1.isInv == false && attack5_img.enabled == false)
        {
            attack5_img.sprite = attack1.image;
            attack5_img.enabled = true;
            btn_5 = attack5_img.GetComponent<Button>();
            attack5_img.tag = "phone";
            attack1.isInv = true;
        }
        else if (attack1.isBought == true && attack1.isInv == false && attack6_img.enabled == false)
        {
            attack6_img.sprite = attack1.image;
            attack6_img.enabled = true;
            btn_6 = attack6_img.GetComponent<Button>();
            attack6_img.tag = "phone";
            attack1.isInv = true;
        }
        else if (attack1.isBought == true && attack1.isInv == false && attack7_img.enabled == false)
        {
            attack7_img.sprite = attack1.image;
            attack7_img.enabled = true;
            btn_7 = attack7_img.GetComponent<Button>();
            attack7_img.tag = "phone";
            attack1.isInv = true;
        }
        else if (attack1.isBought == true && attack1.isInv == false && attack8_img.enabled == false)
        {
            attack8_img.sprite = attack1.image;
            attack8_img.enabled = true;
            btn_8 = attack8_img.GetComponent<Button>();
            attack8_img.tag = "phone";
            attack1.isInv = true;
        }
        #endregion

        #region Sandcastle
        if (attack2.isBought == true && attack2.isInv == false && attack_img.enabled == false)
        {
            attack_img.sprite = attack2.image;
            attack_img.enabled = true;
            btn_1 = attack_img.GetComponent<Button>();
            attack_img.tag = "sandcastle";
            attack2.isInv = true;
        }
        else if (attack2.isBought == true && attack2.isInv == false && attack2_img.enabled == false)
        {
            attack2_img.sprite = attack2.image;
            attack2_img.enabled = true;
            btn_2 = attack2_img.GetComponent<Button>();
            attack2_img.tag = "sandcastle";
            attack2.isInv = true;
        }
        else if (attack2.isBought == true && attack2.isInv == false && attack3_img.enabled == false)
        {
            attack3_img.sprite = attack2.image;
            attack3_img.enabled = true;
            btn_3 = attack3_img.GetComponent<Button>();
            attack3_img.tag = "sandcastle";
            attack2.isInv = true;
        }
        else if (attack2.isBought == true && attack2.isInv == false && attack4_img.enabled == false)
        {
            attack4_img.sprite = attack2.image;
            attack4_img.enabled = true;
            btn_4 = attack4_img.GetComponent<Button>();
            attack4_img.tag = "sandcastle";
            attack2.isInv = true;
        }
        else if (attack2.isBought == true && attack2.isInv == false && attack5_img.enabled == false)
        {
            attack5_img.sprite = attack2.image;
            attack5_img.enabled = true;
            btn_5 = attack5_img.GetComponent<Button>();
            attack5_img.tag = "sandcastle";
            attack2.isInv = true;
        }
        else if (attack2.isBought == true && attack2.isInv == false && attack6_img.enabled == false)
        {
            attack6_img.sprite = attack2.image;
            attack6_img.enabled = true;
            btn_6 = attack6_img.GetComponent<Button>();
            attack6_img.tag = "sandcastle";
            attack2.isInv = true;
        }
        else if (attack2.isBought == true && attack2.isInv == false && attack7_img.enabled == false)
        {
            attack7_img.sprite = attack2.image;
            attack7_img.enabled = true;
            btn_7 = attack7_img.GetComponent<Button>();
            attack7_img.tag = "sandcastle";
            attack2.isInv = true;
        }
        else if (attack2.isBought == true && attack2.isInv == false && attack8_img.enabled == false)
        {
            attack8_img.sprite = attack2.image;
            attack8_img.enabled = true;
            btn_8 = attack8_img.GetComponent<Button>();
            attack8_img.tag = "sandcastle";
            attack2.isInv = true;
        }
        #endregion

        #region Water Gun
        if (attack3.isBought == true && attack3.isInv == false && attack_img.enabled == false)
        {
            attack_img.sprite = attack3.image;
            attack_img.enabled = true;
            btn_1 = attack_img.GetComponent<Button>();
            attack_img.tag = "water";
            attack3.isInv = true;
        }
        else if (attack3.isBought == true && attack3.isInv == false && attack2_img.enabled == false)
        {
            attack2_img.sprite = attack3.image;
            attack2_img.enabled = true;
            btn_2 = attack2_img.GetComponent<Button>();
            attack2_img.tag = "water";
            attack3.isInv = true;
        }
        else if (attack3.isBought == true && attack3.isInv == false && attack3_img.enabled == false)
        {
            attack3_img.sprite = attack3.image;
            attack3_img.enabled = true;
            btn_3 = attack3_img.GetComponent<Button>();
            attack3_img.tag = "water";
            attack3.isInv = true;
        }
        else if (attack3.isBought == true && attack3.isInv == false && attack4_img.enabled == false)
        {
            attack4_img.sprite = attack3.image;
            attack4_img.enabled = true;
            btn_4 = attack4_img.GetComponent<Button>();
            attack4_img.tag = "water";
            attack3.isInv = true;
        }
        else if (attack3.isBought == true && attack3.isInv == false && attack5_img.enabled == false)
        {
            attack5_img.sprite = attack3.image;
            attack5_img.enabled = true;
            btn_5 = attack5_img.GetComponent<Button>();
            attack5_img.tag = "water";
            attack3.isInv = true;
        }
        else if (attack3.isBought == true && attack3.isInv == false && attack6_img.enabled == false)
        {
            attack6_img.sprite = attack3.image;
            attack6_img.enabled = true;
            btn_6 = attack6_img.GetComponent<Button>();
            attack6_img.tag = "water";
            attack3.isInv = true;
        }
        else if (attack3.isBought == true && attack3.isInv == false && attack7_img.enabled == false)
        {
            attack7_img.sprite = attack3.image;
            attack7_img.enabled = true;
            btn_7 = attack7_img.GetComponent<Button>();
            attack7_img.tag = "water";
            attack3.isInv = true;
        }
        else if (attack3.isBought == true && attack3.isInv == false && attack8_img.enabled == false)
        {
            attack8_img.sprite = attack3.image;
            attack8_img.enabled = true;
            btn_8 = attack8_img.GetComponent<Button>();
            attack8_img.tag = "water";
            attack3.isInv = true;
        }
        #endregion

        #region Stick
        if (attack4.isBought == true && attack4.isInv == false && attack_img.enabled == false)
        {
            attack_img.sprite = attack4.image;
            attack_img.enabled = true;
            btn_1 = attack_img.GetComponent<Button>();
            attack_img.tag = "stick";
            attack4.isInv = true;
        }
        else if (attack4.isBought && attack4.isInv == false && attack2_img.enabled == false)
        {
            attack2_img.sprite = attack4.image;
            attack2_img.enabled = true;
            btn_2 = attack2_img.GetComponent<Button>();
            attack2_img.tag = "stick";
            attack4.isInv = true;
        }
        else if (attack4.isBought == true && attack4.isInv == false && attack3_img.enabled == false)
        {
            attack3_img.sprite = attack4.image;
            attack3_img.enabled = true;
            btn_3 = attack3_img.GetComponent<Button>();
            attack3_img.tag = "stick";
            attack4.isInv = true;
        }
        else if (attack4.isBought == true && attack4.isInv == false && attack4_img.enabled == false)
        {
            attack4_img.sprite = attack4.image;
            attack4_img.enabled = true;
            btn_4 = attack4_img.GetComponent<Button>();
            attack4_img.tag = "stick";
            attack4.isInv = true;
        }
        else if (attack4.isBought == true && attack4.isInv == false && attack5_img.enabled == false)
        {
            attack5_img.sprite = attack4.image;
            attack5_img.enabled = true;
            btn_5 = attack5_img.GetComponent<Button>();
            attack5_img.tag = "stick";
            attack4.isInv = true;
        }
        else if (attack4.isBought == true && attack4.isInv == false && attack6_img.enabled == false)
        {
            attack6_img.sprite = attack4.image;
            attack6_img.enabled = true;
            btn_6 = attack6_img.GetComponent<Button>();
            attack6_img.tag = "stick";
            attack4.isInv = true;
        }
        else if (attack4.isBought == true && attack4.isInv == false && attack7_img.enabled == false)
        {
            attack7_img.sprite = attack4.image;
            attack7_img.enabled = true;
            btn_7 = attack7_img.GetComponent<Button>();
            attack7_img.tag = "stick";
            attack4.isInv = true;
        }
        else if (attack4.isBought == true && attack4.isInv == false && attack8_img.enabled == false)
        {
            attack8_img.sprite = attack4.image;
            attack8_img.enabled = true;
            btn_8 = attack8_img.GetComponent<Button>();
            attack8_img.tag = "stick";
            attack4.isInv = true;
        }
        #endregion

        #region Blade
        if (attack5.isBought == true && attack5.isInv == false && attack_img.enabled == false)
        {
            attack_img.sprite = attack5.image;
            attack_img.enabled = true;
            btn_1 = attack_img.GetComponent<Button>();
            attack_img.tag = "blade";
            attack5.isInv = true;
        }
        else if (attack5.isBought == true && attack5.isInv == false && attack2_img.enabled == false)
        {
            attack2_img.sprite = attack5.image;
            attack2_img.enabled = true;
            btn_2 = attack2_img.GetComponent<Button>();
            attack2_img.tag = "blade";
            attack5.isInv = true;
        }
        else if (attack5.isBought == true && attack5.isInv == false && attack3_img.enabled == false)
        {
            attack3_img.sprite = attack5.image;
            attack3_img.enabled = true;
            btn_3 = attack3_img.GetComponent<Button>();
            attack3_img.tag = "blade";
            attack5.isInv = true;
        }
        else if (attack5.isBought == true && attack5.isInv == false && attack4_img.enabled == false)
        {
            attack4_img.sprite = attack5.image;
            attack4_img.enabled = true;
            btn_4 = attack4_img.GetComponent<Button>();
            attack4_img.tag = "blade";
            attack5.isInv = true;
        }
        else if (attack5.isBought == true && attack5.isInv == false && attack5_img.enabled == false)
        {
            attack5_img.sprite = attack5.image;
            attack5_img.enabled = true;
            btn_5 = attack5_img.GetComponent<Button>();
            attack5_img.tag = "blade";
            attack5.isInv = true;
        }
        else if (attack5.isBought == true && attack5.isInv == false && attack6_img.enabled == false)
        {
            attack6_img.sprite = attack5.image;
            attack6_img.enabled = true;
            btn_6 = attack6_img.GetComponent<Button>();
            attack6_img.tag = "blade";
            attack5.isInv = true;
        }
        else if (attack5.isBought == true && attack5.isInv == false && attack7_img.enabled == false)
        {
            attack7_img.sprite = attack5.image;
            attack7_img.enabled = true;
            btn_7 = attack7_img.GetComponent<Button>();
            attack7_img.tag = "blade";
            attack5.isInv = true;
        }
        else if (attack5.isBought == true && attack5.isInv == false && attack8_img.enabled == false)
        {
            attack8_img.sprite = attack5.image;
            attack8_img.enabled = true;
            btn_8 = attack8_img.GetComponent<Button>();
            attack8_img.tag = "blade";
            attack5.isInv = true;
        }
        #endregion

        #region Shock
        if (attack6.isBought == true && attack6.isInv == false && attack_img.enabled == false)
        {
            attack_img.sprite = attack6.image;
            attack_img.enabled = true;
            btn_1 = attack_img.GetComponent<Button>();
            attack_img.tag = "shock";
            attack6.isInv = true;
        }
        else if (attack6.isBought == true && attack6.isInv == false && attack2_img.enabled == false)
        {
            attack2_img.sprite = attack6.image;
            attack2_img.enabled = true;
            btn_2 = attack2_img.GetComponent<Button>();
            attack2_img.tag = "shock";
            attack6.isInv = true;
        }
        else if (attack6.isBought == true && attack6.isInv == false && attack3_img.enabled == false)
        {
            attack3_img.sprite = attack6.image;
            attack3_img.enabled = true;
            btn_3 = attack3_img.GetComponent<Button>();
            attack3_img.tag = "shock";
            attack6.isInv = true;
        }
        else if (attack6.isBought == true && attack6.isInv == false && attack4_img.enabled == false)
        {
            attack4_img.sprite = attack6.image;
            attack4_img.enabled = true;
            btn_4 = attack4_img.GetComponent<Button>();
            attack4_img.tag = "shock";
            attack6.isInv = true;
        }
        else if (attack6.isBought == true && attack6.isInv == false && attack5_img.enabled == false)
        {
            attack5_img.sprite = attack6.image;
            attack5_img.enabled = true;
            btn_5 = attack5_img.GetComponent<Button>();
            attack5_img.tag = "shock";
            attack6.isInv = true;
        }
        else if (attack6.isBought == true && attack6.isInv == false && attack6_img.enabled == false)
        {
            attack6_img.sprite = attack6.image;
            attack6_img.enabled = true;
            btn_6 = attack6_img.GetComponent<Button>();
            attack6_img.tag = "shock";
            attack6.isInv = true;
        }
        else if (attack6.isBought == true && attack6.isInv == false && attack7_img.enabled == false)
        {
            attack7_img.sprite = attack6.image;
            attack7_img.enabled = true;
            btn_7 = attack7_img.GetComponent<Button>();
            attack7_img.tag = "shock";
            attack6.isInv = true;
        }
        else if (attack6.isBought == true && attack6.isInv == false && attack8_img.enabled == false)
        {
            attack8_img.sprite = attack6.image;
            attack8_img.enabled = true;
            btn_8 = attack8_img.GetComponent<Button>();
            attack8_img.tag = "shock";
            attack6.isInv = true;
        }

        #endregion

        #region Arson
        if (attack7.isBought == true && attack7.isInv == false && attack_img.enabled == false)
        {
            attack_img.sprite = attack7.image;
            attack_img.enabled = true;
            btn_1 = attack_img.GetComponent<Button>();
            attack_img.tag = "arson";
            attack7.isInv = true;
        }
        else if (attack7.isBought == true && attack7.isInv == false && attack2_img.enabled == false)
        {
            attack2_img.sprite = attack7.image;
            attack2_img.enabled = true;
            btn_2 = attack2_img.GetComponent<Button>();
            attack2_img.tag = "arson";
            attack7.isInv = true;
        }
        else if (attack7.isBought == true && attack7.isInv == false && attack3_img.enabled == false)
        {
            attack3_img.sprite = attack7.image;
            attack3_img.enabled = true;
            btn_3 = attack3_img.GetComponent<Button>();
            attack3_img.tag = "arson";
            attack7.isInv = true;
        }
        else if (attack7.isBought == true && attack7.isInv == false && attack4_img.enabled == false)
        {
            attack4_img.sprite = attack7.image;
            attack4_img.enabled = true;
            btn_4 = attack4_img.GetComponent<Button>();
            attack4_img.tag = "arson";
            attack7.isInv = true;
        }
        else if (attack7.isBought == true && attack7.isInv == false && attack5_img.enabled == false)
        {
            attack5_img.sprite = attack7.image;
            attack5_img.enabled = true;
            btn_5 = attack5_img.GetComponent<Button>();
            attack5_img.tag = "arson";
            attack7.isInv = true;
        }
        else if (attack7.isBought == true && attack7.isInv == false && attack6_img.enabled == false)
        {
            attack6_img.sprite = attack7.image;
            attack6_img.enabled = true;
            btn_6 = attack6_img.GetComponent<Button>();
            attack6_img.tag = "arson";
            attack7.isInv = true;
        }
        else if (attack7.isBought == true && attack7.isInv == false && attack7_img.enabled == false)
        {
            attack7_img.sprite = attack7.image;
            attack7_img.enabled = true;
            btn_7 = attack7_img.GetComponent<Button>();
            attack7_img.tag = "arson";
            attack7.isInv = true;
        }
        else if (attack7.isBought == true && attack7.isInv == false && attack8_img.enabled == false)
        {
            attack8_img.sprite = attack7.image;
            attack8_img.enabled = true;
            btn_8 = attack8_img.GetComponent<Button>();
            attack8_img.tag = "arson";
            attack7.isInv = true;
        }

        #endregion

        #region Snow
        if (attack8.isBought == true && attack8.isInv == false && attack_img.enabled == false)
        {
            attack_img.sprite = attack8.image;
            attack_img.enabled = true;
            btn_1 = attack_img.GetComponent<Button>();
            attack_img.tag = "snow";
            attack8.isInv = true;
        }
        else if (attack8.isBought == true && attack8.isInv == false && attack2_img.enabled == false)
        {
            attack2_img.sprite = attack8.image;
            attack2_img.enabled = true;
            btn_2 = attack2_img.GetComponent<Button>();
            attack2_img.tag = "snow";
            attack8.isInv = true;
        }
        else if (attack8.isBought == true && attack8.isInv == false && attack3_img.enabled == false)
        {
            attack3_img.sprite = attack8.image;
            attack3_img.enabled = true;
            btn_3 = attack3_img.GetComponent<Button>();
            attack3_img.tag = "snow";
            attack8.isInv = true;
        }
        else if (attack8.isBought == true && attack8.isInv == false && attack4_img.enabled == false)
        {
            attack4_img.sprite = attack8.image;
            attack4_img.enabled = true;
            btn_4 = attack4_img.GetComponent<Button>();
            attack4_img.tag = "snow";
            attack8.isInv = true;
        }
        else if (attack8.isBought == true && attack8.isInv == false && attack5_img.enabled == false)
        {
            attack5_img.sprite = attack8.image;
            attack5_img.enabled = true;
            btn_5 = attack5_img.GetComponent<Button>();
            attack5_img.tag = "snow";
            attack8.isInv = true;
        }
        else if (attack8.isBought == true && attack8.isInv == false && attack6_img.enabled == false)
        {
            attack6_img.sprite = attack8.image;
            attack6_img.enabled = true;
            btn_6 = attack6_img.GetComponent<Button>();
            attack6_img.tag = "snow";
            attack8.isInv = true;
        }
        else if (attack8.isBought == true && attack8.isInv == false && attack7_img.enabled == false)
        {
            attack7_img.sprite = attack8.image;
            attack7_img.enabled = true;
            btn_7 = attack7_img.GetComponent<Button>();
            attack7_img.tag = "snow";
            attack8.isInv = true;
        }
        else if (attack8.isBought == true && attack8.isInv == false && attack8_img.enabled == false)
        {
            attack8_img.sprite = attack8.image;
            attack8_img.enabled = true;
            btn_8 = attack8_img.GetComponent<Button>();
            attack8_img.tag = "snow";
            attack8.isInv = true;
        }

        #endregion
    }

    public void EquipWeapon(Button btn)
    {
        #region Phone
        if (btn.tag == "phone")
        {
            if (attack1.isEquip == true)
            {
                equipText.text = "You already have " + stats.weaponNameE.ToString() + " equipped";
                StartCoroutine(EquipWait());
            }

            if (attack2.isEquip == true)
            {

                attack2.isEquip = false;

                stats.weaponNameE = "Phone charger";

                CurrentWeapons();


                equipText.text = "You equipped " + stats.weaponNameE.ToString();
                StartCoroutine(EquipWait());
            }

            if (attack3.isEquip == true)
            {

                attack3.isEquip = false;

                stats.weaponNameE = "Phone charger";

                CurrentWeapons();


                equipText.text = "You equipped " + stats.weaponNameE.ToString();
                StartCoroutine(EquipWait());
            }

            if (attack4.isEquip == true)
            {

                attack4.isEquip = false;

                stats.weaponNameE = "Phone charger";

                CurrentWeapons();


                equipText.text = "You equipped " + stats.weaponNameE.ToString();
                StartCoroutine(EquipWait());
            }

            if (attack5.isEquip == true)
            {
                attack5.isEquip = false;

                stats.weaponNameE = "Phone charger";

                CurrentWeapons();


                equipText.text = "You equipped " + stats.weaponNameE.ToString();
                StartCoroutine(EquipWait());
            }

            if (attack6.isEquip == true)
            {

                attack6.isEquip = false;

                stats.weaponNameE = "Phone charger";

                CurrentWeapons();


                equipText.text = "You equipped " + stats.weaponNameE.ToString();
                StartCoroutine(EquipWait());
            }

            if (attack7.isEquip == true)
            {

                attack7.isEquip = false;

                stats.weaponNameE = "Phone charger";

                CurrentWeapons();


                equipText.text = "You equipped " + stats.weaponNameE.ToString();
                StartCoroutine(EquipWait());
            }

            if (attack8.isEquip == true)
            {

                attack8.isEquip = false;

                stats.weaponNameE = "Phone charger";

                CurrentWeapons();


                equipText.text = "You equipped " + stats.weaponNameE.ToString();
                StartCoroutine(EquipWait());
            }

            attack1.isEquip = true;

            CurrentWeapons();
        }
        #endregion

        #region Sand
        if (btn.tag == "sandcastle")
        {
            if (attack1.isEquip == true)
            {

                attack1.isEquip = false;

                stats.weaponNameE = "Sandcastle";

                CurrentWeapons();


                equipText.text = "You equipped " + stats.weaponNameE.ToString();
                StartCoroutine(EquipWait());
            }

            if (attack2.isEquip == true)
            {
                equipText.text = "You already have " + stats.weaponNameE.ToString() + " equipped";
                StartCoroutine(EquipWait());
            }

            if (attack3.isEquip == true)
            {

                attack3.isEquip = false;

                stats.weaponNameE = "Sandcastle";

                CurrentWeapons();


                equipText.text = "You equipped " + stats.weaponNameE.ToString();
                StartCoroutine(EquipWait());
            }

            if (attack4.isEquip == true)
            {

                attack4.isEquip = false;

                stats.weaponNameE = "Sandcastle";

                CurrentWeapons();


                equipText.text = "You equipped " + stats.weaponNameE.ToString();
                StartCoroutine(EquipWait());
            }

            if (attack5.isEquip == true)
            {
                attack5.isEquip = false;

                stats.weaponNameE = "Sandcastle";

                CurrentWeapons();


                equipText.text = "You equipped " + stats.weaponNameE.ToString();
                StartCoroutine(EquipWait());
            }

            if (attack6.isEquip == true)
            {

                attack6.isEquip = false;

                stats.weaponNameE = "Sandcastle";

                CurrentWeapons();


                equipText.text = "You equipped " + stats.weaponNameE.ToString();
                StartCoroutine(EquipWait());
            }

            if (attack7.isEquip == true)
            {

                attack7.isEquip = false;

                stats.weaponNameE = "Sandcastle";

                CurrentWeapons();


                equipText.text = "You equipped " + stats.weaponNameE.ToString();
                StartCoroutine(EquipWait());
            }

            if (attack8.isEquip == true)
            {

                attack8.isEquip = false;

                stats.weaponNameE = "Sandcastle";

                CurrentWeapons();


                equipText.text = "You equipped " + stats.weaponNameE.ToString();
                StartCoroutine(EquipWait());
            }

            attack2.isEquip = true;

            CurrentWeapons();
        }
        #endregion

        #region Water
        if (btn.tag == "water")
        {
            if (attack1.isEquip == true)
            {

                attack1.isEquip = false;

                stats.weaponNameE = "Water gun";

                CurrentWeapons();


                equipText.text = "You equipped " + stats.weaponNameE.ToString();
                StartCoroutine(EquipWait());
            }

            if (attack2.isEquip == true)
            {

                attack2.isEquip = false;

                stats.weaponNameE = "Water gun";

                CurrentWeapons();


                equipText.text = "You equipped " + stats.weaponNameE.ToString();
                StartCoroutine(EquipWait());
            }

            if (attack3.isEquip == true)
            {
                equipText.text = "You already have " + stats.weaponNameE.ToString() + " equipped";
                StartCoroutine(EquipWait());
            }

            if (attack4.isEquip == true)
            {

                attack4.isEquip = false;

                stats.weaponNameE = "Water gun";

                CurrentWeapons();


                equipText.text = "You equipped " + stats.weaponNameE.ToString();
                StartCoroutine(EquipWait());
            }

            if (attack5.isEquip == true)
            {
                attack5.isEquip = false;

                stats.weaponNameE = "Water gun";

                CurrentWeapons();


                equipText.text = "You equipped " + stats.weaponNameE.ToString();
                StartCoroutine(EquipWait());
            }

            if (attack6.isEquip == true)
            {

                attack6.isEquip = false;

                stats.weaponNameE = "Water gun";

                CurrentWeapons();


                equipText.text = "You equipped " + stats.weaponNameE.ToString();
                StartCoroutine(EquipWait());
            }

            if (attack7.isEquip == true)
            {

                attack7.isEquip = false;

                stats.weaponNameE = "Water gun";

                CurrentWeapons();


                equipText.text = "You equipped " + stats.weaponNameE.ToString();
                StartCoroutine(EquipWait());
            }

            if (attack8.isEquip == true)
            {

                attack8.isEquip = false;

                stats.weaponNameE = "Water gun";

                CurrentWeapons();


                equipText.text = "You equipped " + stats.weaponNameE.ToString();
                StartCoroutine(EquipWait());
            }

            attack3.isEquip = true;

            CurrentWeapons();
        }
        #endregion

        #region Stick
        if (btn.tag == "stick")
        {
            if (attack1.isEquip == true)
            {

                attack1.isEquip = false;

                stats.weaponNameE = "Matchstick";

                CurrentWeapons();


                equipText.text = "You equipped " + stats.weaponNameE.ToString();
                StartCoroutine(EquipWait());
            }

            if (attack2.isEquip == true)
            {

                attack2.isEquip = false;

                stats.weaponNameE = "Matchstick";

                CurrentWeapons();


                equipText.text = "You equipped " + stats.weaponNameE.ToString();
                StartCoroutine(EquipWait());
            }

            if (attack3.isEquip == true)
            {

                attack3.isEquip = false;

                stats.weaponNameE = "Matchstick";

                CurrentWeapons();


                equipText.text = "You equipped " + stats.weaponNameE.ToString();
                StartCoroutine(EquipWait());
            }

            if (attack4.isEquip == true)
            {
                equipText.text = "You already have " + stats.weaponNameE.ToString() + " equipped";
                StartCoroutine(EquipWait());
            }

            if (attack5.isEquip == true)
            {
                attack5.isEquip = false;

                stats.weaponNameE = "Matchstick";

                CurrentWeapons();


                equipText.text = "You equipped " + stats.weaponNameE.ToString();
                StartCoroutine(EquipWait());
            }

            if (attack6.isEquip == true)
            {

                attack6.isEquip = false;

                stats.weaponNameE = "Matchstick";

                CurrentWeapons();


                equipText.text = "You equipped " + stats.weaponNameE.ToString();
                StartCoroutine(EquipWait());
            }

            if (attack7.isEquip == true)
            {

                attack7.isEquip = false;

                stats.weaponNameE = "Matchstick";

                CurrentWeapons();


                equipText.text = "You equipped " + stats.weaponNameE.ToString();
                StartCoroutine(EquipWait());
            }

            if (attack8.isEquip == true)
            {

                attack8.isEquip = false;

                stats.weaponNameE = "Matchstick";

                CurrentWeapons();


                equipText.text = "You equipped " + stats.weaponNameE.ToString();
                StartCoroutine(EquipWait());
            }

            attack4.isEquip = true;

            CurrentWeapons();
        }
        #endregion

        #region Blade
        if (btn.tag == "blade")
        {
            if (attack1.isEquip == true)
            {

                attack1.isEquip = false;

                stats.weaponNameE = "Weed Blade";

                CurrentWeapons();


                equipText.text = "You equipped " + stats.weaponNameE.ToString();
                StartCoroutine(EquipWait());
            }

            if (attack2.isEquip == true)
            {

                attack2.isEquip = false;

                stats.weaponNameE = "Weed Blade";

                CurrentWeapons();


                equipText.text = "You equipped " + stats.weaponNameE.ToString();
                StartCoroutine(EquipWait());
            }

            if (attack3.isEquip == true)
            {

                attack3.isEquip = false;

                stats.weaponNameE = "Weed Blade";

                CurrentWeapons();


                equipText.text = "You equipped " + stats.weaponNameE.ToString();
                StartCoroutine(EquipWait());
            }

            if (attack4.isEquip == true)
            {

                attack4.isEquip = false;

                stats.weaponNameE = "Weed Blade";

                CurrentWeapons();


                equipText.text = "You equipped " + stats.weaponNameE.ToString();
                StartCoroutine(EquipWait());
            }

            if (attack5.isEquip == true)
            {
                equipText.text = "You already have " + stats.weaponNameE.ToString() + " equipped";
                StartCoroutine(EquipWait());
            }

            if (attack6.isEquip == true)
            {

                attack6.isEquip = false;

                stats.weaponNameE = "Weed Blade";

                CurrentWeapons();


                equipText.text = "You equipped " + stats.weaponNameE.ToString();
                StartCoroutine(EquipWait());
            }

            if (attack7.isEquip == true)
            {

                attack7.isEquip = false;

                stats.weaponNameE = "Weed Blade";

                CurrentWeapons();


                equipText.text = "You equipped " + stats.weaponNameE.ToString();
                StartCoroutine(EquipWait());
            }

            if (attack8.isEquip == true)
            {

                attack8.isEquip = false;

                stats.weaponNameE = "Weed Blade";

                CurrentWeapons();


                equipText.text = "You equipped " + stats.weaponNameE.ToString();
                StartCoroutine(EquipWait());
            }

            attack5.isEquip = true;

            CurrentWeapons();
        }

        #endregion

        #region Shock
        if (btn.tag == "shock")
        {
            if (attack1.isEquip == true)
            {

                attack1.isEquip = false;

                stats.weaponNameE = "Electroshock";

                CurrentWeapons();


                equipText.text = "You equipped " + stats.weaponNameE.ToString();
                StartCoroutine(EquipWait());
            }

            if (attack2.isEquip == true)
            {

                attack2.isEquip = false;

                stats.weaponNameE = "Electroshock";

                CurrentWeapons();


                equipText.text = "You equipped " + stats.weaponNameE.ToString();
                StartCoroutine(EquipWait());
            }

            if (attack3.isEquip == true)
            {

                attack3.isEquip = false;

                stats.weaponNameE = "Electroshock";

                CurrentWeapons();


                equipText.text = "You equipped " + stats.weaponNameE.ToString();
                StartCoroutine(EquipWait());
            }

            if (attack4.isEquip == true)
            {

                attack4.isEquip = false;

                stats.weaponNameE = "Electroshock";

                CurrentWeapons();


                equipText.text = "You equipped " + stats.weaponNameE.ToString();
                StartCoroutine(EquipWait());
            }

            if (attack5.isEquip == true)
            {
                attack5.isEquip = false;

                stats.weaponNameE = "Electroshock";

                CurrentWeapons();

                equipText.text = "You equipped " + stats.weaponNameE.ToString();
                StartCoroutine(EquipWait());
            }

            if (attack6.isEquip == true)
            {
                equipText.text = "You already have " + stats.weaponNameE.ToString() + " equipped";
                StartCoroutine(EquipWait());
            }

            if (attack7.isEquip == true)
            {

                attack7.isEquip = false;

                stats.weaponNameE = "Electroshock";

                CurrentWeapons();


                equipText.text = "You equipped " + stats.weaponNameE.ToString();
                StartCoroutine(EquipWait());
            }

            if (attack8.isEquip == true)
            {

                attack8.isEquip = false;

                stats.weaponNameE = "Electroshock";

                CurrentWeapons();


                equipText.text = "You equipped " + stats.weaponNameE.ToString();
                StartCoroutine(EquipWait());
            }

            attack6.isEquip = true;

            CurrentWeapons();
        }

        #endregion

        #region Arson
        if (btn.tag == "arson")
        {
            if (attack1.isEquip == true)
            {

                attack1.isEquip = false;

                stats.weaponNameE = "Lil Arson";

                CurrentWeapons();


                equipText.text = "You equipped " + stats.weaponNameE.ToString();
                StartCoroutine(EquipWait());
            }

            if (attack2.isEquip == true)
            {

                attack2.isEquip = false;

                stats.weaponNameE = "Lil Arson";

                CurrentWeapons();


                equipText.text = "You equipped " + stats.weaponNameE.ToString();
                StartCoroutine(EquipWait());
            }

            if (attack3.isEquip == true)
            {

                attack3.isEquip = false;

                stats.weaponNameE = "Lil Arson";

                CurrentWeapons();


                equipText.text = "You equipped " + stats.weaponNameE.ToString();
                StartCoroutine(EquipWait());
            }

            if (attack4.isEquip == true)
            {

                attack4.isEquip = false;

                stats.weaponNameE = "Lil Arson";

                CurrentWeapons();


                equipText.text = "You equipped " + stats.weaponNameE.ToString();
                StartCoroutine(EquipWait());
            }

            if (attack5.isEquip == true)
            {
                attack5.isEquip = false;

                stats.weaponNameE = "Lil Arson";

                CurrentWeapons();

                equipText.text = "You equipped " + stats.weaponNameE.ToString();
                StartCoroutine(EquipWait());
            }

            if (attack6.isEquip == true)
            {
                attack6.isEquip = false;

                stats.weaponNameE = "Lil Arson";

                CurrentWeapons();

                equipText.text = "You equipped " + stats.weaponNameE.ToString();
                StartCoroutine(EquipWait());
            }

            if (attack7.isEquip == true)
            {
                equipText.text = "You already have " + stats.weaponNameE.ToString() + " equipped";
                StartCoroutine(EquipWait());
            }

            if (attack8.isEquip == true)
            {

                attack8.isEquip = false;

                stats.weaponNameE = "Lil Arson";

                CurrentWeapons();


                equipText.text = "You equipped " + stats.weaponNameE.ToString();
                StartCoroutine(EquipWait());
            }

            attack7.isEquip = true;

            CurrentWeapons();
        }

        #endregion

        #region Snow
        if (btn.tag == "snow")
        {
            if (attack1.isEquip == true)
            {

                attack1.isEquip = false;

                stats.weaponNameE = "Snowball";

                CurrentWeapons();


                equipText.text = "You equipped " + stats.weaponNameE.ToString();
                StartCoroutine(EquipWait());
            }

            if (attack2.isEquip == true)
            {

                attack2.isEquip = false;

                stats.weaponNameE = "Snowball";

                CurrentWeapons();


                equipText.text = "You equipped " + stats.weaponNameE.ToString();
                StartCoroutine(EquipWait());
            }

            if (attack3.isEquip == true)
            {

                attack3.isEquip = false;

                stats.weaponNameE = "Snowball";

                CurrentWeapons();


                equipText.text = "You equipped " + stats.weaponNameE.ToString();
                StartCoroutine(EquipWait());
            }

            if (attack4.isEquip == true)
            {

                attack4.isEquip = false;

                stats.weaponNameE = "Snowball";

                CurrentWeapons();


                equipText.text = "You equipped " + stats.weaponNameE.ToString();
                StartCoroutine(EquipWait());
            }

            if (attack5.isEquip == true)
            {
                attack5.isEquip = false;

                stats.weaponNameE = "Snowball";

                CurrentWeapons();

                equipText.text = "You equipped " + stats.weaponNameE.ToString();
                StartCoroutine(EquipWait());
            }

            if (attack6.isEquip == true)
            {
                attack6.isEquip = false;

                stats.weaponNameE = "Snowball";

                CurrentWeapons();

                equipText.text = "You equipped " + stats.weaponNameE.ToString();
                StartCoroutine(EquipWait());
            }

            if (attack7.isEquip == true)
            {
                attack7.isEquip = false;

                stats.weaponNameE = "Snowball";

                CurrentWeapons();

                equipText.text = "You equipped " + stats.weaponNameE.ToString();
                StartCoroutine(EquipWait());
            }

            if (attack8.isEquip == true)
            {
                equipText.text = "You already have " + stats.weaponNameE.ToString() + " equipped";
                StartCoroutine(EquipWait());
            }

            attack8.isEquip = true;

            CurrentWeapons();
        }

        #endregion

    }

    void CurrentWeapons()
        {
            if (attack1.isEquip == true)
            {
                currentAttack_img.sprite = attack1.image;
                currentAttack_img.tag = "Attack1";
            }

            if (attack2.isEquip == true)
            {
                currentAttack_img.sprite = attack2.image;
                currentAttack_img.tag = "Attack2";
            }

            if (attack3.isEquip == true)
            {
                currentAttack_img.sprite = attack3.image;
                currentAttack_img.tag = "Attack3";
            }

            if (attack4.isEquip == true)
            {
                currentAttack_img.sprite = attack4.image;
                currentAttack_img.tag = "Attack4";
            }

            if (attack5.isEquip == true)
            {
                currentAttack_img.sprite = attack5.image;
                currentAttack_img.tag = "Attack5";
            }

            if (attack6.isEquip == true)
            {
                currentAttack_img.sprite = attack6.image;
                currentAttack_img.tag = "Attack6";
            }

            if (attack7.isEquip == true)
            {
                currentAttack_img.sprite = attack7.image;
                currentAttack_img.tag = "Attack7";
            }

            if (attack8.isEquip == true)
            {
                currentAttack_img.sprite = attack8.image;
                currentAttack_img.tag = "Attack8";
            }

            if (n_attack1.isEquip == true)
            {
                cur_nAttack_img.sprite = n_attack1.image;
                cur_nAttack_img.tag = "nAttack1";
            }

            if (n_attack2.isEquip == true)
            {
                cur_nAttack2_img.sprite = n_attack2.image;
                cur_nAttack2_img.tag = "nAttack2";
            }
        }

    public void ShowWeaponInfo(Button btn)
        {
            if (btn.tag == "Attack1")
            {
                weaponInfo.SetActive(true);
                weaponName.text = stats.weaponNameE.ToString();
                weaponStrength.text = "Strength: " + stats.realStrenghtE.ToString();
                weaponSpeed.text = "Speed: " + stats.realSpeedE.ToString();
                weaponHealing.text = "Healing: " + stats.realHealingE.ToString();
            }

            if (btn.tag == "Attack2")
            {
                weaponInfo.SetActive(true);
                weaponName.text = stats.weaponNameE.ToString();
                weaponStrength.text = "Strength: " + stats.realStrenghtE.ToString();
                weaponSpeed.text = "Speed: " + stats.realSpeedE.ToString();
                weaponHealing.text = "Healing: " + stats.realHealingE.ToString();
            }

            if (btn.tag == "Attack3")
            {
                weaponInfo.SetActive(true);
                weaponName.text = stats.weaponNameE.ToString();
                weaponStrength.text = "Strength: " + stats.realStrenghtE.ToString();
                weaponSpeed.text = "Speed: " + stats.realSpeedE.ToString();
                weaponHealing.text = "Healing: " + stats.realHealingE.ToString();
            }

            if (btn.tag == "Attack4")
            {
                weaponInfo.SetActive(true);
                weaponName.text = stats.weaponNameE.ToString();
                weaponStrength.text = "Strength: " + stats.realStrenghtE.ToString();
                weaponSpeed.text = "Speed: " + stats.realSpeedE.ToString();
                weaponHealing.text = "Healing: " + stats.realHealingE.ToString();
            }

            if (btn.tag == "Attack5")
            {
                weaponInfo.SetActive(true);
                weaponName.text = stats.weaponNameE.ToString();
                weaponStrength.text = "Strength: " + stats.realStrenghtE.ToString();
                weaponSpeed.text = "Speed: " + stats.realSpeedE.ToString();
                weaponHealing.text = "Healing: " + stats.realHealingE.ToString();
            }

            if (btn.tag == "Attack6")
            {
                weaponInfo.SetActive(true);
                weaponName.text = stats.weaponNameE.ToString();
                weaponStrength.text = "Strength: " + stats.realStrenghtE.ToString();
                weaponSpeed.text = "Speed: " + stats.realSpeedE.ToString();
                weaponHealing.text = "Healing: " + stats.realHealingE.ToString();
            }

            if (btn.tag == "Attack7")
            {
                weaponInfo.SetActive(true);
                weaponName.text = stats.weaponNameE.ToString();
                weaponStrength.text = "Strength: " + stats.realStrenghtE.ToString();
                weaponSpeed.text = "Speed: " + stats.realSpeedE.ToString();
                weaponHealing.text = "Healing: " + stats.realHealingE.ToString();
            }

            if (btn.tag == "Attack8")
            {
                weaponInfo.SetActive(true);
                weaponName.text = stats.weaponNameE.ToString();
                weaponStrength.text = "Strength: " + stats.realStrenghtE.ToString();
                weaponSpeed.text = "Speed: " + stats.realSpeedE.ToString();
                weaponHealing.text = "Healing: " + stats.realHealingE.ToString();
            }

            if (btn.tag == "nAttack1")
            {
                weaponInfo.SetActive(true);
                weaponName.text = stats.weaponName1.ToString();
                weaponStrength.text = "Strength: " + stats.realStrenght.ToString();
                weaponSpeed.text = "Speed: " + stats.realSpeed.ToString();
                weaponHealing.text = "";
            }

            if (btn.tag == "nAttack2")
            {
                weaponInfo.SetActive(true);
                weaponName.text = stats.weaponName2.ToString();
                weaponStrength.text = "Strength: " + stats.realStrenght2.ToString();
                weaponSpeed.text = "Speed: " + stats.realSpeed2.ToString();
                weaponHealing.text = "";
            }
        }

    public void CloseInfo()
    {
        weaponInfo.SetActive(false);
    }

    IEnumerator EquipWait()
    {
        yield return new WaitForSeconds(2);
        equipText.text = "";
    }
}
