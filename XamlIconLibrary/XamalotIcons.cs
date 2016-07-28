using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamlIconLibrary
{
    /// <summary>
    /// All predefined Xamalot Icons
    /// </summary>
    public enum XamalotIcons
    {
        _Default,
        AkirossAudioButtonSet4
    }

    /// <summary>
    /// structure used to pass back author and data
    /// </summary>
    internal struct XamalotIconInformation
    {
        public string _data;
        public string _author;
    }

    /// <summary>
    /// Static class used to help with <see cref="XamalotIcons"/>
    /// </summary>
    internal static class XamalotIconsHelper
    {
    }


}
