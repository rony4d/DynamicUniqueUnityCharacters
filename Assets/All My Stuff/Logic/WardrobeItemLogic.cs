using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WardrobeItemLogic
{
    List<WardrobeItem> _wardrobeItems { get; set; }

    public List<WardrobeItem> BuildAllWardrobeItems()
    {
        _wardrobeItems = new List<WardrobeItem>();
        _wardrobeItems.Add(new WardrobeItem()
        {
            Id =
            (int)WardrobeItemNames.BumsBeard,
            Name = WardrobeItemNames.BumsBeard.ToString(),
            WardrobeSlot = new WardrobeSlot() { Id = (int)SlotNames.Beard, Name = SlotNames.Beard.ToString() }
        });
        _wardrobeItems.Add(new WardrobeItem() // No beard
        {
            Id =
            0,
            Name = string.Empty,
            WardrobeSlot = new WardrobeSlot() { Id = (int)SlotNames.Hair, Name = SlotNames.Hair.ToString() }
        });
        _wardrobeItems.Add(new WardrobeItem()
        {
            Id =
           (int)WardrobeItemNames.IndianLoinCloth,
            Name = WardrobeItemNames.IndianLoinCloth.ToString(),
            WardrobeSlot = new WardrobeSlot() { Id = (int)SlotNames.Waist, Name = SlotNames.Waist.ToString() }
        });
        return _wardrobeItems;
    }


    public  List<WardrobeItem> GetMaleWorkerWardrobeItems(){
        _wardrobeItems = new List<WardrobeItem>();

        _wardrobeItems.Add(new WardrobeItem()
        {
            Id =
           (int)WardrobeItemNames.BumsBeard,
            Name = WardrobeItemNames.BumsBeard.ToString(),
            WardrobeSlot = new WardrobeSlot() { Id = (int)SlotNames.Beard, Name = SlotNames.Beard.ToString() }
        });

        _wardrobeItems.Add(new WardrobeItem() // No beard
        {
            Id = 0,
            Name = string.Empty,
            WardrobeSlot = new WardrobeSlot() { Id = (int)SlotNames.Beard, Name = SlotNames.Beard.ToString() }
        });
       
        _wardrobeItems.Add(new WardrobeItem()
        {
            Id =
           (int)WardrobeItemNames.IndianLoinCloth,
            Name = WardrobeItemNames.IndianLoinCloth.ToString(),
            WardrobeSlot = new WardrobeSlot() { Id = (int)SlotNames.Waist, Name = SlotNames.Waist.ToString() }
        });

        _wardrobeItems.Add(new WardrobeItem()
        {
            Id =
          (int)WardrobeItemNames.SpartanWarriorSkirt,
            Name = WardrobeItemNames.SpartanWarriorSkirt.ToString(),
            WardrobeSlot = new WardrobeSlot() { Id = (int)SlotNames.Waist, Name = SlotNames.Waist.ToString() }
        });
        _wardrobeItems.Add(new WardrobeItem() //no foot wear :D
        {
            Id =0,
            Name = string.Empty,
            WardrobeSlot = new WardrobeSlot() { Id = (int)SlotNames.Feet, Name = SlotNames.Feet.ToString() }
        });
        _wardrobeItems.Add(new WardrobeItem()
        {
            Id =
         (int)WardrobeItemNames.SpartanWarriorSandals,
            Name = WardrobeItemNames.SpartanWarriorSandals.ToString(),
            WardrobeSlot = new WardrobeSlot() { Id = (int)SlotNames.Feet, Name = SlotNames.Feet.ToString() }
        });

        #region helmet
        _wardrobeItems.Add(new WardrobeItem() //no helmet
        {
            Id = 0,
            Name = string.Empty,
            WardrobeSlot = new WardrobeSlot() { Id = (int)SlotNames.Helmet, Name = SlotNames.Helmet.ToString() }
        });
        _wardrobeItems.Add(new WardrobeItem()
        {
            Id =
         (int)WardrobeItemNames.EnchantedHood,
            Name = WardrobeItemNames.EnchantedHood.ToString(),
            WardrobeSlot = new WardrobeSlot() { Id = (int)SlotNames.Helmet, Name = SlotNames.Helmet.ToString() }
        });
        #endregion
        return _wardrobeItems;
    }

    public List<WardrobeItem> GetFemaleWorkerWardrobeItems()
    {
        _wardrobeItems = new List<WardrobeItem>();

        #region hair
        _wardrobeItems.Add(new WardrobeItem() //no hair
        {
            Id = 0,
            Name = string.Empty,
            WardrobeSlot = new WardrobeSlot() { Id = (int)SlotNames.Hair, Name = SlotNames.Hair.ToString() }
        });
        _wardrobeItems.Add(new WardrobeItem()
        {
            Id =
         (int)WardrobeItemNames.FemaleHair1,
            Name = WardrobeItemNames.FemaleHair1.ToString(),
            WardrobeSlot = new WardrobeSlot() { Id = (int)SlotNames.Hair, Name = SlotNames.Hair.ToString() }
        });
        _wardrobeItems.Add(new WardrobeItem()
        {
            Id =
         (int)WardrobeItemNames.FemaleHair2,
            Name = WardrobeItemNames.FemaleHair2.ToString(),
            WardrobeSlot = new WardrobeSlot() { Id = (int)SlotNames.Hair, Name = SlotNames.Hair.ToString() }
        });
        _wardrobeItems.Add(new WardrobeItem()
        {
            Id =(int)WardrobeItemNames.FemaleHair3,
            Name = WardrobeItemNames.FemaleHair3.ToString(),
            WardrobeSlot = new WardrobeSlot() { Id = (int)SlotNames.Hair, Name = SlotNames.Hair.ToString() }
        });
        #endregion

        #region Underwear
        _wardrobeItems.Add(new WardrobeItem() // female must wear underwear at all times
        {
            Id =(int)WardrobeItemNames.FemaleUndies2,
            Name = WardrobeItemNames.FemaleUndies2.ToString(),
            WardrobeSlot = new WardrobeSlot() { Id = (int)SlotNames.Underwear, Name = SlotNames.Underwear.ToString() }
        });
        #endregion

        #region hands
        _wardrobeItems.Add(new WardrobeItem() //no hands
        {
            Id = 0,
            Name = string.Empty,
            WardrobeSlot = new WardrobeSlot() { Id = (int)SlotNames.Hands, Name = SlotNames.Hands.ToString() }
        });
        _wardrobeItems.Add(new WardrobeItem()
        {
            Id =(int)WardrobeItemNames.PeasantFemaleGlove,
            Name = WardrobeItemNames.PeasantFemaleGlove.ToString(),
            WardrobeSlot = new WardrobeSlot() { Id = (int)SlotNames.Hands, Name = SlotNames.Hands.ToString() }
        });
        #endregion

        #region helmet
        _wardrobeItems.Add(new WardrobeItem() //no helmet
        {
            Id = 0,
            Name = string.Empty,
            WardrobeSlot = new WardrobeSlot() { Id = (int)SlotNames.Helmet, Name = SlotNames.Helmet.ToString() }
        });
        _wardrobeItems.Add(new WardrobeItem()
        {
            Id =
         (int)WardrobeItemNames.PeasantCap,
            Name = WardrobeItemNames.PeasantCap.ToString(),
            WardrobeSlot = new WardrobeSlot() { Id = (int)SlotNames.Helmet, Name = SlotNames.Helmet.ToString() }
        });
        #endregion

        #region waist
        _wardrobeItems.Add(new WardrobeItem() //no waist item
        {
            Id = 0,
            Name = string.Empty,
            WardrobeSlot = new WardrobeSlot() { Id = (int)SlotNames.Waist, Name = SlotNames.Waist.ToString() }
        });
        _wardrobeItems.Add(new WardrobeItem()
        {
            Id =(int)WardrobeItemNames.PeasantBelt,
            Name = WardrobeItemNames.PeasantBelt.ToString(),
            WardrobeSlot = new WardrobeSlot() { Id = (int)SlotNames.Waist, Name = SlotNames.Waist.ToString() }
        });
        #endregion

        #region legs
        _wardrobeItems.Add(new WardrobeItem() // lady workers must wear a gown or a lower body covering
        {
            Id =(int)WardrobeItemNames.PeasantLowerBody,
            Name = WardrobeItemNames.PeasantLowerBody.ToString(),
            WardrobeSlot = new WardrobeSlot() { Id = (int)SlotNames.Legs, Name = SlotNames.Legs.ToString() }
        });
        #endregion

        #region shoulders
        _wardrobeItems.Add(new WardrobeItem() //no shoulder item
        {
            Id = 0,
            Name = string.Empty,
            WardrobeSlot = new WardrobeSlot() { Id = (int)SlotNames.Shoulders, Name = SlotNames.Shoulders.ToString() }
        });
        _wardrobeItems.Add(new WardrobeItem() 
        {
            Id = (int)WardrobeItemNames.PeasantLowerBody,
            Name = WardrobeItemNames.PeasantLowerBody.ToString(),
            WardrobeSlot = new WardrobeSlot() { Id = (int)SlotNames.Shoulders, Name = SlotNames.Shoulders.ToString() }
        });
        #endregion

        #region chest
        _wardrobeItems.Add(new WardrobeItem() //no chest item, but the underwear will always be below for covering
        {
            Id = 0,
            Name = string.Empty,
            WardrobeSlot = new WardrobeSlot() { Id = (int)SlotNames.Chest, Name = SlotNames.Chest.ToString() }
        });
        _wardrobeItems.Add(new WardrobeItem()
        {
            Id = (int)WardrobeItemNames.PeasantTop,
            Name = WardrobeItemNames.PeasantTop.ToString(),
            WardrobeSlot = new WardrobeSlot() { Id = (int)SlotNames.Chest, Name = SlotNames.Chest.ToString() }
        });
        #endregion

        #region feet
        _wardrobeItems.Add(new WardrobeItem() //no feet item, just bare feet
        {
            Id = 0,
            Name = string.Empty,
            WardrobeSlot = new WardrobeSlot() { Id = (int)SlotNames.Feet, Name = SlotNames.Feet.ToString() }
        });
        _wardrobeItems.Add(new WardrobeItem()
        {
            Id = (int)WardrobeItemNames.PeasantShoe,
            Name = WardrobeItemNames.PeasantShoe.ToString(),
            WardrobeSlot = new WardrobeSlot() { Id = (int)SlotNames.Feet, Name = SlotNames.Feet.ToString() }
        });
        #endregion
        return _wardrobeItems;
    }
}
