using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace BBList.Views.Shared.Components.Card
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    //[HtmlTargetElement("tag-name")]
    public class CardDescriptionTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.Attributes.SetAttribute("class", "text-slate-900/50 text-sm");
        }
    }
}
