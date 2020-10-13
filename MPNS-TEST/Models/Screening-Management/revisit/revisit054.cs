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

namespace MPNS_TEST.Models.Screening_Management.revisit
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The revisit054 recording.
    /// </summary>
    [TestModule("8f105917-e271-43e3-98b3-9517d3aa4c15", ModuleType.Recording, 1)]
    public partial class revisit054 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::MPNS_TEST.Repositorys.Infomation repository.
        /// </summary>
        public static global::MPNS_TEST.Repositorys.Infomation repo = global::MPNS_TEST.Repositorys.Infomation.Instance;

        static revisit054 instance = new revisit054();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public revisit054()
        {
            回访日期 = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static revisit054 Instance
        {
            get { return instance; }
        }

#region Variables

        string _回访日期;

        /// <summary>
        /// Gets or sets the value of variable 回访日期.
        /// </summary>
        [TestVariable("5a2108be-483a-4535-9afb-e9cea6d9c40e")]
        public string 回访日期
        {
            get { return _回访日期; }
            set { _回访日期 = value; }
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

            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Value' from item '筛查回访.新生儿回访日期' and assigning its value to variable '回访日期'.", repo.筛查回访.新生儿回访日期Info, new RecordItemIndex(0));
            回访日期 = repo.筛查回访.新生儿回访日期.Element.GetAttributeValueText("Value");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", 回访日期, new RecordItemIndex(1));
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '(null)' on item '筛查回访.新生儿回访日期'.", repo.筛查回访.新生儿回访日期Info, new RecordItemIndex(2));
            repo.筛查回访.新生儿回访日期.Element.SetAttributeValue("Value", null);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '筛查回访.新生儿信息保存' at Center.", repo.筛查回访.新生儿信息保存Info, new RecordItemIndex(3));
            repo.筛查回访.新生儿信息保存.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(4));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(5));
            Keyboard.Press("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '筛查回访.新生儿回访日期' at Center.", repo.筛查回访.新生儿回访日期Info, new RecordItemIndex(6));
            repo.筛查回访.新生儿回访日期.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '筛查回访.新生儿回访日期选择今天' at Center.", repo.筛查回访.新生儿回访日期选择今天Info, new RecordItemIndex(7));
            repo.筛查回访.新生儿回访日期选择今天.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
