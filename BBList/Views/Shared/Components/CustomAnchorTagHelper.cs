using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace BBList.Views.Shared.Components
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement("custom-anchor")]
    public class CustomAnchorTagHelper : TagHelper
    {
        public enum AnchorType
        {
            Default,
            Outline,
            Destructive,
            Link
        }

        public AnchorType Type { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";    // Replaces <tag-name> with <a> tag
            
            switch (Type)
            {
                case AnchorType.Default:
                    output.Attributes.SetAttribute("class", "bg-blue-500");
                    break;
                case AnchorType.Outline:
                    output.Attributes.SetAttribute("class", "bg-slate-500");
                    break;
                case AnchorType.Destructive:
                    output.Attributes.SetAttribute("class", "bg-red-500");
                    break;
                case AnchorType.Link:
                    output.Attributes.SetAttribute("class", "bg-black");
                    break;
            }
        }
    }
}
