using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WardrobeItemLogic
{
    List<WardrobeItem> _maleWardrobeItems { get; set; }

    List<WardrobeItem> _femaleWardrobeItems { get; set; }



    public  List<WardrobeItem> GetMaleWorkerWardrobeItems(){
        _maleWardrobeItems = new List<WardrobeItem>();

        #region Beard

        _maleWardrobeItems.Add(new WardrobeItem()
        {
            Id =
           (int)WardrobeItemNames.BumsBeard,
            Name = WardrobeItemNames.BumsBeard.ToString(),
            WardrobeSlot = new WardrobeSlot() { Id = (int)SlotNames.Beard, Name = SlotNames.Beard.ToString() }
        });

        _maleWardrobeItems.Add(new WardrobeItem() // No beard
        {
            Id = 0,
            Name = string.Empty,
            WardrobeSlot = new WardrobeSlot() { Id = (int)SlotNames.Beard, Name = SlotNames.Beard.ToString() }
        });
        #endregion
        #region waist
        _maleWardrobeItems.Add(new WardrobeItem()
       {
           Id =
          (int)WardrobeItemNames.SpartanWarriorSkirt,
           Name = WardrobeItemNames.SpartanWarriorSkirt.ToString(),
           WardrobeSlot = new WardrobeSlot() { Id = (int)SlotNames.Waist, Name = SlotNames.Waist.ToString() }
       });
        _maleWardrobeItems.Add(new WardrobeItem()
        {
            Id =
           (int)WardrobeItemNames.EgyptianBlacksmithBelt,
            Name = WardrobeItemNames.EgyptianBlacksmithBelt.ToString(),
            WardrobeSlot = new WardrobeSlot() { Id = (int)SlotNames.Waist, Name = SlotNames.Waist.ToString() }
        });
        _maleWardrobeItems.Add(new WardrobeItem()
        {
            Id =
           (int)WardrobeItemNames.IndianLoinCloth,
            Name = WardrobeItemNames.IndianLoinCloth.ToString(),
            WardrobeSlot = new WardrobeSlot() { Id = (int)SlotNames.Waist, Name = SlotNames.Waist.ToString() }
        });
        #endregion

        #region feet
        _maleWardrobeItems.Add(new WardrobeItem() //no foot wear :D
        {
            Id =0,
            Name = string.Empty,
            WardrobeSlot = new WardrobeSlot() { Id = (int)SlotNames.Feet, Name = SlotNames.Feet.ToString() }
        });
        _maleWardrobeItems.Add(new WardrobeItem()
        {
            Id =
         (int)WardrobeItemNames.SpartanWarriorSandals,
            Name = WardrobeItemNames.SpartanWarriorSandals.ToString(),
            WardrobeSlot = new WardrobeSlot() { Id = (int)SlotNames.Feet, Name = SlotNames.Feet.ToString() }
        });
        #endregion
        #region helmet
        _maleWardrobeItems.Add(new WardrobeItem() //no helmet
        {
            Id = 0,
            Name = string.Empty,
            WardrobeSlot = new WardrobeSlot() { Id = (int)SlotNames.Helmet, Name = SlotNames.Helmet.ToString() }
        });
        _maleWardrobeItems.Add(new WardrobeItem()
        {
            Id =(int)WardrobeItemNames.EnchantedHood,
            Name = WardrobeItemNames.EnchantedHood.ToString(),
            WardrobeSlot = new WardrobeSlot() { Id = (int)SlotNames.Helmet, Name = SlotNames.Helmet.ToString() }
        });
        _maleWardrobeItems.Add(new WardrobeItem()
        {
            Id = (int)WardrobeItemNames.EgyptianBlacksmithHat,
            Name = WardrobeItemNames.EgyptianBlacksmithHat.ToString(),
            WardrobeSlot = new WardrobeSlot() { Id = (int)SlotNames.Helmet, Name = SlotNames.Helmet.ToString() }
        });
        #endregion
        return _maleWardrobeItems;
    }



    public List<WardrobeItem> GetFemaleWorkerWardrobeItems()
    {
        _femaleWardrobeItems = new List<WardrobeItem>();

        #region hair
        _femaleWardrobeItems.Add(new WardrobeItem() //no hair
        {
            Id = 0,
            Name = string.Empty,
            WardrobeSlot = new WardrobeSlot() { Id = (int)SlotNames.Hair, Name = SlotNames.Hair.ToString() }
        });
        _femaleWardrobeItems.Add(new WardrobeItem()
        {
            Id =
         (int)WardrobeItemNames.FemaleHair1,
            Name = WardrobeItemNames.FemaleHair1.ToString(),
            WardrobeSlot = new WardrobeSlot() { Id = (int)SlotNames.Hair, Name = SlotNames.Hair.ToString() }
        });
        _femaleWardrobeItems.Add(new WardrobeItem()
        {
            Id =
         (int)WardrobeItemNames.FemaleHair2,
            Name = WardrobeItemNames.FemaleHair2.ToString(),
            WardrobeSlot = new WardrobeSlot() { Id = (int)SlotNames.Hair, Name = SlotNames.Hair.ToString() }
        });
        _femaleWardrobeItems.Add(new WardrobeItem()
        {
            Id =(int)WardrobeItemNames.FemaleHair3,
            Name = WardrobeItemNames.FemaleHair3.ToString(),
            WardrobeSlot = new WardrobeSlot() { Id = (int)SlotNames.Hair, Name = SlotNames.Hair.ToString() }
        });
        #endregion

        #region Underwear
        _femaleWardrobeItems.Add(new WardrobeItem() // female must wear underwear at all times
        {
            Id =(int)WardrobeItemNames.FemaleUndies2,
            Name = WardrobeItemNames.FemaleUndies2.ToString(),
            WardrobeSlot = new WardrobeSlot() { Id = (int)SlotNames.Underwear, Name = SlotNames.Underwear.ToString() }
        });
        #endregion

        #region hands
        _femaleWardrobeItems.Add(new WardrobeItem() //no hands
        {
            Id = 0,
            Name = string.Empty,
            WardrobeSlot = new WardrobeSlot() { Id = (int)SlotNames.Hands, Name = SlotNames.Hands.ToString() }
        });
        _femaleWardrobeItems.Add(new WardrobeItem()
        {
            Id =(int)WardrobeItemNames.PeasantFemaleGlove,
            Name = WardrobeItemNames.PeasantFemaleGlove.ToString(),
            WardrobeSlot = new WardrobeSlot() { Id = (int)SlotNames.Hands, Name = SlotNames.Hands.ToString() }
        });
        #endregion

        #region helmet
        _femaleWardrobeItems.Add(new WardrobeItem() //no helmet
        {
            Id = 0,
            Name = string.Empty,
            WardrobeSlot = new WardrobeSlot() { Id = (int)SlotNames.Helmet, Name = SlotNames.Helmet.ToString() }
        });
        _femaleWardrobeItems.Add(new WardrobeItem()
        {
            Id =
         (int)WardrobeItemNames.PeasantCap,
            Name = WardrobeItemNames.PeasantCap.ToString(),
            WardrobeSlot = new WardrobeSlot() { Id = (int)SlotNames.Helmet, Name = SlotNames.Helmet.ToString() }
        });
        _femaleWardrobeItems.Add(new WardrobeItem()
        {
            Id =
             (int)WardrobeItemNames.EgyptianBlacksmithHat,
            Name = WardrobeItemNames.EgyptianBlacksmithHat.ToString(),
            WardrobeSlot = new WardrobeSlot() { Id = (int)SlotNames.Helmet, Name = SlotNames.Helmet.ToString() }
        });

        #endregion

        #region waist
        _femaleWardrobeItems.Add(new WardrobeItem() //no waist item
        {
            Id = 0,
            Name = string.Empty,
            WardrobeSlot = new WardrobeSlot() { Id = (int)SlotNames.Waist, Name = SlotNames.Waist.ToString() }
        });
        _femaleWardrobeItems.Add(new WardrobeItem()
        {
            Id =(int)WardrobeItemNames.PeasantBelt,
            Name = WardrobeItemNames.PeasantBelt.ToString(),
            WardrobeSlot = new WardrobeSlot() { Id = (int)SlotNames.Waist, Name = SlotNames.Waist.ToString() }
        });
        _femaleWardrobeItems.Add(new WardrobeItem()
        {
            Id =
          (int)WardrobeItemNames.EgyptianBlacksmithBelt,
            Name = WardrobeItemNames.EgyptianBlacksmithBelt.ToString(),
            WardrobeSlot = new WardrobeSlot() { Id = (int)SlotNames.Waist, Name = SlotNames.Waist.ToString() }
        });
        #endregion

        #region legs
        _femaleWardrobeItems.Add(new WardrobeItem() // lady workers must wear a gown or a lower body covering
        {
            Id =(int)WardrobeItemNames.PeasantLowerBody,
            Name = WardrobeItemNames.PeasantLowerBody.ToString(),
            WardrobeSlot = new WardrobeSlot() { Id = (int)SlotNames.Legs, Name = SlotNames.Legs.ToString() }
        });
        #endregion

        #region shoulders
        _femaleWardrobeItems.Add(new WardrobeItem() //no shoulder item
        {
            Id = 0,
            Name = string.Empty,
            WardrobeSlot = new WardrobeSlot() { Id = (int)SlotNames.Shoulders, Name = SlotNames.Shoulders.ToString() }
        });
        _femaleWardrobeItems.Add(new WardrobeItem() 
        {
            Id = (int)WardrobeItemNames.PeasantShawl,
            Name = WardrobeItemNames.PeasantShawl.ToString(),
            WardrobeSlot = new WardrobeSlot() { Id = (int)SlotNames.Shoulders, Name = SlotNames.Shoulders.ToString() }
        });
        #endregion

        #region chest
        _femaleWardrobeItems.Add(new WardrobeItem() //no chest item, but the underwear will always be below for covering
        {
            Id = 0,
            Name = string.Empty,
            WardrobeSlot = new WardrobeSlot() { Id = (int)SlotNames.Chest, Name = SlotNames.Chest.ToString() }
        });
        _femaleWardrobeItems.Add(new WardrobeItem()
        {
            Id = (int)WardrobeItemNames.PeasantTop,
            Name = WardrobeItemNames.PeasantTop.ToString(),
            WardrobeSlot = new WardrobeSlot() { Id = (int)SlotNames.Chest, Name = SlotNames.Chest.ToString() }
        });
        #endregion

        #region feet
        _femaleWardrobeItems.Add(new WardrobeItem() //no feet item, just bare feet
        {
            Id = 0,
            Name = string.Empty,
            WardrobeSlot = new WardrobeSlot() { Id = (int)SlotNames.Feet, Name = SlotNames.Feet.ToString() }
        });
        _femaleWardrobeItems.Add(new WardrobeItem()
        {
            Id = (int)WardrobeItemNames.PeasantShoe,
            Name = WardrobeItemNames.PeasantShoe.ToString(),
            WardrobeSlot = new WardrobeSlot() { Id = (int)SlotNames.Feet, Name = SlotNames.Feet.ToString() }
        });
        #endregion
        return _femaleWardrobeItems;
    }
}
