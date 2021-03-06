#pragma checksum "D:\Users\Senku\source\repos\SenkuuChin\RecycleSystem\RecycleSystem.MVC\Views\LogManage\OperateLog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6793694f7c3af15d845c02842af6edb155ae6737"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LogManage_OperateLog), @"mvc.1.0.view", @"/Views/LogManage/OperateLog.cshtml")]
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
#line 1 "D:\Users\Senku\source\repos\SenkuuChin\RecycleSystem\RecycleSystem.MVC\Views\_ViewImports.cshtml"
using RecycleSystem.MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Users\Senku\source\repos\SenkuuChin\RecycleSystem\RecycleSystem.MVC\Views\_ViewImports.cshtml"
using RecycleSystem.MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6793694f7c3af15d845c02842af6edb155ae6737", @"/Views/LogManage/OperateLog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5395091e11ca697dd29694adba61af7541e0e676", @"/Views/_ViewImports.cshtml")]
    public class Views_LogManage_OperateLog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Users\Senku\source\repos\SenkuuChin\RecycleSystem\RecycleSystem.MVC\Views\LogManage\OperateLog.cshtml"
  
    ViewData["Title"] = "操作日志信息";
    Layout = "~/Views/Shared/_MyLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table class=""layui-hide"" id=""operateLogDataList"" lay-filter=""operateLogDataList""></table>


<script>
    var table; //放置全局中，方便后续使用
    layui.use('table', function () {
        table = layui.table;
        table.render({
            elem: '#operateLogDataList'
            , url: '/LogManage/GetOperateLogData'
            , toolbar: '#toolbarDemo' //开启头部工具栏，并为其绑定左侧模板
            , defaultToolbar: ['filter', 'exports', 'print', { //自定义头部工具栏右侧图标。如无需自定义，去除该参数即可
                title: '提示'
                , layEvent: 'LAYTABLE_TIPS'
                , icon: 'layui-icon-tips'
            }]
            , parseData: function (res) {
                return {
                    ""code"": 0
                    , ""msg"": """",
                    ""count"": res.count
                    , ""data"": res.data
                    , ""curr"": res.data.length
                }
            }
            , title: '用户数据表'
            , cols: [[
                  { type: 'checkbox', fixed: 'left' },
          ");
            WriteLiteral(@"        { field: 'id', title: 'ID', width: 100, unresize: false }
                , { field: 'operator', title: '操作人', width: 200 }
                , { field: 'info', title: '信息', width: 500 }
                , { field: 'addTime', title: '操作时间', width: 300 }
            ]]
            , page: true
            , limit: 10
            , limits: [10, 20, 25, 30, 35, 40, 45, 50, 100]
        });
    });
</script>");
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
