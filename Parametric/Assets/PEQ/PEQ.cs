using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PEQ : MonoBehaviour
{

    public static Vector3 Circle(float t, float a = 2)
    {
        float x = a * Mathf.Cos(t);
        float y = a * Mathf.Sin(t);
        float z = 0f;

        return new Vector3(x, y, z);
    }
    public static Vector3 Astroid(float t, float a = 2)
    {
        float x = a * Mathf.Pow(Mathf.Cos(t), 3);
        float y = a * Mathf.Pow(Mathf.Sin(t), 3);
        float z = 0f;

        return new Vector3(x, y, z);
    }
    public static Vector3 Epicycloid(float t, float a = 2, float b = 3)
    {
        float x = (a+b)*Mathf.Cos(t) - b * Mathf.Cos( ((a/b)+1) * t); //a * Mathf.Pow(Mathf.Cos(t), 3);
        float y = (a+b)*Mathf.Sin(t) - b * Mathf.Sin( ((a/b)+1) * t); //a * Mathf.Pow(Mathf.Cos(t), 3);

        
        float z = 0f;

        return new Vector3(x, y, z);
    }
    public static Vector3 Epitrochiod(float t, float a = 2, float b = 3, float c = 2)
    {
        float x = (a + b) * Mathf.Cos(t) - c * Mathf.Cos(((a / b) + 1) * t); //a * Mathf.Pow(Mathf.Cos(t), 3);
        float y = (a + b) * Mathf.Sin(t) - c * Mathf.Sin(((a / b) + 1) * t); //a * Mathf.Pow(Mathf.Cos(t), 3);


        float z = 0f;

        return new Vector3(x, y, z);
    }

    public static Vector3 Freeth(float th, float a = 2)
    {
        float r = a * (1 + 2 * Mathf.Sin(th / 2));
        return ToPolar2(r, th);
    }
    private static Vector3 ToPolar(float r, float theta)
    {
        return new Vector3(r * Mathf.Cos(theta), r * Mathf.Sin(theta), 0);
    }

    private static Vector3 ToPolar2(float r, float theta)
    {
        return new Vector3(r * Mathf.Cos(theta) + 30, r * Mathf.Sin(theta), 0);
    }
    private static Vector3 ToPolar3(float r, float theta)
    {
        return new Vector3(r * Mathf.Cos(theta) - 45, r * Mathf.Sin(theta), 0);
    }
    public static Vector3 Rhodonea(float th, float a = 3, float k = 9)
    {
        float r = a * Mathf.Sin(th * k);
        return ToPolar(r, th);
    }
    public static Vector3 Strophoid(float th, float a = 3)
    {
        float r = (a * Mathf.Cos(2*th))/Mathf.Cos(th);
        return ToPolar3(r, th);
    }
    public static Vector3 Circle3D(float t, float a = 2)
    {
        float x = a * Mathf.Cos(t);
        float y = a * Mathf.Sin(t);
        float z = a * t * Mathf.Sin(t) * Mathf.Cos(t);

        return new Vector3(x, y, z);

    }
    public static Vector3 Hypocycloid(float t, float a = 2, float b = 3)
    {
        float x = (a + b) * Mathf.Cos(t) + b * Mathf.Cos(((a / b) - 1) * t); //a * Mathf.Pow(Mathf.Cos(t), 3);
        float y = (a + b) * Mathf.Sin(t) - b * Mathf.Sin(((a / b) - 1) * t); //a * Mathf.Pow(Mathf.Cos(t), 3);


        float z = 0f;

        return new Vector3(x, y, z);
    }
}
