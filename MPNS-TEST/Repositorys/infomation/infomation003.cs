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
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace MPNS_TEST.Repositorys.infomation
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the infomation003 element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("548b123e-b94e-444b-89ef-c9abe241d413")]
    public partial class infomation003 : RepoGenBaseFolder
    {
        static infomation003 instance = new infomation003();
        infomation003Folders.筛查信息AppFolder _筛查信息;

        /// <summary>
        /// Gets the singleton class instance representing the infomation003 element repository.
        /// </summary>
        [RepositoryFolder("548b123e-b94e-444b-89ef-c9abe241d413")]
        public static infomation003 Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public infomation003() 
            : base("infomation003", "/", null, 0, false, "548b123e-b94e-444b-89ef-c9abe241d413", ".\\RepositoryImages\\infomation003548b123e.rximgres")
        {
            _筛查信息 = new infomation003Folders.筛查信息AppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("548b123e-b94e-444b-89ef-c9abe241d413")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The 筛查信息 folder.
        /// </summary>
        [RepositoryFolder("a7efca04-702f-438e-be5f-6859c2578b63")]
        public virtual infomation003Folders.筛查信息AppFolder 筛查信息
        {
            get { return _筛查信息; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class infomation003Folders
    {
        /// <summary>
        /// The 筛查信息AppFolder folder.
        /// </summary>
        [RepositoryFolder("a7efca04-702f-438e-be5f-6859c2578b63")]
        public partial class 筛查信息AppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _筛查管理Info;
            RepoItemInfo _筛查信息Info;
            RepoItemInfo _登记日期Info;
            RepoItemInfo _保存按钮Info;
            RepoItemInfo _保存失败确定Info;

            /// <summary>
            /// Creates a new 筛查信息  folder.
            /// </summary>
            public 筛查信息AppFolder(RepoGenBaseFolder parentFolder) :
                    base("筛查信息", "/dom[@domain='localhost:8016']", parentFolder, 30000, null, false, "a7efca04-702f-438e-be5f-6859c2578b63", "")
            {
                _筛查管理Info = new RepoItemInfo(this, "筛查管理", ".//ul[#'mainmenus']/?/?/a[@innertext='筛查管理']", 30000, null, "f6984859-bfde-4674-9e61-c1cb3a259c66");
                _筛查信息Info = new RepoItemInfo(this, "筛查信息", ".//ul[#'mainmenus']/?/?/div/ul/?/?/a[@innertext='筛查信息']", 30000, null, "e453ddd0-0b7e-4c8c-9961-38eb0cd79378");
                _登记日期Info = new RepoItemInfo(this, "登记日期", ".//input[#'RegisterDate']", 30000, null, "33b2596d-a7b2-4220-96a3-a1c4828d28fb");
                _保存按钮Info = new RepoItemInfo(this, "保存按钮", ".//input[#'butSavePregnant']", 30000, null, "14b19b0d-0aaf-464c-954c-cb16168186d7");
                _保存失败确定Info = new RepoItemInfo(this, "保存失败确定", ".//div[#'xubox_layer3']//a[@innertext='确定']", 30000, null, "667c4daa-cae9-4f35-b552-517de4926614");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("a7efca04-702f-438e-be5f-6859c2578b63")]
            public virtual Ranorex.WebDocument Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WebDocument>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("a7efca04-702f-438e-be5f-6859c2578b63")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The 筛查管理 item.
            /// </summary>
            [RepositoryItem("f6984859-bfde-4674-9e61-c1cb3a259c66")]
            public virtual Ranorex.ATag 筛查管理
            {
                get
                {
                    return _筛查管理Info.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The 筛查管理 item info.
            /// </summary>
            [RepositoryItemInfo("f6984859-bfde-4674-9e61-c1cb3a259c66")]
            public virtual RepoItemInfo 筛查管理Info
            {
                get
                {
                    return _筛查管理Info;
                }
            }

            /// <summary>
            /// The 筛查信息 item.
            /// </summary>
            [RepositoryItem("e453ddd0-0b7e-4c8c-9961-38eb0cd79378")]
            public virtual Ranorex.ATag 筛查信息
            {
                get
                {
                    return _筛查信息Info.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The 筛查信息 item info.
            /// </summary>
            [RepositoryItemInfo("e453ddd0-0b7e-4c8c-9961-38eb0cd79378")]
            public virtual RepoItemInfo 筛查信息Info
            {
                get
                {
                    return _筛查信息Info;
                }
            }

            /// <summary>
            /// The 登记日期 item.
            /// </summary>
            [RepositoryItem("33b2596d-a7b2-4220-96a3-a1c4828d28fb")]
            public virtual Ranorex.InputTag 登记日期
            {
                get
                {
                    return _登记日期Info.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The 登记日期 item info.
            /// </summary>
            [RepositoryItemInfo("33b2596d-a7b2-4220-96a3-a1c4828d28fb")]
            public virtual RepoItemInfo 登记日期Info
            {
                get
                {
                    return _登记日期Info;
                }
            }

            /// <summary>
            /// The 保存按钮 item.
            /// </summary>
            [RepositoryItem("14b19b0d-0aaf-464c-954c-cb16168186d7")]
            public virtual Ranorex.InputTag 保存按钮
            {
                get
                {
                    return _保存按钮Info.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The 保存按钮 item info.
            /// </summary>
            [RepositoryItemInfo("14b19b0d-0aaf-464c-954c-cb16168186d7")]
            public virtual RepoItemInfo 保存按钮Info
            {
                get
                {
                    return _保存按钮Info;
                }
            }

            /// <summary>
            /// The 保存失败确定 item.
            /// </summary>
            [RepositoryItem("667c4daa-cae9-4f35-b552-517de4926614")]
            public virtual Ranorex.ATag 保存失败确定
            {
                get
                {
                    return _保存失败确定Info.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The 保存失败确定 item info.
            /// </summary>
            [RepositoryItemInfo("667c4daa-cae9-4f35-b552-517de4926614")]
            public virtual RepoItemInfo 保存失败确定Info
            {
                get
                {
                    return _保存失败确定Info;
                }
            }
        }

    }
#pragma warning restore 0436
}