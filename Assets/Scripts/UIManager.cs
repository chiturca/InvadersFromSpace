
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    private static UIManager instance;

    public TextMeshProUGUI scoreText;
    private int score;
    public TextMeshProUGUI highScoreText;
    private int highScore;
    public TextMeshProUGUI coinsText;
    private int coins;
    public TextMeshProUGUI waveText;
    private int wave;
    public Image[] lifeSprites;
    public Image healthBar;
    public Sprite[] healthBars;
    private Color32 active = new Color(1, 1, 1, 1);
    private Color32 inactive = new Color(1, 1, 1, 0.25f);



    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public static void UpdateLives(int l)
    {
        foreach (Image i in instance.lifeSprites)
        {
            i.color = instance.inactive;
        }
        for (int i = 0; i < l; i++)
        {
            instance.lifeSprites[i].color = instance.active;
        }
    }
    public static void UpdateHealthBar(int h)
    {
        instance.healthBar.sprite = instance.healthBars[h];
    }
    public static void UpdateScore(int s)
    {
        instance.score += s;
        instance.scoreText.text = instance.score.ToString("000,000");
    }
    public static void UpdateHighScore()
    {

    }
    public static void UpdateCoins()
    {
        instance.coinsText.text = Inventory.currentCoins.ToString();
    }
    public static void UpdateWave()
    {
        instance.wave++;
        instance.waveText.text = instance.wave.ToString();
    }
}
