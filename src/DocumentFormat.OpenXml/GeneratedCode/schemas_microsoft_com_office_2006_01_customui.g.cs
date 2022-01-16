﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office.CustomUI
{
    /// <summary>
    /// <para>Defines the UnsizedControlClone Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:control.</para>
    /// </summary>
    [SchemaAttr("mso:control")]
    public partial class UnsizedControlClone : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the UnsizedControlClone class.
        /// </summary>
        public UnsizedControlClone() : base()
        {
        }

        /// <summary>
        /// <para>idQ</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? IdQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [SchemaAttr("idMso")]
        public StringValue? IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [SchemaAttr("image")]
        public StringValue? Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [SchemaAttr("imageMso")]
        public StringValue? ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [SchemaAttr("getImage")]
        public StringValue? GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [SchemaAttr("screentip")]
        public StringValue? Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [SchemaAttr("getScreentip")]
        public StringValue? GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [SchemaAttr("supertip")]
        public StringValue? Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [SchemaAttr("getSupertip")]
        public StringValue? GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [SchemaAttr("getEnabled")]
        public StringValue? GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [SchemaAttr("getLabel")]
        public StringValue? GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [SchemaAttr("insertAfterMso")]
        public StringValue? InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [SchemaAttr("insertBeforeMso")]
        public StringValue? InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [SchemaAttr("insertAfterQ")]
        public StringValue? InsertAfterQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [SchemaAttr("insertBeforeQ")]
        public StringValue? InsertBeforeQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [SchemaAttr("keytip")]
        public StringValue? Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [SchemaAttr("getKeytip")]
        public StringValue? GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr("showLabel")]
        public BooleanValue? ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [SchemaAttr("getShowLabel")]
        public StringValue? GetShowLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showImage</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr("showImage")]
        public BooleanValue? ShowImage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowImage</para>
        /// <para>Represents the following attribute in the schema: getShowImage</para>
        /// </summary>
        [SchemaAttr("getShowImage")]
        public StringValue? GetShowImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso:control");
            builder.AddElement<UnsizedControlClone>()
.AddAttribute("idQ", a => a.IdQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("image", a => a.Image, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("imageMso", a => a.ImageMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getImage", a => a.GetImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("screentip", a => a.Screentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getScreentip", a => a.GetScreentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("supertip", a => a.Supertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getSupertip", a => a.GetSupertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("enabled", a => a.Enabled)
.AddAttribute("getEnabled", a => a.GetEnabled, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterQ", a => a.InsertAfterQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeQ", a => a.InsertBeforeQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("visible", a => a.Visible)
.AddAttribute("getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("keytip", a => a.Keytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), MinLength = (1L), MaxLength = (3L) });
})
.AddAttribute("getKeytip", a => a.GetKeytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("showLabel", a => a.ShowLabel)
.AddAttribute("getShowLabel", a => a.GetShowLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("showImage", a => a.ShowImage)
.AddAttribute("getShowImage", a => a.GetShowImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<UnsizedControlClone>(deep);
    }

    /// <summary>
    /// <para>Defines the UnsizedButton Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:button.</para>
    /// </summary>
    [SchemaAttr("mso:button")]
    public partial class UnsizedButton : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the UnsizedButton class.
        /// </summary>
        public UnsizedButton() : base()
        {
        }

        /// <summary>
        /// <para>onAction</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        [SchemaAttr("onAction")]
        public StringValue? OnAction
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [SchemaAttr("getEnabled")]
        public StringValue? GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>description</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [SchemaAttr("description")]
        public StringValue? Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getDescription</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [SchemaAttr("getDescription")]
        public StringValue? GetDescription
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [SchemaAttr("image")]
        public StringValue? Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [SchemaAttr("imageMso")]
        public StringValue? ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [SchemaAttr("getImage")]
        public StringValue? GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? IdQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [SchemaAttr("idMso")]
        public StringValue? IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [SchemaAttr("screentip")]
        public StringValue? Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [SchemaAttr("getScreentip")]
        public StringValue? GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [SchemaAttr("supertip")]
        public StringValue? Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [SchemaAttr("getSupertip")]
        public StringValue? GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [SchemaAttr("getLabel")]
        public StringValue? GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [SchemaAttr("insertAfterMso")]
        public StringValue? InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [SchemaAttr("insertBeforeMso")]
        public StringValue? InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [SchemaAttr("insertAfterQ")]
        public StringValue? InsertAfterQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [SchemaAttr("insertBeforeQ")]
        public StringValue? InsertBeforeQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [SchemaAttr("keytip")]
        public StringValue? Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [SchemaAttr("getKeytip")]
        public StringValue? GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr("showLabel")]
        public BooleanValue? ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [SchemaAttr("getShowLabel")]
        public StringValue? GetShowLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showImage</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr("showImage")]
        public BooleanValue? ShowImage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowImage</para>
        /// <para>Represents the following attribute in the schema: getShowImage</para>
        /// </summary>
        [SchemaAttr("getShowImage")]
        public StringValue? GetShowImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso:button");
            builder.AddElement<UnsizedButton>()
.AddAttribute("onAction", a => a.OnAction, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("enabled", a => a.Enabled)
.AddAttribute("getEnabled", a => a.GetEnabled, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("description", a => a.Description, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (4096L) });
})
.AddAttribute("getDescription", a => a.GetDescription, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("image", a => a.Image, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("imageMso", a => a.ImageMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getImage", a => a.GetImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idQ", a => a.IdQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("screentip", a => a.Screentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getScreentip", a => a.GetScreentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("supertip", a => a.Supertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getSupertip", a => a.GetSupertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterQ", a => a.InsertAfterQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeQ", a => a.InsertBeforeQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("visible", a => a.Visible)
.AddAttribute("getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("keytip", a => a.Keytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), MinLength = (1L), MaxLength = (3L) });
})
.AddAttribute("getKeytip", a => a.GetKeytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("showLabel", a => a.ShowLabel)
.AddAttribute("getShowLabel", a => a.GetShowLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("showImage", a => a.ShowImage)
.AddAttribute("getShowImage", a => a.GetShowImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<UnsizedButton>(deep);
    }

    /// <summary>
    /// <para>Defines the CheckBox Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:checkBox.</para>
    /// </summary>
    [SchemaAttr("mso:checkBox")]
    public partial class CheckBox : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the CheckBox class.
        /// </summary>
        public CheckBox() : base()
        {
        }

        /// <summary>
        /// <para>getPressed</para>
        /// <para>Represents the following attribute in the schema: getPressed</para>
        /// </summary>
        [SchemaAttr("getPressed")]
        public StringValue? GetPressed
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>onAction</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        [SchemaAttr("onAction")]
        public StringValue? OnAction
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [SchemaAttr("getEnabled")]
        public StringValue? GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>description</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [SchemaAttr("description")]
        public StringValue? Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getDescription</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [SchemaAttr("getDescription")]
        public StringValue? GetDescription
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? IdQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [SchemaAttr("idMso")]
        public StringValue? IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [SchemaAttr("screentip")]
        public StringValue? Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [SchemaAttr("getScreentip")]
        public StringValue? GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [SchemaAttr("supertip")]
        public StringValue? Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [SchemaAttr("getSupertip")]
        public StringValue? GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [SchemaAttr("getLabel")]
        public StringValue? GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [SchemaAttr("insertAfterMso")]
        public StringValue? InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [SchemaAttr("insertBeforeMso")]
        public StringValue? InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [SchemaAttr("insertAfterQ")]
        public StringValue? InsertAfterQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [SchemaAttr("insertBeforeQ")]
        public StringValue? InsertBeforeQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [SchemaAttr("keytip")]
        public StringValue? Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [SchemaAttr("getKeytip")]
        public StringValue? GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso:checkBox");
            builder.AddElement<CheckBox>()
.AddAttribute("getPressed", a => a.GetPressed, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("onAction", a => a.OnAction, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("enabled", a => a.Enabled)
.AddAttribute("getEnabled", a => a.GetEnabled, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("description", a => a.Description, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (4096L) });
})
.AddAttribute("getDescription", a => a.GetDescription, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idQ", a => a.IdQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("screentip", a => a.Screentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getScreentip", a => a.GetScreentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("supertip", a => a.Supertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getSupertip", a => a.GetSupertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterQ", a => a.InsertAfterQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeQ", a => a.InsertBeforeQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("visible", a => a.Visible)
.AddAttribute("getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("keytip", a => a.Keytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), MinLength = (1L), MaxLength = (3L) });
})
.AddAttribute("getKeytip", a => a.GetKeytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CheckBox>(deep);
    }

    /// <summary>
    /// <para>Defines the UnsizedGallery Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:gallery.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton" /> <c>&lt;mso:button></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.Item" /> <c>&lt;mso:item></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso:gallery")]
    public partial class UnsizedGallery : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the UnsizedGallery class.
        /// </summary>
        public UnsizedGallery() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the UnsizedGallery class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public UnsizedGallery(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the UnsizedGallery class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public UnsizedGallery(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the UnsizedGallery class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public UnsizedGallery(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>description</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [SchemaAttr("description")]
        public StringValue? Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getDescription</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [SchemaAttr("getDescription")]
        public StringValue? GetDescription
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>invalidateContentOnDrop</para>
        /// <para>Represents the following attribute in the schema: invalidateContentOnDrop</para>
        /// </summary>
        [SchemaAttr("invalidateContentOnDrop")]
        public BooleanValue? InvalidateContentOnDrop
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>columns</para>
        /// <para>Represents the following attribute in the schema: columns</para>
        /// </summary>
        [SchemaAttr("columns")]
        public IntegerValue? Columns
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>rows</para>
        /// <para>Represents the following attribute in the schema: rows</para>
        /// </summary>
        [SchemaAttr("rows")]
        public IntegerValue? Rows
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>itemWidth</para>
        /// <para>Represents the following attribute in the schema: itemWidth</para>
        /// </summary>
        [SchemaAttr("itemWidth")]
        public IntegerValue? ItemWidth
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>itemHeight</para>
        /// <para>Represents the following attribute in the schema: itemHeight</para>
        /// </summary>
        [SchemaAttr("itemHeight")]
        public IntegerValue? ItemHeight
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemWidth</para>
        /// <para>Represents the following attribute in the schema: getItemWidth</para>
        /// </summary>
        [SchemaAttr("getItemWidth")]
        public StringValue? GetItemWidth
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemHeight</para>
        /// <para>Represents the following attribute in the schema: getItemHeight</para>
        /// </summary>
        [SchemaAttr("getItemHeight")]
        public StringValue? GetItemHeight
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showItemLabel</para>
        /// <para>Represents the following attribute in the schema: showItemLabel</para>
        /// </summary>
        [SchemaAttr("showItemLabel")]
        public BooleanValue? ShowItemLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>onAction</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        [SchemaAttr("onAction")]
        public StringValue? OnAction
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [SchemaAttr("getEnabled")]
        public StringValue? GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [SchemaAttr("image")]
        public StringValue? Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [SchemaAttr("imageMso")]
        public StringValue? ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [SchemaAttr("getImage")]
        public StringValue? GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showItemImage</para>
        /// <para>Represents the following attribute in the schema: showItemImage</para>
        /// </summary>
        [SchemaAttr("showItemImage")]
        public BooleanValue? ShowItemImage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemCount</para>
        /// <para>Represents the following attribute in the schema: getItemCount</para>
        /// </summary>
        [SchemaAttr("getItemCount")]
        public StringValue? GetItemCount
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemLabel</para>
        /// <para>Represents the following attribute in the schema: getItemLabel</para>
        /// </summary>
        [SchemaAttr("getItemLabel")]
        public StringValue? GetItemLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemScreentip</para>
        /// <para>Represents the following attribute in the schema: getItemScreentip</para>
        /// </summary>
        [SchemaAttr("getItemScreentip")]
        public StringValue? GetItemScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemSupertip</para>
        /// <para>Represents the following attribute in the schema: getItemSupertip</para>
        /// </summary>
        [SchemaAttr("getItemSupertip")]
        public StringValue? GetItemSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemImage</para>
        /// <para>Represents the following attribute in the schema: getItemImage</para>
        /// </summary>
        [SchemaAttr("getItemImage")]
        public StringValue? GetItemImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemID</para>
        /// <para>Represents the following attribute in the schema: getItemID</para>
        /// </summary>
        [SchemaAttr("getItemID")]
        public StringValue? GetItemID
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sizeString</para>
        /// <para>Represents the following attribute in the schema: sizeString</para>
        /// </summary>
        [SchemaAttr("sizeString")]
        public StringValue? SizeString
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSelectedItemID</para>
        /// <para>Represents the following attribute in the schema: getSelectedItemID</para>
        /// </summary>
        [SchemaAttr("getSelectedItemID")]
        public StringValue? GetSelectedItemID
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSelectedItemIndex</para>
        /// <para>Represents the following attribute in the schema: getSelectedItemIndex</para>
        /// </summary>
        [SchemaAttr("getSelectedItemIndex")]
        public StringValue? GetSelectedItemIndex
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? IdQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [SchemaAttr("idMso")]
        public StringValue? IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [SchemaAttr("screentip")]
        public StringValue? Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [SchemaAttr("getScreentip")]
        public StringValue? GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [SchemaAttr("supertip")]
        public StringValue? Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [SchemaAttr("getSupertip")]
        public StringValue? GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [SchemaAttr("getLabel")]
        public StringValue? GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [SchemaAttr("insertAfterMso")]
        public StringValue? InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [SchemaAttr("insertBeforeMso")]
        public StringValue? InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [SchemaAttr("insertAfterQ")]
        public StringValue? InsertAfterQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [SchemaAttr("insertBeforeQ")]
        public StringValue? InsertBeforeQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [SchemaAttr("keytip")]
        public StringValue? Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [SchemaAttr("getKeytip")]
        public StringValue? GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr("showLabel")]
        public BooleanValue? ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [SchemaAttr("getShowLabel")]
        public StringValue? GetShowLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showImage</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr("showImage")]
        public BooleanValue? ShowImage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowImage</para>
        /// <para>Represents the following attribute in the schema: getShowImage</para>
        /// </summary>
        [SchemaAttr("getShowImage")]
        public StringValue? GetShowImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso:gallery");
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.Item>();
            builder.AddElement<UnsizedGallery>()
.AddAttribute("description", a => a.Description, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (4096L) });
})
.AddAttribute("getDescription", a => a.GetDescription, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("invalidateContentOnDrop", a => a.InvalidateContentOnDrop)
.AddAttribute("columns", a => a.Columns, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (1L), MaxInclusive = (1024L), IsPositive = (true) });
})
.AddAttribute("rows", a => a.Rows, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (1L), MaxInclusive = (1024L), IsPositive = (true) });
})
.AddAttribute("itemWidth", a => a.ItemWidth, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (1L), MaxInclusive = (4096L), IsPositive = (true) });
})
.AddAttribute("itemHeight", a => a.ItemHeight, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (1L), MaxInclusive = (4096L), IsPositive = (true) });
})
.AddAttribute("getItemWidth", a => a.GetItemWidth, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getItemHeight", a => a.GetItemHeight, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("showItemLabel", a => a.ShowItemLabel)
.AddAttribute("onAction", a => a.OnAction, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("enabled", a => a.Enabled)
.AddAttribute("getEnabled", a => a.GetEnabled, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("image", a => a.Image, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("imageMso", a => a.ImageMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getImage", a => a.GetImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("showItemImage", a => a.ShowItemImage)
.AddAttribute("getItemCount", a => a.GetItemCount, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getItemLabel", a => a.GetItemLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getItemScreentip", a => a.GetItemScreentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getItemSupertip", a => a.GetItemSupertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getItemImage", a => a.GetItemImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getItemID", a => a.GetItemID, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("sizeString", a => a.SizeString, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getSelectedItemID", a => a.GetSelectedItemID, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getSelectedItemIndex", a => a.GetSelectedItemIndex, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idQ", a => a.IdQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("screentip", a => a.Screentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getScreentip", a => a.GetScreentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("supertip", a => a.Supertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getSupertip", a => a.GetSupertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterQ", a => a.InsertAfterQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeQ", a => a.InsertBeforeQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("visible", a => a.Visible)
.AddAttribute("getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("keytip", a => a.Keytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), MinLength = (1L), MaxLength = (3L) });
})
.AddAttribute("getKeytip", a => a.GetKeytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("showLabel", a => a.ShowLabel)
.AddAttribute("getShowLabel", a => a.GetShowLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("showImage", a => a.ShowImage)
.AddAttribute("getShowImage", a => a.GetShowImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.Item), 0, 1000),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton), 0, 16)
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<UnsizedGallery>(deep);
    }

    /// <summary>
    /// <para>Defines the UnsizedToggleButton Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:toggleButton.</para>
    /// </summary>
    [SchemaAttr("mso:toggleButton")]
    public partial class UnsizedToggleButton : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the UnsizedToggleButton class.
        /// </summary>
        public UnsizedToggleButton() : base()
        {
        }

        /// <summary>
        /// <para>getPressed</para>
        /// <para>Represents the following attribute in the schema: getPressed</para>
        /// </summary>
        [SchemaAttr("getPressed")]
        public StringValue? GetPressed
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>onAction</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        [SchemaAttr("onAction")]
        public StringValue? OnAction
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [SchemaAttr("getEnabled")]
        public StringValue? GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>description</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [SchemaAttr("description")]
        public StringValue? Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getDescription</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [SchemaAttr("getDescription")]
        public StringValue? GetDescription
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [SchemaAttr("image")]
        public StringValue? Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [SchemaAttr("imageMso")]
        public StringValue? ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [SchemaAttr("getImage")]
        public StringValue? GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? IdQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [SchemaAttr("idMso")]
        public StringValue? IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [SchemaAttr("screentip")]
        public StringValue? Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [SchemaAttr("getScreentip")]
        public StringValue? GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [SchemaAttr("supertip")]
        public StringValue? Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [SchemaAttr("getSupertip")]
        public StringValue? GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [SchemaAttr("getLabel")]
        public StringValue? GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [SchemaAttr("insertAfterMso")]
        public StringValue? InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [SchemaAttr("insertBeforeMso")]
        public StringValue? InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [SchemaAttr("insertAfterQ")]
        public StringValue? InsertAfterQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [SchemaAttr("insertBeforeQ")]
        public StringValue? InsertBeforeQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [SchemaAttr("keytip")]
        public StringValue? Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [SchemaAttr("getKeytip")]
        public StringValue? GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr("showLabel")]
        public BooleanValue? ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [SchemaAttr("getShowLabel")]
        public StringValue? GetShowLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showImage</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr("showImage")]
        public BooleanValue? ShowImage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowImage</para>
        /// <para>Represents the following attribute in the schema: getShowImage</para>
        /// </summary>
        [SchemaAttr("getShowImage")]
        public StringValue? GetShowImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso:toggleButton");
            builder.AddElement<UnsizedToggleButton>()
.AddAttribute("getPressed", a => a.GetPressed, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("onAction", a => a.OnAction, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("enabled", a => a.Enabled)
.AddAttribute("getEnabled", a => a.GetEnabled, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("description", a => a.Description, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (4096L) });
})
.AddAttribute("getDescription", a => a.GetDescription, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("image", a => a.Image, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("imageMso", a => a.ImageMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getImage", a => a.GetImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idQ", a => a.IdQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("screentip", a => a.Screentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getScreentip", a => a.GetScreentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("supertip", a => a.Supertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getSupertip", a => a.GetSupertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterQ", a => a.InsertAfterQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeQ", a => a.InsertBeforeQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("visible", a => a.Visible)
.AddAttribute("getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("keytip", a => a.Keytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), MinLength = (1L), MaxLength = (3L) });
})
.AddAttribute("getKeytip", a => a.GetKeytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("showLabel", a => a.ShowLabel)
.AddAttribute("getShowLabel", a => a.GetShowLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("showImage", a => a.ShowImage)
.AddAttribute("getShowImage", a => a.GetShowImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<UnsizedToggleButton>(deep);
    }

    /// <summary>
    /// <para>Defines the MenuSeparator Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:menuSeparator.</para>
    /// </summary>
    [SchemaAttr("mso:menuSeparator")]
    public partial class MenuSeparator : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the MenuSeparator class.
        /// </summary>
        public MenuSeparator() : base()
        {
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? IdQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [SchemaAttr("insertAfterMso")]
        public StringValue? InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [SchemaAttr("insertBeforeMso")]
        public StringValue? InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [SchemaAttr("insertAfterQ")]
        public StringValue? InsertAfterQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [SchemaAttr("insertBeforeQ")]
        public StringValue? InsertBeforeQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>title</para>
        /// <para>Represents the following attribute in the schema: title</para>
        /// </summary>
        [SchemaAttr("title")]
        public StringValue? Title
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getTitle</para>
        /// <para>Represents the following attribute in the schema: getTitle</para>
        /// </summary>
        [SchemaAttr("getTitle")]
        public StringValue? GetTitle
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso:menuSeparator");
            builder.AddElement<MenuSeparator>()
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idQ", a => a.IdQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterQ", a => a.InsertAfterQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeQ", a => a.InsertBeforeQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("title", a => a.Title, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getTitle", a => a.GetTitle, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MenuSeparator>(deep);
    }

    /// <summary>
    /// <para>Defines the UnsizedSplitButton Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:splitButton.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu" /> <c>&lt;mso:menu></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.VisibleButton" /> <c>&lt;mso:button></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.VisibleToggleButton" /> <c>&lt;mso:toggleButton></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso:splitButton")]
    public partial class UnsizedSplitButton : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the UnsizedSplitButton class.
        /// </summary>
        public UnsizedSplitButton() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the UnsizedSplitButton class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public UnsizedSplitButton(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the UnsizedSplitButton class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public UnsizedSplitButton(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the UnsizedSplitButton class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public UnsizedSplitButton(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>enabled</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [SchemaAttr("getEnabled")]
        public StringValue? GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? IdQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [SchemaAttr("idMso")]
        public StringValue? IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [SchemaAttr("insertAfterMso")]
        public StringValue? InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [SchemaAttr("insertBeforeMso")]
        public StringValue? InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [SchemaAttr("insertAfterQ")]
        public StringValue? InsertAfterQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [SchemaAttr("insertBeforeQ")]
        public StringValue? InsertBeforeQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [SchemaAttr("keytip")]
        public StringValue? Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [SchemaAttr("getKeytip")]
        public StringValue? GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr("showLabel")]
        public BooleanValue? ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [SchemaAttr("getShowLabel")]
        public StringValue? GetShowLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso:splitButton");
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.VisibleButton>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.VisibleToggleButton>();
            builder.AddElement<UnsizedSplitButton>()
.AddAttribute("enabled", a => a.Enabled)
.AddAttribute("getEnabled", a => a.GetEnabled, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idQ", a => a.IdQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterQ", a => a.InsertAfterQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeQ", a => a.InsertBeforeQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("visible", a => a.Visible)
.AddAttribute("getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("keytip", a => a.Keytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), MinLength = (1L), MaxLength = (3L) });
})
.AddAttribute("getKeytip", a => a.GetKeytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("showLabel", a => a.ShowLabel)
.AddAttribute("getShowLabel", a => a.GetShowLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Sequence, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 0, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.VisibleButton), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.VisibleToggleButton), 1, 1)
                    },
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu), 1, 1)
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<UnsizedSplitButton>(deep);
    }

    /// <summary>
    /// <para>Defines the UnsizedMenu Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:menu.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton" /> <c>&lt;mso:button></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.CheckBox" /> <c>&lt;mso:checkBox></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.UnsizedControlClone" /> <c>&lt;mso:control></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.UnsizedDynamicMenu" /> <c>&lt;mso:dynamicMenu></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery" /> <c>&lt;mso:gallery></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu" /> <c>&lt;mso:menu></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.MenuSeparator" /> <c>&lt;mso:menuSeparator></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.UnsizedSplitButton" /> <c>&lt;mso:splitButton></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.UnsizedToggleButton" /> <c>&lt;mso:toggleButton></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso:menu")]
    public partial class UnsizedMenu : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the UnsizedMenu class.
        /// </summary>
        public UnsizedMenu() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the UnsizedMenu class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public UnsizedMenu(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the UnsizedMenu class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public UnsizedMenu(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the UnsizedMenu class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public UnsizedMenu(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>itemSize</para>
        /// <para>Represents the following attribute in the schema: itemSize</para>
        /// </summary>
        [SchemaAttr("itemSize")]
        public EnumValue<DocumentFormat.OpenXml.Office.CustomUI.ItemSizeValues>? ItemSize
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office.CustomUI.ItemSizeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>description</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [SchemaAttr("description")]
        public StringValue? Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getDescription</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [SchemaAttr("getDescription")]
        public StringValue? GetDescription
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? IdQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [SchemaAttr("idMso")]
        public StringValue? IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [SchemaAttr("image")]
        public StringValue? Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [SchemaAttr("imageMso")]
        public StringValue? ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [SchemaAttr("getImage")]
        public StringValue? GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [SchemaAttr("screentip")]
        public StringValue? Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [SchemaAttr("getScreentip")]
        public StringValue? GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [SchemaAttr("supertip")]
        public StringValue? Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [SchemaAttr("getSupertip")]
        public StringValue? GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [SchemaAttr("getEnabled")]
        public StringValue? GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [SchemaAttr("getLabel")]
        public StringValue? GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [SchemaAttr("insertAfterMso")]
        public StringValue? InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [SchemaAttr("insertBeforeMso")]
        public StringValue? InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [SchemaAttr("insertAfterQ")]
        public StringValue? InsertAfterQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [SchemaAttr("insertBeforeQ")]
        public StringValue? InsertBeforeQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [SchemaAttr("keytip")]
        public StringValue? Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [SchemaAttr("getKeytip")]
        public StringValue? GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr("showLabel")]
        public BooleanValue? ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [SchemaAttr("getShowLabel")]
        public StringValue? GetShowLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showImage</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr("showImage")]
        public BooleanValue? ShowImage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowImage</para>
        /// <para>Represents the following attribute in the schema: getShowImage</para>
        /// </summary>
        [SchemaAttr("getShowImage")]
        public StringValue? GetShowImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso:menu");
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.CheckBox>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedControlClone>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedDynamicMenu>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.MenuSeparator>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedSplitButton>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedToggleButton>();
            builder.AddElement<UnsizedMenu>()
.AddAttribute("itemSize", a => a.ItemSize)
.AddAttribute("description", a => a.Description, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (4096L) });
})
.AddAttribute("getDescription", a => a.GetDescription, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idQ", a => a.IdQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("image", a => a.Image, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("imageMso", a => a.ImageMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getImage", a => a.GetImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("screentip", a => a.Screentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getScreentip", a => a.GetScreentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("supertip", a => a.Supertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getSupertip", a => a.GetSupertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("enabled", a => a.Enabled)
.AddAttribute("getEnabled", a => a.GetEnabled, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterQ", a => a.InsertAfterQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeQ", a => a.InsertBeforeQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("visible", a => a.Visible)
.AddAttribute("getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("keytip", a => a.Keytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), MinLength = (1L), MaxLength = (3L) });
})
.AddAttribute("getKeytip", a => a.GetKeytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("showLabel", a => a.ShowLabel)
.AddAttribute("getShowLabel", a => a.GetShowLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("showImage", a => a.ShowImage)
.AddAttribute("getShowImage", a => a.GetShowImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 0, 1000)
                    {
                        new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                        {
                            new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                            {
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedControlClone), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.CheckBox), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedToggleButton), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.MenuSeparator), 1, 1)
                            }
                        },
                        new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                        {
                            new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                            {
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedSplitButton), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedDynamicMenu), 1, 1)
                            }
                        }
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<UnsizedMenu>(deep);
    }

    /// <summary>
    /// <para>Defines the UnsizedDynamicMenu Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:dynamicMenu.</para>
    /// </summary>
    [SchemaAttr("mso:dynamicMenu")]
    public partial class UnsizedDynamicMenu : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the UnsizedDynamicMenu class.
        /// </summary>
        public UnsizedDynamicMenu() : base()
        {
        }

        /// <summary>
        /// <para>description</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [SchemaAttr("description")]
        public StringValue? Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getDescription</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [SchemaAttr("getDescription")]
        public StringValue? GetDescription
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? IdQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [SchemaAttr("idMso")]
        public StringValue? IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getContent</para>
        /// <para>Represents the following attribute in the schema: getContent</para>
        /// </summary>
        [SchemaAttr("getContent")]
        public StringValue? GetContent
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>invalidateContentOnDrop</para>
        /// <para>Represents the following attribute in the schema: invalidateContentOnDrop</para>
        /// </summary>
        [SchemaAttr("invalidateContentOnDrop")]
        public BooleanValue? InvalidateContentOnDrop
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [SchemaAttr("image")]
        public StringValue? Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [SchemaAttr("imageMso")]
        public StringValue? ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [SchemaAttr("getImage")]
        public StringValue? GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [SchemaAttr("screentip")]
        public StringValue? Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [SchemaAttr("getScreentip")]
        public StringValue? GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [SchemaAttr("supertip")]
        public StringValue? Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [SchemaAttr("getSupertip")]
        public StringValue? GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [SchemaAttr("getEnabled")]
        public StringValue? GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [SchemaAttr("getLabel")]
        public StringValue? GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [SchemaAttr("insertAfterMso")]
        public StringValue? InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [SchemaAttr("insertBeforeMso")]
        public StringValue? InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [SchemaAttr("insertAfterQ")]
        public StringValue? InsertAfterQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [SchemaAttr("insertBeforeQ")]
        public StringValue? InsertBeforeQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [SchemaAttr("keytip")]
        public StringValue? Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [SchemaAttr("getKeytip")]
        public StringValue? GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr("showLabel")]
        public BooleanValue? ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [SchemaAttr("getShowLabel")]
        public StringValue? GetShowLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showImage</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr("showImage")]
        public BooleanValue? ShowImage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowImage</para>
        /// <para>Represents the following attribute in the schema: getShowImage</para>
        /// </summary>
        [SchemaAttr("getShowImage")]
        public StringValue? GetShowImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso:dynamicMenu");
            builder.AddElement<UnsizedDynamicMenu>()
.AddAttribute("description", a => a.Description, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (4096L) });
})
.AddAttribute("getDescription", a => a.GetDescription, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idQ", a => a.IdQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getContent", a => a.GetContent, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("invalidateContentOnDrop", a => a.InvalidateContentOnDrop)
.AddAttribute("image", a => a.Image, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("imageMso", a => a.ImageMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getImage", a => a.GetImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("screentip", a => a.Screentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getScreentip", a => a.GetScreentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("supertip", a => a.Supertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getSupertip", a => a.GetSupertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("enabled", a => a.Enabled)
.AddAttribute("getEnabled", a => a.GetEnabled, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterQ", a => a.InsertAfterQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeQ", a => a.InsertBeforeQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("visible", a => a.Visible)
.AddAttribute("getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("keytip", a => a.Keytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), MinLength = (1L), MaxLength = (3L) });
})
.AddAttribute("getKeytip", a => a.GetKeytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("showLabel", a => a.ShowLabel)
.AddAttribute("getShowLabel", a => a.GetShowLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("showImage", a => a.ShowImage)
.AddAttribute("getShowImage", a => a.GetShowImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<UnsizedDynamicMenu>(deep);
    }

    /// <summary>
    /// <para>Defines the SplitButtonWithTitle Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:splitButton.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.MenuWithTitle" /> <c>&lt;mso:menu></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.VisibleButton" /> <c>&lt;mso:button></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.VisibleToggleButton" /> <c>&lt;mso:toggleButton></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso:splitButton")]
    public partial class SplitButtonWithTitle : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SplitButtonWithTitle class.
        /// </summary>
        public SplitButtonWithTitle() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SplitButtonWithTitle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SplitButtonWithTitle(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SplitButtonWithTitle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SplitButtonWithTitle(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SplitButtonWithTitle class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SplitButtonWithTitle(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>enabled</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [SchemaAttr("getEnabled")]
        public StringValue? GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? IdQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [SchemaAttr("idMso")]
        public StringValue? IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [SchemaAttr("insertAfterMso")]
        public StringValue? InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [SchemaAttr("insertBeforeMso")]
        public StringValue? InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [SchemaAttr("insertAfterQ")]
        public StringValue? InsertAfterQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [SchemaAttr("insertBeforeQ")]
        public StringValue? InsertBeforeQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [SchemaAttr("keytip")]
        public StringValue? Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [SchemaAttr("getKeytip")]
        public StringValue? GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr("showLabel")]
        public BooleanValue? ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [SchemaAttr("getShowLabel")]
        public StringValue? GetShowLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso:splitButton");
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.MenuWithTitle>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.VisibleButton>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.VisibleToggleButton>();
            builder.AddElement<SplitButtonWithTitle>()
.AddAttribute("enabled", a => a.Enabled)
.AddAttribute("getEnabled", a => a.GetEnabled, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idQ", a => a.IdQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterQ", a => a.InsertAfterQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeQ", a => a.InsertBeforeQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("visible", a => a.Visible)
.AddAttribute("getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("keytip", a => a.Keytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), MinLength = (1L), MaxLength = (3L) });
})
.AddAttribute("getKeytip", a => a.GetKeytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("showLabel", a => a.ShowLabel)
.AddAttribute("getShowLabel", a => a.GetShowLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Sequence, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 0, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.VisibleButton), 1, 1),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.VisibleToggleButton), 1, 1)
                    },
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.MenuWithTitle), 1, 1)
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SplitButtonWithTitle>(deep);
    }

    /// <summary>
    /// <para>Defines the MenuWithTitle Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:menu.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton" /> <c>&lt;mso:button></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.CheckBox" /> <c>&lt;mso:checkBox></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.UnsizedControlClone" /> <c>&lt;mso:control></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.UnsizedDynamicMenu" /> <c>&lt;mso:dynamicMenu></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery" /> <c>&lt;mso:gallery></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.MenuSeparator" /> <c>&lt;mso:menuSeparator></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.MenuWithTitle" /> <c>&lt;mso:menu></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.SplitButtonWithTitle" /> <c>&lt;mso:splitButton></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.UnsizedToggleButton" /> <c>&lt;mso:toggleButton></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso:menu")]
    public partial class MenuWithTitle : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the MenuWithTitle class.
        /// </summary>
        public MenuWithTitle() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the MenuWithTitle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MenuWithTitle(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MenuWithTitle class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MenuWithTitle(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MenuWithTitle class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public MenuWithTitle(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? IdQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [SchemaAttr("idMso")]
        public StringValue? IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>itemSize</para>
        /// <para>Represents the following attribute in the schema: itemSize</para>
        /// </summary>
        [SchemaAttr("itemSize")]
        public EnumValue<DocumentFormat.OpenXml.Office.CustomUI.ItemSizeValues>? ItemSize
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office.CustomUI.ItemSizeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>title</para>
        /// <para>Represents the following attribute in the schema: title</para>
        /// </summary>
        [SchemaAttr("title")]
        public StringValue? Title
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getTitle</para>
        /// <para>Represents the following attribute in the schema: getTitle</para>
        /// </summary>
        [SchemaAttr("getTitle")]
        public StringValue? GetTitle
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [SchemaAttr("image")]
        public StringValue? Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [SchemaAttr("imageMso")]
        public StringValue? ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [SchemaAttr("getImage")]
        public StringValue? GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [SchemaAttr("screentip")]
        public StringValue? Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [SchemaAttr("getScreentip")]
        public StringValue? GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [SchemaAttr("supertip")]
        public StringValue? Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [SchemaAttr("getSupertip")]
        public StringValue? GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [SchemaAttr("getEnabled")]
        public StringValue? GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [SchemaAttr("getLabel")]
        public StringValue? GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [SchemaAttr("insertAfterMso")]
        public StringValue? InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [SchemaAttr("insertBeforeMso")]
        public StringValue? InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [SchemaAttr("insertAfterQ")]
        public StringValue? InsertAfterQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [SchemaAttr("insertBeforeQ")]
        public StringValue? InsertBeforeQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [SchemaAttr("keytip")]
        public StringValue? Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [SchemaAttr("getKeytip")]
        public StringValue? GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr("showLabel")]
        public BooleanValue? ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [SchemaAttr("getShowLabel")]
        public StringValue? GetShowLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showImage</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr("showImage")]
        public BooleanValue? ShowImage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowImage</para>
        /// <para>Represents the following attribute in the schema: getShowImage</para>
        /// </summary>
        [SchemaAttr("getShowImage")]
        public StringValue? GetShowImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso:menu");
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.CheckBox>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedControlClone>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedDynamicMenu>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.MenuSeparator>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.MenuWithTitle>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.SplitButtonWithTitle>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedToggleButton>();
            builder.AddElement<MenuWithTitle>()
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idQ", a => a.IdQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("itemSize", a => a.ItemSize)
.AddAttribute("title", a => a.Title, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getTitle", a => a.GetTitle, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("image", a => a.Image, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("imageMso", a => a.ImageMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getImage", a => a.GetImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("screentip", a => a.Screentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getScreentip", a => a.GetScreentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("supertip", a => a.Supertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getSupertip", a => a.GetSupertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("enabled", a => a.Enabled)
.AddAttribute("getEnabled", a => a.GetEnabled, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterQ", a => a.InsertAfterQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeQ", a => a.InsertBeforeQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("visible", a => a.Visible)
.AddAttribute("getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("keytip", a => a.Keytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), MinLength = (1L), MaxLength = (3L) });
})
.AddAttribute("getKeytip", a => a.GetKeytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("showLabel", a => a.ShowLabel)
.AddAttribute("getShowLabel", a => a.GetShowLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("showImage", a => a.ShowImage)
.AddAttribute("getShowImage", a => a.GetShowImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 0, 1000)
                    {
                        new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                        {
                            new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                            {
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedControlClone), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.CheckBox), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedToggleButton), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.MenuSeparator), 1, 1)
                            }
                        },
                        new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                        {
                            new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                            {
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.SplitButtonWithTitle), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.MenuWithTitle), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedDynamicMenu), 1, 1)
                            }
                        }
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MenuWithTitle>(deep);
    }

    /// <summary>
    /// <para>Defines the ControlClone Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:control.</para>
    /// </summary>
    [SchemaAttr("mso:control")]
    public partial class ControlClone : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ControlClone class.
        /// </summary>
        public ControlClone() : base()
        {
        }

        /// <summary>
        /// <para>size</para>
        /// <para>Represents the following attribute in the schema: size</para>
        /// </summary>
        [SchemaAttr("size")]
        public EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues>? Size
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSize</para>
        /// <para>Represents the following attribute in the schema: getSize</para>
        /// </summary>
        [SchemaAttr("getSize")]
        public StringValue? GetSize
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [SchemaAttr("getEnabled")]
        public StringValue? GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>description</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [SchemaAttr("description")]
        public StringValue? Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getDescription</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [SchemaAttr("getDescription")]
        public StringValue? GetDescription
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [SchemaAttr("image")]
        public StringValue? Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [SchemaAttr("imageMso")]
        public StringValue? ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [SchemaAttr("getImage")]
        public StringValue? GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? IdQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [SchemaAttr("idMso")]
        public StringValue? IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [SchemaAttr("screentip")]
        public StringValue? Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [SchemaAttr("getScreentip")]
        public StringValue? GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [SchemaAttr("supertip")]
        public StringValue? Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [SchemaAttr("getSupertip")]
        public StringValue? GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [SchemaAttr("getLabel")]
        public StringValue? GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [SchemaAttr("insertAfterMso")]
        public StringValue? InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [SchemaAttr("insertBeforeMso")]
        public StringValue? InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [SchemaAttr("insertAfterQ")]
        public StringValue? InsertAfterQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [SchemaAttr("insertBeforeQ")]
        public StringValue? InsertBeforeQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [SchemaAttr("keytip")]
        public StringValue? Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [SchemaAttr("getKeytip")]
        public StringValue? GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr("showLabel")]
        public BooleanValue? ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [SchemaAttr("getShowLabel")]
        public StringValue? GetShowLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showImage</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr("showImage")]
        public BooleanValue? ShowImage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowImage</para>
        /// <para>Represents the following attribute in the schema: getShowImage</para>
        /// </summary>
        [SchemaAttr("getShowImage")]
        public StringValue? GetShowImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso:control");
            builder.AddElement<ControlClone>()
.AddAttribute("size", a => a.Size)
.AddAttribute("getSize", a => a.GetSize, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("enabled", a => a.Enabled)
.AddAttribute("getEnabled", a => a.GetEnabled, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("description", a => a.Description, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (4096L) });
})
.AddAttribute("getDescription", a => a.GetDescription, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("image", a => a.Image, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("imageMso", a => a.ImageMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getImage", a => a.GetImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idQ", a => a.IdQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("screentip", a => a.Screentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getScreentip", a => a.GetScreentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("supertip", a => a.Supertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getSupertip", a => a.GetSupertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterQ", a => a.InsertAfterQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeQ", a => a.InsertBeforeQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("visible", a => a.Visible)
.AddAttribute("getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("keytip", a => a.Keytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), MinLength = (1L), MaxLength = (3L) });
})
.AddAttribute("getKeytip", a => a.GetKeytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("showLabel", a => a.ShowLabel)
.AddAttribute("getShowLabel", a => a.GetShowLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("showImage", a => a.ShowImage)
.AddAttribute("getShowImage", a => a.GetShowImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ControlClone>(deep);
    }

    /// <summary>
    /// <para>Defines the TextLabel Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:labelControl.</para>
    /// </summary>
    [SchemaAttr("mso:labelControl")]
    public partial class TextLabel : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the TextLabel class.
        /// </summary>
        public TextLabel() : base()
        {
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? IdQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [SchemaAttr("idMso")]
        public StringValue? IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [SchemaAttr("screentip")]
        public StringValue? Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [SchemaAttr("getScreentip")]
        public StringValue? GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [SchemaAttr("supertip")]
        public StringValue? Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [SchemaAttr("getSupertip")]
        public StringValue? GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [SchemaAttr("getEnabled")]
        public StringValue? GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [SchemaAttr("getLabel")]
        public StringValue? GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [SchemaAttr("insertAfterMso")]
        public StringValue? InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [SchemaAttr("insertBeforeMso")]
        public StringValue? InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [SchemaAttr("insertAfterQ")]
        public StringValue? InsertAfterQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [SchemaAttr("insertBeforeQ")]
        public StringValue? InsertBeforeQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr("showLabel")]
        public BooleanValue? ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [SchemaAttr("getShowLabel")]
        public StringValue? GetShowLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso:labelControl");
            builder.AddElement<TextLabel>()
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idQ", a => a.IdQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("screentip", a => a.Screentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getScreentip", a => a.GetScreentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("supertip", a => a.Supertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getSupertip", a => a.GetSupertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("enabled", a => a.Enabled)
.AddAttribute("getEnabled", a => a.GetEnabled, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterQ", a => a.InsertAfterQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeQ", a => a.InsertBeforeQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("visible", a => a.Visible)
.AddAttribute("getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("showLabel", a => a.ShowLabel)
.AddAttribute("getShowLabel", a => a.GetShowLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TextLabel>(deep);
    }

    /// <summary>
    /// <para>Defines the Button Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:button.</para>
    /// </summary>
    [SchemaAttr("mso:button")]
    public partial class Button : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Button class.
        /// </summary>
        public Button() : base()
        {
        }

        /// <summary>
        /// <para>size</para>
        /// <para>Represents the following attribute in the schema: size</para>
        /// </summary>
        [SchemaAttr("size")]
        public EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues>? Size
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSize</para>
        /// <para>Represents the following attribute in the schema: getSize</para>
        /// </summary>
        [SchemaAttr("getSize")]
        public StringValue? GetSize
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>onAction</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        [SchemaAttr("onAction")]
        public StringValue? OnAction
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [SchemaAttr("getEnabled")]
        public StringValue? GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>description</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [SchemaAttr("description")]
        public StringValue? Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getDescription</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [SchemaAttr("getDescription")]
        public StringValue? GetDescription
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [SchemaAttr("image")]
        public StringValue? Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [SchemaAttr("imageMso")]
        public StringValue? ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [SchemaAttr("getImage")]
        public StringValue? GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? IdQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [SchemaAttr("idMso")]
        public StringValue? IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [SchemaAttr("screentip")]
        public StringValue? Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [SchemaAttr("getScreentip")]
        public StringValue? GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [SchemaAttr("supertip")]
        public StringValue? Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [SchemaAttr("getSupertip")]
        public StringValue? GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [SchemaAttr("getLabel")]
        public StringValue? GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [SchemaAttr("insertAfterMso")]
        public StringValue? InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [SchemaAttr("insertBeforeMso")]
        public StringValue? InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [SchemaAttr("insertAfterQ")]
        public StringValue? InsertAfterQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [SchemaAttr("insertBeforeQ")]
        public StringValue? InsertBeforeQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [SchemaAttr("keytip")]
        public StringValue? Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [SchemaAttr("getKeytip")]
        public StringValue? GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr("showLabel")]
        public BooleanValue? ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [SchemaAttr("getShowLabel")]
        public StringValue? GetShowLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showImage</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr("showImage")]
        public BooleanValue? ShowImage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowImage</para>
        /// <para>Represents the following attribute in the schema: getShowImage</para>
        /// </summary>
        [SchemaAttr("getShowImage")]
        public StringValue? GetShowImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso:button");
            builder.AddElement<Button>()
.AddAttribute("size", a => a.Size)
.AddAttribute("getSize", a => a.GetSize, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("onAction", a => a.OnAction, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("enabled", a => a.Enabled)
.AddAttribute("getEnabled", a => a.GetEnabled, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("description", a => a.Description, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (4096L) });
})
.AddAttribute("getDescription", a => a.GetDescription, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("image", a => a.Image, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("imageMso", a => a.ImageMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getImage", a => a.GetImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idQ", a => a.IdQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("screentip", a => a.Screentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getScreentip", a => a.GetScreentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("supertip", a => a.Supertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getSupertip", a => a.GetSupertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterQ", a => a.InsertAfterQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeQ", a => a.InsertBeforeQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("visible", a => a.Visible)
.AddAttribute("getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("keytip", a => a.Keytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), MinLength = (1L), MaxLength = (3L) });
})
.AddAttribute("getKeytip", a => a.GetKeytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("showLabel", a => a.ShowLabel)
.AddAttribute("getShowLabel", a => a.GetShowLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("showImage", a => a.ShowImage)
.AddAttribute("getShowImage", a => a.GetShowImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Button>(deep);
    }

    /// <summary>
    /// <para>Defines the ToggleButton Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:toggleButton.</para>
    /// </summary>
    [SchemaAttr("mso:toggleButton")]
    public partial class ToggleButton : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ToggleButton class.
        /// </summary>
        public ToggleButton() : base()
        {
        }

        /// <summary>
        /// <para>size</para>
        /// <para>Represents the following attribute in the schema: size</para>
        /// </summary>
        [SchemaAttr("size")]
        public EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues>? Size
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSize</para>
        /// <para>Represents the following attribute in the schema: getSize</para>
        /// </summary>
        [SchemaAttr("getSize")]
        public StringValue? GetSize
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getPressed</para>
        /// <para>Represents the following attribute in the schema: getPressed</para>
        /// </summary>
        [SchemaAttr("getPressed")]
        public StringValue? GetPressed
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>onAction</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        [SchemaAttr("onAction")]
        public StringValue? OnAction
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [SchemaAttr("getEnabled")]
        public StringValue? GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>description</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [SchemaAttr("description")]
        public StringValue? Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getDescription</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [SchemaAttr("getDescription")]
        public StringValue? GetDescription
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [SchemaAttr("image")]
        public StringValue? Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [SchemaAttr("imageMso")]
        public StringValue? ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [SchemaAttr("getImage")]
        public StringValue? GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? IdQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [SchemaAttr("idMso")]
        public StringValue? IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [SchemaAttr("screentip")]
        public StringValue? Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [SchemaAttr("getScreentip")]
        public StringValue? GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [SchemaAttr("supertip")]
        public StringValue? Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [SchemaAttr("getSupertip")]
        public StringValue? GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [SchemaAttr("getLabel")]
        public StringValue? GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [SchemaAttr("insertAfterMso")]
        public StringValue? InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [SchemaAttr("insertBeforeMso")]
        public StringValue? InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [SchemaAttr("insertAfterQ")]
        public StringValue? InsertAfterQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [SchemaAttr("insertBeforeQ")]
        public StringValue? InsertBeforeQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [SchemaAttr("keytip")]
        public StringValue? Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [SchemaAttr("getKeytip")]
        public StringValue? GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr("showLabel")]
        public BooleanValue? ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [SchemaAttr("getShowLabel")]
        public StringValue? GetShowLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showImage</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr("showImage")]
        public BooleanValue? ShowImage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowImage</para>
        /// <para>Represents the following attribute in the schema: getShowImage</para>
        /// </summary>
        [SchemaAttr("getShowImage")]
        public StringValue? GetShowImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso:toggleButton");
            builder.AddElement<ToggleButton>()
.AddAttribute("size", a => a.Size)
.AddAttribute("getSize", a => a.GetSize, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getPressed", a => a.GetPressed, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("onAction", a => a.OnAction, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("enabled", a => a.Enabled)
.AddAttribute("getEnabled", a => a.GetEnabled, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("description", a => a.Description, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (4096L) });
})
.AddAttribute("getDescription", a => a.GetDescription, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("image", a => a.Image, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("imageMso", a => a.ImageMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getImage", a => a.GetImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idQ", a => a.IdQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("screentip", a => a.Screentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getScreentip", a => a.GetScreentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("supertip", a => a.Supertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getSupertip", a => a.GetSupertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterQ", a => a.InsertAfterQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeQ", a => a.InsertBeforeQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("visible", a => a.Visible)
.AddAttribute("getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("keytip", a => a.Keytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), MinLength = (1L), MaxLength = (3L) });
})
.AddAttribute("getKeytip", a => a.GetKeytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("showLabel", a => a.ShowLabel)
.AddAttribute("getShowLabel", a => a.GetShowLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("showImage", a => a.ShowImage)
.AddAttribute("getShowImage", a => a.GetShowImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ToggleButton>(deep);
    }

    /// <summary>
    /// <para>Defines the EditBox Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:editBox.</para>
    /// </summary>
    [SchemaAttr("mso:editBox")]
    public partial class EditBox : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the EditBox class.
        /// </summary>
        public EditBox() : base()
        {
        }

        /// <summary>
        /// <para>enabled</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [SchemaAttr("getEnabled")]
        public StringValue? GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [SchemaAttr("image")]
        public StringValue? Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [SchemaAttr("imageMso")]
        public StringValue? ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [SchemaAttr("getImage")]
        public StringValue? GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>maxLength</para>
        /// <para>Represents the following attribute in the schema: maxLength</para>
        /// </summary>
        [SchemaAttr("maxLength")]
        public IntegerValue? MaxLength
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getText</para>
        /// <para>Represents the following attribute in the schema: getText</para>
        /// </summary>
        [SchemaAttr("getText")]
        public StringValue? GetText
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>onChange</para>
        /// <para>Represents the following attribute in the schema: onChange</para>
        /// </summary>
        [SchemaAttr("onChange")]
        public StringValue? OnChange
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sizeString</para>
        /// <para>Represents the following attribute in the schema: sizeString</para>
        /// </summary>
        [SchemaAttr("sizeString")]
        public StringValue? SizeString
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? IdQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [SchemaAttr("idMso")]
        public StringValue? IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [SchemaAttr("screentip")]
        public StringValue? Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [SchemaAttr("getScreentip")]
        public StringValue? GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [SchemaAttr("supertip")]
        public StringValue? Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [SchemaAttr("getSupertip")]
        public StringValue? GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [SchemaAttr("getLabel")]
        public StringValue? GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [SchemaAttr("insertAfterMso")]
        public StringValue? InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [SchemaAttr("insertBeforeMso")]
        public StringValue? InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [SchemaAttr("insertAfterQ")]
        public StringValue? InsertAfterQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [SchemaAttr("insertBeforeQ")]
        public StringValue? InsertBeforeQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [SchemaAttr("keytip")]
        public StringValue? Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [SchemaAttr("getKeytip")]
        public StringValue? GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr("showLabel")]
        public BooleanValue? ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [SchemaAttr("getShowLabel")]
        public StringValue? GetShowLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showImage</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr("showImage")]
        public BooleanValue? ShowImage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowImage</para>
        /// <para>Represents the following attribute in the schema: getShowImage</para>
        /// </summary>
        [SchemaAttr("getShowImage")]
        public StringValue? GetShowImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso:editBox");
            builder.AddElement<EditBox>()
.AddAttribute("enabled", a => a.Enabled)
.AddAttribute("getEnabled", a => a.GetEnabled, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("image", a => a.Image, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("imageMso", a => a.ImageMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getImage", a => a.GetImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("maxLength", a => a.MaxLength, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (1L), MaxInclusive = (1024L), IsPositive = (true) });
})
.AddAttribute("getText", a => a.GetText, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("onChange", a => a.OnChange, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("sizeString", a => a.SizeString, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idQ", a => a.IdQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("screentip", a => a.Screentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getScreentip", a => a.GetScreentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("supertip", a => a.Supertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getSupertip", a => a.GetSupertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterQ", a => a.InsertAfterQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeQ", a => a.InsertBeforeQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("visible", a => a.Visible)
.AddAttribute("getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("keytip", a => a.Keytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), MinLength = (1L), MaxLength = (3L) });
})
.AddAttribute("getKeytip", a => a.GetKeytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("showLabel", a => a.ShowLabel)
.AddAttribute("getShowLabel", a => a.GetShowLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("showImage", a => a.ShowImage)
.AddAttribute("getShowImage", a => a.GetShowImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<EditBox>(deep);
    }

    /// <summary>
    /// <para>Defines the ComboBox Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:comboBox.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.Item" /> <c>&lt;mso:item></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso:comboBox")]
    public partial class ComboBox : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ComboBox class.
        /// </summary>
        public ComboBox() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ComboBox class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ComboBox(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ComboBox class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ComboBox(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ComboBox class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ComboBox(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>showItemImage</para>
        /// <para>Represents the following attribute in the schema: showItemImage</para>
        /// </summary>
        [SchemaAttr("showItemImage")]
        public BooleanValue? ShowItemImage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemCount</para>
        /// <para>Represents the following attribute in the schema: getItemCount</para>
        /// </summary>
        [SchemaAttr("getItemCount")]
        public StringValue? GetItemCount
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemLabel</para>
        /// <para>Represents the following attribute in the schema: getItemLabel</para>
        /// </summary>
        [SchemaAttr("getItemLabel")]
        public StringValue? GetItemLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemScreentip</para>
        /// <para>Represents the following attribute in the schema: getItemScreentip</para>
        /// </summary>
        [SchemaAttr("getItemScreentip")]
        public StringValue? GetItemScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemSupertip</para>
        /// <para>Represents the following attribute in the schema: getItemSupertip</para>
        /// </summary>
        [SchemaAttr("getItemSupertip")]
        public StringValue? GetItemSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemImage</para>
        /// <para>Represents the following attribute in the schema: getItemImage</para>
        /// </summary>
        [SchemaAttr("getItemImage")]
        public StringValue? GetItemImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemID</para>
        /// <para>Represents the following attribute in the schema: getItemID</para>
        /// </summary>
        [SchemaAttr("getItemID")]
        public StringValue? GetItemID
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sizeString</para>
        /// <para>Represents the following attribute in the schema: sizeString</para>
        /// </summary>
        [SchemaAttr("sizeString")]
        public StringValue? SizeString
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>invalidateContentOnDrop</para>
        /// <para>Represents the following attribute in the schema: invalidateContentOnDrop</para>
        /// </summary>
        [SchemaAttr("invalidateContentOnDrop")]
        public BooleanValue? InvalidateContentOnDrop
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [SchemaAttr("getEnabled")]
        public StringValue? GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [SchemaAttr("image")]
        public StringValue? Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [SchemaAttr("imageMso")]
        public StringValue? ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [SchemaAttr("getImage")]
        public StringValue? GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>maxLength</para>
        /// <para>Represents the following attribute in the schema: maxLength</para>
        /// </summary>
        [SchemaAttr("maxLength")]
        public IntegerValue? MaxLength
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getText</para>
        /// <para>Represents the following attribute in the schema: getText</para>
        /// </summary>
        [SchemaAttr("getText")]
        public StringValue? GetText
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>onChange</para>
        /// <para>Represents the following attribute in the schema: onChange</para>
        /// </summary>
        [SchemaAttr("onChange")]
        public StringValue? OnChange
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? IdQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [SchemaAttr("idMso")]
        public StringValue? IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [SchemaAttr("screentip")]
        public StringValue? Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [SchemaAttr("getScreentip")]
        public StringValue? GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [SchemaAttr("supertip")]
        public StringValue? Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [SchemaAttr("getSupertip")]
        public StringValue? GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [SchemaAttr("getLabel")]
        public StringValue? GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [SchemaAttr("insertAfterMso")]
        public StringValue? InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [SchemaAttr("insertBeforeMso")]
        public StringValue? InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [SchemaAttr("insertAfterQ")]
        public StringValue? InsertAfterQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [SchemaAttr("insertBeforeQ")]
        public StringValue? InsertBeforeQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [SchemaAttr("keytip")]
        public StringValue? Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [SchemaAttr("getKeytip")]
        public StringValue? GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr("showLabel")]
        public BooleanValue? ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [SchemaAttr("getShowLabel")]
        public StringValue? GetShowLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showImage</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr("showImage")]
        public BooleanValue? ShowImage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowImage</para>
        /// <para>Represents the following attribute in the schema: getShowImage</para>
        /// </summary>
        [SchemaAttr("getShowImage")]
        public StringValue? GetShowImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso:comboBox");
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.Item>();
            builder.AddElement<ComboBox>()
.AddAttribute("showItemImage", a => a.ShowItemImage)
.AddAttribute("getItemCount", a => a.GetItemCount, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getItemLabel", a => a.GetItemLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getItemScreentip", a => a.GetItemScreentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getItemSupertip", a => a.GetItemSupertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getItemImage", a => a.GetItemImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getItemID", a => a.GetItemID, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("sizeString", a => a.SizeString, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("invalidateContentOnDrop", a => a.InvalidateContentOnDrop)
.AddAttribute("enabled", a => a.Enabled)
.AddAttribute("getEnabled", a => a.GetEnabled, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("image", a => a.Image, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("imageMso", a => a.ImageMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getImage", a => a.GetImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("maxLength", a => a.MaxLength, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (1L), MaxInclusive = (1024L), IsPositive = (true) });
})
.AddAttribute("getText", a => a.GetText, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("onChange", a => a.OnChange, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idQ", a => a.IdQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("screentip", a => a.Screentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getScreentip", a => a.GetScreentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("supertip", a => a.Supertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getSupertip", a => a.GetSupertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterQ", a => a.InsertAfterQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeQ", a => a.InsertBeforeQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("visible", a => a.Visible)
.AddAttribute("getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("keytip", a => a.Keytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), MinLength = (1L), MaxLength = (3L) });
})
.AddAttribute("getKeytip", a => a.GetKeytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("showLabel", a => a.ShowLabel)
.AddAttribute("getShowLabel", a => a.GetShowLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("showImage", a => a.ShowImage)
.AddAttribute("getShowImage", a => a.GetShowImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.Item), 0, 1000)
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ComboBox>(deep);
    }

    /// <summary>
    /// <para>Defines the DropDown Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:dropDown.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton" /> <c>&lt;mso:button></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.Item" /> <c>&lt;mso:item></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso:dropDown")]
    public partial class DropDown : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DropDown class.
        /// </summary>
        public DropDown() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DropDown class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DropDown(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DropDown class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DropDown(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DropDown class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DropDown(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>onAction</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        [SchemaAttr("onAction")]
        public StringValue? OnAction
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [SchemaAttr("getEnabled")]
        public StringValue? GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [SchemaAttr("image")]
        public StringValue? Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [SchemaAttr("imageMso")]
        public StringValue? ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [SchemaAttr("getImage")]
        public StringValue? GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showItemImage</para>
        /// <para>Represents the following attribute in the schema: showItemImage</para>
        /// </summary>
        [SchemaAttr("showItemImage")]
        public BooleanValue? ShowItemImage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemCount</para>
        /// <para>Represents the following attribute in the schema: getItemCount</para>
        /// </summary>
        [SchemaAttr("getItemCount")]
        public StringValue? GetItemCount
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemLabel</para>
        /// <para>Represents the following attribute in the schema: getItemLabel</para>
        /// </summary>
        [SchemaAttr("getItemLabel")]
        public StringValue? GetItemLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemScreentip</para>
        /// <para>Represents the following attribute in the schema: getItemScreentip</para>
        /// </summary>
        [SchemaAttr("getItemScreentip")]
        public StringValue? GetItemScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemSupertip</para>
        /// <para>Represents the following attribute in the schema: getItemSupertip</para>
        /// </summary>
        [SchemaAttr("getItemSupertip")]
        public StringValue? GetItemSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemImage</para>
        /// <para>Represents the following attribute in the schema: getItemImage</para>
        /// </summary>
        [SchemaAttr("getItemImage")]
        public StringValue? GetItemImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemID</para>
        /// <para>Represents the following attribute in the schema: getItemID</para>
        /// </summary>
        [SchemaAttr("getItemID")]
        public StringValue? GetItemID
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sizeString</para>
        /// <para>Represents the following attribute in the schema: sizeString</para>
        /// </summary>
        [SchemaAttr("sizeString")]
        public StringValue? SizeString
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSelectedItemID</para>
        /// <para>Represents the following attribute in the schema: getSelectedItemID</para>
        /// </summary>
        [SchemaAttr("getSelectedItemID")]
        public StringValue? GetSelectedItemID
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSelectedItemIndex</para>
        /// <para>Represents the following attribute in the schema: getSelectedItemIndex</para>
        /// </summary>
        [SchemaAttr("getSelectedItemIndex")]
        public StringValue? GetSelectedItemIndex
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showItemLabel</para>
        /// <para>Represents the following attribute in the schema: showItemLabel</para>
        /// </summary>
        [SchemaAttr("showItemLabel")]
        public BooleanValue? ShowItemLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? IdQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [SchemaAttr("idMso")]
        public StringValue? IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [SchemaAttr("screentip")]
        public StringValue? Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [SchemaAttr("getScreentip")]
        public StringValue? GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [SchemaAttr("supertip")]
        public StringValue? Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [SchemaAttr("getSupertip")]
        public StringValue? GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [SchemaAttr("getLabel")]
        public StringValue? GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [SchemaAttr("insertAfterMso")]
        public StringValue? InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [SchemaAttr("insertBeforeMso")]
        public StringValue? InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [SchemaAttr("insertAfterQ")]
        public StringValue? InsertAfterQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [SchemaAttr("insertBeforeQ")]
        public StringValue? InsertBeforeQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [SchemaAttr("keytip")]
        public StringValue? Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [SchemaAttr("getKeytip")]
        public StringValue? GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr("showLabel")]
        public BooleanValue? ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [SchemaAttr("getShowLabel")]
        public StringValue? GetShowLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showImage</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr("showImage")]
        public BooleanValue? ShowImage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowImage</para>
        /// <para>Represents the following attribute in the schema: getShowImage</para>
        /// </summary>
        [SchemaAttr("getShowImage")]
        public StringValue? GetShowImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso:dropDown");
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.Item>();
            builder.AddElement<DropDown>()
.AddAttribute("onAction", a => a.OnAction, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("enabled", a => a.Enabled)
.AddAttribute("getEnabled", a => a.GetEnabled, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("image", a => a.Image, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("imageMso", a => a.ImageMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getImage", a => a.GetImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("showItemImage", a => a.ShowItemImage)
.AddAttribute("getItemCount", a => a.GetItemCount, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getItemLabel", a => a.GetItemLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getItemScreentip", a => a.GetItemScreentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getItemSupertip", a => a.GetItemSupertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getItemImage", a => a.GetItemImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getItemID", a => a.GetItemID, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("sizeString", a => a.SizeString, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getSelectedItemID", a => a.GetSelectedItemID, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getSelectedItemIndex", a => a.GetSelectedItemIndex, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("showItemLabel", a => a.ShowItemLabel)
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idQ", a => a.IdQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("screentip", a => a.Screentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getScreentip", a => a.GetScreentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("supertip", a => a.Supertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getSupertip", a => a.GetSupertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterQ", a => a.InsertAfterQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeQ", a => a.InsertBeforeQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("visible", a => a.Visible)
.AddAttribute("getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("keytip", a => a.Keytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), MinLength = (1L), MaxLength = (3L) });
})
.AddAttribute("getKeytip", a => a.GetKeytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("showLabel", a => a.ShowLabel)
.AddAttribute("getShowLabel", a => a.GetShowLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("showImage", a => a.ShowImage)
.AddAttribute("getShowImage", a => a.GetShowImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.Item), 0, 1000),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton), 0, 16)
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DropDown>(deep);
    }

    /// <summary>
    /// <para>Defines the Gallery Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:gallery.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton" /> <c>&lt;mso:button></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.Item" /> <c>&lt;mso:item></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso:gallery")]
    public partial class Gallery : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Gallery class.
        /// </summary>
        public Gallery() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Gallery class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Gallery(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Gallery class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Gallery(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Gallery class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Gallery(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>size</para>
        /// <para>Represents the following attribute in the schema: size</para>
        /// </summary>
        [SchemaAttr("size")]
        public EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues>? Size
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSize</para>
        /// <para>Represents the following attribute in the schema: getSize</para>
        /// </summary>
        [SchemaAttr("getSize")]
        public StringValue? GetSize
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>description</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [SchemaAttr("description")]
        public StringValue? Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getDescription</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [SchemaAttr("getDescription")]
        public StringValue? GetDescription
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>invalidateContentOnDrop</para>
        /// <para>Represents the following attribute in the schema: invalidateContentOnDrop</para>
        /// </summary>
        [SchemaAttr("invalidateContentOnDrop")]
        public BooleanValue? InvalidateContentOnDrop
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>columns</para>
        /// <para>Represents the following attribute in the schema: columns</para>
        /// </summary>
        [SchemaAttr("columns")]
        public IntegerValue? Columns
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>rows</para>
        /// <para>Represents the following attribute in the schema: rows</para>
        /// </summary>
        [SchemaAttr("rows")]
        public IntegerValue? Rows
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>itemWidth</para>
        /// <para>Represents the following attribute in the schema: itemWidth</para>
        /// </summary>
        [SchemaAttr("itemWidth")]
        public IntegerValue? ItemWidth
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>itemHeight</para>
        /// <para>Represents the following attribute in the schema: itemHeight</para>
        /// </summary>
        [SchemaAttr("itemHeight")]
        public IntegerValue? ItemHeight
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemWidth</para>
        /// <para>Represents the following attribute in the schema: getItemWidth</para>
        /// </summary>
        [SchemaAttr("getItemWidth")]
        public StringValue? GetItemWidth
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemHeight</para>
        /// <para>Represents the following attribute in the schema: getItemHeight</para>
        /// </summary>
        [SchemaAttr("getItemHeight")]
        public StringValue? GetItemHeight
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showItemLabel</para>
        /// <para>Represents the following attribute in the schema: showItemLabel</para>
        /// </summary>
        [SchemaAttr("showItemLabel")]
        public BooleanValue? ShowItemLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>onAction</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        [SchemaAttr("onAction")]
        public StringValue? OnAction
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [SchemaAttr("getEnabled")]
        public StringValue? GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [SchemaAttr("image")]
        public StringValue? Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [SchemaAttr("imageMso")]
        public StringValue? ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [SchemaAttr("getImage")]
        public StringValue? GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showItemImage</para>
        /// <para>Represents the following attribute in the schema: showItemImage</para>
        /// </summary>
        [SchemaAttr("showItemImage")]
        public BooleanValue? ShowItemImage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemCount</para>
        /// <para>Represents the following attribute in the schema: getItemCount</para>
        /// </summary>
        [SchemaAttr("getItemCount")]
        public StringValue? GetItemCount
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemLabel</para>
        /// <para>Represents the following attribute in the schema: getItemLabel</para>
        /// </summary>
        [SchemaAttr("getItemLabel")]
        public StringValue? GetItemLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemScreentip</para>
        /// <para>Represents the following attribute in the schema: getItemScreentip</para>
        /// </summary>
        [SchemaAttr("getItemScreentip")]
        public StringValue? GetItemScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemSupertip</para>
        /// <para>Represents the following attribute in the schema: getItemSupertip</para>
        /// </summary>
        [SchemaAttr("getItemSupertip")]
        public StringValue? GetItemSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemImage</para>
        /// <para>Represents the following attribute in the schema: getItemImage</para>
        /// </summary>
        [SchemaAttr("getItemImage")]
        public StringValue? GetItemImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemID</para>
        /// <para>Represents the following attribute in the schema: getItemID</para>
        /// </summary>
        [SchemaAttr("getItemID")]
        public StringValue? GetItemID
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sizeString</para>
        /// <para>Represents the following attribute in the schema: sizeString</para>
        /// </summary>
        [SchemaAttr("sizeString")]
        public StringValue? SizeString
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSelectedItemID</para>
        /// <para>Represents the following attribute in the schema: getSelectedItemID</para>
        /// </summary>
        [SchemaAttr("getSelectedItemID")]
        public StringValue? GetSelectedItemID
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSelectedItemIndex</para>
        /// <para>Represents the following attribute in the schema: getSelectedItemIndex</para>
        /// </summary>
        [SchemaAttr("getSelectedItemIndex")]
        public StringValue? GetSelectedItemIndex
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? IdQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [SchemaAttr("idMso")]
        public StringValue? IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [SchemaAttr("screentip")]
        public StringValue? Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [SchemaAttr("getScreentip")]
        public StringValue? GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [SchemaAttr("supertip")]
        public StringValue? Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [SchemaAttr("getSupertip")]
        public StringValue? GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [SchemaAttr("getLabel")]
        public StringValue? GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [SchemaAttr("insertAfterMso")]
        public StringValue? InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [SchemaAttr("insertBeforeMso")]
        public StringValue? InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [SchemaAttr("insertAfterQ")]
        public StringValue? InsertAfterQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [SchemaAttr("insertBeforeQ")]
        public StringValue? InsertBeforeQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [SchemaAttr("keytip")]
        public StringValue? Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [SchemaAttr("getKeytip")]
        public StringValue? GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr("showLabel")]
        public BooleanValue? ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [SchemaAttr("getShowLabel")]
        public StringValue? GetShowLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showImage</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr("showImage")]
        public BooleanValue? ShowImage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowImage</para>
        /// <para>Represents the following attribute in the schema: getShowImage</para>
        /// </summary>
        [SchemaAttr("getShowImage")]
        public StringValue? GetShowImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso:gallery");
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.Item>();
            builder.AddElement<Gallery>()
.AddAttribute("size", a => a.Size)
.AddAttribute("getSize", a => a.GetSize, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("description", a => a.Description, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (4096L) });
})
.AddAttribute("getDescription", a => a.GetDescription, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("invalidateContentOnDrop", a => a.InvalidateContentOnDrop)
.AddAttribute("columns", a => a.Columns, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (1L), MaxInclusive = (1024L), IsPositive = (true) });
})
.AddAttribute("rows", a => a.Rows, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (1L), MaxInclusive = (1024L), IsPositive = (true) });
})
.AddAttribute("itemWidth", a => a.ItemWidth, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (1L), MaxInclusive = (4096L), IsPositive = (true) });
})
.AddAttribute("itemHeight", a => a.ItemHeight, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (1L), MaxInclusive = (4096L), IsPositive = (true) });
})
.AddAttribute("getItemWidth", a => a.GetItemWidth, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getItemHeight", a => a.GetItemHeight, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("showItemLabel", a => a.ShowItemLabel)
.AddAttribute("onAction", a => a.OnAction, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("enabled", a => a.Enabled)
.AddAttribute("getEnabled", a => a.GetEnabled, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("image", a => a.Image, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("imageMso", a => a.ImageMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getImage", a => a.GetImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("showItemImage", a => a.ShowItemImage)
.AddAttribute("getItemCount", a => a.GetItemCount, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getItemLabel", a => a.GetItemLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getItemScreentip", a => a.GetItemScreentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getItemSupertip", a => a.GetItemSupertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getItemImage", a => a.GetItemImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getItemID", a => a.GetItemID, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("sizeString", a => a.SizeString, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getSelectedItemID", a => a.GetSelectedItemID, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getSelectedItemIndex", a => a.GetSelectedItemIndex, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idQ", a => a.IdQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("screentip", a => a.Screentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getScreentip", a => a.GetScreentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("supertip", a => a.Supertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getSupertip", a => a.GetSupertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterQ", a => a.InsertAfterQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeQ", a => a.InsertBeforeQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("visible", a => a.Visible)
.AddAttribute("getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("keytip", a => a.Keytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), MinLength = (1L), MaxLength = (3L) });
})
.AddAttribute("getKeytip", a => a.GetKeytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("showLabel", a => a.ShowLabel)
.AddAttribute("getShowLabel", a => a.GetShowLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("showImage", a => a.ShowImage)
.AddAttribute("getShowImage", a => a.GetShowImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
                    {
                        new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
                        {
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.Item), 0, 1000),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton), 0, 16)
                        }
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Gallery>(deep);
    }

    /// <summary>
    /// <para>Defines the Menu Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:menu.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton" /> <c>&lt;mso:button></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.CheckBox" /> <c>&lt;mso:checkBox></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.UnsizedControlClone" /> <c>&lt;mso:control></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.UnsizedDynamicMenu" /> <c>&lt;mso:dynamicMenu></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery" /> <c>&lt;mso:gallery></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu" /> <c>&lt;mso:menu></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.MenuSeparator" /> <c>&lt;mso:menuSeparator></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.UnsizedSplitButton" /> <c>&lt;mso:splitButton></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.UnsizedToggleButton" /> <c>&lt;mso:toggleButton></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso:menu")]
    public partial class Menu : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Menu class.
        /// </summary>
        public Menu() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Menu class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Menu(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Menu class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Menu(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Menu class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Menu(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>size</para>
        /// <para>Represents the following attribute in the schema: size</para>
        /// </summary>
        [SchemaAttr("size")]
        public EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues>? Size
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSize</para>
        /// <para>Represents the following attribute in the schema: getSize</para>
        /// </summary>
        [SchemaAttr("getSize")]
        public StringValue? GetSize
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>itemSize</para>
        /// <para>Represents the following attribute in the schema: itemSize</para>
        /// </summary>
        [SchemaAttr("itemSize")]
        public EnumValue<DocumentFormat.OpenXml.Office.CustomUI.ItemSizeValues>? ItemSize
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office.CustomUI.ItemSizeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>description</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [SchemaAttr("description")]
        public StringValue? Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getDescription</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [SchemaAttr("getDescription")]
        public StringValue? GetDescription
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? IdQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [SchemaAttr("idMso")]
        public StringValue? IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [SchemaAttr("image")]
        public StringValue? Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [SchemaAttr("imageMso")]
        public StringValue? ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [SchemaAttr("getImage")]
        public StringValue? GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [SchemaAttr("screentip")]
        public StringValue? Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [SchemaAttr("getScreentip")]
        public StringValue? GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [SchemaAttr("supertip")]
        public StringValue? Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [SchemaAttr("getSupertip")]
        public StringValue? GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [SchemaAttr("getEnabled")]
        public StringValue? GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [SchemaAttr("getLabel")]
        public StringValue? GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [SchemaAttr("insertAfterMso")]
        public StringValue? InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [SchemaAttr("insertBeforeMso")]
        public StringValue? InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [SchemaAttr("insertAfterQ")]
        public StringValue? InsertAfterQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [SchemaAttr("insertBeforeQ")]
        public StringValue? InsertBeforeQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [SchemaAttr("keytip")]
        public StringValue? Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [SchemaAttr("getKeytip")]
        public StringValue? GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr("showLabel")]
        public BooleanValue? ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [SchemaAttr("getShowLabel")]
        public StringValue? GetShowLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showImage</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr("showImage")]
        public BooleanValue? ShowImage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowImage</para>
        /// <para>Represents the following attribute in the schema: getShowImage</para>
        /// </summary>
        [SchemaAttr("getShowImage")]
        public StringValue? GetShowImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso:menu");
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.CheckBox>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedControlClone>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedDynamicMenu>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.MenuSeparator>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedSplitButton>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedToggleButton>();
            builder.AddElement<Menu>()
.AddAttribute("size", a => a.Size)
.AddAttribute("getSize", a => a.GetSize, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("itemSize", a => a.ItemSize)
.AddAttribute("description", a => a.Description, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (4096L) });
})
.AddAttribute("getDescription", a => a.GetDescription, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idQ", a => a.IdQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("image", a => a.Image, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("imageMso", a => a.ImageMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getImage", a => a.GetImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("screentip", a => a.Screentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getScreentip", a => a.GetScreentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("supertip", a => a.Supertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getSupertip", a => a.GetSupertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("enabled", a => a.Enabled)
.AddAttribute("getEnabled", a => a.GetEnabled, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterQ", a => a.InsertAfterQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeQ", a => a.InsertBeforeQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("visible", a => a.Visible)
.AddAttribute("getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("keytip", a => a.Keytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), MinLength = (1L), MaxLength = (3L) });
})
.AddAttribute("getKeytip", a => a.GetKeytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("showLabel", a => a.ShowLabel)
.AddAttribute("getShowLabel", a => a.GetShowLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("showImage", a => a.ShowImage)
.AddAttribute("getShowImage", a => a.GetShowImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
                    {
                        new CompositeParticle.Builder(ParticleType.Choice, 0, 1000)
                        {
                            new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                            {
                                new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                {
                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedControlClone), 1, 1),
                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton), 1, 1),
                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.CheckBox), 1, 1),
                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery), 1, 1),
                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedToggleButton), 1, 1),
                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.MenuSeparator), 1, 1)
                                }
                            },
                            new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                            {
                                new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                {
                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedSplitButton), 1, 1),
                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu), 1, 1),
                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedDynamicMenu), 1, 1)
                                }
                            }
                        }
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Menu>(deep);
    }

    /// <summary>
    /// <para>Defines the DynamicMenu Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:dynamicMenu.</para>
    /// </summary>
    [SchemaAttr("mso:dynamicMenu")]
    public partial class DynamicMenu : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the DynamicMenu class.
        /// </summary>
        public DynamicMenu() : base()
        {
        }

        /// <summary>
        /// <para>size</para>
        /// <para>Represents the following attribute in the schema: size</para>
        /// </summary>
        [SchemaAttr("size")]
        public EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues>? Size
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSize</para>
        /// <para>Represents the following attribute in the schema: getSize</para>
        /// </summary>
        [SchemaAttr("getSize")]
        public StringValue? GetSize
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>description</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [SchemaAttr("description")]
        public StringValue? Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getDescription</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [SchemaAttr("getDescription")]
        public StringValue? GetDescription
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? IdQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [SchemaAttr("idMso")]
        public StringValue? IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getContent</para>
        /// <para>Represents the following attribute in the schema: getContent</para>
        /// </summary>
        [SchemaAttr("getContent")]
        public StringValue? GetContent
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>invalidateContentOnDrop</para>
        /// <para>Represents the following attribute in the schema: invalidateContentOnDrop</para>
        /// </summary>
        [SchemaAttr("invalidateContentOnDrop")]
        public BooleanValue? InvalidateContentOnDrop
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [SchemaAttr("image")]
        public StringValue? Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [SchemaAttr("imageMso")]
        public StringValue? ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [SchemaAttr("getImage")]
        public StringValue? GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [SchemaAttr("screentip")]
        public StringValue? Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [SchemaAttr("getScreentip")]
        public StringValue? GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [SchemaAttr("supertip")]
        public StringValue? Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [SchemaAttr("getSupertip")]
        public StringValue? GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [SchemaAttr("getEnabled")]
        public StringValue? GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [SchemaAttr("getLabel")]
        public StringValue? GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [SchemaAttr("insertAfterMso")]
        public StringValue? InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [SchemaAttr("insertBeforeMso")]
        public StringValue? InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [SchemaAttr("insertAfterQ")]
        public StringValue? InsertAfterQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [SchemaAttr("insertBeforeQ")]
        public StringValue? InsertBeforeQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [SchemaAttr("keytip")]
        public StringValue? Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [SchemaAttr("getKeytip")]
        public StringValue? GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr("showLabel")]
        public BooleanValue? ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [SchemaAttr("getShowLabel")]
        public StringValue? GetShowLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showImage</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr("showImage")]
        public BooleanValue? ShowImage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowImage</para>
        /// <para>Represents the following attribute in the schema: getShowImage</para>
        /// </summary>
        [SchemaAttr("getShowImage")]
        public StringValue? GetShowImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso:dynamicMenu");
            builder.AddElement<DynamicMenu>()
.AddAttribute("size", a => a.Size)
.AddAttribute("getSize", a => a.GetSize, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("description", a => a.Description, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (4096L) });
})
.AddAttribute("getDescription", a => a.GetDescription, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idQ", a => a.IdQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getContent", a => a.GetContent, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("invalidateContentOnDrop", a => a.InvalidateContentOnDrop)
.AddAttribute("image", a => a.Image, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("imageMso", a => a.ImageMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getImage", a => a.GetImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("screentip", a => a.Screentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getScreentip", a => a.GetScreentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("supertip", a => a.Supertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getSupertip", a => a.GetSupertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("enabled", a => a.Enabled)
.AddAttribute("getEnabled", a => a.GetEnabled, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterQ", a => a.InsertAfterQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeQ", a => a.InsertBeforeQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("visible", a => a.Visible)
.AddAttribute("getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("keytip", a => a.Keytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), MinLength = (1L), MaxLength = (3L) });
})
.AddAttribute("getKeytip", a => a.GetKeytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("showLabel", a => a.ShowLabel)
.AddAttribute("getShowLabel", a => a.GetShowLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("showImage", a => a.ShowImage)
.AddAttribute("getShowImage", a => a.GetShowImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DynamicMenu>(deep);
    }

    /// <summary>
    /// <para>Defines the SplitButton Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:splitButton.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu" /> <c>&lt;mso:menu></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.VisibleButton" /> <c>&lt;mso:button></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.VisibleToggleButton" /> <c>&lt;mso:toggleButton></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso:splitButton")]
    public partial class SplitButton : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SplitButton class.
        /// </summary>
        public SplitButton() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SplitButton class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SplitButton(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SplitButton class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SplitButton(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SplitButton class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SplitButton(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>size</para>
        /// <para>Represents the following attribute in the schema: size</para>
        /// </summary>
        [SchemaAttr("size")]
        public EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues>? Size
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSize</para>
        /// <para>Represents the following attribute in the schema: getSize</para>
        /// </summary>
        [SchemaAttr("getSize")]
        public StringValue? GetSize
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [SchemaAttr("getEnabled")]
        public StringValue? GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? IdQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [SchemaAttr("idMso")]
        public StringValue? IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [SchemaAttr("insertAfterMso")]
        public StringValue? InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [SchemaAttr("insertBeforeMso")]
        public StringValue? InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [SchemaAttr("insertAfterQ")]
        public StringValue? InsertAfterQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [SchemaAttr("insertBeforeQ")]
        public StringValue? InsertBeforeQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [SchemaAttr("keytip")]
        public StringValue? Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [SchemaAttr("getKeytip")]
        public StringValue? GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr("showLabel")]
        public BooleanValue? ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [SchemaAttr("getShowLabel")]
        public StringValue? GetShowLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso:splitButton");
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.VisibleButton>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.VisibleToggleButton>();
            builder.AddElement<SplitButton>()
.AddAttribute("size", a => a.Size)
.AddAttribute("getSize", a => a.GetSize, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("enabled", a => a.Enabled)
.AddAttribute("getEnabled", a => a.GetEnabled, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idQ", a => a.IdQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterQ", a => a.InsertAfterQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeQ", a => a.InsertBeforeQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("visible", a => a.Visible)
.AddAttribute("getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("keytip", a => a.Keytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), MinLength = (1L), MaxLength = (3L) });
})
.AddAttribute("getKeytip", a => a.GetKeytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("showLabel", a => a.ShowLabel)
.AddAttribute("getShowLabel", a => a.GetShowLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Sequence, 0, 1)
                    {
                        new CompositeParticle.Builder(ParticleType.Choice, 0, 1)
                        {
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.VisibleButton), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.VisibleToggleButton), 1, 1)
                        },
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu), 1, 1)
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SplitButton>(deep);
    }

    /// <summary>
    /// <para>Defines the Box Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:box.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.Box" /> <c>&lt;mso:box></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.Button" /> <c>&lt;mso:button></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.ButtonGroup" /> <c>&lt;mso:buttonGroup></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.CheckBox" /> <c>&lt;mso:checkBox></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.ComboBox" /> <c>&lt;mso:comboBox></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.ControlClone" /> <c>&lt;mso:control></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.DropDown" /> <c>&lt;mso:dropDown></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.DynamicMenu" /> <c>&lt;mso:dynamicMenu></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.EditBox" /> <c>&lt;mso:editBox></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.Gallery" /> <c>&lt;mso:gallery></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.TextLabel" /> <c>&lt;mso:labelControl></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.Menu" /> <c>&lt;mso:menu></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.SplitButton" /> <c>&lt;mso:splitButton></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.ToggleButton" /> <c>&lt;mso:toggleButton></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso:box")]
    public partial class Box : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Box class.
        /// </summary>
        public Box() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Box class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Box(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Box class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Box(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Box class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Box(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? IdQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [SchemaAttr("insertAfterMso")]
        public StringValue? InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [SchemaAttr("insertBeforeMso")]
        public StringValue? InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [SchemaAttr("insertAfterQ")]
        public StringValue? InsertAfterQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [SchemaAttr("insertBeforeQ")]
        public StringValue? InsertBeforeQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>boxStyle</para>
        /// <para>Represents the following attribute in the schema: boxStyle</para>
        /// </summary>
        [SchemaAttr("boxStyle")]
        public EnumValue<DocumentFormat.OpenXml.Office.CustomUI.BoxStyleValues>? BoxStyle
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office.CustomUI.BoxStyleValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso:box");
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.Box>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.Button>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.ButtonGroup>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.CheckBox>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.ComboBox>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.ControlClone>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.DropDown>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.DynamicMenu>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.EditBox>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.Gallery>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.TextLabel>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.Menu>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.SplitButton>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.ToggleButton>();
            builder.AddElement<Box>()
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idQ", a => a.IdQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("visible", a => a.Visible)
.AddAttribute("getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterQ", a => a.InsertAfterQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeQ", a => a.InsertBeforeQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("boxStyle", a => a.BoxStyle);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Group, 0, 1000)
            {
                new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.ControlClone), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.TextLabel), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.Button), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.ToggleButton), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.CheckBox), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.EditBox), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.ComboBox), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.DropDown), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.Gallery), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.Menu), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.DynamicMenu), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.SplitButton), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.Box), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.ButtonGroup), 1, 1)
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Box>(deep);
    }

    /// <summary>
    /// <para>Defines the ButtonGroup Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:buttonGroup.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton" /> <c>&lt;mso:button></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.UnsizedControlClone" /> <c>&lt;mso:control></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.UnsizedDynamicMenu" /> <c>&lt;mso:dynamicMenu></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery" /> <c>&lt;mso:gallery></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu" /> <c>&lt;mso:menu></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.UnsizedSplitButton" /> <c>&lt;mso:splitButton></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.UnsizedToggleButton" /> <c>&lt;mso:toggleButton></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso:buttonGroup")]
    public partial class ButtonGroup : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ButtonGroup class.
        /// </summary>
        public ButtonGroup() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ButtonGroup class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ButtonGroup(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ButtonGroup class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ButtonGroup(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ButtonGroup class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ButtonGroup(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? IdQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [SchemaAttr("insertAfterMso")]
        public StringValue? InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [SchemaAttr("insertBeforeMso")]
        public StringValue? InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [SchemaAttr("insertAfterQ")]
        public StringValue? InsertAfterQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [SchemaAttr("insertBeforeQ")]
        public StringValue? InsertBeforeQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso:buttonGroup");
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedControlClone>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedDynamicMenu>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedSplitButton>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedToggleButton>();
            builder.AddElement<ButtonGroup>()
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idQ", a => a.IdQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("visible", a => a.Visible)
.AddAttribute("getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterQ", a => a.InsertAfterQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeQ", a => a.InsertBeforeQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Choice, 0, 1000)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedControlClone), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedToggleButton), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedDynamicMenu), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedSplitButton), 1, 1)
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ButtonGroup>(deep);
    }

    /// <summary>
    /// <para>Defines the MenuRoot Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:menu.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton" /> <c>&lt;mso:button></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.CheckBox" /> <c>&lt;mso:checkBox></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.UnsizedControlClone" /> <c>&lt;mso:control></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.UnsizedDynamicMenu" /> <c>&lt;mso:dynamicMenu></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery" /> <c>&lt;mso:gallery></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu" /> <c>&lt;mso:menu></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.MenuSeparator" /> <c>&lt;mso:menuSeparator></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.UnsizedSplitButton" /> <c>&lt;mso:splitButton></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.UnsizedToggleButton" /> <c>&lt;mso:toggleButton></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso:menu")]
    public partial class MenuRoot : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the MenuRoot class.
        /// </summary>
        public MenuRoot() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the MenuRoot class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MenuRoot(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MenuRoot class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MenuRoot(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MenuRoot class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public MenuRoot(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>title</para>
        /// <para>Represents the following attribute in the schema: title</para>
        /// </summary>
        [SchemaAttr("title")]
        public StringValue? Title
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getTitle</para>
        /// <para>Represents the following attribute in the schema: getTitle</para>
        /// </summary>
        [SchemaAttr("getTitle")]
        public StringValue? GetTitle
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>itemSize</para>
        /// <para>Represents the following attribute in the schema: itemSize</para>
        /// </summary>
        [SchemaAttr("itemSize")]
        public EnumValue<DocumentFormat.OpenXml.Office.CustomUI.ItemSizeValues>? ItemSize
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office.CustomUI.ItemSizeValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso:menu");
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.CheckBox>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedControlClone>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedDynamicMenu>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.MenuSeparator>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedSplitButton>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedToggleButton>();
            builder.AddElement<MenuRoot>()
.AddAttribute("title", a => a.Title, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getTitle", a => a.GetTitle, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("itemSize", a => a.ItemSize);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Choice, 0, 1000)
                {
                    new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                    {
                        new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                        {
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedControlClone), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.CheckBox), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedToggleButton), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.MenuSeparator), 1, 1)
                        }
                    },
                    new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                    {
                        new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                        {
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedSplitButton), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedMenu), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedDynamicMenu), 1, 1)
                        }
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MenuRoot>(deep);
    }

    /// <summary>
    /// <para>Defines the CustomUI Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:customUI.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.RepurposedCommands" /> <c>&lt;mso:commands></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.Ribbon" /> <c>&lt;mso:ribbon></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso:customUI")]
    public partial class CustomUI : OpenXmlPartRootElement
    {
        /// <summary>
        /// Initializes a new instance of the CustomUI class.
        /// </summary>
        public CustomUI() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the CustomUI class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CustomUI(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CustomUI class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public CustomUI(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the CustomUI class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public CustomUI(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>onLoad</para>
        /// <para>Represents the following attribute in the schema: onLoad</para>
        /// </summary>
        [SchemaAttr("onLoad")]
        public StringValue? OnLoad
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>loadImage</para>
        /// <para>Represents the following attribute in the schema: loadImage</para>
        /// </summary>
        [SchemaAttr("loadImage")]
        public StringValue? LoadImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso:customUI");
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.RepurposedCommands>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.Ribbon>();
            builder.AddElement<CustomUI>()
.AddAttribute("onLoad", a => a.OnLoad, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("loadImage", a => a.LoadImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.RepurposedCommands), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.Ribbon), 0, 1)
            };
        }

        /// <summary>
        /// <para>RepurposedCommands.</para>
        /// <para>Represents the following element tag in the schema: mso:commands.</para>
        /// </summary>
        /// <remark>
        /// xmlns:mso = http://schemas.microsoft.com/office/2006/01/customui
        /// </remark>
        public DocumentFormat.OpenXml.Office.CustomUI.RepurposedCommands? RepurposedCommands
        {
            get => GetElement<DocumentFormat.OpenXml.Office.CustomUI.RepurposedCommands>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Ribbon.</para>
        /// <para>Represents the following element tag in the schema: mso:ribbon.</para>
        /// </summary>
        /// <remark>
        /// xmlns:mso = http://schemas.microsoft.com/office/2006/01/customui
        /// </remark>
        public DocumentFormat.OpenXml.Office.CustomUI.Ribbon? Ribbon
        {
            get => GetElement<DocumentFormat.OpenXml.Office.CustomUI.Ribbon>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CustomUI>(deep);
    }

    /// <summary>
    /// <para>Defines the Item Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:item.</para>
    /// </summary>
    [SchemaAttr("mso:item")]
    public partial class Item : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Item class.
        /// </summary>
        public Item() : base()
        {
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [SchemaAttr("image")]
        public StringValue? Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [SchemaAttr("imageMso")]
        public StringValue? ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [SchemaAttr("screentip")]
        public StringValue? Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [SchemaAttr("supertip")]
        public StringValue? Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso:item");
            builder.AddElement<Item>()
.AddAttribute("id", a => a.Id, aBuilder =>
{
 aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("label", a => a.Label, aBuilder =>
{
 aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("image", a => a.Image, aBuilder =>
{
 aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("imageMso", a => a.ImageMso, aBuilder =>
{
 aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("screentip", a => a.Screentip, aBuilder =>
{
 aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("supertip", a => a.Supertip, aBuilder =>
{
 aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Item>(deep);
    }

    /// <summary>
    /// <para>Defines the VisibleButton Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:button.</para>
    /// </summary>
    [SchemaAttr("mso:button")]
    public partial class VisibleButton : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the VisibleButton class.
        /// </summary>
        public VisibleButton() : base()
        {
        }

        /// <summary>
        /// <para>onAction</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        [SchemaAttr("onAction")]
        public StringValue? OnAction
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [SchemaAttr("getEnabled")]
        public StringValue? GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>description</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [SchemaAttr("description")]
        public StringValue? Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getDescription</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [SchemaAttr("getDescription")]
        public StringValue? GetDescription
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [SchemaAttr("image")]
        public StringValue? Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [SchemaAttr("imageMso")]
        public StringValue? ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [SchemaAttr("getImage")]
        public StringValue? GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? IdQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [SchemaAttr("idMso")]
        public StringValue? IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [SchemaAttr("screentip")]
        public StringValue? Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [SchemaAttr("getScreentip")]
        public StringValue? GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [SchemaAttr("supertip")]
        public StringValue? Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [SchemaAttr("getSupertip")]
        public StringValue? GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [SchemaAttr("getLabel")]
        public StringValue? GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [SchemaAttr("insertAfterMso")]
        public StringValue? InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [SchemaAttr("insertBeforeMso")]
        public StringValue? InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [SchemaAttr("insertAfterQ")]
        public StringValue? InsertAfterQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [SchemaAttr("insertBeforeQ")]
        public StringValue? InsertBeforeQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [SchemaAttr("keytip")]
        public StringValue? Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [SchemaAttr("getKeytip")]
        public StringValue? GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr("showLabel")]
        public BooleanValue? ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [SchemaAttr("getShowLabel")]
        public StringValue? GetShowLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showImage</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr("showImage")]
        public BooleanValue? ShowImage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowImage</para>
        /// <para>Represents the following attribute in the schema: getShowImage</para>
        /// </summary>
        [SchemaAttr("getShowImage")]
        public StringValue? GetShowImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso:button");
            builder.AddElement<VisibleButton>()
.AddAttribute("onAction", a => a.OnAction, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("enabled", a => a.Enabled)
.AddAttribute("getEnabled", a => a.GetEnabled, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("description", a => a.Description, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (4096L) });
})
.AddAttribute("getDescription", a => a.GetDescription, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("image", a => a.Image, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("imageMso", a => a.ImageMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getImage", a => a.GetImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idQ", a => a.IdQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("screentip", a => a.Screentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getScreentip", a => a.GetScreentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("supertip", a => a.Supertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getSupertip", a => a.GetSupertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterQ", a => a.InsertAfterQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeQ", a => a.InsertBeforeQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("keytip", a => a.Keytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), MinLength = (1L), MaxLength = (3L) });
})
.AddAttribute("getKeytip", a => a.GetKeytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("showLabel", a => a.ShowLabel)
.AddAttribute("getShowLabel", a => a.GetShowLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("showImage", a => a.ShowImage)
.AddAttribute("getShowImage", a => a.GetShowImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<VisibleButton>(deep);
    }

    /// <summary>
    /// <para>Defines the VisibleToggleButton Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:toggleButton.</para>
    /// </summary>
    [SchemaAttr("mso:toggleButton")]
    public partial class VisibleToggleButton : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the VisibleToggleButton class.
        /// </summary>
        public VisibleToggleButton() : base()
        {
        }

        /// <summary>
        /// <para>getPressed</para>
        /// <para>Represents the following attribute in the schema: getPressed</para>
        /// </summary>
        [SchemaAttr("getPressed")]
        public StringValue? GetPressed
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>onAction</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        [SchemaAttr("onAction")]
        public StringValue? OnAction
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [SchemaAttr("getEnabled")]
        public StringValue? GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>description</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [SchemaAttr("description")]
        public StringValue? Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getDescription</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [SchemaAttr("getDescription")]
        public StringValue? GetDescription
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [SchemaAttr("image")]
        public StringValue? Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [SchemaAttr("imageMso")]
        public StringValue? ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [SchemaAttr("getImage")]
        public StringValue? GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? IdQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [SchemaAttr("idMso")]
        public StringValue? IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [SchemaAttr("screentip")]
        public StringValue? Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [SchemaAttr("getScreentip")]
        public StringValue? GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [SchemaAttr("supertip")]
        public StringValue? Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [SchemaAttr("getSupertip")]
        public StringValue? GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [SchemaAttr("getLabel")]
        public StringValue? GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [SchemaAttr("insertAfterMso")]
        public StringValue? InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [SchemaAttr("insertBeforeMso")]
        public StringValue? InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [SchemaAttr("insertAfterQ")]
        public StringValue? InsertAfterQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [SchemaAttr("insertBeforeQ")]
        public StringValue? InsertBeforeQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [SchemaAttr("keytip")]
        public StringValue? Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [SchemaAttr("getKeytip")]
        public StringValue? GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr("showLabel")]
        public BooleanValue? ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [SchemaAttr("getShowLabel")]
        public StringValue? GetShowLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showImage</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr("showImage")]
        public BooleanValue? ShowImage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowImage</para>
        /// <para>Represents the following attribute in the schema: getShowImage</para>
        /// </summary>
        [SchemaAttr("getShowImage")]
        public StringValue? GetShowImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso:toggleButton");
            builder.AddElement<VisibleToggleButton>()
.AddAttribute("getPressed", a => a.GetPressed, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("onAction", a => a.OnAction, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("enabled", a => a.Enabled)
.AddAttribute("getEnabled", a => a.GetEnabled, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("description", a => a.Description, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (4096L) });
})
.AddAttribute("getDescription", a => a.GetDescription, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("image", a => a.Image, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("imageMso", a => a.ImageMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getImage", a => a.GetImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idQ", a => a.IdQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("screentip", a => a.Screentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getScreentip", a => a.GetScreentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("supertip", a => a.Supertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getSupertip", a => a.GetSupertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterQ", a => a.InsertAfterQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeQ", a => a.InsertBeforeQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("keytip", a => a.Keytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), MinLength = (1L), MaxLength = (3L) });
})
.AddAttribute("getKeytip", a => a.GetKeytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("showLabel", a => a.ShowLabel)
.AddAttribute("getShowLabel", a => a.GetShowLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("showImage", a => a.ShowImage)
.AddAttribute("getShowImage", a => a.GetShowImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<VisibleToggleButton>(deep);
    }

    /// <summary>
    /// <para>Defines the VerticalSeparator Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:separator.</para>
    /// </summary>
    [SchemaAttr("mso:separator")]
    public partial class VerticalSeparator : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the VerticalSeparator class.
        /// </summary>
        public VerticalSeparator() : base()
        {
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? IdQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [SchemaAttr("insertAfterMso")]
        public StringValue? InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [SchemaAttr("insertBeforeMso")]
        public StringValue? InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [SchemaAttr("insertAfterQ")]
        public StringValue? InsertAfterQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [SchemaAttr("insertBeforeQ")]
        public StringValue? InsertBeforeQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso:separator");
            builder.AddElement<VerticalSeparator>()
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idQ", a => a.IdQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("visible", a => a.Visible)
.AddAttribute("getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterQ", a => a.InsertAfterQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeQ", a => a.InsertBeforeQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<VerticalSeparator>(deep);
    }

    /// <summary>
    /// <para>Defines the DialogBoxLauncher Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:dialogBoxLauncher.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton" /> <c>&lt;mso:button></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso:dialogBoxLauncher")]
    public partial class DialogBoxLauncher : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DialogBoxLauncher class.
        /// </summary>
        public DialogBoxLauncher() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DialogBoxLauncher class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DialogBoxLauncher(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DialogBoxLauncher class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DialogBoxLauncher(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DialogBoxLauncher class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DialogBoxLauncher(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso:dialogBoxLauncher");
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton), 1, 1)
            };
        }

        /// <summary>
        /// <para>UnsizedButton.</para>
        /// <para>Represents the following element tag in the schema: mso:button.</para>
        /// </summary>
        /// <remark>
        /// xmlns:mso = http://schemas.microsoft.com/office/2006/01/customui
        /// </remark>
        public DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton? UnsizedButton
        {
            get => GetElement<DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DialogBoxLauncher>(deep);
    }

    /// <summary>
    /// <para>Defines the Group Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:group.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.Box" /> <c>&lt;mso:box></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.Button" /> <c>&lt;mso:button></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.ButtonGroup" /> <c>&lt;mso:buttonGroup></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.CheckBox" /> <c>&lt;mso:checkBox></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.ComboBox" /> <c>&lt;mso:comboBox></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.ControlClone" /> <c>&lt;mso:control></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.DialogBoxLauncher" /> <c>&lt;mso:dialogBoxLauncher></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.DropDown" /> <c>&lt;mso:dropDown></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.DynamicMenu" /> <c>&lt;mso:dynamicMenu></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.EditBox" /> <c>&lt;mso:editBox></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.Gallery" /> <c>&lt;mso:gallery></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.TextLabel" /> <c>&lt;mso:labelControl></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.Menu" /> <c>&lt;mso:menu></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.VerticalSeparator" /> <c>&lt;mso:separator></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.SplitButton" /> <c>&lt;mso:splitButton></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.ToggleButton" /> <c>&lt;mso:toggleButton></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso:group")]
    public partial class Group : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Group class.
        /// </summary>
        public Group() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Group class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Group(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Group class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Group(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Group class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Group(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? IdQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [SchemaAttr("idMso")]
        public StringValue? IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [SchemaAttr("getLabel")]
        public StringValue? GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [SchemaAttr("image")]
        public StringValue? Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [SchemaAttr("imageMso")]
        public StringValue? ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [SchemaAttr("getImage")]
        public StringValue? GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [SchemaAttr("insertAfterMso")]
        public StringValue? InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [SchemaAttr("insertBeforeMso")]
        public StringValue? InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [SchemaAttr("insertAfterQ")]
        public StringValue? InsertAfterQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [SchemaAttr("insertBeforeQ")]
        public StringValue? InsertBeforeQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [SchemaAttr("screentip")]
        public StringValue? Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [SchemaAttr("getScreentip")]
        public StringValue? GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [SchemaAttr("supertip")]
        public StringValue? Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [SchemaAttr("getSupertip")]
        public StringValue? GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [SchemaAttr("keytip")]
        public StringValue? Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [SchemaAttr("getKeytip")]
        public StringValue? GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso:group");
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.Box>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.Button>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.ButtonGroup>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.CheckBox>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.ComboBox>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.ControlClone>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.DialogBoxLauncher>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.DropDown>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.DynamicMenu>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.EditBox>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.Gallery>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.TextLabel>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.Menu>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.VerticalSeparator>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.SplitButton>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.ToggleButton>();
            builder.AddElement<Group>()
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idQ", a => a.IdQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("image", a => a.Image, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("imageMso", a => a.ImageMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getImage", a => a.GetImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterQ", a => a.InsertAfterQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeQ", a => a.InsertBeforeQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("screentip", a => a.Screentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getScreentip", a => a.GetScreentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("supertip", a => a.Supertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getSupertip", a => a.GetSupertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("visible", a => a.Visible)
.AddAttribute("getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("keytip", a => a.Keytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), MinLength = (1L), MaxLength = (3L) });
})
.AddAttribute("getKeytip", a => a.GetKeytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 0, 1000)
                    {
                        new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                        {
                            new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                            {
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.ControlClone), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.TextLabel), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.Button), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.ToggleButton), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.CheckBox), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.EditBox), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.ComboBox), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.DropDown), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.Gallery), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.Menu), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.DynamicMenu), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.SplitButton), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.Box), 1, 1),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.ButtonGroup), 1, 1)
                            }
                        },
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.VerticalSeparator), 1, 1)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.DialogBoxLauncher), 0, 1)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Group>(deep);
    }

    /// <summary>
    /// <para>Defines the QuickAccessToolbarControlClone Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:control.</para>
    /// </summary>
    [SchemaAttr("mso:control")]
    public partial class QuickAccessToolbarControlClone : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the QuickAccessToolbarControlClone class.
        /// </summary>
        public QuickAccessToolbarControlClone() : base()
        {
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? IdQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [SchemaAttr("idMso")]
        public StringValue? IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>description</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [SchemaAttr("description")]
        public StringValue? Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getDescription</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [SchemaAttr("getDescription")]
        public StringValue? GetDescription
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>size</para>
        /// <para>Represents the following attribute in the schema: size</para>
        /// </summary>
        [SchemaAttr("size")]
        public EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues>? Size
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSize</para>
        /// <para>Represents the following attribute in the schema: getSize</para>
        /// </summary>
        [SchemaAttr("getSize")]
        public StringValue? GetSize
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [SchemaAttr("image")]
        public StringValue? Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [SchemaAttr("imageMso")]
        public StringValue? ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [SchemaAttr("getImage")]
        public StringValue? GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [SchemaAttr("screentip")]
        public StringValue? Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [SchemaAttr("getScreentip")]
        public StringValue? GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [SchemaAttr("supertip")]
        public StringValue? Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [SchemaAttr("getSupertip")]
        public StringValue? GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [SchemaAttr("getEnabled")]
        public StringValue? GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [SchemaAttr("getLabel")]
        public StringValue? GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [SchemaAttr("insertAfterMso")]
        public StringValue? InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [SchemaAttr("insertBeforeMso")]
        public StringValue? InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [SchemaAttr("insertAfterQ")]
        public StringValue? InsertAfterQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [SchemaAttr("insertBeforeQ")]
        public StringValue? InsertBeforeQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [SchemaAttr("keytip")]
        public StringValue? Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [SchemaAttr("getKeytip")]
        public StringValue? GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr("showLabel")]
        public BooleanValue? ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [SchemaAttr("getShowLabel")]
        public StringValue? GetShowLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showImage</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr("showImage")]
        public BooleanValue? ShowImage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowImage</para>
        /// <para>Represents the following attribute in the schema: getShowImage</para>
        /// </summary>
        [SchemaAttr("getShowImage")]
        public StringValue? GetShowImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso:control");
            builder.AddElement<QuickAccessToolbarControlClone>()
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idQ", a => a.IdQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("description", a => a.Description, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (4096L) });
})
.AddAttribute("getDescription", a => a.GetDescription, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("size", a => a.Size)
.AddAttribute("getSize", a => a.GetSize, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("image", a => a.Image, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("imageMso", a => a.ImageMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getImage", a => a.GetImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("screentip", a => a.Screentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getScreentip", a => a.GetScreentip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("supertip", a => a.Supertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getSupertip", a => a.GetSupertip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("enabled", a => a.Enabled)
.AddAttribute("getEnabled", a => a.GetEnabled, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterQ", a => a.InsertAfterQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeQ", a => a.InsertBeforeQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("visible", a => a.Visible)
.AddAttribute("getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("keytip", a => a.Keytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), MinLength = (1L), MaxLength = (3L) });
})
.AddAttribute("getKeytip", a => a.GetKeytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("showLabel", a => a.ShowLabel)
.AddAttribute("getShowLabel", a => a.GetShowLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("showImage", a => a.ShowImage)
.AddAttribute("getShowImage", a => a.GetShowImage, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<QuickAccessToolbarControlClone>(deep);
    }

    /// <summary>
    /// <para>Defines the SharedQatControls Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:sharedControls.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton" /> <c>&lt;mso:button></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.QuickAccessToolbarControlClone" /> <c>&lt;mso:control></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.VerticalSeparator" /> <c>&lt;mso:separator></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso:sharedControls")]
    public partial class SharedQatControls : QatItemsType
    {
        /// <summary>
        /// Initializes a new instance of the SharedQatControls class.
        /// </summary>
        public SharedQatControls() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SharedQatControls class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SharedQatControls(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SharedQatControls class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SharedQatControls(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SharedQatControls class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SharedQatControls(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso:sharedControls");
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Choice, 0, 1000)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.QuickAccessToolbarControlClone), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.VerticalSeparator), 1, 1)
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SharedQatControls>(deep);
    }

    /// <summary>
    /// <para>Defines the DocumentSpecificQuickAccessToolbarControls Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:documentControls.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton" /> <c>&lt;mso:button></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.QuickAccessToolbarControlClone" /> <c>&lt;mso:control></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.VerticalSeparator" /> <c>&lt;mso:separator></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso:documentControls")]
    public partial class DocumentSpecificQuickAccessToolbarControls : QatItemsType
    {
        /// <summary>
        /// Initializes a new instance of the DocumentSpecificQuickAccessToolbarControls class.
        /// </summary>
        public DocumentSpecificQuickAccessToolbarControls() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DocumentSpecificQuickAccessToolbarControls class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DocumentSpecificQuickAccessToolbarControls(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DocumentSpecificQuickAccessToolbarControls class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DocumentSpecificQuickAccessToolbarControls(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DocumentSpecificQuickAccessToolbarControls class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DocumentSpecificQuickAccessToolbarControls(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso:documentControls");
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Choice, 0, 1000)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.QuickAccessToolbarControlClone), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton), 1, 1),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.VerticalSeparator), 1, 1)
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DocumentSpecificQuickAccessToolbarControls>(deep);
    }

    /// <summary>
    /// <para>Defines the QatItemsType Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton" /> <c>&lt;mso:button></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.QuickAccessToolbarControlClone" /> <c>&lt;mso:control></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.VerticalSeparator" /> <c>&lt;mso:separator></c></description></item>
    /// </list>
    /// </remark>
    public abstract partial class QatItemsType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the QatItemsType class.
        /// </summary>
        protected QatItemsType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the QatItemsType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected QatItemsType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the QatItemsType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected QatItemsType(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the QatItemsType class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        protected QatItemsType(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.QuickAccessToolbarControlClone>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.VerticalSeparator>();
        }
    }

    /// <summary>
    /// <para>Defines the Tab Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:tab.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.Group" /> <c>&lt;mso:group></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso:tab")]
    public partial class Tab : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Tab class.
        /// </summary>
        public Tab() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Tab class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Tab(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Tab class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Tab(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Tab class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Tab(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? IdQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [SchemaAttr("idMso")]
        public StringValue? IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [SchemaAttr("getLabel")]
        public StringValue? GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [SchemaAttr("insertAfterMso")]
        public StringValue? InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [SchemaAttr("insertBeforeMso")]
        public StringValue? InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [SchemaAttr("insertAfterQ")]
        public StringValue? InsertAfterQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [SchemaAttr("insertBeforeQ")]
        public StringValue? InsertBeforeQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [SchemaAttr("keytip")]
        public StringValue? Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [SchemaAttr("getKeytip")]
        public StringValue? GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso:tab");
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.Group>();
            builder.AddElement<Tab>()
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idQ", a => a.IdQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterQ", a => a.InsertAfterQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeQ", a => a.InsertBeforeQ, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("visible", a => a.Visible)
.AddAttribute("getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("keytip", a => a.Keytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), MinLength = (1L), MaxLength = (3L) });
})
.AddAttribute("getKeytip", a => a.GetKeytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Choice, 0, 100)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.Group), 1, 1)
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Tab>(deep);
    }

    /// <summary>
    /// <para>Defines the ContextualTabSet Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:tabSet.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.Tab" /> <c>&lt;mso:tab></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso:tabSet")]
    public partial class ContextualTabSet : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ContextualTabSet class.
        /// </summary>
        public ContextualTabSet() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ContextualTabSet class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ContextualTabSet(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ContextualTabSet class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ContextualTabSet(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ContextualTabSet class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ContextualTabSet(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>idMso</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [SchemaAttr("idMso")]
        public StringValue? IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso:tabSet");
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.Tab>();
            builder.AddElement<ContextualTabSet>()
.AddAttribute("idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(RequiredValidator.Instance);
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("visible", a => a.Visible)
.AddAttribute("getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.Tab), 0, 50)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ContextualTabSet>(deep);
    }

    /// <summary>
    /// <para>Defines the RepurposedCommand Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:command.</para>
    /// </summary>
    [SchemaAttr("mso:command")]
    public partial class RepurposedCommand : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the RepurposedCommand class.
        /// </summary>
        public RepurposedCommand() : base()
        {
        }

        /// <summary>
        /// <para>onAction</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        [SchemaAttr("onAction")]
        public StringValue? OnAction
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [SchemaAttr("getEnabled")]
        public StringValue? GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [SchemaAttr("idMso")]
        public StringValue? IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso:command");
            builder.AddElement<RepurposedCommand>()
.AddAttribute("onAction", a => a.OnAction, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("enabled", a => a.Enabled)
.AddAttribute("getEnabled", a => a.GetEnabled, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RepurposedCommand>(deep);
    }

    /// <summary>
    /// <para>Defines the OfficeMenu Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:officeMenu.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton" /> <c>&lt;mso:button></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.CheckBox" /> <c>&lt;mso:checkBox></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.UnsizedControlClone" /> <c>&lt;mso:control></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.UnsizedDynamicMenu" /> <c>&lt;mso:dynamicMenu></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery" /> <c>&lt;mso:gallery></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.MenuSeparator" /> <c>&lt;mso:menuSeparator></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.MenuWithTitle" /> <c>&lt;mso:menu></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.SplitButtonWithTitle" /> <c>&lt;mso:splitButton></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.UnsizedToggleButton" /> <c>&lt;mso:toggleButton></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso:officeMenu")]
    public partial class OfficeMenu : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the OfficeMenu class.
        /// </summary>
        public OfficeMenu() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the OfficeMenu class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OfficeMenu(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OfficeMenu class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public OfficeMenu(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the OfficeMenu class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public OfficeMenu(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso:officeMenu");
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.CheckBox>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedControlClone>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedDynamicMenu>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.MenuSeparator>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.MenuWithTitle>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.SplitButtonWithTitle>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.UnsizedToggleButton>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Choice, 0, 1000)
                {
                    new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                    {
                        new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                        {
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedControlClone), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedButton), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.CheckBox), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedGallery), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedToggleButton), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.MenuSeparator), 1, 1)
                        }
                    },
                    new CompositeParticle.Builder(ParticleType.Group, 1, 1)
                    {
                        new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                        {
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.SplitButtonWithTitle), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.MenuWithTitle), 1, 1),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.UnsizedDynamicMenu), 1, 1)
                        }
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<OfficeMenu>(deep);
    }

    /// <summary>
    /// <para>Defines the QuickAccessToolbar Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:qat.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.SharedQatControls" /> <c>&lt;mso:sharedControls></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.DocumentSpecificQuickAccessToolbarControls" /> <c>&lt;mso:documentControls></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso:qat")]
    public partial class QuickAccessToolbar : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the QuickAccessToolbar class.
        /// </summary>
        public QuickAccessToolbar() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the QuickAccessToolbar class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public QuickAccessToolbar(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the QuickAccessToolbar class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public QuickAccessToolbar(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the QuickAccessToolbar class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public QuickAccessToolbar(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso:qat");
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.SharedQatControls>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.DocumentSpecificQuickAccessToolbarControls>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.SharedQatControls), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.DocumentSpecificQuickAccessToolbarControls), 0, 1)
            };
        }

        /// <summary>
        /// <para>SharedQatControls.</para>
        /// <para>Represents the following element tag in the schema: mso:sharedControls.</para>
        /// </summary>
        /// <remark>
        /// xmlns:mso = http://schemas.microsoft.com/office/2006/01/customui
        /// </remark>
        public DocumentFormat.OpenXml.Office.CustomUI.SharedQatControls? SharedQatControls
        {
            get => GetElement<DocumentFormat.OpenXml.Office.CustomUI.SharedQatControls>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>DocumentSpecificQuickAccessToolbarControls.</para>
        /// <para>Represents the following element tag in the schema: mso:documentControls.</para>
        /// </summary>
        /// <remark>
        /// xmlns:mso = http://schemas.microsoft.com/office/2006/01/customui
        /// </remark>
        public DocumentFormat.OpenXml.Office.CustomUI.DocumentSpecificQuickAccessToolbarControls? DocumentSpecificQuickAccessToolbarControls
        {
            get => GetElement<DocumentFormat.OpenXml.Office.CustomUI.DocumentSpecificQuickAccessToolbarControls>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<QuickAccessToolbar>(deep);
    }

    /// <summary>
    /// <para>Defines the Tabs Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:tabs.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.Tab" /> <c>&lt;mso:tab></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso:tabs")]
    public partial class Tabs : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Tabs class.
        /// </summary>
        public Tabs() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Tabs class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Tabs(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Tabs class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Tabs(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Tabs class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Tabs(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso:tabs");
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.Tab>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.Tab), 1, 100)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Tabs>(deep);
    }

    /// <summary>
    /// <para>Defines the ContextualTabSets Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:contextualTabs.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.ContextualTabSet" /> <c>&lt;mso:tabSet></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso:contextualTabs")]
    public partial class ContextualTabSets : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ContextualTabSets class.
        /// </summary>
        public ContextualTabSets() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ContextualTabSets class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ContextualTabSets(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ContextualTabSets class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ContextualTabSets(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ContextualTabSets class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ContextualTabSets(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso:contextualTabs");
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.ContextualTabSet>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.ContextualTabSet), 1, 100)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ContextualTabSets>(deep);
    }

    /// <summary>
    /// <para>Defines the RepurposedCommands Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:commands.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.RepurposedCommand" /> <c>&lt;mso:command></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso:commands")]
    public partial class RepurposedCommands : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RepurposedCommands class.
        /// </summary>
        public RepurposedCommands() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RepurposedCommands class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RepurposedCommands(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RepurposedCommands class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RepurposedCommands(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RepurposedCommands class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RepurposedCommands(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso:commands");
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.RepurposedCommand>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.RepurposedCommand), 1, 5000)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RepurposedCommands>(deep);
    }

    /// <summary>
    /// <para>Defines the Ribbon Class.</para>
    /// <para>This class is available in Office 2007 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso:ribbon.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.ContextualTabSets" /> <c>&lt;mso:contextualTabs></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.OfficeMenu" /> <c>&lt;mso:officeMenu></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.QuickAccessToolbar" /> <c>&lt;mso:qat></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.CustomUI.Tabs" /> <c>&lt;mso:tabs></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso:ribbon")]
    public partial class Ribbon : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Ribbon class.
        /// </summary>
        public Ribbon() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Ribbon class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Ribbon(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Ribbon class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Ribbon(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Ribbon class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Ribbon(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>startFromScratch</para>
        /// <para>Represents the following attribute in the schema: startFromScratch</para>
        /// </summary>
        [SchemaAttr("startFromScratch")]
        public BooleanValue? StartFromScratch
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso:ribbon");
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.ContextualTabSets>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.OfficeMenu>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.QuickAccessToolbar>();
            builder.AddChild<DocumentFormat.OpenXml.Office.CustomUI.Tabs>();
            builder.AddElement<Ribbon>()
.AddAttribute("startFromScratch", a => a.StartFromScratch);
            builder.Particle = new CompositeParticle.Builder(ParticleType.All, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.OfficeMenu), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.QuickAccessToolbar), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.Tabs), 0, 1),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.CustomUI.ContextualTabSets), 0, 1)
            };
        }

        /// <summary>
        /// <para>OfficeMenu.</para>
        /// <para>Represents the following element tag in the schema: mso:officeMenu.</para>
        /// </summary>
        /// <remark>
        /// xmlns:mso = http://schemas.microsoft.com/office/2006/01/customui
        /// </remark>
        public DocumentFormat.OpenXml.Office.CustomUI.OfficeMenu? OfficeMenu
        {
            get => GetElement<DocumentFormat.OpenXml.Office.CustomUI.OfficeMenu>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>QuickAccessToolbar.</para>
        /// <para>Represents the following element tag in the schema: mso:qat.</para>
        /// </summary>
        /// <remark>
        /// xmlns:mso = http://schemas.microsoft.com/office/2006/01/customui
        /// </remark>
        public DocumentFormat.OpenXml.Office.CustomUI.QuickAccessToolbar? QuickAccessToolbar
        {
            get => GetElement<DocumentFormat.OpenXml.Office.CustomUI.QuickAccessToolbar>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Tabs.</para>
        /// <para>Represents the following element tag in the schema: mso:tabs.</para>
        /// </summary>
        /// <remark>
        /// xmlns:mso = http://schemas.microsoft.com/office/2006/01/customui
        /// </remark>
        public DocumentFormat.OpenXml.Office.CustomUI.Tabs? Tabs
        {
            get => GetElement<DocumentFormat.OpenXml.Office.CustomUI.Tabs>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ContextualTabSets.</para>
        /// <para>Represents the following element tag in the schema: mso:contextualTabs.</para>
        /// </summary>
        /// <remark>
        /// xmlns:mso = http://schemas.microsoft.com/office/2006/01/customui
        /// </remark>
        public DocumentFormat.OpenXml.Office.CustomUI.ContextualTabSets? ContextualTabSets
        {
            get => GetElement<DocumentFormat.OpenXml.Office.CustomUI.ContextualTabSets>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Ribbon>(deep);
    }

    /// <summary>
    /// Defines the SizeValues enumeration.
    /// </summary>
    public enum SizeValues
    {
        /// <summary>
        /// normal.
        /// <para>When the item is serialized out as xml, its value is "normal".</para>
        /// </summary>
        [EnumString("normal")]
        Normal,
        /// <summary>
        /// large.
        /// <para>When the item is serialized out as xml, its value is "large".</para>
        /// </summary>
        [EnumString("large")]
        Large
    }

    /// <summary>
    /// Defines the ItemSizeValues enumeration.
    /// </summary>
    public enum ItemSizeValues
    {
        /// <summary>
        /// normal.
        /// <para>When the item is serialized out as xml, its value is "normal".</para>
        /// </summary>
        [EnumString("normal")]
        Normal,
        /// <summary>
        /// large.
        /// <para>When the item is serialized out as xml, its value is "large".</para>
        /// </summary>
        [EnumString("large")]
        Large
    }

    /// <summary>
    /// Defines the BoxStyleValues enumeration.
    /// </summary>
    public enum BoxStyleValues
    {
        /// <summary>
        /// horizontal.
        /// <para>When the item is serialized out as xml, its value is "horizontal".</para>
        /// </summary>
        [EnumString("horizontal")]
        Horizontal,
        /// <summary>
        /// vertical.
        /// <para>When the item is serialized out as xml, its value is "vertical".</para>
        /// </summary>
        [EnumString("vertical")]
        Vertical
    }
}