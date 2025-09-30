using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "Shop Items")]
public class ShopItems : ScriptableObject
{
    public string itemName = "";
    public int maxItems = 1;
    public Sprite image;
    public int howMuch = 100;
    public bool isBought = false;
    public bool isEquip = false;
    public bool isInv = false;
}
