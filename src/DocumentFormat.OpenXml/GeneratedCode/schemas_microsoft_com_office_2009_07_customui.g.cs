﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using DocumentFormat.OpenXml.Validation.Semantic;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office2010.CustomUI
{
    /// <summary>
    /// <para>Defines the ControlCloneRegular Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:control.</para>
    /// </summary>
    [SchemaAttr("mso14:control")]
    public partial class ControlCloneRegular : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ControlCloneRegular class.
        /// </summary>
        public ControlCloneRegular() : base()
        {
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [SchemaAttr("idMso")]
        public StringValue? IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [SchemaAttr("image")]
        public StringValue? Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [SchemaAttr("imageMso")]
        public StringValue? ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [SchemaAttr("getImage")]
        public StringValue? GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [SchemaAttr("screentip")]
        public StringValue? Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [SchemaAttr("getScreentip")]
        public StringValue? GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [SchemaAttr("supertip")]
        public StringValue? Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [SchemaAttr("getSupertip")]
        public StringValue? GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [SchemaAttr("getEnabled")]
        public StringValue? GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [SchemaAttr("getLabel")]
        public StringValue? GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [SchemaAttr("insertAfterMso")]
        public StringValue? InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [SchemaAttr("insertBeforeMso")]
        public StringValue? InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [SchemaAttr("insertAfterQ")]
        public StringValue? InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [SchemaAttr("insertBeforeQ")]
        public StringValue? InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [SchemaAttr("keytip")]
        public StringValue? Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [SchemaAttr("getKeytip")]
        public StringValue? GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr("showLabel")]
        public BooleanValue? ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [SchemaAttr("getShowLabel")]
        public StringValue? GetShowLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showImage, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr("showImage")]
        public BooleanValue? ShowImage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowImage, this property is only available in Office 2010 and later.</para>
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
            builder.SetSchema("mso14:control");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<ControlCloneRegular>()
.AddAttribute("idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
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
.AddAttribute("insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
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
            builder.AddConstraint(new AttributeMutualExclusive("mso14:size", "mso14:getSize") { Version = FileFormatVersions.Office2010 });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ControlCloneRegular>(deep);
    }

    /// <summary>
    /// <para>Defines the ButtonRegular Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:button.</para>
    /// </summary>
    [SchemaAttr("mso14:button")]
    public partial class ButtonRegular : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ButtonRegular class.
        /// </summary>
        public ButtonRegular() : base()
        {
        }

        /// <summary>
        /// <para>onAction, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        [SchemaAttr("onAction")]
        public StringValue? OnAction
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [SchemaAttr("getEnabled")]
        public StringValue? GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>description, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [SchemaAttr("description")]
        public StringValue? Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getDescription, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [SchemaAttr("getDescription")]
        public StringValue? GetDescription
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [SchemaAttr("image")]
        public StringValue? Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [SchemaAttr("imageMso")]
        public StringValue? ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [SchemaAttr("getImage")]
        public StringValue? GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [SchemaAttr("idMso")]
        public StringValue? IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [SchemaAttr("screentip")]
        public StringValue? Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [SchemaAttr("getScreentip")]
        public StringValue? GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [SchemaAttr("supertip")]
        public StringValue? Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [SchemaAttr("getSupertip")]
        public StringValue? GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [SchemaAttr("getLabel")]
        public StringValue? GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [SchemaAttr("insertAfterMso")]
        public StringValue? InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [SchemaAttr("insertBeforeMso")]
        public StringValue? InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [SchemaAttr("insertAfterQ")]
        public StringValue? InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [SchemaAttr("insertBeforeQ")]
        public StringValue? InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [SchemaAttr("keytip")]
        public StringValue? Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [SchemaAttr("getKeytip")]
        public StringValue? GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr("showLabel")]
        public BooleanValue? ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [SchemaAttr("getShowLabel")]
        public StringValue? GetShowLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showImage, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr("showImage")]
        public BooleanValue? ShowImage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowImage, this property is only available in Office 2010 and later.</para>
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
            builder.SetSchema("mso14:button");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<ButtonRegular>()
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
.AddAttribute("idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
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
.AddAttribute("insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
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
            builder.AddConstraint(new AttributeMutualExclusive("mso14:insertAfterMso", "mso14:insertAfterQ", "mso14:insertBeforeMso", "mso14:insertBeforeQ") { Version = FileFormatVersions.Office2010 });
            builder.AddConstraint(new AttributeMutualExclusive("mso14:size", "mso14:getSize") { Version = FileFormatVersions.Office2010 });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ButtonRegular>(deep);
    }

    /// <summary>
    /// <para>Defines the CheckBox Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:checkBox.</para>
    /// </summary>
    [SchemaAttr("mso14:checkBox")]
    public partial class CheckBox : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the CheckBox class.
        /// </summary>
        public CheckBox() : base()
        {
        }

        /// <summary>
        /// <para>getPressed, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getPressed</para>
        /// </summary>
        [SchemaAttr("getPressed")]
        public StringValue? GetPressed
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>onAction, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        [SchemaAttr("onAction")]
        public StringValue? OnAction
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [SchemaAttr("getEnabled")]
        public StringValue? GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>description, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [SchemaAttr("description")]
        public StringValue? Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getDescription, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [SchemaAttr("getDescription")]
        public StringValue? GetDescription
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [SchemaAttr("idMso")]
        public StringValue? IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [SchemaAttr("screentip")]
        public StringValue? Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [SchemaAttr("getScreentip")]
        public StringValue? GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [SchemaAttr("supertip")]
        public StringValue? Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [SchemaAttr("getSupertip")]
        public StringValue? GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [SchemaAttr("getLabel")]
        public StringValue? GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [SchemaAttr("insertAfterMso")]
        public StringValue? InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [SchemaAttr("insertBeforeMso")]
        public StringValue? InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [SchemaAttr("insertAfterQ")]
        public StringValue? InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [SchemaAttr("insertBeforeQ")]
        public StringValue? InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [SchemaAttr("keytip")]
        public StringValue? Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office 2010 and later.</para>
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
            builder.SetSchema("mso14:checkBox");
            builder.Availability = FileFormatVersions.Office2010;
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
.AddAttribute("idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
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
.AddAttribute("insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
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
    /// <para>Defines the GalleryRegular Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:gallery.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular" /> <c>&lt;mso14:button></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.Item" /> <c>&lt;mso14:item></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso14:gallery")]
    public partial class GalleryRegular : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the GalleryRegular class.
        /// </summary>
        public GalleryRegular() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the GalleryRegular class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GalleryRegular(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GalleryRegular class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GalleryRegular(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GalleryRegular class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public GalleryRegular(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>description, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [SchemaAttr("description")]
        public StringValue? Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getDescription, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [SchemaAttr("getDescription")]
        public StringValue? GetDescription
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>invalidateContentOnDrop, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: invalidateContentOnDrop</para>
        /// </summary>
        [SchemaAttr("invalidateContentOnDrop")]
        public BooleanValue? InvalidateContentOnDrop
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>columns, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: columns</para>
        /// </summary>
        [SchemaAttr("columns")]
        public IntegerValue? Columns
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>rows, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: rows</para>
        /// </summary>
        [SchemaAttr("rows")]
        public IntegerValue? Rows
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>itemWidth, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: itemWidth</para>
        /// </summary>
        [SchemaAttr("itemWidth")]
        public IntegerValue? ItemWidth
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>itemHeight, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: itemHeight</para>
        /// </summary>
        [SchemaAttr("itemHeight")]
        public IntegerValue? ItemHeight
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemWidth, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getItemWidth</para>
        /// </summary>
        [SchemaAttr("getItemWidth")]
        public StringValue? GetItemWidth
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemHeight, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getItemHeight</para>
        /// </summary>
        [SchemaAttr("getItemHeight")]
        public StringValue? GetItemHeight
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showItemLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: showItemLabel</para>
        /// </summary>
        [SchemaAttr("showItemLabel")]
        public BooleanValue? ShowItemLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showInRibbon, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: showInRibbon</para>
        /// </summary>
        [SchemaAttr("showInRibbon")]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.GalleryShowInRibbonValues>? ShowInRibbon
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.GalleryShowInRibbonValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>onAction, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        [SchemaAttr("onAction")]
        public StringValue? OnAction
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [SchemaAttr("getEnabled")]
        public StringValue? GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [SchemaAttr("image")]
        public StringValue? Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [SchemaAttr("imageMso")]
        public StringValue? ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [SchemaAttr("getImage")]
        public StringValue? GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showItemImage, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: showItemImage</para>
        /// </summary>
        [SchemaAttr("showItemImage")]
        public BooleanValue? ShowItemImage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemCount, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getItemCount</para>
        /// </summary>
        [SchemaAttr("getItemCount")]
        public StringValue? GetItemCount
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getItemLabel</para>
        /// </summary>
        [SchemaAttr("getItemLabel")]
        public StringValue? GetItemLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemScreentip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getItemScreentip</para>
        /// </summary>
        [SchemaAttr("getItemScreentip")]
        public StringValue? GetItemScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemSupertip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getItemSupertip</para>
        /// </summary>
        [SchemaAttr("getItemSupertip")]
        public StringValue? GetItemSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemImage, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getItemImage</para>
        /// </summary>
        [SchemaAttr("getItemImage")]
        public StringValue? GetItemImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemID, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getItemID</para>
        /// </summary>
        [SchemaAttr("getItemID")]
        public StringValue? GetItemID
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sizeString, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: sizeString</para>
        /// </summary>
        [SchemaAttr("sizeString")]
        public StringValue? SizeString
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSelectedItemID, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getSelectedItemID</para>
        /// </summary>
        [SchemaAttr("getSelectedItemID")]
        public StringValue? GetSelectedItemID
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSelectedItemIndex, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getSelectedItemIndex</para>
        /// </summary>
        [SchemaAttr("getSelectedItemIndex")]
        public StringValue? GetSelectedItemIndex
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [SchemaAttr("idMso")]
        public StringValue? IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [SchemaAttr("screentip")]
        public StringValue? Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [SchemaAttr("getScreentip")]
        public StringValue? GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [SchemaAttr("supertip")]
        public StringValue? Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [SchemaAttr("getSupertip")]
        public StringValue? GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [SchemaAttr("getLabel")]
        public StringValue? GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [SchemaAttr("insertAfterMso")]
        public StringValue? InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [SchemaAttr("insertBeforeMso")]
        public StringValue? InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [SchemaAttr("insertAfterQ")]
        public StringValue? InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [SchemaAttr("insertBeforeQ")]
        public StringValue? InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [SchemaAttr("keytip")]
        public StringValue? Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [SchemaAttr("getKeytip")]
        public StringValue? GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr("showLabel")]
        public BooleanValue? ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [SchemaAttr("getShowLabel")]
        public StringValue? GetShowLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showImage, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr("showImage")]
        public BooleanValue? ShowImage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowImage, this property is only available in Office 2010 and later.</para>
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
            builder.SetSchema("mso14:gallery");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.Item>();
            builder.AddElement<GalleryRegular>()
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
.AddAttribute("showInRibbon", a => a.ShowInRibbon)
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
.AddAttribute("idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
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
.AddAttribute("insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
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
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.Item), 0, 1000, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular), 0, 16, version: FileFormatVersions.Office2010)
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<GalleryRegular>(deep);
    }

    /// <summary>
    /// <para>Defines the ToggleButtonRegular Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:toggleButton.</para>
    /// </summary>
    [SchemaAttr("mso14:toggleButton")]
    public partial class ToggleButtonRegular : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ToggleButtonRegular class.
        /// </summary>
        public ToggleButtonRegular() : base()
        {
        }

        /// <summary>
        /// <para>getPressed, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getPressed</para>
        /// </summary>
        [SchemaAttr("getPressed")]
        public StringValue? GetPressed
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>onAction, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        [SchemaAttr("onAction")]
        public StringValue? OnAction
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [SchemaAttr("getEnabled")]
        public StringValue? GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>description, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [SchemaAttr("description")]
        public StringValue? Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getDescription, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [SchemaAttr("getDescription")]
        public StringValue? GetDescription
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [SchemaAttr("image")]
        public StringValue? Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [SchemaAttr("imageMso")]
        public StringValue? ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [SchemaAttr("getImage")]
        public StringValue? GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [SchemaAttr("idMso")]
        public StringValue? IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [SchemaAttr("screentip")]
        public StringValue? Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [SchemaAttr("getScreentip")]
        public StringValue? GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [SchemaAttr("supertip")]
        public StringValue? Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [SchemaAttr("getSupertip")]
        public StringValue? GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [SchemaAttr("getLabel")]
        public StringValue? GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [SchemaAttr("insertAfterMso")]
        public StringValue? InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [SchemaAttr("insertBeforeMso")]
        public StringValue? InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [SchemaAttr("insertAfterQ")]
        public StringValue? InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [SchemaAttr("insertBeforeQ")]
        public StringValue? InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [SchemaAttr("keytip")]
        public StringValue? Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [SchemaAttr("getKeytip")]
        public StringValue? GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr("showLabel")]
        public BooleanValue? ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [SchemaAttr("getShowLabel")]
        public StringValue? GetShowLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showImage, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr("showImage")]
        public BooleanValue? ShowImage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowImage, this property is only available in Office 2010 and later.</para>
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
            builder.SetSchema("mso14:toggleButton");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<ToggleButtonRegular>()
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
.AddAttribute("idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
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
.AddAttribute("insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
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
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ToggleButtonRegular>(deep);
    }

    /// <summary>
    /// <para>Defines the MenuSeparator Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:menuSeparator.</para>
    /// </summary>
    [SchemaAttr("mso14:menuSeparator")]
    public partial class MenuSeparator : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the MenuSeparator class.
        /// </summary>
        public MenuSeparator() : base()
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [SchemaAttr("insertAfterMso")]
        public StringValue? InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [SchemaAttr("insertBeforeMso")]
        public StringValue? InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [SchemaAttr("insertAfterQ")]
        public StringValue? InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [SchemaAttr("insertBeforeQ")]
        public StringValue? InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>title, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: title</para>
        /// </summary>
        [SchemaAttr("title")]
        public StringValue? Title
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getTitle, this property is only available in Office 2010 and later.</para>
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
            builder.SetSchema("mso14:menuSeparator");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<MenuSeparator>()
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
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
.AddAttribute("insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
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
    /// <para>Defines the SplitButtonRegular Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:splitButton.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.MenuRegular" /> <c>&lt;mso14:menu></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.VisibleButton" /> <c>&lt;mso14:button></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.VisibleToggleButton" /> <c>&lt;mso14:toggleButton></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso14:splitButton")]
    public partial class SplitButtonRegular : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SplitButtonRegular class.
        /// </summary>
        public SplitButtonRegular() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SplitButtonRegular class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SplitButtonRegular(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SplitButtonRegular class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SplitButtonRegular(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SplitButtonRegular class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SplitButtonRegular(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [SchemaAttr("getEnabled")]
        public StringValue? GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [SchemaAttr("idMso")]
        public StringValue? IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [SchemaAttr("insertAfterMso")]
        public StringValue? InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [SchemaAttr("insertBeforeMso")]
        public StringValue? InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [SchemaAttr("insertAfterQ")]
        public StringValue? InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [SchemaAttr("insertBeforeQ")]
        public StringValue? InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [SchemaAttr("keytip")]
        public StringValue? Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [SchemaAttr("getKeytip")]
        public StringValue? GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr("showLabel")]
        public BooleanValue? ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office 2010 and later.</para>
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
            builder.SetSchema("mso14:splitButton");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.MenuRegular>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.VisibleButton>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.VisibleToggleButton>();
            builder.AddElement<SplitButtonRegular>()
.AddAttribute("enabled", a => a.Enabled)
.AddAttribute("getEnabled", a => a.GetEnabled, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
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
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.VisibleButton), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.VisibleToggleButton), 1, 1, version: FileFormatVersions.Office2010)
                    },
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.MenuRegular), 1, 1, version: FileFormatVersions.Office2010)
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SplitButtonRegular>(deep);
    }

    /// <summary>
    /// <para>Defines the MenuRegular Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:menu.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular" /> <c>&lt;mso14:button></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.CheckBox" /> <c>&lt;mso14:checkBox></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.ControlCloneRegular" /> <c>&lt;mso14:control></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.DynamicMenuRegular" /> <c>&lt;mso14:dynamicMenu></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular" /> <c>&lt;mso14:gallery></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.MenuRegular" /> <c>&lt;mso14:menu></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.MenuSeparator" /> <c>&lt;mso14:menuSeparator></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonRegular" /> <c>&lt;mso14:splitButton></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.ToggleButtonRegular" /> <c>&lt;mso14:toggleButton></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso14:menu")]
    public partial class MenuRegular : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the MenuRegular class.
        /// </summary>
        public MenuRegular() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the MenuRegular class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MenuRegular(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MenuRegular class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MenuRegular(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MenuRegular class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public MenuRegular(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>itemSize, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: itemSize</para>
        /// </summary>
        [SchemaAttr("itemSize")]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues>? ItemSize
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>description, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [SchemaAttr("description")]
        public StringValue? Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getDescription, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [SchemaAttr("getDescription")]
        public StringValue? GetDescription
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [SchemaAttr("idMso")]
        public StringValue? IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [SchemaAttr("image")]
        public StringValue? Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [SchemaAttr("imageMso")]
        public StringValue? ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [SchemaAttr("getImage")]
        public StringValue? GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [SchemaAttr("screentip")]
        public StringValue? Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [SchemaAttr("getScreentip")]
        public StringValue? GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [SchemaAttr("supertip")]
        public StringValue? Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [SchemaAttr("getSupertip")]
        public StringValue? GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [SchemaAttr("getEnabled")]
        public StringValue? GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [SchemaAttr("getLabel")]
        public StringValue? GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [SchemaAttr("insertAfterMso")]
        public StringValue? InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [SchemaAttr("insertBeforeMso")]
        public StringValue? InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [SchemaAttr("insertAfterQ")]
        public StringValue? InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [SchemaAttr("insertBeforeQ")]
        public StringValue? InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [SchemaAttr("keytip")]
        public StringValue? Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [SchemaAttr("getKeytip")]
        public StringValue? GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr("showLabel")]
        public BooleanValue? ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [SchemaAttr("getShowLabel")]
        public StringValue? GetShowLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showImage, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr("showImage")]
        public BooleanValue? ShowImage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowImage, this property is only available in Office 2010 and later.</para>
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
            builder.SetSchema("mso14:menu");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.CheckBox>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.ControlCloneRegular>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.DynamicMenuRegular>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.MenuRegular>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.MenuSeparator>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonRegular>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.ToggleButtonRegular>();
            builder.AddElement<MenuRegular>()
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
.AddAttribute("idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
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
.AddAttribute("insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
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
                        new CompositeParticle.Builder(ParticleType.Group, 1, 1, version: FileFormatVersions.Office2010)
                        {
                            new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                            {
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ControlCloneRegular), 1, 1, version: FileFormatVersions.Office2010),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular), 1, 1, version: FileFormatVersions.Office2010),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.CheckBox), 1, 1, version: FileFormatVersions.Office2010),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular), 1, 1, version: FileFormatVersions.Office2010),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ToggleButtonRegular), 1, 1, version: FileFormatVersions.Office2010),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.MenuSeparator), 1, 1, version: FileFormatVersions.Office2010)
                            }
                        },
                        new CompositeParticle.Builder(ParticleType.Group, 1, 1, version: FileFormatVersions.Office2010)
                        {
                            new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                            {
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonRegular), 1, 1, version: FileFormatVersions.Office2010),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.MenuRegular), 1, 1, version: FileFormatVersions.Office2010),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.DynamicMenuRegular), 1, 1, version: FileFormatVersions.Office2010)
                            }
                        }
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MenuRegular>(deep);
    }

    /// <summary>
    /// <para>Defines the DynamicMenuRegular Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:dynamicMenu.</para>
    /// </summary>
    [SchemaAttr("mso14:dynamicMenu")]
    public partial class DynamicMenuRegular : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the DynamicMenuRegular class.
        /// </summary>
        public DynamicMenuRegular() : base()
        {
        }

        /// <summary>
        /// <para>description, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [SchemaAttr("description")]
        public StringValue? Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getDescription, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [SchemaAttr("getDescription")]
        public StringValue? GetDescription
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [SchemaAttr("idMso")]
        public StringValue? IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getContent, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getContent</para>
        /// </summary>
        [SchemaAttr("getContent")]
        public StringValue? GetContent
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>invalidateContentOnDrop, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: invalidateContentOnDrop</para>
        /// </summary>
        [SchemaAttr("invalidateContentOnDrop")]
        public BooleanValue? InvalidateContentOnDrop
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [SchemaAttr("image")]
        public StringValue? Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [SchemaAttr("imageMso")]
        public StringValue? ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [SchemaAttr("getImage")]
        public StringValue? GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [SchemaAttr("screentip")]
        public StringValue? Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [SchemaAttr("getScreentip")]
        public StringValue? GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [SchemaAttr("supertip")]
        public StringValue? Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [SchemaAttr("getSupertip")]
        public StringValue? GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [SchemaAttr("getEnabled")]
        public StringValue? GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [SchemaAttr("getLabel")]
        public StringValue? GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [SchemaAttr("insertAfterMso")]
        public StringValue? InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [SchemaAttr("insertBeforeMso")]
        public StringValue? InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [SchemaAttr("insertAfterQ")]
        public StringValue? InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [SchemaAttr("insertBeforeQ")]
        public StringValue? InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [SchemaAttr("keytip")]
        public StringValue? Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [SchemaAttr("getKeytip")]
        public StringValue? GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr("showLabel")]
        public BooleanValue? ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [SchemaAttr("getShowLabel")]
        public StringValue? GetShowLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showImage, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr("showImage")]
        public BooleanValue? ShowImage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowImage, this property is only available in Office 2010 and later.</para>
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
            builder.SetSchema("mso14:dynamicMenu");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<DynamicMenuRegular>()
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
.AddAttribute("idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
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
.AddAttribute("insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
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
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DynamicMenuRegular>(deep);
    }

    /// <summary>
    /// <para>Defines the SplitButtonWithTitle Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:splitButton.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.MenuWithTitle" /> <c>&lt;mso14:menu></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.VisibleButton" /> <c>&lt;mso14:button></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.VisibleToggleButton" /> <c>&lt;mso14:toggleButton></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso14:splitButton")]
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
        /// <para>enabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [SchemaAttr("getEnabled")]
        public StringValue? GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [SchemaAttr("idMso")]
        public StringValue? IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [SchemaAttr("insertAfterMso")]
        public StringValue? InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [SchemaAttr("insertBeforeMso")]
        public StringValue? InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [SchemaAttr("insertAfterQ")]
        public StringValue? InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [SchemaAttr("insertBeforeQ")]
        public StringValue? InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [SchemaAttr("keytip")]
        public StringValue? Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [SchemaAttr("getKeytip")]
        public StringValue? GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr("showLabel")]
        public BooleanValue? ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office 2010 and later.</para>
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
            builder.SetSchema("mso14:splitButton");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.MenuWithTitle>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.VisibleButton>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.VisibleToggleButton>();
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
.AddAttribute("idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
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
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.VisibleButton), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.VisibleToggleButton), 1, 1, version: FileFormatVersions.Office2010)
                    },
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.MenuWithTitle), 1, 1, version: FileFormatVersions.Office2010)
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SplitButtonWithTitle>(deep);
    }

    /// <summary>
    /// <para>Defines the MenuWithTitle Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:menu.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular" /> <c>&lt;mso14:button></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.CheckBox" /> <c>&lt;mso14:checkBox></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.ControlCloneRegular" /> <c>&lt;mso14:control></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.DynamicMenuRegular" /> <c>&lt;mso14:dynamicMenu></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular" /> <c>&lt;mso14:gallery></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.MenuSeparator" /> <c>&lt;mso14:menuSeparator></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.MenuWithTitle" /> <c>&lt;mso14:menu></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonWithTitle" /> <c>&lt;mso14:splitButton></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.ToggleButtonRegular" /> <c>&lt;mso14:toggleButton></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso14:menu")]
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
        /// <para>id, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [SchemaAttr("idMso")]
        public StringValue? IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>itemSize, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: itemSize</para>
        /// </summary>
        [SchemaAttr("itemSize")]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues>? ItemSize
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>title, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: title</para>
        /// </summary>
        [SchemaAttr("title")]
        public StringValue? Title
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getTitle, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getTitle</para>
        /// </summary>
        [SchemaAttr("getTitle")]
        public StringValue? GetTitle
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [SchemaAttr("image")]
        public StringValue? Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [SchemaAttr("imageMso")]
        public StringValue? ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [SchemaAttr("getImage")]
        public StringValue? GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [SchemaAttr("screentip")]
        public StringValue? Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [SchemaAttr("getScreentip")]
        public StringValue? GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [SchemaAttr("supertip")]
        public StringValue? Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [SchemaAttr("getSupertip")]
        public StringValue? GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [SchemaAttr("getEnabled")]
        public StringValue? GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [SchemaAttr("getLabel")]
        public StringValue? GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [SchemaAttr("insertAfterMso")]
        public StringValue? InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [SchemaAttr("insertBeforeMso")]
        public StringValue? InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [SchemaAttr("insertAfterQ")]
        public StringValue? InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [SchemaAttr("insertBeforeQ")]
        public StringValue? InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [SchemaAttr("keytip")]
        public StringValue? Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [SchemaAttr("getKeytip")]
        public StringValue? GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr("showLabel")]
        public BooleanValue? ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [SchemaAttr("getShowLabel")]
        public StringValue? GetShowLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showImage, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr("showImage")]
        public BooleanValue? ShowImage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowImage, this property is only available in Office 2010 and later.</para>
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
            builder.SetSchema("mso14:menu");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.CheckBox>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.ControlCloneRegular>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.DynamicMenuRegular>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.MenuSeparator>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.MenuWithTitle>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonWithTitle>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.ToggleButtonRegular>();
            builder.AddElement<MenuWithTitle>()
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
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
.AddAttribute("insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
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
                        new CompositeParticle.Builder(ParticleType.Group, 1, 1, version: FileFormatVersions.Office2010)
                        {
                            new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                            {
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ControlCloneRegular), 1, 1, version: FileFormatVersions.Office2010),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular), 1, 1, version: FileFormatVersions.Office2010),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.CheckBox), 1, 1, version: FileFormatVersions.Office2010),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular), 1, 1, version: FileFormatVersions.Office2010),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ToggleButtonRegular), 1, 1, version: FileFormatVersions.Office2010),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.MenuSeparator), 1, 1, version: FileFormatVersions.Office2010)
                            }
                        },
                        new CompositeParticle.Builder(ParticleType.Group, 1, 1, version: FileFormatVersions.Office2010)
                        {
                            new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                            {
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonWithTitle), 1, 1, version: FileFormatVersions.Office2010),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.MenuWithTitle), 1, 1, version: FileFormatVersions.Office2010),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.DynamicMenuRegular), 1, 1, version: FileFormatVersions.Office2010)
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
    /// <para>Defines the MenuSeparatorNoTitle Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:menuSeparator.</para>
    /// </summary>
    [SchemaAttr("mso14:menuSeparator")]
    public partial class MenuSeparatorNoTitle : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the MenuSeparatorNoTitle class.
        /// </summary>
        public MenuSeparatorNoTitle() : base()
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [SchemaAttr("insertAfterMso")]
        public StringValue? InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [SchemaAttr("insertBeforeMso")]
        public StringValue? InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [SchemaAttr("insertAfterQ")]
        public StringValue? InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [SchemaAttr("insertBeforeQ")]
        public StringValue? InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso14:menuSeparator");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<MenuSeparatorNoTitle>()
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
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
.AddAttribute("insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MenuSeparatorNoTitle>(deep);
    }

    /// <summary>
    /// <para>Defines the ControlClone Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:control.</para>
    /// </summary>
    [SchemaAttr("mso14:control")]
    public partial class ControlClone : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ControlClone class.
        /// </summary>
        public ControlClone() : base()
        {
        }

        /// <summary>
        /// <para>size, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: size</para>
        /// </summary>
        [SchemaAttr("size")]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues>? Size
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSize, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getSize</para>
        /// </summary>
        [SchemaAttr("getSize")]
        public StringValue? GetSize
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [SchemaAttr("getEnabled")]
        public StringValue? GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>description, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [SchemaAttr("description")]
        public StringValue? Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getDescription, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [SchemaAttr("getDescription")]
        public StringValue? GetDescription
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [SchemaAttr("image")]
        public StringValue? Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [SchemaAttr("imageMso")]
        public StringValue? ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [SchemaAttr("getImage")]
        public StringValue? GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [SchemaAttr("idMso")]
        public StringValue? IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [SchemaAttr("screentip")]
        public StringValue? Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [SchemaAttr("getScreentip")]
        public StringValue? GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [SchemaAttr("supertip")]
        public StringValue? Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [SchemaAttr("getSupertip")]
        public StringValue? GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [SchemaAttr("getLabel")]
        public StringValue? GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [SchemaAttr("insertAfterMso")]
        public StringValue? InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [SchemaAttr("insertBeforeMso")]
        public StringValue? InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [SchemaAttr("insertAfterQ")]
        public StringValue? InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [SchemaAttr("insertBeforeQ")]
        public StringValue? InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [SchemaAttr("keytip")]
        public StringValue? Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [SchemaAttr("getKeytip")]
        public StringValue? GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr("showLabel")]
        public BooleanValue? ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [SchemaAttr("getShowLabel")]
        public StringValue? GetShowLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showImage, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr("showImage")]
        public BooleanValue? ShowImage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowImage, this property is only available in Office 2010 and later.</para>
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
            builder.SetSchema("mso14:control");
            builder.Availability = FileFormatVersions.Office2010;
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
.AddAttribute("idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
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
.AddAttribute("insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
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
            builder.AddConstraint(new AttributeMutualExclusive("mso14:size", "mso14:getSize") { Version = FileFormatVersions.Office2010 });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ControlClone>(deep);
    }

    /// <summary>
    /// <para>Defines the LabelControl Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:labelControl.</para>
    /// </summary>
    [SchemaAttr("mso14:labelControl")]
    public partial class LabelControl : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the LabelControl class.
        /// </summary>
        public LabelControl() : base()
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [SchemaAttr("idMso")]
        public StringValue? IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [SchemaAttr("screentip")]
        public StringValue? Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [SchemaAttr("getScreentip")]
        public StringValue? GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [SchemaAttr("supertip")]
        public StringValue? Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [SchemaAttr("getSupertip")]
        public StringValue? GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [SchemaAttr("getEnabled")]
        public StringValue? GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [SchemaAttr("getLabel")]
        public StringValue? GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [SchemaAttr("insertAfterMso")]
        public StringValue? InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [SchemaAttr("insertBeforeMso")]
        public StringValue? InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [SchemaAttr("insertAfterQ")]
        public StringValue? InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [SchemaAttr("insertBeforeQ")]
        public StringValue? InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr("showLabel")]
        public BooleanValue? ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office 2010 and later.</para>
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
            builder.SetSchema("mso14:labelControl");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<LabelControl>()
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
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
.AddAttribute("insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
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
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LabelControl>(deep);
    }

    /// <summary>
    /// <para>Defines the Button Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:button.</para>
    /// </summary>
    [SchemaAttr("mso14:button")]
    public partial class Button : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Button class.
        /// </summary>
        public Button() : base()
        {
        }

        /// <summary>
        /// <para>size, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: size</para>
        /// </summary>
        [SchemaAttr("size")]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues>? Size
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSize, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getSize</para>
        /// </summary>
        [SchemaAttr("getSize")]
        public StringValue? GetSize
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>onAction, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        [SchemaAttr("onAction")]
        public StringValue? OnAction
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [SchemaAttr("getEnabled")]
        public StringValue? GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>description, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [SchemaAttr("description")]
        public StringValue? Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getDescription, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [SchemaAttr("getDescription")]
        public StringValue? GetDescription
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [SchemaAttr("image")]
        public StringValue? Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [SchemaAttr("imageMso")]
        public StringValue? ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [SchemaAttr("getImage")]
        public StringValue? GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [SchemaAttr("idMso")]
        public StringValue? IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [SchemaAttr("screentip")]
        public StringValue? Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [SchemaAttr("getScreentip")]
        public StringValue? GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [SchemaAttr("supertip")]
        public StringValue? Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [SchemaAttr("getSupertip")]
        public StringValue? GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [SchemaAttr("getLabel")]
        public StringValue? GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [SchemaAttr("insertAfterMso")]
        public StringValue? InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [SchemaAttr("insertBeforeMso")]
        public StringValue? InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [SchemaAttr("insertAfterQ")]
        public StringValue? InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [SchemaAttr("insertBeforeQ")]
        public StringValue? InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [SchemaAttr("keytip")]
        public StringValue? Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [SchemaAttr("getKeytip")]
        public StringValue? GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr("showLabel")]
        public BooleanValue? ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [SchemaAttr("getShowLabel")]
        public StringValue? GetShowLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showImage, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr("showImage")]
        public BooleanValue? ShowImage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowImage, this property is only available in Office 2010 and later.</para>
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
            builder.SetSchema("mso14:button");
            builder.Availability = FileFormatVersions.Office2010;
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
.AddAttribute("idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
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
.AddAttribute("insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
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
            builder.AddConstraint(new AttributeMutualExclusive("mso14:insertAfterMso", "mso14:insertAfterQ", "mso14:insertBeforeMso", "mso14:insertBeforeQ") { Version = FileFormatVersions.Office2010 });
            builder.AddConstraint(new AttributeMutualExclusive("mso14:size", "mso14:getSize") { Version = FileFormatVersions.Office2010 });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Button>(deep);
    }

    /// <summary>
    /// <para>Defines the ToggleButton Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:toggleButton.</para>
    /// </summary>
    [SchemaAttr("mso14:toggleButton")]
    public partial class ToggleButton : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ToggleButton class.
        /// </summary>
        public ToggleButton() : base()
        {
        }

        /// <summary>
        /// <para>size, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: size</para>
        /// </summary>
        [SchemaAttr("size")]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues>? Size
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSize, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getSize</para>
        /// </summary>
        [SchemaAttr("getSize")]
        public StringValue? GetSize
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getPressed, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getPressed</para>
        /// </summary>
        [SchemaAttr("getPressed")]
        public StringValue? GetPressed
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>onAction, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        [SchemaAttr("onAction")]
        public StringValue? OnAction
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [SchemaAttr("getEnabled")]
        public StringValue? GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>description, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [SchemaAttr("description")]
        public StringValue? Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getDescription, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [SchemaAttr("getDescription")]
        public StringValue? GetDescription
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [SchemaAttr("image")]
        public StringValue? Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [SchemaAttr("imageMso")]
        public StringValue? ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [SchemaAttr("getImage")]
        public StringValue? GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [SchemaAttr("idMso")]
        public StringValue? IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [SchemaAttr("screentip")]
        public StringValue? Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [SchemaAttr("getScreentip")]
        public StringValue? GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [SchemaAttr("supertip")]
        public StringValue? Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [SchemaAttr("getSupertip")]
        public StringValue? GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [SchemaAttr("getLabel")]
        public StringValue? GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [SchemaAttr("insertAfterMso")]
        public StringValue? InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [SchemaAttr("insertBeforeMso")]
        public StringValue? InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [SchemaAttr("insertAfterQ")]
        public StringValue? InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [SchemaAttr("insertBeforeQ")]
        public StringValue? InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [SchemaAttr("keytip")]
        public StringValue? Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [SchemaAttr("getKeytip")]
        public StringValue? GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr("showLabel")]
        public BooleanValue? ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [SchemaAttr("getShowLabel")]
        public StringValue? GetShowLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showImage, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr("showImage")]
        public BooleanValue? ShowImage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowImage, this property is only available in Office 2010 and later.</para>
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
            builder.SetSchema("mso14:toggleButton");
            builder.Availability = FileFormatVersions.Office2010;
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
.AddAttribute("idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
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
.AddAttribute("insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
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
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:editBox.</para>
    /// </summary>
    [SchemaAttr("mso14:editBox")]
    public partial class EditBox : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the EditBox class.
        /// </summary>
        public EditBox() : base()
        {
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [SchemaAttr("getEnabled")]
        public StringValue? GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [SchemaAttr("image")]
        public StringValue? Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [SchemaAttr("imageMso")]
        public StringValue? ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [SchemaAttr("getImage")]
        public StringValue? GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>maxLength, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: maxLength</para>
        /// </summary>
        [SchemaAttr("maxLength")]
        public IntegerValue? MaxLength
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getText, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getText</para>
        /// </summary>
        [SchemaAttr("getText")]
        public StringValue? GetText
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>onChange, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: onChange</para>
        /// </summary>
        [SchemaAttr("onChange")]
        public StringValue? OnChange
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sizeString, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: sizeString</para>
        /// </summary>
        [SchemaAttr("sizeString")]
        public StringValue? SizeString
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [SchemaAttr("idMso")]
        public StringValue? IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [SchemaAttr("screentip")]
        public StringValue? Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [SchemaAttr("getScreentip")]
        public StringValue? GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [SchemaAttr("supertip")]
        public StringValue? Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [SchemaAttr("getSupertip")]
        public StringValue? GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [SchemaAttr("getLabel")]
        public StringValue? GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [SchemaAttr("insertAfterMso")]
        public StringValue? InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [SchemaAttr("insertBeforeMso")]
        public StringValue? InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [SchemaAttr("insertAfterQ")]
        public StringValue? InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [SchemaAttr("insertBeforeQ")]
        public StringValue? InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [SchemaAttr("keytip")]
        public StringValue? Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [SchemaAttr("getKeytip")]
        public StringValue? GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr("showLabel")]
        public BooleanValue? ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [SchemaAttr("getShowLabel")]
        public StringValue? GetShowLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showImage, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr("showImage")]
        public BooleanValue? ShowImage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowImage, this property is only available in Office 2010 and later.</para>
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
            builder.SetSchema("mso14:editBox");
            builder.Availability = FileFormatVersions.Office2010;
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
.AddAttribute("idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
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
.AddAttribute("insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
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
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:comboBox.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.Item" /> <c>&lt;mso14:item></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso14:comboBox")]
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
        /// <para>showItemImage, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: showItemImage</para>
        /// </summary>
        [SchemaAttr("showItemImage")]
        public BooleanValue? ShowItemImage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemCount, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getItemCount</para>
        /// </summary>
        [SchemaAttr("getItemCount")]
        public StringValue? GetItemCount
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getItemLabel</para>
        /// </summary>
        [SchemaAttr("getItemLabel")]
        public StringValue? GetItemLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemScreentip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getItemScreentip</para>
        /// </summary>
        [SchemaAttr("getItemScreentip")]
        public StringValue? GetItemScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemSupertip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getItemSupertip</para>
        /// </summary>
        [SchemaAttr("getItemSupertip")]
        public StringValue? GetItemSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemImage, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getItemImage</para>
        /// </summary>
        [SchemaAttr("getItemImage")]
        public StringValue? GetItemImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemID, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getItemID</para>
        /// </summary>
        [SchemaAttr("getItemID")]
        public StringValue? GetItemID
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sizeString, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: sizeString</para>
        /// </summary>
        [SchemaAttr("sizeString")]
        public StringValue? SizeString
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>invalidateContentOnDrop, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: invalidateContentOnDrop</para>
        /// </summary>
        [SchemaAttr("invalidateContentOnDrop")]
        public BooleanValue? InvalidateContentOnDrop
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [SchemaAttr("getEnabled")]
        public StringValue? GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [SchemaAttr("image")]
        public StringValue? Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [SchemaAttr("imageMso")]
        public StringValue? ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [SchemaAttr("getImage")]
        public StringValue? GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>maxLength, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: maxLength</para>
        /// </summary>
        [SchemaAttr("maxLength")]
        public IntegerValue? MaxLength
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getText, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getText</para>
        /// </summary>
        [SchemaAttr("getText")]
        public StringValue? GetText
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>onChange, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: onChange</para>
        /// </summary>
        [SchemaAttr("onChange")]
        public StringValue? OnChange
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [SchemaAttr("idMso")]
        public StringValue? IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [SchemaAttr("screentip")]
        public StringValue? Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [SchemaAttr("getScreentip")]
        public StringValue? GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [SchemaAttr("supertip")]
        public StringValue? Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [SchemaAttr("getSupertip")]
        public StringValue? GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [SchemaAttr("getLabel")]
        public StringValue? GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [SchemaAttr("insertAfterMso")]
        public StringValue? InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [SchemaAttr("insertBeforeMso")]
        public StringValue? InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [SchemaAttr("insertAfterQ")]
        public StringValue? InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [SchemaAttr("insertBeforeQ")]
        public StringValue? InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [SchemaAttr("keytip")]
        public StringValue? Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [SchemaAttr("getKeytip")]
        public StringValue? GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr("showLabel")]
        public BooleanValue? ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [SchemaAttr("getShowLabel")]
        public StringValue? GetShowLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showImage, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr("showImage")]
        public BooleanValue? ShowImage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowImage, this property is only available in Office 2010 and later.</para>
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
            builder.SetSchema("mso14:comboBox");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.Item>();
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
.AddAttribute("idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
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
.AddAttribute("insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
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
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.Item), 0, 1000, version: FileFormatVersions.Office2010)
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ComboBox>(deep);
    }

    /// <summary>
    /// <para>Defines the DropDownRegular Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:dropDown.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular" /> <c>&lt;mso14:button></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.Item" /> <c>&lt;mso14:item></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso14:dropDown")]
    public partial class DropDownRegular : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the DropDownRegular class.
        /// </summary>
        public DropDownRegular() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DropDownRegular class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DropDownRegular(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DropDownRegular class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DropDownRegular(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DropDownRegular class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DropDownRegular(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>onAction, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        [SchemaAttr("onAction")]
        public StringValue? OnAction
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [SchemaAttr("getEnabled")]
        public StringValue? GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [SchemaAttr("image")]
        public StringValue? Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [SchemaAttr("imageMso")]
        public StringValue? ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [SchemaAttr("getImage")]
        public StringValue? GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showItemImage, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: showItemImage</para>
        /// </summary>
        [SchemaAttr("showItemImage")]
        public BooleanValue? ShowItemImage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemCount, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getItemCount</para>
        /// </summary>
        [SchemaAttr("getItemCount")]
        public StringValue? GetItemCount
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getItemLabel</para>
        /// </summary>
        [SchemaAttr("getItemLabel")]
        public StringValue? GetItemLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemScreentip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getItemScreentip</para>
        /// </summary>
        [SchemaAttr("getItemScreentip")]
        public StringValue? GetItemScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemSupertip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getItemSupertip</para>
        /// </summary>
        [SchemaAttr("getItemSupertip")]
        public StringValue? GetItemSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemImage, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getItemImage</para>
        /// </summary>
        [SchemaAttr("getItemImage")]
        public StringValue? GetItemImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemID, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getItemID</para>
        /// </summary>
        [SchemaAttr("getItemID")]
        public StringValue? GetItemID
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sizeString, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: sizeString</para>
        /// </summary>
        [SchemaAttr("sizeString")]
        public StringValue? SizeString
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSelectedItemID, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getSelectedItemID</para>
        /// </summary>
        [SchemaAttr("getSelectedItemID")]
        public StringValue? GetSelectedItemID
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSelectedItemIndex, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getSelectedItemIndex</para>
        /// </summary>
        [SchemaAttr("getSelectedItemIndex")]
        public StringValue? GetSelectedItemIndex
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showItemLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: showItemLabel</para>
        /// </summary>
        [SchemaAttr("showItemLabel")]
        public BooleanValue? ShowItemLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [SchemaAttr("idMso")]
        public StringValue? IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [SchemaAttr("screentip")]
        public StringValue? Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [SchemaAttr("getScreentip")]
        public StringValue? GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [SchemaAttr("supertip")]
        public StringValue? Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [SchemaAttr("getSupertip")]
        public StringValue? GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [SchemaAttr("getLabel")]
        public StringValue? GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [SchemaAttr("insertAfterMso")]
        public StringValue? InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [SchemaAttr("insertBeforeMso")]
        public StringValue? InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [SchemaAttr("insertAfterQ")]
        public StringValue? InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [SchemaAttr("insertBeforeQ")]
        public StringValue? InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [SchemaAttr("keytip")]
        public StringValue? Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [SchemaAttr("getKeytip")]
        public StringValue? GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr("showLabel")]
        public BooleanValue? ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [SchemaAttr("getShowLabel")]
        public StringValue? GetShowLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showImage, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr("showImage")]
        public BooleanValue? ShowImage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowImage, this property is only available in Office 2010 and later.</para>
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
            builder.SetSchema("mso14:dropDown");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.Item>();
            builder.AddElement<DropDownRegular>()
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
.AddAttribute("idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
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
.AddAttribute("insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
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
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.Item), 0, 1000, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular), 0, 16, version: FileFormatVersions.Office2010)
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DropDownRegular>(deep);
    }

    /// <summary>
    /// <para>Defines the Gallery Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:gallery.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular" /> <c>&lt;mso14:button></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.Item" /> <c>&lt;mso14:item></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso14:gallery")]
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
        /// <para>size, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: size</para>
        /// </summary>
        [SchemaAttr("size")]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues>? Size
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSize, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getSize</para>
        /// </summary>
        [SchemaAttr("getSize")]
        public StringValue? GetSize
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>description, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [SchemaAttr("description")]
        public StringValue? Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getDescription, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [SchemaAttr("getDescription")]
        public StringValue? GetDescription
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>invalidateContentOnDrop, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: invalidateContentOnDrop</para>
        /// </summary>
        [SchemaAttr("invalidateContentOnDrop")]
        public BooleanValue? InvalidateContentOnDrop
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>columns, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: columns</para>
        /// </summary>
        [SchemaAttr("columns")]
        public IntegerValue? Columns
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>rows, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: rows</para>
        /// </summary>
        [SchemaAttr("rows")]
        public IntegerValue? Rows
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>itemWidth, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: itemWidth</para>
        /// </summary>
        [SchemaAttr("itemWidth")]
        public IntegerValue? ItemWidth
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>itemHeight, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: itemHeight</para>
        /// </summary>
        [SchemaAttr("itemHeight")]
        public IntegerValue? ItemHeight
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemWidth, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getItemWidth</para>
        /// </summary>
        [SchemaAttr("getItemWidth")]
        public StringValue? GetItemWidth
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemHeight, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getItemHeight</para>
        /// </summary>
        [SchemaAttr("getItemHeight")]
        public StringValue? GetItemHeight
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showItemLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: showItemLabel</para>
        /// </summary>
        [SchemaAttr("showItemLabel")]
        public BooleanValue? ShowItemLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showInRibbon, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: showInRibbon</para>
        /// </summary>
        [SchemaAttr("showInRibbon")]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.GalleryShowInRibbonValues>? ShowInRibbon
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.GalleryShowInRibbonValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>onAction, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        [SchemaAttr("onAction")]
        public StringValue? OnAction
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [SchemaAttr("getEnabled")]
        public StringValue? GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [SchemaAttr("image")]
        public StringValue? Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [SchemaAttr("imageMso")]
        public StringValue? ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [SchemaAttr("getImage")]
        public StringValue? GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showItemImage, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: showItemImage</para>
        /// </summary>
        [SchemaAttr("showItemImage")]
        public BooleanValue? ShowItemImage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemCount, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getItemCount</para>
        /// </summary>
        [SchemaAttr("getItemCount")]
        public StringValue? GetItemCount
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getItemLabel</para>
        /// </summary>
        [SchemaAttr("getItemLabel")]
        public StringValue? GetItemLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemScreentip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getItemScreentip</para>
        /// </summary>
        [SchemaAttr("getItemScreentip")]
        public StringValue? GetItemScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemSupertip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getItemSupertip</para>
        /// </summary>
        [SchemaAttr("getItemSupertip")]
        public StringValue? GetItemSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemImage, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getItemImage</para>
        /// </summary>
        [SchemaAttr("getItemImage")]
        public StringValue? GetItemImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemID, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getItemID</para>
        /// </summary>
        [SchemaAttr("getItemID")]
        public StringValue? GetItemID
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sizeString, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: sizeString</para>
        /// </summary>
        [SchemaAttr("sizeString")]
        public StringValue? SizeString
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSelectedItemID, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getSelectedItemID</para>
        /// </summary>
        [SchemaAttr("getSelectedItemID")]
        public StringValue? GetSelectedItemID
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSelectedItemIndex, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getSelectedItemIndex</para>
        /// </summary>
        [SchemaAttr("getSelectedItemIndex")]
        public StringValue? GetSelectedItemIndex
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [SchemaAttr("idMso")]
        public StringValue? IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [SchemaAttr("screentip")]
        public StringValue? Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [SchemaAttr("getScreentip")]
        public StringValue? GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [SchemaAttr("supertip")]
        public StringValue? Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [SchemaAttr("getSupertip")]
        public StringValue? GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [SchemaAttr("getLabel")]
        public StringValue? GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [SchemaAttr("insertAfterMso")]
        public StringValue? InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [SchemaAttr("insertBeforeMso")]
        public StringValue? InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [SchemaAttr("insertAfterQ")]
        public StringValue? InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [SchemaAttr("insertBeforeQ")]
        public StringValue? InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [SchemaAttr("keytip")]
        public StringValue? Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [SchemaAttr("getKeytip")]
        public StringValue? GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr("showLabel")]
        public BooleanValue? ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [SchemaAttr("getShowLabel")]
        public StringValue? GetShowLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showImage, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr("showImage")]
        public BooleanValue? ShowImage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowImage, this property is only available in Office 2010 and later.</para>
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
            builder.SetSchema("mso14:gallery");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.Item>();
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
.AddAttribute("showInRibbon", a => a.ShowInRibbon)
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
.AddAttribute("idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
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
.AddAttribute("insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
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
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.Item), 0, 1000, version: FileFormatVersions.Office2010),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular), 0, 16, version: FileFormatVersions.Office2010)
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
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:menu.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular" /> <c>&lt;mso14:button></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.CheckBox" /> <c>&lt;mso14:checkBox></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.ControlCloneRegular" /> <c>&lt;mso14:control></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.DynamicMenuRegular" /> <c>&lt;mso14:dynamicMenu></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular" /> <c>&lt;mso14:gallery></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.MenuRegular" /> <c>&lt;mso14:menu></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.MenuSeparator" /> <c>&lt;mso14:menuSeparator></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonRegular" /> <c>&lt;mso14:splitButton></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.ToggleButtonRegular" /> <c>&lt;mso14:toggleButton></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso14:menu")]
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
        /// <para>size, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: size</para>
        /// </summary>
        [SchemaAttr("size")]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues>? Size
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSize, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getSize</para>
        /// </summary>
        [SchemaAttr("getSize")]
        public StringValue? GetSize
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>itemSize, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: itemSize</para>
        /// </summary>
        [SchemaAttr("itemSize")]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues>? ItemSize
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>description, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [SchemaAttr("description")]
        public StringValue? Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getDescription, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [SchemaAttr("getDescription")]
        public StringValue? GetDescription
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [SchemaAttr("idMso")]
        public StringValue? IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [SchemaAttr("image")]
        public StringValue? Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [SchemaAttr("imageMso")]
        public StringValue? ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [SchemaAttr("getImage")]
        public StringValue? GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [SchemaAttr("screentip")]
        public StringValue? Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [SchemaAttr("getScreentip")]
        public StringValue? GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [SchemaAttr("supertip")]
        public StringValue? Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [SchemaAttr("getSupertip")]
        public StringValue? GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [SchemaAttr("getEnabled")]
        public StringValue? GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [SchemaAttr("getLabel")]
        public StringValue? GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [SchemaAttr("insertAfterMso")]
        public StringValue? InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [SchemaAttr("insertBeforeMso")]
        public StringValue? InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [SchemaAttr("insertAfterQ")]
        public StringValue? InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [SchemaAttr("insertBeforeQ")]
        public StringValue? InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [SchemaAttr("keytip")]
        public StringValue? Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [SchemaAttr("getKeytip")]
        public StringValue? GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr("showLabel")]
        public BooleanValue? ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [SchemaAttr("getShowLabel")]
        public StringValue? GetShowLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showImage, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr("showImage")]
        public BooleanValue? ShowImage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowImage, this property is only available in Office 2010 and later.</para>
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
            builder.SetSchema("mso14:menu");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.CheckBox>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.ControlCloneRegular>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.DynamicMenuRegular>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.MenuRegular>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.MenuSeparator>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonRegular>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.ToggleButtonRegular>();
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
.AddAttribute("idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
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
.AddAttribute("insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
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
                            new CompositeParticle.Builder(ParticleType.Group, 1, 1, version: FileFormatVersions.Office2010)
                            {
                                new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                {
                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ControlCloneRegular), 1, 1, version: FileFormatVersions.Office2010),
                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular), 1, 1, version: FileFormatVersions.Office2010),
                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.CheckBox), 1, 1, version: FileFormatVersions.Office2010),
                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular), 1, 1, version: FileFormatVersions.Office2010),
                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ToggleButtonRegular), 1, 1, version: FileFormatVersions.Office2010),
                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.MenuSeparator), 1, 1, version: FileFormatVersions.Office2010)
                                }
                            },
                            new CompositeParticle.Builder(ParticleType.Group, 1, 1, version: FileFormatVersions.Office2010)
                            {
                                new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                                {
                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonRegular), 1, 1, version: FileFormatVersions.Office2010),
                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.MenuRegular), 1, 1, version: FileFormatVersions.Office2010),
                                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.DynamicMenuRegular), 1, 1, version: FileFormatVersions.Office2010)
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
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:dynamicMenu.</para>
    /// </summary>
    [SchemaAttr("mso14:dynamicMenu")]
    public partial class DynamicMenu : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the DynamicMenu class.
        /// </summary>
        public DynamicMenu() : base()
        {
        }

        /// <summary>
        /// <para>size, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: size</para>
        /// </summary>
        [SchemaAttr("size")]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues>? Size
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSize, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getSize</para>
        /// </summary>
        [SchemaAttr("getSize")]
        public StringValue? GetSize
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>description, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [SchemaAttr("description")]
        public StringValue? Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getDescription, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [SchemaAttr("getDescription")]
        public StringValue? GetDescription
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [SchemaAttr("idMso")]
        public StringValue? IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getContent, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getContent</para>
        /// </summary>
        [SchemaAttr("getContent")]
        public StringValue? GetContent
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>invalidateContentOnDrop, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: invalidateContentOnDrop</para>
        /// </summary>
        [SchemaAttr("invalidateContentOnDrop")]
        public BooleanValue? InvalidateContentOnDrop
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [SchemaAttr("image")]
        public StringValue? Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [SchemaAttr("imageMso")]
        public StringValue? ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [SchemaAttr("getImage")]
        public StringValue? GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [SchemaAttr("screentip")]
        public StringValue? Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [SchemaAttr("getScreentip")]
        public StringValue? GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [SchemaAttr("supertip")]
        public StringValue? Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [SchemaAttr("getSupertip")]
        public StringValue? GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [SchemaAttr("getEnabled")]
        public StringValue? GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [SchemaAttr("getLabel")]
        public StringValue? GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [SchemaAttr("insertAfterMso")]
        public StringValue? InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [SchemaAttr("insertBeforeMso")]
        public StringValue? InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [SchemaAttr("insertAfterQ")]
        public StringValue? InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [SchemaAttr("insertBeforeQ")]
        public StringValue? InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [SchemaAttr("keytip")]
        public StringValue? Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [SchemaAttr("getKeytip")]
        public StringValue? GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr("showLabel")]
        public BooleanValue? ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [SchemaAttr("getShowLabel")]
        public StringValue? GetShowLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showImage, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr("showImage")]
        public BooleanValue? ShowImage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowImage, this property is only available in Office 2010 and later.</para>
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
            builder.SetSchema("mso14:dynamicMenu");
            builder.Availability = FileFormatVersions.Office2010;
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
.AddAttribute("idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
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
.AddAttribute("insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
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
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:splitButton.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.MenuRegular" /> <c>&lt;mso14:menu></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.VisibleButton" /> <c>&lt;mso14:button></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.VisibleToggleButton" /> <c>&lt;mso14:toggleButton></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso14:splitButton")]
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
        /// <para>size, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: size</para>
        /// </summary>
        [SchemaAttr("size")]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues>? Size
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSize, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getSize</para>
        /// </summary>
        [SchemaAttr("getSize")]
        public StringValue? GetSize
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [SchemaAttr("getEnabled")]
        public StringValue? GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [SchemaAttr("idMso")]
        public StringValue? IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [SchemaAttr("insertAfterMso")]
        public StringValue? InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [SchemaAttr("insertBeforeMso")]
        public StringValue? InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [SchemaAttr("insertAfterQ")]
        public StringValue? InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [SchemaAttr("insertBeforeQ")]
        public StringValue? InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [SchemaAttr("keytip")]
        public StringValue? Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [SchemaAttr("getKeytip")]
        public StringValue? GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr("showLabel")]
        public BooleanValue? ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office 2010 and later.</para>
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
            builder.SetSchema("mso14:splitButton");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.MenuRegular>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.VisibleButton>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.VisibleToggleButton>();
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
.AddAttribute("idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
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
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.VisibleButton), 1, 1, version: FileFormatVersions.Office2010),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.VisibleToggleButton), 1, 1, version: FileFormatVersions.Office2010)
                        },
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.MenuRegular), 1, 1, version: FileFormatVersions.Office2010)
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SplitButton>(deep);
    }

    /// <summary>
    /// <para>Defines the Box Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:box.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.Box" /> <c>&lt;mso14:box></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.Button" /> <c>&lt;mso14:button></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.ButtonGroup" /> <c>&lt;mso14:buttonGroup></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.CheckBox" /> <c>&lt;mso14:checkBox></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.ComboBox" /> <c>&lt;mso14:comboBox></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.ControlClone" /> <c>&lt;mso14:control></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular" /> <c>&lt;mso14:dropDown></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.DynamicMenu" /> <c>&lt;mso14:dynamicMenu></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.EditBox" /> <c>&lt;mso14:editBox></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.Gallery" /> <c>&lt;mso14:gallery></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.LabelControl" /> <c>&lt;mso14:labelControl></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.Menu" /> <c>&lt;mso14:menu></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.SplitButton" /> <c>&lt;mso14:splitButton></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.ToggleButton" /> <c>&lt;mso14:toggleButton></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso14:box")]
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
        /// <para>id, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [SchemaAttr("insertAfterMso")]
        public StringValue? InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [SchemaAttr("insertBeforeMso")]
        public StringValue? InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [SchemaAttr("insertAfterQ")]
        public StringValue? InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [SchemaAttr("insertBeforeQ")]
        public StringValue? InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>boxStyle, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: boxStyle</para>
        /// </summary>
        [SchemaAttr("boxStyle")]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.BoxStyleValues>? BoxStyle
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.BoxStyleValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso14:box");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.Box>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.Button>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.ButtonGroup>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.CheckBox>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.ComboBox>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.ControlClone>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.DynamicMenu>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.EditBox>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.Gallery>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.LabelControl>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.Menu>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.SplitButton>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.ToggleButton>();
            builder.AddElement<Box>()
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
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
.AddAttribute("insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("boxStyle", a => a.BoxStyle);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Group, 0, 1000, version: FileFormatVersions.Office2010)
            {
                new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ControlClone), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.LabelControl), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.Button), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ToggleButton), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.CheckBox), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.EditBox), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ComboBox), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.Gallery), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.Menu), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.DynamicMenu), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.SplitButton), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.Box), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ButtonGroup), 1, 1, version: FileFormatVersions.Office2010)
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Box>(deep);
    }

    /// <summary>
    /// <para>Defines the ButtonGroup Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:buttonGroup.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular" /> <c>&lt;mso14:button></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.ControlCloneRegular" /> <c>&lt;mso14:control></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.DynamicMenuRegular" /> <c>&lt;mso14:dynamicMenu></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular" /> <c>&lt;mso14:gallery></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.MenuRegular" /> <c>&lt;mso14:menu></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.Separator" /> <c>&lt;mso14:separator></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonRegular" /> <c>&lt;mso14:splitButton></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.ToggleButtonRegular" /> <c>&lt;mso14:toggleButton></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso14:buttonGroup")]
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
        /// <para>id, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [SchemaAttr("insertAfterMso")]
        public StringValue? InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [SchemaAttr("insertBeforeMso")]
        public StringValue? InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [SchemaAttr("insertAfterQ")]
        public StringValue? InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [SchemaAttr("insertBeforeQ")]
        public StringValue? InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso14:buttonGroup");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.ControlCloneRegular>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.DynamicMenuRegular>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.MenuRegular>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.Separator>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonRegular>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.ToggleButtonRegular>();
            builder.AddElement<ButtonGroup>()
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
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
.AddAttribute("insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Choice, 0, 1000)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ControlCloneRegular), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ToggleButtonRegular), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.MenuRegular), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.DynamicMenuRegular), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonRegular), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.Separator), 1, 1, version: FileFormatVersions.Office2010)
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ButtonGroup>(deep);
    }

    /// <summary>
    /// <para>Defines the BackstageMenuButton Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:button.</para>
    /// </summary>
    [SchemaAttr("mso14:button")]
    public partial class BackstageMenuButton : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the BackstageMenuButton class.
        /// </summary>
        public BackstageMenuButton() : base()
        {
        }

        /// <summary>
        /// <para>description, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [SchemaAttr("description")]
        public StringValue? Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getDescription, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [SchemaAttr("getDescription")]
        public StringValue? GetDescription
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>onAction, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        [SchemaAttr("onAction")]
        public StringValue? OnAction
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>isDefinitive, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: isDefinitive</para>
        /// </summary>
        [SchemaAttr("isDefinitive")]
        public BooleanValue? IsDefinitive
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [SchemaAttr("getEnabled")]
        public StringValue? GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [SchemaAttr("getLabel")]
        public StringValue? GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [SchemaAttr("keytip")]
        public StringValue? Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [SchemaAttr("getKeytip")]
        public StringValue? GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [SchemaAttr("image")]
        public StringValue? Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [SchemaAttr("imageMso")]
        public StringValue? ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [SchemaAttr("getImage")]
        public StringValue? GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso14:button");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<BackstageMenuButton>()
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
.AddAttribute("idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("onAction", a => a.OnAction, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("isDefinitive", a => a.IsDefinitive)
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
});
            builder.AddConstraint(new AttributeMutualExclusive("mso14:insertAfterMso", "mso14:insertAfterQ", "mso14:insertBeforeMso", "mso14:insertBeforeQ") { Version = FileFormatVersions.Office2010 });
            builder.AddConstraint(new AttributeMutualExclusive("mso14:size", "mso14:getSize") { Version = FileFormatVersions.Office2010 });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackstageMenuButton>(deep);
    }

    /// <summary>
    /// <para>Defines the BackstageMenuCheckBox Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:checkBox.</para>
    /// </summary>
    [SchemaAttr("mso14:checkBox")]
    public partial class BackstageMenuCheckBox : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the BackstageMenuCheckBox class.
        /// </summary>
        public BackstageMenuCheckBox() : base()
        {
        }

        /// <summary>
        /// <para>description, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [SchemaAttr("description")]
        public StringValue? Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getDescription, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [SchemaAttr("getDescription")]
        public StringValue? GetDescription
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>onAction, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        [SchemaAttr("onAction")]
        public StringValue? OnAction
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getPressed, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getPressed</para>
        /// </summary>
        [SchemaAttr("getPressed")]
        public StringValue? GetPressed
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [SchemaAttr("getEnabled")]
        public StringValue? GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [SchemaAttr("getLabel")]
        public StringValue? GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [SchemaAttr("keytip")]
        public StringValue? Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office 2010 and later.</para>
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
            builder.SetSchema("mso14:checkBox");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<BackstageMenuCheckBox>()
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
.AddAttribute("idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("onAction", a => a.OnAction, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getPressed", a => a.GetPressed, aBuilder =>
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
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackstageMenuCheckBox>(deep);
    }

    /// <summary>
    /// <para>Defines the BackstageSubMenu Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:menu.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuGroup" /> <c>&lt;mso14:menuGroup></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso14:menu")]
    public partial class BackstageSubMenu : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the BackstageSubMenu class.
        /// </summary>
        public BackstageSubMenu() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BackstageSubMenu class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BackstageSubMenu(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BackstageSubMenu class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BackstageSubMenu(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BackstageSubMenu class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public BackstageSubMenu(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>description, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [SchemaAttr("description")]
        public StringValue? Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getDescription, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [SchemaAttr("getDescription")]
        public StringValue? GetDescription
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [SchemaAttr("getEnabled")]
        public StringValue? GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [SchemaAttr("getLabel")]
        public StringValue? GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [SchemaAttr("image")]
        public StringValue? Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [SchemaAttr("imageMso")]
        public StringValue? ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [SchemaAttr("getImage")]
        public StringValue? GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [SchemaAttr("keytip")]
        public StringValue? Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office 2010 and later.</para>
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
            builder.SetSchema("mso14:menu");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuGroup>();
            builder.AddElement<BackstageSubMenu>()
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
.AddAttribute("idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
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
.AddAttribute("visible", a => a.Visible)
.AddAttribute("getVisible", a => a.GetVisible, aBuilder =>
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
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuGroup), 1, 1, version: FileFormatVersions.Office2010)
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackstageSubMenu>(deep);
    }

    /// <summary>
    /// <para>Defines the BackstageMenuToggleButton Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:toggleButton.</para>
    /// </summary>
    [SchemaAttr("mso14:toggleButton")]
    public partial class BackstageMenuToggleButton : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the BackstageMenuToggleButton class.
        /// </summary>
        public BackstageMenuToggleButton() : base()
        {
        }

        /// <summary>
        /// <para>image, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [SchemaAttr("image")]
        public StringValue? Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [SchemaAttr("imageMso")]
        public StringValue? ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [SchemaAttr("getImage")]
        public StringValue? GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>description, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [SchemaAttr("description")]
        public StringValue? Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getDescription, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [SchemaAttr("getDescription")]
        public StringValue? GetDescription
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>onAction, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        [SchemaAttr("onAction")]
        public StringValue? OnAction
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getPressed, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getPressed</para>
        /// </summary>
        [SchemaAttr("getPressed")]
        public StringValue? GetPressed
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [SchemaAttr("getEnabled")]
        public StringValue? GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [SchemaAttr("getLabel")]
        public StringValue? GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [SchemaAttr("keytip")]
        public StringValue? Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office 2010 and later.</para>
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
            builder.SetSchema("mso14:toggleButton");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<BackstageMenuToggleButton>()
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
.AddAttribute("idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("onAction", a => a.OnAction, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getPressed", a => a.GetPressed, aBuilder =>
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
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackstageMenuToggleButton>(deep);
    }

    /// <summary>
    /// <para>Defines the BackstageGroupButton Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:button.</para>
    /// </summary>
    [SchemaAttr("mso14:button")]
    public partial class BackstageGroupButton : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the BackstageGroupButton class.
        /// </summary>
        public BackstageGroupButton() : base()
        {
        }

        /// <summary>
        /// <para>expand, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: expand</para>
        /// </summary>
        [SchemaAttr("expand")]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>? Expand
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>style, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: style</para>
        /// </summary>
        [SchemaAttr("style")]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.Style2Values>? Style
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.Style2Values>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [SchemaAttr("screentip")]
        public StringValue? Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [SchemaAttr("getScreentip")]
        public StringValue? GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [SchemaAttr("supertip")]
        public StringValue? Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [SchemaAttr("getSupertip")]
        public StringValue? GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>onAction, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        [SchemaAttr("onAction")]
        public StringValue? OnAction
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>isDefinitive, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: isDefinitive</para>
        /// </summary>
        [SchemaAttr("isDefinitive")]
        public BooleanValue? IsDefinitive
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [SchemaAttr("getEnabled")]
        public StringValue? GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [SchemaAttr("getLabel")]
        public StringValue? GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [SchemaAttr("keytip")]
        public StringValue? Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [SchemaAttr("getKeytip")]
        public StringValue? GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [SchemaAttr("image")]
        public StringValue? Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [SchemaAttr("imageMso")]
        public StringValue? ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [SchemaAttr("getImage")]
        public StringValue? GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso14:button");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<BackstageGroupButton>()
.AddAttribute("expand", a => a.Expand)
.AddAttribute("style", a => a.Style)
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
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("onAction", a => a.OnAction, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("isDefinitive", a => a.IsDefinitive)
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
});
            builder.AddConstraint(new AttributeMutualExclusive("mso14:insertAfterMso", "mso14:insertAfterQ", "mso14:insertBeforeMso", "mso14:insertBeforeQ") { Version = FileFormatVersions.Office2010 });
            builder.AddConstraint(new AttributeMutualExclusive("mso14:size", "mso14:getSize") { Version = FileFormatVersions.Office2010 });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackstageGroupButton>(deep);
    }

    /// <summary>
    /// <para>Defines the BackstageCheckBox Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:checkBox.</para>
    /// </summary>
    [SchemaAttr("mso14:checkBox")]
    public partial class BackstageCheckBox : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the BackstageCheckBox class.
        /// </summary>
        public BackstageCheckBox() : base()
        {
        }

        /// <summary>
        /// <para>expand, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: expand</para>
        /// </summary>
        [SchemaAttr("expand")]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>? Expand
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>description, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [SchemaAttr("description")]
        public StringValue? Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getDescription, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [SchemaAttr("getDescription")]
        public StringValue? GetDescription
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [SchemaAttr("screentip")]
        public StringValue? Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [SchemaAttr("getScreentip")]
        public StringValue? GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [SchemaAttr("supertip")]
        public StringValue? Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [SchemaAttr("getSupertip")]
        public StringValue? GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>onAction, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        [SchemaAttr("onAction")]
        public StringValue? OnAction
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getPressed, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getPressed</para>
        /// </summary>
        [SchemaAttr("getPressed")]
        public StringValue? GetPressed
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [SchemaAttr("getEnabled")]
        public StringValue? GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [SchemaAttr("getLabel")]
        public StringValue? GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [SchemaAttr("keytip")]
        public StringValue? Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office 2010 and later.</para>
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
            builder.SetSchema("mso14:checkBox");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<BackstageCheckBox>()
.AddAttribute("expand", a => a.Expand)
.AddAttribute("description", a => a.Description, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (4096L) });
})
.AddAttribute("getDescription", a => a.GetDescription, aBuilder =>
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
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("onAction", a => a.OnAction, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getPressed", a => a.GetPressed, aBuilder =>
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
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackstageCheckBox>(deep);
    }

    /// <summary>
    /// <para>Defines the BackstageEditBox Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:editBox.</para>
    /// </summary>
    [SchemaAttr("mso14:editBox")]
    public partial class BackstageEditBox : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the BackstageEditBox class.
        /// </summary>
        public BackstageEditBox() : base()
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>alignLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: alignLabel</para>
        /// </summary>
        [SchemaAttr("alignLabel")]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>? AlignLabel
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>expand, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: expand</para>
        /// </summary>
        [SchemaAttr("expand")]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>? Expand
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [SchemaAttr("getEnabled")]
        public StringValue? GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [SchemaAttr("getLabel")]
        public StringValue? GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [SchemaAttr("keytip")]
        public StringValue? Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [SchemaAttr("getKeytip")]
        public StringValue? GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getText, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getText</para>
        /// </summary>
        [SchemaAttr("getText")]
        public StringValue? GetText
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>onChange, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: onChange</para>
        /// </summary>
        [SchemaAttr("onChange")]
        public StringValue? OnChange
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>maxLength, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: maxLength</para>
        /// </summary>
        [SchemaAttr("maxLength")]
        public IntegerValue? MaxLength
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sizeString, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: sizeString</para>
        /// </summary>
        [SchemaAttr("sizeString")]
        public StringValue? SizeString
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso14:editBox");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<BackstageEditBox>()
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("alignLabel", a => a.AlignLabel)
.AddAttribute("expand", a => a.Expand)
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
.AddAttribute("getText", a => a.GetText, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("onChange", a => a.OnChange, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("maxLength", a => a.MaxLength, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (1L), MaxInclusive = (1024L), IsPositive = (true) });
})
.AddAttribute("sizeString", a => a.SizeString, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackstageEditBox>(deep);
    }

    /// <summary>
    /// <para>Defines the BackstageDropDown Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:dropDown.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.ItemBackstageItem" /> <c>&lt;mso14:item></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso14:dropDown")]
    public partial class BackstageDropDown : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the BackstageDropDown class.
        /// </summary>
        public BackstageDropDown() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BackstageDropDown class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BackstageDropDown(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BackstageDropDown class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BackstageDropDown(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BackstageDropDown class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public BackstageDropDown(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>alignLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: alignLabel</para>
        /// </summary>
        [SchemaAttr("alignLabel")]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>? AlignLabel
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>expand, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: expand</para>
        /// </summary>
        [SchemaAttr("expand")]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>? Expand
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [SchemaAttr("getEnabled")]
        public StringValue? GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [SchemaAttr("getLabel")]
        public StringValue? GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>onAction, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        [SchemaAttr("onAction")]
        public StringValue? OnAction
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [SchemaAttr("screentip")]
        public StringValue? Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [SchemaAttr("getScreentip")]
        public StringValue? GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [SchemaAttr("supertip")]
        public StringValue? Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [SchemaAttr("getSupertip")]
        public StringValue? GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [SchemaAttr("keytip")]
        public StringValue? Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [SchemaAttr("getKeytip")]
        public StringValue? GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSelectedItemIndex, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getSelectedItemIndex</para>
        /// </summary>
        [SchemaAttr("getSelectedItemIndex")]
        public StringValue? GetSelectedItemIndex
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sizeString, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: sizeString</para>
        /// </summary>
        [SchemaAttr("sizeString")]
        public StringValue? SizeString
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemCount, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getItemCount</para>
        /// </summary>
        [SchemaAttr("getItemCount")]
        public StringValue? GetItemCount
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getItemLabel</para>
        /// </summary>
        [SchemaAttr("getItemLabel")]
        public StringValue? GetItemLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemID, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getItemID</para>
        /// </summary>
        [SchemaAttr("getItemID")]
        public StringValue? GetItemID
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso14:dropDown");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.ItemBackstageItem>();
            builder.AddElement<BackstageDropDown>()
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("alignLabel", a => a.AlignLabel)
.AddAttribute("expand", a => a.Expand)
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
.AddAttribute("visible", a => a.Visible)
.AddAttribute("getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("onAction", a => a.OnAction, aBuilder =>
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
.AddAttribute("keytip", a => a.Keytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), MinLength = (1L), MaxLength = (3L) });
})
.AddAttribute("getKeytip", a => a.GetKeytip, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getSelectedItemIndex", a => a.GetSelectedItemIndex, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("sizeString", a => a.SizeString, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getItemCount", a => a.GetItemCount, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getItemLabel", a => a.GetItemLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getItemID", a => a.GetItemID, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ItemBackstageItem), 0, 1000, version: FileFormatVersions.Office2010)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackstageDropDown>(deep);
    }

    /// <summary>
    /// <para>Defines the RadioGroup Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:radioGroup.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.RadioButtonBackstageItem" /> <c>&lt;mso14:radioButton></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso14:radioGroup")]
    public partial class RadioGroup : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the RadioGroup class.
        /// </summary>
        public RadioGroup() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the RadioGroup class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RadioGroup(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RadioGroup class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public RadioGroup(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RadioGroup class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public RadioGroup(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>alignLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: alignLabel</para>
        /// </summary>
        [SchemaAttr("alignLabel")]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>? AlignLabel
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>expand, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: expand</para>
        /// </summary>
        [SchemaAttr("expand")]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>? Expand
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [SchemaAttr("getEnabled")]
        public StringValue? GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [SchemaAttr("getLabel")]
        public StringValue? GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>onAction, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        [SchemaAttr("onAction")]
        public StringValue? OnAction
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [SchemaAttr("keytip")]
        public StringValue? Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [SchemaAttr("getKeytip")]
        public StringValue? GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSelectedItemIndex, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getSelectedItemIndex</para>
        /// </summary>
        [SchemaAttr("getSelectedItemIndex")]
        public StringValue? GetSelectedItemIndex
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemCount, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getItemCount</para>
        /// </summary>
        [SchemaAttr("getItemCount")]
        public StringValue? GetItemCount
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getItemLabel</para>
        /// </summary>
        [SchemaAttr("getItemLabel")]
        public StringValue? GetItemLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemID, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getItemID</para>
        /// </summary>
        [SchemaAttr("getItemID")]
        public StringValue? GetItemID
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso14:radioGroup");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.RadioButtonBackstageItem>();
            builder.AddElement<RadioGroup>()
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("alignLabel", a => a.AlignLabel)
.AddAttribute("expand", a => a.Expand)
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
.AddAttribute("visible", a => a.Visible)
.AddAttribute("getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("onAction", a => a.OnAction, aBuilder =>
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
.AddAttribute("getSelectedItemIndex", a => a.GetSelectedItemIndex, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getItemCount", a => a.GetItemCount, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getItemLabel", a => a.GetItemLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getItemID", a => a.GetItemID, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.RadioButtonBackstageItem), 0, 1000, version: FileFormatVersions.Office2010)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RadioGroup>(deep);
    }

    /// <summary>
    /// <para>Defines the BackstageComboBox Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:comboBox.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.ItemBackstageItem" /> <c>&lt;mso14:item></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso14:comboBox")]
    public partial class BackstageComboBox : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the BackstageComboBox class.
        /// </summary>
        public BackstageComboBox() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BackstageComboBox class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BackstageComboBox(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BackstageComboBox class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BackstageComboBox(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BackstageComboBox class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public BackstageComboBox(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>alignLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: alignLabel</para>
        /// </summary>
        [SchemaAttr("alignLabel")]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>? AlignLabel
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>expand, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: expand</para>
        /// </summary>
        [SchemaAttr("expand")]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>? Expand
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [SchemaAttr("getEnabled")]
        public StringValue? GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [SchemaAttr("getLabel")]
        public StringValue? GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [SchemaAttr("keytip")]
        public StringValue? Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [SchemaAttr("getKeytip")]
        public StringValue? GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getText, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getText</para>
        /// </summary>
        [SchemaAttr("getText")]
        public StringValue? GetText
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>onChange, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: onChange</para>
        /// </summary>
        [SchemaAttr("onChange")]
        public StringValue? OnChange
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>sizeString, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: sizeString</para>
        /// </summary>
        [SchemaAttr("sizeString")]
        public StringValue? SizeString
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemCount, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getItemCount</para>
        /// </summary>
        [SchemaAttr("getItemCount")]
        public StringValue? GetItemCount
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getItemLabel</para>
        /// </summary>
        [SchemaAttr("getItemLabel")]
        public StringValue? GetItemLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getItemID, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getItemID</para>
        /// </summary>
        [SchemaAttr("getItemID")]
        public StringValue? GetItemID
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso14:comboBox");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.ItemBackstageItem>();
            builder.AddElement<BackstageComboBox>()
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("alignLabel", a => a.AlignLabel)
.AddAttribute("expand", a => a.Expand)
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
.AddAttribute("getItemCount", a => a.GetItemCount, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getItemLabel", a => a.GetItemLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getItemID", a => a.GetItemID, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ItemBackstageItem), 0, 1000, version: FileFormatVersions.Office2010)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackstageComboBox>(deep);
    }

    /// <summary>
    /// <para>Defines the Hyperlink Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:hyperlink.</para>
    /// </summary>
    [SchemaAttr("mso14:hyperlink")]
    public partial class Hyperlink : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Hyperlink class.
        /// </summary>
        public Hyperlink() : base()
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>alignLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: alignLabel</para>
        /// </summary>
        [SchemaAttr("alignLabel")]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>? AlignLabel
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>expand, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: expand</para>
        /// </summary>
        [SchemaAttr("expand")]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>? Expand
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [SchemaAttr("getEnabled")]
        public StringValue? GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [SchemaAttr("keytip")]
        public StringValue? Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [SchemaAttr("getKeytip")]
        public StringValue? GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [SchemaAttr("getLabel")]
        public StringValue? GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>onAction, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        [SchemaAttr("onAction")]
        public StringValue? OnAction
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [SchemaAttr("image")]
        public StringValue? Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [SchemaAttr("imageMso")]
        public StringValue? ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [SchemaAttr("getImage")]
        public StringValue? GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [SchemaAttr("screentip")]
        public StringValue? Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [SchemaAttr("getScreentip")]
        public StringValue? GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [SchemaAttr("supertip")]
        public StringValue? Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [SchemaAttr("getSupertip")]
        public StringValue? GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>target, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: target</para>
        /// </summary>
        [SchemaAttr("target")]
        public StringValue? Target
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getTarget, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getTarget</para>
        /// </summary>
        [SchemaAttr("getTarget")]
        public StringValue? GetTarget
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso14:hyperlink");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<Hyperlink>()
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("alignLabel", a => a.AlignLabel)
.AddAttribute("expand", a => a.Expand)
.AddAttribute("enabled", a => a.Enabled)
.AddAttribute("getEnabled", a => a.GetEnabled, aBuilder =>
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
})
.AddAttribute("label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("onAction", a => a.OnAction, aBuilder =>
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
.AddAttribute("target", a => a.Target, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getTarget", a => a.GetTarget, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Hyperlink>(deep);
    }

    /// <summary>
    /// <para>Defines the BackstageLabelControl Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:labelControl.</para>
    /// </summary>
    [SchemaAttr("mso14:labelControl")]
    public partial class BackstageLabelControl : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the BackstageLabelControl class.
        /// </summary>
        public BackstageLabelControl() : base()
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>alignLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: alignLabel</para>
        /// </summary>
        [SchemaAttr("alignLabel")]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>? AlignLabel
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>expand, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: expand</para>
        /// </summary>
        [SchemaAttr("expand")]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>? Expand
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [SchemaAttr("getEnabled")]
        public StringValue? GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [SchemaAttr("getLabel")]
        public StringValue? GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>noWrap, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: noWrap</para>
        /// </summary>
        [SchemaAttr("noWrap")]
        public BooleanValue? NoWrap
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso14:labelControl");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<BackstageLabelControl>()
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("alignLabel", a => a.AlignLabel)
.AddAttribute("expand", a => a.Expand)
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
.AddAttribute("visible", a => a.Visible)
.AddAttribute("getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("noWrap", a => a.NoWrap);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackstageLabelControl>(deep);
    }

    /// <summary>
    /// <para>Defines the GroupBox Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:groupBox.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.BackstageCheckBox" /> <c>&lt;mso14:checkBox></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.BackstageComboBox" /> <c>&lt;mso14:comboBox></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.BackstageDropDown" /> <c>&lt;mso14:dropDown></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.BackstageEditBox" /> <c>&lt;mso14:editBox></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroupButton" /> <c>&lt;mso14:button></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.BackstageLabelControl" /> <c>&lt;mso14:labelControl></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox" /> <c>&lt;mso14:groupBox></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.Hyperlink" /> <c>&lt;mso14:hyperlink></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.ImageControl" /> <c>&lt;mso14:imageControl></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer" /> <c>&lt;mso14:layoutContainer></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup" /> <c>&lt;mso14:radioGroup></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso14:groupBox")]
    public partial class GroupBox : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the GroupBox class.
        /// </summary>
        public GroupBox() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupBox class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GroupBox(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupBox class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public GroupBox(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupBox class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public GroupBox(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>expand, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: expand</para>
        /// </summary>
        [SchemaAttr("expand")]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>? Expand
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [SchemaAttr("getLabel")]
        public StringValue? GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso14:groupBox");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageCheckBox>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageComboBox>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageDropDown>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageEditBox>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroupButton>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageLabelControl>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.Hyperlink>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.ImageControl>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup>();
            builder.AddElement<GroupBox>()
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("expand", a => a.Expand)
.AddAttribute("label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 0, 1000, version: FileFormatVersions.Office2010)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroupButton), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageCheckBox), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageEditBox), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageDropDown), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageComboBox), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.Hyperlink), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageLabelControl), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ImageControl), 1, 1, version: FileFormatVersions.Office2010)
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<GroupBox>(deep);
    }

    /// <summary>
    /// <para>Defines the LayoutContainer Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:layoutContainer.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.BackstageCheckBox" /> <c>&lt;mso14:checkBox></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.BackstageComboBox" /> <c>&lt;mso14:comboBox></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.BackstageDropDown" /> <c>&lt;mso14:dropDown></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.BackstageEditBox" /> <c>&lt;mso14:editBox></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroupButton" /> <c>&lt;mso14:button></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.BackstageLabelControl" /> <c>&lt;mso14:labelControl></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox" /> <c>&lt;mso14:groupBox></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.Hyperlink" /> <c>&lt;mso14:hyperlink></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.ImageControl" /> <c>&lt;mso14:imageControl></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer" /> <c>&lt;mso14:layoutContainer></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup" /> <c>&lt;mso14:radioGroup></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso14:layoutContainer")]
    public partial class LayoutContainer : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the LayoutContainer class.
        /// </summary>
        public LayoutContainer() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the LayoutContainer class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LayoutContainer(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LayoutContainer class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public LayoutContainer(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the LayoutContainer class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public LayoutContainer(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>align, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: align</para>
        /// </summary>
        [SchemaAttr("align")]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>? Align
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>expand, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: expand</para>
        /// </summary>
        [SchemaAttr("expand")]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>? Expand
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>layoutChildren, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: layoutChildren</para>
        /// </summary>
        [SchemaAttr("layoutChildren")]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.LayoutChildrenValues>? LayoutChildren
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.LayoutChildrenValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso14:layoutContainer");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageCheckBox>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageComboBox>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageDropDown>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageEditBox>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroupButton>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageLabelControl>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.Hyperlink>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.ImageControl>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup>();
            builder.AddElement<LayoutContainer>()
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("align", a => a.Align)
.AddAttribute("expand", a => a.Expand)
.AddAttribute("layoutChildren", a => a.LayoutChildren);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 0, 1000, version: FileFormatVersions.Office2010)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroupButton), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageCheckBox), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageEditBox), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageDropDown), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageComboBox), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.Hyperlink), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageLabelControl), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ImageControl), 1, 1, version: FileFormatVersions.Office2010)
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<LayoutContainer>(deep);
    }

    /// <summary>
    /// <para>Defines the ImageControl Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:imageControl.</para>
    /// </summary>
    [SchemaAttr("mso14:imageControl")]
    public partial class ImageControl : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ImageControl class.
        /// </summary>
        public ImageControl() : base()
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [SchemaAttr("getEnabled")]
        public StringValue? GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [SchemaAttr("image")]
        public StringValue? Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [SchemaAttr("imageMso")]
        public StringValue? ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [SchemaAttr("getImage")]
        public StringValue? GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>altText, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: altText</para>
        /// </summary>
        [SchemaAttr("altText")]
        public StringValue? AltText
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getAltText, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getAltText</para>
        /// </summary>
        [SchemaAttr("getAltText")]
        public StringValue? GetAltText
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso14:imageControl");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<ImageControl>()
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("enabled", a => a.Enabled)
.AddAttribute("getEnabled", a => a.GetEnabled, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("visible", a => a.Visible)
.AddAttribute("getVisible", a => a.GetVisible, aBuilder =>
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
.AddAttribute("altText", a => a.AltText, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (4096L) });
})
.AddAttribute("getAltText", a => a.GetAltText, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ImageControl>(deep);
    }

    /// <summary>
    /// <para>Defines the BackstageGroup Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:group.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.TopItemsGroupControls" /> <c>&lt;mso14:topItems></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.BottomItemsGroupControls" /> <c>&lt;mso14:bottomItems></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.PrimaryItem" /> <c>&lt;mso14:primaryItem></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso14:group")]
    public partial class BackstageGroup : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the BackstageGroup class.
        /// </summary>
        public BackstageGroup() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BackstageGroup class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BackstageGroup(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BackstageGroup class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BackstageGroup(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BackstageGroup class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public BackstageGroup(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [SchemaAttr("idMso")]
        public StringValue? IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [SchemaAttr("insertAfterMso")]
        public StringValue? InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [SchemaAttr("insertBeforeMso")]
        public StringValue? InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [SchemaAttr("insertAfterQ")]
        public StringValue? InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [SchemaAttr("insertBeforeQ")]
        public StringValue? InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [SchemaAttr("getLabel")]
        public StringValue? GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>style, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: style</para>
        /// </summary>
        [SchemaAttr("style")]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.StyleValues>? Style
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.StyleValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getStyle, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getStyle</para>
        /// </summary>
        [SchemaAttr("getStyle")]
        public StringValue? GetStyle
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>helperText, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: helperText</para>
        /// </summary>
        [SchemaAttr("helperText")]
        public StringValue? HelperText
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getHelperText, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getHelperText</para>
        /// </summary>
        [SchemaAttr("getHelperText")]
        public StringValue? GetHelperText
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr("showLabel")]
        public BooleanValue? ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office 2010 and later.</para>
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
            builder.SetSchema("mso14:group");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.TopItemsGroupControls>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.BottomItemsGroupControls>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.PrimaryItem>();
            builder.AddElement<BackstageGroup>()
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("visible", a => a.Visible)
.AddAttribute("getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("style", a => a.Style)
.AddAttribute("getStyle", a => a.GetStyle, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("helperText", a => a.HelperText, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (4096L) });
})
.AddAttribute("getHelperText", a => a.GetHelperText, aBuilder =>
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
                new CompositeParticle.Builder(ParticleType.Choice, 0, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.PrimaryItem), 0, 1, version: FileFormatVersions.Office2010)
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.TopItemsGroupControls), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BottomItemsGroupControls), 0, 1, version: FileFormatVersions.Office2010)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackstageGroup>(deep);
    }

    /// <summary>
    /// <para>Defines the TaskGroup Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:taskGroup.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroupCategory" /> <c>&lt;mso14:category></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso14:taskGroup")]
    public partial class TaskGroup : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TaskGroup class.
        /// </summary>
        public TaskGroup() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TaskGroup class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TaskGroup(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TaskGroup class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TaskGroup(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TaskGroup class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TaskGroup(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [SchemaAttr("idMso")]
        public StringValue? IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [SchemaAttr("insertAfterMso")]
        public StringValue? InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [SchemaAttr("insertBeforeMso")]
        public StringValue? InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [SchemaAttr("insertAfterQ")]
        public StringValue? InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [SchemaAttr("insertBeforeQ")]
        public StringValue? InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [SchemaAttr("getLabel")]
        public StringValue? GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>helperText, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: helperText</para>
        /// </summary>
        [SchemaAttr("helperText")]
        public StringValue? HelperText
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getHelperText, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getHelperText</para>
        /// </summary>
        [SchemaAttr("getHelperText")]
        public StringValue? GetHelperText
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr("showLabel")]
        public BooleanValue? ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [SchemaAttr("getShowLabel")]
        public StringValue? GetShowLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>allowedTaskSizes, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: allowedTaskSizes</para>
        /// </summary>
        [SchemaAttr("allowedTaskSizes")]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.TaskSizesValues>? AllowedTaskSizes
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.TaskSizesValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso14:taskGroup");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroupCategory>();
            builder.AddElement<TaskGroup>()
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("visible", a => a.Visible)
.AddAttribute("getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("helperText", a => a.HelperText, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (4096L) });
})
.AddAttribute("getHelperText", a => a.GetHelperText, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("showLabel", a => a.ShowLabel)
.AddAttribute("getShowLabel", a => a.GetShowLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("allowedTaskSizes", a => a.AllowedTaskSizes);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroupCategory), 0, 100, version: FileFormatVersions.Office2010)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TaskGroup>(deep);
    }

    /// <summary>
    /// <para>Defines the MenuRoot Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:menu.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular" /> <c>&lt;mso14:button></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.CheckBox" /> <c>&lt;mso14:checkBox></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.ControlCloneRegular" /> <c>&lt;mso14:control></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.DynamicMenuRegular" /> <c>&lt;mso14:dynamicMenu></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular" /> <c>&lt;mso14:gallery></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.MenuRegular" /> <c>&lt;mso14:menu></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.MenuSeparator" /> <c>&lt;mso14:menuSeparator></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonRegular" /> <c>&lt;mso14:splitButton></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.ToggleButtonRegular" /> <c>&lt;mso14:toggleButton></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso14:menu")]
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
        /// <para>title, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: title</para>
        /// </summary>
        [SchemaAttr("title")]
        public StringValue? Title
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getTitle, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getTitle</para>
        /// </summary>
        [SchemaAttr("getTitle")]
        public StringValue? GetTitle
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>itemSize, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: itemSize</para>
        /// </summary>
        [SchemaAttr("itemSize")]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues>? ItemSize
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso14:menu");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.CheckBox>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.ControlCloneRegular>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.DynamicMenuRegular>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.MenuRegular>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.MenuSeparator>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonRegular>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.ToggleButtonRegular>();
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
                    new CompositeParticle.Builder(ParticleType.Group, 1, 1, version: FileFormatVersions.Office2010)
                    {
                        new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                        {
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ControlCloneRegular), 1, 1, version: FileFormatVersions.Office2010),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular), 1, 1, version: FileFormatVersions.Office2010),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.CheckBox), 1, 1, version: FileFormatVersions.Office2010),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular), 1, 1, version: FileFormatVersions.Office2010),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ToggleButtonRegular), 1, 1, version: FileFormatVersions.Office2010),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.MenuSeparator), 1, 1, version: FileFormatVersions.Office2010)
                        }
                    },
                    new CompositeParticle.Builder(ParticleType.Group, 1, 1, version: FileFormatVersions.Office2010)
                    {
                        new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                        {
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonRegular), 1, 1, version: FileFormatVersions.Office2010),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.MenuRegular), 1, 1, version: FileFormatVersions.Office2010),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.DynamicMenuRegular), 1, 1, version: FileFormatVersions.Office2010)
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
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:customUI.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.Backstage" /> <c>&lt;mso14:backstage></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.Commands" /> <c>&lt;mso14:commands></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenus" /> <c>&lt;mso14:contextMenus></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.Ribbon" /> <c>&lt;mso14:ribbon></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso14:customUI")]
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
        /// <para>onLoad, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: onLoad</para>
        /// </summary>
        [SchemaAttr("onLoad")]
        public StringValue? OnLoad
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>loadImage, this property is only available in Office 2010 and later.</para>
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
            builder.SetSchema("mso14:customUI");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.Backstage>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.Commands>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenus>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.Ribbon>();
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
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.Commands), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.Ribbon), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.Backstage), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenus), 0, 1, version: FileFormatVersions.Office2010)
            };
        }

        /// <summary>
        /// <para>Commands.</para>
        /// <para>Represents the following element tag in the schema: mso14:commands.</para>
        /// </summary>
        /// <remark>
        /// xmlns:mso14 = http://schemas.microsoft.com/office/2009/07/customui
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.CustomUI.Commands? Commands
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.CustomUI.Commands>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Ribbon.</para>
        /// <para>Represents the following element tag in the schema: mso14:ribbon.</para>
        /// </summary>
        /// <remark>
        /// xmlns:mso14 = http://schemas.microsoft.com/office/2009/07/customui
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.CustomUI.Ribbon? Ribbon
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.CustomUI.Ribbon>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Backstage.</para>
        /// <para>Represents the following element tag in the schema: mso14:backstage.</para>
        /// </summary>
        /// <remark>
        /// xmlns:mso14 = http://schemas.microsoft.com/office/2009/07/customui
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.CustomUI.Backstage? Backstage
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.CustomUI.Backstage>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ContextMenus.</para>
        /// <para>Represents the following element tag in the schema: mso14:contextMenus.</para>
        /// </summary>
        /// <remark>
        /// xmlns:mso14 = http://schemas.microsoft.com/office/2009/07/customui
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenus? ContextMenus
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenus>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CustomUI>(deep);

        internal CustomUI(RibbonAndBackstageCustomizationsPart ownerPart) : base(ownerPart)
        {
        }

        /// <summary>
        /// Loads the DOM from the RibbonAndBackstageCustomizationsPart
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to be loaded.</param>
        public void Load(RibbonAndBackstageCustomizationsPart openXmlPart)
        {
            LoadFromPart(openXmlPart);
        }

        /// <summary>
        /// Saves the DOM into the RibbonAndBackstageCustomizationsPart.
        /// </summary>
        /// <param name="openXmlPart">Specifies the part to save to.</param>
        public void Save(RibbonAndBackstageCustomizationsPart openXmlPart)
        {
            base.SaveToPart(openXmlPart);
        }

        /// <summary>
        /// Gets the RibbonAndBackstageCustomizationsPart associated with this element.
        /// </summary>
        public RibbonAndBackstageCustomizationsPart? RibbonAndBackstageCustomizationsPart
        {
            get => OpenXmlPart as RibbonAndBackstageCustomizationsPart;
            internal set => OpenXmlPart = value;
        }
    }

    /// <summary>
    /// <para>Defines the Item Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:item.</para>
    /// </summary>
    [SchemaAttr("mso14:item")]
    public partial class Item : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Item class.
        /// </summary>
        public Item() : base()
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [SchemaAttr("image")]
        public StringValue? Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [SchemaAttr("imageMso")]
        public StringValue? ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [SchemaAttr("screentip")]
        public StringValue? Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip, this property is only available in Office 2010 and later.</para>
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
            builder.SetSchema("mso14:item");
            builder.Availability = FileFormatVersions.Office2010;
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
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:button.</para>
    /// </summary>
    [SchemaAttr("mso14:button")]
    public partial class VisibleButton : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the VisibleButton class.
        /// </summary>
        public VisibleButton() : base()
        {
        }

        /// <summary>
        /// <para>onAction, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        [SchemaAttr("onAction")]
        public StringValue? OnAction
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [SchemaAttr("getEnabled")]
        public StringValue? GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>description, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [SchemaAttr("description")]
        public StringValue? Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getDescription, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [SchemaAttr("getDescription")]
        public StringValue? GetDescription
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [SchemaAttr("image")]
        public StringValue? Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [SchemaAttr("imageMso")]
        public StringValue? ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [SchemaAttr("getImage")]
        public StringValue? GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [SchemaAttr("idMso")]
        public StringValue? IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [SchemaAttr("screentip")]
        public StringValue? Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [SchemaAttr("getScreentip")]
        public StringValue? GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [SchemaAttr("supertip")]
        public StringValue? Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [SchemaAttr("getSupertip")]
        public StringValue? GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [SchemaAttr("getLabel")]
        public StringValue? GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [SchemaAttr("insertAfterMso")]
        public StringValue? InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [SchemaAttr("insertBeforeMso")]
        public StringValue? InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [SchemaAttr("insertAfterQ")]
        public StringValue? InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [SchemaAttr("insertBeforeQ")]
        public StringValue? InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [SchemaAttr("keytip")]
        public StringValue? Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [SchemaAttr("getKeytip")]
        public StringValue? GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr("showLabel")]
        public BooleanValue? ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [SchemaAttr("getShowLabel")]
        public StringValue? GetShowLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showImage, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr("showImage")]
        public BooleanValue? ShowImage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowImage, this property is only available in Office 2010 and later.</para>
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
            builder.SetSchema("mso14:button");
            builder.Availability = FileFormatVersions.Office2010;
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
.AddAttribute("idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
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
.AddAttribute("insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
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
            builder.AddConstraint(new AttributeMutualExclusive("mso14:insertAfterMso", "mso14:insertAfterQ", "mso14:insertBeforeMso", "mso14:insertBeforeQ") { Version = FileFormatVersions.Office2010 });
            builder.AddConstraint(new AttributeMutualExclusive("mso14:size", "mso14:getSize") { Version = FileFormatVersions.Office2010 });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<VisibleButton>(deep);
    }

    /// <summary>
    /// <para>Defines the VisibleToggleButton Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:toggleButton.</para>
    /// </summary>
    [SchemaAttr("mso14:toggleButton")]
    public partial class VisibleToggleButton : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the VisibleToggleButton class.
        /// </summary>
        public VisibleToggleButton() : base()
        {
        }

        /// <summary>
        /// <para>getPressed, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getPressed</para>
        /// </summary>
        [SchemaAttr("getPressed")]
        public StringValue? GetPressed
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>onAction, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        [SchemaAttr("onAction")]
        public StringValue? OnAction
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [SchemaAttr("getEnabled")]
        public StringValue? GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>description, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [SchemaAttr("description")]
        public StringValue? Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getDescription, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [SchemaAttr("getDescription")]
        public StringValue? GetDescription
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [SchemaAttr("image")]
        public StringValue? Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [SchemaAttr("imageMso")]
        public StringValue? ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [SchemaAttr("getImage")]
        public StringValue? GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [SchemaAttr("idMso")]
        public StringValue? IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [SchemaAttr("screentip")]
        public StringValue? Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [SchemaAttr("getScreentip")]
        public StringValue? GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [SchemaAttr("supertip")]
        public StringValue? Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [SchemaAttr("getSupertip")]
        public StringValue? GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [SchemaAttr("getLabel")]
        public StringValue? GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [SchemaAttr("insertAfterMso")]
        public StringValue? InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [SchemaAttr("insertBeforeMso")]
        public StringValue? InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [SchemaAttr("insertAfterQ")]
        public StringValue? InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [SchemaAttr("insertBeforeQ")]
        public StringValue? InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [SchemaAttr("keytip")]
        public StringValue? Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [SchemaAttr("getKeytip")]
        public StringValue? GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr("showLabel")]
        public BooleanValue? ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [SchemaAttr("getShowLabel")]
        public StringValue? GetShowLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showImage, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr("showImage")]
        public BooleanValue? ShowImage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowImage, this property is only available in Office 2010 and later.</para>
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
            builder.SetSchema("mso14:toggleButton");
            builder.Availability = FileFormatVersions.Office2010;
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
.AddAttribute("idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
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
.AddAttribute("insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
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
    /// <para>Defines the Separator Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:separator.</para>
    /// </summary>
    [SchemaAttr("mso14:separator")]
    public partial class Separator : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Separator class.
        /// </summary>
        public Separator() : base()
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [SchemaAttr("insertAfterMso")]
        public StringValue? InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [SchemaAttr("insertBeforeMso")]
        public StringValue? InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [SchemaAttr("insertAfterQ")]
        public StringValue? InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [SchemaAttr("insertBeforeQ")]
        public StringValue? InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso14:separator");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<Separator>()
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
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
.AddAttribute("insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
});
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Separator>(deep);
    }

    /// <summary>
    /// <para>Defines the DialogBoxLauncher Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:dialogBoxLauncher.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular" /> <c>&lt;mso14:button></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso14:dialogBoxLauncher")]
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
            builder.SetSchema("mso14:dialogBoxLauncher");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular), 1, 1, version: FileFormatVersions.Office2010)
            };
        }

        /// <summary>
        /// <para>ButtonRegular.</para>
        /// <para>Represents the following element tag in the schema: mso14:button.</para>
        /// </summary>
        /// <remark>
        /// xmlns:mso14 = http://schemas.microsoft.com/office/2009/07/customui
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular? ButtonRegular
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DialogBoxLauncher>(deep);
    }

    /// <summary>
    /// <para>Defines the Group Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:group.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.Box" /> <c>&lt;mso14:box></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.Button" /> <c>&lt;mso14:button></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.ButtonGroup" /> <c>&lt;mso14:buttonGroup></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.CheckBox" /> <c>&lt;mso14:checkBox></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.ComboBox" /> <c>&lt;mso14:comboBox></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.ControlClone" /> <c>&lt;mso14:control></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.DialogBoxLauncher" /> <c>&lt;mso14:dialogBoxLauncher></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular" /> <c>&lt;mso14:dropDown></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.DynamicMenu" /> <c>&lt;mso14:dynamicMenu></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.EditBox" /> <c>&lt;mso14:editBox></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.Gallery" /> <c>&lt;mso14:gallery></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.LabelControl" /> <c>&lt;mso14:labelControl></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.Menu" /> <c>&lt;mso14:menu></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.Separator" /> <c>&lt;mso14:separator></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.SplitButton" /> <c>&lt;mso14:splitButton></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.ToggleButton" /> <c>&lt;mso14:toggleButton></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso14:group")]
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
        /// <para>id, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [SchemaAttr("idMso")]
        public StringValue? IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [SchemaAttr("getLabel")]
        public StringValue? GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [SchemaAttr("image")]
        public StringValue? Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [SchemaAttr("imageMso")]
        public StringValue? ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [SchemaAttr("getImage")]
        public StringValue? GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [SchemaAttr("insertAfterMso")]
        public StringValue? InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [SchemaAttr("insertBeforeMso")]
        public StringValue? InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [SchemaAttr("insertAfterQ")]
        public StringValue? InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [SchemaAttr("insertBeforeQ")]
        public StringValue? InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [SchemaAttr("screentip")]
        public StringValue? Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [SchemaAttr("getScreentip")]
        public StringValue? GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [SchemaAttr("supertip")]
        public StringValue? Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [SchemaAttr("getSupertip")]
        public StringValue? GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [SchemaAttr("keytip")]
        public StringValue? Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [SchemaAttr("getKeytip")]
        public StringValue? GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>autoScale, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: autoScale</para>
        /// </summary>
        [SchemaAttr("autoScale")]
        public BooleanValue? AutoScale
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>centerVertically, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: centerVertically</para>
        /// </summary>
        [SchemaAttr("centerVertically")]
        public BooleanValue? CenterVertically
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso14:group");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.Box>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.Button>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.ButtonGroup>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.CheckBox>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.ComboBox>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.ControlClone>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.DialogBoxLauncher>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.DynamicMenu>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.EditBox>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.Gallery>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.LabelControl>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.Menu>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.Separator>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.SplitButton>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.ToggleButton>();
            builder.AddElement<Group>()
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
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
.AddAttribute("insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
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
})
.AddAttribute("autoScale", a => a.AutoScale)
.AddAttribute("centerVertically", a => a.CenterVertically);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 0, 1000)
                    {
                        new CompositeParticle.Builder(ParticleType.Group, 1, 1, version: FileFormatVersions.Office2010)
                        {
                            new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                            {
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ControlClone), 1, 1, version: FileFormatVersions.Office2010),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.LabelControl), 1, 1, version: FileFormatVersions.Office2010),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.Button), 1, 1, version: FileFormatVersions.Office2010),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ToggleButton), 1, 1, version: FileFormatVersions.Office2010),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.CheckBox), 1, 1, version: FileFormatVersions.Office2010),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.EditBox), 1, 1, version: FileFormatVersions.Office2010),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ComboBox), 1, 1, version: FileFormatVersions.Office2010),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular), 1, 1, version: FileFormatVersions.Office2010),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.Gallery), 1, 1, version: FileFormatVersions.Office2010),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.Menu), 1, 1, version: FileFormatVersions.Office2010),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.DynamicMenu), 1, 1, version: FileFormatVersions.Office2010),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.SplitButton), 1, 1, version: FileFormatVersions.Office2010),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.Box), 1, 1, version: FileFormatVersions.Office2010),
                                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ButtonGroup), 1, 1, version: FileFormatVersions.Office2010)
                            }
                        },
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.Separator), 1, 1, version: FileFormatVersions.Office2010)
                    }
                },
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.DialogBoxLauncher), 0, 1, version: FileFormatVersions.Office2010)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Group>(deep);
    }

    /// <summary>
    /// <para>Defines the ControlCloneQat Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:control.</para>
    /// </summary>
    [SchemaAttr("mso14:control")]
    public partial class ControlCloneQat : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the ControlCloneQat class.
        /// </summary>
        public ControlCloneQat() : base()
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? IdQ
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [SchemaAttr("idMso")]
        public StringValue? IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>description, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [SchemaAttr("description")]
        public StringValue? Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getDescription, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [SchemaAttr("getDescription")]
        public StringValue? GetDescription
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>size, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: size</para>
        /// </summary>
        [SchemaAttr("size")]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues>? Size
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues>>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSize, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getSize</para>
        /// </summary>
        [SchemaAttr("getSize")]
        public StringValue? GetSize
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [SchemaAttr("image")]
        public StringValue? Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [SchemaAttr("imageMso")]
        public StringValue? ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [SchemaAttr("getImage")]
        public StringValue? GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>screentip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [SchemaAttr("screentip")]
        public StringValue? Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [SchemaAttr("getScreentip")]
        public StringValue? GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [SchemaAttr("supertip")]
        public StringValue? Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [SchemaAttr("getSupertip")]
        public StringValue? GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [SchemaAttr("getEnabled")]
        public StringValue? GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [SchemaAttr("getLabel")]
        public StringValue? GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [SchemaAttr("insertAfterMso")]
        public StringValue? InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [SchemaAttr("insertBeforeMso")]
        public StringValue? InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [SchemaAttr("insertAfterQ")]
        public StringValue? InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [SchemaAttr("insertBeforeQ")]
        public StringValue? InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [SchemaAttr("keytip")]
        public StringValue? Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [SchemaAttr("getKeytip")]
        public StringValue? GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr("showLabel")]
        public BooleanValue? ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [SchemaAttr("getShowLabel")]
        public StringValue? GetShowLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showImage, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: showImage</para>
        /// </summary>
        [SchemaAttr("showImage")]
        public BooleanValue? ShowImage
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowImage, this property is only available in Office 2010 and later.</para>
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
            builder.SetSchema("mso14:control");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<ControlCloneQat>()
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
.AddAttribute("insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
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
            builder.AddConstraint(new AttributeMutualExclusive("mso14:size", "mso14:getSize") { Version = FileFormatVersions.Office2010 });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ControlCloneQat>(deep);
    }

    /// <summary>
    /// <para>Defines the SharedControlsQatItems Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:sharedControls.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular" /> <c>&lt;mso14:button></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.ControlCloneQat" /> <c>&lt;mso14:control></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.Separator" /> <c>&lt;mso14:separator></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso14:sharedControls")]
    public partial class SharedControlsQatItems : QatItemsType
    {
        /// <summary>
        /// Initializes a new instance of the SharedControlsQatItems class.
        /// </summary>
        public SharedControlsQatItems() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SharedControlsQatItems class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SharedControlsQatItems(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SharedControlsQatItems class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SharedControlsQatItems(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SharedControlsQatItems class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SharedControlsQatItems(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso14:sharedControls");
            builder.Availability = FileFormatVersions.Office2010;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Choice, 0, 1000)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ControlCloneQat), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.Separator), 1, 1, version: FileFormatVersions.Office2010)
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SharedControlsQatItems>(deep);
    }

    /// <summary>
    /// <para>Defines the DocumentControlsQatItems Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:documentControls.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular" /> <c>&lt;mso14:button></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.ControlCloneQat" /> <c>&lt;mso14:control></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.Separator" /> <c>&lt;mso14:separator></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso14:documentControls")]
    public partial class DocumentControlsQatItems : QatItemsType
    {
        /// <summary>
        /// Initializes a new instance of the DocumentControlsQatItems class.
        /// </summary>
        public DocumentControlsQatItems() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the DocumentControlsQatItems class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DocumentControlsQatItems(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DocumentControlsQatItems class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public DocumentControlsQatItems(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the DocumentControlsQatItems class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public DocumentControlsQatItems(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso14:documentControls");
            builder.Availability = FileFormatVersions.Office2010;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Choice, 0, 1000)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ControlCloneQat), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.Separator), 1, 1, version: FileFormatVersions.Office2010)
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<DocumentControlsQatItems>(deep);
    }

    /// <summary>
    /// <para>Defines the QatItemsType Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular" /> <c>&lt;mso14:button></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.ControlCloneQat" /> <c>&lt;mso14:control></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.Separator" /> <c>&lt;mso14:separator></c></description></item>
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
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.ControlCloneQat>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.Separator>();
        }
    }

    /// <summary>
    /// <para>Defines the Tab Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:tab.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.Group" /> <c>&lt;mso14:group></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso14:tab")]
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
        /// <para>id, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [SchemaAttr("idMso")]
        public StringValue? IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [SchemaAttr("getLabel")]
        public StringValue? GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [SchemaAttr("insertAfterMso")]
        public StringValue? InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [SchemaAttr("insertBeforeMso")]
        public StringValue? InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [SchemaAttr("insertAfterQ")]
        public StringValue? InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [SchemaAttr("insertBeforeQ")]
        public StringValue? InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [SchemaAttr("keytip")]
        public StringValue? Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office 2010 and later.</para>
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
            builder.SetSchema("mso14:tab");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.Group>();
            builder.AddElement<Tab>()
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
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
.AddAttribute("insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
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
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.Group), 1, 1, version: FileFormatVersions.Office2010)
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Tab>(deep);
    }

    /// <summary>
    /// <para>Defines the TabSet Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:tabSet.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.Tab" /> <c>&lt;mso14:tab></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso14:tabSet")]
    public partial class TabSet : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TabSet class.
        /// </summary>
        public TabSet() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TabSet class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TabSet(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TabSet class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TabSet(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TabSet class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TabSet(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [SchemaAttr("idMso")]
        public StringValue? IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office 2010 and later.</para>
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
            builder.SetSchema("mso14:tabSet");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.Tab>();
            builder.AddElement<TabSet>()
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
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.Tab), 0, 50, version: FileFormatVersions.Office2010)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TabSet>(deep);
    }

    /// <summary>
    /// <para>Defines the Command Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:command.</para>
    /// </summary>
    [SchemaAttr("mso14:command")]
    public partial class Command : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the Command class.
        /// </summary>
        public Command() : base()
        {
        }

        /// <summary>
        /// <para>onAction, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        [SchemaAttr("onAction")]
        public StringValue? OnAction
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [SchemaAttr("getEnabled")]
        public StringValue? GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office 2010 and later.</para>
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
            builder.SetSchema("mso14:command");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<Command>()
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
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Command>(deep);
    }

    /// <summary>
    /// <para>Defines the QuickAccessToolbar Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:qat.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.SharedControlsQatItems" /> <c>&lt;mso14:sharedControls></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.DocumentControlsQatItems" /> <c>&lt;mso14:documentControls></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso14:qat")]
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
            builder.SetSchema("mso14:qat");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.SharedControlsQatItems>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.DocumentControlsQatItems>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.SharedControlsQatItems), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.DocumentControlsQatItems), 0, 1, version: FileFormatVersions.Office2010)
            };
        }

        /// <summary>
        /// <para>SharedControlsQatItems.</para>
        /// <para>Represents the following element tag in the schema: mso14:sharedControls.</para>
        /// </summary>
        /// <remark>
        /// xmlns:mso14 = http://schemas.microsoft.com/office/2009/07/customui
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.CustomUI.SharedControlsQatItems? SharedControlsQatItems
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.CustomUI.SharedControlsQatItems>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>DocumentControlsQatItems.</para>
        /// <para>Represents the following element tag in the schema: mso14:documentControls.</para>
        /// </summary>
        /// <remark>
        /// xmlns:mso14 = http://schemas.microsoft.com/office/2009/07/customui
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.CustomUI.DocumentControlsQatItems? DocumentControlsQatItems
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.CustomUI.DocumentControlsQatItems>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<QuickAccessToolbar>(deep);
    }

    /// <summary>
    /// <para>Defines the Tabs Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:tabs.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.Tab" /> <c>&lt;mso14:tab></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso14:tabs")]
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
            builder.SetSchema("mso14:tabs");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.Tab>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.Tab), 1, 100, version: FileFormatVersions.Office2010)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Tabs>(deep);
    }

    /// <summary>
    /// <para>Defines the ContextualTabs Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:contextualTabs.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.TabSet" /> <c>&lt;mso14:tabSet></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso14:contextualTabs")]
    public partial class ContextualTabs : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ContextualTabs class.
        /// </summary>
        public ContextualTabs() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ContextualTabs class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ContextualTabs(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ContextualTabs class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ContextualTabs(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ContextualTabs class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ContextualTabs(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso14:contextualTabs");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.TabSet>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.TabSet), 1, 100, version: FileFormatVersions.Office2010)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ContextualTabs>(deep);
    }

    /// <summary>
    /// <para>Defines the ContextMenu Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:contextMenu.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular" /> <c>&lt;mso14:button></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.CheckBox" /> <c>&lt;mso14:checkBox></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.ControlCloneRegular" /> <c>&lt;mso14:control></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.DynamicMenuRegular" /> <c>&lt;mso14:dynamicMenu></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular" /> <c>&lt;mso14:gallery></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.MenuRegular" /> <c>&lt;mso14:menu></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.MenuSeparatorNoTitle" /> <c>&lt;mso14:menuSeparator></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonRegular" /> <c>&lt;mso14:splitButton></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.ToggleButtonRegular" /> <c>&lt;mso14:toggleButton></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso14:contextMenu")]
    public partial class ContextMenu : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ContextMenu class.
        /// </summary>
        public ContextMenu() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ContextMenu class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ContextMenu(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ContextMenu class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ContextMenu(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ContextMenu class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ContextMenu(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office 2010 and later.</para>
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
            builder.SetSchema("mso14:contextMenu");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.CheckBox>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.ControlCloneRegular>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.DynamicMenuRegular>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.MenuRegular>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.MenuSeparatorNoTitle>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonRegular>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.ToggleButtonRegular>();
            builder.AddElement<ContextMenu>()
.AddAttribute("idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Choice, 0, 1000)
                {
                    new CompositeParticle.Builder(ParticleType.Group, 1, 1, version: FileFormatVersions.Office2010)
                    {
                        new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                        {
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ControlCloneRegular), 1, 1, version: FileFormatVersions.Office2010),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ButtonRegular), 1, 1, version: FileFormatVersions.Office2010),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.CheckBox), 1, 1, version: FileFormatVersions.Office2010),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.GalleryRegular), 1, 1, version: FileFormatVersions.Office2010),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ToggleButtonRegular), 1, 1, version: FileFormatVersions.Office2010),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.SplitButtonRegular), 1, 1, version: FileFormatVersions.Office2010),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.MenuRegular), 1, 1, version: FileFormatVersions.Office2010),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.DynamicMenuRegular), 1, 1, version: FileFormatVersions.Office2010),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.MenuSeparatorNoTitle), 1, 1, version: FileFormatVersions.Office2010)
                        }
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ContextMenu>(deep);
    }

    /// <summary>
    /// <para>Defines the ItemBackstageItem Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:item.</para>
    /// </summary>
    [SchemaAttr("mso14:item")]
    public partial class ItemBackstageItem : BackstageItemType
    {
        /// <summary>
        /// Initializes a new instance of the ItemBackstageItem class.
        /// </summary>
        public ItemBackstageItem() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso14:item");
            builder.Availability = FileFormatVersions.Office2010;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ItemBackstageItem>(deep);
    }

    /// <summary>
    /// <para>Defines the RadioButtonBackstageItem Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:radioButton.</para>
    /// </summary>
    [SchemaAttr("mso14:radioButton")]
    public partial class RadioButtonBackstageItem : BackstageItemType
    {
        /// <summary>
        /// Initializes a new instance of the RadioButtonBackstageItem class.
        /// </summary>
        public RadioButtonBackstageItem() : base()
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso14:radioButton");
            builder.Availability = FileFormatVersions.Office2010;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<RadioButtonBackstageItem>(deep);
    }

    /// <summary>
    /// <para>Defines the BackstageItemType Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    public abstract partial class BackstageItemType : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the BackstageItemType class.
        /// </summary>
        protected BackstageItemType() : base()
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [SchemaAttr("getLabel")]
        public StringValue? GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddElement<BackstageItemType>()
                           .AddAttribute("id", a => a.Id, aBuilder =>
                           {
                               aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
                           })
                           .AddAttribute("label", a => a.Label, aBuilder =>
                           {
                               aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
                           })
                           .AddAttribute("getLabel", a => a.GetLabel, aBuilder =>
                           {
                               aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
                           });
        }
    }

    /// <summary>
    /// <para>Defines the BackstageRegularButton Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:button.</para>
    /// </summary>
    [SchemaAttr("mso14:button")]
    public partial class BackstageRegularButton : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the BackstageRegularButton class.
        /// </summary>
        public BackstageRegularButton() : base()
        {
        }

        /// <summary>
        /// <para>screentip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [SchemaAttr("screentip")]
        public StringValue? Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [SchemaAttr("getScreentip")]
        public StringValue? GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [SchemaAttr("supertip")]
        public StringValue? Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [SchemaAttr("getSupertip")]
        public StringValue? GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>onAction, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        [SchemaAttr("onAction")]
        public StringValue? OnAction
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>isDefinitive, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: isDefinitive</para>
        /// </summary>
        [SchemaAttr("isDefinitive")]
        public BooleanValue? IsDefinitive
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [SchemaAttr("getEnabled")]
        public StringValue? GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [SchemaAttr("getLabel")]
        public StringValue? GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [SchemaAttr("keytip")]
        public StringValue? Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [SchemaAttr("getKeytip")]
        public StringValue? GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [SchemaAttr("image")]
        public StringValue? Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [SchemaAttr("imageMso")]
        public StringValue? ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [SchemaAttr("getImage")]
        public StringValue? GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso14:button");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<BackstageRegularButton>()
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
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("onAction", a => a.OnAction, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("isDefinitive", a => a.IsDefinitive)
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
});
            builder.AddConstraint(new AttributeMutualExclusive("mso14:insertAfterMso", "mso14:insertAfterQ", "mso14:insertBeforeMso", "mso14:insertBeforeQ") { Version = FileFormatVersions.Office2010 });
            builder.AddConstraint(new AttributeMutualExclusive("mso14:size", "mso14:getSize") { Version = FileFormatVersions.Office2010 });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackstageRegularButton>(deep);
    }

    /// <summary>
    /// <para>Defines the BackstagePrimaryMenu Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:menu.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuGroup" /> <c>&lt;mso14:menuGroup></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso14:menu")]
    public partial class BackstagePrimaryMenu : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the BackstagePrimaryMenu class.
        /// </summary>
        public BackstagePrimaryMenu() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BackstagePrimaryMenu class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BackstagePrimaryMenu(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BackstagePrimaryMenu class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BackstagePrimaryMenu(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BackstagePrimaryMenu class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public BackstagePrimaryMenu(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>screentip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: screentip</para>
        /// </summary>
        [SchemaAttr("screentip")]
        public StringValue? Screentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getScreentip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getScreentip</para>
        /// </summary>
        [SchemaAttr("getScreentip")]
        public StringValue? GetScreentip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>supertip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: supertip</para>
        /// </summary>
        [SchemaAttr("supertip")]
        public StringValue? Supertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getSupertip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getSupertip</para>
        /// </summary>
        [SchemaAttr("getSupertip")]
        public StringValue? GetSupertip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [SchemaAttr("getEnabled")]
        public StringValue? GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [SchemaAttr("getLabel")]
        public StringValue? GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [SchemaAttr("image")]
        public StringValue? Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [SchemaAttr("imageMso")]
        public StringValue? ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [SchemaAttr("getImage")]
        public StringValue? GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [SchemaAttr("keytip")]
        public StringValue? Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office 2010 and later.</para>
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
            builder.SetSchema("mso14:menu");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuGroup>();
            builder.AddElement<BackstagePrimaryMenu>()
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
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
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
.AddAttribute("visible", a => a.Visible)
.AddAttribute("getVisible", a => a.GetVisible, aBuilder =>
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
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuGroup), 1, 1, version: FileFormatVersions.Office2010)
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackstagePrimaryMenu>(deep);
    }

    /// <summary>
    /// <para>Defines the BackstageMenuGroup Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:menuGroup.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuButton" /> <c>&lt;mso14:button></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuCheckBox" /> <c>&lt;mso14:checkBox></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuToggleButton" /> <c>&lt;mso14:toggleButton></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.BackstageSubMenu" /> <c>&lt;mso14:menu></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso14:menuGroup")]
    public partial class BackstageMenuGroup : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the BackstageMenuGroup class.
        /// </summary>
        public BackstageMenuGroup() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BackstageMenuGroup class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BackstageMenuGroup(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BackstageMenuGroup class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BackstageMenuGroup(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BackstageMenuGroup class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public BackstageMenuGroup(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [SchemaAttr("getLabel")]
        public StringValue? GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>itemSize, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: itemSize</para>
        /// </summary>
        [SchemaAttr("itemSize")]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues>? ItemSize
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso14:menuGroup");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuButton>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuCheckBox>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuToggleButton>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageSubMenu>();
            builder.AddElement<BackstageMenuGroup>()
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
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
.AddAttribute("itemSize", a => a.ItemSize);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Choice, 0, 1000)
                {
                    new CompositeParticle.Builder(ParticleType.Group, 1, 1, version: FileFormatVersions.Office2010)
                    {
                        new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                        {
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuButton), 1, 1, version: FileFormatVersions.Office2010),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuCheckBox), 1, 1, version: FileFormatVersions.Office2010),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageSubMenu), 1, 1, version: FileFormatVersions.Office2010),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageMenuToggleButton), 1, 1, version: FileFormatVersions.Office2010)
                        }
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackstageMenuGroup>(deep);
    }

    /// <summary>
    /// <para>Defines the PrimaryItem Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:primaryItem.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.BackstagePrimaryMenu" /> <c>&lt;mso14:menu></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.BackstageRegularButton" /> <c>&lt;mso14:button></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso14:primaryItem")]
    public partial class PrimaryItem : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the PrimaryItem class.
        /// </summary>
        public PrimaryItem() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PrimaryItem class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PrimaryItem(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PrimaryItem class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public PrimaryItem(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the PrimaryItem class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public PrimaryItem(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso14:primaryItem");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstagePrimaryMenu>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageRegularButton>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageRegularButton), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstagePrimaryMenu), 0, 1, version: FileFormatVersions.Office2010)
            };
        }

        /// <summary>
        /// <para>BackstageRegularButton.</para>
        /// <para>Represents the following element tag in the schema: mso14:button.</para>
        /// </summary>
        /// <remark>
        /// xmlns:mso14 = http://schemas.microsoft.com/office/2009/07/customui
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.CustomUI.BackstageRegularButton? BackstageRegularButton
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageRegularButton>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>BackstagePrimaryMenu.</para>
        /// <para>Represents the following element tag in the schema: mso14:menu.</para>
        /// </summary>
        /// <remark>
        /// xmlns:mso14 = http://schemas.microsoft.com/office/2009/07/customui
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.CustomUI.BackstagePrimaryMenu? BackstagePrimaryMenu
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.CustomUI.BackstagePrimaryMenu>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<PrimaryItem>(deep);
    }

    /// <summary>
    /// <para>Defines the TopItemsGroupControls Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:topItems.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.BackstageCheckBox" /> <c>&lt;mso14:checkBox></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.BackstageComboBox" /> <c>&lt;mso14:comboBox></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.BackstageDropDown" /> <c>&lt;mso14:dropDown></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.BackstageEditBox" /> <c>&lt;mso14:editBox></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroupButton" /> <c>&lt;mso14:button></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.BackstageLabelControl" /> <c>&lt;mso14:labelControl></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox" /> <c>&lt;mso14:groupBox></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.Hyperlink" /> <c>&lt;mso14:hyperlink></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.ImageControl" /> <c>&lt;mso14:imageControl></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer" /> <c>&lt;mso14:layoutContainer></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup" /> <c>&lt;mso14:radioGroup></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso14:topItems")]
    public partial class TopItemsGroupControls : GroupControlsType
    {
        /// <summary>
        /// Initializes a new instance of the TopItemsGroupControls class.
        /// </summary>
        public TopItemsGroupControls() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TopItemsGroupControls class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TopItemsGroupControls(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TopItemsGroupControls class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TopItemsGroupControls(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TopItemsGroupControls class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TopItemsGroupControls(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso14:topItems");
            builder.Availability = FileFormatVersions.Office2010;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Choice, 0, 1000)
            {
                new CompositeParticle.Builder(ParticleType.Group, 0, 1000, version: FileFormatVersions.Office2010)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroupButton), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageCheckBox), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageEditBox), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageDropDown), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageComboBox), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.Hyperlink), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageLabelControl), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ImageControl), 1, 1, version: FileFormatVersions.Office2010)
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TopItemsGroupControls>(deep);
    }

    /// <summary>
    /// <para>Defines the BottomItemsGroupControls Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:bottomItems.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.BackstageCheckBox" /> <c>&lt;mso14:checkBox></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.BackstageComboBox" /> <c>&lt;mso14:comboBox></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.BackstageDropDown" /> <c>&lt;mso14:dropDown></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.BackstageEditBox" /> <c>&lt;mso14:editBox></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroupButton" /> <c>&lt;mso14:button></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.BackstageLabelControl" /> <c>&lt;mso14:labelControl></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox" /> <c>&lt;mso14:groupBox></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.Hyperlink" /> <c>&lt;mso14:hyperlink></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.ImageControl" /> <c>&lt;mso14:imageControl></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer" /> <c>&lt;mso14:layoutContainer></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup" /> <c>&lt;mso14:radioGroup></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso14:bottomItems")]
    public partial class BottomItemsGroupControls : GroupControlsType
    {
        /// <summary>
        /// Initializes a new instance of the BottomItemsGroupControls class.
        /// </summary>
        public BottomItemsGroupControls() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BottomItemsGroupControls class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BottomItemsGroupControls(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BottomItemsGroupControls class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BottomItemsGroupControls(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BottomItemsGroupControls class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public BottomItemsGroupControls(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso14:bottomItems");
            builder.Availability = FileFormatVersions.Office2010;
            builder.Particle = new CompositeParticle.Builder(ParticleType.Choice, 0, 1000)
            {
                new CompositeParticle.Builder(ParticleType.Group, 0, 1000, version: FileFormatVersions.Office2010)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroupButton), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageCheckBox), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageEditBox), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageDropDown), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageComboBox), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.Hyperlink), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageLabelControl), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ImageControl), 1, 1, version: FileFormatVersions.Office2010)
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BottomItemsGroupControls>(deep);
    }

    /// <summary>
    /// <para>Defines the GroupControlsType Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is :.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.BackstageCheckBox" /> <c>&lt;mso14:checkBox></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.BackstageComboBox" /> <c>&lt;mso14:comboBox></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.BackstageDropDown" /> <c>&lt;mso14:dropDown></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.BackstageEditBox" /> <c>&lt;mso14:editBox></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroupButton" /> <c>&lt;mso14:button></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.BackstageLabelControl" /> <c>&lt;mso14:labelControl></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox" /> <c>&lt;mso14:groupBox></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.Hyperlink" /> <c>&lt;mso14:hyperlink></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.ImageControl" /> <c>&lt;mso14:imageControl></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer" /> <c>&lt;mso14:layoutContainer></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup" /> <c>&lt;mso14:radioGroup></c></description></item>
    /// </list>
    /// </remark>
    public abstract partial class GroupControlsType : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the GroupControlsType class.
        /// </summary>
        protected GroupControlsType() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupControlsType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected GroupControlsType(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupControlsType class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        protected GroupControlsType(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the GroupControlsType class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        protected GroupControlsType(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageCheckBox>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageComboBox>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageDropDown>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageEditBox>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroupButton>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageLabelControl>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.Hyperlink>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.ImageControl>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup>();
        }
    }

    /// <summary>
    /// <para>Defines the TaskGroupCategory Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:category.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroupTask" /> <c>&lt;mso14:task></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso14:category")]
    public partial class TaskGroupCategory : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TaskGroupCategory class.
        /// </summary>
        public TaskGroupCategory() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TaskGroupCategory class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TaskGroupCategory(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TaskGroupCategory class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TaskGroupCategory(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TaskGroupCategory class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TaskGroupCategory(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [SchemaAttr("idMso")]
        public StringValue? IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [SchemaAttr("insertAfterMso")]
        public StringValue? InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [SchemaAttr("insertBeforeMso")]
        public StringValue? InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [SchemaAttr("insertAfterQ")]
        public StringValue? InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [SchemaAttr("insertBeforeQ")]
        public StringValue? InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [SchemaAttr("getLabel")]
        public StringValue? GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso14:category");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroupTask>();
            builder.AddElement<TaskGroupCategory>()
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("visible", a => a.Visible)
.AddAttribute("getVisible", a => a.GetVisible, aBuilder =>
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
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroupTask), 0, 1000, version: FileFormatVersions.Office2010)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TaskGroupCategory>(deep);
    }

    /// <summary>
    /// <para>Defines the TaskGroupTask Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:task.</para>
    /// </summary>
    [SchemaAttr("mso14:task")]
    public partial class TaskGroupTask : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the TaskGroupTask class.
        /// </summary>
        public TaskGroupTask() : base()
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [SchemaAttr("idMso")]
        public StringValue? IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [SchemaAttr("insertAfterMso")]
        public StringValue? InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [SchemaAttr("insertBeforeMso")]
        public StringValue? InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [SchemaAttr("insertAfterQ")]
        public StringValue? InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [SchemaAttr("insertBeforeQ")]
        public StringValue? InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>onAction, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        [SchemaAttr("onAction")]
        public StringValue? OnAction
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>isDefinitive, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: isDefinitive</para>
        /// </summary>
        [SchemaAttr("isDefinitive")]
        public BooleanValue? IsDefinitive
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [SchemaAttr("image")]
        public StringValue? Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [SchemaAttr("imageMso")]
        public StringValue? ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [SchemaAttr("getImage")]
        public StringValue? GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [SchemaAttr("getEnabled")]
        public StringValue? GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [SchemaAttr("getLabel")]
        public StringValue? GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>description, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [SchemaAttr("description")]
        public StringValue? Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getDescription, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [SchemaAttr("getDescription")]
        public StringValue? GetDescription
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [SchemaAttr("keytip")]
        public StringValue? Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office 2010 and later.</para>
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
            builder.SetSchema("mso14:task");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<TaskGroupTask>()
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("onAction", a => a.OnAction, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("isDefinitive", a => a.IsDefinitive)
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
.AddAttribute("visible", a => a.Visible)
.AddAttribute("getVisible", a => a.GetVisible, aBuilder =>
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
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TaskGroupTask>(deep);
    }

    /// <summary>
    /// <para>Defines the TaskFormGroupCategory Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:category.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.TaskFormGroupTask" /> <c>&lt;mso14:task></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso14:category")]
    public partial class TaskFormGroupCategory : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TaskFormGroupCategory class.
        /// </summary>
        public TaskFormGroupCategory() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TaskFormGroupCategory class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TaskFormGroupCategory(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TaskFormGroupCategory class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TaskFormGroupCategory(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TaskFormGroupCategory class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TaskFormGroupCategory(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [SchemaAttr("idMso")]
        public StringValue? IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [SchemaAttr("insertAfterMso")]
        public StringValue? InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [SchemaAttr("insertBeforeMso")]
        public StringValue? InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [SchemaAttr("insertAfterQ")]
        public StringValue? InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [SchemaAttr("insertBeforeQ")]
        public StringValue? InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [SchemaAttr("getLabel")]
        public StringValue? GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso14:category");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.TaskFormGroupTask>();
            builder.AddElement<TaskFormGroupCategory>()
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("visible", a => a.Visible)
.AddAttribute("getVisible", a => a.GetVisible, aBuilder =>
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
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.TaskFormGroupTask), 0, 1000, version: FileFormatVersions.Office2010)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TaskFormGroupCategory>(deep);
    }

    /// <summary>
    /// <para>Defines the TaskFormGroupTask Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:task.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroup" /> <c>&lt;mso14:group></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso14:task")]
    public partial class TaskFormGroupTask : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TaskFormGroupTask class.
        /// </summary>
        public TaskFormGroupTask() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TaskFormGroupTask class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TaskFormGroupTask(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TaskFormGroupTask class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TaskFormGroupTask(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TaskFormGroupTask class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TaskFormGroupTask(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [SchemaAttr("idMso")]
        public StringValue? IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [SchemaAttr("insertAfterMso")]
        public StringValue? InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [SchemaAttr("insertBeforeMso")]
        public StringValue? InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [SchemaAttr("insertAfterQ")]
        public StringValue? InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [SchemaAttr("insertBeforeQ")]
        public StringValue? InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [SchemaAttr("image")]
        public StringValue? Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [SchemaAttr("imageMso")]
        public StringValue? ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [SchemaAttr("getImage")]
        public StringValue? GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [SchemaAttr("getEnabled")]
        public StringValue? GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [SchemaAttr("getLabel")]
        public StringValue? GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>description, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: description</para>
        /// </summary>
        [SchemaAttr("description")]
        public StringValue? Description
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getDescription, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getDescription</para>
        /// </summary>
        [SchemaAttr("getDescription")]
        public StringValue? GetDescription
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [SchemaAttr("keytip")]
        public StringValue? Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office 2010 and later.</para>
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
            builder.SetSchema("mso14:task");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroup>();
            builder.AddElement<TaskFormGroupTask>()
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
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
.AddAttribute("visible", a => a.Visible)
.AddAttribute("getVisible", a => a.GetVisible, aBuilder =>
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
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroup), 0, 1000, version: FileFormatVersions.Office2010)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TaskFormGroupTask>(deep);
    }

    /// <summary>
    /// <para>Defines the TaskFormGroup Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:taskFormGroup.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.TaskFormGroupCategory" /> <c>&lt;mso14:category></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso14:taskFormGroup")]
    public partial class TaskFormGroup : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the TaskFormGroup class.
        /// </summary>
        public TaskFormGroup() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the TaskFormGroup class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TaskFormGroup(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TaskFormGroup class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public TaskFormGroup(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the TaskFormGroup class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public TaskFormGroup(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [SchemaAttr("idMso")]
        public StringValue? IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [SchemaAttr("getLabel")]
        public StringValue? GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>helperText, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: helperText</para>
        /// </summary>
        [SchemaAttr("helperText")]
        public StringValue? HelperText
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getHelperText, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getHelperText</para>
        /// </summary>
        [SchemaAttr("getHelperText")]
        public StringValue? GetHelperText
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>showLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: showLabel</para>
        /// </summary>
        [SchemaAttr("showLabel")]
        public BooleanValue? ShowLabel
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getShowLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getShowLabel</para>
        /// </summary>
        [SchemaAttr("getShowLabel")]
        public StringValue? GetShowLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>allowedTaskSizes, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: allowedTaskSizes</para>
        /// </summary>
        [SchemaAttr("allowedTaskSizes")]
        public EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.TaskSizesValues>? AllowedTaskSizes
        {
            get => GetAttribute<EnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.TaskSizesValues>>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso14:taskFormGroup");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.TaskFormGroupCategory>();
            builder.AddElement<TaskFormGroup>()
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("label", a => a.Label, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getLabel", a => a.GetLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("visible", a => a.Visible)
.AddAttribute("getVisible", a => a.GetVisible, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("helperText", a => a.HelperText, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (4096L) });
})
.AddAttribute("getHelperText", a => a.GetHelperText, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("showLabel", a => a.ShowLabel)
.AddAttribute("getShowLabel", a => a.GetShowLabel, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("allowedTaskSizes", a => a.AllowedTaskSizes);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.TaskFormGroupCategory), 0, 100, version: FileFormatVersions.Office2010)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<TaskFormGroup>(deep);
    }

    /// <summary>
    /// <para>Defines the BackstageGroups Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:firstColumn.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroup" /> <c>&lt;mso14:group></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.TaskFormGroup" /> <c>&lt;mso14:taskFormGroup></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroup" /> <c>&lt;mso14:taskGroup></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso14:firstColumn")]
    public partial class BackstageGroups : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the BackstageGroups class.
        /// </summary>
        public BackstageGroups() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BackstageGroups class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BackstageGroups(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BackstageGroups class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BackstageGroups(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BackstageGroups class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public BackstageGroups(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso14:firstColumn");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroup>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.TaskFormGroup>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroup>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Choice, 0, 1)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.TaskFormGroup), 1, 1, version: FileFormatVersions.Office2010)
                },
                new CompositeParticle.Builder(ParticleType.Choice, 0, 1000)
                {
                    new CompositeParticle.Builder(ParticleType.Group, 1, 1, version: FileFormatVersions.Office2010)
                    {
                        new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                        {
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroup), 1, 1, version: FileFormatVersions.Office2010),
                            new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroup), 1, 1, version: FileFormatVersions.Office2010)
                        }
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackstageGroups>(deep);
    }

    /// <summary>
    /// <para>Defines the SimpleGroups Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:secondColumn.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroup" /> <c>&lt;mso14:group></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroup" /> <c>&lt;mso14:taskGroup></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso14:secondColumn")]
    public partial class SimpleGroups : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the SimpleGroups class.
        /// </summary>
        public SimpleGroups() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SimpleGroups class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SimpleGroups(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SimpleGroups class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public SimpleGroups(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SimpleGroups class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public SimpleGroups(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso14:secondColumn");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroup>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroup>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Choice, 0, 1000)
            {
                new CompositeParticle.Builder(ParticleType.Group, 1, 1, version: FileFormatVersions.Office2010)
                {
                    new CompositeParticle.Builder(ParticleType.Choice, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroup), 1, 1, version: FileFormatVersions.Office2010),
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.TaskGroup), 1, 1, version: FileFormatVersions.Office2010)
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SimpleGroups>(deep);
    }

    /// <summary>
    /// <para>Defines the BackstageTab Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:tab.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroups" /> <c>&lt;mso14:firstColumn></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.SimpleGroups" /> <c>&lt;mso14:secondColumn></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso14:tab")]
    public partial class BackstageTab : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the BackstageTab class.
        /// </summary>
        public BackstageTab() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the BackstageTab class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BackstageTab(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BackstageTab class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public BackstageTab(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the BackstageTab class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public BackstageTab(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [SchemaAttr("idMso")]
        public StringValue? IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [SchemaAttr("insertAfterMso")]
        public StringValue? InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [SchemaAttr("insertBeforeMso")]
        public StringValue? InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [SchemaAttr("insertAfterQ")]
        public StringValue? InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [SchemaAttr("insertBeforeQ")]
        public StringValue? InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [SchemaAttr("getEnabled")]
        public StringValue? GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [SchemaAttr("getLabel")]
        public StringValue? GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [SchemaAttr("keytip")]
        public StringValue? Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [SchemaAttr("getKeytip")]
        public StringValue? GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>title, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: title</para>
        /// </summary>
        [SchemaAttr("title")]
        public StringValue? Title
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getTitle, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getTitle</para>
        /// </summary>
        [SchemaAttr("getTitle")]
        public StringValue? GetTitle
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>columnWidthPercent, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: columnWidthPercent</para>
        /// </summary>
        [SchemaAttr("columnWidthPercent")]
        public IntegerValue? ColumnWidthPercent
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>firstColumnMinWidth, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: firstColumnMinWidth</para>
        /// </summary>
        [SchemaAttr("firstColumnMinWidth")]
        public IntegerValue? FirstColumnMinWidth
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>firstColumnMaxWidth, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: firstColumnMaxWidth</para>
        /// </summary>
        [SchemaAttr("firstColumnMaxWidth")]
        public IntegerValue? FirstColumnMaxWidth
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>secondColumnMinWidth, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: secondColumnMinWidth</para>
        /// </summary>
        [SchemaAttr("secondColumnMinWidth")]
        public IntegerValue? SecondColumnMinWidth
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>secondColumnMaxWidth, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: secondColumnMaxWidth</para>
        /// </summary>
        [SchemaAttr("secondColumnMaxWidth")]
        public IntegerValue? SecondColumnMaxWidth
        {
            get => GetAttribute<IntegerValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso14:tab");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroups>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.SimpleGroups>();
            builder.AddElement<BackstageTab>()
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
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
.AddAttribute("title", a => a.Title, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("getTitle", a => a.GetTitle, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("columnWidthPercent", a => a.ColumnWidthPercent, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (1L), MaxInclusive = (99L), IsPositive = (true) });
})
.AddAttribute("firstColumnMinWidth", a => a.FirstColumnMinWidth, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (1L), MaxInclusive = (10000L), IsPositive = (true) });
})
.AddAttribute("firstColumnMaxWidth", a => a.FirstColumnMaxWidth, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (1L), MaxInclusive = (10000L), IsPositive = (true) });
})
.AddAttribute("secondColumnMinWidth", a => a.SecondColumnMinWidth, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (1L), MaxInclusive = (10000L), IsPositive = (true) });
})
.AddAttribute("secondColumnMaxWidth", a => a.SecondColumnMaxWidth, aBuilder =>
{
aBuilder.AddValidator(new NumberValidator() { MinInclusive = (1L), MaxInclusive = (10000L), IsPositive = (true) });
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroups), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.SimpleGroups), 0, 1, version: FileFormatVersions.Office2010)
            };
        }

        /// <summary>
        /// <para>BackstageGroups.</para>
        /// <para>Represents the following element tag in the schema: mso14:firstColumn.</para>
        /// </summary>
        /// <remark>
        /// xmlns:mso14 = http://schemas.microsoft.com/office/2009/07/customui
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroups? BackstageGroups
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroups>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>SimpleGroups.</para>
        /// <para>Represents the following element tag in the schema: mso14:secondColumn.</para>
        /// </summary>
        /// <remark>
        /// xmlns:mso14 = http://schemas.microsoft.com/office/2009/07/customui
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.CustomUI.SimpleGroups? SimpleGroups
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.CustomUI.SimpleGroups>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackstageTab>(deep);
    }

    /// <summary>
    /// <para>Defines the BackstageFastCommandButton Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:button.</para>
    /// </summary>
    [SchemaAttr("mso14:button")]
    public partial class BackstageFastCommandButton : OpenXmlLeafElement
    {
        /// <summary>
        /// Initializes a new instance of the BackstageFastCommandButton class.
        /// </summary>
        public BackstageFastCommandButton() : base()
        {
        }

        /// <summary>
        /// <para>idMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idMso</para>
        /// </summary>
        [SchemaAttr("idMso")]
        public StringValue? IdMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterMso</para>
        /// </summary>
        [SchemaAttr("insertAfterMso")]
        public StringValue? InsertAfterMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeMso</para>
        /// </summary>
        [SchemaAttr("insertBeforeMso")]
        public StringValue? InsertBeforeMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertAfterQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertAfterQ</para>
        /// </summary>
        [SchemaAttr("insertAfterQ")]
        public StringValue? InsertAfterQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>insertBeforeQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: insertBeforeQ</para>
        /// </summary>
        [SchemaAttr("insertBeforeQ")]
        public StringValue? InsertBeforeQulifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>id, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        [SchemaAttr("id")]
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>idQ, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: idQ</para>
        /// </summary>
        [SchemaAttr("idQ")]
        public StringValue? QualifiedId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>tag, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: tag</para>
        /// </summary>
        [SchemaAttr("tag")]
        public StringValue? Tag
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>onAction, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: onAction</para>
        /// </summary>
        [SchemaAttr("onAction")]
        public StringValue? OnAction
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>isDefinitive, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: isDefinitive</para>
        /// </summary>
        [SchemaAttr("isDefinitive")]
        public BooleanValue? IsDefinitive
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>enabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: enabled</para>
        /// </summary>
        [SchemaAttr("enabled")]
        public BooleanValue? Enabled
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getEnabled, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getEnabled</para>
        /// </summary>
        [SchemaAttr("getEnabled")]
        public StringValue? GetEnabled
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>label, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: label</para>
        /// </summary>
        [SchemaAttr("label")]
        public StringValue? Label
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getLabel, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getLabel</para>
        /// </summary>
        [SchemaAttr("getLabel")]
        public StringValue? GetLabel
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>visible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: visible</para>
        /// </summary>
        [SchemaAttr("visible")]
        public BooleanValue? Visible
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getVisible, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getVisible</para>
        /// </summary>
        [SchemaAttr("getVisible")]
        public StringValue? GetVisible
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>keytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: keytip</para>
        /// </summary>
        [SchemaAttr("keytip")]
        public StringValue? Keytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getKeytip, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getKeytip</para>
        /// </summary>
        [SchemaAttr("getKeytip")]
        public StringValue? GetKeytip
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>image, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: image</para>
        /// </summary>
        [SchemaAttr("image")]
        public StringValue? Image
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>imageMso, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: imageMso</para>
        /// </summary>
        [SchemaAttr("imageMso")]
        public StringValue? ImageMso
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>getImage, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: getImage</para>
        /// </summary>
        [SchemaAttr("getImage")]
        public StringValue? GetImage
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso14:button");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<BackstageFastCommandButton>()
.AddAttribute("idMso", a => a.IdMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterMso", a => a.InsertAfterMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeMso", a => a.InsertBeforeMso, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertAfterQ", a => a.InsertAfterQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("insertBeforeQ", a => a.InsertBeforeQulifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("id", a => a.Id, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsId = (true), IsToken = (true), IsNcName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("idQ", a => a.QualifiedId, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { IsQName = (true), MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("tag", a => a.Tag, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("onAction", a => a.OnAction, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("isDefinitive", a => a.IsDefinitive)
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
});
            builder.AddConstraint(new AttributeMutualExclusive("mso14:insertAfterMso", "mso14:insertAfterQ", "mso14:insertBeforeMso", "mso14:insertBeforeQ") { Version = FileFormatVersions.Office2010 });
            builder.AddConstraint(new AttributeMutualExclusive("mso14:size", "mso14:getSize") { Version = FileFormatVersions.Office2010 });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<BackstageFastCommandButton>(deep);
    }

    /// <summary>
    /// <para>Defines the Commands Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:commands.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.Command" /> <c>&lt;mso14:command></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso14:commands")]
    public partial class Commands : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Commands class.
        /// </summary>
        public Commands() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Commands class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Commands(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Commands class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Commands(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Commands class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Commands(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso14:commands");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.Command>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.Command), 1, 5000, version: FileFormatVersions.Office2010)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Commands>(deep);
    }

    /// <summary>
    /// <para>Defines the Ribbon Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:ribbon.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.ContextualTabs" /> <c>&lt;mso14:contextualTabs></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.QuickAccessToolbar" /> <c>&lt;mso14:qat></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.Tabs" /> <c>&lt;mso14:tabs></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso14:ribbon")]
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
        /// <para>startFromScratch, this property is only available in Office 2010 and later.</para>
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
            builder.SetSchema("mso14:ribbon");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.ContextualTabs>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.QuickAccessToolbar>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.Tabs>();
            builder.AddElement<Ribbon>()
.AddAttribute("startFromScratch", a => a.StartFromScratch);
            builder.Particle = new CompositeParticle.Builder(ParticleType.All, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.QuickAccessToolbar), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.Tabs), 0, 1, version: FileFormatVersions.Office2010),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ContextualTabs), 0, 1, version: FileFormatVersions.Office2010)
            };
        }

        /// <summary>
        /// <para>QuickAccessToolbar.</para>
        /// <para>Represents the following element tag in the schema: mso14:qat.</para>
        /// </summary>
        /// <remark>
        /// xmlns:mso14 = http://schemas.microsoft.com/office/2009/07/customui
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.CustomUI.QuickAccessToolbar? QuickAccessToolbar
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.CustomUI.QuickAccessToolbar>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>Tabs.</para>
        /// <para>Represents the following element tag in the schema: mso14:tabs.</para>
        /// </summary>
        /// <remark>
        /// xmlns:mso14 = http://schemas.microsoft.com/office/2009/07/customui
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.CustomUI.Tabs? Tabs
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.CustomUI.Tabs>();
            set => SetElement(value);
        }

        /// <summary>
        /// <para>ContextualTabs.</para>
        /// <para>Represents the following element tag in the schema: mso14:contextualTabs.</para>
        /// </summary>
        /// <remark>
        /// xmlns:mso14 = http://schemas.microsoft.com/office/2009/07/customui
        /// </remark>
        public DocumentFormat.OpenXml.Office2010.CustomUI.ContextualTabs? ContextualTabs
        {
            get => GetElement<DocumentFormat.OpenXml.Office2010.CustomUI.ContextualTabs>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Ribbon>(deep);
    }

    /// <summary>
    /// <para>Defines the Backstage Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:backstage.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.BackstageFastCommandButton" /> <c>&lt;mso14:button></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.BackstageTab" /> <c>&lt;mso14:tab></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso14:backstage")]
    public partial class Backstage : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Backstage class.
        /// </summary>
        public Backstage() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Backstage class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Backstage(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Backstage class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Backstage(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Backstage class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Backstage(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>onShow, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: onShow</para>
        /// </summary>
        [SchemaAttr("onShow")]
        public StringValue? OnShow
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>onHide, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: onHide</para>
        /// </summary>
        [SchemaAttr("onHide")]
        public StringValue? OnHide
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso14:backstage");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageFastCommandButton>();
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageTab>();
            builder.AddElement<Backstage>()
.AddAttribute("onShow", a => a.OnShow, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
})
.AddAttribute("onHide", a => a.OnHide, aBuilder =>
{
aBuilder.AddValidator(new StringValidator() { MinLength = (1L), MaxLength = (1024L) });
});
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Choice, 0, 255)
                {
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageTab), 1, 1, version: FileFormatVersions.Office2010),
                    new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageFastCommandButton), 1, 1, version: FileFormatVersions.Office2010)
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Backstage>(deep);
    }

    /// <summary>
    /// <para>Defines the ContextMenus Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is mso14:contextMenus.</para>
    /// </summary>
    /// <remark>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenu" /> <c>&lt;mso14:contextMenu></c></description></item>
    /// </list>
    /// </remark>
    [SchemaAttr("mso14:contextMenus")]
    public partial class ContextMenus : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ContextMenus class.
        /// </summary>
        public ContextMenus() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ContextMenus class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ContextMenus(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ContextMenus class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ContextMenus(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ContextMenus class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ContextMenus(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("mso14:contextMenus");
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddChild<DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenu>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office2010.CustomUI.ContextMenu), 1, 1000, version: FileFormatVersions.Office2010)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ContextMenus>(deep);
    }

    /// <summary>
    /// Defines the GalleryShowInRibbonValues enumeration.
    /// </summary>
    public enum GalleryShowInRibbonValues
    {
        /// <summary>
        /// false.
        /// <para>When the item is serialized out as xml, its value is "false".</para>
        /// </summary>
        [EnumString("false")]
        False,
        /// <summary>
        /// 0.
        /// <para>When the item is serialized out as xml, its value is "0".</para>
        /// </summary>
        [EnumString("0")]
        Zero
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

    /// <summary>
    /// Defines the TaskSizesValues enumeration.
    /// </summary>
    public enum TaskSizesValues
    {
        /// <summary>
        /// largeMediumSmall.
        /// <para>When the item is serialized out as xml, its value is "largeMediumSmall".</para>
        /// </summary>
        [EnumString("largeMediumSmall")]
        LargeMediumSmall,
        /// <summary>
        /// largeMedium.
        /// <para>When the item is serialized out as xml, its value is "largeMedium".</para>
        /// </summary>
        [EnumString("largeMedium")]
        LargeMedium,
        /// <summary>
        /// large.
        /// <para>When the item is serialized out as xml, its value is "large".</para>
        /// </summary>
        [EnumString("large")]
        Large,
        /// <summary>
        /// mediumSmall.
        /// <para>When the item is serialized out as xml, its value is "mediumSmall".</para>
        /// </summary>
        [EnumString("mediumSmall")]
        MediumSmall,
        /// <summary>
        /// medium.
        /// <para>When the item is serialized out as xml, its value is "medium".</para>
        /// </summary>
        [EnumString("medium")]
        Medium,
        /// <summary>
        /// small.
        /// <para>When the item is serialized out as xml, its value is "small".</para>
        /// </summary>
        [EnumString("small")]
        Small
    }

    /// <summary>
    /// Defines the ExpandValues enumeration.
    /// </summary>
    public enum ExpandValues
    {
        /// <summary>
        /// topLeft.
        /// <para>When the item is serialized out as xml, its value is "topLeft".</para>
        /// </summary>
        [EnumString("topLeft")]
        TopLeft,
        /// <summary>
        /// top.
        /// <para>When the item is serialized out as xml, its value is "top".</para>
        /// </summary>
        [EnumString("top")]
        Top,
        /// <summary>
        /// topRight.
        /// <para>When the item is serialized out as xml, its value is "topRight".</para>
        /// </summary>
        [EnumString("topRight")]
        TopRight,
        /// <summary>
        /// left.
        /// <para>When the item is serialized out as xml, its value is "left".</para>
        /// </summary>
        [EnumString("left")]
        Left,
        /// <summary>
        /// center.
        /// <para>When the item is serialized out as xml, its value is "center".</para>
        /// </summary>
        [EnumString("center")]
        Center,
        /// <summary>
        /// right.
        /// <para>When the item is serialized out as xml, its value is "right".</para>
        /// </summary>
        [EnumString("right")]
        Right,
        /// <summary>
        /// bottomLeft.
        /// <para>When the item is serialized out as xml, its value is "bottomLeft".</para>
        /// </summary>
        [EnumString("bottomLeft")]
        BottomLeft,
        /// <summary>
        /// bottom.
        /// <para>When the item is serialized out as xml, its value is "bottom".</para>
        /// </summary>
        [EnumString("bottom")]
        Bottom,
        /// <summary>
        /// bottomRight.
        /// <para>When the item is serialized out as xml, its value is "bottomRight".</para>
        /// </summary>
        [EnumString("bottomRight")]
        BottomRight
    }

    /// <summary>
    /// Defines the StyleValues enumeration.
    /// </summary>
    public enum StyleValues
    {
        /// <summary>
        /// normal.
        /// <para>When the item is serialized out as xml, its value is "normal".</para>
        /// </summary>
        [EnumString("normal")]
        Normal,
        /// <summary>
        /// warning.
        /// <para>When the item is serialized out as xml, its value is "warning".</para>
        /// </summary>
        [EnumString("warning")]
        Warning,
        /// <summary>
        /// error.
        /// <para>When the item is serialized out as xml, its value is "error".</para>
        /// </summary>
        [EnumString("error")]
        Error
    }

    /// <summary>
    /// Defines the Style2Values enumeration.
    /// </summary>
    public enum Style2Values
    {
        /// <summary>
        /// normal.
        /// <para>When the item is serialized out as xml, its value is "normal".</para>
        /// </summary>
        [EnumString("normal")]
        Normal,
        /// <summary>
        /// borderless.
        /// <para>When the item is serialized out as xml, its value is "borderless".</para>
        /// </summary>
        [EnumString("borderless")]
        Borderless,
        /// <summary>
        /// large.
        /// <para>When the item is serialized out as xml, its value is "large".</para>
        /// </summary>
        [EnumString("large")]
        Large
    }

    /// <summary>
    /// Defines the LayoutChildrenValues enumeration.
    /// </summary>
    public enum LayoutChildrenValues
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