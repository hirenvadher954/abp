﻿using System;
using Volo.Abp.Application.Dtos;

namespace Volo.CmsKit.Contents;

public class PageDto : ExtensibleEntityDto<Guid>
{
    public string Title { get; set; }

    public string Slug { get; set; }

    public string LayoutName { get; set; }

    public string Content { get; set; }

    public string Script { get; set; }

    public string Style { get; set; }
}