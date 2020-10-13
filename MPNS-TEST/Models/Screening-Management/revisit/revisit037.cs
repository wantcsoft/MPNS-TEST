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
    ///The revisit037 recording.
    /// </summary>
    [TestModule("18e52d89-cb73-4257-b4c6-e49919302e3e", ModuleType.Recording, 1)]
    public partial class revisit037 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::MPNS_TEST.Repositorys.Infomation repository.
        /// </summary>
        public static global::MPNS_TEST.Repositorys.Infomation repo = global::MPNS_TEST.Repositorys.Infomation.Instance;

        static revisit037 instance = new revisit037();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public revisit037()
        {
            修养地址 = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static revisit037 Instance
        {
            get { return instance; }
        }

#region Variables

        string _修养地址;

        /// <summary>
        /// Gets or sets the value of variable 修养地址.
        /// </summary>
        [TestVariable("efe1d620-1ee0-4181-a052-1ffb32753e09")]
        public string 修养地址
        {
            get { return _修养地址; }
            set { _修养地址 = value; }
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

            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Value' from item '筛查回访.修养地址' and assigning its value to variable '修养地址'.", repo.筛查回访.修养地址Info, new RecordItemIndex(0));
            修养地址 = repo.筛查回访.修养地址.Element.GetAttributeValueText("Value");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", 修养地址, new RecordItemIndex(1));
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '(null)' on item '筛查回访.修养地址'.", repo.筛查回访.修养地址Info, new RecordItemIndex(2));
            repo.筛查回访.修养地址.Element.SetAttributeValue("Value", null);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '1234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890' with focus on '筛查回访.修养地址'.", repo.筛查回访.修养地址Info, new RecordItemIndex(3));
            repo.筛查回访.修养地址.PressKeys("1234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '筛查回访.分娩信息回访保存' at Center.", repo.筛查回访.分娩信息回访保存Info, new RecordItemIndex(4));
            repo.筛查回访.分娩信息回访保存.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(5));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(6));
            Keyboard.Press("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '(null)' on item '筛查回访.修养地址'.", repo.筛查回访.修养地址Info, new RecordItemIndex(7));
            repo.筛查回访.修养地址.Element.SetAttributeValue("Value", null);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '12345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901' with focus on '筛查回访.修养地址'.", repo.筛查回访.修养地址Info, new RecordItemIndex(8));
            repo.筛查回访.修养地址.PressKeys("12345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '筛查回访.分娩信息回访保存' at Center.", repo.筛查回访.分娩信息回访保存Info, new RecordItemIndex(9));
            repo.筛查回访.分娩信息回访保存.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(10));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(11));
            Keyboard.Press("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '(null)' on item '筛查回访.修养地址'.", repo.筛查回访.修养地址Info, new RecordItemIndex(12));
            repo.筛查回访.修养地址.Element.SetAttributeValue("Value", null);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '筛查回访.分娩信息回访保存' at Center.", repo.筛查回访.分娩信息回访保存Info, new RecordItemIndex(13));
            repo.筛查回访.分娩信息回访保存.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(14));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(15));
            Keyboard.Press("{Return}");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}