#pragma checksum "C:\Users\User\Desktop\ASP.NET Core\OnlineShop\OnlineShopWebApp\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "760aced4e9c8bd0c9071699cce994e0241cb87ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
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
#line 1 "C:\Users\User\Desktop\ASP.NET Core\OnlineShop\OnlineShopWebApp\Views\_ViewImports.cshtml"
using OnlineShopWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\ASP.NET Core\OnlineShop\OnlineShopWebApp\Views\_ViewImports.cshtml"
using OnlineShopWebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\ASP.NET Core\OnlineShop\OnlineShopWebApp\Views\_ViewImports.cshtml"
using OnlineShop.Db.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Desktop\ASP.NET Core\OnlineShop\OnlineShopWebApp\Views\_ViewImports.cshtml"
using OnlineShopWebApp.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"760aced4e9c8bd0c9071699cce994e0241cb87ab", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b6e7d84013a44bd0102d53deedd73339cf0c715", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CartViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\Desktop\ASP.NET Core\OnlineShop\OnlineShopWebApp\Views\Cart\Index.cshtml"
     if(Model == null || Model.Items.Count == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h5>В корзине нет товаров</h5>\r\n");
#nullable restore
#line 5 "C:\Users\User\Desktop\ASP.NET Core\OnlineShop\OnlineShopWebApp\Views\Cart\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""row"">
                    <div class=""col"">
                        <table class=""table"">
                            <thead>
                                <tr class=""text-center"">
                                    <th>Название</th>
                                    <th>Цена, руб.</th>
                                    <th>Количество, шт.</th>
                                    <th>Общая стоимость, руб.</th>
                                    <th></th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 21 "C:\Users\User\Desktop\ASP.NET Core\OnlineShop\OnlineShopWebApp\Views\Cart\Index.cshtml"
                                 foreach(var item in Model.Items)
                                  {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr class=\"text-center\">\r\n                                    <td>");
#nullable restore
#line 24 "C:\Users\User\Desktop\ASP.NET Core\OnlineShop\OnlineShopWebApp\Views\Cart\Index.cshtml"
                                   Write(item.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 25 "C:\Users\User\Desktop\ASP.NET Core\OnlineShop\OnlineShopWebApp\Views\Cart\Index.cshtml"
                                   Write(item.Product.Cost);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>                                   \r\n                                    <td>\r\n                                        ");
#nullable restore
#line 27 "C:\Users\User\Desktop\ASP.NET Core\OnlineShop\OnlineShopWebApp\Views\Cart\Index.cshtml"
                                   Write(item.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    \r\n                                        <a class=\"btn btn-outline-dark\" role=\"button\"");
            BeginWriteAttribute("href", " href=\"", 1346, "\"", 1389, 2);
            WriteAttributeValue("", 1353, "/cart/add?productId=", 1353, 20, true);
#nullable restore
#line 28 "C:\Users\User\Desktop\ASP.NET Core\OnlineShop\OnlineShopWebApp\Views\Cart\Index.cshtml"
WriteAttributeValue("", 1373, item.Product.Id, 1373, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">+</a>\r\n                                        <a class=\"btn btn-outline-dark\" role=\"button\"");
            BeginWriteAttribute("href", " href=\"", 1483, "\"", 1537, 2);
            WriteAttributeValue("", 1490, "/cart/decreaseAmount?productId=", 1490, 31, true);
#nullable restore
#line 29 "C:\Users\User\Desktop\ASP.NET Core\OnlineShop\OnlineShopWebApp\Views\Cart\Index.cshtml"
WriteAttributeValue("", 1521, item.Product.Id, 1521, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">-</a>\r\n                                    </td>\r\n                                    <td>");
#nullable restore
#line 31 "C:\Users\User\Desktop\ASP.NET Core\OnlineShop\OnlineShopWebApp\Views\Cart\Index.cshtml"
                                   Write(item.Cost);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </tr>\r\n");
#nullable restore
#line 33 "C:\Users\User\Desktop\ASP.NET Core\OnlineShop\OnlineShopWebApp\Views\Cart\Index.cshtml"
                                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                        <div class=\"text-right\">\r\n                            <h3>Итого:</h3>\r\n                            <h3>");
#nullable restore
#line 38 "C:\Users\User\Desktop\ASP.NET Core\OnlineShop\OnlineShopWebApp\Views\Cart\Index.cshtml"
                           Write(Model.Cost);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" руб.</h3>
                        </div>
                        <div class=""text-right"">
                            <br />
                            <a class=""btn btn-danger"" role=""button"" href=""/cart/clear"">Очистить корзину</a>
                            <a class=""btn btn-warning"" style=""color:crimson"" role=""button"" href=""/home/index"">Продолжить покупки</a>
                            <a class=""btn btn-success"" role=""button"" href=""/order/index"">Оформить заказ</a>
                            <br />
                        </div>
                    </div>
                </div>
");
#nullable restore
#line 49 "C:\Users\User\Desktop\ASP.NET Core\OnlineShop\OnlineShopWebApp\Views\Cart\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CartViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591