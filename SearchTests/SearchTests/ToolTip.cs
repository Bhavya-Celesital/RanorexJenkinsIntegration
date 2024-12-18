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
    ///The ToolTip recording.
    /// </summary>
    [TestModule("641cf8d6-0016-4936-88c4-a2b5ef25a3d3", ModuleType.Recording, 1)]
    public partial class ToolTip : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SearchTestsRepository repository.
        /// </summary>
        public static SearchTestsRepository repo = SearchTestsRepository.Instance;

        static ToolTip instance = new ToolTip();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ToolTip()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ToolTip Instance
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

            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'HEXFindReplace.TabPageList1001'.", repo.HEXFindReplace.TabPageList1001Info, new RecordItemIndex(0));
            Validate.Exists(repo.HEXFindReplace.TabPageList1001Info);
            Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'HEXFindReplace.Button' at 11;13.", repo.HEXFindReplace.ButtonInfo, new RecordItemIndex(1));
            //repo.HEXFindReplace.Button.MoveTo("11;13");
            //Delay.Milliseconds(0);
            
            CaputureToolTip();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
