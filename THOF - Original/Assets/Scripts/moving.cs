using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moving : MonoBehaviour
{
    public float moveSpeed = 2.5f;

    Vector2 movement;

    public bool inAction = false;
    public bool in1 = false;
    public bool canGoIn = false;
    public bool canGoOut = false;
    public bool nearEnemy = false;

    public Transform outside;
    public Transform inside;
    public GameObject player;
    public GameObject vittu;

    [HideInInspector]
    public bool isSaved;

    Rigidbody2D rb;
    Animator anim;

    Battle Ba;
    Pause pause;
    Shop shop;
    InventoryUI invUI;
    ChestUI chestUI;
    Dialog Dg;
    Stats stats;

    PlayerData data;

    [HideInInspector]
    public Text shopText;
    public Text chestText;
    [HideInInspector]
    public bool inShop = false;
    public bool inChest = false;

    public Camera Cam;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        Ba = GameObject.Find("Manager").GetComponent<Battle>();
        pause = GameObject.Find("Canvas/Pause").GetComponent<Pause>();
        shopText = GameObject.Find("Canvas/ShopText").GetComponent<Text>();
        shop = GameObject.Find("Canvas/Shop").GetComponent<Shop>();
        invUI = GameObject.Find("Canvas/UI").GetComponent<InventoryUI>();
        chestUI = GameObject.Find("Canvas/ChestUI").GetComponent<ChestUI>();
        Dg = GameObject.Find("Manager").GetComponent<Dialog>();
        stats = GameObject.Find("Player").GetComponent<Stats>();
        data = GameObject.Find("Player").GetComponent<PlayerData>();

        LoadPlayer();
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        anim.SetFloat("Horizontal", movement.x);
        anim.SetFloat("Vertical", movement.y);
        anim.SetFloat("Speed", movement.sqrMagnitude);

        CamFollow();
        Door();
        Person();

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            pause.Paused();
        }

        if(Input.GetKeyDown(KeyCode.Tab))
        {
            invUI.OpenUI();
        }
    }

    public void SavePlayer()
    {
        SaveStuff();
        Debug.Log("game saved");
    }

    public void SaveStuff()
    {
        PlayerData data = new PlayerData();
        isSaved = true;

        data.pos = player.transform.position;
        data.saved = isSaved;
    }

    public void LoadPlayer()
    {
        //PlayerData data;
        if (data.saved == true)
        {
            stats.level = data.level;
            stats.coins = data.coins;
            stats.health = data.coins;
            player.transform.position = data.pos;

            SaveSystem.LoadPlayer();

            Debug.Log("game loaded");
        }
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        if (inAction == false)
        {
            moveSpeed = 2.5f;
        }

        else if (inAction == true)
        {
            moveSpeed = 0f;
        }
    }

    void Door()
    {
        if (canGoIn == true && Input.GetKeyDown(KeyCode.E))
        {
            if (in1 == false)
            {
                in1 = true;
                player.transform.position = inside.transform.position;
                vittu.SetActive(false);
                canGoIn = false;
            }  
        }

        if (canGoOut == true && Input.GetKeyDown(KeyCode.E))
        {
            if (in1 == true)
            {
                in1 = false;
                player.transform.position = outside.transform.position;
                vittu.SetActive(false);
                canGoOut = false;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Door1")
        {
            if (in1 == false)
            {
                canGoIn = true;
                vittu.SetActive(true);
            }

            else if (in1 == true)
            {
                canGoOut = true;
                vittu.SetActive(true);
            }
        }

        #region Enemies

        if (collision.tag == "GrassEnemy1")
        {
            Ba.isEnemy1 = true;
            Ba.eIconK1.SetActive(true);
            nearEnemy = true;
            Dg.isGr1 = true;
        }

        if (collision.tag == "GrassEnemy2")
        {
            Ba.isEnemy2 = true;
            Ba.eIconK1.SetActive(true);
            nearEnemy = true;
            Dg.isGr2 = true;
        }

        if (collision.tag == "GrassEnemy3")
        {
            Ba.isEnemy3 = true;
            Ba.eIconK1.SetActive(true);
            nearEnemy = true;
            Dg.isGr3 = true;
        }

        if (collision.tag == "GrassEnemy4")
        {
            Ba.isEnemy4 = true;
            Ba.eIconK1.SetActive(true);
            nearEnemy = true;
            Dg.isGr4 = true;
        }

        if (collision.tag == "IceEnemy1")
        {
            Ba.isEnemy5 = true;
            Ba.eIconK4.SetActive(true);
            nearEnemy = true;
            Dg.isIc1 = true;
        }

        if (collision.tag == "IceEnemy2")
        {
            Ba.isEnemy6 = true;
            Ba.eIconK4.SetActive(true);
            nearEnemy = true;
            Dg.isIc2 = true;
        }

        if (collision.tag == "IceEnemy3")
        {
            Ba.isEnemy7 = true;
            Ba.eIconK4.SetActive(true);
            nearEnemy = true;
            Dg.isIc3 = true;
        }

        if (collision.tag == "IceEnemy4")
        {
            Ba.isEnemy8 = true;
            Ba.eIconK4.SetActive(true);
            nearEnemy = true;
            Dg.isIc4 = true;
        }

        if (collision.tag == "DesertEnemy1")
        {
            Ba.isEnemy9 = true;
            Ba.eIconK3.SetActive(true);
            nearEnemy = true;
            Dg.isDe1 = true;
        }

        if (collision.tag == "DesertEnemy2")
        {
            Ba.isEnemy10 = true;
            Ba.eIconK3.SetActive(true);
            nearEnemy = true;
            Dg.isDe2 = true;
        }

        if (collision.tag == "DesertEnemy3")
        {
            Ba.isEnemy11 = true;
            Ba.eIconK3.SetActive(true);
            nearEnemy = true;
            Dg.isDe3 = true;
        }

        if (collision.tag == "DesertEnemy4")
        {
            Ba.isEnemy12 = true;
            Ba.eIconK3.SetActive(true);
            nearEnemy = true;
            Dg.isDe4 = true;
        }

        if (collision.tag == "MountainEnemy1")
        {
            Ba.isEnemy13 = true;
            Ba.eIconK2.SetActive(true);
            nearEnemy = true;
            Dg.isMo1 = true;
        }

        if (collision.tag == "MountainEnemy2")
        {
            Ba.isEnemy14 = true;
            Ba.eIconK2.SetActive(true);
            nearEnemy = true;
            Dg.isMo2 = true;
        }

        if (collision.tag == "MountainEnemy3")
        {
            Ba.isEnemy15 = true;
            Ba.eIconK2.SetActive(true);
            nearEnemy = true;
            Dg.isMo3 = true;
        }

        if (collision.tag == "MountainEnemy4")
        {
            Ba.isEnemy16 = true;
            Ba.eIconK2.SetActive(true);
            nearEnemy = true;
            Dg.isMo4 = true;
        }

        if (collision.tag == "SIH1")
        {
            Ba.isSIH1 = true;
            Ba.eIconSIH1.SetActive(true);
            nearEnemy = true;
            Dg.isSIH1 = true;
        }

        if (collision.tag == "SIH2")
        {
            Ba.isSIH2 = true;
            Ba.eIconSIH2.SetActive(true);
            nearEnemy = true;
            Dg.isSIH2 = true;
        }

        if (collision.tag == "SIH3")
        {
            Ba.isSIH3 = true;
            Ba.eIconSIH3.SetActive(true);
            nearEnemy = true;
            Dg.isSIH3 = true;
        }

        if (collision.tag == "SIH4")
        {
            Ba.isSIH4 = true;
            Ba.eIconSIH4.SetActive(true);
            nearEnemy = true;
            Dg.isSIH4 = true;
        }
        #endregion

        if (collision.tag == "Shop")
        {
            shopText.enabled = true;
            inShop = true;
            shop.inShop1 = true;
        }

        if(collision.tag == "Shop2")
        {
            shopText.enabled = true;
            inShop = true;
            shop.inShop2 = true;
        }

        if(collision.tag == "Shop3")
        {
            shopText.enabled = true;
            inShop = true;
            shop.inShop3 = true;
        }

        if(collision.tag == "chest")
        {
            chestText.enabled = true;
            inChest = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        canGoIn = false;
        canGoOut = false;
        vittu.SetActive(false);

        if(other.tag == "Shop")
        {
            shopText.enabled = false;
            shop.transform.GetChild(0).gameObject.SetActive(false);
            shop.isOpen = false;
            shopText.text = "Press E To Open Shop";
            inShop = false;
            shop.inShop1 = false;
        }

        if(other.tag == "Shop2")
        {
            shopText.enabled = false;
            shop.transform.GetChild(0).gameObject.SetActive(false);
            shop.isOpen = false;
            shopText.text = "Press E To Open Shop";
            inShop = false;
            shop.inShop2 = false;
        }

        if (other.tag == "Shop3")
        {
            shopText.enabled = false;
            shop.transform.GetChild(0).gameObject.SetActive(false);
            shop.isOpen = false;
            shopText.text = "Press E To Open Shop";
            inShop = false;
            shop.inShop3 = false;
        }

        if (other.tag == "chest")
        {
            chestText.enabled = false;
            chestUI.transform.GetChild(0).gameObject.SetActive(false);
            chestUI.isOpen = false;
            chestText.text = "Press E to Open Chest";
            inChest = false;
        }

        #region GrassEnemies
        if (other.tag == "GrassEnemy1")
        {
            nearEnemy = false;
            Dg.isGr1 = false;
        }

        if (other.tag == "GrassEnemy2")
        {
            nearEnemy = false;
            Dg.isGr2 = false;
        }

        if (other.tag == "GrassEnemy3")
        {
            nearEnemy = false;
            Dg.isGr3 = false;
        }

        if (other.tag == "GrassEnemy4")
        {
            nearEnemy = false;
            Dg.isGr4 = false;
        }
        #endregion

        #region IceEnemies
        if (other.tag == "IceEnemy1")
        {
            nearEnemy = false;
            Dg.isIc1 = false;
        }

        if (other.tag == "IceEnemy2")
        {
            nearEnemy = false;
            Dg.isIc2 = false;
        }

        if (other.tag == "IceEnemy3")
        {
            nearEnemy = false;
            Dg.isIc3 = false;
        }

        if (other.tag == "IceEnemy4")
        {
            nearEnemy = false;
            Dg.isIc4 = false;
        }
        #endregion

        #region DesertEnemies
        if (other.tag == "DesertEnemy1")
        {
            nearEnemy = false;
            Dg.isDe1 = false;
        }

        if (other.tag == "DesertEnemy2")
        {
            nearEnemy = false;
            Dg.isDe2 = false;
        }

        if (other.tag == "DesertEnemy3")
        {
            nearEnemy = false;
            Dg.isDe3 = false;
        }

        if (other.tag == "DesertEnemy4")
        {
            nearEnemy = false;
            Dg.isDe4 = false;
        }
        #endregion

        #region MountainEnemies
        if (other.tag == "MountainEnemy1")
        {
            nearEnemy = false;
            Dg.isMo1 = false;
        }

        if (other.tag == "MountainEnemy2")
        {
            nearEnemy = false;
            Dg.isMo2 = false;
        }

        if (other.tag == "MountainEnemy3")
        {
            nearEnemy = false;
            Dg.isMo3 = false;
        }

        if (other.tag == "MountainEnemy4")
        {
            nearEnemy = false;
            Dg.isMo4 = false;
        }
        #endregion

        #region SIH
        if (other.tag == "SIH1")
        {
            nearEnemy = false;
            Dg.isSIH1 = false;
        }

        if (other.tag == "SIH2")
        {
            nearEnemy = false;
            Dg.isSIH2 = false;
        }

        if (other.tag == "SIH3")
        {
            nearEnemy = false;
            Dg.isSIH3 = false;
        }

        if (other.tag == "SIH4")
        {
            nearEnemy = false;
            Dg.isSIH4 = false;
        }
        #endregion
    }

    void Person()
    {
        if (nearEnemy == true && inAction == false)
        {
            vittu.SetActive(true);

            if (Input.GetKeyDown(KeyCode.E))
            {
                inAction = true;
                vittu.SetActive(false);
                Dg.BoxOn();
                Dg.WhoIsIt();
            }
        }

        if (nearEnemy == false && canGoIn == false && canGoOut && false)
        {
            vittu.SetActive(false);
        }
    }

    void CamFollow()
    {
        Vector3 FollowPosition = new Vector3(transform.position.x, transform.position.y, Cam.transform.position.z);
        Cam.transform.position = FollowPosition;
    }
}
