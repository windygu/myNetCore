#pragma checksum "F:\0_Study\1_Core\KAJ.Core\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67a584a7148a5f79dfb5ab777d5273880bc3d780"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "F:\0_Study\1_Core\KAJ.Core\Views\_ViewImports.cshtml"
using KAJ.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\0_Study\1_Core\KAJ.Core\Views\_ViewImports.cshtml"
using KAJ.Core.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67a584a7148a5f79dfb5ab777d5273880bc3d780", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b183ca7a37c5b3a8c34c3cfe155ba8f395e45405", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("layui-layout-body"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("border: 0px;width: 100%;height:100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\0_Study\1_Core\KAJ.Core\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "后台大布局";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67a584a7148a5f79dfb5ab777d5273880bc3d7804050", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, maximum-scale=1\">\r\n    <title>layout 后台大布局 - Layui</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67a584a7148a5f79dfb5ab777d5273880bc3d7805188", async() => {
                WriteLiteral(@"
    <div class=""layui-layout layui-layout-admin"" style=""border: 0px;width: 100%;height:100%"">
        <div class=""layui-header"">
            <div class=""layui-logo"">KajAdmin</div>
            <!-- 头部区域（可配合layui已有的水平导航） -->
            <ul class=""layui-nav layui-layout-left"">
                <li class=""layui-nav-item""><a");
                BeginWriteAttribute("href", " href=\"", 647, "\"", 654, 0);
                EndWriteAttribute();
                WriteLiteral(">控制台</a></li>\r\n                <li class=\"layui-nav-item\"><a");
                BeginWriteAttribute("href", " href=\"", 715, "\"", 722, 0);
                EndWriteAttribute();
                WriteLiteral(">商品管理</a></li>\r\n                <li class=\"layui-nav-item\"><a");
                BeginWriteAttribute("href", " href=\"", 784, "\"", 791, 0);
                EndWriteAttribute();
                WriteLiteral(">用户</a></li>\r\n                <li class=\"layui-nav-item\">\r\n                    <a href=\"javascript:;\">云市场</a>\r\n                    <dl class=\"layui-nav-child\">\r\n                        <dd><a");
                BeginWriteAttribute("href", " href=\"", 983, "\"", 990, 0);
                EndWriteAttribute();
                WriteLiteral(">智慧城市</a></dd>\r\n                        <dd><a");
                BeginWriteAttribute("href", " href=\"", 1037, "\"", 1044, 0);
                EndWriteAttribute();
                WriteLiteral(">智慧交通</a></dd>\r\n                        <dd><a");
                BeginWriteAttribute("href", " href=\"", 1091, "\"", 1098, 0);
                EndWriteAttribute();
                WriteLiteral(">BIM设计</a></dd>\r\n                    </dl>\r\n                </li>\r\n            </ul>\r\n            <ul class=\"layui-nav layui-layout-right\">\r\n                <li class=\"layui-nav-item\"><a");
                BeginWriteAttribute("href", " href=\"", 1285, "\"", 1292, 0);
                EndWriteAttribute();
                WriteLiteral(@">消息<span class=""layui-badge"">9</span></a></li>
                <li class=""layui-nav-item"">
                    <a href=""javascript:;"">
                        <img src=""http://t.cn/RCzsdCq"" class=""layui-nav-img""> KAJ
                    </a>
                    <dl class=""layui-nav-child"">
                        <dd><a");
                BeginWriteAttribute("href", " href=\"", 1620, "\"", 1627, 0);
                EndWriteAttribute();
                WriteLiteral(">基本资料</a></dd>\r\n                        <dd><a");
                BeginWriteAttribute("href", " href=\"", 1674, "\"", 1681, 0);
                EndWriteAttribute();
                WriteLiteral(">安全设置</a></dd>\r\n                    </dl>\r\n                </li>\r\n                <li class=\"layui-nav-item\"><a");
                BeginWriteAttribute("href", " href=\"", 1793, "\"", 1800, 0);
                EndWriteAttribute();
                WriteLiteral(@">退了</a></li>
            </ul>
        </div>

        <div class=""layui-side layui-bg-black"">
            <div class=""layui-side-scroll"">
                <!-- 左侧导航区域（可配合layui已有的垂直导航） -->
                <ul class=""layui-nav layui-nav-tree"" lay-filter=""test"">
                    <li class=""layui-nav-item layui-nav-itemed"">
                        <a href=""javascript:;"">开发模式</a>
                        <dl class=""layui-nav-child"">
                            <dd><a href=""javascript:void(0);"" onClick=""iframeChangeAutoForm();"">表单设计</a></dd>
                            <dd><a href=""javascript:void(0);"" onClick=""iframeChangeAutoList();"">列表设计</a></dd>
                            <dd><a href=""javascript:void(0);"" onClick=""iframeChangeDemoList();"">列表Demo</a></dd>
                            <dd><a href=""javascript:;"">流程设计</a></dd>
                        </dl>
                    </li>
                    <li class=""layui-nav-item"">
                        <a href=""javascript:;"">解决方案</a>
          ");
                WriteLiteral(@"              <dl class=""layui-nav-child"">
                            <dd><a href=""javascript:void(0);"" onClick=""iframeChange();"">组织管理</a></dd>
                            <dd><a href=""javascript:void(0);"" onClick=""iframeChangeForm();"">组织添加</a></dd>
                            <dd><a href=""javascript:void(0);"" onClick=""iframeChangeList();"">组织列表</a></dd>
                        </dl>
                    </li>
                    <li class=""layui-nav-item"">
                        <a href=""javascript:;"">Vue市场</a>
                        <dl class=""layui-nav-child"">
                            <dd><a href=""javascript:void(0);"" onClick=""iframeChangeVue();"">element-ui</a></dd>
                        </dl>
                    </li>
                    <li class=""layui-nav-item""><a");
                BeginWriteAttribute("href", " href=\"", 3624, "\"", 3631, 0);
                EndWriteAttribute();
                WriteLiteral(@">发布商品</a></li>
                </ul>
            </div>
        </div>

        <div class=""layui-body"" style=""border: 0px;width: 100%;height:100%"">
            <!-- 内容主体区域 -->
            <iframe id=""iframe"" src=""https://www.layui.com/"" frameborder=""0"" style=""border: 0px;margin-top:10px; width: 100%;height:100%"" scrolling=""auto"" class=""layadmin-iframe""></iframe>
");
                WriteLiteral(@"

        </div>

    </div>
    <script charset=""utf-8"">
        function iframeChange() {
            $('iframe').attr('src', ""/Org/Index"");
        }
        function iframeChangeForm() {
            $('iframe').attr('src', ""/Org/addOrg"");
        }
        function iframeChangeList() {
            $('iframe').attr('src', ""/Org/List"");
        }
        function iframeChangeAutoForm() {
            $('iframe').attr('src', ""/UI/Form/CoreView?tmplCode=CoreForm&ID=0a7fb00c3-9d93-41ea-a1c0-b60c84776c11"");
        }
        function iframeChangeAutoList() {
            $('iframe').attr('src', ""/UI/List/CoreView?tmplCode=CoreList&ID=ab2c00f2-89c2-4148-9dd2-e15e3485e183"");
        }
        function iframeChangeDemoList() {
            $('iframe').attr('src', ""/UI/List/Index"");
        }


        function iframeChangeVue() {
            $('iframe').attr('src', ""https://element.eleme.cn/#/zh-CN/component/installation"");
        }
    </script>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
