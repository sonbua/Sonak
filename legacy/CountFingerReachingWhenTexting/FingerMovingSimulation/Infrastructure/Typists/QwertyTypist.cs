﻿using System;
using System.Collections.Generic;
using System.Linq;
using FingerMovingSimulation.Core;
using FingerMovingSimulation.Core.Expanders;
using FingerMovingSimulation.Core.Hands;
using FingerMovingSimulation.Infrastructure.CharacterToLayoutMappers;
using FingerMovingSimulation.Infrastructure.Expanders;
using FingerMovingSimulation.Infrastructure.Expanders.ToneMappers;
using FingerMovingSimulation.Infrastructure.Hands.Qwerty;
using FingerMovingSimulation.Infrastructure.Layouts;
using MiscUtil;

namespace FingerMovingSimulation.Infrastructure.Typists
{
    public class QwertyTypist : ITypist
    {
        private readonly IHand leftHand;
        private readonly IHand rightHand;
        private readonly List<IHand> bothHands;
        private readonly ILayout layout;
        private IVietnameseCharacterExpander vietnameseCharacterExpander;
        private readonly ICharacterToLayoutMapper characterToLayoutMapper;

        public QwertyTypist() : this(new TelexMapper())
        {
        }

        public QwertyTypist(IToneMapper toneMapper)
        {
            leftHand = new LeftHand();
            rightHand = new RightHand();
            bothHands = new List<IHand> {leftHand, rightHand};
            layout = new QwertyLayout();
            ToneMapper = toneMapper;
            characterToLayoutMapper = new CharacterToQwertyLayoutMapper();
        }

        public void ResetHandPosition()
        {
            bothHands.ForEach(hand => hand.ReturnToHomeRow());
        }

        public double Type(string text)
        {
            return text.SelectMany(c => vietnameseCharacterExpander.Expand(c))
                       .SelectMany(c => characterToLayoutMapper.Map(c))
                       .Sum(button => Type(button));
        }

        public IToneMapper ToneMapper
        {
            set { vietnameseCharacterExpander = new VietnameseCharacterExpander(value); }
        }

        private double Type(Keys key)
        {
            if (key == Keys.Space)
            {
                ResetHandPosition();
                return Consts.KeyPressDepth;
            }

            if (key == Keys.Enter)
            {
                var distance = rightHand.Press(key) + Consts.KeyPressDepth;
                ResetHandPosition();
                return distance;
            }

            if (key.IsIn(layout.LeftHandKeys))
            {
                return leftHand.Press(key) + Consts.KeyPressDepth;
            }

            if (key.IsIn(layout.RightHandKeys))
            {
                return rightHand.Press(key) + Consts.KeyPressDepth;
            }

            throw new NotSupportedException(string.Format("Cannot reach this '{0}' key.", key));
        }
    }
}