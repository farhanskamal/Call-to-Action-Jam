using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GMScript : MonoBehaviour
{
    public int dataC;
    public int crypto;
    public GameObject clicker;
    public GameObject StartScreen;
    public GameObject UpgradeScreen;
    public GameObject HackedScreen;
    public GameObject ConversionScreen;
    public GameObject BossFightScreen;
    public GameObject winScreen;
    public TextMeshProUGUI dataText;
    public TextMeshProUGUI cryptoText;
    public TextMeshProUGUI codeText;
    public TextMeshProUGUI totalDataText;
    public TextMeshProUGUI bossFightText;
    private int willV;
    private int amount;
    public string vCode;
    private int hi;
    public int lo;
    public int help;
    private bool hackable;
    public bool beated;
    public string pin;
    public int totalData;

    public int pScore;
    public int eScore;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dataText.text = dataC.ToString();
        cryptoText.text = crypto.ToString();
        totalDataText.text = totalData.ToString() + "/50 Goal";
        bossFightText.text = "Enemies Progress: " + eScore + "/100" + " Your Progress: " + pScore + "/100";
        if (pin == vCode)
        {
            Debug.Log("HackedSolved");
            HackedScreen.SetActive(false);
            lo = 0;
            vCode = "";
            pin = "";
        }

        if (totalData >= 50 && beated == false)
        {
            BossFightScreen.SetActive(true);
        }
    }

    public void VirusHappens()
    {
        if (lo < 3)
        {
            hi = UnityEngine.Random.Range(1, 3);
            vCode += hi;
            help = vCode.Length;
            if (help == 3)
            {
                lo = 3;
                hackable = true;
            }
        } else if (lo >= 3)
        {
            lo = 3;
        }

        Debug.Log(vCode);
        willV = UnityEngine.Random.Range(1, 7);
        if (willV == 5 && hackable == true)
        {
            Debug.Log("YOUR HACKED");
            codeText.text = vCode;
            HackedScreen.SetActive(true);
        }
    }

    public void b1()
    {
        pin += "1";
    }

    public void b2()
    {
        pin += "2";
    }

    public void b3()
    {
        pin += "3";
    }

    public void fight()
    {
        pScore += 20;
        eScore += UnityEngine.Random.RandomRange(1, 15);

        if (pScore >= 100)
        {
            Debug.Log("PLAYER WINS");
            beated = true;
            winScreen.SetActive(true);
        }
    }

    public void StartE()
    {
        StartScreen.SetActive(false);
    }

    public void ShowUpgrades()
    {
        ConversionScreen.SetActive(false);
        UpgradeScreen.SetActive(true);
    }

    public void ShowConvert()
    {
        UpgradeScreen.SetActive(false);
        ConversionScreen.SetActive(true);
    }

    public void ConvertData()
    {
        if (dataC >= 5)
        {
            amount = dataC/5;
            crypto += amount;
            dataC -= amount*5;
        }
    }

    public void ShowMain()
    {
        ConversionScreen.SetActive(false);
        UpgradeScreen.SetActive(false);
    }
}
