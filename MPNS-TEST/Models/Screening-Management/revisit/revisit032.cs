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
    ///The revisit032 recording.
    /// </summary>
    [TestModule("b9d5403e-361b-4670-833a-b2322a35bd0a", ModuleType.Recording, 1)]
    public partial class revisit032 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::MPNS_TEST.Repositorys.Infomation repository.
        /// </summary>
        public static global::MPNS_TEST.Repositorys.Infomation repo = global::MPNS_TEST.Repositorys.Infomation.Instance;

        static revisit032 instance = new revisit032();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public revisit032()
        {
            备注 = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static revisit032 Instance
        {
            get { return instance; }
        }

#region Variables

        string _备注;

        /// <summary>
        /// Gets or sets the value of variable 备注.
        /// </summary>
        [TestVariable("6bd82bc4-3cea-442f-8d72-daacab4fcb9a")]
        public string 备注
        {
            get { return _备注; }
            set { _备注 = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '筛查回访.回访日期' at Center.", repo.筛查回访.回访日期Info, new RecordItemIndex(0));
            repo.筛查回访.回访日期.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '筛查回访.回访日期选择今天' at Center.", repo.筛查回访.回访日期选择今天Info, new RecordItemIndex(1));
            repo.筛查回访.回访日期选择今天.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Value' from item '筛查回访.备注信息' and assigning its value to variable '备注'.", repo.筛查回访.备注信息Info, new RecordItemIndex(2));
            备注 = repo.筛查回访.备注信息.Element.GetAttributeValueText("Value");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", 备注, new RecordItemIndex(3));
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '01234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789' with focus on '筛查回访.备注信息'.", repo.筛查回访.备注信息Info, new RecordItemIndex(4));
            repo.筛查回访.备注信息.PressKeys("01234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '01234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789' with focus on '筛查回访.备注信息'.", repo.筛查回访.备注信息Info, new RecordItemIndex(5));
            repo.筛查回访.备注信息.PressKeys("01234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '01234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789' with focus on '筛查回访.备注信息'.", repo.筛查回访.备注信息Info, new RecordItemIndex(6));
            repo.筛查回访.备注信息.PressKeys("01234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '01234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789' with focus on '筛查回访.备注信息'.", repo.筛查回访.备注信息Info, new RecordItemIndex(7));
            repo.筛查回访.备注信息.PressKeys("01234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '01234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789' with focus on '筛查回访.备注信息'.", repo.筛查回访.备注信息Info, new RecordItemIndex(8));
            repo.筛查回访.备注信息.PressKeys("01234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '012345678901234567890123' with focus on '筛查回访.备注信息'.", repo.筛查回访.备注信息Info, new RecordItemIndex(9));
            repo.筛查回访.备注信息.PressKeys("012345678901234567890123");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '筛查回访.保存' at Center.", repo.筛查回访.保存Info, new RecordItemIndex(10));
            repo.筛查回访.保存.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(11));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(12));
            Keyboard.Press("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '(null)' on item '筛查回访.备注信息'.", repo.筛查回访.备注信息Info, new RecordItemIndex(13));
            repo.筛查回访.备注信息.Element.SetAttributeValue("TagValue", null);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '01234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789' with focus on '筛查回访.备注信息'.", repo.筛查回访.备注信息Info, new RecordItemIndex(14));
            repo.筛查回访.备注信息.PressKeys("01234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '01234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789' with focus on '筛查回访.备注信息'.", repo.筛查回访.备注信息Info, new RecordItemIndex(15));
            repo.筛查回访.备注信息.PressKeys("01234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '01234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789' with focus on '筛查回访.备注信息'.", repo.筛查回访.备注信息Info, new RecordItemIndex(16));
            repo.筛查回访.备注信息.PressKeys("01234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '01234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789' with focus on '筛查回访.备注信息'.", repo.筛查回访.备注信息Info, new RecordItemIndex(17));
            repo.筛查回访.备注信息.PressKeys("01234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '01234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789' with focus on '筛查回访.备注信息'.", repo.筛查回访.备注信息Info, new RecordItemIndex(18));
            repo.筛查回访.备注信息.PressKeys("01234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '0123456789012345678901234' with focus on '筛查回访.备注信息'.", repo.筛查回访.备注信息Info, new RecordItemIndex(19));
            repo.筛查回访.备注信息.PressKeys("0123456789012345678901234");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '筛查回访.保存' at Center.", repo.筛查回访.保存Info, new RecordItemIndex(20));
            repo.筛查回访.保存.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(21));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(22));
            Keyboard.Press("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '(null)' on item '筛查回访.备注信息'.", repo.筛查回访.备注信息Info, new RecordItemIndex(23));
            repo.筛查回访.备注信息.Element.SetAttributeValue("TagValue", null);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '筛查回访.保存' at Center.", repo.筛查回访.保存Info, new RecordItemIndex(24));
            repo.筛查回访.保存.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(25));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(26));
            Keyboard.Press("{Return}");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}