﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Features;
using DocumentFormat.OpenXml.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DocumentFormat.OpenXml.Packaging;

internal partial class PartFeatureCollection :
    IFeatureCollection,
    ITargetFeature,
    IPartConstraintFeature,
    IContentTypeFeature,
    IKnownDataPartFeature,
    IDisposableFeature,
    IContainerDisposableFeature
{
    private readonly OpenXmlPart _part;
    private Action? _disposable;

    private FeatureContainer _container;

    public PartFeatureCollection(OpenXmlPart part)
    {
        _part = part;
    }

    public bool IsReadOnly => false;

    public int Revision => _container.Revision + (Parent?.Revision ?? 0);

    private IFeatureCollection? Parent => _part?._openXmlPackage?.Features;

    string ITargetFeature.Path => ".";

    string ITargetFeature.Extension => ".xml";

    string ITargetFeature.Name => string.Empty;

    public TFeature? Get<TFeature>()
    {
        if (_container.Get<TFeature>() is { } other)
        {
            return other;
        }

        if (this is TFeature @this)
        {
            return @this;
        }

        if (GetInternal<TFeature>() is { } @internal)
        {
            return @internal;
        }

        if (Parent is { } parent && parent.Get<TFeature>() is { } fromParent)
        {
            return fromParent;
        }

        return default;
    }

    [KnownFeature(typeof(AnnotationsFeature))]
    private partial T? GetInternal<T>();

    public void Set<TFeature>(TFeature? instance)
        => _container.Set(instance);

    IEnumerable<PartConstraintRule> IPartConstraintFeature.Rules => Enumerable.Empty<PartConstraintRule>();

    bool IContentTypeFeature.IsConstant => _part is IFixedContentTypePart;

    bool IPartConstraintFeature.TryGetRule(string relationshipId, out PartConstraintRule rule)
    {
        rule = default;
        return false;
    }

    bool IKnownDataPartFeature.IsKnown(string relationshipId) => false;

    void IDisposableFeature.Register(Action disposable) => _disposable = disposable + _disposable;

    void IContainerDisposableFeature.Dispose()
    {
        _disposable?.Invoke();
        _disposable = null;
    }
}
