using UnityEngine;
using System.Collections;

public enum RoleCategoryEnum
{
    Regular = 1,
    Enchanted = 2,

}
public enum RoleEnum
{
    Worker = 1,
    Soldier = 2,
}
public enum SlotNames
{
    Hair = 1,
    Eyebrows = 2,
    Eyes = 3,
    Face = 4,
    Chest = 5,
    Helmet = 6,
    Feet = 7,
    Underwear = 8,
    Ears = 9,
    Legs = 10,
    Waist = 11,
    Complexion = 12,
    Cape = 13,
    AlternateHands = 14,
    ThighGuards = 15,
    Gauntlets = 16,
    Beard = 17,
    Shoulders = 18,
    Hands = 19,
    FullOutfit = 20,

}

public enum WardrobeItemNames
{
    #region male
    DevlishGoatee = 1,
    BumsBeard = 2,
    IndianLoinCloth = 3,
    SpartanWarriorSkirt = 4,
    SpartanWarriorSandals = 5,
    EnchantedHood = 6,

    #endregion

    #region female
    PeasantCap = 7,
    PeasantBelt = 8,
    PeasantFemaleGlove = 9,
    PeasantLowerBody = 10,
    PeasantShawl = 11,
    PeasantShoe = 12,
    PeasantTop = 13,
    FemaleHair1 = 14,
    FemaleHair2 = 15,
    FemaleHair3 = 16,
    FemaleUndies2 = 17,

    #endregion

    #region Unisex
    EgyptianBlacksmithBelt = 18,
    EgyptianBlacksmithHat = 19,
    EgyptianBlacksmithApron = 20,
    EgyptianBlacksmithShoes = 21,
    EgyptianBlacksmithSkirt = 22
    #endregion
}

public enum Gender{
    Male = 1,
    Female = 2
}

public enum Kingdoms{
    Wakanda = 1,
    Asgard = 2,

}

public enum Genome{
    height,
    armLength,
    upperMuscle,
    lowerMuscle,
    upperWeight,
    lowerWeight 
}