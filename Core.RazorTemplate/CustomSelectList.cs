using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.RazorTemplate
{
  public  class CustomSelectList<IValue>:InputSelect<IValue>
    {
        protected override bool TryParseValueFromString(string value, out IValue result, out string validationErrorMessage)
        {
            if (typeof(IValue) == typeof(int))
            {
                if (int.TryParse(value, out var resuleInt))
                {
                    result = (IValue)(object)resuleInt;
                    validationErrorMessage = null;
                    return true;

                }
                else
                {
                    result = default;
                    validationErrorMessage = $"Selection Value Invaild{value}";
                    return false;

                }
            }
            else
            {
                return base.TryParseValueFromString(value, out result,out validationErrorMessage);
            }
                

        }
    }
}
