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
    ///The revisit005 recording.
    /// </summary>
    [TestModule("e0c1dd82-9cbe-401a-80a2-725de71923b8", ModuleType.Recording, 1)]
    public partial class revisit005 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::MPNS_TEST.Repositorys.Infomation repository.
        /// </summary>
        public static global::MPNS_TEST.Repositorys.Infomation repo = global::MPNS_TEST.Repositorys.Infomation.Instance;

        static revisit005 instance = new revisit005();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public revisit005()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static revisit005 Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '筛查回访.新生儿信息' at Center.", repo.筛查回访.新生儿信息Info, new RecordItemIndex(0));
            repo.筛查回访.新生儿信息.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '筛查回访.分娩日' at Center.", repo.筛查回访.分娩日Info, new RecordItemIndex(1));
            repo.筛查回访.分娩日.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '筛查回访.分娩日期选择今天' at Center.", repo.筛查回访.分娩日期选择今天Info, new RecordItemIndex(2));
            repo.筛查回访.分娩日期选择今天.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '1' on item '筛查回访.婴儿性别'.", repo.筛查回访.婴儿性别Info, new RecordItemIndex(3));
            repo.筛查回访.婴儿性别.Element.SetAttributeValue("TagValue", "1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '5' on item '筛查回访.胎儿体重1'.", repo.筛查回访.胎儿体重1Info, new RecordItemIndex(4));
            repo.筛查回访.胎儿体重1.Element.SetAttributeValue("Value", "5");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '6' on item '筛查回访.胎儿体重2'.", repo.筛查回访.胎儿体重2Info, new RecordItemIndex(5));
            repo.筛查回访.胎儿体重2.Element.SetAttributeValue("Value", "6");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '500' on item '筛查回访.胎儿体长1'.", repo.筛查回访.胎儿体长1Info, new RecordItemIndex(6));
            repo.筛查回访.胎儿体长1.Element.SetAttributeValue("Value", "500");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '600' on item '筛查回访.胎儿体长2'.", repo.筛查回访.胎儿体长2Info, new RecordItemIndex(7));
            repo.筛查回访.胎儿体长2.Element.SetAttributeValue("Value", "600");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '300' on item '筛查回访.胎儿头围1'.", repo.筛查回访.胎儿头围1Info, new RecordItemIndex(8));
            repo.筛查回访.胎儿头围1.Element.SetAttributeValue("Value", "300");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '350' on item '筛查回访.胎儿头围2'.", repo.筛查回访.胎儿头围2Info, new RecordItemIndex(9));
            repo.筛查回访.胎儿头围2.Element.SetAttributeValue("Value", "350");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '5' on item '筛查回访.Apgar评分'.", repo.筛查回访.Apgar评分Info, new RecordItemIndex(10));
            repo.筛查回访.Apgar评分.Element.SetAttributeValue("Value", "5");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '1' on item '筛查回访.听力测试'.", repo.筛查回访.听力测试Info, new RecordItemIndex(11));
            repo.筛查回访.听力测试.Element.SetAttributeValue("TagValue", "1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '1' on item '筛查回访.N42天'.", repo.筛查回访.N42天Info, new RecordItemIndex(12));
            repo.筛查回访.N42天.Element.SetAttributeValue("TagValue", "1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '1' on item '筛查回访.儿童筛查中心'.", repo.筛查回访.儿童筛查中心Info, new RecordItemIndex(13));
            repo.筛查回访.儿童筛查中心.Element.SetAttributeValue("TagValue", "1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '1' on item '筛查回访.肌张力'.", repo.筛查回访.肌张力Info, new RecordItemIndex(14));
            repo.筛查回访.肌张力.Element.SetAttributeValue("TagValue", "1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '1' on item '筛查回访.心肺情况'.", repo.筛查回访.心肺情况Info, new RecordItemIndex(15));
            repo.筛查回访.心肺情况.Element.SetAttributeValue("TagValue", "1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '1' on item '筛查回访.关节曲度'.", repo.筛查回访.关节曲度Info, new RecordItemIndex(16));
            repo.筛查回访.关节曲度.Element.SetAttributeValue("TagValue", "1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '李医生' on item '筛查回访.新生儿回访人'.", repo.筛查回访.新生儿回访人Info, new RecordItemIndex(17));
            repo.筛查回访.新生儿回访人.Element.SetAttributeValue("Value", "李医生");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '新生儿信息' on item '筛查回访.新生儿信息备注'.", repo.筛查回访.新生儿信息备注Info, new RecordItemIndex(18));
            repo.筛查回访.新生儿信息备注.Element.SetAttributeValue("TagValue", "新生儿信息");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '筛查回访.新生儿回访日期' at Center.", repo.筛查回访.新生儿回访日期Info, new RecordItemIndex(19));
            repo.筛查回访.新生儿回访日期.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '筛查回访.新生儿回访日期选择今天' at Center.", repo.筛查回访.新生儿回访日期选择今天Info, new RecordItemIndex(20));
            repo.筛查回访.新生儿回访日期选择今天.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '筛查回访.新生儿信息保存' at Center.", repo.筛查回访.新生儿信息保存Info, new RecordItemIndex(21));
            repo.筛查回访.新生儿信息保存.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}