using UnityEngine;
using System.Collections;
using UMA.CharacterSystem;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using System;

public class DynamicCharacterBuilderLogic 
{
    readonly WardrobeItemLogic WardrobeItemLogic;
    readonly WardrobeSlotLogic wardrobeSlotLogic;

    Dictionary<string, Dictionary<string,bool>> wardrobeSlotItemsUsed;

    List<WardrobeItem> MaleWorkerWardrobeItems;
    List<WardrobeItem> FemaleWorkerWardrobeItems;

    static bool isMaleWardrobeSlotUsedDictionaryLoaded = false;
    static bool isFemaleWardrobeSlotUsedDictionaryLoaded = false;
    Dictionary<string, bool> wardrobeItemDictionary;

    List<WardrobeSlot> MaleWorkerWardrobeslots;
    List<WardrobeSlot> FemaleWorkerWardrobeslots;

    public DynamicCharacterBuilderLogic(){
        
        wardrobeSlotLogic = new WardrobeSlotLogic();
        WardrobeItemLogic = new WardrobeItemLogic();

        MaleWorkerWardrobeslots = wardrobeSlotLogic.GetMaleWorkerSlots().Randomize().ToList();
        FemaleWorkerWardrobeslots = wardrobeSlotLogic.GetFemaleWorkerSlots().Randomize().ToList();

        wardrobeSlotItemsUsed = new Dictionary<string, Dictionary<string, bool>>();

        MaleWorkerWardrobeItems = WardrobeItemLogic.GetMaleWorkerWardrobeItems().Randomize().ToList();
        FemaleWorkerWardrobeItems = WardrobeItemLogic.GetFemaleWorkerWardrobeItems().Randomize().ToList();
    }
    public void BuildWorkerAvatar(DynamicCharacterAvatar Avatar, Gender gender)
    {
        


        switch (gender)
        {
            case Gender.Male:
                if (!isMaleWardrobeSlotUsedDictionaryLoaded)
                {
                    foreach (WardrobeItem item in MaleWorkerWardrobeItems)
                    {
                       
                        if (!wardrobeSlotItemsUsed.Keys.Contains(item.WardrobeSlot.Name))// first time
                        {
                            wardrobeItemDictionary = new Dictionary<string, bool>();
                            wardrobeItemDictionary.Add(item.Name, false); 

                            wardrobeSlotItemsUsed.Add(item.WardrobeSlot.Name, wardrobeItemDictionary);


                        }else{
                             
                            foreach (var wardrobeSlotItem in wardrobeSlotItemsUsed)
                            {
                                string slot = wardrobeSlotItem.Key;
                                if(slot == item.WardrobeSlot.Name){
                                    if (!wardrobeSlotItemsUsed[slot].Keys.Contains(item.Name))
                                    {
                                        wardrobeSlotItemsUsed[slot].Add(item.Name, false);

                                    }
                                }
                            }

                        }


                    }
                    isMaleWardrobeSlotUsedDictionaryLoaded = true;
                }

                // Set random wardrobe slots.

                foreach (WardrobeSlot item in MaleWorkerWardrobeslots)
                {
                    int cnt = MaleWorkerWardrobeslots.Count;
                    if (cnt > 0)
                    {
                        string slotItemName = GetNextWardrobeSlotItem(item.Name);
                        if (string.IsNullOrEmpty(slotItemName))
                        {

                            Avatar.ClearSlot(item.Name);
                        }
                        else
                        {

                            Avatar.SetSlot(item.Name, slotItemName);
                        }
                        wardrobeSlotItemsUsed[item.Name][slotItemName] = true;
                        RemoveUsedWardrobeItems(item.Name,gender);

                    }
                }

                break;
            case Gender.Female:
                if (!isFemaleWardrobeSlotUsedDictionaryLoaded)
                {
                    foreach (WardrobeItem item in FemaleWorkerWardrobeItems)
                    {

                        if (!wardrobeSlotItemsUsed.Keys.Contains(item.WardrobeSlot.Name))// first time
                        {
                            wardrobeItemDictionary = new Dictionary<string, bool>();
                            wardrobeItemDictionary.Add(item.Name, false);

                            wardrobeSlotItemsUsed.Add(item.WardrobeSlot.Name, wardrobeItemDictionary);


                        }
                        else
                        {

                            foreach (var wardrobeSlotItem in wardrobeSlotItemsUsed)
                            {
                                string slot = wardrobeSlotItem.Key;
                                if (slot == item.WardrobeSlot.Name)
                                {
                                    if (!wardrobeSlotItemsUsed[slot].Keys.Contains(item.Name))
                                    {
                                        wardrobeSlotItemsUsed[slot].Add(item.Name, false);

                                    }
                                }
                            }

                        }


                    }
                    isFemaleWardrobeSlotUsedDictionaryLoaded = true;
                }
                // Set random wardrobe slots.

                foreach (WardrobeSlot item in FemaleWorkerWardrobeslots)
                {
                    int cnt = FemaleWorkerWardrobeslots.Count;
                    if (cnt > 0)
                    {
                        string slotItemName = GetNextWardrobeSlotItem(item.Name);
                        if (string.IsNullOrEmpty(slotItemName))
                        {

                            Avatar.ClearSlot(item.Name);
                        }
                        else
                        {

                            Avatar.SetSlot(item.Name, slotItemName);
                        }
                        wardrobeSlotItemsUsed[item.Name][slotItemName] = true;
                        RemoveUsedWardrobeItems(item.Name,gender);

                    }
                }

                break;
        }
       
        //Dictionary<string, List<UMATextRecipe>> recipes = Avatar.AvailableRecipes;

       

        // Set Random DNA 
        Dictionary<string, DnaSetter> setters = Avatar.GetDNA();
        foreach (KeyValuePair<string, DnaSetter> dna in setters)
        {
            dna.Value.Set(0.35f + (UnityEngine.Random.value * 0.3f));
        }

        Avatar.BuildCharacter(true);
        Avatar.ForceUpdate(true, true, true);

        foreach (var item in Avatar.WardrobeRecipes)
        {
            if (item.Key == "AlternateHead")
            {
                if (item.Value.name.ToLower() == "spartanshield")
                {
                    Debug.Log("He has a shied");
                }
            }
            if (item.Key == "Helmet")
            {
                if (item.Value.name.ToLower() == "spartanhelmet")
                {
                    Debug.Log("He has a helmet");

                }
            }
        }

    }

    public string GetNextWardrobeSlotItem(string slotName){
        string nextSlotItem = "";
        var wardrobeItems = wardrobeSlotItemsUsed[slotName];
        if (wardrobeItems.Count > 0)
        {
            List<string> avalableKeys = wardrobeItems.Keys.ToList();
            List<string> randomizedKeys = avalableKeys.Randomize().ToList();
            foreach (var item in randomizedKeys)
            {

                nextSlotItem = item;
                    break; // leave the loop once we find an unused slot item

            }
        }

        return nextSlotItem;
    }

    public void RemoveUsedWardrobeItems(string slotName,Gender gender){
        
        foreach (var item in wardrobeSlotItemsUsed[slotName])
        {
            string slotItem = item.Key;
            bool isUsed = item.Value;
            if (isUsed)
            {
                wardrobeSlotItemsUsed[slotName].Remove(slotItem);
                if (wardrobeSlotItemsUsed[slotName].Values.Count == 0)
                {
                    RepopulateAllSlotItemsOfEmptySlot(slotName,gender);

                }
                break;
            }

        }

    }

    public void RepopulateAllSlotItemsOfEmptySlot(string slotName,Gender gender){

        switch (gender)
        {
            case Gender.Male:
                List<WardrobeItem> maleWorkerWardrobeItems =
                WardrobeItemLogic.GetMaleWorkerWardrobeItems().
                             Where(prop => prop.WardrobeSlot.Name == slotName).Randomize().ToList();

                foreach (var wardrobeSlotItem in maleWorkerWardrobeItems)
                {

                    wardrobeSlotItemsUsed[slotName].Add(wardrobeSlotItem.Name, false);

                }
                break;
            case Gender.Female:
                List<WardrobeItem> femaleWorkerWardrobeItems =
                WardrobeItemLogic.GetFemaleWorkerWardrobeItems().
                             Where(prop => prop.WardrobeSlot.Name == slotName).Randomize().ToList();

                foreach (var wardrobeSlotItem in femaleWorkerWardrobeItems)
                {
                    wardrobeSlotItemsUsed[slotName].Add(wardrobeSlotItem.Name, false);
                }
                break;
        }
       
    }

}
