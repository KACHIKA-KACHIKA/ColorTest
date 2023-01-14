using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button1 : MonoBehaviour
{
    [SerializeField] Text Mark;
    [SerializeField] GameObject Mark_panel, button1;
    private float mark = 0;
    private float coef = 0.0039215f;
    private bool check = false, checkCoord = false;
    private int temp = 0;
    private Button[] answer = new Button[85];
    public List<int> numberList = new List<int>();
    public List<Vector3> G_Buffer = new List<Vector3>();
    public void CheckCord()
    {
        for (int i = 0; i < GetComponent<Main>().size; i++)
        {
            button1.transform.position = new Vector3(GetComponent<Main>().arr[i].x, GetComponent<Main>().arr[i].y, 90);
            GetComponent<Main>().cord_in_circl.Add(new cord { x = button1.transform.localPosition.x, y = button1.transform.localPosition.y });
            Debug.Log(GetComponent<Main>().cord_in_circl[i]);
        }
        Destroy(button1);
    }
    private void Start()
    {
        Mark_panel.SetActive(false);
    }
    public void BtnOnClick(Button button)
    {
        if (!checkCoord)
        {
            CheckCord(); checkCoord = true;
        }
        //запоминаем индекс кнопки
        for (int i = 0; i < GetComponent<Main>().size; i++)
        {
            if (GetComponent<Main>().Buttons[i] == button)
            {
                temp = i;
            }
        }
        //убрать кнопку из круга
        for (int i = 0; i < GetComponent<Main>().cord_in_circl.Count; i++)
        {
            if (button.transform.localPosition.x == GetComponent<Main>().cord_in_circl[i].x && button.transform.localPosition.y == GetComponent<Main>().cord_in_circl[i].y)
            {
                button.transform.localPosition = new Vector3(GetComponent<Main>().FirstPlace[temp].x, GetComponent<Main>().FirstPlace[temp].y, 0);
                GetComponent<Main>().used[i] = false;
                answer[i] = null;
                check = true;
                break;
            }
        }
        //ставим в круг
        for (int i = 0; i < GetComponent<Main>().size; i++)
        {
            if(check)
            {
                break;
            }
            if (GetComponent<Main>().used[i] == false)
            { 
                button.transform.position = new Vector3(GetComponent<Main>().arr[i].x, GetComponent<Main>().arr[i].y, 90);
                GetComponent<Main>().used[i] = true;
                answer[i] = button;
                break;
            }            
        }
        check = false; 
    }
    public void BtnEndTEST()
    {
        int Q = 0, maxQ = 1;
        for (int i = 0; i < answer.Length; i++)
        {
            if (answer[i] != null)
            {
                G_Buffer.Add(new Vector3(answer[i].GetComponent<Image>().color.r / coef, answer[i].GetComponent<Image>().color.g / coef, answer[i].GetComponent<Image>().color.b / coef));
               
            }
        }
        Debug.Log("for 1 ");
        //int step += GetComponent<Main>().Gradient.Length / GetComponent<Main>().size;
        for (int i = 0; i < G_Buffer.Count; i++)
        {
            //int step = 0;
            for (int j = 0; j < GetComponent<Main>().S_Gradient.Count; j++)
            {
                //Debug.Log("G_Buffer[i] " + G_Buffer[i] + " Gradient[j] " + GetComponent<Main>().Gradient[j]);
                if (G_Buffer[i] == GetComponent<Main>().S_Gradient[j])
                {
                    Debug.Log("What j? " + j);
                    numberList.Add(j);
                    break;
                }
                //step += GetComponent<Main>().Gradient.Length / GetComponent<Main>().size;
            }
        }
        Debug.Log("for 2 " + numberList);
        for (int i = 0; i < numberList.Count-1; i++)
        {
            if(Mathf.Abs(numberList[i] - numberList[i + 1]) == 1)
            {
                maxQ++;
            }
            else if (numberList[i] - numberList[i + 1] == numberList.Count - 2)
            {
                maxQ++;
            }
            else if (Mathf.Abs(numberList[i] - numberList[i + 1]) >= 10)
            {
                mark -= 10f;
            }
        }
        if(Mathf.Abs(numberList[numberList.Count-1] - numberList[0]) == 1)
        {
            maxQ++;
        }
        Debug.Log("maxQ " + maxQ + "numberList.Count " + numberList.Count);
        mark = ((maxQ * 100.0f) / (float)numberList.Count);
        Mark.text = mark.ToString("0.00");
        Mark_panel.SetActive(true);
    }
}