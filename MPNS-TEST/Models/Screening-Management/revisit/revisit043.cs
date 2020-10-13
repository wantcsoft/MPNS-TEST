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
    ///The revisit043 recording.
    /// </summary>
    [TestModule("020ff7fb-d208-4101-9f55-0fd82d7a1305", ModuleType.Recording, 1)]
    public partial class revisit043 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::MPNS_TEST.Repositorys.Infomation repository.
        /// </summary>
        public static global::MPNS_TEST.Repositorys.Infomation repo = global::MPNS_TEST.Repositorys.Infomation.Instance;

        static revisit043 instance = new revisit043();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public revisit043()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static revisit043 Instance
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

            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '(null)' on item '筛查回访.胎儿体重1'.", repo.筛查回访.胎儿体重1Info, new RecordItemIndex(0));
            repo.筛查回访.胎儿体重1.Element.SetAttributeValue("Value", null);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '(null)' on item '筛查回访.胎儿体重2'.", repo.筛查回访.胎儿体重2Info, new RecordItemIndex(1));
            repo.筛查回访.胎儿体重2.Element.SetAttributeValue("Value", null);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '99999' with focus on '筛查回访.胎儿体重1'.", repo.筛查回访.胎儿体重1Info, new RecordItemIndex(2));
            repo.筛查回访.胎儿体重1.PressKeys("99999");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '99999' with focus on '筛查回访.胎儿体重2'.", repo.筛查回访.胎儿体重2Info, new RecordItemIndex(3));
            repo.筛查回访.胎儿体重2.PressKeys("99999");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '筛查回访.新生儿信息保存' at Center.", repo.筛查回访.新生儿信息保存Info, new RecordItemIndex(4));
            repo.筛查回访.新生儿信息保存.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(5));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(6));
            Keyboard.Press("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '(null)' on item '筛查回访.胎儿体重1'.", repo.筛查回访.胎儿体重1Info, new RecordItemIndex(7));
            repo.筛查回访.胎儿体重1.Element.SetAttributeValue("Value", null);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '(null)' on item '筛查回访.胎儿体重2'.", repo.筛查回访.胎儿体重2Info, new RecordItemIndex(8));
            repo.筛查回访.胎儿体重2.Element.SetAttributeValue("Value", null);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '-9999' with focus on '筛查回访.胎儿体重1'.", repo.筛查回访.胎儿体重1Info, new RecordItemIndex(9));
            repo.筛查回访.胎儿体重1.PressKeys("-9999");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '-9999' with focus on '筛查回访.胎儿体重2'.", repo.筛查回访.胎儿体重2Info, new RecordItemIndex(10));
            repo.筛查回访.胎儿体重2.PressKeys("-9999");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '筛查回访.新生儿信息保存' at Center.", repo.筛查回访.新生儿信息保存Info, new RecordItemIndex(11));
            repo.筛查回访.新生儿信息保存.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(12));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(13));
            Keyboard.Press("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '(null)' on item '筛查回访.胎儿体重1'.", repo.筛查回访.胎儿体重1Info, new RecordItemIndex(14));
            repo.筛查回访.胎儿体重1.Element.SetAttributeValue("Value", null);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '(null)' on item '筛查回访.胎儿体重2'.", repo.筛查回访.胎儿体重2Info, new RecordItemIndex(15));
            repo.筛查回访.胎儿体重2.Element.SetAttributeValue("Value", null);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '筛查回访.新生儿信息保存' at Center.", repo.筛查回访.新生儿信息保存Info, new RecordItemIndex(16));
            repo.筛查回访.新生儿信息保存.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(17));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(18));
            Keyboard.Press("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '(null)' on item '筛查回访.胎儿体重1'.", repo.筛查回访.胎儿体重1Info, new RecordItemIndex(19));
            repo.筛查回访.胎儿体重1.Element.SetAttributeValue("Value", null);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '(null)' on item '筛查回访.胎儿体重2'.", repo.筛查回访.胎儿体重2Info, new RecordItemIndex(20));
            repo.筛查回访.胎儿体重2.Element.SetAttributeValue("Value", null);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '1.5' with focus on '筛查回访.胎儿体重1'.", repo.筛查回访.胎儿体重1Info, new RecordItemIndex(21));
            repo.筛查回访.胎儿体重1.PressKeys("1.5");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '1.5' with focus on '筛查回访.胎儿体重2'.", repo.筛查回访.胎儿体重2Info, new RecordItemIndex(22));
            repo.筛查回访.胎儿体重2.PressKeys("1.5");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '筛查回访.新生儿信息保存' at Center.", repo.筛查回访.新生儿信息保存Info, new RecordItemIndex(23));
            repo.筛查回访.新生儿信息保存.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(24));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(25));
            Keyboard.Press("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '(null)' on item '筛查回访.胎儿体重1'.", repo.筛查回访.胎儿体重1Info, new RecordItemIndex(26));
            repo.筛查回访.胎儿体重1.Element.SetAttributeValue("Value", null);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '(null)' on item '筛查回访.胎儿体重2'.", repo.筛查回访.胎儿体重2Info, new RecordItemIndex(27));
            repo.筛查回访.胎儿体重2.Element.SetAttributeValue("Value", null);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'a' with focus on '筛查回访.胎儿体重1'.", repo.筛查回访.胎儿体重1Info, new RecordItemIndex(28));
            repo.筛查回访.胎儿体重1.PressKeys("a");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'a' with focus on '筛查回访.胎儿体重2'.", repo.筛查回访.胎儿体重2Info, new RecordItemIndex(29));
            repo.筛查回访.胎儿体重2.PressKeys("a");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '筛查回访.新生儿信息保存' at Center.", repo.筛查回访.新生儿信息保存Info, new RecordItemIndex(30));
            repo.筛查回访.新生儿信息保存.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(31));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(32));
            Keyboard.Press("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '(null)' on item '筛查回访.胎儿体重1'.", repo.筛查回访.胎儿体重1Info, new RecordItemIndex(33));
            repo.筛查回访.胎儿体重1.Element.SetAttributeValue("Value", null);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '(null)' on item '筛查回访.胎儿体重2'.", repo.筛查回访.胎儿体重2Info, new RecordItemIndex(34));
            repo.筛查回访.胎儿体重2.Element.SetAttributeValue("Value", null);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '-10000' with focus on '筛查回访.胎儿体重1'.", repo.筛查回访.胎儿体重1Info, new RecordItemIndex(35));
            repo.筛查回访.胎儿体重1.PressKeys("-10000");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '100000' with focus on '筛查回访.胎儿体重2'.", repo.筛查回访.胎儿体重2Info, new RecordItemIndex(36));
            repo.筛查回访.胎儿体重2.PressKeys("100000");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '筛查回访.新生儿信息保存' at Center.", repo.筛查回访.新生儿信息保存Info, new RecordItemIndex(37));
            repo.筛查回访.新生儿信息保存.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(38));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(39));
            Keyboard.Press("{Return}");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
