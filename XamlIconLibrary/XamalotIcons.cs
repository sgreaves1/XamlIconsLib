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
        AkirossAudioButtonSet4,
        TangoXOfficeCalender
    }

    /// <summary>
    /// structure used to pass back author and data
    /// </summary>
    internal struct XamalotIconInformation
    {
        public bool AkirossAudioButtonSet4Visible;
        public bool TangoXOfficeCalenderVisible;
        public string _author;
    }

    /// <summary>
    /// Static class used to help with <see cref="XamalotIcons"/>
    /// </summary>
    internal static class XamalotIconsHelper
    {
        /// <summary>
        /// Method used to return the bools when the XamalotIcons property is updated
        /// </summary>
        internal static XamalotIconInformation UpdateData(XamalotIcons icon)
        {
            XamalotIconInformation info = new XamalotIconInformation();
            
            switch (icon)
            {
                case XamalotIcons._Default:
                    info._author = "Unknown";
                    break;
                case XamalotIcons.AkirossAudioButtonSet4:
                    info.AkirossAudioButtonSet4Visible = true;
                    info._author = "Akiross";
                    break;
                case XamalotIcons.TangoXOfficeCalender:
                    info.TangoXOfficeCalenderVisible = true;
                    info._author = "Tango";
                    break;

                default:
                    info._author = "Unknown";
                    break;
            }

            return info;
        }
    }


}
