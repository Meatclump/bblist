using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace BBList.Views.Shared.Components.Card
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    //[HtmlTargetElement("tag-name")]
    public class CardFooterTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.Attributes.SetAttribute("data-slot", "card-footer");
            output.Attributes.SetAttribute("class", "bg-slate-300/50 rounded-b-xl border-t border-slate-300/50 p-4 group-data-[size=sm]/card:p-3 flex items-center");
        }
    }
}
