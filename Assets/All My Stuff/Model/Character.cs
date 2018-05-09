using UnityEngine;
using System.Collections;
using System;

[Serializable]
public class Character
{
    public long Id { get; set; }

    public string Name { get; set; }

    public int RoleId { get; set; }

    public int RoleCategoryId { get; set; }

    public int GenderId { get; set; }

    public long KingdomId { get; set; }

    public decimal Price { get; set; }
    public CharacterDNA CharacterDNA { get; set; }

    public string CharacterGenome { get; set; }

    public string ImageUrlPNG { get; set; }

    public string ImageUrlGIF { get; set; }

}
[Serializable]
public class CharacterDNA{
    public string Id { get; set; }
    public float Height { get; set; }
    public float ArmLength { get; set; }
    public float UpperMuscle { get; set; }
    public float LowerMuscle { get; set; }
    public float UpperWeight { get; set; }
    public float LowerWeight { get; set; }
}


