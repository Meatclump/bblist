using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace BBList.Views.Shared.Components.Card
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    //[HtmlTargetElement("tag-name")]
    public class CardContentTagHelper : TagHelper
    {
        public string Size { get; set; } = "default";
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.Attributes.SetAttribute("data-size", Size);
            output.Attributes.SetAttribute("class", "px-4 group-data-[size=sm]/card:px-3");
        }
    }
}
