#pragma checksum "E:\Senkuu\RecycleSystem\RecycleSystem.MVC\Views\OrderManage\SpecialRequest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2931f00ce385a505b1b7e569df70b36b2e19cf5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OrderManage_SpecialRequest), @"mvc.1.0.view", @"/Views/OrderManage/SpecialRequest.cshtml")]
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
#line 1 "E:\Senkuu\RecycleSystem\RecycleSystem.MVC\Views\_ViewImports.cshtml"
using RecycleSystem.MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Senkuu\RecycleSystem\RecycleSystem.MVC\Views\_ViewImports.cshtml"
using RecycleSystem.MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2931f00ce385a505b1b7e569df70b36b2e19cf5", @"/Views/OrderManage/SpecialRequest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0f17171c1af4e388c1fbe24a8c8e14fb7d04498", @"/Views/_ViewImports.cshtml")]
    public class Views_OrderManage_SpecialRequest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\Senkuu\RecycleSystem\RecycleSystem.MVC\Views\OrderManage\SpecialRequest.cshtml"
  
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
        <button class=""layui-btn layui-btn-sm layui-btn-normal"" lay-event=""View""><i class=""layui-icon""></i>申请撤销订单</button>
    </div>
</script>


<!-- 注意：如果你直接复制所有代码到本地，上述js路径需要改成你本地的 -->
<script type=""text/html"" id=""statusId"">
    {{#  if(d.status == 1){ }}
    <span style=""color: indianred;width:200px"">未接单</span>
    {{#  } else if (d.status == 2){ }}
    <span style=""color:orangered; width:200px;"">进行中</span>
    {{#  } else if (d.status == 3){ }}
    <span style=""color:red;width:200px"">已完成</span>
    {{#  } else if (d.status ");
            WriteLiteral(@"== 4){ }}
    <span style=""color:palevioletred;width:200px"">撤销申请中</span>
    {{#  } else if (d.status == 5){ }}
    <span style=""color:tomato;width:200px"">已驳回撤销申请</span>
    {{#  } else if (d.status == 6){ }}
    <span style=""color:gold;width:200px"">已撤销</span>
    {{#  } }}

</script>
<script>
    $(function () {
        alert(""此功能仅为突发情况和特殊情况使用！"");
    }); 
    var table; //放置全局中，方便后续使用
    layui.use('table', function () {
        table = layui.table;
        table.render({
            elem: '#orderList'
            , url: '/OrderManage/GetMyRuningOrders'
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
                    ""co");
            WriteLiteral(@"unt"": res.count
                    , ""data"": res.data
                    , ""curr"": res.data.length
                }
            }
            , title: '用户数据表'
            , cols: [[
                { type: 'checkbox', fixed: 'left' }
                , { field: 'oid', title: '订单编号', width: 300, fixed: 'left' }
                , { field: 'enterpriser', title: '发布者', width: 100 }
                , { field: 'name', title: '物品名', width: 120 }
                , { field: 'category', title: '类型', width: 150 }
                , { field: 'num', title: '数量', width: 80 }
                , { field: 'unit', title: '单位', width: 80 }
                , { field: 'addTime', title: '添加时间', width: 200 }
                , { field: 'status', title: '状态', width: 130, sort: false, templet: '#statusId' }
                , { field: 'receiver', title: '执行者', width: 130, sort: false }
                , { fixed: 'right', title: '操作', width: 200, align: 'center', toolbar: '#operation' }
            ]]
            , pa");
            WriteLiteral(@"ge: true
            , limit: 10
            , limits: [10, 20, 25, 30, 35, 40, 45, 50, 100]
        });


        table.on('tool(orderList)', function (obj) {
            debugger;
            var data = obj.data;
            switch (obj.event) {
                case 'View':
                    console.log(data);
                    layer.open({
                        type: 2,
                        title: ""申请撤销订单"",
                        shade: 0.8,
                        area: ['780px', '620px'],
                        content: ['/OrderManage/ApplyingWithdrew?oid=' + data.oid + ''],
                    });
                    break;

                case 'withdrew':
                    layer.confirm('确认撤销订单 ' + data.oid + ' 吗?', function (index) {
                        $.ajax({
                            url: ""/OrderManage/WithdrewMyApplicationBySpecial"",
                            type: ""post"",
                            data: { oid: data.oid },
                       ");
            WriteLiteral(@"     success: function (res) {
                                return layer.alert(res);
                            }
                        })
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
            url: '/OrderManage/GetMyRuningOrders',
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
