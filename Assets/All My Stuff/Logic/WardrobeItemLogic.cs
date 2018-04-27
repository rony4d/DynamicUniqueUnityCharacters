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
}
