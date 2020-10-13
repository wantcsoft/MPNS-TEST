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
    ///The revisit008 recording.
    /// </summary>
    [TestModule("dee51c08-dc32-481c-881a-ac7e443e3a01", ModuleType.Recording, 1)]
    public partial class revisit008 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::MPNS_TEST.Repositorys.Infomation repository.
        /// </summary>
        public static global::MPNS_TEST.Repositorys.Infomation repo = global::MPNS_TEST.Repositorys.Infomation.Instance;

        static revisit008 instance = new revisit008();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public revisit008()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static revisit008 Instance
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
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.筛查回访.回访显示截图, false, new RecordItemIndex(6));
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '孕妇' on item '筛查回访.搜索框内容'.", repo.筛查回访.搜索框内容Info, new RecordItemIndex(7));
            repo.筛查回访.搜索框内容.Element.SetAttributeValue("Value", "孕妇");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '筛查回访.点击搜索' at Center.", repo.筛查回访.点击搜索Info, new RecordItemIndex(8));
            repo.筛查回访.点击搜索.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(9));
            Delay.Duration(300, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.筛查回访.回访显示截图, false, new RecordItemIndex(10));
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to 'blh0001' on item '筛查回访.搜索框内容'.", repo.筛查回访.搜索框内容Info, new RecordItemIndex(11));
            repo.筛查回访.搜索框内容.Element.SetAttributeValue("Value", "blh0001");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '筛查回访.点击搜索' at Center.", repo.筛查回访.点击搜索Info, new RecordItemIndex(12));
            repo.筛查回访.点击搜索.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(13));
            Delay.Duration(300, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.筛查回访.回访显示截图, false, new RecordItemIndex(14));
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to 'MOZ00001' on item '筛查回访.搜索框内容'.", repo.筛查回访.搜索框内容Info, new RecordItemIndex(15));
            repo.筛查回访.搜索框内容.Element.SetAttributeValue("Value", "MOZ00001");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '筛查回访.点击搜索' at Center.", repo.筛查回访.点击搜索Info, new RecordItemIndex(16));
            repo.筛查回访.点击搜索.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(17));
            Delay.Duration(300, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.筛查回访.回访显示截图, false, new RecordItemIndex(18));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '页面头选择.筛查管理' at Center.", repo.页面头选择.筛查管理Info, new RecordItemIndex(19));
            repo.页面头选择.筛查管理.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '页面头选择.筛查信息' at Center.", repo.页面头选择.筛查信息Info, new RecordItemIndex(20));
            repo.页面头选择.筛查信息.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(21));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '冯孕妇007' on item '筛查信息查询.搜索框内容'.", repo.筛查信息查询.搜索框内容Info, new RecordItemIndex(22));
            repo.筛查信息查询.搜索框内容.Element.SetAttributeValue("Value", "冯孕妇007");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '筛查信息查询.点击搜索' at Center.", repo.筛查信息查询.点击搜索Info, new RecordItemIndex(23));
            repo.筛查信息查询.点击搜索.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(24));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '筛查信息查询.搜索到的第一人' at Center.", repo.筛查信息查询.搜索到的第一人Info, new RecordItemIndex(25));
            repo.筛查信息查询.搜索到的第一人.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}