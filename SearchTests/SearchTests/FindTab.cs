﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
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
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace SearchTests
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The FindTab recording.
    /// </summary>
    [TestModule("a8429e90-65c8-4d09-b48e-40467269e2aa", ModuleType.Recording, 1)]
    public partial class FindTab : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SearchTestsRepository repository.
        /// </summary>
        public static SearchTestsRepository repo = SearchTestsRepository.Instance;

        static FindTab instance = new FindTab();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public FindTab()
        {
            Text = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static FindTab Instance
        {
            get { return instance; }
        }

#region Variables

        string _Text;

        /// <summary>
        /// Gets or sets the value of variable Text.
        /// </summary>
        [TestVariable("dcef949e-cfad-4d90-a4d9-ec761fbcea22")]
        public string Text
        {
            get { return _Text; }
            set { _Text = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Selected='True') on item 'HEXFindReplace.Find'.", repo.HEXFindReplace.FindInfo, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.HEXFindReplace.FindInfo, "Selected", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HEXFindReplace.FindASCII' at 8;8.", repo.HEXFindReplace.FindASCIIInfo, new RecordItemIndex(1));
            repo.HEXFindReplace.FindASCII.Click("8;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='True') on item 'HEXFindReplace.FindASCII'.", repo.HEXFindReplace.FindASCIIInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.HEXFindReplace.FindASCIIInfo, "Checked", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(3));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HEXFindReplace.Text1687' at 64;15.", repo.HEXFindReplace.Text1687Info, new RecordItemIndex(4));
            repo.HEXFindReplace.Text1687.Click("64;15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'test' with focus on 'HEXFindReplace.Text1687'.", repo.HEXFindReplace.Text1687Info, new RecordItemIndex(5));
            repo.HEXFindReplace.Text1687.PressKeys("test");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'HEXFindReplace.Text1687'.", repo.HEXFindReplace.Text1687Info, new RecordItemIndex(6));
            repo.HEXFindReplace.Text1687.PressKeys("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}{Akey}{LControlKey up}{Back}' with focus on 'HEXFindReplace.Text1687'.", repo.HEXFindReplace.Text1687Info, new RecordItemIndex(7));
            repo.HEXFindReplace.Text1687.PressKeys("{LControlKey down}{Akey}{LControlKey up}{Back}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'german' with focus on 'HEXFindReplace.Text1687'.", repo.HEXFindReplace.Text1687Info, new RecordItemIndex(8));
            repo.HEXFindReplace.Text1687.PressKeys("german");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'HEXFindReplace.Text1687'.", repo.HEXFindReplace.Text1687Info, new RecordItemIndex(9));
            repo.HEXFindReplace.Text1687.PressKeys("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HEXFindReplace.Button' at 18;17.", repo.HEXFindReplace.ButtonInfo, new RecordItemIndex(10));
            repo.HEXFindReplace.Button.Click("18;17");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Text' from item 'Uedit64.Test' and assigning its value to variable 'Text'.", repo.Uedit64.TestInfo, new RecordItemIndex(11));
            Text = repo.Uedit64.Test.Element.GetAttributeValueText("Text");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Uedit64.Test' at 34;10.", repo.Uedit64.TestInfo, new RecordItemIndex(12));
            repo.Uedit64.Test.Click("34;10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", Text, new RecordItemIndex(13));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Text) on item 'HEXFindReplace.Text1687'.", repo.HEXFindReplace.Text1687Info, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.HEXFindReplace.Text1687Info, "Text", Text);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Selected='True') on item 'HEXFindReplace.Find'.", repo.HEXFindReplace.FindInfo, new RecordItemIndex(15));
            Validate.AttributeEqual(repo.HEXFindReplace.FindInfo, "Selected", "True");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
