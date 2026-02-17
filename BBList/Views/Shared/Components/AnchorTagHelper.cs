using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace BBList.Views.Shared.Components
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement("a")]
    public class AnchorTagHelper : TagHelper
    {
        public enum AnchorType
        {
            Default,
            Outline,
            Destructive,
            Link
        }
        public enum AnchorSize
        {
            Default,
            Xs,
            Sm,
            Lg,
            Icon,
            IconXs,
            IconSm,
            IconLg
        }

        public AnchorType Variant { get; set; } = AnchorType.Default;
        public AnchorSize Size { get; set; } = AnchorSize.Default;
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";

            string classString = "font-rokkit focus-visible:border-ring focus-visible:ring-ring/50 aria-invalid:ring-destructive/20 dark:aria-invalid:ring-destructive/40 aria-invalid:border-red-500 dark:aria-invalid:border-red-500/50 rounded-lg border border-transparent bg-clip-padding text-base font-medium focus-visible:ring-3 aria-invalid:ring-3 [&_svg:not([class*='size-'])]:size-4 inline-flex items-center justify-center whitespace-nowrap transition-all disabled:pointer-events-none disabled:opacity-50 [&_svg]:pointer-events-none shrink-0 [&_svg]:shrink-0 outline-none group/button select-none";

            switch (Variant)
            {
                case AnchorType.Default:
                    classString += " bg-slate-100 text-slate-700 [a]:hover:bg-slate-100/80";
                    break;
                case AnchorType.Outline:
                    classString += " border-zinc-300 bg-transparent hover:bg-zinc-300/50 hover:text-foreground dark:bg-input/30 dark:border-zinc-300 dark:hover:bg-input/50 aria-expanded:bg-muted aria-expanded:text-foreground";
                    break;
                case AnchorType.Destructive:
                    classString += " bg-red-500/10 hover:bg-red-500/20 focus-visible:ring-destructive/20 dark:focus-visible:ring-destructive/40 dark:bg-red-500/20 text-destructive focus-visible:border-red-500/40 dark:hover:bg-red-500/30";
                    break;
                case AnchorType.Link:
                    classString += " text-slate-700 underline-offset-4 hover:underline ps-0 pe-0";
                    break;
            }

            switch (Size)
            {
                case AnchorSize.Default:
                    classString += " h-8 gap-1.5 px-2.5 has-data-[icon=inline-end]:pr-2 has-data-[icon=inline-start]:pl-2";
                    break;
                case AnchorSize.Xs:
                    classString += " h-6 gap-1 rounded-[min(var(--radius-md),10px)] px-2 text-xs in-data-[slot=button-group]:rounded-lg has-data-[icon=inline-end]:pr-1.5 has-data-[icon=inline-start]:pl-1.5 [&_svg:not([class*='size-'])]:size-3";
                    break;
                case AnchorSize.Sm:
                    classString += " h-7 gap-1 rounded-[min(var(--radius-md),12px)] px-2.5 text-[0.8rem] in-data-[slot=button-group]:rounded-lg has-data-[icon=inline-end]:pr-1.5 has-data-[icon=inline-start]:pl-1.5 [&_svg:not([class*='size-'])]:size-3.5";
                    break;
                case AnchorSize.Lg:
                    classString += " h-9 gap-1.5 px-2.5 has-data-[icon=inline-end]:pr-3 has-data-[icon=inline-start]:pl-3";
                    break;
                case AnchorSize.Icon:
                    classString += " size-8";
                    break;
                case AnchorSize.IconXs:
                    classString += " size-6 rounded-[min(var(--radius-md),10px)] in-data-[slot=button-group]:rounded-lg [&_svg:not([class*='size-'])]:size-3";
                    break;
                case AnchorSize.IconSm:
                    classString += " size-7 rounded-[min(var(--radius-md),12px)] in-data-[slot=button-group]:rounded-lg";
                    break;
                case AnchorSize.IconLg:
                    classString += " size-9";
                    break;
            }

            output.Attributes.SetAttribute("class", classString);
        }
    }
}
