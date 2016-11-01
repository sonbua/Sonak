using System;
using System.Collections.Generic;
using FingerMovingSimulation.Core;

namespace FingerMovingSimulation.Infrastructure.CharacterToLayoutMappers
{
    internal class CharacterToColemakLayoutMapper : ICharacterToLayoutMapper
    {
        private readonly Dictionary<char, IEnumerable<Keys>> decomposedCharacterSet =
            new Dictionary<char, IEnumerable<Keys>>
            {
                // alphabet
                {'a', new[] {Keys.A}},
                {'b', new[] {Keys.B}},
                {'c', new[] {Keys.C}},
                {'d', new[] {Keys.D}},
                {'e', new[] {Keys.E}},
                {'f', new[] {Keys.F}},
                {'g', new[] {Keys.G}},
                {'h', new[] {Keys.H}},
                {'i', new[] {Keys.I}},
                {'j', new[] {Keys.J}},
                {'k', new[] {Keys.K}},
                {'l', new[] {Keys.L}},
                {'m', new[] {Keys.M}},
                {'n', new[] {Keys.N}},
                {'o', new[] {Keys.O}},
                {'p', new[] {Keys.P}},
                {'q', new[] {Keys.Q}},
                {'r', new[] {Keys.R}},
                {'s', new[] {Keys.S}},
                {'t', new[] {Keys.T}},
                {'u', new[] {Keys.U}},
                {'v', new[] {Keys.V}},
                {'w', new[] {Keys.W}},
                {'x', new[] {Keys.X}},
                {'y', new[] {Keys.Y}},
                {'z', new[] {Keys.Z}},
                // alphabet capitalized
                {'A', new[] {Keys.RShift, Keys.A}},
                {'B', new[] {Keys.RShift, Keys.B}},
                {'C', new[] {Keys.RShift, Keys.C}},
                {'D', new[] {Keys.RShift, Keys.D}},
                {'E', new[] {Keys.LShift, Keys.E}},
                {'F', new[] {Keys.RShift, Keys.F}},
                {'G', new[] {Keys.RShift, Keys.G}},
                {'H', new[] {Keys.LShift, Keys.H}},
                {'I', new[] {Keys.LShift, Keys.I}},
                {'J', new[] {Keys.LShift, Keys.J}},
                {'K', new[] {Keys.LShift, Keys.K}},
                {'L', new[] {Keys.LShift, Keys.L}},
                {'M', new[] {Keys.LShift, Keys.M}},
                {'N', new[] {Keys.LShift, Keys.N}},
                {'O', new[] {Keys.LShift, Keys.O}},
                {'P', new[] {Keys.RShift, Keys.P}},
                {'Q', new[] {Keys.RShift, Keys.Q}},
                {'R', new[] {Keys.RShift, Keys.R}},
                {'S', new[] {Keys.RShift, Keys.S}},
                {'T', new[] {Keys.RShift, Keys.T}},
                {'U', new[] {Keys.LShift, Keys.U}},
                {'V', new[] {Keys.RShift, Keys.V}},
                {'W', new[] {Keys.RShift, Keys.W}},
                {'X', new[] {Keys.RShift, Keys.X}},
                {'Y', new[] {Keys.LShift, Keys.Y}},
                {'Z', new[] {Keys.RShift, Keys.Z}},
                // digit
                {'1', new[] {Keys.D1}},
                {'2', new[] {Keys.D2}},
                {'3', new[] {Keys.D3}},
                {'4', new[] {Keys.D4}},
                {'5', new[] {Keys.D5}},
                {'6', new[] {Keys.D6}},
                {'7', new[] {Keys.D7}},
                {'8', new[] {Keys.D8}},
                {'9', new[] {Keys.D9}},
                {'0', new[] {Keys.D0}},
                // digit capitalized
                {'!', new[] {Keys.RShift, Keys.D1}},
                {'@', new[] {Keys.RShift, Keys.D2}},
                {'#', new[] {Keys.RShift, Keys.D3}},
                {'$', new[] {Keys.RShift, Keys.D4}},
                {'%', new[] {Keys.RShift, Keys.D5}},
                {'^', new[] {Keys.LShift, Keys.D6}},
                {'&', new[] {Keys.LShift, Keys.D7}},
                {'*', new[] {Keys.LShift, Keys.D8}},
                {'(', new[] {Keys.LShift, Keys.D9}},
                {')', new[] {Keys.LShift, Keys.D0}},
                // special
                {',', new[] {Keys.OemComma}},
                {'.', new[] {Keys.OemPeriod}},
                {'/', new[] {Keys.OemSlash}},
                {';', new[] {Keys.OemSemicolon}},
                {'\'', new[] {Keys.OemSingleQuote}},
                {'[', new[] {Keys.OemOpenSquareBracket}},
                {']', new[] {Keys.OemCloseSquareBracket}},
                {'\\', new[] {Keys.OemBackSlash}},
                {'-', new[] {Keys.OemMinus}},
                {'=', new[] {Keys.OemPipe}},
                {'`', new[] {Keys.OemGrave}},
                // Shift + special
                {'<', new[] {Keys.LShift, Keys.OemComma}},
                {'>', new[] {Keys.LShift, Keys.OemPeriod}},
                {'?', new[] {Keys.LShift, Keys.OemSlash}},
                {':', new[] {Keys.LShift, Keys.OemSemicolon}},
                {'"', new[] {Keys.LShift, Keys.OemSingleQuote}},
                {'{', new[] {Keys.LShift, Keys.OemOpenSquareBracket}},
                {'}', new[] {Keys.LShift, Keys.OemCloseSquareBracket}},
                {'|', new[] {Keys.LShift, Keys.OemBackSlash}},
                {'_', new[] {Keys.LShift, Keys.OemMinus}},
                {'+', new[] {Keys.LShift, Keys.OemPipe}},
                {'~', new[] {Keys.RShift, Keys.OemGrave}},
                // others
                {' ', new[] {Keys.Space}},
                {'\r', new Keys[] {}},
                {'\n', new[] {Keys.Enter}}
            };

        public IEnumerable<Keys> Map(char c)
        {
            if (decomposedCharacterSet.ContainsKey(c))
            {
                return decomposedCharacterSet[c];
            }

            throw new Exception(string.Format("Do not know how to type this '{0}' letter.", c));
        }
    }
}