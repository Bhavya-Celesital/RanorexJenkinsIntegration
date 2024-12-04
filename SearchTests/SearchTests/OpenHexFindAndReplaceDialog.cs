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
    ///The OpenHexFindAndReplaceDialog recording.
    /// </summary>
    [TestModule("051f8864-e3e0-48b4-9990-d0c771210cbd", ModuleType.Recording, 1)]
    public partial class OpenHexFindAndReplaceDialog : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SearchTestsRepository repository.
        /// </summary>
        public static SearchTestsRepository repo = SearchTestsRepository.Instance;

        static OpenHexFindAndReplaceDialog instance = new OpenHexFindAndReplaceDialog();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public OpenHexFindAndReplaceDialog()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static OpenHexFindAndReplaceDialog Instance
        {
            get { return instance; }
        }

#region Variables

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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'TrialPeriodExpiring.Close'", repo.TrialPeriodExpiring.CloseInfo, new ActionTimeout(30000), new RecordItemIndex(0));
            repo.TrialPeriodExpiring.CloseInfo.WaitForExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TrialPeriodExpiring.Close' at 9;13.", repo.TrialPeriodExpiring.CloseInfo, new RecordItemIndex(1));
            repo.TrialPeriodExpiring.Close.Click("9;13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormEdit1UltraEdit64Bit.ApplicationMenu' at 28;7.", repo.FormEdit1UltraEdit64Bit.ApplicationMenuInfo, new RecordItemIndex(2));
            repo.FormEdit1UltraEdit64Bit.ApplicationMenu.Click("28;7");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Uedit64.Open' at 59;20.", repo.Uedit64.OpenInfo, new RecordItemIndex(3));
            repo.Uedit64.Open.Click("59;20");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Open.Text1148' at 233;3.", repo.Open.Text1148Info, new RecordItemIndex(4));
            repo.Open.Text1148.Click("233;3");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'C:\\Users\\bhavya.sm\\Downloads\\ue-20241025T061201Z-006 1\\ue\\encodingTestsBOM\\langFile_ASCII_DOS.txt' with focus on 'Open.Text1148'.", repo.Open.Text1148Info, new RecordItemIndex(5));
            repo.Open.Text1148.PressKeys("C:\\Users\\bhavya.sm\\Downloads\\ue-20241025T061201Z-006 1\\ue\\encodingTestsBOM\\langFile_ASCII_DOS.txt");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Open.ButtonOpen' at 40;19.", repo.Open.ButtonOpenInfo, new RecordItemIndex(6));
            repo.Open.ButtonOpen.Click("40;19");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+H' Press with focus on 'FormCUsersBhavyaSmDownloadsUe202.Element59648'.", repo.FormCUsersBhavyaSmDownloadsUe202.Element59648Info, new RecordItemIndex(7));
            Keyboard.PrepareFocus(repo.FormCUsersBhavyaSmDownloadsUe202.Element59648);
            Keyboard.Press(System.Windows.Forms.Keys.H | System.Windows.Forms.Keys.Control, 35, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(2930);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormCUsersBhavyaSmDownloadsUe202.Home' at 39;6.", repo.FormCUsersBhavyaSmDownloadsUe202.HomeInfo, new RecordItemIndex(8));
            repo.FormCUsersBhavyaSmDownloadsUe202.Home.Click("39;6");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Uedit64.Find' at 16;26.", repo.Uedit64.FindInfo, new RecordItemIndex(9));
            repo.Uedit64.Find.Click("16;26");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'HEXFindReplace'.", repo.HEXFindReplace.SelfInfo, new RecordItemIndex(10));
            Validate.Exists(repo.HEXFindReplace.SelfInfo);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}