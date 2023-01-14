using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public struct cord
{
    public float x, y;
}

public class Main : MonoBehaviour
{
    public GameObject Circleoncircle;
    public Button ButtonCircleColor;
    public GameObject centercirlce;
    public LineRenderer linespawn;
    public GameObject Canvas;
    public Text text;
    public List<cord> arr = new List<cord>();
    public List<bool> used = new List<bool>();

    public int size = 85;
    [SerializeField] Text inputSize;

    public List<Button> Buttons = new List<Button>();
    public cord template;
    public List<cord> cord_in_circl = new List<cord>();
    public List<cord> FirstPlace = new List<cord>();
    public Vector3[] Gradient = new Vector3[85];
    public List<Vector3> S_Gradient = new List<Vector3>();
    private Main Instance { get; set; }
    public void Awake()
    {
        Instance = this;
        Gradient[0] = new Vector3(87f, 16f, 132f);
        Gradient[1] = new Vector3(86f, 1f, 137f);
        Gradient[2] = new Vector3(86f, 0f, 136f);
        Gradient[3] = new Vector3(84f, 3f, 141f);
        Gradient[4] = new Vector3(82f, 7f, 146f);
        Gradient[5] = new Vector3(79f, 10f, 152f);
        Gradient[6] = new Vector3(77f, 15f, 157f);
        Gradient[7] = new Vector3(74f, 20f, 163f);
        Gradient[8] = new Vector3(71f, 26f, 169f);
        Gradient[9] = new Vector3(69f, 34f, 176f);
        Gradient[10] = new Vector3(68f, 43f, 181f);
        Gradient[11] = new Vector3(66f, 51f, 185f);
        Gradient[12] = new Vector3(67f, 59f, 188f);
        Gradient[13] = new Vector3(66f, 67f, 191f);
        Gradient[14] = new Vector3(66f, 73f, 193f);
        Gradient[15] = new Vector3(67f, 78f, 194f);
        Gradient[16] = new Vector3(67f, 90f, 198f);
        Gradient[17] = new Vector3(66f, 98f, 201f);
        Gradient[18] = new Vector3(67f, 105f, 202f);
        Gradient[19] = new Vector3(67f, 109f, 204f);
        Gradient[20] = new Vector3(66f, 116f, 206f);
        Gradient[21] = new Vector3(66f, 125f, 208f);
        Gradient[22] = new Vector3(67f, 137f, 209f);
        Gradient[23] = new Vector3(67f, 148f, 209f);
        Gradient[24] = new Vector3(67f, 156f, 209f);
        Gradient[25] = new Vector3(66f, 163f, 209f);
        Gradient[26] = new Vector3(66f, 170f, 209f);
        Gradient[27] = new Vector3(67f, 178f, 209f);
        Gradient[28] = new Vector3(66f, 183f, 209f);
        Gradient[29] = new Vector3(68f, 188f, 209f);
        Gradient[30] = new Vector3(69f, 192f, 209f);
        Gradient[31] = new Vector3(73f, 198f, 209f);
        Gradient[32] = new Vector3(78f, 201f, 207f);
        Gradient[33] = new Vector3(93f, 201f, 193f);
        Gradient[34] = new Vector3(102f, 201f, 184f);
        Gradient[35] = new Vector3(115f, 201f, 171f);
        Gradient[36] = new Vector3(129f, 201f, 158f);
        Gradient[37] = new Vector3(144f, 201f, 142f);
        Gradient[38] = new Vector3(153f, 201f, 133f);
        Gradient[39] = new Vector3(169f, 201f, 114f);
        Gradient[40] = new Vector3(179f, 201f, 104f);
        Gradient[41] = new Vector3(188f, 201f, 94f);
        Gradient[42] = new Vector3(199f, 195f, 81f);
        Gradient[43] = new Vector3(205f, 191f, 73f);
        Gradient[44] = new Vector3(210f, 187f, 67f);
        Gradient[45] = new Vector3(213f, 180f, 59f);
        Gradient[46] = new Vector3(213f, 178f, 56f);
        Gradient[47] = new Vector3(213f, 172f, 53f);
        Gradient[48] = new Vector3(213f, 164f, 48f);
        Gradient[49] = new Vector3(213f, 155f, 44f);
        Gradient[50] = new Vector3(212f, 146f, 42f);
        Gradient[51] = new Vector3(212f, 136f, 38f);
        Gradient[52] = new Vector3(209f, 126f, 36f);
        Gradient[53] = new Vector3(205f, 114f, 36f);
        Gradient[54] = new Vector3(198f, 94f, 36f);
        Gradient[55] = new Vector3(198f, 83f, 36f);
        Gradient[56] = new Vector3(190f, 76f, 36f);
        Gradient[57] = new Vector3(187f, 71f, 36f);
        Gradient[58] = new Vector3(184f, 64f, 36f);
        Gradient[59] = new Vector3(180f, 56f, 36f);
        Gradient[60] = new Vector3(176f, 50f, 36f);
        Gradient[61] = new Vector3(172f, 43f, 36f);
        Gradient[62] = new Vector3(166f, 36f, 36f);
        Gradient[63] = new Vector3(164f, 33f, 38f);
        Gradient[64] = new Vector3(161f, 30f, 40f);
        Gradient[65] = new Vector3(157f, 27f, 44f);
        Gradient[66] = new Vector3(153f, 24f, 47f);
        Gradient[67] = new Vector3(150f, 23f, 51f);
        Gradient[68] = new Vector3(147f, 21f, 53f);
        Gradient[69] = new Vector3(145f, 21f, 57f);
        Gradient[70] = new Vector3(141f, 19f, 62f);
        Gradient[71] = new Vector3(137f, 18f, 66f);
        Gradient[72] = new Vector3(134f, 17f, 70f);
        Gradient[73] = new Vector3(130f, 17f, 75f);
        Gradient[74] = new Vector3(126f, 17f, 79f);
        Gradient[75] = new Vector3(124f, 16f, 83f);
        Gradient[76] = new Vector3(118f, 16f, 92f);
        Gradient[77] = new Vector3(112f, 16f, 99f);
        Gradient[78] = new Vector3(107f, 16f, 106f);
        Gradient[79] = new Vector3(99f, 16f, 116f);
        Gradient[80] = new Vector3(98f, 17f, 117f);
        Gradient[81] = new Vector3(93f, 16f, 125f);
        Gradient[82] = new Vector3(90f, 17f, 128f);
        Gradient[83] = new Vector3(89f, 16f, 130f);
        Gradient[84] = new Vector3(88f, 15f, 131f);
        
    }
    private float coef = 0.0039215f;

    public void InputSize()
    {
        size = int.Parse(inputSize.text);
    }
    public void StartMain()
    {
        Instantiate(centercirlce, new Vector3(0, 5, 0), Quaternion.identity);
        if(size>85)
        {
            size = 85;
        }

        float step = 0;
        for (int i = 0; i < size; ++i)
        {
            Debug.Log(Gradient[(int)step]);
            S_Gradient.Add(new Vector3(Gradient[(int)step].x, Gradient[(int)step].y, Gradient[(int)step].z));

            step += (float)Gradient.Length / size;
        }
        int[] naScene = new int[size];
        //рисуем "солнышко" с цифрами
        for (int i = 0; i < size; ++i)
        {
            float circleposition = (float)i / (size*5);
            float x = Mathf.Sin(circleposition * Mathf.PI*10) *6;
            float y = Mathf.Cos(circleposition * Mathf.PI*10) *6;
            arr.Add(new cord { x=x, y=y+5 });
            //Debug.Log("x= " + arr[i].x + " y= " + arr[i].y);
            GameObject c = Instantiate(Circleoncircle, new Vector3(x, y + 5, 94), Quaternion.identity);
            c.transform.name = "Circleoncircle"+(i+1).ToString();

            LineRenderer fence = Instantiate(linespawn, new Vector3(x, y + 5, 93.1f), Quaternion.identity);
            Vector3[] positions = new Vector3[2] { new Vector3(0, 0, 2), new Vector3(-x, -y, 2) };
            fence.positionCount = 2;
            fence.SetPositions(positions);

            //Text t = Instantiate(text, new Vector3(x*95, y*95+360, 3), Quaternion.identity);
            Text t = Instantiate(text, new Vector3(x * 54+12.5f, y * 54 + 211, 3), Quaternion.identity);
            t.transform.SetParent(Canvas.transform, false);
            t.text=(i+1).ToString();
        }
        //создает кноп очки
        for (int i = 0; i < size; ++i)
        {
            used.Add(false);
            //Debug.Log("x= "+arr[i].x +" y= "+ arr[i].y);
            Button color = Instantiate(ButtonCircleColor, new Vector3(-700+(i%20*80), -200-(i/20*80), 0), Quaternion.identity);
            FirstPlace.Add(new cord { x = -700 + (i % 20 * 80), y = -200 - (i / 20 * 80) });
            color.transform.name = "ButtonCircleColor"+(i+1).ToString();
           // Debug.Log(i + " xB"+ color.transform.position.x + " yB" + color.transform.position.y);
           
            int i_spawn = Random.Range(0, size);
           //рандомный спавн
            for(int j = 0; j < size; j++)
            {
                if(i_spawn == naScene[j])
                {
                    i_spawn = Random.Range(0, S_Gradient.Count);
                    j = 0;
                }
            }
            naScene[i] = i_spawn;
            //color.GetComponent<Image>().color = new Color(Gradient[i_spawn].x * coef, Gradient[i_spawn].y * coef, Gradient[i_spawn].z * coef, 1);
            color.GetComponent<Image>().color = new Color(S_Gradient[i_spawn].x * coef, S_Gradient[i_spawn].y * coef, S_Gradient[i_spawn].z * coef, 1);
            //нерандомный спавн
            //color.GetComponent<Image>().color = new Color(S_Gradient[i].x * coef, S_Gradient[i].y * coef, S_Gradient[i].z * coef, 1);
            Buttons.Add(color);

            color.transform.SetParent(Canvas.transform, false);
        }
    }

    void Update()
    {

    }
}
