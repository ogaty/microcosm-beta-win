﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace microcosm.Properties {
    using System;
    
    
    /// <summary>
    ///   ローカライズされた文字列などを検索するための、厳密に型指定されたリソース クラスです。
    /// </summary>
    // このクラスは StronglyTypedResourceBuilder クラスが ResGen
    // または Visual Studio のようなツールを使用して自動生成されました。
    // メンバーを追加または削除するには、.ResX ファイルを編集して、/str オプションと共に
    // ResGen を実行し直すか、または VS プロジェクトをビルドし直します。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   このクラスで使用されているキャッシュされた ResourceManager インスタンスを返します。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("microcosm.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   厳密に型指定されたこのリソース クラスを使用して、すべての検索リソースに対し、
        ///   現在のスレッドの CurrentUICulture プロパティをオーバーライドします。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   データが取得できませんでした。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ERROR_ERROR_RESPONSE {
            get {
                return ResourceManager.GetString("ERROR_ERROR_RESPONSE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   対象のファイルが存在します。 に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string ERROR_FILE_EXIST {
            get {
                return ResourceManager.GetString("ERROR_FILE_EXIST", resourceCulture);
            }
        }
        
        /// <summary>
        ///   GMT(世界標準) に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string TIMEZONE_GMT_STR_LONG {
            get {
                return ResourceManager.GetString("TIMEZONE_GMT_STR_LONG", resourceCulture);
            }
        }
        
        /// <summary>
        ///   GMT に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string TIMEZONE_GMT_STR_SHORT {
            get {
                return ResourceManager.GetString("TIMEZONE_GMT_STR_SHORT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   JST(日本標準) に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string TIMEZONE_JST_STR_LONG {
            get {
                return ResourceManager.GetString("TIMEZONE_JST_STR_LONG", resourceCulture);
            }
        }
        
        /// <summary>
        ///   JST に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string TIMEZONE_JST_STR_SHORT {
            get {
                return ResourceManager.GetString("TIMEZONE_JST_STR_SHORT", resourceCulture);
            }
        }
    }
}
