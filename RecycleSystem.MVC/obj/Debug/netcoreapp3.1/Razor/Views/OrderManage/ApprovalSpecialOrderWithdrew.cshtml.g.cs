#pragma checksum "D:\Users\Senku\source\repos\SenkuuChin\RecycleSystem\RecycleSystem.MVC\Views\OrderManage\ApprovalSpecialOrderWithdrew.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c68011eb58569cff663fe6dc13c892fe6b43186d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OrderManage_ApprovalSpecialOrderWithdrew), @"mvc.1.0.view", @"/Views/OrderManage/ApprovalSpecialOrderWithdrew.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c68011eb58569cff663fe6dc13c892fe6b43186d", @"/Views/OrderManage/ApprovalSpecialOrderWithdrew.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5395091e11ca697dd29694adba61af7541e0e676", @"/Views/_ViewImports.cshtml")]
    public class Views_OrderManage_ApprovalSpecialOrderWithdrew : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Users\Senku\source\repos\SenkuuChin\RecycleSystem\RecycleSystem.MVC\Views\OrderManage\ApprovalSpecialOrderWithdrew.cshtml"
  
    ViewData["Title"] = "特殊请求订单";
    Layout = "~/Views/Shared/_MyLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""layui-row "">

    <div class=""layui-col-md2 layui-col-md-offset5 "" style=""margin-top:20px;""><input type=""text"" id=""txt_Query"" placeholder=""请输入订单号"" class=""layui-input""></div>
    <div class=""layui-col-md1"" style=""margin-top:20px;""> <button class=""layui-btn"" onclick=""btn_search()"">搜索</button></div>

</div>


<table class=""layui-hide"" id=""orderList"" lay-filter=""orderList""></table>

<script type=""text/html"" id=""operation"">
    <div class=""layui-row"">
        <button class=""layui-btn layui-btn-sm layui-btn-normal"" lay-event=""ViewSpecial""><i class=""layui-icon""></i>查看订单</button>
    </div>
</script>


<!-- 注意：如果你直接复制所有代码到本地，上述js路径需要改成你本地的 -->
<script type=""text/html"" id=""statusId"">
    {{#  if(d.status == 1){ }}
    <span style=""color: indianred;width:200px"">撤销订单申请中</span>
    {{#  } else if (d.status == 2){ }}
    <span style=""color:orangered; width:200px;"">客户已撤销申请</span>
    {{#  } else if (d.status == 3){ }}
    <span style=""color:red;width:200px"">拒绝撤销订单</span>
    {{#  } el");
            WriteLiteral(@"se if (d.status == 4){ }}
    <span style=""color:palevioletred;width:200px"">已允许</span>
    {{#  } }}

</script>
<script>
    var table; //放置全局中，方便后续使用
    layui.use('table', function () {
        table = layui.table;
        table.render({
            elem: '#orderList'
            , url: '/OrderManage/GetRuningSpecialOrders'
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
                { type: 'checkbox', fixed: 'left'");
            WriteLiteral(@" }
                , { field: 'instanceId', title: '事件编号', width: 300, fixed: 'left' }
                , { field: 'userId', title: '请求人', width: 100 }
                , { field: 'enterpriseName', title: '所属公司', width: 100 }
                , { field: 'reason', title: '缘由', width: 120 }
                , { field: 'currentReviewer', title: '当前审核人', width: 150 }
                , { field: 'orderID', title: '订单编号', width: 80 }
                , { field: 'typeId', title: '类别', width: 80 }
                , { field: 'addTime', title: '申请时间', width: 200 }
                , { field: 'status', title: '状态', width: 130, sort: false, templet: '#statusId' }
                , { field: 'receiver', title: '正在执行人', width: 130, sort: false }
                , { fixed: 'right', title: '操作', width: 200, align: 'center', toolbar: '#operation' }
            ]]
            , page: true
            , limit: 10
            , limits: [10, 20, 25, 30, 35, 40, 45, 50, 100]
        });


        table.on('tool(orderLis");
            WriteLiteral(@"t)', function (obj) {
            debugger;
            var data = obj.data;
            switch (obj.event) {
                case 'ViewSpecial':
                    layer.open({
                        type: 2,
                        title: ""请求撤销的特殊订单查看"",
                        shade: 0.8,
                        area: ['780px', '620px'],
                        content: ['/OrderManage/ViewSpecialApplyingOrder?oid=' + data.orderID + ''],
                    });
                    break;
                //自定义头工具栏右侧图标 - 提示
                case 'LAYTABLE_TIPS':
                    layer.alert('这是工具栏右侧自定义的一个图标按钮');
                    break;
            };
        });
    });
    //查询
    btn_search = function () {
        debugger;
        var selectInfo = $(""#txt_Query"").val();

        //重新加载表格，并把文本框的内容传给后台
        table.reload('orderList', {
            url: '/OrderManage/GetRuningSpecialOrders',
            page: {
                curr: 1//从第一页开始（很关键）
            },
       ");
            WriteLiteral("     where: {\r\n                queryInfo: selectInfo, //需传过去的值\r\n            }\r\n        });\r\n    };\r\n</script>\r\n");
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
