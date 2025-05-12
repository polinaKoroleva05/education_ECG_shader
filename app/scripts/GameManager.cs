using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Material heart;
    public float count;
    public GameObject startPanel; 
    public GameObject ecgPanel; 
    public TMP_Text RRText;
    public TMP_Text PText;
    public TMP_Text PTimeText;
    public TMP_Text PQText;
    public TMP_Text QRSText;
    public TMP_Text RText;
    public TMP_Text STText;
    public TMP_Text TTimeText;
    public Slider RRSlider;
    public Slider PSlider;
    public Slider PTimeSlider;
    public Slider PQSlider;
    public Slider QRSSlider;
    public Slider RSlider;
    public Slider STSlider;
    public Slider TTimeSlider;
    public GameObject Heart;
    public Button NormalButton;
    public Button TahicardiaButton;
    public Button BradicardiaButton;
    public Button SyndromCLCButton;
    private void Start()
    {
        startPanel.SetActive(true);
        ecgPanel.SetActive(false);
        NormalButton.Select();
        Normal();
    }

    // private int i = 0;
    // private float timeToChangeRR = 0.12f + 0.1f + 0.05f + 0.15f;
    // Update is called once per frame
    public void Update(){
        // float[] arrArytmia = {1f, 1.5f, 1.2f};
        // if( Time.time >= timeToChangeRR ){
        //     timeToChangeRR += arrArytmia[i];
        //     heart.SetFloat("_Arytmia", arrArytmia[i]);
        //     Debug.Log("check " + arrArytmia[i]);
        //     i = ++i % 3;
        // }
    }

    public void Normal()
    {
        setSetting(RRSlider, RRText, "_RR", 1f);
        setSetting(PTimeSlider, PTimeText, "_PTime", 0.08f);
        setSetting(PSlider, PText, "_P", 0.2f);
        setSetting(QRSSlider, QRSText, "_QRS", 0.1f);
        setSetting(RSlider, RText, "_R", 1f);
        setSetting(TTimeSlider, TTimeText, "_TTime", 0.15f);
        setSetting(STSlider, STText, "_ST", 0.05f);
        setSetting(PQSlider, PQText, "_PQ", 0.12f);
    }

    public void setSetting(Slider slider, TMP_Text textField, string name, float v){
        heart.SetFloat(name, v);
        slider.value = v;
        textField.text = trimValue(v);
    }

    public void changeSettingFromSlider(TMP_Text textField, string name, float v){
        heart.SetFloat(name, v);
        textField.text = trimValue(v);
    }

    public string trimValue(float val){
        string text = val.ToString();
        if(text.Length > 4){
            text = text.Substring(0, 4);
        }
        return text;
    }

    public void Tahicardia()
    {
        setSetting(RRSlider, RRText, "_RR",  0.5f);
        setSetting(PTimeSlider, PTimeText, "_PTime", 0.08f);
        setSetting(PSlider, PText, "_P", 0.25f);
        setSetting(QRSSlider, QRSText, "_QRS", 0.1f);
        setSetting(RSlider, RText, "_R", 1f);
        setSetting(TTimeSlider, TTimeText, "_TTime", 0.15f);
        setSetting(STSlider, STText, "_ST", 0.05f);
        setSetting(PQSlider, PQText, "_PQ", 0.12f);
    }

    public void Bradicardia()
    {
        setSetting(RRSlider, RRText, "_RR",  2f);
        setSetting(PTimeSlider, PTimeText, "_PTime", 0.08f);
        setSetting(PSlider, PText, "_P", 0.25f);
        setSetting(QRSSlider, QRSText, "_QRS", 0.1f);
        setSetting(RSlider, RText, "_R", 1f);
        setSetting(TTimeSlider, TTimeText, "_TTime", 0.15f);
        setSetting(STSlider, STText, "_ST", 0.05f);
        setSetting(PQSlider, PQText, "_PQ", 0.12f);
    }

    public void SyndromCLC()
    {
        setSetting(RRSlider, RRText, "_RR", 1f);
        setSetting(PTimeSlider, PTimeText, "_PTime", 0.08f);
        setSetting(PSlider, PText, "_P", 0.1f);
        setSetting(QRSSlider, QRSText, "_QRS", 0.1f);
        setSetting(RSlider, RText, "_R", 1f);
        setSetting(TTimeSlider, TTimeText, "_TTime", 0.15f);
        setSetting(STSlider, STText, "_ST", 0.05f);
        setSetting(PQSlider, PQText, "_PQ", 0.02f);
    }

    public void SettingECG()
    {
        startPanel.SetActive(false);
        ecgPanel.SetActive(true);
    }

    public void ChooseVariant()
    {
        startPanel.SetActive(true);
        ecgPanel.SetActive(false);
    }

    public void onChangePtime(float ptime)
    {
        changeSettingFromSlider(PTimeText, "_PTime", ptime);
    }

    public void onChangeP(float p)
    {
        changeSettingFromSlider(PText, "_P", p);
    }
    
    public void onChangeQRS(float qrs)
    {
        changeSettingFromSlider(QRSText, "_QRS", qrs);
    }
    
    public void onChangeR(float r)
    {
        changeSettingFromSlider(RText, "_R", r);
    }

    public void onChangeTTime(float ttime)
    {
        changeSettingFromSlider(TTimeText, "_TTime", ttime);
    }

    public void onChangeST(float st)
    {
        changeSettingFromSlider(STText, "_ST", st);
    }

    public void onChangePQ(float pq)
    {
        changeSettingFromSlider(PQText, "_PQ", pq);
    }
    
    public void onChangeRR(float rr)
    {
        changeSettingFromSlider(RRText, "_RR", rr);
    }
}
