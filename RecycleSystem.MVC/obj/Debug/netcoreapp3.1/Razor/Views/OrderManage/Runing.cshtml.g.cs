#pragma checksum "D:\Users\Senku\source\repos\SenkuuChin\RecycleSystem\RecycleSystem.MVC\Views\OrderManage\Runing.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e35a42fac4814fe934c0fbb3f1a0d2038925d04"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OrderManage_Runing), @"mvc.1.0.view", @"/Views/OrderManage/Runing.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e35a42fac4814fe934c0fbb3f1a0d2038925d04", @"/Views/OrderManage/Runing.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5395091e11ca697dd29694adba61af7541e0e676", @"/Views/_ViewImports.cshtml")]
    public class Views_OrderManage_Runing : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Users\Senku\source\repos\SenkuuChin\RecycleSystem\RecycleSystem.MVC\Views\OrderManage\Runing.cshtml"
  
    ViewData["Title"] = "进行中的订单";
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
        <button class=""layui-btn layui-btn-sm layui-btn-normal"" lay-event=""View""><i class=""layui-icon""></i>查看订单</button>
    </div>
</script>

<script type=""text/html"" id=""barDemo"">
    <a class=""layui-btn layui-btn-xs"" lay-event=""edit"">编辑</a>
    <a class=""layui-btn layui-btn-danger layui-btn-xs"" lay-event=""del"">删除</a>
</script>

<!-- 注意：如果你直接复制所有代码到本地，上述js路径需要改成你本地的 -->
<script type=""text/html"" id=""statusId"">
    {{#  if(d.status == 1){ }}
    <span style=""color: indianred;width:200px"">未接单</span>
    {{#  } else if (d.status == ");
            WriteLiteral(@"2){ }}
    <span style=""color:orangered; width:200px;"">进行中</span>
    {{#  } else if (d.status == 3){ }}
    <span style=""color:red;width:200px"">已完成</span>
    {{#  } else if (d.status == 4){ }}
    <span style=""color:palevioletred;width:200px"">撤销申请中</span>
    {{#  } else if (d.status == 5){ }}
    <span style=""color:tomato;width:200px"">已驳回撤销申请</span>
    {{#  } else if (d.status == 6){ }}
    <span style=""color:gold;width:200px"">已撤销</span>
    {{#  } }}

</script>
<script>
    var table; //放置全局中，方便后续使用
    layui.use('table', function () {
        table = layui.table;
        var form = layui.form;
        table.render({
            elem: '#orderList'
            , url: '/OrderManage/GetRunningOrders'
            , defaultToolbar: ['filter', 'exports', 'print', { //自定义头部工具栏右侧图标。如无需自定义，去除该参数即可
                title: '提示'
                , layEvent: 'LAYTABLE_TIPS'
                , icon: 'layui-icon-tips'
            }]
            , parseData: function (res) {
                retur");
            WriteLiteral(@"n {
                    ""code"": 0
                    , ""msg"": """",
                    ""count"": res.count
                    , ""data"": res.data
                    , ""curr"": res.data.length
                }
            }
            , title: '用户数据表'
            , cols: [[
                { type: 'checkbox', fixed: 'left' }
                , { field: 'oid', title: 'ID', width: 80, fixed: 'left', unresize: true, sort: false }
                , { field: 'enterpriser', title: '发布者', width: 100 }
                , { field: 'name', title: '物品名', width: 120  }
                , { field: 'category', title: '类型', width: 150,  sort: false }
                , { field: 'num', title: '数量', width: 250 }
                , { field: 'unit', title: '单位', width: 50 }
                , { field: 'addTime', title: '添加时间', width: 200 }
                , { field: 'status', title: '状态', width: 130, sort: false, templet: '#statusId' }
                , { field: 'receiver', title: '执行者', width: 130, sort: false }
");
            WriteLiteral(@"                , { fixed: 'right', title: '操作', width: 200, align: 'center', toolbar: '#operation' }
            ]]
            , page: true
            , limit: 10
            , limits: [10, 20, 25, 30, 35, 40, 45, 50, 100]
        });
        
        //头工具栏事件
        table.on('tool(orderList)', function (obj) {
            debugger;
            var checkStatus = table.checkStatus(obj.data.id);
            switch (obj.event) {
                case 'View':
                    var data = obj.data;
                    console.log(data);
                    layer.open({
                        type: 2,
                        title: ""订单进度查看"",
                        shade: 0.8,
                        area: ['780px', '620px'],
                        content: ['/OrderManage/ViewOrder?oid=' + data.oid + ''],
                    });
                    break;

                //自定义头工具栏右侧图标 - 提示
                case 'LAYTABLE_TIPS':
                    layer.alert('这是工具栏右侧自定义的一个图标按钮');
");
            WriteLiteral(@"                    break;
            };
        });
    });
    //查询
    btn_search = function () {
        debugger;
        var selectInfo = $(""#txt_Query"").val();

        //重新加载表格，并把文本框的内容传给后台
        table.reload('orderList', {
            url: '/OrderManage/GetRunningOrders',
            page: {
                curr: 1//从第一页开始（很关键）
            },
            where: {
                queryInfo: selectInfo, //需传过去的值
            }
        });
    };
</script>



");
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
