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
    ///The revisit023 recording.
    /// </summary>
    [TestModule("18d74005-2bfa-4505-9487-af174e03c0c2", ModuleType.Recording, 1)]
    public partial class revisit023 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::MPNS_TEST.Repositorys.Infomation repository.
        /// </summary>
        public static global::MPNS_TEST.Repositorys.Infomation repo = global::MPNS_TEST.Repositorys.Infomation.Instance;

        static revisit023 instance = new revisit023();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public revisit023()
        {
            黄疸状态 = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static revisit023 Instance
        {
            get { return instance; }
        }

#region Variables

        string _黄疸状态;

        /// <summary>
        /// Gets or sets the value of variable 黄疸状态.
        /// </summary>
        [TestVariable("430f9f5c-e661-4870-a4ef-32102b6a1aa3")]
        public string 黄疸状态
        {
            get { return _黄疸状态; }
            set { _黄疸状态 = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '页面头选择.筛查管理' at Center.", repo.页面头选择.筛查管理Info, new RecordItemIndex(0));
            repo.页面头选择.筛查管理.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '页面头选择.筛查回访' at Center.", repo.页面头选择.筛查回访Info, new RecordItemIndex(1));
            repo.页面头选择.筛查回访.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(2));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '冯孕妇007' on item '筛查回访.搜索框内容'.", repo.筛查回访.搜索框内容Info, new RecordItemIndex(3));
            repo.筛查回访.搜索框内容.Element.SetAttributeValue("Value", "冯孕妇007");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '筛查回访.点击搜索' at Center.", repo.筛查回访.点击搜索Info, new RecordItemIndex(4));
            repo.筛查回访.点击搜索.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(5));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '筛查回访.第一个回访对象' at Center.", repo.筛查回访.第一个回访对象Info, new RecordItemIndex(6));
            repo.筛查回访.第一个回访对象.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(7));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Checked' from item '筛查回访.黄疸' and assigning its value to variable '黄疸状态'.", repo.筛查回访.黄疸Info, new RecordItemIndex(8));
            黄疸状态 = repo.筛查回访.黄疸.Element.GetAttributeValueText("Checked");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", 黄疸状态, new RecordItemIndex(9));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
