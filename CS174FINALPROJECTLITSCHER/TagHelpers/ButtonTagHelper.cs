

using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CS174FINALPROJECTLITSCHER.TagHelpers
{
    [HtmlTargetElement("button", Attributes = "[title=Select]")]
    public class ButtonTagHelper : TagHelper
    {

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.SetAttribute("class", "btn btn-success");
        }
    }
}
