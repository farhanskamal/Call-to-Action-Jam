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
    public GameObject UpgradeScreen;
    public GameObject HackedScreen;
    public GameObject ConversionScreen;
    public TextMeshProUGUI dataText;
    public TextMeshProUGUI cryptoText;
    public TextMeshProUGUI codeText;
    private int willV;
    private int amount;
    public string vCode;
    private int hi;
    public int lo;
    public int help;
    private bool hackable;
    public string pin;
    public int totalCrypto;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dataText.text = dataC.ToString();
        cryptoText.text = crypto.ToString();
        if (pin == vCode)
        {
            Debug.Log("HackedSolved");
            HackedScreen.SetActive(false);
            lo = 0;
            vCode = "";
            pin = "";
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
