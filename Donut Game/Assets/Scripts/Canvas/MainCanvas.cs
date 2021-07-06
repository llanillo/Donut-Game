using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainCanvas : MonoBehaviour
{
    [SerializeField] private RectTransform initialHearthLocation;
    [SerializeField] private GameObject fullHeart;
    [SerializeField] private GameObject almostHeart;
    [SerializeField] private GameObject emptyHeart;
    [SerializeField] private TextMeshProUGUI ammoText;

    private Sprite fullHeartSprite;
    private Sprite almostHeartSprite;
    private Sprite emptyHeartSprite;

    private List<GameObject> heartsList;
    private PlayerManager playerManager;

    private float offsetY;
    private int lastHeart;

    public void Startup()
    {
        CalculateHeartsOffset();
        GetComponents();
        InitialHearts();
    }

    private void InitialHearts()
    {
        float maxHearts = playerManager.Health.maxHealth;
        RectTransform lastPosition = initialHearthLocation;

        for (int i = 0; i < maxHearts; i++)
        {
            if (i == 0)
            {
                GameObject heart = Instantiate(fullHeart, lastPosition, false);
                lastPosition = heart.GetComponent<RectTransform>();
                heartsList.Add(heart);
            }
            else
            {
                GameObject heart = Instantiate(fullHeart, lastPosition.position + Vector3.right * offsetY, fullHeart.transform.rotation, initialHearthLocation);
                lastPosition = heart.GetComponent<RectTransform>();
                heartsList.Add(heart);
            }
        }
    }

    private void ReduceHearts(float damage)
    {
        int count = (int)(damage / 0.5f);

        for (int i = 0; i < count; i++)
        {
            if (lastHeart >= 0) // To prevent out of index error
            {
                Sprite heartImage = heartsList[lastHeart].GetComponent<Image>().sprite;

                if (heartImage == fullHeartSprite)
                    heartsList[lastHeart].GetComponent<Image>().sprite = almostHeartSprite;

                else
                {
                    heartsList[lastHeart].GetComponent<Image>().sprite = emptyHeartSprite;
                    lastHeart -= 1;
                }
            }
        }
    }

    public void UpdateAmmo()
    {        
        AttackController weapon = playerManager.Weapon;
        if (weapon.currentWeapon != null)
            ammoText.SetText("Ammo: " + weapon.currentWeapon.data.currentAmmo + "/" + weapon.currentWeapon.data.maxAmmo);
    }

    private void GetComponents()
    {
        heartsList = new List<GameObject>();

        playerManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<PlayerManager>();
        playerManager.Health.heartsDelegate += ReduceHearts;

        lastHeart = (int)playerManager.Health.maxHealth - 1;

        fullHeartSprite = fullHeart.GetComponent<Image>().sprite;
        almostHeartSprite = almostHeart.GetComponent<Image>().sprite;
        emptyHeartSprite = emptyHeart.GetComponent<Image>().sprite;
    }

    private void CalculateHeartsOffset()
    {
        int width = Screen.width;

        if (width <= 1370)
            offsetY = 65;
        else if (width <= 1920)
            offsetY = 70;
        else if (width <= 3900)
            offsetY = 75;
    }
}
