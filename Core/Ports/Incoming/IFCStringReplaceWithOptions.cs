// <copyright file="IFCStringReplaceWithOptions.cs" company="Matthew Klemetsen">
// Copyright (c) Matthew Klemetsen. All rights reserved.
// </copyright>

namespace FindAndReplace.Core.Ports.Incoming
{
    using FindAndReplace.Core.DataStructures;

    internal interface IFCStringReplaceWithOptions
    {
        public static abstract string fncStringReplaceWithOptions(string p_vstUSSearchIn, string p_vstUSFind, string p_vstUSReplace, ENMFindMode p_enmFindMode, bool p_vbnMatchCase, bool p_vbnMatchWholeWord, bool p_vbnDotMatchesNewline, bool p_vbnTreatLinesAsSeparateStrings);
    }
}
