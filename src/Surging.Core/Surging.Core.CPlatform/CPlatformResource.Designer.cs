﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace SurgingEngine.Core.CPlatform {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class CPlatformResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal CPlatformResource() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SurgingEngine.Core.CPlatform.CPlatformResource", typeof(CPlatformResource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   重写当前线程的 CurrentUICulture 属性
        ///   重写当前线程的 CurrentUICulture 属性。
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
        ///   查找类似 &quot;{0}&quot;参数不能为空 的本地化字符串。
        /// </summary>
        internal static string ArgumentIsNullOrWhitespace {
            get {
                return ResourceManager.GetString("ArgumentIsNullOrWhitespace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 调用远程配置终结点发生错误： {0} - {1} 的本地化字符串。
        /// </summary>
        internal static string HttpException {
            get {
                return ResourceManager.GetString("HttpException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 {0} 不能以&apos;{1}&apos;结束 的本地化字符串。
        /// </summary>
        internal static string InvalidEndCharacter {
            get {
                return ResourceManager.GetString("InvalidEndCharacter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 {0} 不能以&apos;{1}&apos;开始 的本地化字符串。
        /// </summary>
        internal static string InvalidStartCharacter {
            get {
                return ResourceManager.GetString("InvalidStartCharacter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 不能解析JSON文本，行号 &apos;{0}&apos;: &apos;{1}&apos;. 的本地化字符串。
        /// </summary>
        internal static string JSONParseException {
            get {
                return ResourceManager.GetString("JSONParseException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 路由模板不能以&apos;/&apos;或&apos;〜&apos;字符开头。 的本地化字符串。
        /// </summary>
        internal static string TemplateRoute_InvalidRouteTemplate {
            get {
                return ResourceManager.GetString("TemplateRoute_InvalidRouteTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 路由模板中有一个不完整的参数。 检查每个“{”字符是否具有匹配的&apos;}&apos;字符。 的本地化字符串。
        /// </summary>
        internal static string TemplateRoute_MismatchedParameter {
            get {
                return ResourceManager.GetString("TemplateRoute_MismatchedParameter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 此&apos;{0}&apos; JSON 令牌不支持，路径&apos;{1}&apos;,行&apos;{2}&apos;,位置&apos;{3}&apos; 的本地化字符串。
        /// </summary>
        internal static string UnsupportedJSONToken {
            get {
                return ResourceManager.GetString("UnsupportedJSONToken", resourceCulture);
            }
        }
    }
}
