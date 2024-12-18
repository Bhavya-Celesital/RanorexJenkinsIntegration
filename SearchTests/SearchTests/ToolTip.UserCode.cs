﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace SearchTests
{
    public partial class ToolTip
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

       

        public void CaputureToolTip()
        {
            // TODO: Replace the following line with your code implementation.
           // throw new NotImplementedException();
           var elementWithToolTip= repo.HEXFindReplace.Button;
           elementWithToolTip.MoveTo();
           Delay.Seconds(1);
           try
           {
           	var tooltip = Host.Local.FindSingle<RawText>("//rawtext[@visible='True']");  
	
	        if (tooltip != null)
	        {
	            string tooltipText = tooltip.Element.GetAttributeValueText("ToolTipText") ?? tooltip.Element.GetAttributeValueText("AccessibleDescription") ?? tooltip.Element.GetAttributeValueText("Text");
	            Report.Info("Tooltip Text: " + tooltipText);
	        }
           	
           } 
		     catch (ElementNotFoundException)
		    {
		        Report.Warn("Tooltip not found.");
		    }
        }

    }
}
