using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Build;
using UnityEngine;

public class ArrayPractice : MonoBehaviour
{

    public int[] scores = new int[5];
    void Start()
    {
        //변수값 넣기
        scores[0] = 60;
        scores[1] = 95;
        scores[2] = 35;
        scores[3] = 45;
        scores[4] = 70;

        // 총 점수의 합
        int sum = 0;
        // 최고 점수
        int maxScore = 0;

        Debug.Log("배열 실습");

       for (int i = 0; i < scores.Length; i++)
        { 
            Debug.Log($"{i + 1} 번째 점수 : {scores[i]}");
            sum += scores[i];
        
        
            if (scores[i] > maxScore)
            {
                maxScore = scores[i];
            }
            }
       // 평균 구하기 ai에게 물어보기
       float average = (float)sum / scores.Length;
        // (float)sum 코드 풀이
        // '()'뒤의 변수(sum)의 값(int값)을 '()'안의 자료형(float)으로
        // 변환하여 바꾼 자료형(float)으로 계산이 가능하도록 함

        Debug.Log($"최고 점수: {maxScore}");
        Debug.Log($"점수의 합: {sum}");
        Debug.Log($"점수의 평균: {average}");
        }
    }

