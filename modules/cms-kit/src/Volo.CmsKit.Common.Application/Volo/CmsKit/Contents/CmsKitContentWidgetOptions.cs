﻿using System.Collections.Generic;

namespace Volo.CmsKit.Contents;

public class CmsKitContentWidgetOptions
{
    public Dictionary<string, ContentWidgetConfig> WidgetConfigs { get; }

    public CmsKitContentWidgetOptions()
    {
        WidgetConfigs = new();
    }

    public void AddWidget(string widgetKey, string widgetName, string internalWidgetName = null)
    {
        var config = new ContentWidgetConfig(widgetName, internalWidgetName);
        WidgetConfigs.Add(widgetKey, config);
    }
}