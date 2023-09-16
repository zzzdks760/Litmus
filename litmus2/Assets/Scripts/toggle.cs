using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class toggle : MonoBehaviour
{
    [SerializeField]
    private GameObject img1, img2, img3, img4, img5, img6, img7, img8, img9, img10, img11, img12, img13, img14, img15, img16, a;
    [SerializeField]
    private Toggle toggle1, toggle2, toggle3, toggle4, toggle5, toggle6, toggle7, toggle8, toggle9, toggle10, toggle11;
    private ToggleGroup allowSwitch;

    public GameObject btn;
    Renderer re;
    public GameObject cub;
    public GameObject textObj1;
    public GameObject textObj2;

    void Start()
    {
        re = cub.GetComponent<Renderer>();
    }


    public void on()
    {
            if(toggle1.isOn == true)
            {            
                if(toggle9.isOn == true)
                {
                    a.SetActive(true);
                    img1.SetActive(false);
                    img2.SetActive(false);
                    img3.SetActive(true);
                    img4.SetActive(false);
                    img5.SetActive(false);
                    img6.SetActive(false);
                    img7.SetActive(false);
                    img8.SetActive(false);
                    img9.SetActive(false);
                    img10.SetActive(false);
                    img11.SetActive(false);
                    img12.SetActive(false);
                    img13.SetActive(false);
                    img14.SetActive(false);
                    img15.SetActive(false);
                    img16.SetActive(false);
                    re.material.color = new Color(242/255f, 103/255f, 36/255f, 50/255f);
                    textObj1.GetComponent<Text>().text = "묽은 염산";
                    textObj2.GetComponent<Text>().text = "01";

                }
                else if(toggle10.isOn == true)
                {
                    a.SetActive(true);
                    img1.SetActive(false);
                    img2.SetActive(false);
                    img3.SetActive(false);
                    img4.SetActive(true);
                    img5.SetActive(false);
                    img6.SetActive(false);
                    img7.SetActive(false);
                    img8.SetActive(false);
                    img9.SetActive(false);
                    img10.SetActive(false);
                    img11.SetActive(false);
                    img12.SetActive(false);
                    img13.SetActive(false);
                    img14.SetActive(false);
                    img15.SetActive(false);
                    img16.SetActive(false);
                    re.material.color = new Color(1249/255f, 199/255f, 18/255f);
                    textObj1.GetComponent<Text>().text = "묽은 염산";
                    textObj2.GetComponent<Text>().text = "02";
                }
                else if(toggle11.isOn == true)
                {
                    a.SetActive(true);
                    img1.SetActive(false);
                    img2.SetActive(false);
                    img3.SetActive(false);
                    img4.SetActive(false);
                    img5.SetActive(true);
                    img6.SetActive(false);
                    img7.SetActive(false);
                    img8.SetActive(false);
                    img9.SetActive(false);
                    img10.SetActive(false);
                    img11.SetActive(false);
                    img12.SetActive(false);
                    img13.SetActive(false);
                    img14.SetActive(false);
                    img15.SetActive(false);
                    img16.SetActive(false);
                    re.material.color = new Color(245/255f, 237/255f, 28/255f);
                    textObj1.GetComponent<Text>().text = "묽은 염산";
                    textObj2.GetComponent<Text>().text = "03";
                }
            }
            else if(toggle2.isOn == true)
            {            
                if(toggle9.isOn == true)
                {
                    a.SetActive(true);
                    img1.SetActive(false);
                    img2.SetActive(false);
                    img3.SetActive(false);
                    img4.SetActive(true);
                    img5.SetActive(false);
                    img6.SetActive(false);
                    img7.SetActive(false);
                    img8.SetActive(false);
                    img9.SetActive(false);
                    img10.SetActive(false);
                    img11.SetActive(false);
                    img12.SetActive(false);
                    img13.SetActive(false);
                    img14.SetActive(false);
                    img15.SetActive(false);
                    img16.SetActive(false);
                    re.material.color = new Color(249/255f, 199/255f, 18/255f);
                    textObj1.GetComponent<Text>().text = "위액";
                    textObj2.GetComponent<Text>().text = "02";

                }
                else if(toggle10.isOn == true)
                {
                    a.SetActive(true);
                    img1.SetActive(false);
                    img2.SetActive(false);
                    img3.SetActive(false);
                    img4.SetActive(false);
                    img5.SetActive(true);
                    img6.SetActive(false);
                    img7.SetActive(false);
                    img8.SetActive(false);
                    img9.SetActive(false);
                    img10.SetActive(false);
                    img11.SetActive(false);
                    img12.SetActive(false);
                    img13.SetActive(false);
                    img14.SetActive(false);
                    img15.SetActive(false);
                    img16.SetActive(false);
                    re.material.color = new Color(245/255f, 237/255f, 28/255f);
                    textObj1.GetComponent<Text>().text = "위액";
                    textObj2.GetComponent<Text>().text = "03";
                }
                else if(toggle11.isOn == true)
                {
                    a.SetActive(true);
                    img1.SetActive(false);
                    img2.SetActive(false);
                    img3.SetActive(false);
                    img4.SetActive(false);
                    img5.SetActive(false);
                    img6.SetActive(true);
                    img7.SetActive(false);
                    img8.SetActive(false);
                    img9.SetActive(false);
                    img10.SetActive(false);
                    img11.SetActive(false);
                    img12.SetActive(false);
                    img13.SetActive(false);
                    img14.SetActive(false);
                    img15.SetActive(false);
                    img16.SetActive(false);
                    re.material.color = new Color(181/255f, 211/255f, 51/255f);
                    textObj1.GetComponent<Text>().text = "위액";
                    textObj2.GetComponent<Text>().text = "04";
                }
            }
            else if(toggle3.isOn == true)
            {            
                if(toggle9.isOn == true)
                {
                    a.SetActive(true);
                    img1.SetActive(false);
                    img2.SetActive(false);
                    img3.SetActive(false);
                    img4.SetActive(false);
                    img5.SetActive(false);
                    img6.SetActive(true);
                    img7.SetActive(false);
                    img8.SetActive(false);
                    img9.SetActive(false);
                    img10.SetActive(false);
                    img11.SetActive(false);
                    img12.SetActive(false);
                    img13.SetActive(false);
                    img14.SetActive(false);
                    img15.SetActive(false);
                    img16.SetActive(false);
                    re.material.color = new Color(181/255f, 211/255f, 51/255f);
                    textObj1.GetComponent<Text>().text = "와인";
                    textObj2.GetComponent<Text>().text = "04";

                }
                else if(toggle10.isOn == true)
                {
                    a.SetActive(true);
                    img1.SetActive(false);
                    img2.SetActive(false);
                    img3.SetActive(false);
                    img4.SetActive(false);
                    img5.SetActive(false);
                    img6.SetActive(false);
                    img7.SetActive(true);
                    img8.SetActive(false);
                    img9.SetActive(false);
                    img10.SetActive(false);
                    img11.SetActive(false);
                    img12.SetActive(false);
                    img13.SetActive(false);
                    img14.SetActive(false);
                    img15.SetActive(false);
                    img16.SetActive(false);
                    re.material.color = new Color(132/255f, 195/255f, 85/255f);
                    textObj1.GetComponent<Text>().text = "와인";
                    textObj2.GetComponent<Text>().text = "05";
                }
                else if(toggle11.isOn == true)
                {
                    a.SetActive(true);
                    img1.SetActive(false);
                    img2.SetActive(false);
                    img3.SetActive(false);
                    img4.SetActive(false);
                    img5.SetActive(false);
                    img6.SetActive(false);
                    img7.SetActive(false);
                    img8.SetActive(true);
                    img9.SetActive(false);
                    img10.SetActive(false);
                    img11.SetActive(false);
                    img12.SetActive(false);
                    img13.SetActive(false);
                    img14.SetActive(false);
                    img15.SetActive(false);
                    img16.SetActive(false);
                    re.material.color = new Color(77/255f, 183/255f, 73/255f);
                    textObj1.GetComponent<Text>().text = "와인";
                    textObj2.GetComponent<Text>().text = "06";
                }
            }
            else if(toggle4.isOn == true)
            {            
                if(toggle9.isOn == true)
                {
                    a.SetActive(true);
                    img1.SetActive(false);
                    img2.SetActive(false);
                    img3.SetActive(false);
                    img4.SetActive(false);
                    img5.SetActive(false);
                    img6.SetActive(false);
                    img7.SetActive(false);
                    img8.SetActive(true);
                    img9.SetActive(false);
                    img10.SetActive(false);
                    img11.SetActive(false);
                    img12.SetActive(false);
                    img13.SetActive(false);
                    img14.SetActive(false);
                    img15.SetActive(false);
                    img16.SetActive(false);
                    re.material.color = new Color(77/255f, 183/255f, 73/255f);
                    textObj1.GetComponent<Text>().text = "산성비";
                    textObj2.GetComponent<Text>().text = "06";

                }
                else if(toggle10.isOn == true)
                {
                    a.SetActive(true);
                    img1.SetActive(false);
                    img2.SetActive(false);
                    img3.SetActive(false);
                    img4.SetActive(false);
                    img5.SetActive(false);
                    img6.SetActive(false);
                    img7.SetActive(false);
                    img8.SetActive(true);
                    img9.SetActive(false);
                    img10.SetActive(false);
                    img11.SetActive(false);
                    img12.SetActive(false);
                    img13.SetActive(false);
                    img14.SetActive(false);
                    img15.SetActive(false);
                    img16.SetActive(false);
                    re.material.color = new Color(77/255f, 183/255f, 73/255f);
                    textObj1.GetComponent<Text>().text = "산성비";
                    textObj2.GetComponent<Text>().text = "06";
                }
                else if(toggle11.isOn == true)
                {
                    a.SetActive(true);
                    img1.SetActive(false);
                    img2.SetActive(false);
                    img3.SetActive(false);
                    img4.SetActive(false);
                    img5.SetActive(false);
                    img6.SetActive(false);
                    img7.SetActive(false);
                    img8.SetActive(false);
                    img9.SetActive(false);
                    img10.SetActive(true);
                    img11.SetActive(false);
                    img12.SetActive(false);
                    img13.SetActive(false);
                    img14.SetActive(false);
                    img15.SetActive(false);
                    img16.SetActive(false);
                    re.material.color = new Color(34/255f, 180/255f, 107/255f);
                    textObj1.GetComponent<Text>().text = "산성비";
                    textObj2.GetComponent<Text>().text = "08";
                }
            }
            else if(toggle5.isOn == true)
            {            
                if(toggle9.isOn == true)
                {
                    a.SetActive(true);
                    img1.SetActive(false);
                    img2.SetActive(false);
                    img3.SetActive(false);
                    img4.SetActive(false);
                    img5.SetActive(false);
                    img6.SetActive(false);
                    img7.SetActive(false);
                    img8.SetActive(false);
                    img9.SetActive(false);
                    img10.SetActive(false);
                    img11.SetActive(false);
                    img12.SetActive(false);
                    img13.SetActive(true);
                    img14.SetActive(false);
                    img15.SetActive(false);
                    img16.SetActive(false);
                    re.material.color = new Color(56/255f, 83/255f, 164/255f);
                    textObj1.GetComponent<Text>().text = "암모니아";
                    textObj2.GetComponent<Text>().text = "11";

                }
                else if(toggle10.isOn == true)
                {
                    a.SetActive(true);
                    img1.SetActive(false);
                    img2.SetActive(false);
                    img3.SetActive(false);
                    img4.SetActive(false);
                    img5.SetActive(false);
                    img6.SetActive(false);
                    img7.SetActive(false);
                    img8.SetActive(false);
                    img9.SetActive(false);
                    img10.SetActive(false);
                    img11.SetActive(false);
                    img12.SetActive(true);
                    img13.SetActive(false);
                    img14.SetActive(false);
                    img15.SetActive(false);
                    img16.SetActive(false);
                    re.material.color = new Color(70/255f, 144/255f, 205/255f);
                    textObj1.GetComponent<Text>().text = "암모니아";
                    textObj2.GetComponent<Text>().text = "10";
                }
                else if(toggle11.isOn == true)
                {
                    a.SetActive(true);
                    img1.SetActive(false);
                    img2.SetActive(false);
                    img3.SetActive(false);
                    img4.SetActive(false);
                    img5.SetActive(false);
                    img6.SetActive(false);
                    img7.SetActive(false);
                    img8.SetActive(false);
                    img9.SetActive(false);
                    img10.SetActive(false);
                    img11.SetActive(true);
                    img12.SetActive(false);
                    img13.SetActive(false);
                    img14.SetActive(false);
                    img15.SetActive(false);
                    img16.SetActive(false);
                    re.material.color = new Color(10/255f, 184/255f, 182/255f);
                    textObj1.GetComponent<Text>().text = "암모니아";
                    textObj2.GetComponent<Text>().text = "9";
                }
            }
            else if(toggle6.isOn == true)
            {            
                if(toggle9.isOn == true)
                {
                    a.SetActive(true);
                    img1.SetActive(false);
                    img2.SetActive(false);
                    img3.SetActive(false);
                    img4.SetActive(false);
                    img5.SetActive(false);
                    img6.SetActive(false);
                    img7.SetActive(false);
                    img8.SetActive(false);
                    img9.SetActive(false);
                    img10.SetActive(false);
                    img11.SetActive(true);
                    img12.SetActive(false);
                    img13.SetActive(false);
                    img14.SetActive(false);
                    img15.SetActive(false);
                    img16.SetActive(false);
                    re.material.color = new Color(10/255f, 184/255f, 182/255f);
                    textObj1.GetComponent<Text>().text = "베이킹소다";
                    textObj2.GetComponent<Text>().text = "09";

                }
                else if(toggle10.isOn == true)
                {
                    a.SetActive(true);
                    img1.SetActive(false);
                    img2.SetActive(false);
                    img3.SetActive(false);
                    img4.SetActive(false);
                    img5.SetActive(false);
                    img6.SetActive(false);
                    img7.SetActive(false);
                    img8.SetActive(false);
                    img9.SetActive(false);
                    img10.SetActive(true);
                    img11.SetActive(false);
                    img12.SetActive(false);
                    img13.SetActive(false);
                    img14.SetActive(false);
                    img15.SetActive(false);
                    img16.SetActive(false);
                    re.material.color = new Color(34/255f, 180/255f, 107/255f);
                    textObj1.GetComponent<Text>().text = "베이킹소다";
                    textObj2.GetComponent<Text>().text = "08";
                }
                else if(toggle11.isOn == true)
                {
                    a.SetActive(true);
                    img1.SetActive(false);
                    img2.SetActive(false);
                    img3.SetActive(false);
                    img4.SetActive(false);
                    img5.SetActive(false);
                    img6.SetActive(false);
                    img7.SetActive(false);
                    img8.SetActive(false);
                    img9.SetActive(true);
                    img10.SetActive(false);
                    img11.SetActive(false);
                    img12.SetActive(false);
                    img13.SetActive(false);
                    img14.SetActive(false);
                    img15.SetActive(false);
                    img16.SetActive(false);
                    re.material.color = new Color(51/255f, 169/255f, 75/255f);
                    textObj1.GetComponent<Text>().text = "베이킹소다";
                    textObj2.GetComponent<Text>().text = "07";
                }
            }
            else if(toggle7.isOn == true)
            {            
                if(toggle9.isOn == true)
                {
                    a.SetActive(true);
                    img1.SetActive(false);
                    img2.SetActive(false);
                    img3.SetActive(false);
                    img4.SetActive(false);
                    img5.SetActive(false);
                    img6.SetActive(false);
                    img7.SetActive(false);
                    img8.SetActive(false);
                    img9.SetActive(false);
                    img10.SetActive(false);
                    img11.SetActive(false);
                    img12.SetActive(true);
                    img13.SetActive(false);
                    img14.SetActive(false);
                    img15.SetActive(false);
                    img16.SetActive(false);
                    re.material.color = new Color(70/255f, 144/255f, 205/255f);
                    textObj1.GetComponent<Text>().text = "세척제";
                    textObj2.GetComponent<Text>().text = "10";
                }
                else if(toggle10.isOn == true)
                {
                    a.SetActive(true);
                    img1.SetActive(false);
                    img2.SetActive(false);
                    img3.SetActive(false);
                    img4.SetActive(false);
                    img5.SetActive(false);
                    img6.SetActive(false);
                    img7.SetActive(false);
                    img8.SetActive(false);
                    img9.SetActive(false);
                    img10.SetActive(false);
                    img11.SetActive(true);
                    img12.SetActive(false);
                    img13.SetActive(false);
                    img14.SetActive(false);
                    img15.SetActive(false);
                    img16.SetActive(false);
                    re.material.color = new Color(10/255f, 184/255f, 182/255f);
                    textObj1.GetComponent<Text>().text = "세척제";
                    textObj2.GetComponent<Text>().text = "09";                    
                }
                else if(toggle11.isOn == true)
                {
                    a.SetActive(true);
                    img1.SetActive(false);
                    img2.SetActive(false);
                    img3.SetActive(false);
                    img4.SetActive(false);
                    img5.SetActive(false);
                    img6.SetActive(false);
                    img7.SetActive(false);
                    img8.SetActive(false);
                    img9.SetActive(false);
                    img10.SetActive(true);
                    img11.SetActive(false);
                    img12.SetActive(false);
                    img13.SetActive(false);
                    img14.SetActive(false);
                    img15.SetActive(false);
                    img16.SetActive(false);
                    re.material.color = new Color(34/255f, 180/255f, 107/255f);
                    textObj1.GetComponent<Text>().text = "세척제";
                    textObj2.GetComponent<Text>().text = "08";                    
                }
            }
            else if(toggle8.isOn == true)
            {            
                if(toggle9.isOn == true)
                {
                    a.SetActive(true);
                    img1.SetActive(false);
                    img2.SetActive(false);
                    img3.SetActive(false);
                    img4.SetActive(false);
                    img5.SetActive(false);
                    img6.SetActive(false);
                    img7.SetActive(false);
                    img8.SetActive(false);
                    img9.SetActive(false);
                    img10.SetActive(false);
                    img11.SetActive(false);
                    img12.SetActive(false);
                    img13.SetActive(false);
                    img14.SetActive(false);
                    img15.SetActive(false);
                    img16.SetActive(true);
                    re.material.color = new Color(70/255f, 44/255f, 131/255f);
                    textObj1.GetComponent<Text>().text = "수산화나트륨";
                    textObj2.GetComponent<Text>().text = "14";
                }
                else if(toggle10.isOn == true)
                {
                    a.SetActive(true);
                    img1.SetActive(false);
                    img2.SetActive(false);
                    img3.SetActive(false);
                    img4.SetActive(false);
                    img5.SetActive(false);
                    img6.SetActive(false);
                    img7.SetActive(false);
                    img8.SetActive(false);
                    img9.SetActive(false);
                    img10.SetActive(false);
                    img11.SetActive(false);
                    img12.SetActive(false);
                    img13.SetActive(false);
                    img14.SetActive(false);
                    img15.SetActive(true);
                    img16.SetActive(false);
                    re.material.color = new Color(99/255f, 69/255f, 157/255f);
                    textObj1.GetComponent<Text>().text = "수산화나트륨";
                    textObj2.GetComponent<Text>().text = "13";                    
                }
                else if(toggle11.isOn == true)
                {
                    a.SetActive(true);
                    img1.SetActive(false);
                    img2.SetActive(false);
                    img3.SetActive(false);
                    img4.SetActive(false);
                    img5.SetActive(false);
                    img6.SetActive(false);
                    img7.SetActive(false);
                    img8.SetActive(false);
                    img9.SetActive(false);
                    img10.SetActive(false);
                    img11.SetActive(false);
                    img12.SetActive(false);
                    img13.SetActive(false);
                    img14.SetActive(true);
                    img15.SetActive(false);
                    img16.SetActive(false);
                    re.material.color = new Color(87/255f, 80/255f, 160/255f);
                    textObj1.GetComponent<Text>().text = "수산화나트륨";
                    textObj2.GetComponent<Text>().text = "12";
                }
            }
    }

    public void reset()
    {
        a.SetActive(false);
        //re.material.color = new Color(255/255f, 255/255f, 255/255f);
        img1.SetActive(true);
        img2.SetActive(false);
        img3.SetActive(false);
        img4.SetActive(false);
        img5.SetActive(false);
        img6.SetActive(false);
        img7.SetActive(false);
        img8.SetActive(false);
        img9.SetActive(false);
        img10.SetActive(false);
        img11.SetActive(false);
        img12.SetActive(false);
        img13.SetActive(false);
        img14.SetActive(false);
        img15.SetActive(false);
        img16.SetActive(false);
        textObj1.GetComponent<Text>().text = " Name";
        textObj2.GetComponent<Text>().text = "N";

    }

}