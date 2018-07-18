using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data.Items;
using Sitecore.Data.Fields;

namespace Sitecore.Support.XA.Foundation.RenderingVariants.Pipelines.RenderVariantField
{
  public class RenderText : Sitecore.XA.Foundation.RenderingVariants.Pipelines.RenderVariantField.RenderText
  {
    protected override string GetAttributeTokenValue(string fieldName, Item item)
    {
      Field field = item.Fields[fieldName];
      if (field != null)
      {
        CustomField field2 = FieldTypeManager.GetField(field);
        if (field2 is ValueLookupField)
        {
          return ((ValueLookupField)item.Fields[fieldName]).Value;
        }
        else
        {
          return base.GetAttributeTokenValue(fieldName, item);
        }
      }
      else
        return String.Empty;
    }
  }

  public class RenderVariantField: Sitecore.XA.Foundation.RenderingVariants.Pipelines.RenderVariantField.RenderVariantField
  {
    protected override string GetAttributeTokenValue(string fieldName, Item item)
    {
      Field field = item.Fields[fieldName];
      if (field != null)
      {
        CustomField field2 = FieldTypeManager.GetField(field);
        if (field2 is ValueLookupField)
        {
          return ((ValueLookupField)item.Fields[fieldName]).Value;
        }
        else
        {
          return base.GetAttributeTokenValue(fieldName, item);
        }
      }
      else
        return String.Empty;
    }
  }


  public class RenderSection : Sitecore.XA.Foundation.RenderingVariants.Pipelines.RenderVariantField.RenderSection
  {
    protected override string GetAttributeTokenValue(string fieldName, Item item)
    {
      Field field = item.Fields[fieldName];
      if (field != null)
      {
        CustomField field2 = FieldTypeManager.GetField(field);
        if (field2 is ValueLookupField)
        {
          return ((ValueLookupField)item.Fields[fieldName]).Value;
        }
        else
        {
          return base.GetAttributeTokenValue(fieldName, item);
        }
      }
      else
        return String.Empty;
    }
  }
}