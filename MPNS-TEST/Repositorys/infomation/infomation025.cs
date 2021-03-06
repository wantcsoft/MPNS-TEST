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
    /// The class representing the infomation025 element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("4554c9ef-17bf-4c50-b658-cad65e01d86e")]
    public partial class infomation025 : RepoGenBaseFolder
    {
        static infomation025 instance = new infomation025();
        infomation025Folders.维护AppFolder _维护;

        /// <summary>
        /// Gets the singleton class instance representing the infomation025 element repository.
        /// </summary>
        [RepositoryFolder("4554c9ef-17bf-4c50-b658-cad65e01d86e")]
        public static infomation025 Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public infomation025() 
            : base("infomation025", "/", null, 0, false, "4554c9ef-17bf-4c50-b658-cad65e01d86e", ".\\RepositoryImages\\infomation0254554c9ef.rximgres")
        {
            _维护 = new infomation025Folders.维护AppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("4554c9ef-17bf-4c50-b658-cad65e01d86e")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The 维护 folder.
        /// </summary>
        [RepositoryFolder("fa434f56-77c5-493d-9268-222427114ccc")]
        public virtual infomation025Folders.维护AppFolder 维护
        {
            get { return _维护; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class infomation025Folders
    {
        /// <summary>
        /// The 维护AppFolder folder.
        /// </summary>
        [RepositoryFolder("fa434f56-77c5-493d-9268-222427114ccc")]
        public partial class 维护AppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _维护管理Info;
            RepoItemInfo _参数信息Info;
            RepoItemInfo _数据来源Info;

            /// <summary>
            /// Creates a new 维护  folder.
            /// </summary>
            public 维护AppFolder(RepoGenBaseFolder parentFolder) :
                    base("维护", "/dom[@domain='localhost:8016']", parentFolder, 30000, null, false, "fa434f56-77c5-493d-9268-222427114ccc", "")
            {
                _维护管理Info = new RepoItemInfo(this, "维护管理", ".//ul[#'mainmenus']/?/?/a[@innertext='维护管理']", 30000, null, "af14041f-7766-4a37-a935-58a8d72444fc");
                _参数信息Info = new RepoItemInfo(this, "参数信息", ".//ul[#'mainmenus']/li[5]/div/ul/?/?/a[@innertext='参数信息']", 30000, null, "92af5527-5c64-4f52-9272-62cc937457ed");
                _数据来源Info = new RepoItemInfo(this, "数据来源", ".//div[#'leftcontent']//a[@innertext='数据来源']", 30000, null, "9819e926-3c75-41dd-8dd0-05c01e7d9e08");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("fa434f56-77c5-493d-9268-222427114ccc")]
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
            [RepositoryItemInfo("fa434f56-77c5-493d-9268-222427114ccc")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The 维护管理 item.
            /// </summary>
            [RepositoryItem("af14041f-7766-4a37-a935-58a8d72444fc")]
            public virtual Ranorex.ATag 维护管理
            {
                get
                {
                    return _维护管理Info.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The 维护管理 item info.
            /// </summary>
            [RepositoryItemInfo("af14041f-7766-4a37-a935-58a8d72444fc")]
            public virtual RepoItemInfo 维护管理Info
            {
                get
                {
                    return _维护管理Info;
                }
            }

            /// <summary>
            /// The 参数信息 item.
            /// </summary>
            [RepositoryItem("92af5527-5c64-4f52-9272-62cc937457ed")]
            public virtual Ranorex.ATag 参数信息
            {
                get
                {
                    return _参数信息Info.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The 参数信息 item info.
            /// </summary>
            [RepositoryItemInfo("92af5527-5c64-4f52-9272-62cc937457ed")]
            public virtual RepoItemInfo 参数信息Info
            {
                get
                {
                    return _参数信息Info;
                }
            }

            /// <summary>
            /// The 数据来源 item.
            /// </summary>
            [RepositoryItem("9819e926-3c75-41dd-8dd0-05c01e7d9e08")]
            public virtual Ranorex.ATag 数据来源
            {
                get
                {
                    return _数据来源Info.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The 数据来源 item info.
            /// </summary>
            [RepositoryItemInfo("9819e926-3c75-41dd-8dd0-05c01e7d9e08")]
            public virtual RepoItemInfo 数据来源Info
            {
                get
                {
                    return _数据来源Info;
                }
            }
        }

    }
#pragma warning restore 0436
}
