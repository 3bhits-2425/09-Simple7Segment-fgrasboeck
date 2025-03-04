using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SegmentController : MonoBehaviour
{
    public GameObject segmentOben;
    public GameObject segmentObenLinks;
    public GameObject segmentObenRechts;
    public GameObject segmentMitte;
    public GameObject segmentUntenLinks;
    public GameObject segmentUntenRechts;
    public GameObject segmentUnten;

    private Dictionary<int, bool[]> zahlen = new Dictionary<int, bool[]>()
    {
        { 0, new bool[] { true, true, true, false, true, true, true } },  // 0
        { 1, new bool[] { false, false, true, false, false, true, false } }, // 1
        { 2, new bool[] { true, false, true, true, true, false, true } },  // 2
        { 3, new bool[] { true, false, true, true, false, true, true } },  // 3
        { 4, new bool[] { false, true, true, true, false, true, false } }, // 4
        { 5, new bool[] { true, true, false, true, false, true, true } },  // 5
        { 6, new bool[] { true, true, false, true, true, true, true } },   // 6
        { 7, new bool[] { true, false, true, false, false, true, false } },// 7
        { 8, new bool[] { true, true, true, true, true, true, true } },    // 8
        { 9, new bool[] { true, true, true, true, false, true, true } }    // 9
    };

    void Update()
    {
        for (int i = 0; i <= 9; i++)
        {
            if (Input.GetKeyDown(i.ToString()))
            {
                SetNumber(i);
            }
        }
    }

    void SetNumber(int number)
    {
        bool[] segments = zahlen[number];

        segmentOben.SetActive(segments[0]);
        segmentObenLinks.SetActive(segments[1]);
        segmentObenRechts.SetActive(segments[2]);
        segmentMitte.SetActive(segments[3]);
        segmentUntenLinks.SetActive(segments[4]);
        segmentUntenRechts.SetActive(segments[5]);
        segmentUnten.SetActive(segments[6]);
    }
}
