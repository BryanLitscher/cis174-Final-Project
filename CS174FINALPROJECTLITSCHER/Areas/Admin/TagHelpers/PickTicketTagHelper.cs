using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace CS174FINALPROJECTLITSCHER.TagHelpers
{
    [HtmlTargetElement("a", Attributes= "[title=pickticket]")]
    public class PickTicketTagHelper: TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.SetAttribute("class", "btn btn-primary");
        }

    }
}


