using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person : MonoBehaviour
{
    public SpriteRenderer head;
    public SpriteRenderer eye1;
    public SpriteRenderer eye2;
    public SpriteRenderer eyebrow1;
    public SpriteRenderer eyebrow2;
    public SpriteRenderer mouth;
    public SpriteRenderer shirt;
    public SpriteRenderer hair;
    public Sprite[] heads;
    public Sprite[] eyes;
    public Sprite[] eyebrows;
    public Sprite[] mouths;
    public Sprite[] shirts;
    public Sprite[] hairstyles;
    public int id;

    public void SetHeads(int x, bool y = false, int z = 0)
    {
        if (y && z == id)
        {
            if (x > 0)
            {
                x--;
            }
            else
            {
                x++;
            }
        }

        head.sprite = heads[x];
    }

    public void SetEyes(int x, bool y = false, int z = 0)
    {
        if (y && z == id)
        {
            if (x > 0)
            {
                x--;
            }
            else
            {
                x++;
            }
        }

        eye1.sprite = eyes[x];
        eye2.sprite = eyes[x];
    }

    public void SetEyebrows(int x, bool y = false, int z = 0)
    {
        if (y && z == id)
        {
            if (x > 0)
            {
                x--;
            }
            else
            {
                x++;
            }
        }

        eyebrow1.sprite = eyebrows[x];
        eyebrow2.sprite = eyebrows[x];
    }

    public void SetMouth(int x, bool y = false, int z = 0)
    {
        if (y && z == id)
        {
            if (x > 0)
            {
                x--;
            }
            else
            {
                x++;
            }
        }
        mouth.sprite = mouths[x];
    }

    public void SetShirt(int x, bool y = false, int z = 0)
    {
        if (y && z == id)
        {
            if (x > 0)
            {
                x--;
            }
            else
            {
                x++;
            }
        }
        shirt.sprite = shirts[x];
    }

    public void SetHair(int x, bool y = false, int z = 0)
    {
        if (y && z == id)
        {
            if (x > 0)
            {
                x--;
            }
            else
            {
                x++;
            }
        }
        hair.sprite = hairstyles[x];
    }
}
