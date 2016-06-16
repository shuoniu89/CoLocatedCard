﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Input;

namespace CoLocatedCardSystem.CollaborationWindow.InteractionModule
{
    public class SortingBoxController
    {
        SortingBoxList list;
        InteractionControllers interactionControllers;

        public SortingBoxController(InteractionControllers interactionControllers)
        {
            this.interactionControllers = interactionControllers;
        }

        /// <summary>
        /// Initialize the sorting box controller
        /// </summary>
        public void Init()
        {
            list = new SortingBoxList();
        }
        /// <summary>
        /// Destroy all sorting boxes
        /// </summary>
        public void Deinit()
        {
            list.Clear();
        }
        /// <summary>
        /// Based on the user, create a sorting box.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="user"></param>
        public void CreateSortingBox(string name, User user)
        {
            SortingBox box = list.AddBox(user, name, this);
            interactionControllers.AddSortingBoxes(box);
        }
        /// <summary>
        /// Add a card to the sortingbox
        /// </summary>
        /// <param name="card"></param>
        /// <param name="box"></param>
        public void AddCardToSortingBox(Card card, SortingBox box)
        {
            box.AddCard(card);
        }

        public void RemoveCardFromSortingBox(Card card, SortingBox box)
        {
            box.RemoveCard(card);
        }
        /// <summary>
        /// Get all sorting box by card
        /// </summary>
        /// <param name="card"></param>
        /// <returns></returns>
        SortingBox[] FindAllSortingBoxesByCard(Card card)
        {
            List<SortingBox> boxes = new List<SortingBox>();
            foreach (SortingBox box in list.GetAllSortingBoxes())
            {
                foreach (Card cd in box.CardList)
                {
                    if (card.CardID == cd.CardID)
                    {
                        boxes.Add(box);
                    }
                }
            }
            return boxes.ToArray();
        }
        /// <summary>
        /// Get all sorting boxes in the list
        /// </summary>
        /// <returns></returns>
        internal SortingBox[] GetAllSortingBoxes()
        {
            return list.GetAllSortingBoxes();
        }

        bool ContainCard(SortingBox box, Card card)
        {
            foreach (Card cd in box.CardList)
            {
                if (card.CardID == cd.CardID)
                {
                    return true;
                }
            }
            return false;
        }

        void DestroyBox(SortingBox box)
        {
            list.RemoveSortingBox(box);
        }

        internal void PointerDown(PointerPoint localPoint, PointerPoint globalPoint, SortingBox box, Type type)
        {
            interactionControllers.TouchController.TouchDown(localPoint, globalPoint, box, type);
        }

        internal void PointerMove(PointerPoint localPoint, PointerPoint globalPoint)
        {
            interactionControllers.TouchController.TouchMove(localPoint, globalPoint);
        }

        internal void PointerUp(PointerPoint localPoint, PointerPoint globalPoint)
        {
            interactionControllers.TouchController.TouchUp(localPoint, globalPoint);
        }

        /// <summary>
        /// Update the ZIndex of the card. Move the card to the top.
        /// </summary>
        /// <param name="card"></param>
        internal void MoveSortingBoxToTop(SortingBox box)
        {
            interactionControllers.MoveSortingBoxToTop(box);
        }
    }
}
