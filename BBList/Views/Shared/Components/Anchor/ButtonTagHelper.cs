using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace BBList.Views.Shared.Components.Anchor
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement("button")]
    public class ButtonTagHelper : TagHelper
    {
        public enum VariantTypes {
            Default,
            Outline,
            Secondary,
            Ghost,
            Destructive,
            Link
        }
        public enum SizeTypes {
            Default,
            Xs,
            Sm,
            Lg,
            Icon,
            IconXs,
            IconSm,
            IconLg
        }

        readonly string _default = "bg-primary text-primary-foreground [a]:hover:bg-primary/80";
        readonly string _outline = "border-border bg-background hover:bg-muted hover:text-foreground dark:bg-input/30 dark:border-input dark:hover:bg-input/50 aria-expanded:bg-muted aria-expanded:text-foreground";
        readonly string _secondary = "bg-secondary text-secondary-foreground hover:bg-secondary/80 aria-expanded:bg-secondary aria-expanded:text-secondary-foreground";
        readonly string _ghost = "hover:bg-muted hover:text-foreground dark:hover:bg-muted/50 aria-expanded:bg-muted aria-expanded:text-foreground";
        readonly string _destructive = "bg-destructive/10 hover:bg-destructive/20 focus-visible:ring-destructive/20 dark:focus-visible:ring-destructive/40 dark:bg-destructive/20 text-destructive focus-visible:border-destructive/40 dark:hover:bg-destructive/30";
        readonly string _link = "text-primary underline-offset-4 hover:underline";

        readonly string _sizeDefault = "h-8 gap-1.5 px-2.5 has-data-[icon=inline-end]:pr-2 has-data-[icon=inline-start]:pl-2";
        readonly string _sizeXs = "h-6 gap-1 rounded-[min(var(--radius-md),10px)] px-2 text-xs in-data-[slot=button-group]:rounded-lg has-data-[icon=inline-end]:pr-1.5 has-data-[icon=inline-start]:pl-1.5 [&_svg:not([class*='size-'])]:size-3";
        readonly string _sizeSm = "h-7 gap-1 rounded-[min(var(--radius-md),12px)] px-2.5 text-[0.8rem] in-data-[slot=button-group]:rounded-lg has-data-[icon=inline-end]:pr-1.5 has-data-[icon=inline-start]:pl-1.5 [&_svg:not([class*='size-'])]:size-3.5";
        readonly string _sizeLg = "h-9 gap-1.5 px-2.5 has-data-[icon=inline-end]:pr-3 has-data-[icon=inline-start]:pl-3";
        readonly string _sizeIcon = "size-8";
        readonly string _sizeIconXs = "size-6 rounded-[min(var(--radius-md),10px)] in-data-[slot=button-group]:rounded-lg [&_svg:not([class*='size-'])]:size-3";
        readonly string _sizeIconSm = "size-7 rounded-[min(var(--radius-md),12px)] in-data-[slot=button-group]:rounded-lg";
        readonly string _sizeIconLg = "size-9";

        public VariantTypes Variant { get; set; } = VariantTypes.Default;
        public SizeTypes Size { get; set; } = SizeTypes.Default;
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var v = Variant switch
            {
                VariantTypes.Default => _default,
                VariantTypes.Outline => _outline,
                VariantTypes.Secondary => _secondary,
                VariantTypes.Ghost => _ghost,
                VariantTypes.Destructive => _destructive,
                VariantTypes.Link => _link,
                _ => _default
            };

            var s = Size switch
            {
                SizeTypes.Default => _sizeDefault,
                SizeTypes.Xs => _sizeXs,
                SizeTypes.Sm => _sizeSm,
                SizeTypes.Lg => _sizeLg,
                SizeTypes.Icon => _sizeIcon,
                SizeTypes.IconXs => _sizeIconXs,
                SizeTypes.IconSm => _sizeIconSm,
                SizeTypes.IconLg => _sizeIconLg,
                _ => _sizeDefault
            };

            output.TagName = "button";
            output.Attributes.SetAttribute("variant", Variant);
            output.Attributes.SetAttribute("data-slot", "button");
            output.Attributes.SetAttribute("data-size", Size);
            output.Attributes.SetAttribute("class", v + " " + s + "focus-visible:border-ring focus-visible:ring-ring/50 aria-invalid:ring-destructive/20 dark:aria-invalid:ring-destructive/40 aria-invalid:border-destructive dark:aria-invalid:border-destructive/50 rounded-lg border border-transparent bg-clip-padding text-sm font-medium focus-visible:ring-3 aria-invalid:ring-3 [&_svg:not([class*='size-'])]:size-4 inline-flex items-center justify-center whitespace-nowrap transition-all disabled:pointer-events-none disabled:opacity-50 [&_svg]:pointer-events-none shrink-0 [&_svg]:shrink-0 outline-none group/button select-none");
        }
    }
}
