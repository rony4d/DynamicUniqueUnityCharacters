using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UMA.CharacterSystem;
using UMA;
using System.Linq;

public class WardrobeSlotLogic
{
    List<WardrobeSlot> _wardrobeSlots { get; set; }

    public List<WardrobeSlot> GetAllWardrobeSlots(){
        _wardrobeSlots = new List<WardrobeSlot>();
        _wardrobeSlots.Add(new WardrobeSlot(){ Id = (int)SlotNames.AlternateHands,Name = SlotNames.AlternateHands.ToString() });
        _wardrobeSlots.Add(new WardrobeSlot() { Id = (int)SlotNames.Cape, Name = SlotNames.Cape.ToString() });
        _wardrobeSlots.Add(new WardrobeSlot() { Id = (int)SlotNames.Chest, Name = SlotNames.Chest.ToString() });
        _wardrobeSlots.Add(new WardrobeSlot() { Id = (int)SlotNames.Complexion, Name = SlotNames.Complexion.ToString() });
        _wardrobeSlots.Add(new WardrobeSlot() { Id = (int)SlotNames.Ears, Name = SlotNames.Ears.ToString() });
        _wardrobeSlots.Add(new WardrobeSlot() { Id = (int)SlotNames.Eyebrows, Name = SlotNames.Eyebrows.ToString() });
        _wardrobeSlots.Add(new WardrobeSlot() { Id = (int)SlotNames.Eyes, Name = SlotNames.Eyes.ToString() });
        _wardrobeSlots.Add(new WardrobeSlot() { Id = (int)SlotNames.Face, Name = SlotNames.Face.ToString() });
        _wardrobeSlots.Add(new WardrobeSlot() { Id = (int)SlotNames.Feet, Name = SlotNames.Feet.ToString() });
        _wardrobeSlots.Add(new WardrobeSlot() { Id = (int)SlotNames.Gauntlets, Name = SlotNames.Gauntlets.ToString() });
        _wardrobeSlots.Add(new WardrobeSlot() { Id = (int)SlotNames.Hair, Name = SlotNames.Hair.ToString() });
        _wardrobeSlots.Add(new WardrobeSlot() { Id = (int)SlotNames.Helmet, Name = SlotNames.Helmet.ToString() });
        _wardrobeSlots.Add(new WardrobeSlot() { Id = (int)SlotNames.Legs, Name = SlotNames.Legs.ToString() });
        _wardrobeSlots.Add(new WardrobeSlot() { Id = (int)SlotNames.ThighGuards, Name = SlotNames.ThighGuards.ToString() });
        _wardrobeSlots.Add(new WardrobeSlot() { Id = (int)SlotNames.Underwear, Name = SlotNames.Underwear.ToString() });
        _wardrobeSlots.Add(new WardrobeSlot() { Id = (int)SlotNames.Waist, Name = SlotNames.Waist.ToString() });
        _wardrobeSlots.Add(new WardrobeSlot() { Id = (int)SlotNames.Beard, Name = SlotNames.Beard.ToString() });


        return _wardrobeSlots;
    }

    public List<WardrobeSlot> GetMaleWorkerSlots()
    {
        _wardrobeSlots = new List<WardrobeSlot>();
        _wardrobeSlots.Add(new WardrobeSlot() { Id = (int)SlotNames.Waist, Name = SlotNames.Waist.ToString() });
        _wardrobeSlots.Add(new WardrobeSlot() { Id = (int)SlotNames.Beard, Name = SlotNames.Beard.ToString() });
        _wardrobeSlots.Add(new WardrobeSlot() { Id = (int)SlotNames.Feet, Name = SlotNames.Feet.ToString() });
        _wardrobeSlots.Add(new WardrobeSlot() { Id = (int)SlotNames.Helmet, Name = SlotNames.Helmet.ToString() });

        return _wardrobeSlots;
    }

    public List<WardrobeSlot> GetFemaleWorkerSlots()
    {
        _wardrobeSlots = new List<WardrobeSlot>();
        _wardrobeSlots.Add(new WardrobeSlot() { Id = (int)SlotNames.Hair, Name = SlotNames.Hair.ToString() });
        _wardrobeSlots.Add(new WardrobeSlot() { Id = (int)SlotNames.Hands, Name = SlotNames.Hands.ToString() });
        _wardrobeSlots.Add(new WardrobeSlot() { Id = (int)SlotNames.Helmet, Name = SlotNames.Helmet.ToString() });
        _wardrobeSlots.Add(new WardrobeSlot() { Id = (int)SlotNames.Waist, Name = SlotNames.Waist.ToString() });
        _wardrobeSlots.Add(new WardrobeSlot() { Id = (int)SlotNames.Legs, Name = SlotNames.Legs.ToString() });
        _wardrobeSlots.Add(new WardrobeSlot() { Id = (int)SlotNames.Shoulders, Name = SlotNames.Shoulders.ToString() });
        _wardrobeSlots.Add(new WardrobeSlot() { Id = (int)SlotNames.Chest, Name = SlotNames.Chest.ToString() });
        _wardrobeSlots.Add(new WardrobeSlot() { Id = (int)SlotNames.Feet, Name = SlotNames.Feet.ToString() });
        _wardrobeSlots.Add(new WardrobeSlot() { Id = (int)SlotNames.Underwear, Name = SlotNames.Underwear.ToString() });


        return _wardrobeSlots;
    }
        //Create a folder and save the avatars there and then compare the values of each avatar


}
