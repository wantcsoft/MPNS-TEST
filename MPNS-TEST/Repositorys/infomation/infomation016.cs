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
    /// The class representing the infomation016 element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("89d6ca43-4592-4f8f-90a8-b70106eb85d8")]
    public partial class infomation016 : RepoGenBaseFolder
    {
        static infomation016 instance = new infomation016();
        infomation016Folders.筛查信息AppFolder _筛查信息;

        /// <summary>
        /// Gets the singleton class instance representing the infomation016 element repository.
        /// </summary>
        [RepositoryFolder("89d6ca43-4592-4f8f-90a8-b70106eb85d8")]
        public static infomation016 Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public infomation016() 
            : base("infomation016", "/", null, 0, false, "89d6ca43-4592-4f8f-90a8-b70106eb85d8", ".\\RepositoryImages\\infomation01689d6ca43.rximgres")
        {
            _筛查信息 = new infomation016Folders.筛查信息AppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("89d6ca43-4592-4f8f-90a8-b70106eb85d8")]
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
        public virtual infomation016Folders.筛查信息AppFolder 筛查信息
        {
            get { return _筛查信息; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class infomation016Folders
    {
        /// <summary>
        /// The 筛查信息AppFolder folder.
        /// </summary>
        [RepositoryFolder("a7efca04-702f-438e-be5f-6859c2578b63")]
        public partial class 筛查信息AppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _筛查管理Info;
            RepoItemInfo _筛查信息Info;
            RepoItemInfo _人种Info;

            /// <summary>
            /// Creates a new 筛查信息  folder.
            /// </summary>
            public 筛查信息AppFolder(RepoGenBaseFolder parentFolder) :
                    base("筛查信息", "/dom[@domain='localhost:8016']", parentFolder, 30000, null, false, "a7efca04-702f-438e-be5f-6859c2578b63", "")
            {
                _筛查管理Info = new RepoItemInfo(this, "筛查管理", ".//ul[#'mainmenus']/?/?/a[@innertext='筛查管理']", 30000, null, "f6984859-bfde-4674-9e61-c1cb3a259c66");
                _筛查信息Info = new RepoItemInfo(this, "筛查信息", ".//ul[#'mainmenus']/?/?/div/ul/?/?/a[@innertext='筛查信息']", 30000, null, "e453ddd0-0b7e-4c8c-9961-38eb0cd79378");
                _人种Info = new RepoItemInfo(this, "人种", ".//select[#'RaceType']", 30000, null, "9312a1af-ecbf-4d7c-993e-0a57c49c9312");
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
            /// The 人种 item.
            /// </summary>
            [RepositoryItem("9312a1af-ecbf-4d7c-993e-0a57c49c9312")]
            public virtual Ranorex.SelectTag 人种
            {
                get
                {
                    return _人种Info.CreateAdapter<Ranorex.SelectTag>(true);
                }
            }

            /// <summary>
            /// The 人种 item info.
            /// </summary>
            [RepositoryItemInfo("9312a1af-ecbf-4d7c-993e-0a57c49c9312")]
            public virtual RepoItemInfo 人种Info
            {
                get
                {
                    return _人种Info;
                }
            }
        }

    }
#pragma warning restore 0436
}
